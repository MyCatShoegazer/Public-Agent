﻿using System.Data.Entity;
using PublicAgentDesktop.Data.Models;

namespace PublicAgentDesktop.Data
{
    /// <summary>
    ///     Представляет контекст базы данных приложения.
    /// </summary>
    public class PublicAgentDbContext : DbContext
    {
        /// <summary>
        ///     Инициализирует контекст данных приложения.
        /// </summary>
        public PublicAgentDbContext()
            : base("name=PublicAgentDbContext")
        {
#if CLEAN_DATA
            Database.SetInitializer(new AlwaysDropDataInitializer());
#else
            Database.SetInitializer(new DropOnModelChangeDataInitializer());
#endif
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            /*
             * Во время создания модели задаём
             * имя схемы данных.
             */
            modelBuilder.HasDefaultSchema("public");

            /*
             * Выставляем соответствие имени модели
             * и имени таблицы в базе данных.
             */
            modelBuilder.Entity<Group>().ToTable("GroupInfo");
            modelBuilder.Entity<User>().ToTable("UserInfo");
        }
        
        /// <summary>
        ///     Коллекция групп привилегий пользователей.
        /// </summary>
        public virtual DbSet<Group> Groups { get; set; }
        
        /// <summary>
        ///     Коллекция пользователей.
        /// </summary>
        public virtual DbSet<User> Users { get; set; }
    }
}