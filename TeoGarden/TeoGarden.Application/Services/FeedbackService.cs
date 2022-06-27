using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeoGarden.Application.Interfaces;
using TeoGarden.Data.EF;
using TeoGarden.Data.Models;
using TeoGarden.ShareModel.Requests.Feedback;
using TeoGarden.ShareModel.ViewModels;

namespace TeoGarden.Application.Services
{
    public class FeedbackService : IFeedbackService
    {
        private readonly TeoGardenDbContext _context;

        public FeedbackService(TeoGardenDbContext context)
        {
            _context = context;
        }

        public async Task<List<FeedbackViewModel>> GetAllAsync()
        {
            return await _context.Feedbacks.Where(feedback=>feedback.IsDeleted==false).Select(feedback => new FeedbackViewModel()
            {
                Id = feedback.Id,
                UserId = feedback.UserId,
                VegetableId = feedback.VegetableId,
                Comment = feedback.Comment,
                Vote = feedback.Vote,
                FeedbackTime = feedback.FeedbackTime
            }).ToListAsync();
        }

        public async Task<FeedbackViewModel> GetByIdAsync(int Id)
        {
            var feedback = await _context.Feedbacks.Where(feedback => feedback.Id == Id && feedback.IsDeleted == false)
                                                    .FirstOrDefaultAsync();
            if(feedback == null)
            {
                return null;
            }
            return new FeedbackViewModel()
            {
                Id = feedback.Id,
                UserId = feedback.UserId,
                VegetableId = feedback.VegetableId,
                Comment = feedback.Comment,
                Vote = feedback.Vote,
                FeedbackTime = feedback.FeedbackTime
            };
        }

        public async Task<List<FeedbackViewModel>> GetByUserIdAsync(int Id)
        {
            return await _context.Feedbacks.Where(feedback => feedback.UserId == Id && feedback.IsDeleted == false)
                                            .Select(feedback => new FeedbackViewModel()
            {
                Id = feedback.Id,
                UserId = feedback.UserId,
                VegetableId = feedback.VegetableId,
                Comment = feedback.Comment,
                Vote = feedback.Vote,
                FeedbackTime = feedback.FeedbackTime
            }).ToListAsync();
        }

        public async Task<List<FeedbackViewModel>> GetByVegetableIdAsync(int Id)
        {
            return await _context.Feedbacks.Where(feedback => feedback.VegetableId == Id && feedback.IsDeleted == false)
                                            .Select(feedback => new FeedbackViewModel()
            {
                Id = feedback.Id,
                UserId = feedback.UserId,
                VegetableId = feedback.VegetableId,
                Comment = feedback.Comment,
                Vote = feedback.Vote,
                FeedbackTime = feedback.FeedbackTime
            }).ToListAsync();
        }

        public async Task<int> CreateAsync(FeedbackCreateRequest request)
        {
            if (request == null)
            {
                return 0;
            }
            var feedback = new Feedback()
            {
                UserId = request.UserId,
                VegetableId = request.VegetableId,
                Comment = request.Comment,
                Vote = request.Vote
            };

            await _context.Feedbacks.AddAsync(feedback);
            var result = await _context.SaveChangesAsync();
            if (result == 0)
            {
                return 0;
            }
            return feedback.Id;
        }

        public async Task<int> UpdateAsync(FeedbackUpdateRequest request)
        {
            if (request == null)
            {
                return 0;
            }
            var feedback = await _context.Feedbacks.FindAsync(request.Id);
            if(feedback == null || request.IsDeleted==false)
            {
                return 0;
            }
            feedback.Comment = request.Comment;
            feedback.Vote = request.Vote;
            feedback.FeedbackTime = DateTime.Now;
            return await _context.SaveChangesAsync();
        }

        public async Task<int> DeleteAsync(int Id)
        {
            var feedback = await _context.Feedbacks.Where(feedback => feedback.Id == Id && feedback.IsDeleted==false)
                                                    .FirstOrDefaultAsync();
            if(feedback == null)
            {
                return 0;
            }
            feedback.IsDeleted = true;
            return await _context.SaveChangesAsync();
        }
    }
}
