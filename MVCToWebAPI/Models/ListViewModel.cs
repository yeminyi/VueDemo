using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VueDemo.Models
{
    public class ListViewModel
    {
        public int Id { get; set; }
        public string MarketItemTitle { get; set; }
        public string MarketItemDetail { get; set; }
        public string CreateTime { get; set; }
        public int CreateUserId { get; set; }
        public int TypeId { get; set; }
        public string TypeName { get; set; }
        public bool IsRecommend { get; set; }
        public bool IsDel { get; set; }
        /// <summary>
        /// Mocking the list
        /// </summary>
        /// <returns></returns>
        public static List<ListViewModel> ListAll()
        {
            List<ListViewModel> marketListAll = new List<ListViewModel>();
            for (int i = 0; i < 8; i++)
            {
                bool IsRecommend = false;
                if (i > 4)
                {
                    IsRecommend = true;
                }
                marketListAll.Add(new ListViewModel
                {
                    Id = 1000+i,
                    MarketItemTitle = "Job Title " + (i+1).ToString(),
                    MarketItemDetail = "Job Description Details",
                    CreateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                    CreateUserId = 1,
                    TypeId = 1,
                    TypeName = "Jobs",
                    IsRecommend = IsRecommend,
                    IsDel = false,
                });
            }
            for (int i = 0; i < 8; i++)
            {
                bool IsRecommend = false;
                if (i > 4)
                {
                    IsRecommend = true;
                }
                marketListAll.Add(new ListViewModel
                {
                    Id = 2000+i,
                    MarketItemTitle = "Real Estate Title " + (i+1).ToString(),
                    MarketItemDetail = "Real Estate Detais",
                    CreateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                    CreateUserId = 1,
                    TypeId = 2,
                    TypeName = "Real Estate",
                    IsRecommend = IsRecommend,
                    IsDel = false,
                });
            }
            for (int i = 0; i < 8; i++)
            {
                bool IsRecommend = false;
                if (i > 4)
                {
                    IsRecommend = true;
                }
                marketListAll.Add(new ListViewModel
                {
                    Id = 3000+i,
                    MarketItemTitle = "Cars Test " + (i+1).ToString(),
                    MarketItemDetail = "Cars Description Details",
                    CreateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                    CreateUserId = 1,
                    TypeId = 3,
                    TypeName = "Cars",
                    IsRecommend = IsRecommend,
                    IsDel = false,
                });
            }
            for (int i = 0; i < 8; i++)
            {
                bool IsRecommend = false;
                if (i > 4)
                {
                    IsRecommend = true;
                }
                marketListAll.Add(new ListViewModel
                {
                    Id = 4000+i,
                    MarketItemTitle = "Home&Garden Title "+ (i+1).ToString(),
                    MarketItemDetail = "Home&Garden Description Details",
                    CreateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                    CreateUserId = 1,
                    TypeId = 4,
                    TypeName = "Home&Garden",
                    IsRecommend = IsRecommend,
                    IsDel = false,
                });
            }
            return marketListAll;
        }
    }
}