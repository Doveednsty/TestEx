using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEx
{
    //Напишите небольшое приложение для работы с SQLite базой данных.
    //Используйте Entity Framework для подключения к базе.
    //Базу генерировать через код с помощью миграций.
    //Пусть в базе будет две таблицы: "Projects" (Id - идентификатор проекта, DateCreate - дата создания проекта, Name - название проекта,
    //CountryId - страна проекта), "Countries" (Id - идентификатор страны, Name - название страны).
    //Приложение на WinForms.На главной форме журнал проектов, где в табличной части можно увидеть список проектов.
    //И три кнопки на добавление, редактирование и удаление проекта. Добавление и редактирование открывает новую форму для ввода
    //данных или изменения данных соответственно.
    class Country
    {
        public int CountryID { get; set; }
        public string Name { get; set; }
    }
}
