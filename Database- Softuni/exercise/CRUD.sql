USE SoftUni
--2
SELECT * FROM Departments

--3
USE SoftUni
SELECT [Name] FROM Departments

--4
SELECT [FirstName], [LastName],[Salary] FROM Employees

--5
SELECT [FirstName],[MiddleName],[LastName] FROM Employees

--6
SELECT [FirstName]+'.'+[LastName]+'@softuni.bg' AS [Full Email Address] FROM Employees

--7
SELECT DISTINCT Salary FROM Employees

--8
SELECT * FROM Employees 
	WHERE [JobTitle]='Sales Representative'

--9
USE SoftUni
SELECT FirstName, LastName,JobTitle FROM Employees	
	WHERE Salary >= 20000 AND Salary <= 30000

--10
SELECT FirstName+' '+MiddleName+' '+LastName AS [Full Name] FROM Employees
	WHERE Salary=25000 OR Salary=14000 OR Salary=12500 OR Salary=23600

	--or
SELECT FirstName+' '+MiddleName+' '+LastName AS [Full Name] FROM Employees
	WHERE Salary IN (25000,14000,12500,23600)
--11
SELECT FirstName, LastName FROm Employees 
	WHERE ManagerID IS NULL

--12
 

--13
SELECT TOP(5) FirstName, LastName FROM Employees
	ORDER BY Salary DESC
--14
SELECT FirstName,LastName FROM Employees
	WHERE DepartmentID != 4

--15
SELECT * FROM Employees	
ORDER BY Salary DESC, FirstName ASC, LastName DESC, MiddleName ASC

--16
CREATE VIEW V_EmployeesSalaries AS
	SELECT FirstName,LastName,Salary FROM [dbo].[Employees]

--17
CREATE VIEW V_EmployeeNameJobTitle AS
	SELECT (FirstName+' '+(ISNULL(MiddleName,''))+' '+LastName) 
	AS FullName, JobTitle FROM Employees
	
--18
SELECT DISTINCT JobTitle FROM Employees	

--19
SELECT TOP(10) * FROM Projects
	ORDER BY StartDate ASC, [Name] ASC

--20
SELECT TOP(7) FirstName,LastName,HireDate FROM Employees
	ORDER BY HireDate DESC

--21
SELECT * FROM Employees
SELECT * FROM Departments

 UPDATE Employees
 SET Salary *= 1.12
 WHERE DepartmentID IN (1, 2, 4, 11)

 SELECT Salary FROM Employees

 --22
 USE [Geography]
 SELECT PeakName FROM Peaks

 --23
 SELECT * FROM Countries

 SELECT TOP(30) CountryName, Population FROM Countries
	WHERE ContinentCode='EU'
	ORDER BY Population DESC, CountryName ASC

--24
USE Geography
SELECT CountryName,CountryCode,
	(Case 
		WHEN CurrencyCode='EUR' THEN 'Euro'
		ELSE 'Not Euro'
		END) AS Currency
	 FROM Countries
	 ORDER BY CountryName ASC
--25
USE Diablo
SELECT [Name] FROM Characters
	ORDER BY [Name] ASC