---
banner: ProgrammeringDotNETCSharp2/Anteckningar/database-transformed.jpeg
---
# Data
- Data är uppgifter/värden av olika slag, vanligen hämtat från __verkligheten__.
- Ibland skiljer man data från information, som är data som man gett en tolkning
- Alltså är siffran __23__ ett exempel på __data__ medan det är __information__ om vi vet att det är __23 grader varmt ute__. 
- Ibland talar man också om kunskap, som i _kunskapsbaserade system_.
- __Kunskap__ är anvisningar om beteende, exempelvis regler för hur datorn ska dra slutsatser och agera utifrån information.

## Datalagring
Gamla lagringstyper:
- rullband
- hålkort
- kassettband
- diskett

Moderna lagringstyper:
- magnetisk hårddisk
- SSD-hårddisk

# Databaser
En  databas är en samling data som:
- hör ihop
- modellerar en del av världen, till exempel ett företag och dess verksamhet
- är persistent, dvs inte försvinner när man avslutar programmet eller stänger av datorn
- har ett schema, dvs det ska finnas en explicit beskrivning av vad det är för data
- är konsistent eller logiskt koherent, dvs den får inte innehålla motsägelser

Vi antar också att databasen lagras och hanteras av en dator.

## Databastyper
- Hierarkiska databaser
	- Data organiserat i ett "träd"
- Relationsdatabaser
	- Databaser byggda enligt tabeller med rader och kolumner
	- Relationer anges mellan tabeller, främst för att skapa en databas utan fel, på ett så effektivt sätt som möjligt
- Dokument-databaser
	- Posterna sparas som dokument, som kan ha olika innehåll i varje post

## Historik
När datorer började användas inom affärsvärlden på 1960-talet blev det __viktigt att kunna spara data på ett säkert sätt__.
De __första databaserna var hierarkiska__ där data lagras i en struktur anpassad till dåtidens __linjära lagringsmedia som magnetband__.
Det är en vanlig missuppfattning att data och databaser inte fanns innan datorernas intåg. Databaser har funnits sedan mycket lång tid tillbaka.  Ända sedan man började samla in data och ordna den systematiskt, exempelvis i form av arkiv och kartotek.
I och med att datorerna kom fick man möjlighet att behandla data med maskinellt automatiskt behandling (ADB).

## Hierarkiska databaser
![[Pasted image 20231114095124.png]]

- Hierarkisk databas var den __första typen av databas__. Den började användas på 1960-talet, och datan var lagrad på ett sådant sätt att det var lätt att överföra från ett magnetband, dåtidens främsta datalagringsmedium. Namnet har den fått därför att datan lagrades hierarkiskt, på en trädstruktur. 
- En hierarkisk databas har som sagt en trädstruktur, det vill säga en __en-till-många__ struktur: varje post består av en __föräldradel__, som kan har __ett eller flera barn__ med samma struktur inbördes. Barnen kan alltså endast ha en förälder, medan föräldern kan ha många barn.
- Om inflexibiliteten, begränsningen till en en-till-många struktur, inte innebär några  problem har strukturen många fördelar: 
	- den är __mycket snabb vis access__ av poster
	- det är __enkelt (tack var länkarna) att lägga till och ta bort poster__
	- den är (och kanske framför allt var) __ mycket väl anpassad när det gäller att överföra linjära lagringsstrukturer, som exempelvis magnet band , från och till hierarkiska databassystem

## Relationsdatabaser
![[Pasted image 20231114100102.png]]
### SQL - Structured Query Language
- En relationsdatabas är en databas där information ("data") är organiserad i relationer (även kallade tabeller) bestående av rader (kallas också poster eller tupler) och kolumner (fält).
- En relationsdatabas lagrar data i tabeller. som är organiserade i kolumner. Varje kolumn lagrar en datatyp (heltal, verkligt nummer, sträng, datum, etc.) och varje rad representerar en instans av ett "Objekt". Jämför med Excel.
- För femton år sedan var databas alternativ lite mer tydliga. __SQL var standarden__, och generellt sett hade databaser tabeller, tabeller hade kolumner och det fanns relationer mellan dem.
- Microsoft SQL Server, Oracle, PostgreSQL, eller MySQL var/är lösningarna som gällde.
- SQL-frågor gjorde det ganska enkelt att hämta eller uppdatera data.
- SQL-databaser är fortfarande ett bra alternativ för många applikationer.
- Men databastekniken har förändrats lite, och det finns alternativ som kan passa ditt projekt bättre. Teknologier som har olika tillvägagångssätt, är lättare att fråga, är flexibla eller är bättre lämpade för olika typer av data.

### SQL - nycklar
- En post motsvarar ofta något objekt och information förknippad med det, oavsett om objektet är ett fysiskt objekt eller ett abstrakt koncept.
	- Namn
	- Födelsedag
	- IDnummer
- De flesta databastabeller har någon form av nyckel
- En __nyckel__ är en slags restriktion som ser till att objektet eller kritisk information om ett objekt __inte dupliceras__.
- Till exempel kan man inom en familj har restriktionen att __inga två familjemedlemmar kan ha samma förnamn__. Om information om denna familj lagrades i ren relationsdatabas skulle __förnamnen kunna användas som nyckel__.
- __Förnamn är sällan unika__ över grupper större än den innersta familjekretsen, som till exempel hela landets befolkning. Detta är ett skäl till att Sveriges medborgare tilldelas ett nummer, ett __personnummer__, unikt för var och en i landet. Personnummer används som nyckel i både privata och offentliga relationsdatabaser.
- En vanlig nyckel är ett ID, som räknas upp automatiskt, sk. auto-increment.

## Data att ha i en databas
- Ekonomiska transaktioner
	- Bankkonton
	- Bokföring
- Webbsajter
	- Webbshop
	- Sociala medier
- Register
	- Befolkning
	- Företag
Osv.

# Relational Database Management System (RDMS)
Relational database management system hanterar data som är lagrat i tabeller
Systemen hanterar typiskt:
- Skapa/ändra/ta bort tabeller och relationer mellan dem (databasens schema)
- Skapa/ändra/hitta/ta bort data i dessa tabeller (CRUD = Create, Read, Update, Delete)
- Stöd för frågespråket SQL
- Hantering av transaktioner (ibland)

## Tabeller och relationer
### Tabeller
- Tabeller i en databas består av data som är ordnade i rader och kolumner
T.ex:
![[Pasted image 20231114103849.png]]
- Alla rader i tabellen har samma struktur
- Kolumner har namn ich typ (tal, sträng, datum, bild eller annat)
### Schema för tabeller
En tabells schema ör ne ordnad lista av kolumnspecifikationer
T.ex har tabellen Persons följande schema:
![[Pasted image 20231114104112.png]]
### Primärnyckel (Primary key)
- __Primärnyckel__ är en kolumn i en tabell som __unikt identifierar dess rader__ (vanligtvis ett nummer)
![[Pasted image 20231114110306.png]]
- Två poster (rader) är olika om (och endast om) deras primärnycklar är olika
- Primärnyckeln kan bestå av flera kolumner (__sammansatt primärnyckel__)
### Relationer
- Den __främmande nyckeln__ identifierar en post i en annan tabell (vanligen dess primärnyckel)
- Genom att avnvända relationer undviker vi en upprepning av data i databasen
	- I det förra exemplet upprepas inte landsnamnet - vi använder dess nummer
- Relationer har __kardinalitet__:
	- __en-till-många__ - t.ex. country <=> towns
	- __många-till många__ - t.ex. student <=> course
	- __en-till-en__ t.ex. person <=> student
- __Relationer__ mellan tabeller baseras på kopplingar
	- Primärnyckel <=> Främmande nyckel (foreign key)
![[Pasted image 20231114110935.png]]
## E/R-diagram
Entity/Relationship diagram och verktyg för att modellera databaser
### Relationsschema
- En databas __relationsschema__ är en samling av:
	- Scheman för alla tabeller
	- Relationer mellan tabeller
	- Alla andra databasobjekt (t.ex. constraints/begränsningar)
- Relationsschemat beskriver databasens struktur
	- Innehåller inga data - bara metadata
- Relationsscheman visas grafiskt i form av Entitets/Relationsdiagram (E/R-diagram)

Exempel på E/R-diagram skapat i SSMS
![[Pasted image 20231114111457.png]]
## Normalisering av datamodeller
Undvik duplicerade data genom normalisering av databasens schema
### Normalisering
- __Normalisering__ av datamodellen görs för att man inte skall dubbellagra data
- __Icke-normaliserade__ databaser kan innehålla många upprepade data:
![[Pasted image 20231114111659.png]]

Exempel på fullt normaliserad modell (i fjärde normalform)
![[Pasted image 20231114111803.png]]

# Språket SQL
- SQL (Structured Query Language)
	- Standardiserat deklarativt språk för manipulering av relationsdatabaser
	- De flesta databaser idag använder __SQL-99__
- Språket SQL har stöd för att:
	- Skapa, ändra, ta bort tabeller och andra objekt i databasen
	- Söka, hämta, lägga till, ändra och ta bort tabelldata (rader)
	- Framför allt visa data
- Språket SQL består av:
	- __DDL__ - Data Definition Language
		- Kommandon som CREATE, ALTER, DROP
	- __DML__ - Data Manipulation Language
		- Kommandon som SELECT, INSERT, UPDATE, DELETE
Exempel på en __SQL SELECT__ fråga:
```sql
SELECT Towns.Name, Countries.Name
FROM Towns, Countries
WHERE TOwns.CountryID = Countries.ID
```
# NoSQL-databaser
Icke-relationsdatabaser
## Icke-relations datamodeller
- Dokumentmodell
	- Sätt med dokument, t.ex. JSON-strängar
- Key-value modell
	- Sätt med nyckel-värdepar
- Hierarkiska key-value
	- Hierarki av nyckel-värdepar
- Wide-column modell
	- Nyckel-värdepar med schema
- Objektmodell
	- Sätt med OOP-liknande objekt
## Vad är en NoSQL-databas?
- NoSQL (icke-relationella) databaser
	- Använder en dokumentbaserad modell
	- Dokumentlagring utan schema
		- Har fortfarande stöd för CRUD-operationer (Create, Read, Update, Delete)
		- Stöd för indexering och frågor
		- Stöd för samtidighet och transaktioner
	- Starkt optimerade för lägg till/hämta
	- Bra prestanda och skalbarhet
	- "NoSQL" == "Ingen SQL" eller "Inte bara SQL"
## Relationsdatabaser <=> NoSQL-databaser
- Relationsdatabaser
	- Data lagras som tabellrader
	- Relationer mellan rader i olika tabeller
	- En entitet sprids över flera tabeller
	- RDBMS-system är väldigt mogna, mycket stabila
- NoSQL-databaser
	- Data lagras som dokument
	- En entitet (dokument) är en enda post
	- Dokument behöver inte ha någon fast struktur
## Relationsmodell <=> NoSQL-modell
![[Pasted image 20231114121602.png]]
## NoSQL databassystem
- Redis
	- Extremt snabb server för datastrukturer i RAM
- MongoDB
	- Mogen och kraftfull JSON-dokumentdatabas
- CouchDB
	- JSON-baserad dokumentdatabas med REST API
- Cassandra
	- Distribuerad wide-column databas

# Sammanfattning
- Den vanligaste typen av databas är __relationsdatabas__
- Bygger på mängdlära - stabil matematisk grund
- Data lagras i tabeller
- Tabeller kan ha relationer till varandra
- Man __normaliserar__ sin datamodell för att undvika dubbellagring av data
- Man arbetar med relationsdatabaser via språket __SQL__
- SQL används både för att skapa tabeller och för att populera dem
- På senare år har NoSQL-databaser blivit populära

# Begrepp
- Database - hela SQL-servern
- Schema - Varje separat applikation i databasen 
	- Vanligtvis är ett schema ett projekt eller en tjänst
		- Chattjänst, personregister, webshop, mm ryms normalt i ett schema
		- Det vi ibland menar med __databas__
- Annat som finns i ett schema
	- Views, Stored Procedures, Functions (gås inte igenom)
- Table - varje schema består av en eller flera tabeller
	- Består av rader och kolumner
	- Det är i Table vi sparar data
	- Det är här vi normalt jobbar
# Microsoft SQL Server
Microsoft SQL Server är en relationsdatabashanterare från Microsoft
- Använder språket Transact SQL (T-SQL), en utvidgning av SQL
- Lättanvänd och lätt att komma igång med
## Komponenter i SQL Server
![[Pasted image 20231114123008.png]]
## SQL Server databaser
SQL Server har systemdatabaser och användardatabaser
- Systemdatabaser
	- Innehåller serverns interna information
- Användardatabaser
	- Databaser som vi skapar
	- Lagrar schema och data
	- Använder sig av systemdatabaserna
### Systemdatabaser
- Master - meta-databas med information om 
	- Användarkonton
	- Miljövariabler och inställningar
	- Felmeddelanden
	- Metadata om användardatabaser
- Model - en prototyp för nya databaser
- Tempdb - lagring av tillfälliga tabeller och data
- Msdb - schemalagda jobb

Varje databas i SQL Server består av två filer:
- .mdf
	- innehåller egentliga data i databasen 
	- schema, tabelldata andra projekt
- .ldf
	- Transaktionslogg - håller ordning på transaktioner

Båda behövs för att använda databasen. Om .ldf saknas så skapas den automatiskt
# SQL Server Management Studio - intro
Ett verktyg för administratörer och utvecklare av databaser. SSMS är ett grafiskt verktyg för databashantering
- Administrerar databaser (skapa, ändra, säkerhetskopiera/återställa)
- Skapa och ändra E/R diagram
- Se och ändra tabelldata och andra objekt
- Köra SQL frågor
- Gratis, enkel att använda
- Fungerar med alla versioner av SQL Server

- SSMS användas för att registrera databasers struktur och innehåll
- Kan köra SQL frågor
	- Välj databas att använda
	- Klicka på [New Query]
	- Skriv in din fråga i fönstret
	- Klicka på knappen [Execute]

# Utvecklingsmiljön
- SQL Server
	- Saknar GUI
	- Är en process som körs hela tiden på datorn
	- Kan bara ta emot och svara på frågor/queries
	- Allt som sparas på SQL-servern stannar där i evighet (tills man tar bort det aktivt)

- SQL Server Management Studio (SSMS)
	- Erbjuder ett GUI
	- Är ett program som kommunicerar med olika SQL-servrar
	- Skickar frågor och visar svar vi får från SQL-servern
	- De frågor vi skriver kan vi spara om vi vill

# SQL - Structured Query Language
## Relationsdatabaser
- En databas är en samling information som är organiserad för att man enkelt ska kunna söka och ändra enskilda delar av informationen
- En databashanterare (DBMS) är den mjukvara som används för att söka och manipulera data i en specifik databas
- Det finns olika sorters databaser. Vi kommer att fokusera på den kategori av databaser som kallas relationsdatabaser, som är väldigt vanlig
- Relationsdatabaser lagrar data i tabellform och ofta är det relationerna mellan olika tabeller som är det mest intressanta. Därav namnet relationsdatabas

## Structured Query Language (SQL)
- SQL är ett standardiserat programspråk för att hämta och modifiera data i relationsdatabaser (REDMS)
- Språket utvecklades först av IBM under 70-talet
- SQL uttalas vanligen bokstav för bokstav, alltså S-Q-L, men ibland hör man det även uttalas som engelskans "sequel"
- Olika databashanterare (t.ex Oracle, Postgres och MySQL) använder olika dialekter av SQL. Variationerna är dock oftast relativt små
- I denna och kommande lektioner använder vi T-SQL som är den variant som Microsoft använder i sin SQL-server

## Queries (frågor)
- För att hämta ut eller ändra information i en relationsdatabas skickar man så kallade "queries" (frågor) till databashanteraren (servern)
- En query kan vara allt från väldigt enkel ("ge mig all data i tabell xyz") till väldigt komplex (t.ex korsreferera data från flera tabeller med en mängd villkor för exakt vilka data som man vill få ut)
- I denna lektion tittar vi på några av de vanligaste uttryck man använder i SQL för att plocka ut data från en tabell

## Syntax
- SQL är inte case-sensitive men det är bra att man anger alla SQL-kommandon med VERSALER så de syns tydligare
- Tabellnamn kan anges utan hakparenteser, men innehåller de mellanslag eller svenska tecken behöver de omslutas av hakparenteser
```sql
SELECT * FROM users 
--och
SELECT * FROM [users] 
--fungerar lika bra
```
- SQL behöver inte avslutas med ';' men vid mer komplexa uttryck är det lämpligt att göra det
- Förslag på grundsyntax:
```sql
SELECT * FROM users;
```
## CRUD
- Create
	- SQL: INSERT
- Read
	- SQL: SELECT
- Update
	- SQL: UPDATE
- Delete
	- SQL: DELETE

CRUD är en förkortning som används i de allra flest programspråk som en allmän beskrivning av då man hanterar data.
- C - Create
	- Skapa en databaspost eller ett object i C#
- R - Read
	- Läsa från en eller flera databasposter eller t.ex loopa igenom en List i C#
- U - Update
	- Ändra i en eller flera befintliga poster i en databas eller ändra properties i ett C#-object
- D - Delete
	- Ta bort en eller flera poster i en databas eller ta bort ett object ur en List i C#
## SELECT - Read
- När vi vill hämta och visa data från en tabell använder vi "SELECT"
```sql
SELECT id, username, password FROM users
```
![[Pasted image 20231122173417.png]]

- För att ta ut alla kolumner i en tabell kan man skriva
```sql
SELECT * FROM tabellnamn
```

#### TOPX *
- Man vill i princip aldrig be om all data i en tabell (SELECT /* ) då t.ex tabellen "users" kan innehålla tusentals användare
- Ett sätt att begränsa antal rader är genom "TOP X" som begränsar resultatet till x rader
```sql
SELECT TOP 10 * FROM users
```

#### WHERE
- Ett annat sätt att begränsa är att bara be om rader som matchar ett givet villkor. Detta gör man med "WHERE"
```sql
SELECT * FROM users WHERE username = "Micke"
```
![[Pasted image 20231122174455.png]]

#### Logiska operationer
```sql
SELECT * FROM countries
WHERE country = 'Sweden' AND popualtion > 10000

SELECT * FROM countries
WHERE country = 'Sweden' OR country = 'Norge'

SELECT * FROM countries 
WHERE NOT country = 'Sweden'

SELECT * FROM countries
WHERE country <> 'Sweden'
```

#### IN
- I exemplet med "OR" ovan då tog vi ut alla rader där country är "Sweden" eller "Norway". Ett smidigare sätt är att använda "in".
```sql
SELECT * FROM countries WHERE country IN ('Sweden', 'Norway', 'Denmark')
```

- Man kan även använda "NOT IN" för att få alla städer från tabellen som inte ligger i de länder man anger.
```sql
SELECT * FROM countries WHERE country NOT IN ('Sweden', 'Norway', 'Denmark')
```

#### BETWEEN
- Man kan använda BETWEEN för att ange ett spann av värden
```sql
SELECT * FROM countries WHERE population BETWEEN 500000 AND 1000000

SELECT * FROM airports WHERE IATA BETWEEN 'AAF' AND 'AAJ'
```

#### LIKE
- "LIKE" används när man vill matcha textfält mot ett specifikt mönster
- T.ex alla textfält som börjar på "B".
- Uttrycken i tabellen kan kombineras till ett mönster som beskriver data
```sql
SELECT * FROM countries WHERE country LIKE 'b%'
--Alla länder som blrjar på B

SELECT * FROM  airports WHERE IATA LIKE '[acf]_[q-z]'
--Alla IATA som börjar på a, c eller f och slutar på q till z

SELECT * FROM countries WHERE country LIKE '%land%'
--All länder som innehåller order land
```

![[Pasted image 20231122212014.png]]
#### ORDER BY
- Man kan välja att sortera resultatet på en eller flera kolumner
- Om man t.ex vill sortera de rader man tar ut från tabellen "people" på efternamn och i andra hand på förnamn (i de fall personer har samma efternamn kan man skriva)
```sql
SELECT * FROM users ORDER BY firstname
--eller
SELECT * FROM users ORDER BY firstname DESC
--eller
SELECT * FROM users ORDER BY lastname, firstname
--sorterar först på lastname och sedan på firstname
```

Efter varje kolumn vi sorterar på kan vi lägga till "ASC" (ascending) eller "DESC" (Descending) för att ange om det ska vara stigande eller fallande ordning. Anger man inget så används "ASC" som default.
#### DISTINCT
Vill man bara ha unika värden så kan man använda "DISTINCT"
```sql
SELECT DISTINCT lastname FROM users
ORDER BY lastname
```
#### ALIASES
- Aliases används för att in sin query referera till t.ex kolumner eller tabeller med ett annat namn än de har i databasen
- Detta kan vara användbart t.ex för att slippa skriva så mycket eller för att man vill att resultatet ska visas med ett annat namn
```sql
SELECT id, username AS 'Användarnamn', password AS 'Nyckel' FROM users
```
![[Pasted image 20231122212840.png]]

#### CASE WHEN
- Med konstruktionen case-when kan man välja att visa olika värden i resultatet beroende på villkor man angett
```sql
SELECT City,
	CASE
		WHEN population < 1500 then 'Village'
		WHEN population < 50000 then 'Town'
		ELSE 'City'
	END
AS 'Classification'
FROM USCities
```
#### Sätta ihop strängar
- Ibland vill man lägga till information i tabellposterna
- Då kan man använda ett "+"
```sql
SELECT TOP (1000) [Name] + ' med koden ' + [Code] as 'Färger'
	, [Red]
FROM [Colors]
```

- Formatera siffror och de blir strängar
```sql
SELECT TOP (1000) [Name] + ' med koden ' + [Code] as 'Färger'
	, FORMAT(Red, '000')
FROM [Colors]
```
#### Matematiska uttryck
- Det går att utföra beräkningar med hjälp av SQL, på de värden som är lagrade i databasen
```sql
SELECT TOP (1000) 
	[TrackId]
	, [Name]
	, ([Milliseconds] / 1000) AS 'Seconds'
	, ([Bytes] * 0.0000009536) AS 'Mb'
	, ([UnitPrice]) * 12 AS SEK
FROM [everyloop].[music].[tracks]
```
#### FORMAT
- Tal kan vara bra att formatera på olika sätt
```sql
SELECT Productname, FORMAT(UnitPrice, '00.00') FROM company.products
--Ger t.ex 18.00 om UnitPrice är 18
SELECT Country, Population, FORMAT(Population, '### ### ###') FROM Countries
--Ger 2 976 372 om Population är 2976372
```

SQL är mer än bara SELECT-satser. Man kan göra mycket mer med SQL än att bara plocka ut data från tabeller som vi gjort i exemplen ovan. Några viktiga användningsområden som vi kommer att se på framöver är:
- Lägga till, uppdatera och ta bort rader i tabeller
- Skapa och ta bort tabeller och så kallade vyer
- Plocka ut data på aggregerad nivå
- Korsreferera data från flera tabeller
- Skriva funktioner och procedurer med flödeslogik som mer liknar vanlig programmering så som vi är vana vid från t.ex C#

SQL består av:
- Data Manipulation Language (DML)
	- SELECT, INSERT, UPDATE, DELETE
- Data Definition Language (DDL)
	- CREATE, DROP, ALTER
	- GRANT, REVOKE



## Kopiera databastabell
- Ibland vill man göra en kopia av en tabell, allra helst då vi övar på SQL:
```sql
SELECT * INTO company.categoriesTest FROM company.categories

SELECT CategoryName, Id INTO company.categoriesTest2 FROM company.categories

SELECT CategoryName as Cat, Id as IdNumber INTO company.categoriesTest3 FROM company.categories
```
## INSERT - Create
### INSERT
```sql
INSERT INTO company.categoriesTest VALUES(13, 'Candy', 'Candy is the best')

INSERT INTO company.categoriesTest(CategoryName, Id) VALUES('Candy', 16)

INSERT INTO company.categoriesTest(Id, CategoryName, Description) SELECT 25, CategoryName, 'Gamlakategorier: ' + Description FROM company.categoriesTestDB
```

### Bulk INSERT
```sql
INSERT INTO company.categoriesTest(CatgeoryName, Id, Description) VALUES
('Pizza', 16), 'Description'),
('Cookies', 17), 'Description'),
('Veggies', 18), 'Description'),
('Water', 19), 'Description'),
```
## UPDATE
Kommandot UPDATE:
```sql
UPDATE Employees SET LastName = 'Brown' WHERE EmployeeID = 1

UPDATE Employees SET Salary = Salary * 1.5, JobTitle = 'Senior' + JobTitle WHERE DepartmentID = 3
```
☣️OBS! Glöm inte WHERE-klausulen, den talar vad som ska ändras. Annars uppdateras hela rader i angivna kolumnerna
## Jämförelse med NULL
- Kontrollera om något är NULL
```sql
SELECT LastName, ManagerID FROM Employees WHERE ManagerID IS NULL

SELECT LastName, ManagerID FROM Employees WHERE ManagerID IS NOT NULL
```
## DELETE
```sql
--Ta bort rader från en tabell
DELETE FROM Employees WHERE EmployeedID = 1
DELETE FROM Employees WHERE LastName LIKE 'S%'

--Ta bort all rader från en tabell på en gång
TRUNCATE TABLE Employees
```


## Skapa en helt ny databas
```sql
CREATE DATABASE MinEgenDatabas
--Utför ovanstående
GO

--Växla till nya databasen
USE MinEgenDatabas
```
## Radera en databas
```sql
DROP DATABASE MinEgenDatabas
GO
```
## Skapa en ny tabell i en databas
```sql
CREATE TABLE Persons (
	Id int,
	LastName varchar(255),
	FirstName varchar(255),
	Address varchar(255),
	City varchar(255)
)
```


## Datatyper och variabler
- Det är viktigt att välja rätt datatyp för att:
	- Den data man vill lagra SKA KUNNA lagras
	- Att man kan skapa queries som fungerar som det är tänkt
	- Att spara på prestanda och lagringsutrymme
### Sträng-datatyper
![[Pasted image 20231123090551.png]]
### Numeriska datatyper
![[Pasted image 20231123090626.png]]
### Datum och tid
![[Pasted image 20231123090650.png]]
### IDENTITY
IDENTITY är en egenskap man kan välja att sätta på en kolumn av datatyp 'int' (eller flera andra heltals-typer). Databas hanteraren kommer då själv generera värden för denna kolumn enligt en given sekvens (vanligtvis 1, 2, 3, 4,5 osv.) När man sedan sätter in nya rader i tabellen hoppar man helt enkelt över att ange något för IDENTITY-kolumnen som automatiskt får nästa värde i sekvensen.
```sql
CREATE TABLE Persons(
Id int IDENTITY (1, 1), --fungerar också med bara IDENTITY
LastName nvarchar(255),
FirstName nvarchar(255)
)
```
### Konvertera mellan datatyper
- Ibland kan man behöva konvertera en datatyp till en annan. Säg att du vill läsa ut en datetime och t.ex lagra i ett nvarchar-fält (kanske för att du klippte in datumet i en längre text) då kan du använda CONVERT.
```sql
CONVERT(nvarchar, @myDatetime, 121)
```

121 är en formateringskod som anger hur DateTime-värdet ska representeras som en sträng.
[Convert DateTime to String in a Specified Format in SQL Server](https://www.sqlservertutorial.net/sql-server-system-functions/convert-datetime-to-string/)

### Datatyper
- Olika datatyper lagras på olika sätt i en databas
- När man skapar en tabell behöver man därför anger en datatyp för varje kolumn så databashanteraren vet hur informationen ska lagras
- Olika databaser (mjukvaror) hr olika datatyper
- De flesta databaser har ett ganska stort antal olika datatyper att välja mellan men oftast är det ett relativt fåtal som är vanligt förekommande
#### Vanliga datatyper
![[Pasted image 20231123094732.png]]

### Deklarera variabler
- För att använda variabler i SQL behöver man först deklarera dem
```sql
--DECLARE <@variablename> (as) <datatype>
DECLARE @username AS nvarchar(25)
```
### Tilldela värden på variabler
- Man kan tilldela värden på variabler när man deklarerar dem:
```sql
DECLARE @username AS nvarchar(25) = 'Admin'
```

- Eller så kan man tilldela eller ändra det senare:
```sql
SET @usernme = 'Micke'
```

- Man kan även sätta ett värde från en tabell till en variabel:
```sql
SET @username = (SELECT TOP 1 username FROM users)
```
### Tilldela variabler med SELECT
Istället för SET kan man använda SELECT för att sätta variabler:
```sql
SELECT TOP 1 @name = user, @pass = password FROM users
```
### Referera till värden i variabler
- Man kan använda PRINT för att skriva ett värde till "meddelanden"
```sql
PRINT @username
```

- Man kan även använda variabler i queries
```sql
SELECT * FROM users WHERE username = @username
```

### Globala variabler
- Globala variabler är variabler som SQL Server sätter automatiskt men som vi kan läsa och använda oss av.
![[Pasted image 20231123100418.png]]
### Tabell-variabel
- Man kan även lagra en hel tabell i en variabel. Man deklarerar då variabel som datatyp TABLE
```sql
DECLARE @product_table TABLE(
ProductName nvarchar(100),
UnitPrice float,
UnitsInStock int
)
```
och kan sedan använda den som en vanlig tabell
#### Sätt in data i en tabell variabel
- Man använder INSERT
```sql
INSERT INTO @product_table
	SELECT ProductName,
	UnitPrice,
	UnitsInStock
	FROM company.products
WHERE SupplierID = 1
```
#### Hämta data från en tabell variabel
- Man använder SELECT
```sql
SELECT * FROM @product_table
```

## Aggregering
### Aggregerad data
- Data som är en sammanslagning av flera datapunkter, till exempel ett medeltal eller en totalsumma, kallas aggregerad data. Den vanligaste anledningen till att man vill skapa ett sådant aggregat är för att öka överskådligheten och eller visa statistik.
- Antag att vi har en tabell med rådata som innehåller ett klockslag för varje gång en bil passerat över en bro. Om vi vill få en överblick över datat kan vi välja att aggregera antal bilar per timme eller kanske per dag. Om det även finns uppgifter om vilket land varje bil är från i rådatat så kan vi välja att aggregera per land.
### Aggregeringsfunktioner i SQL
- En aggregeringsfunktion tar en lista med värden. gör en beräkning på dessa och returnerar ett värde (skalär)
- I SQL finns det ett antal funktioner som används för aggregering. Den kanske mest grundläggande är COUNT() som helt enkelt räknar antalet rader.
	- SUM()
	- AVG()
	- STDEV()
	- MIN()
	  MAX()
	  STRING_AGG()
#### COUNT()
- COUNT() tar ett kolumnamn som parameter och räknar alla värden i kolumnen som inte är NULL
- Om man vill räkna samtliga, även de som är NULL, så skriver man COUNT(\*)
```sql
SELECT COUNT(stad) FROM städer WHERE land = 'Sverige'
--returnerar antalet städer som enligt tabellen städer finns i Sverige
```

- Man kan ange DISTINCT i COUNT() för att bara räkna unika värden:
```sql
SELECT COUNT(DISTINCT land) FROM städer
--returnerar antalet unika länder från tabellen städer
```
### Gruppering av data
- I aggregeringsexemplen ovan så får vi bara ut ett enda värde: antalet städer i Sverige, samt i andra exemplet antal unika länder i tabellen med städer
- Oftast vill vi dock gruppera data och få ut aggregatet för varje grupp i tabellform. Kanske vill vi inte bara veta antalet svenska städer som tabellen innehåller, utan vi vill veta antalet städer för varje land
- Då behöver vi gruppera vårt data per land och sedan räkna antalet städer i varje grupp.
#### GROUP BY
- I slutet av vår SELECT-sats kan vi lägga till GROUP BY följt av en eller flera kolumner som vi vill gruppera på
- Det är endast de kolumner som vi har valt som kan användas för gruppering
- Övriga måste vara i form av aggregat. Alltså, om vi grupper på land så kan vi direkt ta ut landet som en kolumn eftersom det blir just en grupp per land, men vi vill ta ut antal städer (count) eller en summering av invånare i städerna (sum) så måste vi ange en aggereringsfunktion
```sql
SELECT land, COUNT(stad) FROM städer GROUP BY land
--returner antalet städer för varje land
```
### Rådata ⇒ aggregerad data
Exempel på hur rådata över städer ser ut i aggregerad form om man grupperar på land, räknar städer och summerar invånare
![[Pasted image 20231123110847.png]]
### HAVING
- Precis soma tt man ibland ville ge villkor för vilka rader man vill fp ut, så vill man ibland ge villkor på vilka grupper man vill visa i resultatet. Detta gör man med HAVING. Kanske vill vi gruppera på land, men bara ta ut de grupper som har fler än 10 städer:
```sql
SELECT land FROM städer GROUP BY land HAVING COUNT(stad) > 10
```

☣️Vi kan inte använda WHERE för grupper eftersom det redan används med en annan betydelse. Tänk om vi t.ex vill gruppera på land men bara ta med städer med fler än 100 000 invånare (WHERE) och sedan visa de grupper som har mer än 10 sådana städer (HAVING).
## Funktioner
- SQL-Server har en massa inbyggda funktioner som kan vara användbara
```sql
FLOOR(RAND() * (100-30)) + 30)
```
- FLOOR = avrunda
- RAND = Slumptal mellan 0 + 1
	- Exemplet ovan ger ett slumptal mellan 31 och 99

En samling av vanliga SQL-funktioner
[[VanligaFunktioner.sql]]


# SSMS
## Köra delar av SQL-satsen
- Ett enkelt sätt att köra bara visa rader i en SQL-sats är att markera raden och klicka på Execute
## Köra flera SQL-satser
- Det går bra att köra flera SQL-satser efter varandra. Flera SELECT-satser öppnar flera tabellvyer
## Snabb SELECT
- Höger klicka på tabellens namn i Object Explorer och välj Select Top 1000 rows
## Växla mellan databaser
Aktuella databasen visas i ett fönster ovanför Object Explorer. Klicka i rutan och välj en annan databas för att växla. Det går även att skriva 
```sql
USE databasename
```
i query fönstret