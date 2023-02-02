use [3342]

CREATE TABLE Cars(
EntryID int primary key identity (1,1),
BrandName varchar(50) NOT NULL,
Model Varchar(200) NOT NULL,
BodyType varchar(50) NOT NULL,
Engine varchar(50) NOT NULL,
Capacity int NOT NULL,
FuelType varchar(50) NOT NULL,
Price int NOT NULL
)

Drop table Cars

Insert into Cars values('Kia','Kia Seltos','SUV','1.4 L 4-cylinder', 5,'Petrol', 1580000)
Insert into Cars values('Kia','Kia Seltos WPX','SUV','1.5 L 4-cylinder', 5,'Diesel', 1680000)
Insert into Cars values('Kia','Kia Carnival','SUV','1.7 L 3-cylinder', 7,'Diesel', 1280000)
Insert into Cars values('Hyundai','Hyundai i20','Hatchback','1.3 L 3-cylinder', 5,'Diesel', 1380000)
Insert into Cars values('Hyundai','Hyundai i20 Pro','Hatchback','1.2 L 4-cylinder', 5,'Hybrid', 1450000)
Insert into Cars values('Hyundai','Hyundai Creta','SUV','1.4 L 4-cylinder', 5,'Diesel', 1320000)
Insert into Cars values('Hyundai','Hyundai Verna','Sedan','1.1 L 4-cylinder', 5,'Petrol', 950000)
Insert into Cars values('Lamborghini','Lamborghini Hurracan','Hatchback','5.2 L V10', 2,'Petrol', 45080000)
Insert into Cars values('Lamborghini','Lamborghini Hurracan 2021','Hatchback','5.8 L V10', 2,'Hybrid', 43080000)
Insert into Cars values('Lamborghini','Lamborghini Urus','MUV','6 L V10', 2,'Petrol', 53080000)
Insert into Cars values('koenigsegg','koenigsegg Gemera','Hatchback','Inline-3 engine', 2,'Petrol', 35080000)
Insert into Cars values('koenigsegg','koenigsegg Gemera 2022','Hatchback','Inline-4 engine', 2,'Hybrid', 45080000)
Insert into Cars values('Tesla','Tesla Model S','Hatchback','3-phase AC induction motor', 5,'Electric', 8080000)
Insert into Cars values('Tesla','Tesla Model X','SUV','Dual Motor AWD; 60D, 75D', 5,'Electric', 9080000)
Insert into Cars values('Tesla','Tesla Model 3','Hatchback','Permanent-magnet', 5,'Hybrid', 9580000)


Alter Table Cars
Add Constraint chk_Type CHECK (BodyType in ('Hatchback', 'Sedan', 'SUV', 'MUV'))

Alter Table Cars
Add Constraint chk_FuelType CHECK (FuelType in ('Petrol', 'Diesel', 'Hybrid', 'Electric'))

sp_columns Cars

select * from Cars
