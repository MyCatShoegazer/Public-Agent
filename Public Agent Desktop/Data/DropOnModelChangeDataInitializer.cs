using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using PublicAgentDesktop.Data.Models;
using PublicAgentDesktop.Utility;

namespace PublicAgentDesktop.Data
{
    /// <summary>
    ///     Инициализатор контекста базы данных по умолчанию.
    ///     Удаляет данные только в том случае, если одна из моделей
    ///     изменилась со стороны программного кода.
    /// </summary>
    public class DropOnModelChangeDataInitializer : DropCreateDatabaseIfModelChanges<PublicAgentDbContext>
    {
        protected override void Seed(PublicAgentDbContext context)
        {
            /*
             * Группы привилегий по умолчанию.
             */
            var groups = new List<Group>
            {
                new Group
                {
                    Name = "Администраторы",
                    Description = "Администраторы информационной системы. Обладают наивысшими правами."
                },
                new Group
                {
                    Name = "Пользователи",
                    Description = "Пользователи информационной системы. Обладают стандартными правами."
                },
                new Group
                {
                    Name = "Гости",
                    Description = "Гости информационной системы. Обладают исключительно правами только на чтение записей."
                }
            };

            /*
             * Администратор системы по умолчанию.
             */
            var root = new User
            {
                Login = "root",
                Password = "1234",
                Email = "root@root.org",
                Phone = "9990000",
                LastName = "Root",
                FirstName = "Root",
                Group = groups.FirstOrDefault(g => g.Name == "Администраторы")
            };

            /*
             * Добавление записей по умолчание в контекст.
             */
            context.Groups.AddRange(groups);
            context.Users.Add(root);
        }
    }
}
