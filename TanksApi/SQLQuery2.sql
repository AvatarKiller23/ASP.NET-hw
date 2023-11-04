INSERT INTO Nations (Name) VALUES ('USSR'), ('USA'), ('Germany');


INSERT INTO Levels (TankLevel) VALUES (1), (2), (3), (4), (5), (6), (7), (8), (9), (10);


INSERT INTO Tanks (Name, Price, NationId, LevelId) VALUES 
    (N'МС-1', 1500, 1, 1),
    (N'Т-26', 2700, 1, 2),
    (N'Т-34', 5000, 1, 3),
    ('M8A1', 12000, 2, 4),
    ('M4 Sherman', 16000, 2, 5),
    ('M4A3E2 Sherman Jumbo', 19000, 2, 6),
    ('Pz VI Ausf E Tiger I', 20000, 3, 7),
    ('Pz VI Ausf. B Tiger II', 25000, 3, 8),
    ('Panther Ausf. G', 37000, 3, 9),
    ('Leopard 2A4', 45000, 3, 10);