В файле SQL query.txt указаны 2 запроса для выбора всех пар «Имя продукта – Имя категории». Первый с использованием LEFT JOIN, второй - с использованием RIGHT JOIN.

Касательно третьего пункта из "Дополнительно к работоспособности оценим", а именно "Вычисление площади фигуры без знания типа фигуры в compile-time" - для его реализации 
моих знаний недостаточно или потребуется слишком много времени для поиска способов реализации и проработки всех возможных вариантов как можно реализовать.

Идеи как можно попробовать реализовать:
1. Запрашивать у пользователя параметры фигуры и формулу, по которой необходимо произвести расчёт площади фигуры
2. Как-то анализировать что это может быть за фигура на основании введёных пользователем параметров и уже под результат анализа выбирать имеющийся способ расчёта или опять же запрашивать формулу,
   если по результату анализа не удалось определить тип фигуры



Задание:
Напишите на C# библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам. 

Дополнительно:
- Юнит-тесты
- Легкость добавления других фигур
- Вычисление площади фигуры без знания типа фигуры в compile-time
- Проверку на то, является ли треугольник прямоугольным


В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов. Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно должно выводиться.
