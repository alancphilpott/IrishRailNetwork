DROP TABLE Schedules;
DROP TABLE Sales;
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
VALUES(1,'KILLARNEY','MAIN ST','KILLARNEY','KERRY','0646631258','A');
INSERT INTO Stations
VALUES(2,'HEUSTON','INCHICORE','DUBLIN','DBLIN','06177631258','A');
INSERT INTO Stations
VALUES(3,'CASEMENT','JJ SHEEHY RD','TRALEE','KERRY','0646631258','A');

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
VALUES(1,1,2,350,'A');
INSERT INTO ROUTES
VALUES(2,3,2,370,'A');
INSERT INTO ROUTES
VALUES(3,2,1,350,'A');

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
VALUES(2,1,3,'08:00','11:20','A');

CREATE TABLE Rates
(
typeCode char (2),
description varchar (25),
ratePerKM decimal (3,2),
CONSTRAINT pk_Rates PRIMARY KEY (typeCode)
);

INSERT INTO Rates
VALUES('AD','ADULT',3.50);
INSERT INTO Rates
VALUES('ST','STUDENT',2.50);

CREATE TABLE Sales
(
saleID number (10),
routeID number (3),
typeCode char(2),
totalCost decimal (5,2) NOT NULL,
saleDate varchar (10) NOT NULL,
CONSTRAINT pk_Sales PRIMARY KEY (saleID),
CONSTRAINT fk_SalesRoute FOREIGN KEY (routeID) REFERENCES Routes (routeID),
CONSTRAINT fk_SalesType FOREIGN KEY (typeCode) REFERENCES Rates (typeCode)
);

COMMIT;