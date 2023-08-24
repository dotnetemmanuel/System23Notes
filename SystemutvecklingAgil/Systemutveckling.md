---
sticker: lucide//laptop
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

# Molnet
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

# Yrkesroller
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

## Vattenfall
I Metoden rör sig förbättringar linjärt framåt  i en riktning utan att stanna upp. Full fart framåt. Man ser på resultatet på slutet.
Dokumentation mycket viktig och kräver att nya medarbetare läser sig till en väldigt omfattande dokumentation.

Det är en sekventiell systemutvecklingsprocess där man ser framstegen som ett flöde nedåt genom olika faser:
förberedelse => etablering =>analys => design => konstruktion => test => produktionssättning => underhåll

Den har sina rätter i tillverknings - och byggindustrin där det är mycket kostsamt att införa ändringar sent i processen. Den kan jämföras med processen att bygga ett hus. 

### Fördelar
- __Kostnadskontroll__: beställaren kan besluta i varje steg huruvida projektet ska startas, fortsätta, pausas eller avslutas. Återupptagningen underlättas av all dokumentation som redan gjorts.
- __Resursplanering eller upphandling kan göras mellan stegen__: om förarbetet är tillräckligt bra ska vem som helst kunna implementera systemet.
- Slutprodukten är __testad och kvalitetssäkrad__.
- Processen är __relativt överskådlig och lätt att förstå__, vilket sparar tid för en projektgrupp  då modellen inte behöver förklaras lika ingående i processens start.

### Nackdelar
- __Skjuter kvalitetsproblemen framför sig__ vilket kan resultera i försenad leverans och därmed en __ökad kostnad__.
- __Hanterar egentligen inte förändringar__. En förändringsförslag måste gå igenom flera steg för att genomföras.
- __Många dokument__.
- __Datasystem är mycket mer komplexa__ än vad ett hus är att bygga så modellen kan endast användas till en viss del i projekt för datasystem.
- Man ser inte kundnyttan förrän i slutet av projektet.
- Mer riskabelt, dyrare, mindre effektivt och vanligen försenat.
# Agil utveckling
Improvisera och anpassa arbetet efter nya förutsättningar. Skapades ursprungligen för utvecklare av mjukvara, handlar om att dela upp projektet i flera delmoment i stället för en stor slutleverans. Målet är att arbeta snabbt och flexibelt genom att testa sig fram och tillsammans i projektteamet skapa både problemformuleringar och lösningar.

Agil är ett samlingsnamn för ett antal systemutvecklingsmetoder som kan användas vid programvaruutveckling.

Det är inte en process utan mer en __filosofi__ eller __värderingar__.
Metoderna följer den filosofi och de principer som formulerades i __Manifestet för Agil systemutveckling__ 2001 av en grupp programmerare.

De hade reagerat på konsekvenserna at vattenfallsmetoden (detaljerade kravspecifikationer, omfattande dokumentation och byråkratiserande metoder och processer.)

## Manifestet
- Individer och interaktioner framför processer och verktyg.
- Fungerande programvara framför omfattande dokumentation.
- Kundsamarbete framför kontraktsförhandling.
- Anpassning till förändring framför att följa en plan.

Medan det finns värde i punkterna till höger, värdesätter vi punkterna till vänster mer. 

- Individuals and interactions over processes and tools
- Working software over comprehensive documentation
- Customer collaboration over contract negotiation
- Responding to change over following a plan

![[Pasted image 20230824135648.png]]

## Agile process - Iteration
![[Pasted image 20230824135829.png]]

## Vad är agilt?
- Inte en metodik
- Inte ett specifikt sätt att utveckla programvara
- Inte ett ramverk eller process

- Det är __en uppsättning värderingar och principer__

Agilt är en tilltro eller en övertygelse som leder till beslut om hur mjukvaruutvecklingen ska ske.
Agila metoder fattar inte beslut åt en, de ger en och ett team grunden för att fatta egna beslut.

## Principer bakom det agila manifestet
- Högsta prioritet: tillfredsställa kunden med __tidig on kontinuerlig__ leverans av värdefull programvara.
- __Välkomna förändrade krav__, även sent. Agila metoder utnyttjar förändring till kundens konkurrensfördel.
- __Leverera fungerande programvara ofta__ (ett par veckor eller månaders mellanrum). Ju oftare desto bättre. Målet: en veckas sprint.
- Verksamhetskunniga och utvecklare måste __arbeta tillsammans dagligen__ under hela projektet.
- Bygg projekt kring __motiverade individer__. Gem dem rätt förutsättningar och __lita på att de får jobbet gjort__.
- __Kommunikation ansikte mot ansikte__ är det bästa och effektivaste sättet att förmedla information.
- __Fungerande programvara är främsta måttet på framsteg__.
- Agila metoder __verkar för uthållighet__. Sponsorer, utvecklare och användare skall kunna hålla jämn utvecklingstakt under obegränsad tid.
- Kontinuerlig __uppmärksamhet på förstklassig teknik och bra design__ stärker anpassningsförmågan.
- Enkelhet - konsten att __maximera mängden arbete och bra design__.
- Bäst arkitektur, krav och design växer fram med __självorganiserande__ team.
- Regelbundet __reflekterar teamet över hur det kan blir mer effektivt__ och gör beteendejusteringar.
# SCRUM
Scrum är ett ramverk för att __utveckla, tillhandahålla och underhålla__ komplexa produkter. 
Ett sätt att __fördela arbetsuppgifter__ i tiden med bibehållet fokus på levererad affärsnytta. Tanken är att __få ordning i projekt med kontinuerliga förändringar__.

Det är en __användarcentrerad__ systemutvecklingsprocess med __fokus på nyttan för de människor som använder systemen__.

## SCRUM framework
![[Pasted image 20230824144423.png]]

## Projektets roller
### Produktägare
- Har ansvar för en optimal ordning av elementen i backloggen.
- Ser till att varje element i backloggen beskrivs tydligt och begripligt för hela teamet.
- Optimerar värdet av arbetet som utförs av det team med ansvar för utvecklingen.
- Garanterar att backloggen skapas på ett tydligt och transparent sätt. Anger vad SCRUM-teamet har att göra i nästa steg.
- Ser till att utvecklingsteamet förstår samtliga element i backloggen så det blir möjligt att arbeta.

### SCRUM-master
### Utvecklare 

Samarbete, ansvarsskyldighet och iterativa framsteg.
Roller:
- produktägare (ansvarar för resultat)
- Scrum-master
- teamet/utvecklare

SCRUM-möte 15 minuter varje dag. Sprinter som är kortare delprojekt där teamet under en begränsad tid jobbar intensivt med att färdigställa något.

# Kanban
Målet är att effektivisera produktionen.
Visuell tavla där arbetsflödet och processer ska synas och vara tillgängliga för alla (olika faser i utvecklingen).

