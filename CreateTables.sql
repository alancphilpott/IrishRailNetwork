DROP TABLE Stations;
DROP TABLE Routes;
DROP TABLE Schedules;

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