using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeoGarden.ShareModel.Requests.Feedback;
using TeoGarden.ShareModel.ViewModels;

namespace TeoGarden.Sdk.Services
{
    public interface IFeedbackApi
    {
        [Get("/api/Feedbacks/GetByVegetable/{Id}")]
        Task<List<FeedbackViewModel>> GetByVegetableAsync(int Id);

        [Post("/api/Feedbacks")]
        Task<FeedbackViewModel> CreateAsync(FeedbackCreateRequest request);

        [Put("/api/Feedbacks")]
        Task<FeedbackViewModel> UpdateAsync(FeedbackUpdateRequest request);

        [Get("/api/Feedbacks/AverageVote/{vegetableId}")]
        Task<double> GetAverageVoteAsync(int vegetableId);
    }
}
