using Core_Proje_Api.DAL.ApiContext;
using Core_Proje_Api.DAL.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Core_Proje_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        //veri listelenmesi get isteği
        [HttpGet]
        public IActionResult GetCategoryList()
        {
            var context = new Context();
            //OK 200 KODU BAŞIRILI SONUÇ ANLAMINDA
            return Ok(context.Categories.ToList());
        }
        //ıdye göre kayıt getirme get isteği
        [HttpGet("{id}")]
        public IActionResult GetByIdCategoryList(int id)
        {
            var context = new Context();
            var value = context.Categories.Find(id);

            if(value == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(value);
            }
        }
        //ekleme işlemi post isteği
        [HttpPost]
        public IActionResult CategoryAdd(Category category)
        {
            using var context = new Context();
            context.Add(category);
            context.SaveChanges();
            return Created("", category);
        }
        //silme işlemi delete isteği
        [HttpDelete]
        public IActionResult CategoryDelete(int id)
        {
            var context = new Context();
            var value = context.Categories.Find(id);
            if(value == null)
            {
                return NotFound();
            }
            else
            {
                context.Remove(value);
                context.SaveChanges();
                //içerik olmadan döndür
                return NoContent();
            }
        }
        //güncelleme işlemi put isteği
        [HttpPut]
        public IActionResult UpdateCategory(Category category)
        {
            var context = new Context();
            var value = context.Find<Category>(category.CategoryId);
            if(value == null)
            {
                return NotFound();
            }
            else
            {
                value.CategoryName = category.CategoryName;
                context.Update(value);
                context.SaveChanges();
                return NoContent();
            }
        }
    }
}
