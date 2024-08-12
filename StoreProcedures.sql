-- Stored Procedure
-- ===================

-- Simple Stored Procedure
CREATE PROC	sp_select_employees
AS
	SELECT * 
		FROM EMPLOYEES;
GO

EXEC sp_select_employees;
GO

-- Store Procudure with Single parameter
CREATE PROC sp_select_employee @DesID int
AS
	SELECT * 
		FROM EMPLOYEES
		WHERE DesignationID=@DesID;
GO

EXEC sp_select_employee @DesID=3;
GO

-- Store Procedure with Default parameter
CREATE PROCEDURE sp_default_employee (@EmpID int = 1)
AS
BEGIN
	SELECT * FROM EMPLOYEES
	WHERE EmpID = @EmpID;
END
GO

-- Calling default stored procedure with default value
EXEC sp_default_employee;
GO
-- Calling default stored procedure with other value
EXEC sp_default_employee 3;
GO

-- Store Procedure with 'out' parameter

CREATE PROCEDURE sp_add_employee (@EmpName varchar(50), @EmpAge int, @EmpDesID int, @EmpID int output)
AS
BEGIN
	INSERT INTO EMPLOYEES VALUES(@EmpName, @EmpAge, @EmpDesID);
	SELECT @EmpID = SCOPE_IDENTITY() -- It returns the value of newly inserted data's identiy value
END
GO

-- execute above sp
DECLARE @EmpId INT
EXEC sp_add_employee 'New Employee 2', 22, 4, @EmpId OUTPUT
SELECT @EmpId AS EmpID;
GO

