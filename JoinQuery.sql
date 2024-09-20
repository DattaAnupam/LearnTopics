-- inner join
SELECT D.GroupName, EDH.BusinessEntityID, EDH.ShiftID
    FROM HumanResources.Department D
    INNER JOIN HumanResources.EmployeeDepartmentHistory EDH
        ON D.DepartmentID = EDH.DepartmentID

