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

-- Query the list of CITY names starting with vowels (i.e., a, e, i, o, or u) from STATION
SELECT DISTINCT(CITY) FROM STATION
    WHERE LEFT(CITY, 1)='a' OR LEFT(CITY, 1)='e' OR LEFT(CITY, 1)='i' OR LEFT(CITY, 1)='o' OR LEFT(CITY, 1)='u'

-- Query the list of CITY names ending with vowels (i.e., a, e, i, o, or u) from STATION
SELECT DISTINCT(CITY) FROM STATION
    WHERE  RIGHT(CITY, 1)='a' OR  RIGHT(CITY, 1)='e' OR  RIGHT(CITY, 1)='i' OR  RIGHT(CITY, 1)='o' OR  RIGHT(CITY, 1)='u'

-- Select the list of cities that are not starting with a vowel
Select Distinct CITY From STATION
    Where CITY NOT LIKE '[AEIOU]%'

-- Query the list of CITY names from STATION that do not end with vowels. Your result cannot contain duplicates.
Select Distinct CITY From STATION
    Where CITY NOT LIKE '%[AEIOU]'