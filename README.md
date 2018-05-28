# BPeState
Interface to handle database of Estate home investments in Budapest

https://github.com/hand83/BPeState.git

2018-04-11
Andras Horvath

server: halumin.database.windows.net
database: tudbase

Tables:
- Investments  
Estate home investments collected from lakopark.ingatlan.com  
Columns:
	- Name: Name of investment
	- Price_min: Price of the cheapest home (million HUF)
	- Price_max: Price of the most expensive home (million HUF)
	- Area_min: Area of the smallest home (sq meters)
	- Area_max: Area of the largest home (sq meters)
	- Rooms_min: Smallest room number
	- Rooms_max: Largest room number
	- Date_of_finish: Expected date of finist
	- No_of_homes: Number of homes in the estate
- Contractors  
Estate contractors  
Columns:
	- Name: Contractor/investor name
- Streets  
Neighboring streets of the estates  
	- Name: Street name
	- District: District number
- Transport  
Public transport lines near to the estates (subway/metro, tram/lightrail, commuter rail only)  
Columns:
	- Type: Közlekedési eszköz típusa
	- Number: Közlekedési eszköz száma
- IC  
Relation table for Investments and Contractors tables
- IS  
Relation table for Investments and Streets tables
- IT  
Relation table for Investments and Transport.  
A transport line is assigned to an estate if it is located within the 200 meters range of the estate.  
  
The data in the database are not comprehensive and may be inaccurate.
