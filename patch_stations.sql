-- patch_stations.sql
-- Run this against the 'antri' database to register POST10-POST14
-- for all existing stations (DISP, CALL, TICKET, ADMIN)
-- Safe to run multiple times (INSERT IGNORE = skip if already exists)

USE antri;

INSERT IGNORE INTO queue_stations (name, post, keterangan, canlogin) VALUES
   ('ADMIN#1',  'POST10', NULL, 1),
   ('ADMIN#1',  'POST11', NULL, 1),
   ('ADMIN#1',  'POST12', NULL, 1),
   ('ADMIN#1',  'POST13', NULL, 1),
   ('ADMIN#1',  'POST14', NULL, 1),

   ('ADMIN#2',  'POST10', NULL, 1),
   ('ADMIN#2',  'POST11', NULL, 1),
   ('ADMIN#2',  'POST12', NULL, 1),
   ('ADMIN#2',  'POST13', NULL, 1),
   ('ADMIN#2',  'POST14', NULL, 1),

   ('CALL#1',   'POST10', NULL, 1),
   ('CALL#1',   'POST11', NULL, 1),
   ('CALL#1',   'POST12', NULL, 1),
   ('CALL#1',   'POST13', NULL, 1),
   ('CALL#1',   'POST14', NULL, 1),

   ('CALL#2',   'POST10', NULL, 1),
   ('CALL#2',   'POST11', NULL, 1),
   ('CALL#2',   'POST12', NULL, 1),
   ('CALL#2',   'POST13', NULL, 1),
   ('CALL#2',   'POST14', NULL, 1),

   ('CALL#3',   'POST10', NULL, 1),
   ('CALL#3',   'POST11', NULL, 1),
   ('CALL#3',   'POST12', NULL, 1),
   ('CALL#3',   'POST13', NULL, 1),
   ('CALL#3',   'POST14', NULL, 1),

   ('CALL#4',   'POST10', NULL, 1),
   ('CALL#4',   'POST11', NULL, 1),
   ('CALL#4',   'POST12', NULL, 1),
   ('CALL#4',   'POST13', NULL, 1),
   ('CALL#4',   'POST14', NULL, 1),

   ('CALL#5',   'POST10', NULL, 1),
   ('CALL#5',   'POST11', NULL, 1),
   ('CALL#5',   'POST12', NULL, 1),
   ('CALL#5',   'POST13', NULL, 1),
   ('CALL#5',   'POST14', NULL, 1),

   ('CALL#6',   'POST10', NULL, 1),
   ('CALL#6',   'POST11', NULL, 1),
   ('CALL#6',   'POST12', NULL, 1),
   ('CALL#6',   'POST13', NULL, 1),
   ('CALL#6',   'POST14', NULL, 1),

   ('CALL#7',   'POST10', NULL, 1),
   ('CALL#7',   'POST11', NULL, 1),
   ('CALL#7',   'POST12', NULL, 1),
   ('CALL#7',   'POST13', NULL, 1),
   ('CALL#7',   'POST14', NULL, 1),

   ('CALL#8',   'POST10', NULL, 1),
   ('CALL#8',   'POST11', NULL, 1),
   ('CALL#8',   'POST12', NULL, 1),
   ('CALL#8',   'POST13', NULL, 1),
   ('CALL#8',   'POST14', NULL, 1),

   ('CALL#9',   'POST10', NULL, 1),
   ('CALL#9',   'POST11', NULL, 1),
   ('CALL#9',   'POST12', NULL, 1),
   ('CALL#9',   'POST13', NULL, 1),
   ('CALL#9',   'POST14', NULL, 1),

   ('CALL#10',  'POST10', NULL, 1),
   ('CALL#10',  'POST11', NULL, 1),
   ('CALL#10',  'POST12', NULL, 1),
   ('CALL#10',  'POST13', NULL, 1),
   ('CALL#10',  'POST14', NULL, 1),

   ('DISP#1',   'POST10', NULL, 1),
   ('DISP#1',   'POST11', NULL, 1),
   ('DISP#1',   'POST12', NULL, 1),
   ('DISP#1',   'POST13', NULL, 1),
   ('DISP#1',   'POST14', NULL, 1),

   ('DISP#2',   'POST10', NULL, 1),
   ('DISP#2',   'POST11', NULL, 1),
   ('DISP#2',   'POST12', NULL, 1),
   ('DISP#2',   'POST13', NULL, 1),
   ('DISP#2',   'POST14', NULL, 1),

   ('TICKET#1', 'POST10', NULL, 1),
   ('TICKET#1', 'POST11', NULL, 1),
   ('TICKET#1', 'POST12', NULL, 1),
   ('TICKET#1', 'POST13', NULL, 1),
   ('TICKET#1', 'POST14', NULL, 1),

   ('TICKET#2', 'POST10', NULL, 1),
   ('TICKET#2', 'POST11', NULL, 1),
   ('TICKET#2', 'POST12', NULL, 1),
   ('TICKET#2', 'POST13', NULL, 1),
   ('TICKET#2', 'POST14', NULL, 1),

   ('TICKET#3', 'POST10', NULL, 1),
   ('TICKET#3', 'POST11', NULL, 1),
   ('TICKET#3', 'POST12', NULL, 1),
   ('TICKET#3', 'POST13', NULL, 1),
   ('TICKET#3', 'POST14', NULL, 1),

   ('TICKET#4', 'POST10', NULL, 1),
   ('TICKET#4', 'POST11', NULL, 1),
   ('TICKET#4', 'POST12', NULL, 1),
   ('TICKET#4', 'POST13', NULL, 1),
   ('TICKET#4', 'POST14', NULL, 1);

-- Also insert POST0-POST9 rows for any station that might be completely missing
-- (catches edge cases from partial DB init)
INSERT IGNORE INTO queue_stations (name, post, keterangan, canlogin) VALUES
   ('DISP#1',   'POST0',  NULL, 1), ('DISP#1',   'POST1',  NULL, 1),
   ('DISP#1',   'POST2',  NULL, 1), ('DISP#1',   'POST3',  NULL, 1),
   ('DISP#1',   'POST4',  NULL, 1), ('DISP#1',   'POST5',  NULL, 1),
   ('DISP#1',   'POST6',  NULL, 1), ('DISP#1',   'POST7',  NULL, 1),
   ('DISP#1',   'POST8',  NULL, 1), ('DISP#1',   'POST9',  NULL, 1),
   ('DISP#2',   'POST0',  NULL, 1), ('DISP#2',   'POST1',  NULL, 1),
   ('DISP#2',   'POST2',  NULL, 1), ('DISP#2',   'POST3',  NULL, 1),
   ('DISP#2',   'POST4',  NULL, 1), ('DISP#2',   'POST5',  NULL, 1),
   ('DISP#2',   'POST6',  NULL, 1), ('DISP#2',   'POST7',  NULL, 1),
   ('DISP#2',   'POST8',  NULL, 1), ('DISP#2',   'POST9',  NULL, 1);

SELECT name, post, canlogin FROM queue_stations ORDER BY name, post;
