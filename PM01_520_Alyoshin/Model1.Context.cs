﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PM01_520_Alyoshin
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PM01_520_AlyoshinEntities : DbContext
    {
        private static PM01_520_AlyoshinEntities _context;
        public PM01_520_AlyoshinEntities()
            : base("name=PM01_520_AlyoshinEntities")
        {
        }
        public static PM01_520_AlyoshinEntities GetEntities1()
        
        {
            if (_context == null)
            {
                _context = new PM01_520_AlyoshinEntities();
            }
            return _context;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<Event> Event { get; set; }
        public virtual DbSet<Gender> Gender { get; set; }
        public virtual DbSet<Jures> Jures { get; set; }
        public virtual DbSet<Moderators> Moderators { get; set; }
        public virtual DbSet<Organizators> Organizators { get; set; }
        public virtual DbSet<Parcipiants> Parcipiants { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    }
}
