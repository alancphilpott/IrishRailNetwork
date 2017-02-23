DROP TABLE Stations;
DROP TABLE Routes;

CREATE TABLE Stations
(
stationID number (5),
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
routeID number (5),
departStation varchar (20) NOT NULL,
arrivalStation varchar (20) NOT NULL,
distance number (10,2) NOT NULL,
status varchar (1) DEFAULT 'A' NOT NULL,
CONSTRAINT pk_Routes PRIMARY KEY (routeID)
);