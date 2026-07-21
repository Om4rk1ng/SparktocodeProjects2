CREATE DATABASE CompanyDB;
GO

USE CompanyDB;
GO

CREATE TABLE Employee (
    Ssn         CHAR(9)        NOT NULL,
    Fname       VARCHAR(50)    NOT NULL,
    Minit       CHAR(1)        NULL,
    Lname       VARCHAR(50)    NOT NULL,
    Address     VARCHAR(100)   NULL,
    Sex         CHAR(1)        NULL CHECK (Sex IN ('M', 'F')),
    Bdate       DATE           NULL,
    Salary      DECIMAL(10, 2) NULL CHECK (Salary > 0),
    Dno         INT            NULL,
    supervisor  CHAR(9)        NULL,
    CONSTRAINT PK_Employee PRIMARY KEY (Ssn)
);

CREATE TABLE Department (
    Dnumber           INT         NOT NULL,
    Dname             VARCHAR(50) NOT NULL UNIQUE,
    Mgr_ssn           CHAR(9)     NULL,
    Mgr_start_date    DATE        NULL,
    NumberOfEmployees INT         NOT NULL DEFAULT 0 CHECK (NumberOfEmployees >= 0),
    CONSTRAINT PK_Department PRIMARY KEY (Dnumber)
);

CREATE TABLE Dept_Locations (
    Dnumber   INT         NOT NULL,
    Dlocation VARCHAR(50) NOT NULL,
    CONSTRAINT PK_Dept_Locations PRIMARY KEY (Dnumber, Dlocation)
);

CREATE TABLE Project (
    Pnumber   INT         NOT NULL,
    Pname     VARCHAR(50) NOT NULL UNIQUE,
    Plocation VARCHAR(50) NULL,
    Dnum      INT         NOT NULL,
    CONSTRAINT PK_Project PRIMARY KEY (Pnumber)
);

CREATE TABLE Dependent (
    Essn           CHAR(9)     NOT NULL,
    Dependent_name VARCHAR(50) NOT NULL,
    Sex            CHAR(1)     NULL CHECK (Sex IN ('M', 'F')),
    Bdate          DATE        NULL,
    Relationship   VARCHAR(20) NULL,
    CONSTRAINT PK_Dependent PRIMARY KEY (Essn, Dependent_name)
);

CREATE TABLE Works_On (
    Essn  CHAR(9)       NOT NULL,
    Pno   INT           NOT NULL,
    Hours DECIMAL(4, 1) NOT NULL DEFAULT 0.0 CHECK (Hours >= 0.0),
    CONSTRAINT PK_Works_On PRIMARY KEY (Essn, Pno)
);