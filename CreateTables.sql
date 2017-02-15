DROP TABLE Stations;

CREATE TABLE Stations
(
stationID number (5),
name varchar (20),
street varchar (20),
town varchar (20),
county varchar (20),
phoneNo varchar (16),
status varchar (1) DEFAULT 'A',
CONSTRAINT pk_Stations PRIMARY KEY (stationID)
);