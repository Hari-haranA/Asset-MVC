using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Asset.Models
{
    public class CreateSectionView
    {
        
        public string SectionName { get; set; }

        
        public int Asset_Id { get; set; }

        
        public string SubSectionName { get; set; }
    }
}
