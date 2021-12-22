--To create database
--CREATE DATABASE LotsOfCupsDB
--To Drop
--DROP DATABASE LotsOFCUpsDB

--DROP TABLE Store;
--DROP TABLE Products;
--DROP TABLE OrderNumber;
--DROP TABLE Customer;
--Tables

CREATE TABLE Store
(
    StoreID INT (1,1) PRIMARY KEY,
    StoreLocation VARCHAR(20) NOT NULL
);

CREATE TABLE Products
(
    ProductID INT (100) PRIMARY KEY,
    Details VARCHAR (50),
    Price MONEY NOT NULL,

);

CREATE TABLE OrderNumber
(
    OrderID INT (100) NOT NULL PRIMARY KEY,
    Quantity INT (100) NOT NULL,
    PRICE MONEY NOT NULL,
    

    --FK should be customer id
);

CREATE TABLE Customer
(
    CustomerId INT NOT NULL IDENTITY, --PK
    FirstName NVARCHAR(40) NOT NULL,
    LastName NVARCHAR(20) NOT NULL,
    MailingAddress NVARCHAR(70),
    Phone NVARCHAR(24),
    Email NVARCHAR(60) NOT NULL,
    CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED ([CustomerId])
);