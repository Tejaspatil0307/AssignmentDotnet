use BookStoreDB
select *from Customers

-- update the price of book titled "Sql mystery" by increassing it by 10%
update Books
set price = 3000 *1.10
where Title ='Sql mystery';

-- Delete a customer who has not placed any orders.
Delete from OrderItems
where Quantity=0;

--Operators
--1. Retrieve all books with a price greater than 2000. 
select * from Books
where price>2000;
--2. Find the total number of books available.
select * from OrderItems
where SubTotal =0;

--3. Find books published between 2015 and 2023. 
select * from Books
where PublishedYear between '2015' and '2023'

--4.Find all customers who have placed at least one order. 
SELECT DISTINCT C.CustomerID, C.Name, C.Email, C.PhoneNumber --Distinct makes sure customer should appera only once becz it can have multiple order
FROM Customers C
INNER JOIN 
Orders O ON C.CustomerID = O.CustomerID;

--5. Retrieve books where the title contains the word "SQL"
select * from Books
where Title Like '%SQL%';

--6. Find the most expensive book in the store. 
select * from Books
where Price =(select Max(Price) from Books);

--7. Retrieve customers whose name starts with "A" or "J"
select * from Customers
where Name like 'S%' or Name like 'D%';

--8. Calculate the total revenue from all orders.

select sum(TotalAmount)As TotalRevenue
from Orders;




