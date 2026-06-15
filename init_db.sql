CREATE TABLE IF NOT EXISTS medications (
       id SERIAL PRIMARY KEY,
       name VARCHAR(100) NOT NULL,
       expiration_date DATE NOT NULL,
       quantity INT NOT NULL
   );
   INSERT INTO medications (name, expiration_date, quantity) VALUES 
   ('Парацетамол', '2025-12-01', 150),
   ('Ибупрофен', '2024-08-15', 80);