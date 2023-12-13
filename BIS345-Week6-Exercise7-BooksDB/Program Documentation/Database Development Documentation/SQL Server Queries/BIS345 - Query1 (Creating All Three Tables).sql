CREATE TABLE dbo.BookTable (
    Book_ID INT IDENTITY(1,1) NOT NULL ,
	ISBN INT NOT NULL UNIQUE,
	TITLE VARCHAR(255) NOT NULL,
	Copyright_Date DATE NOT NULL,
	Primary_Author VARCHAR(255) NOT NULL,
	Publisher VARCHAR(255) NOT NULL,
	Number_Of_Pages INT NOT NULL,

	/* Primary Key*/
	PRIMARY KEY (Book_ID),
	/* Primary Key*/


    )
	
CREATE TABLE dbo.CourseBookTable (
    
	ISBN INT NOT NULL,
	Course_Number INT NOT NULL UNIQUE,

	/* Primary Key*/
	PRIMARY KEY (ISBN),
	/* Primary Key*/

    )

CREATE TABLE dbo.PeirceCollegeCourseCatalogTable (
    
	Course_Number INT NOT NULL UNIQUE,
	Course_Name VARCHAR(255) NOT NULL UNIQUE,

	/* Primary Key*/
	PRIMARY KEY (Course_Number),
	/* Primary Key*/


    )