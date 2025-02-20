create database clinica_veterinaria;
use clinica_veterinaria;

create table veterinario(
	id int primary key auto_increment,
	nome varchar(40),
    telefone varchar(13),
    cpf varchar(11),
    cep varchar(8),
    especializacao varchar(20),
    crmv varchar(13)
);

create table tutor(
	id int primary key auto_increment,
	nome varchar(40),
    telefone varchar(13),
    cpf varchar(11),
    cep varchar(8)
);

create table animal(
	id int primary key auto_increment,
    nome varchar(20),
    genero varchar(9),
    especie varchar(25),
    raca varchar(25),
    idTutorFk int,
    
    foreign key (idTutorFk) references tutor(id)
);

create table consulta(
	id int primary key auto_increment,
    tipo varchar(20),
    data_consulta date,
    idVeterinarioFk int,
    idAnimalFk int,
    
    foreign key (idVeterinarioFk) references veterinario(id),
    foreign key (idAnimalFk) references animal(id)
);