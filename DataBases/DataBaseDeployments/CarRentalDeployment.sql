-- ������ 
CREATE DATABASE ����������;
GO
USE ����������;
GO
CREATE TABLE ������ (
	��� INT IDENTITY(1,1) NOT NULL,
	��� NVARCHAR(MAX),
	������������� NUMERIC(4,0),
	������������� NUMERIC(6,0),

	PRIMARY KEY(���)
);

CREATE TABLE ���������� (
	��� INT IDENTITY(1,1) NOT NULL,
	������ NVARCHAR(MAX),
	���� NVARCHAR(40),
	���������� NUMERIC(4,0),
	�������� NVARCHAR(10),
	������������������ NUMERIC(9,2),
	������������������ NUMERIC(6,2),
	����������������� DATE,
	�������������������� NUMERIC(2,0),

	PRIMARY KEY(���)
);

CREATE TABLE ���������������� (
	��� INT IDENTITY(1,1) NOT NULL,
	���������� INT NOT NULL,
	������������� INT NOT NULL,

	PRIMARY KEY(���),
	CONSTRAINT FK_����������������_������ FOREIGN KEY (����������)
	REFERENCES ������ (���),
	CONSTRAINT FK_����������������_���������� FOREIGN KEY (�������������)
	REFERENCES ���������� (���)
	ON DELETE CASCADE ON UPDATE CASCADE
);

CREATE TABLE ������ (
	��� INT IDENTITY(1,1) NOT NULL,
	�������� NVARCHAR(MAX),
	���������������� NVARCHAR(255),

	PRIMARY KEY(���),
);

CREATE TABLE ���������������������� (
	��� INT IDENTITY(1,1) NOT NULL,
	���������� INT NOT NULL,
	�������������������� INT NOT NULL,

	PRIMARY KEY(���),
	CONSTRAINT FK_����������������_������ FOREIGN KEY (����������)
	REFERENCES ������ (���),
	CONSTRAINT FK_����������������_���������������� FOREIGN KEY (��������������������)
	REFERENCES ���������������� (���)
	ON DELETE CASCADE ON UPDATE CASCADE
);