using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    //burda <> içinde bir entity değeri almam gerekiyor. Bunu parametre olarak alacağım için T diyorum.
    //yani burada T derken belirttiğim şey aslında T'lerin yerine gelecek olan ENTİTY'LERDİR.
    //where T : class ile bu T bir classa ait bütün değerleri üzerine alabilir.
    public interface IGenericDal<T> where T : class
    {
        //CRUD TEMEL METOTLARIM

        //bu parantez içindeki T aslında yukarıdaki T'lerden geliyor. Bunlar birbirini karşılıyor.
        void Insert(T t);
        void Delete(T t);
        void Update(T t);
        List<T> GetList();
        //T türünü yani entity'i geri döndüreceksin, dışarıdan id değeri alacaksın.
        T GetById(int id);

        //şartlı listeleme yapıcaz burdaki filtre entity'deki herhangi bir property olabilir mail,name yani ıd ye göre değilde bu proplara göre bir listeleme yapabiliriz bunun sayesinde.
        List<T> GetByFilter(Expression<Func<T, bool>> filter);

    }
}
