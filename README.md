# OOExamples
Repository met OO en C# gerelateerde voorbeelden

# Algemeen
Klik rechtsboven op de groene knop "Code" > "Open in visual studio" om de code te bekijken.
Class diagrams (.uxf) zijn te openen met de gratis tool UMlet: https://www.umlet.com/
Voorbeelden dit een database gebruiken vereisen de installatie van Microsoft SQL server op de lokale machine.

## DemoOO
Eenvoudig voorbeeld met een class diagram om afgeleide relatie en associatie te demonstreren. 

## GameAccountExample
Voorbeeld van een veel op veel relatie tussen twee objecten. Werkt met entity framework.
Open de eerste keer na starten in Visual Studio via menu "Tools" > "Nuget Package Manager" > "Package Manager Console". Voer in de console het commando <code>update-database</code> uit om de database aan te maken. Prerequisite: SQL server is geinstalleerd op je lokale machine met een standaard MSSQLSERVER instance.

## WebformsParentChildExample
Voorbeeld van een webforms applicatie met een header/lines constructie. Door in de header een andere regel te kiezen worden de regels opnieuw geladen voor betreffende geselecteerde header. Voer het script database.sql uit op je SQL server alvorens het voorbeeld te starten.

## LambdaAndLinq
Zeer klein voorbeel van Lambda expressions en Linq. Gaat vooral om de documentatie (zie in code). 

## WindowsFormsOefening
Oefening met database, DAL en windows form om te illustreren hoe de verschillende lagen weken en met elkaar interacteren. Maak eerst een database aan op SQL server en voer het CreateScriptParentChild.sql script uit.

## KidsEventsIncorporated
Work in progress voorbeeld van een fictief bedrijf wat events organiseert voor kinderen. Omschrijving en diagrammen beschikbaar in "Misc" folder. Voorbeeld werkt met MVC en EF, code first. Open de eerste keer na starten in Visual Studio via menu "Tools" > "Nuget Package Manager" > "Package Manager Console". Voer in de console het commando <code>update-database</code> uit om de database aan te maken. Prerequisite: SQL server is geinstalleerd op je lokale machine met een standaard MSSQLSERVER instance.
