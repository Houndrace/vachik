-- Амиров 
CREATE DATABASE Кинопрокат
GO
USE Кинопрокат
GO
CREATE TABLE ИНН (
	Код INT IDENTITY(1,1) NOT NULL,
	Номер NVARCHAR(10),
	PRIMARY KEY(Код)
);

CREATE TABLE Поставщик (
	Код INT IDENTITY(1,1) NOT NULL,
	КодИНН INT NOT NULL,
	Имя NVARCHAR(40),
	ЮридическийАдрес NVARCHAR(40),
	Посредник NVARCHAR(40),
	PRIMARY KEY(Код),
	CONSTRAINT FK_Поставщик_ИНН FOREIGN KEY (КодИНН)
	REFERENCES ИНН (Код)
	ON DELETE CASCADE
	ON UPDATE CASCADE
);

CREATE TABLE Банк (
	Код INT IDENTITY(1,1) NOT NULL,
	Название NVARCHAR(40),
	PRIMARY KEY(Код)
);

CREATE TABLE Счет (
	Код INT IDENTITY(1,1) NOT NULL,
	КодБанка INT NOT NULL,
	КодИННВладельца INT NOT NULL,
	Номер INT,
	PRIMARY KEY(Код),
	CONSTRAINT FK_Счет_ИНН FOREIGN KEY (КодИННВладельца)
	REFERENCES ИНН (Код),
	CONSTRAINT FK_Счет_Банк FOREIGN KEY (КодБанка)
	REFERENCES Банк (Код)
	ON DELETE CASCADE
	ON UPDATE CASCADE
);

CREATE TABLE Кинотеатр (
	Код INT IDENTITY(1,1) NOT NULL,
	КодИНН INT NOT NULL,
	Адрес NVARCHAR(40),
	PRIMARY KEY (Код),
	CONSTRAINT FK_Кинотеатр_ИНН FOREIGN KEY (КодИНН)
	REFERENCES ИНН (Код)
	ON DELETE CASCADE
	ON UPDATE CASCADE
);

CREATE TABLE Кинозал (
	Код INT IDENTITY(1,1) NOT NULL,
	КодКинотеатра INT NOT NULL,
	Название NVARCHAR(40),
	ЧислоПосадочныхМест SMALLINT,
	PRIMARY KEY(Код),
	CONSTRAINT FK_Кинозал_Кинотеатр FOREIGN KEY (КодКинотеатра)
	REFERENCES Кинотеатр (Код)
	ON DELETE CASCADE
	ON UPDATE CASCADE
);

CREATE TABLE Компания (
	Код INT IDENTITY(1,1) NOT NULL,
	Название NVARCHAR(40),
	PRIMARY KEY (Код)
);

CREATE TABLE Кинофильм (
	Код INT IDENTITY(1,1) NOT NULL,
	КодПоставщика INT NOT NULL,
	КодКомпании INT NOT NULL,
	Название NVARCHAR(40),
	АвторСценария NVARCHAR(50),
	Содержание NVARCHAR(1000),
	РежиссерПоставщик NVARCHAR(50),
	ГодВыходаНаЭкран DATE,
	ЗатратыНаПроизводство NUMERIC(12,2),
	СтоимостьПриобретения NUMERIC(7,2),
	НаличиеДублирования BIT,
	PRIMARY KEY (Код),
	CONSTRAINT FK_Кинофильм_Поставщик FOREIGN KEY (КодПоставщика)
	REFERENCES Поставщик (Код),
	CONSTRAINT FK_Кинофльм_Компания FOREIGN KEY (КодКомпании)
	REFERENCES Компания (Код)
	ON DELETE CASCADE
	ON UPDATE CASCADE
);

CREATE TABLE КинофильмВКинотеатре (
	Код INT IDENTITY(1,1) NOT NULL,
	КодКинофильма INT NOT NULL,
	КодКинотеатра INT NOT NULL,
	PRIMARY KEY (Код),
	CONSTRAINT FK_КинофильмВКинотеатре_Кинофильм FOREIGN KEY (КодКинофильма)
	REFERENCES Кинофильм (Код),
	CONSTRAINT FK_КинофильмВКинотеатре_Кинотеатр FOREIGN KEY (КодКинотеатра)
	REFERENCES Кинотеатр (Код)
	ON DELETE CASCADE 
	ON UPDATE CASCADE
);

CREATE TABLE Демонстрация (
	Код INT IDENTITY(1,1) NOT NULL,
	КодФильмаВКинотеатре INT NOT NULL,
	Начало TIME,
	Окончание TIME,
	PRIMARY KEY (Код),
	CONSTRAINT FK_Демонстрация_КинофильмВКинотеатре FOREIGN KEY (КодФильмаВКинотеатре)
	REFERENCES КинофильмВКинотеатре (Код)
	ON DELETE CASCADE
	ON UPDATE CASCADE
);

CREATE TABLE Оплата (
	Код INT IDENTITY(1,1) NOT NULL,
	КодКинофильмаВКинотеатре INT NOT NULL,
	КодСчетаПлательщика INT NOT NULL,
	КодСчетаПолучателя INT NOT NULL,
	Стоимость NUMERIC(4,2),
	Пени NUMERIC(5,2),
	PRIMARY KEY (Код),
	CONSTRAINT FK_Оплата_КинофильмВКинотеатре FOREIGN KEY (КодКинофильмаВКинотеатре)
	REFERENCES КинофильмВКинотеатре (Код),
	CONSTRAINT FK_Оплата_СчетПлательщика FOREIGN KEY (КодСчетаПлательщика)
	REFERENCES Счет (Код),
	CONSTRAINT FK_Оплата_СчетПолучателя FOREIGN KEY (КодСчетаПолучателя)
	REFERENCES Счет (Код)
	ON DELETE CASCADE
	ON UPDATE CASCADE
);

CREATE TABLE Должность (
	Код INT IDENTITY(1,1) NOT NULL,
	Название NVARCHAR(40),
	PRIMARY KEY (Код)
);

CREATE TABLE Сотрудник (
	Код INT IDENTITY(1,1) NOT NULL,
	КодДолжности INT NOT NULL,
	ФИО NVARCHAR(50),
	PRIMARY KEY (Код),
	CONSTRAINT FK_Сотрудник_Должность FOREIGN KEY (КодДолжности)
	REFERENCES Должность (Код)
	ON DELETE CASCADE
	ON UPDATE CASCADE
);

CREATE TABLE СотрудникКинотеатра (
	Код INT IDENTITY(1,1) NOT NULL,
	КодКинотеатра INT NOT NULL,
	КодСотрудника INT NOT NULL,
	PRIMARY KEY (Код),
	CONSTRAINT FK_СотрудникКинотеатра_Кинотеатр FOREIGN KEY (КодКинотеатра)
	REFERENCES Кинотеатр (Код),
	CONSTRAINT FK_СотрудникКинотеатра_Сотрудник FOREIGN KEY (КодСотрудника)
	REFERENCES Сотрудник (Код)
	ON DELETE CASCADE
	ON UPDATE CASCADE
);

CREATE TABLE Телефон (
	Код INT IDENTITY(1,1) NOT NULL,
	КодСотрудникаКинотеатра INT NOT NULL,
	Номер NUMERIC(11,0),
	PRIMARY KEY (Код),
	CONSTRAINT FK_Телефон_СотрудникКинотеатра FOREIGN KEY (КодСотрудникаКинотеатра)
	REFERENCES СотрудникКинотеатра (Код)
	ON DELETE CASCADE
	ON UPDATE CASCADE
);