-- Select city with minimum length, if there is more than once choose the first one
SELECT TOP 1 CITY, LEN(CITY) FROM STATION
    WHERE LEN(CITY) = (
        SELECT MIN(LEN(CITY)) FROM STATION
    )
    ORDER BY CITY ASC;
    
-- Select city with maximum length, if there is more than once choose the first one
SELECT TOP 1 CITY, LEN(CITY) FROM STATION
    WHERE LEN(CITY) = (
        SELECT MAX(LEN(CITY)) FROM STATION
    )
    ORDER BY CITY ASC;