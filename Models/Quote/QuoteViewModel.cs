using System.Collections;
using System.Reflection;
using TestWebsite.Enums;

namespace TestWebsite.Models.Quote
{
    public class QuoteViewModel
    {
        public Quote Quote { get; set; }
        public GeneralEnum.Title Title { get; set; } = new GeneralEnum.Title();
    }
}
