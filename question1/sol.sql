-- SQL Dialect - PostgreSQL


-- Make the table
CREATE TABLE CarSales
(
    CarMaker           varchar(255) NOT NULL,
    CarModel           varchar(255) NOT NULL,
    SalePriceInDollars float,
    SaleDate           date
);
-- Insert some Sample Data
INSERT INTO CarSales(CarMaker, CarModel, SalePriceInDollars, SaleDate)
VALUES ('Maker A', 'A Model X V6', 20000, '2019-09-03'),
       ('Maker B', 'B Model V V6', 18500, '2019-08-03'),
       ('Maker C', 'C Model X V6', 21500, '2019-09-01'),
       ('Maker A', 'A Model X V6', 12000, '2019-08-31'),
       ('Maker B', 'B Model X V6', 16783, '2019-08-28'),
       ('Maker C', 'C Model X V6', 30000, '2019-07-23'),
       ('Maker A', 'A Model V V6', 21000, '2019-08-23'),
       ('Maker B', 'B Model X V6', 11000, '2019-09-03'),
       ('Maker C', 'C Model X V6', 14300, '2019-09-02'),
       ('Maker A', 'A Model V V6', 22000, '2019-09-03');


-- Write a SQL query to get the total sale price per maker and model from the past 30 days

SELECT CarMaker,CarModel,sum(SalePriceInDollars) TotalSalePrice
FROM CarSales
WHERE SaleDate > now() - INTERVAL '30 days'
GROUP BY CarMaker,CarModel;
