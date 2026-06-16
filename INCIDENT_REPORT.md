**№1
СИМПТОМ:**
Ошибка связанная с DotEnv (библиотека не устанавленна)

Причина:
библиотека не устанавленна

Решение:
dotnet add package DotNetEnv в терминал 


**№2
СИМПТОМ:**
Произошла ошибка при загрузке данных.

Причина:
Не инцелезирован env.Load();

Решение:
добавление env.Load(); в public DatabaseService() 


**№3
СИМПТОМ:**
Не выводит ошибки в logs 

Причина:
Не добавлен Log.Error

Решение:
Вместо MessageBox.shop ,нужно добавить Log.Error($"Произошла ошибка при загрузке данных. ({ex})");


**№4
СИМПТОМ:**
<img width="794" height="60" alt="image" src="https://github.com/user-attachments/assets/78d91f11-6d84-4f98-bc4f-7376889ca806" />

Причина:
Не добавлен Exception в вывод

Решение:
Добавление exception в лог
Log.Error($"Произошла ошибка при загрузке данных. ({ex})");


**№5
СИМПТОМ:**
Не подключается через env 

<img width="772" height="325" alt="image" src="https://github.com/user-attachments/assets/27659cc3-c8e0-4323-a637-e246647bacb0" />


Причина:
.env файл должен находиться в папке где запускается проект

Решение:
Перенес .env в папку debug

<img width="1086" height="369" alt="image" src="https://github.com/user-attachments/assets/01b26196-e1d5-4cce-90a6-785c377310e9" />



**ЧИСТКА КОДА**
<img width="539" height="89" alt="image" src="https://github.com/user-attachments/assets/5e59cdb8-bebd-43eb-b44c-4c756cb52db3" />
<img width="467" height="178" alt="image" src="https://github.com/user-attachments/assets/1bfaa734-7ec7-4de6-8317-d3d7830416ed" />

**Проект запускается**

<img width="1891" height="788" alt="image" src="https://github.com/user-attachments/assets/6ee87c52-2cbb-47ff-a44a-eebcbf4a358d" />


**Ошибки**
<img width="754" height="515" alt="image" src="https://github.com/user-attachments/assets/167dd58c-ac44-4b77-8207-40bcd76fccdb" />




