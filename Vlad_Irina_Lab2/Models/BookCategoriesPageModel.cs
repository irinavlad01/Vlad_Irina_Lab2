using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json.Bson;
using Vlad_Irina_Lab2.Data;
namespace Vlad_Irina_Lab2.Models
{
    public class BookCategoriesPageModel: PageModel
    {
        public List<AssignedCategoryData>? AssignedCategoryDataList;
        public void PopulateAssignedCategoryData(Vlad_Irina_Lab2Context context, Book book)
        {
            var allCategories = context.Category;
        }
    }
}
