--DROP
--DROP DATABASE CoffeeShop

--DROP TABLE Store;
--DROP TABLE Coffee;
--DROP TABLE OrderNumber;
--DROP TABLE Customer;

--To create database
CREATE DATABASE CoffeeShop

-----Tables
CREATE TABLE Store
(
    StoreID INT PRIMARY KEY,
    StoreLocation VARCHAR(20) NOT NULL
);

CREATE TABLE Inventory
(
	InvnetoryID INT PRIMARY KEY,
	StoreID INT FOREIGN KEY REFERENCES Store(StoreID),
	Quantity INT, 
	CoffeeID INT FOREIGN KEY REFERENCES Coffee(ProductID) 
	
	--Inventory StoreId Quantity CoffeeID Products
	--1			1		10			1
	--3			1		5			4
	--2			2		20			1	
);

CREATE TABLE Coffee
(
    ProductID INT PRIMARY KEY,
    Size VARCHAR (100),
    Price MONEY NOT NULL,

);

CREATE TABLE [Order]
(
    OrderID INT PRIMARY KEY,
	CustomerId INT FOREIGN KEY REFERENCES Customer(CustomerID),
    Quantity INT NOT NULL,
    PRICE MONEY NOT NULL

);

CREATE TABLE Customer
(
    CustomerId INT NOT NULL IDENTITY, --PK
    FirstName NVARCHAR(40) NOT NULL,
    LastName NVARCHAR(20) NOT NULL,
	Email NVARCHAR(20) NOT NULL,
    Phone NVARCHAR(24),
    CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED ([CustomerId])
);

SELECT * FROM Store;
SELECT * FROM Coffee;
SELECT * FROM [Order];

INSERT Coffee
	(ProductID, Size, Price)
VALUES
	(1, [Small], 2),
	(2, [Medium], 3),
	(3, [Large], 5);

INSERT [Order]
	(OrderID, Quantity, Price)
VALUES
	(1, 3, 6),
	(2,  1,	3),
	(3, 2, 15);
	
