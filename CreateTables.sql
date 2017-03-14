DROP TABLE Stations;
DROP TABLE Schedules;
DROP TABLE ScheduleRates;
DROP TABLE Sales;
DROP TABLE Rates;
DROP TABLE Routes;

CREATE TABLE Stations
(
stationID number (3),
name varchar (20) NOT NULL,
street varchar (20) NOT NULL,
town varchar (20) NOT NULL,
county varchar (20) NOT NULL,
phoneNo varchar (16) NOT NULL,
status varchar (1) DEFAULT 'A' NOT NULL,
CONSTRAINT pk_Stations PRIMARY KEY (stationID)
);

CREATE TABLE Routes
(
routeID number (3),
departStation varchar (20) NOT NULL,
arrivalStation varchar (20) NOT NULL,
distance decimal (8,2) NOT NULL,
status varchar (1) DEFAULT 'A' NOT NULL,
CONSTRAINT pk_Routes PRIMARY KEY (routeID)
);

CREATE TABLE Schedules
(
scheduleID number (3),
routeID number (3),
numCarriages number (1) NOT NULL,
depTime varchar (9) NOT NULL,
arrTime varchar (9) NOT NULL,
status varchar (1) DEFAULT 'A' NOT NULL,
CONSTRAINT pk_Schedules PRIMARY KEY (scheduleID, routeID),
CONSTRAINT fk_Schedules FOREIGN KEY (routeID) REFERENCES Routes (routeID)
);

CREATE TABLE Rates
(
typeID number (2),
description varchar (25),
CONSTRAINT pk_Rates PRIMARY KEY (typeID)
);

CREATE TABLE ScheduleRates
(
routeID number (3),
typeID number (2),
rate decimal (3,2) NOT NULL,
CONSTRAINT pk_ScheduleRates PRIMARY KEY (routeID, typeID),
CONSTRAINT fk_ScheduleRatesRoute FOREIGN KEY (routeID) REFERENCES Routes (routeID),
CONSTRAINT fk_ScheduleRatesType FOREIGN KEY (typeID) REFERENCES Rates (typeID)
);

CREATE TABLE Sales
(
saleID number (10),
routeID number (3),
typeID number (2),
totalCost decimal (5,2) NOT NULL,
saleDate varchar (10) NOT NULL,
CONSTRAINT pk_Sales PRIMARY KEY (saleID, routeID, typeID),
CONSTRAINT fk_SalesRoute FOREIGN KEY (routeID) REFERENCES Routes (routeID),
CONSTRAINT fk_SalesType FOREIGN KEY (typeID) REFERENCES Rates (typeID)
);