CREATE TABLE EmpTable
(
	EmpID int PRIMARY KEY IDENTITY(1000,1),
	EmpName varchar(20) NOT NULL,
	EmpAddress varchar(30) NOT NULL,
	EmpBaseLocation varchar(30) NOT NULL
)

CREATE TABLE RouteTable
(
	RouteNo int PRIMARY KEY IDENTITY(1,1),
	RouteName varchar(30) NOT NULL,
	FinalPrice int NOT NULL
)

ALTER Table RouteTable 
ADD RouteImage varchar(MAX);

CREATE TABLE PickUpTable
(
	EntryID int PRIMARY KEY IDENTITY(1,1),
	PickUpPoint varchar(30) NOT NULL,
	RouteNo int REFERENCES RouteTable(RouteNo)
)

CREATE TABLE EmpRoute
(
	EntryID int PRIMARY KEY IDENTITY(1,1),
	EmpID int REFERENCES EmpTable(EmpID),
	PickUpID int REFERENCES PickUpTable(EntryID),
	DropID int REFERENCES PickUpTable(EntryID),
	Amount int NOT NULL
)

---------------------------------Employee Table--------------------------------


insert into EmpTable values ('Pavan R', 'Bangalore', 'Nandini Layout' );
insert into EmpTable values ('Sachin R', 'Mysore', 'Navrang' );
insert into EmpTable values ('Vishwas V', 'Chikkabalapura', 'Indiranagar' );
insert into EmpTable values ('Priya B', 'Dharwad', 'Nandini Layout' );
insert into EmpTable values ('Kishore', 'Bangalore', 'Saraswathipuram' );

---------------------------------Route Table-----------------------------------


insert into RouteTable values ('Nandini Layout - Whitefield',150);
insert into RouteTable values ('Nagarbhavi - Whitefield',160);
insert into RouteTable values ('Whitefield - Electronic City',200);
insert into RouteTable values ('Kormangala - Electronic City',100);
insert into RouteTable values ('Rajajinagar - Electronic City',170);

---------------------------------Route Number 1--------------------------------

insert into PickUpTable values ('Nagarbhavi',1);
insert into PickUpTable values ('Housing Board',1);
insert into PickUpTable values ('Magadi Road',1);
insert into PickUpTable values ('Lulu Mall',1);
insert into PickUpTable values ('Sheshadripuram',1);
insert into PickUpTable values ('Trinity',1);
insert into PickUpTable values ('HAL-Old Airport Road',1);
insert into PickUpTable values ('Marathahalli',1);
insert into PickUpTable values ('Varthur Lake',1);
insert into PickUpTable values ('Whitefield',1);

---------------------------------Route Number 3--------------------------------

insert into PickUpTable values ('Kormangala',3);
insert into PickUpTable values ('Madivala',3);
insert into PickUpTable values ('Silk Board',3);
insert into PickUpTable values ('Bommanahalli',3);
insert into PickUpTable values ('Kudlu Gate',3);
insert into PickUpTable values ('Singasandra',3);
insert into PickUpTable values ('Nice Road',3);
insert into PickUpTable values ('Konappana Agrahara',3);
insert into PickUpTable values ('Electronic City Phase 1',3);
insert into PickUpTable values ('Electronic City',3);

---------------------------------Route Number 4--------------------------------

insert into PickUpTable values ('Rajajinagar',4);
insert into PickUpTable values ('Sujatha',4);
insert into PickUpTable values ('Okalipuram',4);
insert into PickUpTable values ('Majestic',4);
insert into PickUpTable values ('Cubbon Park',4);
insert into PickUpTable values ('Kantirava Stadium',4);
insert into PickUpTable values ('Adugodi',4);
insert into PickUpTable values ('Kormangala',4);
insert into PickUpTable values ('Madivala',4);
insert into PickUpTable values ('Silk Board',4);
insert into PickUpTable values ('Bommanahalli',4);
insert into PickUpTable values ('Kudlu Gate',4);
insert into PickUpTable values ('Singasandra',4);
insert into PickUpTable values ('Nice Road',4);
insert into PickUpTable values ('Konappana Agrahara',4);
insert into PickUpTable values ('Electronic City Phase 1',4);
insert into PickUpTable values ('Electronic City',4);

---------------------------------Route Number 5--------------------------------

insert into PickUpTable values ('Nandini Layout',5);
insert into PickUpTable values ('Saraswathipuram',5);
insert into PickUpTable values ('Mahalakshmi Layout',5);
insert into PickUpTable values ('Navrang',5);
insert into PickUpTable values ('Malleshwaram',5);
insert into PickUpTable values ('Halasur',5);
insert into PickUpTable values ('Indiranagar',5);
insert into PickUpTable values ('Baiyapanahalli',5);
insert into PickUpTable values ('KR Puram',5);
insert into PickUpTable values ('Hoodi',5);
insert into PickUpTable values ('Whitefield',5);

---------------------------------Route Number 7--------------------------------

insert into PickUpTable values ('Whitefield',7);
insert into PickUpTable values ('Marathahalli',7);
insert into PickUpTable values ('Bellandur',7);
insert into PickUpTable values ('HSR Layout',7);
insert into PickUpTable values ('Silk Board',7);
insert into PickUpTable values ('Bommanahalli',7);
insert into PickUpTable values ('Kudlu Gate',7);
insert into PickUpTable values ('Singasandra',7);
insert into PickUpTable values ('Nice Road',7);
insert into PickUpTable values ('Konappana Agrahara',7);
insert into PickUpTable values ('Electronic City Phase 1',7);
insert into PickUpTable values ('Electronic City',7);

---------------------------------Table Views--------------------------------

select * from EmpTable;
select * from RouteTable;
select * from PickUpTable;