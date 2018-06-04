SELECT nombre, MAX(campeonatos)
from participantes;

SELECT *, MIN(capacidad)
from salas,Hotel;

SELECT nombre COUNT(codigo)
from Hotel
WHERE codigo IN ( SELECT codigo
      FROM alojar
      WHERE num_asoc( SELECT num_asoc
        FROM participantes
         WHERE ))


SELECT nombre, MAX(jugadores.nivel),AVG(participantes.campeonatos)
FROM Hotel INNER JOIN  jugadores
WHERE participantes.num_asoc = jugadores.num_asoc AND alojar.codigo = Hotel.codigo;

SELECT *
FROM Hotel, alojar, arbitro
WHERE hotel.codigo != alojar.codigo AND alojar.num_asoc != arbitro.num_asoc;
