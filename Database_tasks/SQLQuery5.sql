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
    Dno         INT            NOT NULL, 
    supervisor  CHAR(9)        NULL,     
    CONSTRAINT PK_Employee PRIMARY KEY (Ssn)
);
GO

CREATE TABLE Department (
    Dnumber           INT         NOT NULL,
    Dname             VARCHAR(50) NOT NULL UNIQUE,
    Mgr_ssn           CHAR(9)     NULL,
    Mgr_start_date    DATE        NULL,
    NumberOfEmployees INT         NOT NULL DEFAULT 0 CHECK (NumberOfEmployees >= 0),
    CONSTRAINT PK_Department PRIMARY KEY (Dnumber)
);
GO

CREATE TABLE Dept_Locations (
    Dnumber   INT         NOT NULL,
    Dlocation VARCHAR(50) NOT NULL,
    CONSTRAINT PK_Dept_Locations PRIMARY KEY (Dnumber, Dlocation)
);
GO

CREATE TABLE Project (
    Pnumber   INT         NOT NULL,
    Pname     VARCHAR(50) NOT NULL UNIQUE, 
    Plocation VARCHAR(50) NULL,
    Dnum      INT         NOT NULL,        
    CONSTRAINT PK_Project PRIMARY KEY (Pnumber)
);
GO


CREATE TABLE Works_On (
    Essn  CHAR(9)       NOT NULL,
    Pno   INT           NOT NULL,
    Hours DECIMAL(4, 1) NOT NULL DEFAULT 0.0 CHECK (Hours >= 0.0),
    CONSTRAINT PK_Works_On PRIMARY KEY (Essn, Pno)
);
GO


CREATE TABLE Dependent (
    Essn           CHAR(9)     NOT NULL,
    Dependent_name VARCHAR(50) NOT NULL,
    Sex            CHAR(1)     NULL CHECK (Sex IN ('M', 'F')),
    Bdate          DATE        NULL,
    Relationship   VARCHAR(20) NULL,
    CONSTRAINT PK_Dependent PRIMARY KEY (Essn, Dependent_name)
);
GO




ALTER TABLE Employee ADD CONSTRAINT FK_WORKS_FOR FOREIGN KEY (Dno) REFERENCES Department(Dnumber);


ALTER TABLE Employee ADD CONSTRAINT FK_SUPERVISION FOREIGN KEY (supervisor) REFERENCES Employee(Ssn);


ALTER TABLE Department ADD CONSTRAINT FK_MANAGES FOREIGN KEY (Mgr_ssn) REFERENCES Employee(Ssn);


ALTER TABLE Dept_Locations ADD CONSTRAINT FK_DeptLocations_Department FOREIGN KEY (Dnumber) REFERENCES Department(Dnumber);

ALTER TABLE Project ADD CONSTRAINT FK_CONTROLS FOREIGN KEY (Dnum) REFERENCES Department(Dnumber);

ALTER TABLE Works_On ADD CONSTRAINT FK_WORKS_ON_Employee FOREIGN KEY (Essn) REFERENCES Employee(Ssn);
ALTER TABLE Works_On ADD CONSTRAINT FK_WORKS_ON_Project FOREIGN KEY (Pno) REFERENCES Project(Pnumber);

ALTER TABLE Dependent ADD CONSTRAINT FK_DEPENDENTS_OF FOREIGN KEY (Essn) REFERENCES Employee(Ssn);
GO

INSERT INTO Department (Dnumber, Dname, Mgr_ssn, Mgr_start_date)
VALUES 
    (1, 'Engineering', NULL, '2023-01-15'),
    (2, 'Human Resources', NULL, '2022-06-01');

    INSERT INTO Employee (Ssn, Fname, Minit, Lname, Address, Sex, Bdate, Salary, Dno, supervisor)
VALUES 
    ('100000001', 'Ali', 'M', 'Al-Busaidi', 'Muscat', 'M', '1985-04-12', 3500.00, 1, NULL),
    ('100000002', 'Sara', 'A', 'Al-Harthy', 'Seeb', 'F', '1992-09-20', 2200.00, 1, '100000001');

    UPDATE Department 
SET Mgr_ssn = '100000001' 
WHERE Dnumber = 1;

INSERT INTO Project (Pnumber, Pname, Plocation, Dnum)
VALUES 
    (101, 'Cloud Migration', 'Muscat', 1),
    (102, 'HR Automation', 'Seeb', 2);

    INSERT INTO Works_On (Essn, Pno, Hours)
VALUES 
    ('100000002', 101, 25.5);

    INSERT INTO Dependent (Essn, Dependent_name, Sex, Bdate, Relationship)
VALUES 
    ('100000001', 'Aisha', 'F', '2015-05-10', 'Daughter');
GO

UPDATE Employee
SET Salary = Salary * 1.10
WHERE Ssn = '100000002';

UPDATE Employee
SET Dno = 2
WHERE Ssn = '100000002';

UPDATE Project
SET Plocation = 'Sohar'
WHERE Pnumber = 101;

UPDATE Works_On
SET Hours = 35.0
WHERE Essn = '100000002' AND Pno = 101;

ALTER TABLE Dependent 
    ALTER COLUMN Relationship VARCHAR(50) NULL;
GO

UPDATE Dependent
SET Relationship = 'Daughter (Legal Guardian)'
WHERE Essn = '100000001' AND Dependent_name = 'Aisha';
GO


-- Nullify foreign key references where Employee is a Manager
UPDATE Department
    SET Mgr_ssn = NULL
    WHERE Mgr_ssn = '100000001';
-- Nullify foreign keys where Employee is a Supervisor
    UPDATE Employee
    SET supervisor = NULL
    WHERE supervisor = '100000001';
-- Delete child records in dependent and junction tables
    DELETE FROM Dependent WHERE Essn = '100000001';
    DELETE FROM Works_On   WHERE Essn = '100000001';

-- delete the target Employee row
    DELETE FROM Employee
    WHERE Ssn = '100000001';