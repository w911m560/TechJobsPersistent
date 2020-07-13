--Part 1
	--'Id' int AI PK; 
	--'Name' longtext; 
	--'EmployerId' int
--Part 2
	SELECT *
	FROM employers
	WHERE location="St. Louis City"
--Part 3
	SELECT Name, Description
	FROM jobskills 
	LEFT JOIN skills ON jobskills.SkillId = skills.Id 
	ORDER BY Name

