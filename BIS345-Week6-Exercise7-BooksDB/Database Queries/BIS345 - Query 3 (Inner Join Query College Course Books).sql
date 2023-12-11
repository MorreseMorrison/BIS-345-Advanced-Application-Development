SELECT  CourseBookTable.Course_Number, PeirceCollegeCourseCatalogTable.Course_Name, BookTable.Title, BookTable.ISBN 
FROM ((BookTable
INNER JOIN CourseBookTable ON BookTable.ISBN = CourseBookTable.ISBN)
INNER JOIN PeirceCollegeCourseCatalogTable ON CourseBookTable.Course_Number = PeirceCollegeCourseCatalogTable.Course_Number);