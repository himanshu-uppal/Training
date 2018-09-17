-- Exercise 6
/* Write a trigger for the Product table to ensure the list price can never be raised more than 15 Percent in a single 
  change. Modify the above trigger to execute its check code only if the ListPrice column is updated . */
USE AdventureWorks;

-- Assumption 
-- When the value of ListPrice column is 0.00, then all values are accepted from update statement

-- Update Trigger on every update
go
CREATE Trigger Production.ProductListPriceMonitored
ON Production.Product
FOR UPDATE
AS 
IF EXISTS
(		
    SELECT 'TRUE'
	FROM INSERTED new
	JOIN DELETED old
	ON old.ProductID = new.ProductID
	WHERE old.ListPrice <> 0 AND ((new.ListPrice - old.ListPrice)/old.ListPrice)*100 > 15	
	)
BEGIN
RAISERROR('Product List Price to be raised more than 15 percent is not allowed',16,1)
ROLLBACK TRAN
END
go

-- Update Trigger on ListPrice Update
go
ALTER Trigger Production.ProductListPriceMonitored
ON Production.Product
FOR UPDATE
AS 
BEGIN
 	DECLARE @oldListPrice float ;
	DECLARE @newListPrice float ;
	SELECT @oldListPrice = ListPrice FROM DELETED;
	SELECT @newListPrice = ListPrice FROM INSERTED;
	 	
	IF UPDATE(ListPrice)
		BEGIN
			IF  (@oldListPrice <> 0 AND ((@newListPrice - @oldListPrice)/@oldListPrice)*100 > 15)
			BEGIN			
				RAISERROR('Product List Price to be raised more than 15 percent is not allowed',16,1)
				ROLLBACK TRAN
			END 
	END
END
go

-- Update Trigger Demo


Update Production.Product SET ListPrice=1 ,Color='red3' where  ProductID=517;  

SELECT ProductID,ListPrice,Color FROM Production.Product  WHERE   ProductID=517; 

Update Production.Product SET ListPrice=160 ,Color='red4' where  ProductID in (517,518,519);  

SELECT ProductID,ListPrice,Color FROM Production.Product  WHERE   ProductID in (517,518,519);

SELECT ProductID,ListPrice,Color FROM Production.Product  WHERE  color='red3';

Update Production.Product SET ListPrice=130 ,Color='red4' where  color='redmnm312';
select * from Production.Product where color='redmnm3';