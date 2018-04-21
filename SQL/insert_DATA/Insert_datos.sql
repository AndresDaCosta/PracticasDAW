

INSERT INTO Hotel(codigo,nombre,direccion,telefono,localidad,provincia) values('h001','hotel central', 'c/larga,7', '923.230.101', 'lleida', 'lleida');
INSERT INTO Hotel(codigo,nombre,direccion,telefono,localidad,provincia) values('h002','hotel cappont', 'c/rio ebro,7', '923555657', 'alcarras', 'lleida');
INSERT INTO Hotel(codigo,nombre,direccion,telefono,localidad,provincia) values('h003','hotel ilerna', 'avda barcelona,13', '923211001', 'barcelona', 'barcelona');
INSERT INTO Hotel(codigo,nombre,direccion,telefono,localidad,provincia) values('h004','hotel real', 'c/ancha,14', '923622558', 'lleida', 'lleida');
INSERT INTO Hotel(codigo,nombre,direccion,telefono,localidad,provincia) values('h005','hostal manzanares', 'avda mayor, 30', '923455221', 'bellpuig', 'lleida');


INSERT INTO pais(cod_pais,nombre,continente,clubes) VALUES('p001', 'rusia', 'europa', '10'); 
INSERT INTO pais(cod_pais,nombre,continente,clubes) VALUES('p002', 'francia', 'europa', '3');
INSERT INTO pais(cod_pais,nombre,continente,clubes) VALUES('p003', 'guayana francesa', 'america', '1');
INSERT INTO pais(cod_pais,nombre,continente,clubes) VALUES('p004', 'uzbekistan', 'asia', '8');
INSERT INTO pais(cod_pais,nombre,continente,clubes) VALUES('p005', 'nigeria', 'africa', '14');

INSERT INTO salas(cod_salas,nombre,medio,capacidad,codigo_ho) VALUES('s001', 's_euclides', 'todos','30', 'h001' );
INSERT INTO salas(cod_salas,nombre,medio,capacidad,codigo_ho) VALUES('s002', 's_descarte', 'todos', '60', 'h001',);
INSERT INTO salas(cod_salas,nombre,medio,capacidad,codigo_ho) VALUES('s003', 's_principal', 'video', '15', 'h003');
INSERT INTO salas(cod_salas,nombre,medio,capacidad,codigo_ho) VALUES('s004', 's_gerona', 'audio', '30', 'h004');
INSERT INTO salas(cod_salas,nombre,medio,capacidad,codigo_ho) VALUES('s005', 's_tarragona', 'todos', '80', 'h004');

INSERT INTO participantes(num_asoc,nombre,direccion,telefono,campeonatos,pais,apellidos) VALUES('001', 'jose luis', 'c/guadalwuivir,8','955233221','4','p001', 'LOPEZ VAZQUEZ');
INSERT INTO participantes(num_asoc,nombre,direccion,telefono,campeonatos,pais,apellidos) VALUES('002', 'sergio', 'c/victoria,18', '955233441', '6', 'p003', 'RAMOS GARCIA');
INSERT INTO participantes(num_asoc,nombre,direccion,telefono,campeonatos,pais,apellidos) VALUES('003', 'MICKEY', 'c/disney,28', '988566998', '1','p002', 'MOUSE LOPEZ');
INSERT INTO participantes(num_asoc,nombre,direccion,telefono,campeonatos,pais,apellidos) VALUES('004', 'DONALD JOSE', 'c/gargolas,14', '988744552', '14', 'p004', 'PATO GARCIA');
INSERT INTO participantes(num_asoc,nombre,direccion,telefono,campeonatos,pais,apellidos) VALUES('005', 'luis brad', 'avda america,1 ', '652255887', '8', 'p005', 'PITT JACKSON');

INSERT INTO jugadores(num_asoc,nivel) VALUES('001','5');
INSERT INTO jugadores(num_asoc,nivel) VALUES('002','2');
INSERT INTO jugadores(num_asoc,nivel) VALUES('003','6');

INSERT INTO arbitro(num_asoc) VALUES('004');
INSERT INTO arbitro(num_asoc) VALUES('005');

INSERT INTO alojar(num_asoc,codigo,fecha_in,fecha_out) VALUES ('001', 'h001','2017-06-26','2017-06-28');
INSERT INTO alojar(num_asoc,codigo,fecha_in,fecha_out) VALUES ('002', 'h002','2017-06-26','2017-07-26');
INSERT INTO alojar(num_asoc,codigo,fecha_in,fecha_out) VALUES ('003', 'h003','2017-06-26','2017-07-26');
INSERT INTO alojar(num_asoc,codigo,fecha_in,fecha_out) VALUES ('004', 'h004','2017-06-26','2017-07-01');
INSERT INTO alojar(num_asoc,codigo,fecha_in,fecha_out) VALUES ('005', 'h005','2017-06-26','2017-07-04');

INSERT INTO partida(cod_partida,arbitro,cod_salas) VALUES('par01','004','s001');
INSERT INTO partida(cod_partida,arbitro,cod_salas) VALUES('par02','004','s002');
INSERT INTO partida(cod_partida,arbitro,cod_salas) VALUES('par03','005','s001');
INSERT INTO partida(cod_partida,arbitro,cod_salas) VALUES('par04','005','s005');
INSERT INTO partida(cod_partida,arbitro,cod_salas) VALUES('par05','004','s003');

INSERT INTO presenta(cod_pais1,cod_pais2) VALUES('p001','p003');
INSERT INTO presenta(cod_pais1,cod_pais2) VALUES('p0012','p004');

INSERT INTO jugar(num_asoc,cod_partida,color_ficha) VALUES('001', 'par01', 'negras');
INSERT INTO jugar(num_asoc,cod_partida,color_ficha) VALUES('001', 'par03', 'negras');
INSERT INTO jugar(num_asoc,cod_partida,color_ficha) VALUES('002', 'par01', 'blancas');
INSERT INTO jugar(num_asoc,cod_partida,color_ficha) VALUES('002', 'par02', 'negras');
INSERT INTO jugar(num_asoc,cod_partida,color_ficha) VALUES('003', 'par02', 'blancas');
INSERT INTO jugar(num_asoc,cod_partida,color_ficha) VALUES('003', 'par03', 'blancas');
