namespace CrudExam
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class CrudContext : DbContext
    {
        // Контекст настроен для использования строки подключения "CrudContext" из файла конфигурации  
        // приложения (App.config или Web.config). По умолчанию эта строка подключения указывает на базу данных 
        // "CrudExam.CrudContext" в экземпляре LocalDb. 
        // 
        // Если требуется выбрать другую базу данных или поставщик базы данных, измените строку подключения "CrudContext" 
        // в файле конфигурации приложения.
        public CrudContext()
            : base("name=CrudContext")
        {
        }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Street> Streets { get; set; }
        public DbSet<City> Cities { get; set; }
        // Добавьте DbSet для каждого типа сущности, который требуется включить в модель. Дополнительные сведения 
        // о настройке и использовании модели Code First см. в статье http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}