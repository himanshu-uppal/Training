--Exercise 4
/* Create a function that takes as inputs a SalesOrderID, a Currency Code, and a date, and returns a table
  of all the SalesOrderDetail rows for that Sales Order including Quantity, ProductID, UnitPrice, and the 
  unit price converted to the target currency based on the end of day rate for the date provided. 
  Exchange rates can be found in the Sales.CurrencyRate table.  */


-- Function

USE AdventureWorks;

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION GetSalesOrderDetails(@OrderID int, @CurrencyCode varchar(3) , @cDate Date)

RETURNS TABLE 
AS
RETURN 
(	
	select sod.OrderQty, sod.ProductID, sod.UnitPrice*cr.EndOfDayRate as UnitPrice
	FROM Sales.SalesOrderDetail sod,Sales.CurrencyRate cr
	where SalesOrderID=@OrderID and
	cr.CurrencyRateDate = @cDate and
	cr.ToCurrencyCode = @CurrencyCode	
)
GO
-- Function Demo
go
Declare @cDate Date = '2011-05-31 00:00:00.000'
Declare @CCode varchar(3) = 'GBP'
select * from GetSalesOrderDetails(43659,@CCode,@cDate) 
go
go
