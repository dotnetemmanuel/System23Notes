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
# SQL Server Management Studio
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
