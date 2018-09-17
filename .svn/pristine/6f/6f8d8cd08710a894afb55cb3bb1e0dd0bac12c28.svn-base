-- Exercise 3
/* Show the most recent five orders that were purchased from account numbers that have
   spent more than $70,000 with AdventureWorks. */
USE AdventureWorks;

-- TOP 5 orders among all account numbers

select TOP 5 soh.SalesOrderID,Soh.AccountNumber,soh.CustomerID,soh.OrderDate,soh.TotalDue FROM Sales.SalesOrderHeader soh
where soh.AccountNumber in (SELECT soh.AccountNumber
FROM Sales.SalesOrderHeader soh
GROUP BY soh.AccountNumber
HAVING SUM(soh.TotalDue) > 70000) ORDER BY soh.OrderDate DESC;


--TOP 5 orders of each account number


WITH RankedOrders AS (
select soh.SalesOrderID,soh.AccountNumber,soh.CustomerID,soh.OrderDate,
ROW_NUMBER() Over (PARTiTION BY soh.AccountNumber ORDER BY soh.OrderDate DESC) as RecentOrderRank
FROM Sales.SalesOrderHeader soh
where soh.AccountNumber in (SELECT soh.AccountNumber
FROM Sales.SalesOrderHeader soh
GROUP BY soh.AccountNumber
HAVING SUM(soh.TotalDue) > 70000) )
SELECT ro.RecentOrderRank,ro.AccountNumber,ro.SalesOrderID,ro.OrderDate,ro.CustomerID
FROM RankedOrders ro
WHERE ro.RecentOrderRank in (1,2,3,4,5);
