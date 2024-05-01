/*using CinemaSocial.Data;

namespace CinemaSocial.Models.Repositories;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

public class UnitOfWork : IUnitOfWork, IDisposable
{
    public UnitOfWork( GameContext context, IFactory factory )
    {
        Context = context;
        Factory = factory;
    }

    public IFactory  Factory { get; }
    protected DbContext Context { get; }

    private IDbContextTransaction? Transaction { get; set; }

    public void Begin()
    {
        Transaction = Context.Database.BeginTransaction();
    }

    public void Commit()
    {
        Transaction?.Commit();
        Transaction = null;
    }

    public void Rollback()
    {
        Transaction?.Rollback();
        Transaction = null;
    }

    public void SaveChanges()
    {
        Context.SaveChanges();
    }

    private IDictionary<Type, dynamic> Repositories { get; } = new Dictionary<Type, dynamic>();

    public IRepository<TEntity>? GetRepository<TEntity>() where TEntity : Item
    {
        if ( Repositories.ContainsKey( typeof( TEntity ) ) )
            return Repositories[typeof( TEntity )] as IRepository<TEntity>;

        var repository = CreateRepository<TEntity>();
        if ( repository != null ) Repositories.Add( typeof( TEntity ), repository );

        return repository;
    }

    protected virtual IRepository<TEntity>? CreateRepository<TEntity>() where TEntity : Item
    {
        return new Repository<TEntity>( Factory, Context );
    }

    public void Dispose()
    {
        Context.Dispose();
    }
}*/