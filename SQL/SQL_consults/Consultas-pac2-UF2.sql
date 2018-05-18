

SELECT codigo,nombre,direccion,telefono,localidad,provincia
FROM Hotel
WHERE provincia = 'lleida';


SELECT * 
FROM Hotel 
WHERE nombre LIKE 'hostal%';

SELECT nombre,direccion,localidad
FROM Hotel
WHERE (provincia = 'lleida' AND localidad != 'lleida');


SELECT * 
FROM salas 
WHERE ( medio = 'todos' AND capacidad < 50);

SELECT COUNT(medio)
FROM salas
WHERE medio = 'todos';

SELECT continente COUNT(pais)
FROM pais
GROUP BY continente;

SELECT nombre
FROM participantes INNER JOIN jugadores 
WHERE  (participantes.num_asoc = jugadores.num_asoc AND jugadores.nivel = 5);


SELECT *
FROM participantes INNER JOIN arbitros
WHERE  participantes.num_asoc = arbitros.num_asoc;

SELECT * 
FROM Hotel 
WHERE direccion LIKE 'avda%';

SELECT participantes.nombre , pais.nombre
FROM participantes INNER JOIN pais
WHERE  participantes.pais = pais.cod_pais;

SELECT AVG(clubes)
FROM pais;


SELECT hotel.nombre , salas.capacidad
FROM hotel INNER JOIN salas
WHERE  hotel.codigo = salas.codigo;



SELECT arbitros.num_asoc, COUNT(*) AS total
FROM partida, arbitros
WHERE partida.arbitro = arbitros.num_asoc
GROUP BY arbitros.num_asoc;

SELECT participantes.nombre
FROM jugar, participantes
WHERE (participantes.num_asoc = jugar.num_asoc AND jugar.color_ficha = 'negras');


SELECT salas.nombre
FROM hotel, salas
WHERE (salas.codigo = hotel.codigo AND hotel.nombre = '%central')
ORDER BY sala.capacidad DESC;

