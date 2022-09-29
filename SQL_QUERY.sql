SELECT p.productName, c.categoryName FROM ProductTale p LEFT JOIN CategoryTale c ON p.productName = c.productName ORDER BY p.productName
