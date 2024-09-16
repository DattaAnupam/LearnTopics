Notes:
========
- Order how we use SQL clauses-
    - SELECT
    - FROM
    - WHERE
    - GROUP BY
    - HAVING
    - ORDER BY
    
- Order how SQL evaluates SQL clauses - 
    - FROM
    - WHERE
    - GROUP BY
    - HAVING
    - SELECT
    - ORDER BY


- Use Order By with multiple columns
     ````sql
    SELECT [Column_1], [Column_2], ...
    FROM [Table_name]
    ORDER BY [Column_1] [ASC/DESC], [Column_2] [ASC/DESC]
    ````
    Example:
    ````sql
    SELECT FirstName, LastName, Age
    FROM Employees
    ORDER BY FirstName, LastName DESC
    ````
