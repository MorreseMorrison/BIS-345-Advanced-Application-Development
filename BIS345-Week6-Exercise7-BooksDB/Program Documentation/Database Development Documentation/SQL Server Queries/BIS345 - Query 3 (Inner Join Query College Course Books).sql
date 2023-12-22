SELECT  CourseBookTable.Course_Number AS "Course Number", PeirceCollegeCourseCatalogTable.Course_Name AS "Course Number", BookTable.Title AS "Text Book Title", 
BookTable.ISBN  AS "Text Book 10-Digit ISBN Number"
FROM ((BookTable
INNER JOIN CourseBookTable ON BookTable.ISBN = CourseBookTable.ISBN)
INNER JOIN PeirceCollegeCourseCatalogTable ON CourseBookTable.Course_Number = PeirceCollegeCourseCatalogTable.Course_Number);