Для корректоной работы программы требуется установить XAMPP для работы с MySQL
В XAMPP требуется установить Apache и MySQL, дальше можно зайти по кнопке "admin", откроется PhpMyAdmin, где можно работать с базой данных 

Также необходимо установить MySqlConnector (все можно найти на официальных сайтах)

Ведущие элементы: 
database.cs - логика базы данных, методы открытия и зарытия, оплучения подключения
Delivery.cs - основная форма и её логика, методы
DeliveryList.cs - вторая форма, с фильтрацией районов и кнопкой вставки данных из файла конфифгурации App.config (информацию о вставке значений из файла конфигурации можно посмотреть по кнопке "Посмотреть логи" или в phpMyAdmin обычным SELECT'ом)
UnitTest1.cs - примеры проведения тестов на логирования и подключение базы данных
Program.cs - запуск начальной формы

Для работы с базой данных из C# нужно установить пакеты, для этого следуем пути (в случае, если они рне докачаны):
Средства -> Диспетчер пакетов NuGet-> Упралвленгие пакетов NuGet для решения

В поиске необходимо ввести и скачать следующие названия:
MySql.Data, NuGet.Frameworks

Дальше нужно поместить две папки в одной директории и запустить файл test.sln

По необходимости создания приложения (.application) нужно:
ПКМ по проекту "test" в обозревателе решений -> Опубликовать -> Указать место, нажать готово -> через некоторое время приложение установится в нужный путь, откуда его можно запустить

Вставка данных из файла конфигурации происходит из файла App.config. Используя тег <appSettings> я вписал туда ключи со значениями

В остальном приложение работает также, как стандартное приложение Microsoft WinForms
