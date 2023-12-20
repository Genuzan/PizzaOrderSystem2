
use pizzadbase;

CREATE TABLE Pizzas (
    PizzaID INT PRIMARY KEY IDENTITY(1,1),
    PizzaName NVARCHAR(50) NOT NULL,
    Price DECIMAL(10, 2) NOT NULL
);
 
CREATE TABLE Customers (
    CustomerID INT PRIMARY KEY IDENTITY(1,1),
    CustomerName NVARCHAR(50) NOT NULL,
    PhoneNumber NVARCHAR(20) NOT NULL,
    CustomerAddress NVARCHAR(100)
);

CREATE TABLE [Order]  (
    OrderID INT PRIMARY KEY IDENTITY(1,1),
    CustomerID INT FOREIGN KEY REFERENCES Customers(CustomerID),
    OrderDate DATETIME CONSTRAINT DF_Order_OrderDate DEFAULT GETDATE(),
	Status NVARCHAR(50) NOT NULL DEFAULT 'Pending',
	DriverID INT NULL,
	CONSTRAINT FK_Order_Driver FOREIGN KEY (DriverID) REFERENCES Drivers(DriverID),
    CONSTRAINT FK_Order_Customer FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID);
);

CREATE TABLE OrderDetail (
    OrderDetailID INT PRIMARY KEY IDENTITY(1,1),
    OrderID INT FOREIGN KEY REFERENCES [Order](OrderID),
    PizzaID INT FOREIGN KEY REFERENCES Pizzas(PizzaID),
    Quantity INT NOT NULL,
    CONSTRAINT FK_OrderDetail_Order FOREIGN KEY (OrderID) REFERENCES [Order](OrderID),
    CONSTRAINT FK_OrderDetail_Pizza FOREIGN KEY (PizzaID) REFERENCES Pizzas(PizzaID)
);
ALTER TABLE [Order]
ADD CONSTAINT DF_Order_OrderDate DEFAULT GETDATE() FOR OrderDate;

ALTER TABLE [Order]
ADD Status NVARCHAR(50) NOT NULL DEFAULT 'Pending';

-- Add DriverID column to [Order] table
ALTER TABLE [Order]
ADD DriverID INT NULL;

-- Add foreign key constraint for DriverID
ALTER TABLE [Order]
ADD CONSTRAINT FK_Order_Driver FOREIGN KEY (DriverID) REFERENCES Drivers(DriverID);



ALTER TABLE OrderDetail
ADD CONSTRAINT FK_OrderDetail_Pizza
FOREIGN KEY (PizzaID) REFERENCES Pizzas(PizzaID);

=
 
delete from Customers where CustomerID = 75;
select * from Customers; 

select * from [order];
select * from OrderDetail;
select * from Pizzas;
select * from Customers



select * from CUstomer_PhoneNumber;

select * from [order] 
left join Customers on [order].CustomerID = Customers.CustomerID;

select * from OrderDetail
inner join [order] on OrderDetail.OrderID = [order].OrderID
inner join Pizzas on OrderDetail.PizzaID = Pizzas.PizzaID;


select PizzaName as 'Pizza Name', Quantity from OrderDetail
inner join Pizzas on OrderDetail.PizzaID = Pizzas.PizzaID;

delete from Customers where CustomerID = 96;
delete from [order] where OrderID = 96;
delete from OrderDetail where OrderID = 96;
 