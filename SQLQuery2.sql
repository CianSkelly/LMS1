drop table Book;
drop table LibUser;
drop table BookOnLoan;

CREATE TABLE	Book (
	BookID int PRIMARY KEY IDENTITY,
	ISBN varchar(255) NOT NULL,
	Title varchar(255) NOT NULL,
	DateofPublication Datetime NOT NULL,

	);

	INSERT INTO BOOK VALUES ('9781911274872', 'Go F*ck Yourself, Cian!','January 2018')
	INSERT INTO BOOK VALUES ('9780230605831', 'Renegotiation of the Just War Tradition and the Right to War in the Twenty-First Century','May 2008')

CREATE TABLE	LibUser (
	UserID		int PRIMARY KEY IDENTITY,
	FirstName	varchar(255) NOT NULL,
	LastName	varchar(255) NOT NULL,
	UserName	varchar(255) NOT NULL,
	Email		varchar(255) NOT NULL,
	Phone		varchar(255),

	);
	INSERT INTO LibUser VALUES ('Joe', 'Bloggs','Bloggs_Joe', 'joe@hotmail.ie','0857356284')
	INSERT INTO LibUser VALUES ('Jane', 'Floggs','Floggs_Jane', 'jane.Floggs@gmail.com','0865839531')

	CREATE TABLE	BookOnLoan (
	OnLoanID			int PRIMARY KEY IDENTITY,
	UserID				varchar(255) NOT NULL,
	BookID				varchar(255) NOT NULL,
	DateIssued			Datetime NOT NULL,
	DateDueForReturn	Datetime NOT Null,
	ActualDateReturned	Datetime,
	CONSTRAINT FK_BookID FOREIGN KEY (BookID)
	REFERENCES Book(BookID),
	CONSTRAINT FK_UserID FOREIGN KEY (UserID)
	REFERENCES LibUser(UserID),
	 
	 );

	INSERT INTO BookOnLoan VALUES ('1', '1','14 March 2018', '21 March 2018')
	INSERT INTO BookOnLoan VALUES ('2', '2','12 February 2018', '19 February 2018','18 February 2018')
