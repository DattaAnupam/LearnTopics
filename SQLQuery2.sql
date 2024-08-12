-- insert single values inside a table
INSERT INTO DESIGNATIONS VALUES(
	'.NET Developer'
);
GO

-- Insert multiple values inside table
INSERT INTO EMPLOYEES
	VALUES 
		('Anupam', 29, 1),
		('xyz', 30, 3),
		('abc', 24, 4),
		('pqr', 26, 3),
		('bapi', 27, 1),
		('ipab', 26, 4),
		('emp1', 34, 2),
		('emp2', 27, 3)
GO

-- Get all values from a table
SELECT * 
	FROM EMPLOYEES;
GO

-- Inner Join
SELECT * 
	FROM EMPLOYEES E
	INNER JOIN DESIGNATIONS D ON E.DesignationID=D.Id;
GO

-- Left Join
SELECT * 
	FROM EMPLOYEES E
	LEFT JOIN DESIGNATIONS D ON E.DesignationID=D.Id;
GO

-- Right Join
SELECT * 
	FROM EMPLOYEES E
	RIGHT JOIN DESIGNATIONS D ON E.DesignationID=D.Id;
GO
