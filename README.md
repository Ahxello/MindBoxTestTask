# Задча на SQL
* В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов. Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно должно выводиться.
### Создание необходимой структуры Базы Данных:
  IF OBJECT_ID(N'Products') IS NULL CREATE TABLE Products (Id INT PRIMARY KEY IDENTITY, Name VARCHAR(255) NOT NULL) ;"
  
  IF OBJECT_ID(N'Category') IS NULL CREATE TABLE Category (Id INT PRIMARY KEY IDENTITY, Name VARCHAR(255) NOT NULL) ;"
  
  IF OBJECT_ID(N'ProductsCategory') IS NULL CREATE TABLE ProductsCategory 
  ( Products_Id INT NOT NULL, Category_Id INT NOT NULL,
  FOREIGN KEY(Products_Id) REFERENCES Products(Id) ON DELETE CASCADE,
  FOREIGN KEY(Category_Id) REFERENCES Category(Id) ON DELETE CASCADE ) ;"
  
