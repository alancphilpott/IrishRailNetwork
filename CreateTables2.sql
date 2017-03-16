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
country varchar (20) NOT NULL,
phoneNo varchar (16) NOT NULL,
status varchar (1) DEFAULT 'A' NOT NULL,
CONSTRAINT pk_Stations PRIMARY KEY (stationID)
);


CREATE TABLE Routes
(
routeID number (3),
departStationID number (3) NOT NULL,
arrivalStationID number (3)  NOT NULL,
distance decimal (8,2) NOT NULL,
status varchar (1) DEFAULT 'A' NOT NULL,
CONSTRAINT pk_Routes PRIMARY KEY (routeID),
CONSTRAINT fk_Station1 FOREIGN KEY (departStationID) REFERENCES Station (stationID),
CONSTRAINT fk_Station2 FOREIGN KEY (arrivalStationID) REFERENCES Station (stationID)
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
description varchar (25) NOT NULL,
ratePerKM decimal (3,2) NOT NULL,
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

/* save a record for each ticket */

CREATE TABLE Sales
(
saleID number (10),
scheduleID number (3),
typeID number (2),
totalCost decimal (5,2) NOT NULL,
saleDate datetime (10) NOT NULL, // /* I will use datetime no varchar!!!! */
CONSTRAINT pk_Sales PRIMARY KEY (saleID),
CONSTRAINT fk_ScheduleIDRoute FOREIGN KEY (scheduleID) REFERENCES Schedules (scheduleID),
CONSTRAINT fk_SalesType FOREIGN KEY (typeID) REFERENCES Rates (typeID)
);

/* YOU WILL USE SQL INNER JOIN AND SQL GROUP BY */