Notes:
========
- Order how we write SQL clauses-
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

- For Multiple ORDER BYs SQL evaluates from Right to Left. For example
    - For examlple in the above sql query SQL will order the result by 'lastname'.
    And then when both the lastnames will have same name it will order them by the firstname.

## Joins

### <ins>Inner Join:</ins>

- Syntax
    ````sql
    SELECT [Column_1], [Column_2], ...
    FROM [Table_1] [Table_1_Alias_Name]
    INNER JOIN [Table_2] [Table_2_Alias_Name]
    ON [Table_1_Alias_Name].[Column_Name] = [Table_2_Alias_Name].[Column_Name]
    ````

- Examlple:
    ````sql
    SELECT *
    FROM Student s
    INNER JOIN Dept d
    ON s.Dept_ID = d.DeptId
    ````


