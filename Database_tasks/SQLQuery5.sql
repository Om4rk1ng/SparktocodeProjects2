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