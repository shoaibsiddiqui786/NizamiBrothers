--/*
ALTER PROCEDURE [dbo].[sp_Aging_Due_Rep]
	@pDoc_Fiscal_ID int,
	@pac_id INT, 
	@pFromDate VARCHAR(10), 
	@pToDate VARCHAR(10)

AS
--*/
/*
DECLARE @pDoc_Fiscal_ID int,
	@pac_id INT, 
	@pFromDate VARCHAR(10), 
	@pToDate VARCHAR(10)

SET @pDoc_Fiscal_ID=1
SET @pac_id=7
SET @pFromDate='2012-08-25'
SET @pToDate = '2013-10-28' 
*/

SET NOCOUNT ON

DECLARE @Ac_Id INT, @Ac_Title VARCHAR(200), @Ac_St VARCHAR(15), @Ac_strID VARCHAR(30)
DECLARE @ac_strtruncated VARCHAR(30)
DECLARE @ac_level INT, @ac_stridParent VARCHAR(30), @ac_titleParent VARCHAR(100)

--DECLARE @OpRunBal MONEY, @Op_DEBIT MONEY, @Op_CREDIT MONEY, @DEBIT MONEY, @CREDIT MONEY, 
--    @Balance MONEY, @SERIAL_NO BIGINT
--DECLARE @MonthDoc_Date INT, @YearDoc_Date INT, @DateMonthName VARCHAR(30)

--SET @SERIAL_NO=1
DECLARE @strac_get AS VARCHAR(30)

SELECT @ac_id=ac_id, @ac_strid=ac_strid, @ac_stridParent=ac_strid, 
	@ac_titleParent=ac_title, @ac_level=ac_level
  FROM gl_ac WHERE ac_id=@pac_id

SELECT @ac_strtruncated= CASE WHEN Right(@ac_strid,12)='0-00-00-0000' THEN Left(@ac_strid,1) 
	WHEN  Right(@ac_strid,10)='00-00-0000' THEN Left(@ac_strid,3) 
	WHEN  Right(@ac_strid,7)='00-0000' THEN Left(@ac_strid,6)
	WHEN  Right(@ac_strid,4)='0000' THEN Left(@ac_strid,9)
	ELSE '' END 
	
PRINT @ac_strtruncated

SET @strac_get = LEFT(@ac_strid, LEN(@ac_strtruncated))
--PRINT @strac_get

--EXECUTE GrpSelected_Ac @Para_Code, @Para_No

CREATE TABLE #tmpTable (
	Ac_Id INT, 
	Ac_Title VARCHAR(200), 
	Ac_St VARCHAR(15),
	Ac_strID VARCHAR(30),
	Debit money,
	Credit money,
	Less15 money,
	Less30 money,
	Less45 money,
	Less60 money,
	Less75 money,
	Less90 money,
	Above money
)


DECLARE cur_gl_ac CURSOR FOR
SELECT g.ac_id, g.ac_title + ' ' + g.ac_st + ' ' + c.city_title AS Ac_Title, g.ac_st, g.ac_strid
  FROM gl_ac g INNER JOIN geo_city c ON g.ac_city_id=c.city_id 
WHERE LEFT(g.ac_strid, LEN(@ac_strtruncated))=@strac_get
	AND g.istran=1
ORDER BY g.ac_strid 

OPEN cur_gl_ac

	DECLARE @mDebit MONEY, @mCredit MONEY
	DECLARE @mLess15 MONEY, @mLess30 MONEY, @mLess45 MONEY, @mLess60 MONEY, @mLess75 MONEY
	DECLARE @mLess90 MONEY, @mAbove MONEY, @mBal MONEY

	FETCH NEXT FROM cur_gl_ac INTO @Ac_Id, @Ac_Title, @Ac_St, @Ac_strID
	WHILE @@FETCH_STATUS=0
	BEGIN
		SET @mCredit =0
		SET @mDebit =0
		SET @mLess15 = 0
		SET @mLess30 = 0
		SET @mLess45 = 0
		SET @mLess60 = 0
		SET @mLess75 = 0
		SET @mLess90 = 0
		SET @mAbove = 0

		select @mBal = (SELECT ISNULL(Sum(isNull(td.DEBIT,0)- ISNULL(td.CREDIT,0)),0) 
			FROM gl_tran t INNER JOIN gl_trandtl td ON t.doc_vt_id=td.doc_vt_id
				AND t.doc_fiscal_id=td.doc_fiscal_id AND t.doc_id=td.doc_id
			WHERE t.doc_fiscal_id=@pDoc_Fiscal_ID
				AND td.AC_ID=@Ac_ID
				AND t.doc_date <= @pToDate) 

		IF @mBal>0
		BEGIN
			EXEC sp_Aging_Due_Calc @pDoc_Fiscal_ID, @Ac_Id, @mDebit OUTPUT,
				@mLess15 OUTPUT, @mLess30 OUTPUT, @mLess45 OUTPUT, 
				@mLess60 OUTPUT, @mLess75 OUTPUT,
				@mLess90 OUTPUT, @mAbove OUTPUT, @pToDate
			
			--EXEC DueLedgerCalcCheqNew @mCode, @mDebit OUTPUT,
			--	@mLess15 OUTPUT, @mLess30 OUTPUT, @mLess45 OUTPUT, 
			--	@mLess60 OUTPUT, @mLess75 OUTPUT,
			--	@mLess90 OUTPUT, @mAbove OUTPUT, @PDate
		END

		IF @mBal<0
		BEGIN
			SET @mCredit = ABS(@mBal)
			SET @mBal = 0
		END

		IF @mBal>0 Or @mCredit>0 Or @mLess15>0 Or @mLess30>0 Or @mLess45>0 Or @mLess60>0 
				   Or @mLess75>0 Or @mLess90>0 Or @mAbove>0
			INSERT INTO #tmpTable Values (@Ac_Id, @Ac_Title, @Ac_St, @Ac_strID, @mBal, @mCredit,
				@mLess15, @mLess30, @mLess45, @mLess60, @mLess75, @mLess90, @mAbove)

		FETCH NEXT FROM cur_gl_ac INTO @Ac_Id, @Ac_Title, @Ac_St, @Ac_strID
	END

CLOSE cur_gl_ac
DEALLOCATE cur_gl_ac
Select * from #tmpTable ORDER BY Ac_Title
Drop Table #tmpTable

select ID, Name, Photo from Photos where id=28;

SET NOCOUNT OFF







