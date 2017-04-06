DROP TABLE Sales;
DROP TABLE Schedules;
DROP TABLE Rates;
DROP TABLE Routes;
DROP TABLE Stations;

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

INSERT INTO Stations
VALUES(1,'KILLARNEY','EAST AVENUE ROAD','KILLARNEY','KERRY','0646631258','A');
INSERT INTO Stations
VALUES(2,'HEUSTON','ROAD WEST','DUBLIN 8','DUBLIN','0112345678','A');
INSERT INTO Stations
VALUES(3,'CASEMENT','CLOONALOUR','TRALEE','KERRY','0646631258','A');
INSERT INTO Stations
VALUES(4,'LIMERICK JUNCTION','MONATOGHER','MONATOGHER','TIPPERARY','0626631258','A');
INSERT INTO Stations
VALUES(5,'PLUNKETT','TERMINUS STREET','CHEANN SCRIBE','WATERFORD','05177631258','A');
INSERT INTO Stations
VALUES(6,'CEANNT','STATION ROAD','GALWAY','GALWAY','0916631258','A');
INSERT INTO Stations
VALUES(7,'MALLOW','ANNABELLA','MALLOW','CORK','0226631258','A');

CREATE TABLE Routes
(
routeID number (3),
departStation numeric(3) NOT NULL,
arrivalStation numeric(3) NOT NULL,
distance decimal (8,2) NOT NULL,
status varchar (1) DEFAULT 'A' NOT NULL,
CONSTRAINT pk_Routes PRIMARY KEY (routeID),
CONSTRAINT pk_Routes_StatDept FOREIGN KEY(departStation) REFERENCES Stations,
CONSTRAINT pk_Routes_StatArr FOREIGN KEY(arrivalStation) REFERENCES Stations
);

INSERT INTO ROUTES
VALUES(1,3,1,307.6,'A');
INSERT INTO ROUTES
VALUES(2,3,2,337.8,'A');
INSERT INTO ROUTES
VALUES(3,3,4,133.2,'A');
INSERT INTO ROUTES
VALUES(4,3,5,208.1,'A');
INSERT INTO ROUTES
VALUES(5,3,6,198,'A');
INSERT INTO ROUTES
VALUES(6,3,7,80.4,'A');

CREATE TABLE Schedules
(
scheduleID number (3),
routeID number (3),
DayofWeek numeric(1) CHECK (DayOfWeek BETWEEN 1 AND 7),
depTime varchar (9) NOT NULL,
arrTime varchar (9) NOT NULL,
status varchar (1) DEFAULT 'A' NOT NULL,
CONSTRAINT pk_Schedules PRIMARY KEY (scheduleID),
CONSTRAINT fk_Schedules FOREIGN KEY (routeID) REFERENCES Routes (routeID)
);

INSERT INTO Schedules
VALUES(1,1,1,'08:00','11:20','A');
INSERT INTO Schedules
VALUES(2,1,2,'08:00','11:20','A');

INSERT INTO Schedules
VALUES(3,2,1,'08:00','11:20','A');
INSERT INTO Schedules
VALUES(4,2,2,'08:00','11:20','A');

INSERT INTO Schedules
VALUES(5,3,1,'08:00','11:20','A');
INSERT INTO Schedules
VALUES(6,3,2,'08:00','11:20','A');

INSERT INTO Schedules
VALUES(7,4,1,'08:00','11:20','A');
INSERT INTO Schedules
VALUES(8,4,2,'08:00','11:20','A');

INSERT INTO Schedules
VALUES(9,5,1,'08:00','11:20','A');
INSERT INTO Schedules
VALUES(10,5,2,'08:00','11:20','A');

INSERT INTO Schedules
VALUES(11,6,1,'08:00','11:20','A');
INSERT INTO Schedules
VALUES(12,6,2,'08:00','11:20','A');

CREATE TABLE Rates
(
typeCode char (2),
description varchar (25),
ratePerKM decimal (3,2),
CONSTRAINT pk_Rates PRIMARY KEY (typeCode)
);

INSERT INTO Rates
VALUES('AD','ADULT',0.11);
INSERT INTO Rates
VALUES('ST','STUDENT',0.08);
INSERT INTO Rates
VALUES('CH','CHILD',0.05);
INSERT INTO Rates
VALUES('OP','OLD AGE PENSIONER',0.02);

CREATE TABLE Sales
(
saleID number (10),
scheduleID number (3),
typeCode char(2),
totalCost decimal (6,2) NOT NULL,
saleDate varchar (10) NOT NULL,
CONSTRAINT pk_Sales PRIMARY KEY (saleID),
CONSTRAINT fk_SalesSchedule FOREIGN KEY (scheduleID) REFERENCES Schedules (scheduleID),
CONSTRAINT fk_SalesType FOREIGN KEY (typeCode) REFERENCES Rates (typeCode)
);

COMMIT;