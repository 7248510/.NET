using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.TagHelpers;
namespace ClassSchedule.TagHelpers
{
    [HtmlTargetElement(Attributes = "[type=submit]")] //Button action
    public class SubmitButtonTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context,TagHelperOutput output)
        {
            output.Attributes.AppendCssClass("btn btn-dark"); //Style the button
        }
    }
}
