CREATE TABLE Product (
    ID INT AUTO_INCREMENT NOT NULL,
    ProductName VARCHAR(255) NULL,
    PRIMARY KEY (ID)
);

CREATE TABLE Category (
    ID INT AUTO_INCREMENT NOT NULL,
    CategoryName VARCHAR(255) NULL,
    PRIMARY KEY (ID)
);

CREATE TABLE ProductCategories (
    ProductID INT,
    CategoryID INT,
    PRIMARY KEY (ProductID, CategoryID),
    FOREIGN KEY (ProductID) REFERENCES Product(ID),
    FOREIGN KEY (CategoryID) REFERENCES Category(ID)
);

INSERT INTO Product (ProductName)
VALUES
    ('Water'),
    ('Apple'),
    ('Mango'),
    ('Squid'),
    ('Oil');

INSERT INTO Category (CategoryName)
VALUES
    ('Solid'),
    ('Food'),
    ('Liquid');

INSERT INTO ProductCategories (ProductID, CategoryID)
VALUES
    (1, 3),
    (2, 1),
    (3, 2),
    (3, 1),
    (4, 2),
    (4, 1);

SELECT ProductName, CategoryName 
FROM Product p
LEFT JOIN ProductCategories pc ON pc.ProductID = p.ID
LEFT JOIN Category c ON pc.CategoryID = c.ID
ORDER BY p.ProductName, c.CategoryName;