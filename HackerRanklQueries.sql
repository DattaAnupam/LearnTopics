-- Get the Students name who got marks > 75
-- Order them by last three characters of their name
-- If last three characters are same then order by ID in descending
SELECT Id, Name 
FROM dbo.Students
WHERE Marks > 75
ORDER BY RIGHT(Name, 3), Id DESC
GO
