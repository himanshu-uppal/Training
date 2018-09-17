-- Exercise 2
/* Write separate queries using a join, a subquery, a CTE, and then an EXISTS to list all AdventureWorks customers
   who have not placed an order. */
USE AdventureWorks;

-- Using Join
SELECT sc.CustomerID FROM Sales.Customer sc  
LEFT JOIN Sales.SalesOrderHeader soh ON soh.CustomerID = sc.CustomerID
WHERE soh.SalesOrderID IS NULL ORDER BY sc.CustomerID;

--Using Sub query
select sc.CustomerID from Sales.Customer sc  where sc.CustomerID not in (
select soh.CustomerID from Sales.SalesOrderHeader soh
 ) ORDER BY sc.CustomerID;

-- Using CTE
WITH CustomerDetailsCTE AS (select sc.CustomerID 'CustomerID',soh.SalesOrderID from  
Sales.Customer sc  
LEFT JOIN Sales.SalesOrderHeader soh ON soh.CustomerID = sc.CustomerID)
select cdCTE.CustomerID from CustomerDetailsCTE cdCTE
WHERE cdCTE.SalesOrderID IS NULL ORDER BY cdCTE.CustomerID;


--Using EXISTS
select sc.CustomerID from Sales.Customer sc  where NOT EXISTS (
select soh.CustomerID from Sales.SalesOrderHeader soh where soh.CustomerID = sc.CustomerID
 ) ORDER BY sc.CustomerID;