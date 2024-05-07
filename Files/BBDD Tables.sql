create table animal (
    id SERIAL PRIMARY KEY,
    nombre VARCHAR,
    super_familia VARCHAR CHECK ( super_familia IN ('Tortuga Marina', 'Ave Marina', 'Cetaceo') ),
    especie VARCHAR,
    grado_aceptacion NUMERIC CHECK ( grado_aceptacion BETWEEN 1 AND 99),
    peso DOUBLE PRECISION
);

create table rescat (
    id SERIAL PRIMARY KEY,
    num_rescate VARCHAR(6),
    fecha DATE,
    super_familia VARCHAR CHECK ( super_familia IN ('Tortuga Marina', 'Ave Marina', 'Cetaceo') ),
    localizacion VARCHAR,
    animal_id INTEGER,
    CONSTRAINT fk_animal FOREIGN KEY (animal_id) REFERENCES animal (id)
);

INSERT INTO animal (nombre, super_familia, especie, grado_aceptacion, peso)
VALUES ('Trotuman', 'Tortuga Marina', 'Chelonia mydas', 80, 150.5);

INSERT INTO rescat (num_rescate, fecha, super_familia, localizacion, animal_id)
VALUES ('RES345', '2024-05-06', 'Tortuga Marina', 'Arenys de Mar', 1);

INSERT INTO animal (nombre, super_familia, especie, grado_aceptacion, peso)
VALUES ('Flipper', 'Cetaceo', 'Tursiops truncatus', 90, 200.2);

INSERT INTO rescat (num_rescate, fecha, super_familia, localizacion, animal_id)
VALUES ('RES890', '2024-05-07', 'Cetaceo', 'Mataró', 2);

INSERT INTO animal (nombre, super_familia, especie, grado_aceptacion, peso)
VALUES ('Pingu', 'Ave Marina', 'Spheniscus magellanicus', 70, 8.5);

INSERT INTO rescat (num_rescate, fecha, super_familia, localizacion, animal_id)
VALUES ('RES680', '2024-05-08', 'Ave Marina', 'Tossa de Mar', 3);

INSERT INTO animal (nombre, super_familia, especie, grado_aceptacion, peso)
VALUES ('Willy', 'Cetaceo', 'Orcinus orca', 95, 5000.0);

INSERT INTO rescat (num_rescate, fecha, super_familia, localizacion, animal_id)
VALUES ('RES579', '2024-05-09', 'Cetaceo', 'Calella de Palafrugell', 4);

INSERT INTO animal (nombre, super_familia, especie, grado_aceptacion, peso)
VALUES ('Leonardo', 'Tortuga Marina', 'Caretta caretta', 78, 120.0);

INSERT INTO rescat (num_rescate, fecha, super_familia, localizacion, animal_id)
VALUES ('RES555', '2024-05-14', 'Tortuga Marina', 'Platja d''Aro', 5);

INSERT INTO animal (nombre, super_familia, especie, grado_aceptacion, peso)
VALUES ('Piolín', 'Ave Marina', 'Diomedea exulans', 85, 4.2);

INSERT INTO rescat (num_rescate, fecha, super_familia, localizacion, animal_id)
VALUES ('RES666', '2024-05-15', 'Ave Marina', 'Lloret de Mar', 6);

INSERT INTO animal (nombre, super_familia, especie, grado_aceptacion, peso)
VALUES ('Felipe', 'Cetaceo', 'Delphinus delphis', 90, 180.0);

INSERT INTO rescat (num_rescate, fecha, super_familia, localizacion, animal_id)
VALUES ('RES777', '2024-05-16', 'Cetaceo', 'Blanes', 7);