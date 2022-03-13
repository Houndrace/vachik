-- Амиров 
CREATE DATABASE Автопрокат;
GO
USE Автопрокат;
GO
CREATE TABLE Клиент (
	Код INT IDENTITY(1,1) NOT NULL,
	ФИО NVARCHAR(MAX),
	СерияПаспорта NUMERIC(4,0),
	НомерПаспорта NUMERIC(6,0),

	PRIMARY KEY(Код)
);

CREATE TABLE Автомобиль (
	Код INT IDENTITY(1,1) NOT NULL,
	Модель NVARCHAR(MAX),
	Цвет NVARCHAR(40),
	ГодВыпуска NUMERIC(4,0),
	Госномер NVARCHAR(10),
	СтраховаяСтоимость NUMERIC(9,2),
	СтоимостьОдногоДня NUMERIC(6,2),
	ДатаНачалаПроката DATE,
	КолчествоДнейПроката NUMERIC(2,0),

	PRIMARY KEY(Код)
);

CREATE TABLE АвтомобильКлиент (
	Код INT IDENTITY(1,1) NOT NULL,
	КодКлиента INT NOT NULL,
	КодАвтомобиля INT NOT NULL,

	PRIMARY KEY(Код),
	CONSTRAINT FK_АвтомобильКлиент_Клиент FOREIGN KEY (КодКлиента)
	REFERENCES Клиент (Код),
	CONSTRAINT FK_АвтомобильКлиент_Автомобиль FOREIGN KEY (КодАвтомобиля)
	REFERENCES Автомобиль (Код)
	ON DELETE CASCADE ON UPDATE CASCADE
);

CREATE TABLE Прокат (
	Код INT IDENTITY(1,1) NOT NULL,
	Название NVARCHAR(MAX),
	ЮридическийАдрес NVARCHAR(255),

	PRIMARY KEY(Код),
);

CREATE TABLE АвтомобильКлиентПрокат (
	Код INT IDENTITY(1,1) NOT NULL,
	КодПроката INT NOT NULL,
	КодАвтомобильКлиента INT NOT NULL,

	PRIMARY KEY(Код),
	CONSTRAINT FK_АвтомобильПрокат_Прокат FOREIGN KEY (КодПроката)
	REFERENCES Прокат (Код),
	CONSTRAINT FK_АвтомобильПрокат_АвтомобильКлиент FOREIGN KEY (КодАвтомобильКлиента)
	REFERENCES АвтомобильКлиент (Код)
	ON DELETE CASCADE ON UPDATE CASCADE
);