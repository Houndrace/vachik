-- ?????? 
CREATE DATABASE ??????????;
GO
USE ??????????;
GO
CREATE TABLE ?????? (
	??? INT IDENTITY(1,1) NOT NULL,
	??? NVARCHAR(MAX),
	????????????? NUMERIC(4,0),
	????????????? NUMERIC(6,0),

	PRIMARY KEY(???)
);

CREATE TABLE ?????????? (
	??? INT IDENTITY(1,1) NOT NULL,
	?????? NVARCHAR(MAX),
	???? NVARCHAR(40),
	?????????? NUMERIC(4,0),
	???????? NVARCHAR(10),
	?????????????????? NUMERIC(9,0),
	?????????????????? NUMERIC(6,0),

	PRIMARY KEY(???)
);

CREATE TABLE ???????????????? (
	??? INT IDENTITY(1,1) NOT NULL,
	?????????? INT NOT NULL,
	????????????? INT NOT NULL,
	????????????????? DATE,
	???????????????????? NUMERIC(2,0),

	PRIMARY KEY(???),
	CONSTRAINT FK_????????????????_?????? FOREIGN KEY (??????????)
	REFERENCES ?????? (???),
	CONSTRAINT FK_????????????????_?????????? FOREIGN KEY (?????????????)
	REFERENCES ?????????? (???)
	ON DELETE CASCADE ON UPDATE CASCADE
);

CREATE TABLE ?????? (
	??? INT IDENTITY(1,1) NOT NULL,
	???????? NVARCHAR(MAX),
	???????????????? NVARCHAR(255),

	PRIMARY KEY(???)
);

CREATE TABLE ?????????????????????? (
	??? INT IDENTITY(1,1) NOT NULL,
	???????????????????? INT NOT NULL,
	?????????? INT NOT NULL,

	PRIMARY KEY(???),
	CONSTRAINT FK_??????????????????????_?????? FOREIGN KEY (??????????)
	REFERENCES ?????? (???),
	CONSTRAINT FK_??????????????????????_???????????????? FOREIGN KEY (????????????????????)
	REFERENCES ???????????????? (???)
	ON DELETE CASCADE ON UPDATE CASCADE
);
GO
INSERT INTO ??????????
	VALUES	('VW Golf', '?????', 2012, '?224??69', 400000, 10500),
			('Toyota Yaris', '???????', 2012, '?820??69', 700000, 10500),
			('Mercedes Benz GLC Class', '?????', 2006, '?340??69', 600000, 20500),
			('Buick Encore', '?????', 2008, '?720??69', 700000, 4500),
			('Nissan Rogue', '?????????', 2013, '?016??69', 400000, 8500),
			('Alfa Romeo Giulia', '???????', 2014, '?761??69', 400000, 16500),
			('Land Rover Discovery', '?????', 2015, 'A777KTR69', 200000, 4500),
			('Kia Ceed', '?????', 2011, '?340??69', 600000, 12500),
			('Volvo V40', '?????', 2010, '?350??69', 200000, 8500),
			('Ford Focus', '?????', 2007, '?648??69', 500000, 6500);
SELECT * FROM ??????????;
GO
INSERT INTO ??????
	VALUES	('???????? ?????? ???????', 2135, 449835),
			('???????? ???????? ??????????????', 2764, 168723),
			('???????? ???? ?????????', 3628, 566373),
			('??????? ????????? ???????', 2455, 503417),
			('????? ??????? ????????', 3844, 307527),
			('??????? ?????? ?????????', 3015, 898452),
			('?????? ?????? ?????????', 3624, 582544),
			('?????????? ???????? ?????????', 3496, 815274),
			('????????? ????????? ?????????', 2242, 258435),
			('???????? ????? ??????????', 3904, 753323);
SELECT * FROM ??????;
GO
INSERT INTO ????????????????
	VALUES	(1, 1, '2020-01-14', 14),
			(2, 2, '2020-05-28', 7),
			(3, 3, '2020-04-20', 60),
			(4, 2, '2020-06-21', 30),
			(5, 1, '2020-02-17', 30),
			(6, 4, '2020-04-21', 14),
			(2, 4, '2020-06-12', 14),
			(7, 5, '2020-04-13', 30),
			(8, 4, '2020-05-06', 30),
			(2, 6, '2020-04-16', 30),
			(3, 7, '2020-06-21', 7),
			(5, 8, '2020-01-22', 14),
			(9, 7, '2020-04-15', 60),
			(3, 8, '2020-07-05', 14),
			(4, 9, '2020-04-20', 60),
			(7, 7, '2020-05-17', 7),
			(1, 4, '2020-01-29', 14),
			(10, 2, '2020-04-14', 14),
			(8, 10, '2020-04-17', 14);
SELECT * FROM ????????????????;
GO
INSERT INTO ??????
	VALUES	('????????????', '904375, ????????? ???????, ????? ???????, ??. ???????, 35'),
			('????????', '571918, ????????? ???????, ????? ???????, ????? ????????, 61'),
			('????????', '364103, ???????????? ???????, ????? ???????????, ?????? ????????, 75'),
			('??????', '668122, ??????? ???????, ????? ??????, ??. ???????????, 29'),
			('???????????????', '991191, ?????????? ???????, ????? ????????, ???. ?????????????, 82'),
			('????????????', '989257, ?????????? ???????, ????? ???????, ????? ?????, 62'),
			('???????????????', '233714, ????????? ???????, ????? ٸ?????, ??????? ?????????????, 68'),
			('?????????????', '755529, ???????? ???????, ????? ?????, ??????? ????????, 80'),
			('???????', '581930, ?????? ???????, ????? ????????, ????? ??????, 35'),
			('???????', '179308, ????????? ???????, ????? ٸ?????, ??. ??????????, 01');
SELECT * FROM ??????;
GO
INSERT INTO ??????????????????????
	VALUES	(1, 1),
			(2, 2),
			(3, 3),
			(4, 4),
			(5, 5),
			(6, 6),
			(7, 7),
			(8, 8),
			(9, 2),
			(10, 2),
			(11, 3),
			(12, 5),
			(13, 4),
			(14, 3),
			(15, 4),
			(16, 8),
			(17, 1),
			(18, 9),
			(19, 2);
SELECT * FROM ??????????????????????;