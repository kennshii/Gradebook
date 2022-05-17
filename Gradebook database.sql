USE carnetNote;

CREATE TABLE elev (
	idElev INT PRIMARY KEY NOT NULL,
	numeElev VARCHAR(30) NOT NULL,
	clasa INT NOT NULL,
	profil VARCHAR(4), NOT NULL
)
CREATE TABLE noteReal(
	idElev INT PRIMARY KEY NOT NULL,
	romana DECIMAL(4,2) NOT NULL,
	matematica DECIMAL(4,2) NOT NULL,
	straina DECIMAL(4,2) NOT NULL,
	istoria DECIMAL(4,2) NOT NULL,
	fizica DECIMAL(4,2) NOT NULL,
	biologia DECIMAL(4,2) NOT NULL,
	chimia DECIMAL(4,2) NOT NULL,
	informatica DECIMAL(4,2) NOT NULL,
	geografia DECIMAL(4,2) NOT NULL,
	notaMedie DECIMAL(4,2) NOT NULL,
)

CREATE TABLE noteUman(
	idElev INT PRIMARY KEY NOT NULL,
	romana DECIMAL(4,2) NOT NULL,
	matematica DECIMAL(4,2) NOT NULL,
	straina DECIMAL(4,2) NOT NULL,
	istoria DECIMAL(4,2) NOT NULL,
	informatica DECIMAL(4,2) NOT NULL,
	biologia DECIMAL(4,2) NOT NULL,
	straina2 DECIMAL(4,2) NOT NULL,
	civica DECIMAL(4,2) NOT NULL,
	geografia DECIMAL(4,2) NOT NULL,
	notaMedie DECIMAL(4,2) NOT NULL
)


ALTER TABLE noteReal
ADD CONSTRAINT FK_elevNoteReal
FOREIGN KEY (idElev) REFERENCES elev(idElev);

ALTER TABLE noteUman
ADD CONSTRAINT FK_elevNoteUman
FOREIGN KEY (idElev) REFERENCES elev(idElev);

insert into elev(numeElev, clasa, profil)
values('Busuioc Eduard', 12, 'REAL'),
		('Lana Rhodes', 12, 'REAL'),
		('Modnaya Bandana', 12, 'REAL'),
		('Soda Luv', 12, 'UMAN'),
		('Miracle Doter', 11, 'UMAN')

insert into noteReal(idElev, romana, matematica, straina, istoria, fizica, biologia, chimia, informatica, geografia, notaMedie)
values (37, 10, 10, 10, 10, 8, 9, 7, 10, 6, 8.76),
	(38, 10, 10, 10, 10, 8, 9, 7, 10, 6, 8.76),
	(39, 10, 10, 10, 10, 8, 9, 7, 10, 6, 8.76)

insert into noteUman(idElev, romana, matematica, straina, istoria, informatica, biologia, straina2, civica, geografia, notaMedie)
values(40, 9, 10, 10, 10, 8, 9, 7, 10, 6, 8.76),
	(41, 10, 10, 10, 10, 8, 9, 7, 10, 6, 8.76)

SELECT * FROM noteReal
SELECT * FROM noteUman
SELECT * FROM elev

SELECT e.idElev, e.numeElev,e.profil, n.romana, n.matematica, n.straina, n.istoria, n.fizica, n.biologia, n.chimia, n.informatica, n.geografia, n.notaMedie
FROM elev e, noteReal n
WHERE e.idElev = n.idElev 

SELECT e.idElev, e.numeElev,e.profil, n.romana, n.matematica, n.straina, n.istoria, n.informatica, n.biologia, n.straina2, n.civica, n.geografia, n.notaMedie
FROM elev e, noteUman n
WHERE e.idElev = n.idElev


-- viziuni
CREATE VIEW selectReal AS
SELECT e.idElev, e.numeElev,e.profil, n.romana, n.matematica, n.straina, n.istoria, n.fizica, n.biologia, n.chimia, n.informatica, n.geografia, n.notaMedie
FROM elev e, noteReal n
WHERE e.idElev = n.idElev 

CREATE VIEW selectUman AS
SELECT e.idElev, e.numeElev,e.profil, n.romana, n.matematica, n.straina, n.istoria, n.informatica, n.biologia, n.straina2, n.civica, n.geografia, n.notaMedie
FROM elev e, noteUman n
WHERE e.idElev = n.idElev

CREATE VIEW selectAll AS
SELECT * FROM selectReal
UNION ALL

SELECT * FROM selectReal
SELECT * FROM selectUman
SELECT * from selectAll


-- DELETE FROM elev
 DELETE FROM noteReal
-- DELETE FROM noteUman