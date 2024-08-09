-- Check the list tables inside a database
SELECT name 
	FROM sys.tables;
GO

-- Create table with Primary key with auto increment property
CREATE TABLE EMPLOYEES(
	EmpID int IDENTITY(1,1) PRIMARY KEY,
	EmpName varchar(50) NOT NULL,
	Designation varchar(max) NOT NULL,
	Age int
);
GO

CREATE TABLE DESIGNATIONS(
	Id int IDENTITY(1,1) PRIMARY KEY,
	Degsignation varchar(50) NOT NULL
);
GO

-- Add a new Column inside existing table
ALTER TABLE EMPLOYEES
	ADD DesignationID int;
GO

-- Drop a Column from a table
ALTER TABLE EMPLOYEES
	DROP COLUMN Designation;
GO

-- Check description of a Table
EXEC sp_columns EMPLOYEES;
GO

-- Change column name in a Table
EXEC sp_rename 'DESIGNATIONS.Degsignation','Designation';
GO

-- Make a column as Foreign Key
ALTER TABLE EMPLOYEES
	ADD FOREIGN KEY (DesignationID) REFERENCES DESIGNATIONS(Id);
GO
