namespace TeoGarden.Application.Interfaces
{
    public class ICategoryService
    {
        Task<List<CategoryViewModel>> GetAllAsync();
    }
}