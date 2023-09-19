-- Создание таблицы Categories для хранения категорий продуктов
CREATE TABLE Categories (
    CategoryID INT PRIMARY KEY,
    CategoryName NVARCHAR(255) NOT NULL
);

-- Создание таблицы Products для хранения информации о продуктах
CREATE TABLE Products (
    ProductID INT PRIMARY KEY,
    ProductName NVARCHAR(255) NOT NULL
);

-- Создание связующей таблицы ProductCategory для связей между продуктами и категориями
CREATE TABLE ProductCategory (
    ProductID INT,
    CategoryID INT,
    FOREIGN KEY (ProductID) REFERENCES Products(ProductID),
    FOREIGN KEY (CategoryID) REFERENCES Categories(CategoryID)
);

-- Пример добавления данных
INSERT INTO Categories (CategoryID, CategoryName)
VALUES (1, 'Категория 1'),
       (2, 'Категория 2'),
       (3, 'Категория 3');

INSERT INTO Products (ProductID, ProductName)
VALUES (1, 'Продукт 1'),
       (2, 'Продукт 2'),
       (3, 'Продукт 3'),
       (4, 'Продукт 4');

INSERT INTO ProductCategory (ProductID, CategoryID)
VALUES (1, 1),
       (1, 2),
       (2, 2),
       (3, 3);

-- ОСНОВНОЙ ЗАПРОС
SELECT p.ProductName, c.CategoryName
FROM Products p
LEFT JOIN ProductCategory pc ON p.ProductID = pc.ProductID
LEFT JOIN Categories c ON pc.CategoryID = c.CategoryID;