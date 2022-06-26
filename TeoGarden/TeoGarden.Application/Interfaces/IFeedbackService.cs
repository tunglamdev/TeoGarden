using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeoGarden.ShareModel.Requests.Feedback;
using TeoGarden.ShareModel.ViewModels;

namespace TeoGarden.Application.Interfaces
{
    public interface IFeedbackService
    {
        Task<List<FeedbackViewModel>> GetAllAsync();
        Task<FeedbackViewModel> GetByIdAsync(int Id);
        Task<List<FeedbackViewModel>> GetByUserIdAsync(int Id);
        Task<List<FeedbackViewModel>> GetByVegetableIdAsync(int Id);
        Task<int> CreateAsync(FeedbackCreateRequest request);
        Task<int> UpdateAsync(FeedbackUpdateRequest request);
        Task<int> DeleteAsync(int Id);
    }
}
