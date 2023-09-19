CREATE TABLE Categories (
    CategoryID INT PRIMARY KEY,
    CategoryName NVARCHAR(255) NOT NULL
);
CREATE TABLE Products (
    ProductID INT PRIMARY KEY,
    ProductName NVARCHAR(255) NOT NULL
);

CREATE TABLE ProductCategory (
    ProductID INT,
    CategoryID INT,
    FOREIGN KEY (ProductID) REFERENCES Products(ProductID),
    FOREIGN KEY (CategoryID) REFERENCES Categories(CategoryID)
);

INSERT INTO Categories (CategoryID, CategoryName)
VALUES (1, '��������� 1'),
       (2, '��������� 2'),
       (3, '��������� 3');

INSERT INTO Products (ProductID, ProductName)
VALUES (1, '������� 1'),
       (2, '������� 2'),
       (3, '������� 3'),
       (4, '������� 4');

INSERT INTO ProductCategory (ProductID, CategoryID)
VALUES (1, 1),
       (1, 2),
       (2, 2),
       (3, 3);

-- TASK 2
SELECT p.ProductName, c.CategoryName
FROM Products p
LEFT JOIN ProductCategory pc ON p.ProductID = pc.ProductID
LEFT JOIN Categories c ON pc.CategoryID = c.CategoryID;