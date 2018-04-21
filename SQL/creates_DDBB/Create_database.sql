create database Campeonato;

	create table Hotel(

		codigo char(5) PRIMARY KEY,
		nombre text(25) not null,
		direccion text(25),
		telefono int(9) not null,
		localidad text(15)not null,
		provincia text(15)

		);
	create table pais(
		cod_pais char(5) PRIMARY KEY,
		nombre text(25) not null, 
		continente text(25) not null,
		clubes int(9)
		);
	create table salas(
		cod_salas char(25) PRIMARY KEY,
		nombre text(25),
		medio text(25),
		capacidad int(5),
		codigo_ho char(5),
		CONSTRAINT FK_codigoHO FOREIGN KEY (codigo_ho)
    		REFERENCES Hotel(codigo)
		);
	create table participantes(
		num_asoc char(5) PRIMARY KEY,
		nombre text(25),
		direccion text(25),
		telefono int(9),
		campeonatos int(5),
		pais char(5),
		apellidos char(25),
		CONSTRAINT FK_Pais FOREIGN KEY (pais)
    		REFERENCES pais(cod_pais)
		);
	create table jugadores(
		num_asoc int(5) PRIMARY KEY,
		nivel int (9) 
		);
	create table arbitro(
		num_asoc char(5) PRIMARY KEY,
		);
	create table partida(
		cod_partida char(5) PRIMARY KEY,
		arbitro char(5),
		cod_salas char(5),
		CONSTRAINT FK_arbitro FOREIGN KEY (arbitro)
    		REFERENCES arbitro(num_asoc),
		CONSTRAINT FK_salas FOREIGN KEY (cod_salas)
    		REFERENCES salas(cod_salas)
		);
	create table jugar(
		num_asoc int(5),
		cod_partida char(5),
		color_ficha text(20),
		CONSTRAINT FK_asoc FOREIGN KEY (num_asoc)
			REFERENCES jugadores(num_asoc),
		CONSTRAINT FK_partida FOREIGN KEY (cod_partida)
			REFERENCES partida(cod_partida),
		CONSTRAINT PK_jugar PRIMARY KEY (num_asoc,cod_partida)
		);
	create table alojar(
		num_asoc char(5),
		codigo char(5),
		fecha_in date,
		fecha_out date,
		CONSTRAINT FK_asoci FOREIGN KEY (num_asoc)
			REFERENCES participantes(num_asoc),
		CONSTRAINT FK_hotel FOREIGN KEY (codigo)
			REFERENCES Hotel(codigo),
		CONSTRAINT PK_aloja PRIMARY KEY (num_asoc,codigo)
		);
	create table presenta(
		 cod_pais1 char(5),
		 cod_pais2 char(5),
		 CONSTRAINT PK_presenta PRIMARY KEY (cod_pais1,cod_pais2)

		);