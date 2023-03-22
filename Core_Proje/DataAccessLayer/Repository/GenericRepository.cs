using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        public void Delete(T t)
        {
            //contexti ele alalım.
            using var c = new Context();

            //dışarıdan gelen entiy'i sil diyoruz.
            c.Remove(t);
            c.SaveChanges();
        }

        //şartlı listeleme yapıcaz burdaki filtre entity'deki herhangi bir property olabilir mail,name yani ıd ye göre değilde bu proplara göre bir listeleme yapabiliriz bunun sayesinde.
        public List<T> GetByFilter(Expression<Func<T, bool>> filter)
        {
            //linq Expression fİLTER
            using var context = new Context();
            //istediğim şarta göre listeleme işlemini bu metot sayesinde gerçekleştirmiş olucam.
            return context.Set<T>().Where(filter).ToList();
        }

        public T GetById(int id)
        {
            //contexti ele alalım.
            using var c = new Context();

            //burda c.set<T> derken entiy'i seçmiş oluyoruz yani Tnin yerine bir entity gelecek ve o entity içinde dışarıdan gelen id'yi bul diyoruz. 
            return c.Set<T>().Find(id);
        }

        public List<T> GetList()
        {
            //contexti ele alalım.
            using var c = new Context();

            //burda c.set<T> derken entiy'i seçmiş oluyoruz yani Tnin yerine bir entity gelecek ve o entity'in tüm kayıtlarını tolist diyerek listeliyoruz.
            return c.Set<T>().ToList();
        }

        public void Insert(T t)
        {
            //contexti ele alalım.
            using var c = new Context();

            //dışarıdan gelen entity'i ekle.
            c.Add(t);
            c.SaveChanges();
        }

        public void Update(T t)
        {
            //contexti ele alalım.
            using var c = new Context();

            //dışarıdan gelen entity'i güncelle.
            c.Update(t);
            c.SaveChanges();
        }
    }
}
