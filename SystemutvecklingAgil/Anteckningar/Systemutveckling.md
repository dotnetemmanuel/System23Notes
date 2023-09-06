---
sticker: lucide//laptop-2
banner: https://images.pexels.com/photos/3183186/pexels-photo-3183186.jpeg
---

# Hårdvaran
Hårdvaran delas typiskt i fyra olika kategorier
- Inmatning
	- tangentbord, kamera, osv.
- Utmatning
	- Skärm, högtalare, osv.
- Lagring
	- Hårddisk, filsystemet, osv.
- Kommunikation
	- nätverkskabel, bluetooth, Wi-Fi, osv.

# Mjukvara
Program och applikationer.
Mjukvara kan innehålla scripts, kommandofiler, osv. 
Installerat på ett operativsystem.
	- Microsoft Windows
	- Unix
		- Linux
		- MacOS och iOS
		- Android

# Operativsystem
Hanterar hårdvara, processer, minnesallokering, säkerhet, filhantering, filsystem och lagring, kommunikation mellan olika processer, osv.

# Filer och mappar
Det är viktigt att följa filnamnskonventioner.
Skiftlägeskänsligt - stora och små bokstäver är olika
	- Ofta sant i Linux och Unix, ej Windows
	- Maximal längd (Windows 260 tecken)
	- Mellanslag tillåtna men att undvika
	- Siffror tillåtna
	- \ / : * ? "< > | ej tillåtet
	- vissa filnamn inte tillåtna (con, nul, prn)
	- Filnamnstillägg ger ledtrådar till innehållet

# Säkerhet för kunden
Det innebär at skydda information/data.
Systemets/kundens data är heligt.

# ☁️Molnet
Vi utvecklare kommer att ägna allt mer tid år att driftsätta våra applikationer i molnet.

## För- och nackdelar
Molnet:
- billigt
- enkelt
- förutsägbara kostnader

Egna servrar:
- kan vara billigt om väl optimerat
- kontroll över hårdvara

# Systemutveckling
Är lika med att utveckla mjukvara. Ingenjör av appar:
	planera, strukturera, bygga, felsöka mjukvara
Kreativt, krävande, komplicerat och roligt
Bra lön, är efterfrågat, innehar en viss status.
Kräver att man är uppdaterad, öppen, strukturerad och kreativ
Nackdelar är att det ibland blir stressigt, komplicerat, "svettigt".

# 🧑‍💻Yrkesroller
- IT-chef (CTO)
- Account Manager
- Projektledare
- SCRUM-master
- __Utvecklare__
- HR/Rekryterare
- Designers
- __UX designers__
- __Testare__
- Nätverkstekniker

# Projektmetod
Viktigt när så många olika roller är inblandade i projektet.. Ett system med tekniker, metoder, förfaranden och regler som används av dem som arbetar inom ett yrke.

Fördelen är att projektledaren får tillgång till modeller och verktyg som ger en tydlig struktur för hur arbetet ska drivas framåt, från planering och budgetering till uppföljning.

Olika metoder:
- Agil projektledning
- Scrum
- Kanban
- Lean
- Vattenfall
- Six Sigma
- PMI / PMBOK
- PRINCE2
- ...

### 💧Vattenfall
![[Pasted image 20230825091510.png]]

I Metoden rör sig förbättringar linjärt framåt  i en riktning utan att stanna upp. Full fart framåt. Man ser på resultatet på slutet.
Dokumentation mycket viktig och kräver att nya medarbetare läser sig till en väldigt omfattande dokumentation.

Det är en sekventiell systemutvecklingsprocess där man ser framstegen som ett flöde nedåt genom olika faser:
__förberedelse__ => __etablering__ =>__analys__ => __design__ => __konstruktion__ => __test__ => __produktionssättning__ => __underhåll__

Den har sina rätter i tillverknings - och byggindustrin där det är mycket kostsamt att införa ändringar sent i processen. Den kan jämföras med processen att bygga ett hus. 

#### Fördelar
- __Kostnadskontroll__: beställaren kan besluta i varje steg huruvida projektet ska startas, fortsätta, pausas eller avslutas. Återupptagningen underlättas av all dokumentation som redan gjorts.
- __Resursplanering eller upphandling kan göras mellan stegen__: om förarbetet är tillräckligt bra ska vem som helst kunna implementera systemet.
- Slutprodukten är __testad och kvalitetssäkrad__.
- Processen är __relativt överskådlig och lätt att förstå__, vilket sparar tid för en projektgrupp  då modellen inte behöver förklaras lika ingående i processens start.

#### Nackdelar
![[Pasted image 20230825091652.png]]

- __Skjuter kvalitetsproblemen framför sig__ vilket kan resultera i försenad leverans och därmed en __ökad kostnad__.
- __Hanterar egentligen inte förändringar__. En förändringsförslag måste gå igenom flera steg för att genomföras.
- __Många dokument__.
- __Datasystem är mycket mer komplexa__ än vad ett hus är att bygga så modellen kan endast användas till en viss del i projekt för datasystem.
- Man ser inte kundnyttan förrän i slutet av projektet.
- Mer riskabelt, dyrare, mindre effektivt och vanligen försenat.
## Agil utveckling
Improvisera och anpassa arbetet efter nya förutsättningar. Skapades ursprungligen för utvecklare av mjukvara, handlar om att dela upp projektet i flera delmoment i stället för en stor slutleverans. Målet är att arbeta snabbt och flexibelt genom att testa sig fram och tillsammans i projektteamet skapa både problemformuleringar och lösningar.

___Agil___ är ett samlingsnamn för ett antal systemutvecklingsmetoder som kan användas vid programvaruutveckling.

Det är inte en process utan mer en __filosofi__ eller __värderingar__.
Metoderna följer den filosofi och de principer som formulerades i __Manifestet för Agil systemutveckling__ 2001 av en grupp programmerare.

De hade reagerat på konsekvenserna av vattenfallsmodellen (detaljerade kravspecifikationer, omfattande dokumentation och byråkratiserande metoder och processer.)

### 🗒️Manifestet
- Individer och interaktioner __framför__ processer och verktyg.
- Fungerande programvara __framför__ omfattande dokumentation.
- Kundsamarbete __framför__ kontraktsförhandling.
- Anpassning till förändring __framför__ att följa en plan.

Medan det finns värde i punkterna till höger, värdesätter vi punkterna till vänster mer. 

- Individuals and interactions over processes and tools
- Working software over comprehensive documentation
- Customer collaboration over contract negotiation
- Responding to change over following a plan

![[Pasted image 20230824135648.png]]

### Agile process - Iteration
![[Pasted image 20230824135829.png]]

### Vad är agilt?
- Inte en metodik
- Inte ett specifikt sätt att utveckla programvara
- Inte ett ramverk eller process

- Det är __en uppsättning värderingar och principer__

Agilt är en tilltro eller en övertygelse som leder till beslut om hur mjukvaruutvecklingen ska ske.
Agila metoder fattar inte beslut åt en, de ger en och ett team grunden för att fatta egna beslut.

### Principer bakom det agila manifestet
- Högsta prioritet: tillfredsställa kunden med __tidig on kontinuerlig__ leverans av värdefull programvara.
- __Välkomna förändrade krav__, även sent. Agila metoder utnyttjar förändring till kundens konkurrensfördel.
- __Leverera fungerande programvara ofta__ (ett par veckor eller månaders mellanrum). Ju oftare desto bättre.
- Verksamhetskunniga och utvecklare måste __arbeta tillsammans dagligen__ under hela projektet.
- Bygg projekt kring __motiverade individer__. Ge dem rätt förutsättningar och __lita på att de får jobbet gjort__.
- __Kommunikation ansikte mot ansikte__ är det bästa och effektivaste sättet att förmedla information.
- __Fungerande programvara är främsta måttet på framsteg__.
- Agila metoder __verkar för uthållighet__. Sponsorer, utvecklare och användare skall kunna hålla jämn utvecklingstakt under obegränsad tid. => __Team velocity__
- Kontinuerlig __uppmärksamhet på förstklassig teknik och bra design__ stärker anpassningsförmågan.
- Enkelhet - konsten att __maximera mängden arbete och bra design__.
- Bäst arkitektur, krav och design växer fram med __självorganiserande__ team.
- Regelbundet __reflekterar teamet över hur det kan blir mer effektivt__ och gör beteendejusteringar.
## SCRUM
Scrum är ett ramverk för att __utveckla, tillhandahålla och underhålla__ komplexa produkter. 
Ett sätt att __fördela arbetsuppgifter__ i tiden med bibehållet fokus på __levererad affärsnytta__. Tanken är att __få ordning i projekt med kontinuerliga förändringar__.

Det är en __användarcentrerad__ systemutvecklingsprocess med __fokus på nyttan för de människor som använder systemen__.

### SCRUM framework
![[Pasted image 20230824144423.png]]

### Projektets roller
#### 👩‍💼Produktägare
- Har ansvar för en optimal ordning av elementen i backloggen.
- Ser till att varje element i backloggen beskrivs tydligt och begripligt för hela teamet.
- Optimerar värdet av arbetet som utförs av det team med ansvar för utvecklingen.
- Garanterar att backloggen skapas på ett tydligt och transparent sätt. Anger vad SCRUM-teamet har att göra i nästa steg.
- Ser till att utvecklingsteamet förstår samtliga element i backloggen så det blir möjligt att arbeta.

#### 🧑‍🏫SCRUM-master
Personen i teamet som ser till att agila principer och värderingar följs samt att processer och metoder som teamet kom överens om används.

Ansvaret för rollen omfattar:
- Rensa hinder
- Etablera en miljö för effektivitet
- Ha koll på teamdynamiken
- Säkerställa en god relation mellan teamet och produktägare och andra utanför teamet
- Skydda teamet från avbrott utifrån och distraktioner

#### 👨‍💻Utvecklare 
- Ansvar för att tidsuppskatta, planera och hantera egna uppgifter och rapportera om framsteg
- Samarbeta nära alla medlemmar i teamet och dela ansvar för övergripande insatser inom teamet
- Ta ansvar för kvalitéten på programvaran
- Interagera med användare efter behov för förtydligande av krav
- Förstå verksamhetens syfte med storyn och definiera och analysera eventuella alternativa sätt tillfredsställa syftet
- Arbeta direkt med produktägaren för att klargöra och ytterligare definiera detaljerna i hur storyn ska implementeras

### SCRUM - beståndsdelar
- #### Product backlog
	- En att-göra lista, samlar alla önskemål som produktägaren vill ha.
	- Kan också innehålla nya funktioner och ändringar av befintliga funktioner, defekter, förbättringar, osv. Det är även tillåtet att lägga in andra uppgifter än user stories.
	- Posten kan läggas till, raderas eller revideras av produktägaren längs med vägen beroende på ändringar i affärsförhållanden och förståelse från SCRUM-teamet.

- #### Sprintplanering
	- Planera vilka user stories som ska ingå i sprinten utifrån granskning av produkt backloggen.
	- Ofta uppdelning av funktioner / uppgifter för att bilda andra backlog som kallas för sprint eftersläpning. Utvecklingsteamet ger sedan en tidsuppskattning om vad som krävs för att slutföra varje uppgift. 

- #### Sprint backlog
	- Lista med det som förväntas hinnas med under sprinten

- #### Sprint
	- Arbetet delas i sprintar och utförs i iterationer eller cykler på mellan 3 och 30 dagar.
	- Alltid fast start- och slutdatum. Bör ha samma varaktighet.
	- En ny sprint följer alltid en avslutad sprint.

- #### Implementering - själva arbetet
	- Allt arbete utförs på uppgiftsnivå som krävs för att få funktionerna "klara".
	- Inget krav på vilken ordning uppgifterna ska göras.
	- Teammedlemmar definierar sitt eget arbete på uppgiftsnivå och organiserar sig på det sättet man känner är bäst för att uppnå uppgiftsmålet.

- #### Daily Scrums/ Standup
	- Daglig planeringsaktivitet som hjälper ett team att göra sitt jobb bättre. Alla förstår helheten av vad som händer, hur man går mot sprintmålet, ändringar.
	- Inte problemlösningsmöte eller statusmöte
	- Max 15 min.
	- Varje person svarar på följande frågor:
		- Vad gjorde du igår?
		- Vad tänker du göra idag?
		- Finns det några hinder för mitt arbete?

- #### Definition of done
	- Arbete är klart när det som SCRUM-teamet bestämde har blivit verklighet 
	- Slutförda arbetet är av god kvalité och kan levereras
	- User story har blivit sann (användaren kan göra det som bestämts och utlovats)

- #### Sprint review (med kund)
	- Målet är att inspektera och anpassa produkten
	- Fokuserar på de funktionerna som jobbats med under sprinten
	- De närvarande får insyn i vand som hänt och hjälper till att påverka utvecklingen för att säkerställa att den mest affärsmässiga lösningen skapas
	- Görs vanligen som en demo

- #### Sprint Retrospective (utan kund)
	- Utvärdering och anpassning av processen. 
		- Vad har fungerat bra?
		- Vad har fungerat mindre bra? 
		- Vad borde vi sluta göra?
		- Vad borde vi börja göra?

Man bestämmer vissa åtgärder. Därefter börjar man om!

![[Pasted image 20230825110528.png]]

## Kanban
Målet är att effektivisera produktionen.
Visuell tavla där arbetsflödet och processer ska synas och vara tillgängliga för alla (olika faser i utvecklingen).

## User story
Kanban tavlan fyller man med ___user stories___.

- En användarberättelse, den minsta enheten för agilt arbete.
- Skriven __ur slutanvändarens perspektiv__. Syfte: artikulera en funktion som __ger värde till kunden__.
- Är __EJ__ systemkrav.
- Använder icke-tekniskt språk.

Passar bra i SCRUM och Kanban. Kanban teamet använder till exempel user stories från backloggen och kör dem igenom sitt arbetsflöde. En user story bör vara möjlig att utföra under en sprint.

### Fördelar
- Hålla fokus på användaren
- Möjliggör samarbete
- Driver kreativa lösningar
- Skapar drivkraft

### Att skriva user stories
"Som [persona], [vill jag], [så att]."

- __[Persona]__: vem bygger vi detta för? T.ex: Max. Teamet behöver ha en förståelse för vem Max är. Vi förstår hur den personen fungerar, hur de tänker och vad de känner. Vi har empati för Max.
- __[Vill jag]__: Här beskriver vi deras avsikt – inte de funktioner som de använder. Vad är det de faktiskt försöker uppnå? Den här satsen ska vara fri från tekniska begrepp – om du beskriver någon del av användargränssnittet och inte vad användarmålet är, har du missat poängen.
- __[Så att]__: hur deras omedelbara önskan att göra något som passar in i deras behov? Vad är fördelen de försöker uppnå? Vad är det stora problemet som behöver lösas?

### Persona
En fiktiv representation av din ideala målgrupp.
Utgå från målgruppsparametrarna och lägg till följande frågor:
- Personens utmaningar
- Personens tankar
- Personens agerande
- Personens orosmoment

Exempel:
Kvinna i 35-årsåldern som bor i Stockholm, har en akademisk bakgrund med en inkomst över genomsnittet. Hon jobbar inom IT, är småbarnsförälder samt använder Facebook 3 timmar per dag. Ser ofta på TV och tränar sällan.

	Vad heter hen?
	Vilka utmaningar, tankar, agerande och orosmoment har hen?
	Vad fyller hennes behov med den app vi bygger?

### Exempel på user stories:
- Som Max vill jag kunna bjuda in mina vänner, så vi kan njuta av den här tjänsten tillsammans.
- Som Anna vill jag organisera mitt arbete, så att jag kan känna mer kontroll. 
- Som chefen Bertil vill jag kunna förstå mina kollegors framsteg, så jag kan bättre rapportera våra framgångar och misslyckanden.
- Som hamnägaren Sofia vill jag berätta om vilka fina faciliteter jag kan erbjuda, så mina kunder väljer min hamn. 
	- Som hamnägare vill jag berätta om hur många duschar jag kan erbjuda, så mina kunder väljer att ta en dusch I min hamn

## Estimering - uppskatta "tid"
"Hur lång tid tar det att...?"

- I takt med ökad komplexitet blir det nästan omöjligt att ge en exakt uppskattning.
- Uppskattning är en välgrundad gissning och det skiljer sig från det faktiska.
- Det finns ingen exakt uppskattning
- Varians är en verklighet, det är bara att acceptera det.

### Orsaker till osäkerhet vid uppskattning
- Görs av icke-utvecklare
- Saknas kunskap om området eller tekniken
- Finns ingen historik att lära sig ifrån
- Oklara krav
- Vad ska ingå?

En del lean/agilutvecklare tycker t.o.m att tidsestimering är slöseri med tid.

### Fördelar och tips
- Uppskattning hjälper till att förstå om produkten är livskraftig
- Uppskattning hjälper till vid projektplanering och genomförande
- Uppskattning hjälper till vid prioritering
- Det ger en annan möjlighet att samarbeta och få bättre förståelse för krav och design
- Tips
	- Uppskatta i intervall istället för att ge en enda siffra
	- Uppskattning är INTE detsamma som löfte så ändra det när du lär dig något nytt
	- Varje uppskattning är inte bättre än dess underliggande resonemang och antaganden
	- Historiska data är bra för uppskattning
	- Aktuella data är ännu bättre och det är där Agil utveckling fokuserar

### Ideal tid och verklig tid
- Ideal tid är - hur lång tid det skulle ta om
	- det är allt du arbetar med
	- du har inga avbrott
	- du har allt du behöver
- Förfluten/verklig tid är total tid det tar att avsluta arbetet
	- Tänk på hur många produktiva timmar om dagen du vanligtvis har
	- Perfekt tid för en fotbollsmatch är 90 minuter - 2 x 45 minuter men blir nästan aldrig verklighet
	- Ideal tidsuppskattning är lätt att uppskatta och förklara men svårt att omvandla till förfluten tid
	- Utbildningar, möten, telefonsamtal och uppgiftsbyten mm påverkar skillnaden mellan idealtid och förfluten tid.

### Story points
- Story Point är en relativ storlek/storhet av uppgiften
	- Beror på hur svårt det är
	- Beror på hur mycket det finns att göra
- Relativa värden är det som är viktigt
	- En inloggningsskärm är kanske 5; en sökfunktion är 8; en kundkorg är 35
	- Minsta story point kan vara 1, t.ex en statisk sida med en text
- Enhetslösa punkter
- Använd inte en enda guldstandard - triangulera
	- triangulering innebär att jämföra historien med flera andra berättelser
- Varje team definierar dem som de vill. Vi kan inte jämföra uppskattningar av två olika team
- Lättare att uppskatta. svårare att förklara
- Till en början kan t.ex 6 points motsvara en ideal arbetsdag, men målet är att det till slut inte ska motsvara en verklig tidsenhet, utan relativ
- När ett team jobbat tillsammans länge börjar det falla på plats
- Då kan man också räkna ut hur många points man hinner med på en sprint

#### Planning Poker
Ett sätt att estimera hur svårt en story/funktion är.

De viktigaste stegen är: 
- Varje person i teamet har en hög med kort, varje kort har en siffra skriven på den (baserat på t ex icke-linjär skala) 
- Kund / produktägare läser en berättelse och det diskuteras kort
- Varje person i teamet väljer ett kort som är hans eller hennes uppskattning 
- Korten vänds samtidigt så att alla kan se dem 
- Därefter diskuteras skillnaderna (särskilt de yttersta avvikelserna)
- Därefter upprepas detta tills uppskattningar börjar bli likvärdiga
- När man kommit till en gemensam siffra, så antecknas den 
- Produktägare eller kund men finns för att svara på eventuella frågor kring omfattning

[Poker Sizing](https://pokersizing.com/)

> It's better to be roughly right than precisely wrong

Ett team behöver tid för att börja estimera rätt. Man pratar om teamets ___velocity___.

## Implementation - själva arbetet

- När sprintplanering är klar utför utvecklingsteamet allt arbete på uppgiftsnivå som krävs för att få funktionerna "klara".
- Ingen berättar för teamet i vilken ordning eller hur man gör arbetet på uppgiftsnivå i sprintbackloggen.
- Teammedlemmar definierar sitt eget arbete på uppgiftsnivå och organiserar sig sedan på vilket sätta de känner bär bäst för att uppnå sprintmålet.

## Parprogrammering
En agil arbetsmetod. Två programmerare jobbar tillsammans på samma arbetsstation:
- en förare som skriver kod 
- en observatör eller navigatör  som granskar koden som skrivs.

Under granskningen beaktar observatören också den strategiska riktningen av arbetet och kommer med förslag och förbättringar samt eventuella framtida problem. Syftet är att frigöra föraren att fokusera all sin uppmärksamhet på de taktiska aspekterna av att slutföra den aktuella uppgiften.

Fallgropar: frånvaro (fysisk eller psykisk)
Mäster: om den mest erfarna i paret tar över och kör utan att den andra hänger med. inget bra samspel. Leder oftast till frånvaro.

## Mob-programming
Hela teamet jobbar på ett och samma problem tillsammans utan överlämningar och uppehåll i arbetet.

Två roller som roteras i fasta intervall:
- driver (styr datorn)
- navigator samlar input från de andra i gruppen och för det vidare till drivern

[Vad är mobbprogrammering? | ProAgile](https://proagile.se/lar-mer/mobbprogrammering)

## MVP - Minimum viable product
Minsta livskraftiga produkt. 
- En MVP är en version av en produkt med precis tillräckligt med funktioner för att kunna användas av tidiga kunder som sedan kan ge feedback för framtida produktutveckling.
- Har initialt tillräckligt mycket värde för att användare ska vilja använda eller köpa den.
- Uppvisare kommande fördelar att fortsätta behålla tidiga användaren.
- Skapar en feedback-loop som guidar teamet vidare med utvecklingen

Alfaversionen av ett program är en MVP.
## Slutsatser
Agila metoder: 
- Ska hjälpa till
- Skapade FÖR utvecklare AV utvecklare
- Ger överblick för alla
- Löser inte problem, utan synliggör dem
- Förutsätter att alla är med
- Fasta punkter
	- Sprintstart
	- Dagliga standup-möten, max 15 min.
	- Sprint review 
	- Sprint retrospect
	- Övrig tid: programmering I lugn och ro.

# Teamet, projektet och intressenter

## Projektrisker
- __Konflikter__ inom projektet kan bl.a vara mellan __intressenter__ och projektledningen, mellan organisationen och medarbetarna. Det kan handla om att personer som har en verkställande roll inte lyckas stötta projektet tillräckligt mycket, att __information inte når mottagaren__ av någon anledning eller att det finns någonting som __stör projektet__.
- __Attityder__ inom projektgruppen kan vara både konstruktiva och destruktiva. I vissa fall kan arbetarna som jobbar med projektet ha en väldigt negativ inställning till projektet av någon anledning.

## Intressenter
Externa intressenter:
- __Aktieägare__: har andelar i företag, men är ej aktiv i företaget
- __Politik__: politiska beslut  som påverkar (t.ex: GDPR)
- __Leverantörer__: levererar olika varor eller tjänster mot ersättning
- __Kunder__: betalar för varor eller tjänster
- __Fordrinsägare__: t.ex banker eller andra finansiärer. Tillhandahåller lån eller andra former av finansiering mot ränta eller ersättning
- __Stat och kommun__: tillhandahåller exempelvis offentligfinansierad infrastruktur, angelägna om att medborgare får arbete, tar ut skatt, kan ansvara för myndighetsutövning
- __Medier__: tidning, TV, radio

Interna intressenter:
- __Anställda__: utför arbete i utbyte mot lön och andra förmåner
- __Ägarna__: kan ha satsat kapital, får utdelning eller avkastning i annan form och är aktiva i företaget
- __Ledning__: styrning av en organisation

### Vilka intressenter finns att tillgå?
- Skolan:
	- tillhandahåller lokaler, förutsättningar för studier och arbete
- CSN:
	- finansierar lön
- Läraren:
	- kravställare
	- uppdragsgivare
	- "kund"
	- lärare
- Företagen/grupperna
	- anställda
	- ägare
	- ledning

## Gruppdynamik

- Man kan placeras i __en grupp som man inte valt själv__.
- Det han handla om ett sammanhang dör __en uppgift måste lösas i gruppen__ på uppgift av ledningen
- Vad händer då när en grupp människor sätts samman och ska samarbeta, som kanske aldrig tidigare ens träffats?

___Gruppdynamik___ är ett begrepp som beskriver hur situationen ser ut när det kommer till interaktionen mellan olika individer i en grupp. Den kan vara bra eller dålig. Det är samspelet mellan de olika individerna som avgör detta.

Vad finns det för olika faktorer som kan påverka gruppdynamiken och i vilken ända ska man börja om man vill ändra och förbättra denna inom gruppen?

Man behöver starta grupparbete med team-building.

### Team-building
Används för att stärka grupprelation, i nysammansatt grupp men även om man jobbat tillsammans tidigare.

Vad vill man uppnå? Att förstå varandras __personligheter__ och __egenskaper__.
Det finns företag som är __experter i team-building__ som man kan hyra.

Stärka gruppens samhörighet och sammarbetsförmåga. Gruppen måste förstå varandras sätt att se på saker och ting. team-building kan bestå av en mer __lättsam träff__ eller __uppstyrda övningar__.

## DISC-analys
Många företag använder det vid anställning av nya medarbetare.
En teori om mänskligt beteende som hjälper individer att bli mer framgångsrika. Den identifierar flera beteendestilar som styr hur olika personer fattar beslut och beter sig:
- Dominance - Dominant - Röd
- Influence - Influerande - Gul
- Steadiness - Stabil - Grön
- Conscientiousness - Analytisk - Blå

Ibland kan en DISC-analys vara en del av team-building. Kan användas med fördel för __grupputveckling__ och __gruppdynamik__. __Utökar sin egen självkännedom samt ökar förståelsen för andra människors personligheter.__

Finns dock en del kritik mot det då människor är lite mer komplexa än det. Egenskaper från olika "färger" kan genomsyras i varje individ. Man kan även vara olika i olika sammanhang (arbete, hemma, osv.). Fördelen med det är att identifiera olika personligheter, vilket kan göra det __lättare att samarbeta__ på arbetsplatsen . Ökar även förståelse för hur andra fungerar.

### Fördelar
* Engagerade medarbetare
	* matching av rätt arbetsuppgift leder till nöjda, produktiva och kreativa medarbetare)
* Ledarskapet
	* Lär dig att inspirera, motivera och uppmuntra individer genom att förstå deras beteendeprofil
* Fler affärer
	* förstå och anpassa sig till hur kunderna fungerar och beter sig
* Ge konstruktiv feedback
	* förmågan att anpassa ditt beteende och möta mottagaren i dennes beteendestil
* Konflikthantering
	* när vi förstår avsikten bakom beteende minskar konflikter och motsättningar
* Karriärplanering
	* skapar effektiv karriärplanering genom att hjälpa till att matcha människor med positioner
* Produktiva team
	* möjliggör förståelse om varför andra beter sig på ett visst sätt
* Behåll bra medarbetare
	* avgörande för att behålla medarbetare är att förstå vad som motiverar denne
* Förbättra kommunikation
	* genom förmågan att anpassa sig till mottagaren

### 🔴 DISC - röd 
* Dominant och handlingskraftig. 
* Resultatssökande
* Ser det stora sammanhanget
* Beslutsfattande
* Gillar utmaningar
* Rak på sak
* Vill ha rak och tydlig kommunikation (drivs av resultat, kontroll, effektivitet och makt)
* Vill ej bli bemött av för mycket känslor, utan med rakhet och tydlighet
* Vanligt yrke: ledare/chef, försäljare, politiker, osv.

### 🟡 DISC - gul 
* Inflytande, vill påverka andra
* Utåtriktad
* Gillar att ha kul
* Gillar att samarbeta
* Ogillar ensamhet
* Entusiastisk
* Drivs av bekräftelse och beröm, gillar att bli bemött av känslor och kommunikation
* Ogillar för hårda regler eller att bli avvisad
* Vanliga yrken: säljare, kundservice, eller andra mer kreativa yrken

### 🟢 DISC - grön
- Stabil, tonvikt på samarbete
- Omtänksam
- Lugnt tillvägagångssätt
- God lyssnare
- Pålitlig
- Lagspelare, tålmodig
- Gillar säkerhet och stabilitet och tycker inte om allt för snabba förändringar eller otrygghet
- Vill bli bemött med lugn och tålamod
- Vanliga yrken: vårdpersonal, polis, eller HR och ekonomi

### 🔵 DISC - blå
- Analytisk, tonvikt på kvalitet och noggrannhet
- Söker fakta
- Resonera i sannolikhet
- Vill ha detaljerna
- Kvalitetsmedveten
- Plikttrogen, noggrann, konservativ och kritisk'
- Gillar struktur, saklighet och korrekthet
- Ogillar irrationella människor eller pressade situationer
- Vill bli bemött med respekt och ärlighet, bra argument och korrekt fakta
- Vanliga yrken: psykolog, militär eller forskare osv.

Att notera, ingen specifik personlighetstyp för just programmerare. En blandning är alltid positiv i yrket.

![[Pasted image 20230905100533.png]]

## Feedback

### Feedbacktrappan

![[Pasted image 20230905102808.png]]

#### Steg 1 - Förkasta
- Slår ifrån sig feedbacken
- Förnekande
- Attityd: detta berör inte mig
- Reaktion: nej, så kan det inte vara

#### Steg 2 - Försvara
- Slår fortfarande i från sig feedbacken
- Försvarar sig
- Attityd: Jag tar inget ansvar för att...
- Reaktion: det berodde inte på mig utan på...

#### Steg 3- Förklara
- Slår fortfarande ifrån sig feedbacken
- Accepterar sakförhållandet
- Attityd: det är sant, men
- gömmer sig bakom fakta

#### Steg 4 - Förstå
- Tar till sig informationen
- Accepterar sakförhållandet
- Attityd: Kan du förklara en gång till vad som kan förbättras?
- Reaktion: Ställer frågor eller lyssnar under tystnad

#### Steg 5 - Förändra
- Tar till sig informationen
- Är villig att göra förändringar 
- Attityd: jag kommer att förändra
- Reaktion: handling

### Att ge feedback
- Ge feedback i en tillitsfull situation
- Var positiv och ärlig
- Var direkt, konkret och specifik
- Välj rätt tillfälle
- Var konstruktiv
- Följ upp

## Teamets olika faser
Storleken på teamet varierar beroende på sammanhang och tillfälle. 

### FIRO-metoden


![[Pasted image 20230905104212.png]]

När vi jobbar i team byter man ibland konstellation. Då repeteras cykeln i FIRO-metoden. 

__Fundamental Interpersonal Relations Orientation__

- __Synliggör samspelet i en grupp__ och hur en __grupps utveckling__ vanligtvis ser ut.
- metoden skapades för att studera varför __vissa grupper presterade bättre än andra__ under Koreakriget.
- En grupp genomgår __tre olika faser__

#### FIRO - fas 1: Tillhöra-fasen
- I början känner medlemmar av läget
- Gruppen lär känna varandra__, man går __ej in i konflikt__
- Gruppen är inte speciellt effektiv, tiden går åt till att skapa sig en bild av situationen
- Inga svåra uppgifter, måste ha hittat sin plats i gruppen.

#### FIRO - fas 2: Idyllfasen
- Alla pustar ut
- Produktiviteten stannar upp
- Grupper är nöjd och lever i nuet men inte mycket faktiskt arbete utförs

#### FIRO - fas 3: Rollsökning
- När man är accepterad i gruppen är nästa steg att hitta sin roll
- Maktförhållanden sätts på spel
- Ansvarsfördelning, specialområden
- gruppen mäter sina krafter med varandra för att se vem som ska ta vilken roll
- Kan uppstå konflikter
- ganska låg produktivitet då energin går åt interna konflikter och stridigheter

#### FIRO - fas 4: Gemytfasen
- Ytterligare en "hämta-andan-fas"

#### FIRO - fas 5: Samhörighetsfasen
- Dit man stävar
- Växlande roll beroende på behov
- Man kan kanske byta stol vid varje möte
- Låta andra ta ledningen över ett möte när ämnet för dagen är något som en annan person har Kunskap kring och förmåga att leda
- Om jag är trygg i min roll kan jag lätt underordna mig on det gagnar arbetet
- Man är så trygg i sin roll att man kan överlåta den till någon annan som är bättre lämpad för arbetsuppgiften just då
- Verkligt hög produktivitet

Vid nyrekrytering eller förändring i gruppen hamnar gruppen återigen i tillhörighetsfasen.

### Viktigt att bestämma
- Bestäm vilka arbetstider som gäller
	- avstämningar
	- ses IRL?
	- Kamera av/på
	- Kallpratsnivå
- Dela upp arbetet
	- vissa delar bör ske tillsammans
	- andra delar delegeras till en/flera personer
- Ansvar mot teamet
	- ev. förhinder eller problem kommuniceras
	- vid oklarheter eller om ni inte är överens, red ut det direkt
	- det som utlovas ska hållas

## Kunden - det femte hjulet?
Den som beställt applikationen och betalar för den

### Aktörer
- Slutanvändare - konsumenten
- Företaget som tillhandahåller applikationen - __kunden__
- Anställda eller konsulter (via konsultbolag) - utföraren

#### Slutanvändaren - __konsumenten__
- Slutanvändaren - den som använder och betalar för applikationens funktionalitet
	- Vem betalar?
		- slutanvändaren (abonnemang, osv.)
		- Annonsörer
		- Intresseorganisationer
		- Skattebetalarna

- Slutanvändarens drivkrafter
	- Nytta med appen
	- Nöje
	- Vinna något, pengar?
		- Applikationer för arbetet
		- Söka job, LinkedIn
		- Spelsajter

#### Företaget som tillhandahåller applikationen - __kunden__ 
- Det här vår kund befinner sig
- Drivkraft:
	- Vinst
	- Ev. ideella syften
- Anställer eller hyr konsulter
- Vill få en bra produkt som snabbt kommer ut på marknaden, så billigt som möjligt
- Kunden kan i sin tur ha en rad intressenter som har sina krav:
	- Slutanvändaren 
	- Aktieägare
	- Beställare
	- Samhället

#### Konsult eller anställd - __utföraren__
Det är vi utvecklare
- Våra drivkrafter:
	- Lön
	- Roligt och stimulerande arbetsliv
	- Karriär
	- Framtidsyrke

#### Fler aktörer
- Designers
- Säljare
- Chefer
- SCRUM-masters
- Städare
- Ekonomer
- Osv.

#### Kunden
Den vi arbetar för
- Vi bygger kundens applikation
- Vi skapar vinst för kunden
- Vi har som mål att förstå kunden och göra kunden nöjd - __kundnöjdhet__

### Kundnöjdhet
#### En nöjd kund
- Förblir kund
- Enklare att samarbeta med
- Ger tillbaka kunskap till organisationen
- Utvecklarna
- Enklare att utveckla nya tjänster/produkter
- Stimulerande att arbeta med
- Köper mer
- Generar nya kunder

#### En missnöjd kund
- Slutar köpa/anlita eller går till konkurrent
- Svårare att samarbeta med
- Är svår att utveckla nya tjänster/produkter med
- Är påfrestande att arbeta med
- Köper mindre
- Avskräcker nya kunder

#### Hur blir en kund nöjd?
- Kunder ä också människor därför gör olika saker kunder nöjda.
- Vissa saker är viktigare än andra

De viktigaste faktorerna:
- Rätt förväntan hos kunden
	- Rätt leverans i rätt tid till rätt kostnad
- Bra kommunikation
	- tydlighet, ärlighet, saklighet
- Konsultmässighet
- Kompetens och kvalitet
- Hålla vad man lovar
- Kunna ta kritik

##### 1 Rätt förväntan hos kunden
- Det är viktigt att vara överens med kunder om vad som ska levereras
	- Projektbeskrivning
	- Ärlig CV (ibland på teamnivå)
	- Gemensamma mål

- Kundens krav
	- Rätt leverans i rätt tid till rätt kostnad (billigt, bra och snabbt)

Vår uppgift är att förklara att det bara går att uppfylla två av de tre kraven
Billigt, bra och snabbt - välj två!

###### Billigt och bra - inte snabbt
Om kunden vill få det billigt och bra blir det svårt att leverera snabbt. Ett sätt att få en applikation bra och billig är att låta utvecklingsteamet arbeta med den d
de har tid, vid eventuella lugnare perioder.

###### Billigt och snabbt - inte bra
Svårt att leverera bra. En snabb leverans med begränsad ekonomi borgar för att man behöver sänka ambitionsnivån, fulkoda och inte hinner tänka klart.

###### Bra och snabb - inte billigt
Svårt att leverera billigt då fler personal, konsulter, expertis måste tas in för att jobba med projektet, vilket ökar kostnaderna.

##### 2 Bra kommunikation
De flesta kunder vill ha en löpande kommunikation
- Kommunikation innan uppdraget
	- Tydlighet om uppdraget
	- Tydlighet om kompetens
- Kommunikation under uppdraget
	- Projektverktygen, Kanban, Jira, mm
	- Dagliga avstämningar - daily SCRUM
	- SCRUM: sprint planering, reviews, retrospect
	- Löpande information om hinder och problem
	- Rapporter
	- Använda rätt begrepp
- Kommunikation efter uppdraget
	- Överlämning
	- Slutrapport
	- Utvärdering

##### 3 Konsultmässighet
Krav
- Kort uppstartsträcka
- Trevlig
- Inspirera på arbetsplatsen
- Tillmötesgående
- Dela med dig av kunskap
- Vara självgående och kunna jobba i grupp
- Flexibel
- Representabel
- God ambassadör för sitt företag
- Inte sticka ut

##### 4 Kompetens och kvalitet
- En självklar egenskap för att kunden ska vara nöjd är att vi levererar lösningar på ett kompetent sätt och med hög kvalitet
- En kund blir väldigt missnöjd om vår kod är dålig:
	- Fulkodad
	- Otidsenlig
	- Inte enligt företagets policy
	- Buggig/inte fungerar
	- Failar i test
	- Dåligt dokumenterad (om krav finns på det)
- Vår uppgift är att leverera bra kod och bra funktionalitet, enligt kravspecifikationer
