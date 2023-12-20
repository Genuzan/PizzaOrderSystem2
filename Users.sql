use pizzadbase;

CREATE TABLE Users (
    UserID INT PRIMARY KEY IDENTITY(1,1),
    Username NVARCHAR(50) NOT NULL, 
    PhoneNumber NVARCHAR(20) NOT NULL,
    PasswordHash NVARCHAR(255),
    Salt NVARCHAR(255),
    JobPosition NVARCHAR(50) -- Add the JobPosition column
);

-- Drivers Table
CREATE TABLE Drivers (
    DriverID INT PRIMARY KEY IDENTITY(1,1),
    DriverUsername NVARCHAR(50) NOT NULL, 
    PhoneNumber NVARCHAR(20) NOT NULL,
    PasswordHash NVARCHAR(255),
    Salt NVARCHAR(255),
    JobPosition NVARCHAR(50) -- Add the JobPosition column
);

CREATE TABLE Admins (
    AdminID INT PRIMARY KEY IDENTITY(1,1),
    AdminUsername NVARCHAR(50) NOT NULL, 
    PhoneNumber NVARCHAR(20) NOT NULL,
    PasswordHash NVARCHAR(255), 
    Salt NVARCHAR(255),
    JobPosition NVARCHAR(50) NOT NULL DEFAULT 'Admin' 
);

ALTER TABLE Users
ADD JobPosition NVARCHAR(50);

-- Add JobPosition column to Drivers table
ALTER TABLE Drivers
ADD JobPosition NVARCHAR(50);

UPDATE Users
SET JobPosition = 'Staff'
WHERE UserID = 2;

update Drivers set JobPosition = 'Driver'
where DriverID = 1;

ALTER TABLE Users
ADD PasswordHash NVARCHAR(255), 
    Salt NVARCHAR(255);

ALTER TABLE Users
DROP COLUMN [Password];


select * from Users
select * from Drivers
select * from Admins;

INSERT INTO Admins (AdminUsername, PasswordHash, Salt)
VALUES ('admin', 'hashed_password', 'salt_value');