select p.ProductName, c.CategoryName from dbo.Products as p
right join dbo.ProductCategories as pc
on pc.Product_ProductId  = p.ProductId
left join dbo.Categories as c
on c.CategoryId  = pc.Category_CategoryId
union all
select p.ProductName, c.CategoryName from dbo.Products as p
left join dbo.ProductCategories as pc
on pc.Product_ProductId  = p.ProductId
left join dbo.Categories as c
on c.CategoryId  = pc.Category_CategoryId