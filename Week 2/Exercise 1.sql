-- Exercise 1 
USE AdventureWorks;

-- Question 1
-- Display the number of records in the [SalesPerson] table. (Schema(s) involved: Sales)
SELECT COUNT(1) AS 'TotalRecords'
FROM Sales.SalesPerson; 

-- Question 2
/* Select both the FirstName and LastName of records from the Person table where the FirstName
   begins with the letter �B�. (Schema(s) involved: Person) */
SELECT p.FirstName as 'FirstName',p.LastName as 'LastName' 
FROM Person.Person p
WHERE p.FirstName LIKE 'B%';

-- Question 3
/* Select a list of FirstName and LastName for employees where Title is one of Design Engineer,
   Tool Designer or Marketing Assistant. (Schema(s) involved: HumanResources, Person) */
SELECT p.FirstName as 'FirstName',p.LastName as 'LastName' 
FROM Person.Person p 
JOIN HumanResources.Employee e 
ON p.BusinessEntityID = e.BusinessEntityID 
WHERE e.JobTitle IN ( 'Design Engineer' , 'Tool Designer' , 'Marketing Assistant');

-- Question 4
-- Display the Name and Color of the Product with the maximum weight. (Schema(s) involved: Production)
SELECT prod.Name ,prod.Color 
FROM Production.Product prod 
WHERE prod.Weight = (
						SELECT MAX(prod.Weight) 
						FROM Production.Product prod);  

-- Question 5
/* Display Description and MaxQty fields from the SpecialOffer table. Some of the MaxQty values are NULL,
   in this case display the value 0.00 instead. (Schema(s) involved: Sales) */ 
SELECT so.Description, ISNULL(so.MaxQty ,0.00 ) MaxQuantity 
FROM Sales.SpecialOffer so;

-- Question 6
/* Display the overall Average of the [CurrencyRate].[AverageRate] values for the exchange rate �USD� to �GBP�
   for the year 2005 i.e. FromCurrencyCode = �USD� and ToCurrencyCode = �GBP�. Note: The field 
   [CurrencyRate].[AverageRate] is defined as 'Average exchange rate for the day.' (Schema(s) involved: Sales) */
SELECT AVG(cr.AverageRate) AverageExchangeRate 
FROM Sales.CurrencyRate cr 
WHERE cr.FromCurrencyCode='USD' 
		AND cr.ToCurrencyCode='GBP' 
		AND YEAR(cr.CurrencyRateDate) = 2012;

-- Question 7
/* Display the FirstName and LastName of records from the Person table where FirstName contains the letters �ss�. 
   Display an additional column with sequential numbers for each row returned beginning at integer 1. 
   (Schema(s) involved: Person) */
SELECT ROW_NUMBER() OVER (ORDER BY p.BusinessEntityID ASC) Sequence_Number,p.FirstName, p.LastName 
FROM person.Person p 
WHERE p.FirstName LIKE '%ss%'; 

-- Question 8
/* Sales people receive various commission rates that belong to 1 of 4 bands. (Schema(s) involved: Sales)

CommissionPct	Commission Band
0.00			Band 0
Up To 1%		Band 1
Up To 1.5%		Band 2
Greater 1.5%	Band 3

Display the [SalesPersonID] with an additional column entitled �Commission Band� indicating the appropriate band as above.
 */
SELECT sp.BusinessEntityID,sp.CommissionPct,
CASE
 WHEN sp.CommissionPct = 0.00 THEN 'Band 0'
 WHEN sp.CommissionPct > 0.00 AND sp.CommissionPct <= 0.01 THEN 'Band 1'
 WHEN sp.CommissionPct > 0.01 AND sp.CommissionPct <= 0.015 THEN 'Band 2'
 ELSE 'Band 3'
 END
 'Commission Band'
 FROM Sales.SalesPerson sp;

-- Question 9
/* Display the managerial hierarchy from Ruth Ellerbrock (person type � EM) up to CEO Ken Sanchez.
   Hint: use [uspGetEmployeeManagers] (Schema(s) involved: [Person], [HumanResources])  */
DECLARE @PersonID int;
SELECT @PersonID =BusinessEntityID FROM Person.Person where FirstName='Ruth' AND LastName='Ellerbrock' AND PersonType='EM' ;
EXEC dbo.uspGetEmployeeManagers @PersonID

-- Question 10
/* Display the ProductId of the product with the largest stock level.
   Hint: Use the Scalar-valued function [dbo]. [UfnGetStock]. (Schema(s) involved: Production) */
SELECT p.ProductID 
FROM Production.Product p 
WHERE dbo.ufnGetStock(p.ProductID) = (
										SELECT MAX(dbo.ufnGetStock(p.ProductID)) 
										FROM Production.Product p);
