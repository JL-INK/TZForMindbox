DECLARE @Product TABLE (ProductId INT,  ProductName NVARCHAR(64));

INSERT INTO @Product
VALUES(1, '�������'),
	(2, '�����������'),
    (3, '����'),
    (4, '������'),
    (5, '���������'),
    (6, '��'),
    (7, '���������� �����')

DECLARE @Category TABLE (CategoryId INT,  CategoryName NVARCHAR(64));
    
INSERT INTO @Category
VALUES(1, '������� �������'),
	(2, '�����������')
    
DECLARE @CategoryProduct TABLE (CategoryProductId INT,  ProductId INT, CategoryId INT);

INSERT INTO @CategoryProduct
VALUES
	(1, 1, 2),
    (2, 2, 1),
    (3, 2, 2),
    (4, 6, 2),
    (5, 7, 2),
	(6, 5, 1)
    
select 
	ProductName, 
	CategoryName 
from @Product p
	left join @CategoryProduct cp 
		on cp.ProductId = p.ProductId
	left join @Category c 
		on c.CategoryId = cp.CategoryId