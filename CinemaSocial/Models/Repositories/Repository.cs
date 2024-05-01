/*using System.Linq.Expressions;
using CinemaSocial.Data;
using Microsoft.EntityFrameworkCore;

namespace CinemaSocial.Models.Repositories;


public class Repository<TEntity> : IRepository<TEntity> where TEntity : Item
{
    public Repository( IFactory factory, DbContext context )
    {
        Factory = factory;
        Context = context;
    }

    protected IFactory  Factory { get; set; }
    protected DbContext Context { get; set; }

    public IEnumerable<TEntity> GetAll()
    {
        return Context.Set<TEntity>();
    }

    public TEntity? Get( int id ) 
    {
        return Context.Set<TEntity>()?.FirstOrDefault( x => x.ID == id );
    }

    public TEntity? Create( params object?[]? args )
    {
        return Factory.Create<TEntity>( args );
    }

    public void Insert(TEntity item)
    {
        Context.Set<TEntity>().Add(item);
    }

    public void Update(TEntity item)
    {
        Context.Entry(item).State = EntityState.Modified;
    }

    public void Delete(TEntity item)
    {
        Context.Remove(item);
    }

    public void Ensure<TProperty>( TEntity entity, Expression<Func<TEntity, TProperty>> expression ) where TProperty : class
    {
        Context.Entry( entity ).Reference( expression ).Load();
    }

    public void Ensure<TProperty>( TEntity entity, Expression<Func<TEntity, IEnumerable<TProperty>>> expression ) where TProperty : class
    {
        Context.Entry( entity ).Collection( expression ).Load();
    }
    
    public TEntity GetAnyIncluding(params Expression<Func<TEntity, object>>[] includeProperties)
    {
        IQueryable<TEntity> query = Context.Set<TEntity>();
        foreach (var includeProperty in includeProperties)
        {
            query = query.Include(includeProperty);
        }
        return query.FirstOrDefault();
    }
}*/