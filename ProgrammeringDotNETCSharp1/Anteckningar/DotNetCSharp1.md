---
banner: ProgrammeringDotNETCSharp1/Anteckningar/james-harrison-vpOeXr5wmR4-unsplash.jpg
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
![[Pasted image 20230913094717.png]]

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

//ett av vollkoren måste vara sant
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