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

