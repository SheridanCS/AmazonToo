using System.ComponentModel.DataAnnotations;

namespace AmazonToo.Models
{
    enum Province
    {
        [Display(Name = "Alberta")]
        AB,
    
        [Display(Name = "British Columbia")]
        BC,
    
        [Display(Name = "Manitoba")]
        MB,
    
        [Display(Name = "New Brunswick")]
        NB,
    
        [Display(Name = "Newfoundland")]
        NL,
    
        [Display(Name = "Nova Scotia")]
        NS,
    
        [Display(Name = "Northwest Territories")]
        NT,
    
        [Display(Name = "Nunavut")]
        NU,
    
        [Display(Name = "Ontario")]
        ON,
    
        [Display(Name = "Prince Edward Island")]
        PE,
    
        [Display(Name = "Quebec")]
        QC,
    
        [Display(Name = "Saskatchewan")]
        SK,
    
        [Display(Name = "Yukon Territory")]
        YT
    }
}
