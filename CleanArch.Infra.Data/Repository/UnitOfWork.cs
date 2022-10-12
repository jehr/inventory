using CleanArch.Infra.Data.Context;
using Domain.Interfaces;
using Domain.Models.Assignment;
using Domain.Models.Campus;
using Domain.Models.Configurations;
using Domain.Models.Inventory;
using Domain.Models.Product;
using Domain.Models.Supplier;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Infra.Data.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly U27ApplicationDBContext _ctx;
        private readonly IIntRepository<Assignment> _assignment;
        private readonly IIntRepository<TypesAssignment> _typesAssignment;
        private readonly IIntRepository<Campus> _campus;
        private readonly IIntRepository<Category> _category;
        private readonly IIntRepository<Mark> _mark;
        private readonly IIntRepository<Model> _model;
        private readonly IIntRepository<SubCategory> _subCategory;
        private readonly IIntRepository<DetailInto> _detailInto;
        private readonly IIntRepository<DetailOut> _detailOut;
        private readonly IIntRepository<IntoInventory> _intoInventory;
        private readonly IIntRepository<OutInventory> _outInventory;
        private readonly IIntRepository<Product> _product;
        private readonly IIntRepository<ProductBase> _productBase;
        private readonly IIntRepository<StateProduct> _stateProduct;
        private readonly IIntRepository<TypeProduct> _typeProduct;
        private readonly IIntRepository<Supplier> _supplier;
        private readonly IIntRepository<HistoryInventory> _historyInventory;


        public IIntRepository<Assignment> assignment => _assignment ?? new BaseIntRepository<Assignment>(_ctx);
        public IIntRepository<TypesAssignment> typesAssignment => _typesAssignment ?? new BaseIntRepository<TypesAssignment>(_ctx);
        public IIntRepository<Campus> campus => _campus ?? new BaseIntRepository<Campus>(_ctx);
        public IIntRepository<Category> category => _category ?? new BaseIntRepository<Category>(_ctx);
        public IIntRepository<Mark> mark => _mark ?? new BaseIntRepository<Mark>(_ctx);
        public IIntRepository<Model> model => _model ?? new BaseIntRepository<Model>(_ctx);
        public IIntRepository<SubCategory> subCategory => _subCategory ?? new BaseIntRepository<SubCategory>(_ctx);
        public IIntRepository<DetailInto> detailInto => _detailInto ?? new BaseIntRepository<DetailInto>(_ctx);
        public IIntRepository<DetailOut> detailOut => _detailOut ?? new BaseIntRepository<DetailOut>(_ctx);
        public IIntRepository<HistoryInventory> historyInventory => _historyInventory ?? new BaseIntRepository<HistoryInventory>(_ctx);
        public IIntRepository<IntoInventory> intoInventory => _intoInventory ?? new BaseIntRepository<IntoInventory>(_ctx);
        public IIntRepository<OutInventory> outInventory => _outInventory ?? new BaseIntRepository<OutInventory>(_ctx);
        public IIntRepository<Product> product => _product ?? new BaseIntRepository<Product>(_ctx);
        public IIntRepository<ProductBase> productBase => _productBase ?? new BaseIntRepository<ProductBase>(_ctx);
        public IIntRepository<StateProduct> stateProduct => _stateProduct ?? new BaseIntRepository<StateProduct>(_ctx);
        public IIntRepository<TypeProduct> typeProduct => _typeProduct ?? new BaseIntRepository<TypeProduct>(_ctx);
        public IIntRepository<Supplier> supplier => _supplier ?? new BaseIntRepository<Supplier>(_ctx);

        public UnitOfWork(U27ApplicationDBContext ctx)
        {
            _ctx = ctx;
        }
        
        public string GetDbConnection()
        {
           return _ctx.Database.GetDbConnection().ConnectionString;
        }


        public void Dispose()
        {
            if (_ctx != null)
            {
                _ctx.Dispose();
            }
        }

        public void SaveChanges()
        {
            _ctx.SaveChanges();
        }


        public async Task SaveChangesAsync()
        {
            await _ctx.SaveChangesAsync();
        }
    }
}
