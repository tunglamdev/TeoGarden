using TeoGarden.ShareModel.ViewModels;

namespace TeoGarden.CustomerWebsite.Models
{
    public class ProductViewModel
    {
        public List<VegetableViewModel> Vegetables;
        public VegetableViewModel Vegetable;
        public List<FeedbackViewModel> Feedbacks;
        public string Keyword;
    }
}
