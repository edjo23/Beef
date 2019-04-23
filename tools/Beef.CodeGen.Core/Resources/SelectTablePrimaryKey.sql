﻿-- Copyright (c) Avanade. Licensed under the MIT License. See https://github.com/Avanade/Beef

SELECT kcu.TABLE_SCHEMA, kcu.TABLE_NAME, kcu.CONSTRAINT_NAME, tc.CONSTRAINT_TYPE, kcu.COLUMN_NAME, kcu.ORDINAL_POSITION
  FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS AS tc
  JOIN INFORMATION_SCHEMA.KEY_COLUMN_USAGE AS kcu
    ON kcu.CONSTRAINT_SCHEMA = tc.CONSTRAINT_SCHEMA
   AND kcu.CONSTRAINT_NAME = tc.CONSTRAINT_NAME
   AND kcu.TABLE_SCHEMA = tc.TABLE_SCHEMA
   AND kcu.TABLE_NAME = tc.TABLE_NAME
 WHERE tc.CONSTRAINT_TYPE in ( 'PRIMARY KEY', 'UNIQUE' )
 ORDER BY kcu.TABLE_SCHEMA, kcu.TABLE_NAME, tc.CONSTRAINT_TYPE, kcu.CONSTRAINT_NAME, kcu.ORDINAL_POSITION;