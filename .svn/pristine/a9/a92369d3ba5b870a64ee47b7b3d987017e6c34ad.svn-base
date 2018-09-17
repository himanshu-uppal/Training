--Exercise 5
/* Write a Procedure supplying name information from the Person.Person table and accepting a filter for the first name. 
   Alter the above Store Procedure to supply Default Values if user does not enter any value.( Use AdventureWorks) */

-- Procedure 
USE AdventureWorks;
GO
CREATE PROC GetPersonDetailsByFirstName
@FirstName nvarchar(50)
AS
begin
SELECT  p.FirstName + ',' + p.LastName Name, e.JobTitle, e.HireDate
FROM Person.Person p
JOIN HumanResources.Employee e
ON p. BusinessEntityID = e.BusinessEntityID
WHERE p.FirstName LIKE @FirstName + '%'
end
go

GO
ALTER PROC GetPersonDetailsByFirstName
@FirstName nvarchar(50) = 'a'
AS
begin
SELECT  p.FirstName + ',' + p.LastName Name, e.JobTitle, e.HireDate
FROM Person.Person p
JOIN HumanResources.Employee e
ON p. BusinessEntityID = e.BusinessEntityID
WHERE p.FirstName LIKE @FirstName + '%'
end
go

-- GetPersonDetailsByFirstName Demo
go
[dbo].[GetPersonDetailsByFirstName] 'James'
go
