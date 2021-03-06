--/*
ALTER PROCEDURE [dbo].[sp_Aging_Due_Calc]
	@pDoc_Fiscal_ID int,
	@Ac_Id INT,
	@PDebit numeric OUTPUT,
	@PLess15 numeric OUTPUT,
	@PLess30 numeric OUTPUT,
	@PLess45 numeric OUTPUT,
	@PLess60 numeric OUTPUT,
	@PLess75 numeric OUTPUT,
	@PLess90 numeric OUTPUT,
	@PAbove numeric OUTPUT,
	@PDate char(10)
AS
--*/
/*
DECLARE	
	@pDoc_Fiscal_ID int,
	@Ac_Id INT,
	@PCode char(14),
	@PDebit numeric ,
	@PLess15 numeric,
	@PLess30 numeric,
	@PLess45 numeric,
	@PLess60 numeric,
	@PLess75 numeric,
	@PLess90 numeric,
	@PAbove numeric,
	@PDate char(10)

SET @pDoc_Fiscal_ID=1
SET @Ac_ID= 456 --684 --230  --440
SET @PCode =  '1-2-03-01-0072' --'1-2-03-01-0058'
SET @PDebit =0
SET @PLess15 =0
SET @PLess30 =0
SET @PLess45 =0
SET @PLess60 =0
SET @PLess75 =0
SET @PLess90 =0
SET @PAbove =0
SET @PDate = '2013-09-15'
*/

SET NOCOUNT ON
--EXECUTE DueLedCur_Cheq @PCode
	--Select Date, IsNull(Debit,0) From Ledger
	--Where Code = @PCode AND isNull(Cheq_No,'') Not IN (Select Cheq_No From Ledger 
	--			Where Code=@PCode AND Type='RBR' 
	--			AND isNull(Cheq_No,'') IN (Select Cheq_No From Ledger 
	--			Where Code=@PCode AND Type='BRV'
	--			AND isNull(Cheq_No,'')<>''))
	--Order By Date
	DECLARE DueLedgerCheq_Cur CURSOR FOR
	SELECT t.doc_date, isNull(td.DEBIT,0), td.SERIAL_NO
			FROM gl_tran t INNER JOIN gl_trandtl td ON t.doc_vt_id=td.doc_vt_id
				AND t.doc_fiscal_id=td.doc_fiscal_id AND t.doc_id=td.doc_id
			WHERE t.doc_fiscal_id=@pDoc_Fiscal_ID
				AND td.AC_ID=@Ac_ID
	ORDER BY t.doc_date

	OPEN DueLedgerCheq_Cur

	DECLARE @mDate datetime, @mDebit MONEY, @mCredit MONEY, @mVar MONEY, @mAmountVar MONEY
	DECLARE @CreditDayCalc INT, @SERIAL_NO BIGINT

	--Select @mCredit = (select Sum(IsNull(Credit,0))
	--		From Ledger WHERE Code=@PCode --AND Type<>'RBR'
	--		AND isNull(Cheq_No,'') Not IN (Select Cheq_No From Ledger 
	--			Where Code=@PCode AND Type='RBR' AND isNull(Cheq_No,'')<>''))

	SELECT @mCredit = (SELECT Round(Sum(isNull(td.Credit,0)),2) 
			FROM gl_tran t INNER JOIN gl_trandtl td ON t.doc_vt_id=td.doc_vt_id
				AND t.doc_fiscal_id=td.doc_fiscal_id AND t.doc_id=td.doc_id
			WHERE t.doc_fiscal_id=@pDoc_Fiscal_ID
				AND td.AC_ID=@Ac_ID)

	FETCH NEXT FROM DueLedgerCheq_Cur INTO @mDate, @mDebit, @SERIAL_NO
	WHILE @@FETCH_STATUS=0
	BEGIN
--PRINT ' Date : ' + Cast(@mDate AS Varchar) + ' ++ Debit: ' + Cast(@mDebit AS Varchar) + ' -- Credit: ' + Cast(@mCredit AS Varchar)  + ' ##Serial ##: ' + Cast(@Serial_No AS Varchar)

		SET @mVar = 0
		SET @mAmountVar =0

		IF @mCredit>0
			BEGIN
				IF @mCredit>@mDebit
					BEGIN
						SET @mVar = 0
						SET @mAmountVar = 0
						SET @mCredit = @mCredit - @mDebit
					END
				ELSE
					BEGIN
						--print 'Credit : ' + Cast(@mCredit AS Varchar)
						SET @mVar = @mDebit - @mCredit
						SET @mAmountVar = @mDebit - @mCredit
						SET @mCredit = 0
						--print 'Balance : ' + Cast(@mVar AS Varchar)
					END
			END
		ELSE
			BEGIN 
				SET @mVar = @mDebit
				SET @mAmountVar = @mDebit
			END
			
		SET @CreditDayCalc = DATEDIFF(DAY, @mDate, @PDate) 
		--PRINT ' Credit Day Calc : ' + CAST(@CreditDayCalc AS VARCHAR(10)) 
		--	+ ' Amount : ' + CAST(@mAmountVar AS VARCHAR(20))
		
		IF @CreditDayCalc < 15 SET @PLess15 = @PLess15 + @mAmountVar
		IF (@CreditDayCalc > 14 And @CreditDayCalc<30) SET @PLess30 = @PLess30 + @mAmountVar
		IF (@CreditDayCalc > 29 And @CreditDayCalc<45) SET @PLess45 = @PLess45 + @mAmountVar
		IF (@CreditDayCalc > 44 And @CreditDayCalc<60) SET @PLess60 = @PLess60 + @mAmountVar
		IF (@CreditDayCalc > 59 And @CreditDayCalc<75) SET @PLess75 = @PLess75 + @mAmountVar
		IF (@CreditDayCalc > 74 And @CreditDayCalc<90) SET @PLess90 = @PLess90 + @mAmountVar
		IF @CreditDayCalc >90 SET @PAbove = @PAbove + @mAmountVar

				--IF @CreditDayCalc < 15 SET @PLess15 = @PLess15 + @mVar
				--IF (@CreditDayCalc > 14 And @CreditDayCalc<30) SET @PLess30 = @PLess30 + @mVar
				--IF (@CreditDayCalc > 29 And @CreditDayCalc<45) SET @PLess45 = @PLess45 + @mVar
				--IF (@CreditDayCalc > 44 And @CreditDayCalc<60) SET @PLess60 = @PLess60 + @mVar
				--IF (@CreditDayCalc > 59 And @CreditDayCalc<75) SET @PLess75 = @PLess75 + @mVar
				--IF (@CreditDayCalc > 74 And @CreditDayCalc<90) SET @PLess90 = @PLess90 + @mVar
				--IF @CreditDayCalc >90 SET @PAbove = @PAbove + @mVar

--Print @PCode +' '+ Cast(@PDebit AS Varchar) +' : 15 Day : '+ Cast(@PLess15 AS Varchar)  +' : 30 Day : '+ Cast(@PLess30 AS Varchar)  
--Print Cast(@PLess45 AS Varchar)  +' : 60 Day : '+  Cast(@PLess60 AS Varchar) 
--Print Cast(@PLess75 AS Varchar) +' : 90 Day : '+ Cast(@PLess90  AS Varchar) +' : Above : '+ Cast(@PAbove  AS Varchar) +' : PDate : '+ Cast(@PDate AS Varchar) 
--PRINT ''

		FETCH NEXT FROM DueLedgerCheq_Cur INTO @mDate, @mDebit, @SERIAL_NO
	END

CLOSE DueLedgerCheq_Cur
DEALLOCATE DueLedgerCheq_Cur
RETURN

SET NOCOUNT OFF






