/*using System.Linq.Expressions;
using CinemaSocial.Data;

namespace CinemaSocial.Models.Repositories;

public interface IRepository<TEntity> where TEntity : Item
{
    IEnumerable<TEntity> GetAll();

    TEntity? Create( params object?[]? args );

    void Insert( TEntity item/*#1# );
    void Update( TEntity item );
    void Delete( TEntity item );

    void Ensure<TProperty>( TEntity entity, Expression<Func<TEntity, TProperty>> expression ) where TProperty : class;
    void Ensure<TProperty>( TEntity entity, Expression<Func<TEntity, IEnumerable<TProperty>>> expression ) where TProperty : class;
    
    TEntity GetAnyIncluding(params Expression<Func<TEntity, object>>[] includeProperties);
}*/