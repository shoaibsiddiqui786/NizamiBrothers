--/*
ALTER PROCEDURE [dbo].[sp_Item_MfgClosing] 
	@pDoc_Fiscal_ID int,
	@pFromDate Varchar(10), 
	@pToDate Varchar(10),
	@pGodown INT,
	@pCT_ID int 
	
AS 
--*/
/*
DECLARE @pDoc_Fiscal_ID int,
	@pFromDate Varchar(10), 
	@pToDate Varchar(10), 
	@pGodown INT,
	--@pUOMID INT,
	@pCT_ID int
 
	set @pDoc_Fiscal_ID=1
	set @pFromDate='2012-11-01'
	set @pToDate = '2012-11-30'
	SET @pGodown=4
	--SET @pUOMID=0
	SET @pCT_ID=1
*/

SELECT m.ItemID, m.goodsitem_title as ItemName, m.UOMID, m.Goodsuom_st,
	--m.Godown_title, m.OpBalance, 
	m.Qty_In, m.Qty_Out, m.Balance, isNull(ctd.WastePAge,0) AS WastePAge, 0 AS WasteLessQty,
	0 AS WasteableQty, 0 AS WasteQty, 0 AS WithoutLabQty, 0 AS LabCharge,
	isNull(ctd.Rate,0) AS LabourRate, 0 AS LabCharges,  
	m.MeshTotal, isNull(ctd.MeshRate,0) AS MeshRate, 0 AS Amount
FROM 
(

	SELECT x.ItemID, x.goodsitem_title, x.goodsitem_st, x.Group_Title, x.Group_st,
	x.UOMID, x.Goodsuom_st, x.Godown_title, Sum(x.OpBalance) AS OpBalance, 
	Sum(x.Qty_In) AS Qty_In, Sum(x.Qty_Out) AS Qty_Out, 
	--Sum(x.OpBalance) + 
	Sum(x.Qty_Out) - Sum(x.Qty_In) AS Balance, 
	Sum(x.MeshTotal) AS MeshTotal, Sum(x.Bundle) AS Bundle, 
	x.Group_st + '' + x.goodsitem_st AS ItemName
	FROM (

		SELECT td.ItemID, gi.goodsitem_title, gi.goodsitem_st, gg.Group_title, gg.Group_st,
		td.UOMID, u.goodsuom_st, 
		g.Godown_title, Sum(isNull(td.Qty_In,0))-Sum(ISNULL(td.Qty_Out,0)) AS OpBalance, 
		0 AS Qty_In, 0 AS Qty_Out, 0 AS Balance, 
		0 AS MeshTotal, 0 AS Bundle
		FROM inv_tran t INNER JOIN inv_trandtl td ON t.doc_vt_id=td.doc_vt_id
		AND t.doc_fiscal_id=td.doc_fiscal_id AND t.doc_id=td.doc_id
		INNER JOIN gds_item gi ON gi.goodsitem_id=td.ItemID
		INNER JOIN gds_Group gg ON gg.Group_id=gi.Group_id
		INNER JOIN gds_uom u ON td.UOMID=u.goodsuom_id
		INNER JOIN cmn_Godown g ON td.GodownID=g.Godown_id
		WHERE t.doc_fiscal_id=@pDoc_Fiscal_ID 
			AND t.doc_date < @pFromDate  
			AND (@pGodown>0 AND td.GodownID=@pGodown OR @pGodown=0)
			--AND (@pUOMID>0 AND td.UOMID=@pUOMID OR @pUOMID=0)
		GROUP BY td.ItemID, gi.goodsitem_title, gi.goodsitem_st, gg.Group_title,gg.Group_st,
		td.UOMID, u.goodsuom_st, g.Godown_title
		UNION 
		SELECT td.ItemID, gi.goodsitem_title, gi.goodsitem_st, gg.Group_title, gg.Group_st,
		td.UOMID, u.goodsuom_st, 
		g.Godown_title, 0 AS OpBalance, Sum(isNull(td.Qty_In,0)) AS Qty_In,
		Sum(ISNULL(td.Qty_Out,0)) AS Qty_Out, 0 AS Balance, 
		Sum(isNull(td.MeshTotal,0)) AS MeshTotal, Sum(ISNULL(td.Bundle,0)) AS Bundle
		FROM inv_tran t INNER JOIN inv_trandtl td ON t.doc_vt_id=td.doc_vt_id
		AND t.doc_fiscal_id=td.doc_fiscal_id AND t.doc_id=td.doc_id
		INNER JOIN gds_item gi ON gi.goodsitem_id=td.ItemID
		INNER JOIN gds_Group gg ON gg.Group_id=gi.Group_id
		INNER JOIN gds_uom u ON td.UOMID=u.goodsuom_id
		INNER JOIN cmn_Godown g ON td.GodownID=g.Godown_id
		WHERE t.doc_fiscal_id=@pDoc_Fiscal_ID 
			AND t.doc_date BETWEEN @pFromDate AND @pToDate 
			AND (@pGodown>0 AND td.GodownID=@pGodown OR @pGodown=0)
			--AND (@pUOMID>0 AND td.UOMID=@pUOMID OR @pUOMID=0)
		GROUP BY td.ItemID, gi.goodsitem_title, gi.goodsitem_st, gg.Group_title, gg.Group_st,
		td.UOMID, u.goodsuom_st, g.Godown_title

	)x 
	GROUP BY x.ItemID, x.goodsitem_title, x.goodsitem_st, x.Group_title, x.Group_st,
	x.UOMID, x.goodsuom_st, x.Godown_title

)m	
	LEFT OUTER JOIN ct_tran ct ON ct.doc_vt_id=280 AND ct.doc_fiscal_id=1 
	AND ct.doc_ID=@pCT_ID 
	left outer JOIN ct_trandtl ctd ON ct.doc_vt_id=ctd.doc_vt_id 
	AND ct.doc_fiscal_id=ctd.doc_fiscal_id AND ct.doc_id=ctd.doc_id
	AND m.ItemID=ctd.ItemID AND m.UOMID=ctd.UOMID
WHERE m.Balance<>0

/*
SELECT * FROM ct_tran 
SELECT * FROM ct_trandtl 
SELECT * FROM mfg_tran 
*/
	
--SET NOCOUNT ON
select ID, Name, Photo from Photos where id=28;

--SET NOCOUNT OFF

DECLARE 
	@pAc_ID INT, 
	@pDoc_Vt_ID_Ext INT, 
	@pDoc_Vt_ID_Mfg int  
 
	SELECT @pAc_ID =Godown_ac_id FROM cmn_Godown WHERE Godown_id = @pGodown;

	--SET @pAc_ID =141
	SET @pDoc_Vt_ID_Ext = 288
	SET @pDoc_Vt_ID_Mfg = 286
	
EXEC sp_MfgSum 	@pDoc_Fiscal_ID,
	@pFromDate, @pToDate, 
	@pAc_ID, @pDoc_Vt_ID_Ext, @pDoc_Vt_ID_Mfg
	
EXEC sp_StockSum @pDoc_Fiscal_ID,
	@pFromDate, @pToDate, @pGodown
	
	