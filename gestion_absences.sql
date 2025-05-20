
-- Suppression et création de la base
DROP DATABASE IF EXISTS gestion_absences;
CREATE DATABASE gestion_absences CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE gestion_absences;

-- Création des tables
DROP TABLE IF EXISTS service;
CREATE TABLE service (
  idservice INT PRIMARY KEY AUTO_INCREMENT,
  nom VARCHAR(100) NOT NULL
);

DROP TABLE IF EXISTS motif;
CREATE TABLE motif (
  idmotif INT PRIMARY KEY AUTO_INCREMENT,
  libelle VARCHAR(100) NOT NULL
);

DROP TABLE IF EXISTS personnel;
CREATE TABLE personnel (
  id MEDIUMINT(8) UNSIGNED NOT NULL AUTO_INCREMENT,
  name VARCHAR(255) DEFAULT NULL,
  phone VARCHAR(100) DEFAULT NULL,
  email VARCHAR(255) DEFAULT NULL,
  idservice MEDIUMINT DEFAULT NULL,
  PRIMARY KEY (id)
) AUTO_INCREMENT=1;

DROP TABLE IF EXISTS absence;
CREATE TABLE absence (
  id MEDIUMINT(8) UNSIGNED NOT NULL AUTO_INCREMENT,
  idpersonnel MEDIUMINT DEFAULT NULL,
  datedebut DATE,
  datefin DATE,
  idmotif MEDIUMINT DEFAULT NULL,
  PRIMARY KEY (id)
) AUTO_INCREMENT=1;

DROP TABLE IF EXISTS responsable;
CREATE TABLE responsable (
  login VARCHAR(64),
  pwd VARCHAR(64)
);

-- Remplissage des données fixes
INSERT INTO responsable (login, pwd)
VALUES ('admin', SHA2('secret123', 256));

INSERT INTO motif (libelle) VALUES
('vacances'),
('maladie'),
('motif familial'),
('congé parental');

INSERT INTO service (nom) VALUES
('administratif'),
('médiation culturelle'),
('prêt');

-- Remplissage de la table personnel
INSERT INTO personnel (name, phone, email, idservice) VALUES
("Marie Vincent","01 44 37 30 80","risus@aol.net",3), 
("Grégory Bunschoten","04 03 46 00 57","sit.amet@icloud.couk",2), 
("Charles Bezuindenhout","05 44 32 34 15","pede.et.risus@outlook.net",2), 
("Boris Rademaker","01 37 29 42 45","nunc.est@protonmail.ca",2), 
("Dylan Achthoven","03 53 42 97 58","nunc.ullamcorper@icloud.edu",1),
("Sofia Beaulieu","07 06 16 42 15","orci.donec@protonmail.org",3), 
("Anthony Haanraads","07 47 37 57 18","aliquet@google.edu",1), 
("Charline Travers","07 02 26 15 41","ipsum@icloud.ca",3), 
("Mael Roggeveen","04 12 16 28 21","in.magna@protonmail.ca",1), 
("Arno Roggeveen","08 01 93 73 38","condimentum.eget.volutpat@google.couk",1);

-- Remplissage de la table absence
INSERT INTO absence (idpersonnel, datedebut, datefin, idmotif) VALUES
(4,"2024-07-09","2024-09-17",4),
(7,"2025-03-24","2025-02-11",1),
(7,"2025-08-05","2025-12-16",2),
(10,"2025-04-08","2025-03-18",4),
(3,"2024-07-03","2024-09-25",3),
(1,"2025-11-07","2025-08-01",3),
(5,"2026-03-08","2026-04-07",3),
(8,"2024-08-14","2024-06-03",4),
(7,"2024-09-10","2025-07-18",2),
(9,"2024-10-14","2024-12-10",1),
(3,"2024-06-07","2024-08-28",2),
(7,"2024-12-26","2025-01-18",2),
(6,"2026-05-01","2026-02-22",2),
(6,"2025-07-26","2025-09-20",4),
(7,"2025-04-22","2025-10-06",2),
(2,"2026-01-17","2025-05-24",1),
(5,"2026-04-13","2024-10-25",2),
(7,"2026-02-19","2025-02-19",1),
(4,"2024-10-31","2024-08-04",1),
(4,"2025-11-10","2024-11-11",4),
(4,"2025-11-03","2024-10-07",2),
(9,"2025-07-22","2024-09-30",4),
(9,"2024-09-05","2025-09-25",2),
(4,"2024-06-28","2024-11-10",3),
(9,"2026-04-15","2026-03-27",4),
(8,"2025-03-06","2026-02-19",2),
(8,"2025-08-23","2024-11-24",4),
(1,"2025-01-13","2025-08-18",4),
(6,"2025-09-01","2025-06-03",2),
(3,"2024-07-24","2025-12-11",2);

-- Création d’un utilisateur MySQL et attribution des droits
CREATE USER IF NOT EXISTS 'abs_user'@'localhost' IDENTIFIED BY 'abs_pass';
GRANT ALL PRIVILEGES ON gestion_absences.* TO 'abs_user'@'localhost';
FLUSH PRIVILEGES;
