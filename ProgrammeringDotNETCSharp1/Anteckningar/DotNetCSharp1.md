---
banner: https://images.unsplash.com/photo-1587620962725-abab7fe55159?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=1931&q=80
---
# .NET och programmeringens grunder
## Programmeringens faser
- Definiera ett problem = Specifikation
- Planera lösningen = Design
	- Agil utveckling
	- Hitt lämplig metod
	- Hitta lämpliga datastrukturer
- __Skriv kod = Implementation
- __Fixa fel i koden = Test och Debug__
- Gör kunden glad = Driftsättning

## Vad behöver du för att programmera?
- Ett problem att lösa
- Kunskap om ett programmeringsspråk
	- C#
- Utvecklingsmiljö, kompilatorer, SDK
	- Visual Studio, .NET SKD (Software development kit)
- En uppsättning med standardklasser
	- Microsoft .NET FCL (framework class library)
- Hjälp, documenation
	- Microsoft Docs - <https://docs.microsoft.com/en-us/dotnet/csharp/>

## Vad är C#?
Programmeringsspråk
Egenskaper hos C#
- Modernt
- Extremt kraftfullt
- Lätt att lära
- Lätt att läsa och förstå
- Objektorienterat

## Vad finns i ett program?
### Indata
- Någon form av data som matas in av användaren
- Indata från databaser, sensorer, knapptryckningar

### Utdata
- Programmet kommer fram till ett resultat som sedan skrivs ut på skärmen

```cs
Console.WriteLine("Hello World");
```

### Variabler
- En variabel är ett sätt att lagra ett värde
- Det kan vara ett tal, en text-sträng eller mycket mer komplicerade datatyper
```cs
int x = 23;
string name = Anders;
```

### Loopar och villkor
De flesta program för samma sak flera gånger, repeterar.
```cs 
for(int i = 1; i < 10; x++)
{
	if(i<5)
	{
		Console.WriteLine(i);
	}
}
```

### Operatorer
Värdet i variabler kan ändras enligt matematiska "formler"
```cs
int a, b, c;
a = 7;
b = a;
c = b +3;
b = a + b * c;
```

### Hello World i C\#
```cs
using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
		}
	}
}
```

## Var är .NET?
- En miljö för att köra .NET program
- Ett kraftfullt bibliotek av klasser
- En programmeringsmodell
- En gemensam motor för att köra kod i många olika språk
	- C#
	- VB.NET
	- C++
	- F#
	- och många andra

Kan användas för att bygga ett brett spektrum av applikationer. Webb till mobil till Windows-baserade applikationer.

## Visual Studio
- En komplett utvecklingsmiljö
- En modern IDE - Integrated Development Environment
- Verktyg för att
	- Skriva kod
	- Bygga användargränssnitt
	- Kompilera kod
	- Köra/testa/avlusa applikationer
	- Hantera filer i ett projekt
	- Versionshantering

# C\#
## Kommentarer
Viktigt att kommentera kod av olika anledningar. Kommentarer ska vara självförklarande men även ska användas med en viss måtta.

```cs
//Enradskommentar

/*
Blockkommentar
*/
```

## Datatyper
### Varför välja datatyp?
- Minnesåtgång
- Begriplighet
- Framtida beräkningsbehov, t.ex medelvärde
- Säkrare programmering. Konstiga värden kan inte ta sig in lika lätt

### Primitiva datatyper
![[Pasted image 20230913092820.png]]

### Datatyper
```cs
int myNum = 5;
double myDoubleNum = 5.99D;
char myLetter = 'D';
bool myBool = true;
string myText = "Hello";
```

#### var
- __var__ låter kompilatorn själv bedöma vilken datatyp som ska användas

```cs
var myText = "Hejsan";
var myNumber = 123;
```

Lätt att använda men blir ibland fel.

#### string
Används för att lagra en sekvens av tecken (text). Omges av dubblat citattecken.

Ibland vill man ha tecknet " inne i en sträng, använd då escape-tecknet \.

#### int
Kan lagra heltal från ca -2,2miljarder till 2,2 miljarder.
När fungerar inte int?
- större värden
- tal med decimal noggranhet

##### Andra heltalstyper
- sbyte (-128 - 127)
- byte (0 - 255)
- short
- ushort
- __int__
- uint
- long
- ulong

#### long
Används när int inte är tillräckligt stor för att lagra värdet. Värdet avslutas med "L".
```cs
long myLong = 1234567890L;
```

#### double
Precision på 15 decimaler.

#### decimal
- Precision på 28-29 decimaler.
- Används när man räknar med pengar
- Inga avrundningsfel
- Nästan ingen förlust av precision
- Standardvärde = 0.0M (M är suffixet för sådana här decimaltal)

#### bool
Endast två värden: true eller false.

#### char
Används för att lagra enskilt tecken. Tecknet måste vara omgivet av ' '.
```cs
char myChar = 'D';
```

#### Exempel


```cs 
byte centuries = 20; // Usually a small number 
ushort years = 2022; 
uint days = 730480; 
ulong hours = 17531520; // May be a very big number

Console.WriteLine("{0} centuries is {1} years, or {2} days, or {3} hours.", centuries, years, days, hours);
```

### Konvertera mellan datatyper

```cs
//sting to int
int numberInt = int.Parse(number)

//int to float
float numberFloat = numberInt;

//Convert
double doubleNum = Convert.ToDouble(numInt)

//Casting
int numInt = (int)numDouble;

//Get variable type
Type t = numInt.GetType();
```

## Variabelnamn
- åäö ska ej användas som variabelnamn
- engelska namn används på alla namn
- två variabler kan inte heta samma sak
- vissa namn är "låsta" då de är nyckelord i språket (int, double, string, osv.)
- använder man stora och små bokstäver så måste detta följas senare. 
```cs
mittHELTAL != mittHeltal
```
- tydlighet är viktigt
```cs
//Korrekt men inte uppenbart
a = b * c;

//Att föredra
weeklyPay = hoursWorked * hourlyPayRate;
```
- använd __lowerCamelCase__
- använda variabelnamn som är beskrivande
- anta och håll fast vid en stil för att namnge variabler
- namnge inte variabler med bara versaler

### Legality

![[Pasted image 20230913101518.png]]

### Rekommendationer för variabelnamn
![[Pasted image 20230913101828.png]]

## Operatorer
- +
- -
- *
- / 
- % (modulus) - returnerar resten (återstoden) av en division
	- 10 % 5 = 0
	- 9 % 4 = 1

## Bool och villkor
### Parenteser
- { och } - början och slutet på kodblock
- \[ och ] - används för matriser och listor
- ( och ) - anger grupper av termer eller tal

### Datatypen bool
- deklareras med nyckelordet bool
- har två möjliga värden: true och false
- användbart i logiska uttryck och villkor
- Standardvärdet är false

### Villkor
#### Jämförelse operatorer
```cs
//Lika med
a == b;
a < b;
a <= b;
a > b;
a >= b;
a != b;

bool result = 5 <= 6;
Console.WriteLine(result); //True
```
Villkoret ska vara sant för att något ska händer

#### if
```cs
if (villkor)
{
	Kod;
}
```

#### Logiska operatorer
- INTE - !
- OCH - &&
- ELLER - ||

```cs
//båda villkor måste vara sanna
if (name == "micke" && timme > 18)
{
	Console.WriteLine("God kväll, herr Engström!")
}

//ett av villkoren måste vara sant
if( timme < 9 || timme > 18)
{
	Console.WriteLine("Butiken är stängd.")
}
```

#### Fler villkor
if - else if - else.
```cs
if(villkor)
{
	Kod;
}
else if
{
	Kod;
}
else
{
	Kod;
}
```

## Loopar
- while
- do ... while
- for

### while
```cs
while(villkor)
{
	Kod;
}

int x = 0;
while(x < 100)
{
	Console.WriteLine(x);
	x++; //eller x = x + 1 eller x += 1
}
```
Körs tills villkoret blir falskt. Testar tillståndet innan loopen utförs.

### do ... while
```cs
do
{
	Kod;
}
while(villkor)

int x = 0;
do
{
	Console.WriteLine(x);
	x++; //eller x = x + 1 eller x += 1
}
while(x < 100)
```
Testar tillståndet efter loopen utförs. Loopen körs alltid minst en gång.

### for
```cs
for(int x = startvärde; villkor för x; inkrementering)
{
	Kod;
}

for(int i = 1; i <= 10; i++)
{
	Console.Write(x);
}
```

## Switch
Ett enkelt sätt att skapa ett antal villkor av liknande sort.

```cs
switch(uttryck)
{
	case x:
		Kod (som körs om uttrycket = x)
		break;
	
	case y:
		Kod (som körs om uttrycket = y)
		break;
	
	default:
		Kod ( som körs om uttrycker är varken lika med x eller y)
		break;
}


int caseSwitch = 1;

switch (caseSwitch) 
{ 
	case 1: 
		Console.WriteLine("Case 1"); 
		break; // Avbryter switch-satsen 
	case 2: 
		Console.WriteLine("Case 2"); 
		break; // Avbryter switch-satsen 
	default: 
		Console.WriteLine("Default case"); 
		break; // Avbryter switch-satsen 
}
```

Om _break;_ saknas från varje case kommer koden att generera kompilatorfel.
Det är däremot inte obligatoriskt att ha en _default_ case.

Det går även att ha flera villkor som stämmer överens och kör samma kod:
```cs
int caseSwitch = 1;

switch (caseSwitch) 
{ 
	case 1: 
		Console.WriteLine("Case 1"); 
		break; // Avbryter switch-satsen 
	case 2:
	case 3: 
		Console.WriteLine("Case 2 och Case 3"); 
		break; // Avbryter switch-satsen 
	default: 
		Console.WriteLine("Default case"); 
		break; // Avbryter switch-satsen 
}
```

Exempel:
```cs
Console.Write("Ange namn: "); 
string name = Console.ReadLine();

switch(name) 
{ 
case "micke": case "håkan": 
	Console.WriteLine("Lärare"); 
	break; 
case "christer": 
	Console.WriteLine("Chefen"); 
	break; 
default: 
	Console.WriteLine("Elev"); 
	break; 
}
```

- Det måste finnas ett separat för varje normal situation
- Lägg det normala fallet först
	- Lägg det mest använda fallet först, de sällan använda sist
- Sortera fallen alfabetiskt, numeriskt eller vad som är lämpligt
	- Tänk på att koden skall vara lätt att läsa för människor
- Använd fallet default för att hantera sådana fall som inte skall kunna inträffa under normala omständigheter


## Metoder
- En metod är som ett byggblock som löser ett litet problem
- Ett stycke kod som har ett namn och som kan anropas från en annan plats i programmet
- Kan ta emot parametrar och returnera ett värde
- Låter oss bygga stora program av små enkla bitar
- Kallas också funktioner, procedurer och subrutiner i andra språk

### Varför?
- Mer hanterlig programmering
	- dela upp stort problem i mindre bitar
	- bättre organisation i programmet
	- Förbättra läsbarhet
	- underlätta förståelse
- Undvika upprepningar
- Återanvändbarhet
	- använd en metod flera gånger
- "Gömma undan" kod som man inte behöver känna till - Abstraktion

### Enklaste metoden
```cs
static void Hello()
{
	Console.WriteLine("Hello;")
}
```

### Deklarera metoder
En metod är ett stycke kod med ett namn
- __static__ (Åtkomsttyp)
- __void__ (Returtyp. Vilken datatyp som ska returneras)
- __Hello()__ (Namn på metoden)

### Anropa metoden
```cs
static void Main(string[] args)
{
	Hello();
}
```

### Metoder med inparametrar
- För att skicka information till en metod används parametrar (kallas även argument)
	- skicka noll eller flera värden
	- skicka värden av olika typ
	- varje parametrar har namn och typ
	- parametrar får värden när metoden anropas
	- parametrar kan ändra hur metoden fungerar beroende på deras värden

```cs
static void SayHello(string name)
{
	Console.WriteLine("Hej" + name)
}
```

### Anropa metoden
```cs
static void Main (string[] args)
{
	SayHello("Micke");
}
```

### Definiera och använd metodparametrar

- Metodens beteende beror på parametrarna
- Parametrar kan vara av godtycklig typ
	- int, double, string, etc.
	- Arrays (int[], double[], etc.)

```cs
static void PrintSign(int number) 
{ 
	if (number > 0) 
		Console.WriteLine("Positive"); 
	else if (number < 0) 
		Console.WriteLine("Negative"); 
	else 
		Console.WriteLine("Zero"); 
}
```

### Anropa metoder med parametrar
- För att anropa en metod och skicka värden till dess parametrar:
	- använd metodens namn, följt av en lista av uttryck för parametrarna
- Uttryck måste vara av samma datatyp som metodens parametrar (eller kompatibla)
- Om metoden vill ha en float, kan du skicka en int istället 
	- "Kan" betyder inte att det är bra idé!
	- Använd samma ordningsföljd som i metodens deklaration 
	- För metoder utan parametrar: glöm inte parenteserna! 
		- SayHello()

 - PrintPerson(82, “Micke”);
 - PrintPerson (23 + 45, name);
 - PrintPerson(GetWeight(), GetName())

### Skicka tillbaka värden från metoder
◦ Istället för void anger vi vilken typ av data som skall returneras 

static int Multiply(int firstNum, int secondNum) 
{
return firstNum * secondNum; 
}

- Metoder kan returnera alla datatyper (int, string, array etc.) 
- void-metoder returnerar ingenting
- Kombinationen av metodens namn och dess parametrar kallas signatur
- Använd nyckelordet __return__ för att skicka tillbaka resultatet

```cs
static void Main() 
{ 
	Console.Write("Temperature in Fahrenheit: "); 
	double t = Double.Parse(Console.ReadLine()); 
	t = FahrenheitToCelsius(t); 
	Console.Write("Temperature in Celsius: {0}", t); 
} 

static double FahrenheitToCelsius(double fahrenheit) 
{ 
	double celsius = (fahrenheit - 32) * 5 / 9; 
	return celsius; 
}
```

![[Pasted image 20230918132942.png]]

![[Pasted image 20230918133221.png]]


### Fyra typer av metoder
- Metoder som inte tar in parametrar och inte returnerar något
- Metoder som tar in parametrar med inte returnerar något
- Metoder som inte tar in parametrar men returnerar något
- Metoder som tar in parametrar och returnerar något

### Hur kan vi anropa metoder?
- Huvudprogrammet kan anropa metoder (Main() är faktiskt en metod också)
- Metoder kan anropa metoder
- Metoder kan anropa sig själv (rekursiva metoder)

## Scope
Begrepp som förklarar var vi har tillgång till vissa variabler.

### Classe level scope
- Att deklarera variablerna i en klass, men utanför en metod kan nås direkt var som helst i klassen.
- Dessa variabler kalls också fält eller klassmedlemmar
- Variabelns omfång på klassnivå kan nås av metoderna i den klass den deklareras.

```cs
using System;

class Program
{
static int a = 0;

==> Main method
}
```

### Method level scope
- Variabler som deklareras i en metod har omfång på metodnivå
- Dessa är inte tillgängliga utanför metoden
- Dessa variabler kan dock nås av koden inuti metoden
- Dessa variabler kallas lokala variabler
- Det uppstår kompileringsfel om dessa variabler deklareras två gånger med samma namn i samma omfång
- Dessa variabler finns inte när metodens körning är över
```cs
public void Display()
{
	int m = 47;
	Console.WriteLine(m);
}

public void Display2()
{
	Console.WriteLine(m);//Fungerar inte!
}
```
### Block level scope
- Dessa variabler deklareras i allmänhet inuti for eller while-loopar.
- Dessa variabler kallas också loopvariabler eller satsvariabler eftersom de har begränsat sitt omfång till det block de befinner sig i.

```cs
static void Main(string[] args)
{
    int i = 0;
    for (i = 0; i < 4; i++)
    {
        Console.WriteLine(i);//0, 1, 2, 3
    }
    Console.WriteLine(i);//4
}
```

## Slump
```cs
Random rnd = new Random();
int random = rnd.Next(1, 3);

//eller

Random.Shared.Next(1, 3);
```
## Arrayer
### En-dimensionella arrayer
- En vektor (array) är en sekvens av element av samma typ (string, bool, osv.)
- Ordningsföljden är fast
- Har en fast storlek (Array.Length)
![[Pasted image 20230925103031.png]]

Deklarationen talar om elementtypen. Hakparenteser \[ ] betyder array.

```cs
int[] myIntArray;
myIntArray[] = new int[5]; //5 int element från 0-4.

myIntArray[0] = 25;
myIntArray[1] = 345;
myIntArray[2] = 7;
myIntArray[3] = 47;
myIntArray[4] = 63;
```

Ett kortare sätt att skapa array:
```cs
int[] myIntArray = {23, 345, 7, 47, 63};
```

#### Se värden i en array
Åtkomst till array-element görs genom operatorn hakparentes \[ ].
- kallas indexerare
- Indexeraren tar elementets index som parameter
- Det första elementet har index 0

#### Skriva ut ett värde
```cs
int[] myIntArray = {23, 345, 7, 47, 63}
Console.WriteLine(myIntArray[2]) //Skriver ut "7";
```

#### Skriva ut längden på array
```cs
Console.WriteLine(myIntArray.Length); //Skriver ut 5

Console.WriteLine(myIntArray[myIntArray.Length - 1]); // Skriver ut 63;
```

#### Skriva ut alla värden
```cs
for( int i = 0; i < myArray.Length; i++)
{
	Console.WriteLine(myIntArray[i]);
}
```

#### Ändra värde i en array
```cs
int[] myIntArray = {23, 345, 7, 47, 63}

myIntArray[2] = 99;
```

#### for eller foreach
- En for-loop fungerar utmärkt för att lista innehållet
- En enklare variant är foreach, som lista hela arrayen och inte håller reda på vilket index värden har
```cs
foreach(type value in array)
{

}
```
Används när ingen indexering behövs
- alla element hanteras ett i taget
- read-only
```cs
int[] myIntArray = {23, 345, 7, 47, 63}

foreach(int num in myIntArray)
{
	Console.Write(num);
}
```

##### Exempel:
```cs
string[] capitals = 
{
	"Stockholm",
	"Washington",
	"London",
	"Paris"
};

foreach (string capital in capitals)
{
	Console.WriteLine(capital);
}
```

#### Sortera en array
- Att sortera en array i bokstavsordning görs enkelt såhär:
```cs
Array.Sort(capitals);
```

### Matriser - flerdimensionella arrayer
Vanliga arrayer består av en följd av data
Matriser har mer än en dimension (2, 3 eller flera)
- Den viktigaste och vanligaste är de med två dimensioner (kan också kallas tabell)
	
Exempel på en matris av heltal med två rader och 4 kolumner:
![[Pasted image 20230927103947.png]]

#### Deklarera och skapa matriser:
```cs
int[,] intMatrix = new int[3, 4];
float[,] floatMatrix = new float[8, 2];
string[,,] = strCube = new string[5, 5, 5];
```

##### Exempel:
```cs
int[,] myTable = new int[2, 2]
myTable[0,0] = 25;
myTable[0,1] = 19;
myTable[1,0] = 5;
//Osv.

int[,] myMatrix = {
{1, -1, 13, 47},
{52, 60, -7, 888}
//Matrixens storlek är 2 x 4 (2 rader, 4 kolumner)
}

//Ta fram på en utvald post i matrisen:
Console.WriteLine(myMatrix[1,2]); //Kommer ge -7
```

#### Visa en matris
```cs
int[,] myMatrix = 
{
	{1, -1, 13, 47},
	{52, 60, -7, 888}
}

for (int i = 0; i<2; i++)
{
	for(int j = 0; j < 4; j++)
	{
		Console.Write(myTable[i, j] + "\t");
	}
	Console.WriteLine();
}
```

#### Antalet rader och kolumner?
```cs
int[,] myMatrix = 
{
	{1, -1, 13, 47},
	{52, 60, -7, 888}
}

for (int i = 0; i < myTable.GetLength(0); i++)
{
	for(int j = 0; j < myTable.GetLength(1); j++)
	{
		Console.Write(myTable[i, j] + "\t");
	}
	Console.WriteLine();

}
```

## List
En __List__ är en enkel form av array. Det är möjligt att ändra storlek i en  __List__.
- __List\<T\> - vektor som kan ändra sotrlek dynamiskt
	- kan lägga till eller ta bort poster
	- Har indexerare som vektorer
```cs
List<int> intList = new List<int>();

for(int i = 0; i <5; i++)
{
	intList.Add(i);
}
```

När man använder Listor behöver man inte veta i förväg hur många element som behövs.

```Cs
List<string> words = new List<string>()
{
	//Lägga till:
	words.Add("Hejsan");
	
	//Lägga till fler
	string[] words = { "Hej", “på", "dig"};
	words.AddRange(words2.ToList());
}
```
## Fler filer/klasser i ett projekt
- Class
	- En klass är en programkodmall för att skapa objekt, tillhandahålla initialvärden för tillstånd (medlemsvariabler) och implementeringar av beteende (medlemsfunktioner eller metoder)
	- Ett sätt att dela upp kod
	- Ett sätt att gruppera saker som hör ihop
- Åtkomstmodifierare
	- public
		- all kod i hela programmet kommer åt klasser och metoder som är public
	- internal
		- ca samma sak som public men bara filerna i samma projekt kommer åt detta


## null 
- Null är ett nyckelord som betyder att INGET värde finns. 
- Det är inte samma som 0 (Noll)
- Det är inte samma som “” (en tom sträng)
- Om man försöker göra vissa funktioner med en variabel som är null, så får man ett felmeddelande.

```cs
string enText = null;
Console.WriteLine(enText.ToUpper());
// Vi kommer få ett fel: System.NullReferenceException
```

## Ternary Operator ?
- C# har en så kallad beslutsfattande operator, som är ett frågetecken “?”. 
- Man kan se det som en kortform av if-else
- Det används såhär:
```cs
condition ? statement1 : statement2
```

- Condition = villkor 
- Om condition == true så körs statement1
- Om condition == false så körs statement2
- Ett annat sätt att säga det på:
	- Villkor ? Detta händer om villkoret är sant : Detta händer om villkoret är falskt
### Exempel 1 - Ternary Operator

```cs
int x = 10, y = 20;
var result = x > y ? "x is greater than y" : "x is less than y"; Console.WriteLine(result);

//Det är samma sak som:
int x = 10, y = 20; 
if (x > y) 
	Console.WriteLine("x is greater than y"); 
else 
	Console.WriteLine("x is less than y");

```

### Exempel 1 - Kolla null

```cs
Console.WriteLine(minText == null ? "Inget värde på strängen" : minText.Length);
```

## Filer
### Spara och läsa objektlistor från fil
Vi kommer att prata om mer effektiva metoder om detta seanrie kursen, med JSON-serialisering.
Men en enkel metod att spara och läsa data är med hjälp av ReadAllLines och WriteAllLines De metoderna jobbar med arrayer, och vi måste därför själva bestämma vårt “filformat”. 
#### Exempel:
```cs
string[] minArray = { "banan", "äpple", "apelsin" };
```

### Skriva till textfil
```cs
File.WriteAllLines(“fruits.txt", minArray);
```

### Läsa från textfil
```cs
var minArray = File.ReadAllLines(“fruits.txt")
```

### Kolla om filen finns
```cs
File.Exists(“fruits.txt") //Returnerar en bool
```

### Var hamnar filen?
- Leta upp ditt Visual Studio-project 
- Gå in I Mappen med projektnamnet.
- Leta dig ner enligt de här mapparna: 
	- \bin\Debug\netX.0
- 

## Objektorientering (OOP)
Objektorientering gör det möjligt att hantera "prylar, objekt, saker" som en egen entitet.
### Vad är objektorienterad programmering?
- Refererar till språk som använder __objekt__ i programmering
- Syfta till att implementera verkliga enheter
- Huvudsakliga syftet är att binda samman data och de funktioner som fungerar på dem så att ingen annan del av koden kan komma åt dessa data förutom just den funktionen.
- Innebär några viktiga pelare: __arv__, __inkapsling__, __polymorfism__.
### Glödlampa
Behöver vi veta allt som ingår i att tända en lampa? (tråd, transformator, osv.)
Lampan är ett objekt och det enda vi behöver kunna är att trycka på en strömbrytare. Allt annat är vanligtvis gömt.
### OOP
Ett programmeringsparadigm som tillåter att paketera samman data och funktionalitet för att ändra dessa data samtidigt som detaljerna döljs undan (som med glödlampan). Koden blir då __flexibel__, __modulär__ och __abstrakt__. Det gör det särskilt användbar när man skapar större program.
### Fördelar med OOP
- snabbare och enklare att utföra
- tydlig struktur i programmen
- Hjälper till att hålla koden DRY (Don't repeat Yourself) och gör koden lättare att underhålla, ändra och felsöka
- Möjliggör att skapa återanvändbara applikationer med mindre kod och kortare utvecklingstid
### Begrepp
- Klasser / Classes
- Fält/attribut / Fields/attributes
- Egenskaper / Properties
- Konstruktor / Constructor
- Åtkomstmodifierare / Access Modifiers
- Metoder
### Klasser
- En klass används i objektorienterad programmering för att beskriva ett eller flera objekt. Den fungerar som en mall för att skapa, eller instansiera, specifika objekt inom ett program
- Ett sätt att gruppera olika saker

```cs
public class Customer 
{ 
//All kod som beskriver och hanterar en Customer finns här 
//Fields, properties, methods and events go here... 
}
```
### Klasser och Objekt
- Klasser beskriver en samling av attribut och metoder
- Klassen Program
	- Metoden Main()

- Klassen Fruits
	- Attribute Type - Objektet Banan, Objektet Apelsin, Objektet Päron
	- Metoden MakeFruitSallad()

- Klassen Car
	- Attribut CarBrand - Objektet Volvo, Objektet  Toyota
	- Metoden StartCar()

### C# och klasser
Allt i C# är associerat med klasser och objekt tillsammans med dess attribut och metoder. 
T.Ex: en katt är ett objekt. Vikt, färg, ras är attribut.

En klass är som en objektkonstruktör eller en "ritning" för att skapa objekt.

### Attribut - Attributes
- Alla objekt har någon form av attribut.
- En bil kan t ex ha följande egenskaper 
	- Färg
	- Ålder
	- Antal hjul
	- Hel eller trasig
	- Registreringsskylt
	- Ägare
	- Namn
	- Märke
### Klasser och attribut
En klass kan innehålla många fler saker än metoder:
- Attributes eller Fields
- Properties
- Methods
- Constructor

```Cs
internal class Fruit
{
	//Åtkomsten är public så vi kommer åt den från andra klasser t.ex Program
	public string type = "Apple";
	//Här kan man lägga i metoder som man gjort innan.
}
```

### Datatyper
Vi har hittills arbetat med primitiva datatyper ◦ int, string, double, ulong, bool, osv.
När vi arbetar med klasser och objekt så använder vi istället klassens namn som datatyp: Cat, Fruit, Car, osv.

### Använda en klass

```cs
//Först skapar vi en ny frukt (en instans av Klassen Fruit)
Fruit f = new Fruit();

//Sedan läser vi en av fruktens variabler (ett attribut som Fruit har)
string type = f.type;

//Sist skriver vi ut attributet i konsollen
Console.WriteLine(type);

//Detta skriver ut Apple
```
### new vs static
- Hittills har vi använt våra klasser en och en, dvs vi har inte behövt flera “versioner” av samma klass.
- Då behöver vi inte instansiera, och anger det med nyckelordet static.
- Men om vi behöver många instanser av ett object, t ex flera bilar eller flera frukter, så måste vi skapa en ny “version” av objektet, d v s instansiera med nyckelordet new.
- Då kan vi ha en hel parkeringsplats eller en stor fruktskål

### Åtkomst - Access
- __public__: The type or member can be accessed by any other code in the same assembly or another assembly that references it. 
- __private__: The type or member can be accessed only by code in the same class or struct.
- __protected__: The type or member can be accessed only by code in the same class, or in a class that is derived from that class.
- __internal__: The type or member can be accessed by any code in the same assembly, but not from another assembly.
- __protected internal__: The type or member can be accessed by any code in the assembly in which it's declared, or from within a derived class in another assembly
- __private protected__: The type or member can be accessed only within its declaring assembly, by code in the same class or in a type that is derived from that class.

```cs
//Fruit.cs
internal class Fruit
{
	public string type = "Apple";
}

//Program.cs
internal class Program
{
	static void Main(string[] args)
	{ 
		Fruit fruit = new Fruit();
		Console.WriteLine(fruit.type);
	}
}

//Sätta ett värde på attributet senare
//Fruit.cs
internal class Fruit
{
	public string type;
}

//Program.cs
internal class Program
{
	static void Main(string[] args)
	{ 
		Fruit fruit = new Fruit();
		fruit.type = "Banan";
		Console.WriteLine(fruit.type);
	}
}

```

### Skapa flera objekt
Det är enkelt att skapa nya objekt:
```cs
Fruit fruit1 = new Fruit();
Fruit fruit2 = new Fruit();

//Eller i en loop
for(int = 0; i < 10; i++)
{
	Fruit fruit = new Fruit();
}

```

### Klasser och metoder
Eftersom en class (ett object) är som vilken datatyp som helst, kan vi även använda dem som inparametrar och returvärde i en metod.
```cs
public static Fruit CalculateWeight(Fruit fruit)
{
	fruit.weight = 0.23;
	return fruit;
}
```
