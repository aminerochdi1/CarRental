--Createtion de database


create database gest_de_locations_des_voitures

create table client (
num int primary key identity ,
[code postal] int,
ville nvarchar(50),
rue nvarchar(50),
tel nvarchar(50),
[num de permis ] nvarchar(50),
[date de permis] date,
cin nvarchar(50) foreign key references identite(cin)
)

create table identite (
cin nvarchar(50) primary key,
nom nvarchar(50),
prenom nvarchar(50),
[date de naissance ] date,
[ville de naissance] nvarchar(50),
[nationalite] nvarchar(50)
)
create table contrat 
([numero de contrat] int primary key identity(00001,10), 
[date de depart ] datetime ,
[date de retour ] datetime,
numcl int foreign key references client(num) ,
[km debut] float,
[kim fin] float,
[montant a payer] float,
)


alter table contrat 
add constraint fk_numèclient
foreign key (numcl) references client(num)


create table vehicule
(Immatriculation  nvarchar(50) primary key,
model nvarchar(50),
carburant  nvarchar(50),
assurance  float,
prix float,
disponible nvarchar(50),
etat nvarchar(30)
)

create table retour
(
numcl int foreign key references client(num),
Immatriculation nvarchar(50) foreign key references vehicule(Immatriculation),
[date d'debut] date,
[Date de retour] date,
[prix total] float 
)


create table dapannage
(
Immatriculation nvarchar(50) foreign key references vehicule(Immatriculation),
etat nvarchar(30) foreign key references vehicule,
adresse nvarchar(50),
[date d'accident] date,


)




--DBCC CHECKIDENT('client', RESEED, 0)






