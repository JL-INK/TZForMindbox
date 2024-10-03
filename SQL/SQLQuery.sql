DECLARE @Product TABLE (ProductId INT,  ProductName NVARCHAR(64));

INSERT INTO @Product
VALUES(1, 'Phone'),
	(2, 'Fridge'),
    (3, 'Table'),
    (4, 'Coffee maker'),
    (5, 'Meat grinder'),
    (6, 'PC'),
    (7, 'Table lamp')

DECLARE @Category TABLE (CategoryId INT,  CategoryName NVARCHAR(64));
    
INSERT INTO @Category
VALUES(1, 'Appliances'),
	(2, 'Electronics')
    
DECLARE @CategoryProduct TABLE (CategoryProductId INT,  ProductId INT, CategoryId INT);

INSERT INTO @CategoryProduct
VALUES
	(1, 1, 2),
    (2, 2, 1),
    (3, 2, 2),
    (4, 6, 2),
    (5, 7, 2),
	(6, 5, 1),
	(6, 4, 1)
    
select 
	ProductName, 
	CategoryName 
from @Product p
	left join @CategoryProduct cp 
		on cp.ProductId = p.ProductId
	left join @Category c 
		on c.CategoryId = cp.CategoryId