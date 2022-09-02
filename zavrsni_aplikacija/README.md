# Desktop aplikacija za potporu upravljanju i pružanju prijevoznih usluga

Mentor: Marko Mijač

## Projektni tim

| Ime i prezime     | E-mail adresa (FOI) | JMBAG      | Github korisničko ime |
| ----------------- | ------------------- | ---------- | --------------------- |
| Dario Kulenović   | dkulenovi@foi.hr    | 0016126911 | dkulenovic            |
| Vanja Kostanjevac | vkostanje@foi.hr    | 0016125711 | VanjaKostanjevac      |
| Niki Hercigonja   | nhercigon@foi.hr    | 0016138155 | NikiHerc              |
| Ante Novak        | anovak@foi.hr       | 0016137777 | AnteNovak             |

## Opis domene

U ovom projektu bavit ćemo se izgradnjom aplikacije koja bi trebala podržavati osnovne procese u poduzećima kao što je Zagrebački električni tramvaj (ZET). Potrebu za ovom aplikacijom nalazimo konkretno u olakšavanju prodaje karata klijentima tako da se ponudi kupnja karata, provjera valjanosti karata u samom vozilu, mogućnost pregledavanja voznih redova kako klijentima, tako i zaposlenima (vozačima i menadžmentu). Također postoji potreba za izvještavanjem menadžmenta o prihodu od prodanih karata u određenim vremenskim periodima i izvještavanje o plaćama zaposlenika odnosno troškovima što bismo isto htjeli promatrati kako bi korisnik (u ovom slučaju menadžer) dobio uvid u poslovanje kao temelj za donošenje odluka.

## Specifikacija projekta

| Oznaka | Naziv                           | Kratki opis                                                                                                                                                                              | Odgovorni član tima |
| ------ | ------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------- |
| 01     | Login i registracija            | Za pristup u aplikaciju potrebno je unijeti određeno korisničko ime i lozinku. Registracija novog korisnika u sustav i prikupljanje određenih potrebnih podataka o njemu.                | Vanja Kostanjevac   |
| 02     | Izrada voznog reda              | Za svaku liniju treba postojati vozni red koji će uključiti vozača i vozilo na određenu liniju.                                                                                                    | Vanja Kostanjevac   |
| 03     | Kupnja karte                    | Klijent ima mogućnost kupnje karte i ispis karte u PDF formatu.                                                                                                                          | Dario Kulenović     |
| 04     | Pregled prodanih karata         | Periodičan pregled prodanih karata i izvještaj o zaradi.                                                                                                                                 | Dario Kulenović     |
| 05     | Evidencija zaposlenika i vozila | Popis zaposlenika kojem pristupa menadžment kako bi odredio tko vozi koju liniju i koje vozilo bi se u tom slučaju koristilo.                                                            | Niki Hercigonja     |
| 06     | Provjera valjanosti karata i aktivacija      | Provjera valjanosti karata u vozilu putem šifre pojedinačne karte ili u slučaju kada klijent ima tjednu/mjesečnu/godišnju kartu i aktivacija iste                                                           | Dario Kulenović     |
| 07     | Definiranje linija              | Kreiranje novih linija i pregledavanje postojećih linija i dodavanje stanica na liniju.                                                                                            | Ante Novak          |
| 08     | Pregled i pretraživanje linija  | Funkcionalnost omogućuje putniku da pregleda dostupne linije.                                                                                                                            | Ante Novak          |
| 09     | Izvještaj troška plaća          | Izvještaj o trošku plaća svih zaposlenika ili pojedinačno kroz periode.                                                                                                                  | Niki Hercigonja     |
| 10     | Izvještaj troška i zarade (PDF) | Periodičan pregled troška i zarade koji uključuje plaće zaposlenika i zaradu od prodaje karata.  | Niki Hercigonja     |
| 11     | Izvještaj voznog reda (PDF)     | Izvještaj koji prikazuje vozni red prema liniji.                                                                                                                                                            | Vanja Kostanjevac   |
| 12     | Izvještaj linija (PDF)          | Ispis svih linija prema tramvaju.                                                                                                                                                        | Ante Novak          |

## Tehnologije i oprema

| Alat/tehnologija        | Opis                       |
| ----------------------- | -------------------------- |
| C# i .NET Framework     | Izrada programskog dijela  |
| Microsoft Visual Studio | Izrada programskog dijela  |
| Microsoft SQL Server    | Izrada baze podataka       |
| Windows forms           | GUI biblioteka, frontend   |
| MS Office               | Izrada dokumentacije       |
| Visual Paradigm Online  | Izrada dijagrama           |
| MySQL Workbench         | Izrada skripte za bazu podataka i ERA modela |

Za projektni menadžment ćemo koristiti sam GitHub za sada i u okviru njega postaviti rokove i odrediti faze izrade pojedinog dijela projekta.
