using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VueDemo.Models
{
    public class TypeViewModel
    {
        public int Id { get; set; }
        public string TypeName { get; set; }
        public string Url { get; set; }
        public static List<TypeViewModel> ListAll()
        {
            List<TypeViewModel> navViewModels = new List<TypeViewModel>();
            navViewModels.Add(new TypeViewModel
            {
                Id = 1,
                TypeName = "Jobs",
                Url = "",
            });
            navViewModels.Add(new TypeViewModel
            {
                Id = 2,
                TypeName = "Real Estate",
                Url = "",
            });
            navViewModels.Add(new TypeViewModel
            {
                Id = 3,
                TypeName = "Cars",
                Url = "",
            });
            navViewModels.Add(new TypeViewModel
            {
                Id = 4,
                TypeName = "Home&Garden",
                Url = "",
            });

            return navViewModels;
        }
    }
}
