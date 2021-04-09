# Propeller_Torktumlar_Service

![Image](SnurrtumlareAB.JPG)

Projektet är ett skolprojekt med syftet att skapa en webbapplikation i form av en nätbutik med två olika vyer, en kundvy och en administratörsvy. Målet är att kunden skall kunna lägga order i butiken på artiklar som torktumlare och propellerkepsar. Administratörerna skall kunna logga in och bland annat se kundorder.

-- Noteringar till utvecklare --

* Branch-namn skall med fördel börja med följande taggar beroende på syftet med branchen:
  - fix (fix av en felaktighet)
  - addition (ny funktionallitet eller nya designelement)
  - change (ändringar i befintlig kod eller design utan att det är en bug inblandad)

* Db-migration instruktioner
  - För ett cleant project, radera både aspnet-SnurrtumlareWebSite och SnurrtumlareDB databaserna från SQL Server/localdb
  - Radera hela Migrations mappen från projektet
  - I Package Manager Console kör nedan komandon
    - add-migration InitialApplicationDbContext -context ApplicationDbContext
    - update-database -context ApplicationDbContext
    
    - add-migration InitialSnurrtumlareDbContext -context SnurrtulareDbContext
    - update-database -context SnurrtulareDbContext

* Inloggnings Instruktioner
  - Email: send_me_your_prayers@abdi.com
  - Password: GudÄrGrejt1337!

* Designregler för alla Views (som renderas genom @RenderBody) --
  - Padding: 15 px
  - Margin(top och bottom): 20px 

* YSYS-OP2 ni kommer alla få ta del av olika databaser nu, men det finns en connectionstring mot servern som är följande:    Server=tcp:ourfantasticwebshopdatabaseserver.database.windows.net,1433;Initial Catalog=[ER_DATABASNAMN];Persist Security Info=False;User ID=superuser;Password=SuperMario1337;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;

Nu till databasnamnen:
 
Grupp1: group1-db1, group1-db2
Grupp2: group2-db1, group2-db2
Grupp3: group3-db1, group3-db2
Grupp4: group4-db1, group4-db2
Grupp5: group5-db1, group5-db2


