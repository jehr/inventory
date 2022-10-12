using CleanArchitecture.Application.Common.Interfaces;
using Core.Models.Common;
using Domain.Models.Assignment;
using Domain.Models.Campus;
using Domain.Models.Configurations;
using Domain.Models.Inventory;
using Domain.Models.Product;
using Domain.Models.Supplier;
using Microsoft.EntityFrameworkCore;
using System;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArch.Infra.Data.Context
{
    public class U27ApplicationDBContext : DbContext
    {
        private readonly ICurrentUserService _currentUserService;
        public U27ApplicationDBContext(
            DbContextOptions options,
            ICurrentUserService currentUserService
            ) : base(options)
        {
            _currentUserService = currentUserService;
        }

        #region Configuration
        public DbSet<Mark> Marks { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        #endregion

        #region Supplier
        public DbSet<Supplier> Suppliers { get; set; }
        #endregion

        public DbSet<Campus> Campus { get; set; }

        #region TypesAssignment
        public DbSet<TypesAssignment> TypesAssignments { get; set; }
        public DbSet<Assignment> Assignments { get; set; }
        #endregion

        #region IntoInventory
        public DbSet<IntoInventory> IntoInventories { get; set; }
        public DbSet<OutInventory> OutInventories { get; set; }
        public DbSet<DetailOut> DetaislOut { get; set; }
        public DbSet<DetailInto> DetailsInto { get; set; }
        public DbSet<HistoryInventory> HistoryInventories { get; set; }
        #endregion

        #region Product
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductBase> ProducstBase { get; set; }
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Load all assemblies from configurations folder in infra.data
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            var UserInfo = _currentUserService.GetUserInfo();
            var userName = string.Concat(UserInfo.Name, " ", UserInfo.LastName);
            
            foreach (Microsoft.EntityFrameworkCore.ChangeTracking.EntityEntry<Entity> entry in ChangeTracker.Entries<Entity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedBy = _currentUserService.Id;
                        entry.Entity.CreatedByName = userName;
                        entry.Entity.CreatedAt = DateTime.Now;
                        break;

                    case EntityState.Modified:
                        entry.Entity.UpdatedBy = _currentUserService.Id;
                        entry.Entity.UpdatedByName = userName;
                        entry.Entity.UpdatedAt = DateTime.Now;
                        break;
                    case EntityState.Deleted:
                        entry.Entity.DeletedAt = DateTime.Now;
                        entry.Entity.UpdatedByName = userName;
                        entry.Entity.UpdatedBy = _currentUserService.Id;
                        break;
                }
            }

            
            foreach (Microsoft.EntityFrameworkCore.ChangeTracking.EntityEntry<EntityWithIntId> entry in ChangeTracker.Entries<EntityWithIntId>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedBy = _currentUserService.Id;
                        entry.Entity.LastCreatedByName = userName;
                        entry.Entity.CreatedAt = DateTime.Now;
                        break;

                    case EntityState.Modified:
                        entry.Entity.UpdatedBy = _currentUserService.Id;
                        entry.Entity.LastUpdatedByName = userName;
                        entry.Entity.UpdatedAt = DateTime.Now;
                        break;
                    case EntityState.Deleted:
                        entry.Entity.DeletedAt = DateTime.Now;
                        entry.Entity.LastUpdatedByName = userName;
                        entry.Entity.UpdatedBy = _currentUserService.Id;
                        break;
                }
            }




            var result = await base.SaveChangesAsync(cancellationToken);


            return result;
        }


    }
}
