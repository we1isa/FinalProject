using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
    //Generic constraint T'yi sınıflandıralım
    //class : referans tip olabilir dedik int bit T tanımlanamaz.
    //IEntity olabilir veya IEntity implemente eden bir nesne olabilir.
    //new() : newlenebilir olmalı anlamına gelir ve interface newlenemeyeceğinden IEntity'yi devre dışı bırakarak T'ye kesin olarak nesneleri tanımlayabilir kıldık.
{
    public interface IEntityRepository<T> where T : class, IEntity,new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null); //filtreleme yapmak istediğimde ayrı ayrı metotlar yazmam gerekmeyecek. null = filtreleme vermeyedebiliriz
        //Tek bire göre filreleme, detay
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
