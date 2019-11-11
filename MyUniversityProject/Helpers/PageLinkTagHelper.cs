

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using MyUniversityProject.Models.Pagination;
using System.Threading.Tasks;

namespace MyUniversityProject.Helpers
{
    public class PageLinkTagHelper : TagHelper
    {
        private IUrlHelperFactory urlHelperFactory;
        public PageLinkTagHelper(IUrlHelperFactory helperFactory)
        {
            urlHelperFactory = helperFactory;
        }

        [ViewContext]
        [HtmlAttributeNotBound]
        public ViewContext ViewContext { get; set; }
        public PageViewModel PageModel { get; set; }
        public string StorageId { get; set; }
        public string PageAction { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            IUrlHelper urlHelper = urlHelperFactory.GetUrlHelper(ViewContext);
            output.TagName = "div";

            TagBuilder tag = new TagBuilder("ul");
            if (!PageModel.HasPreviousPage)
            {
                TagBuilder nextItem = CreateTagLastAndFirst(PageModel.TotalPages, urlHelper, true);
                tag.InnerHtml.AppendHtml(nextItem);
            }
            if (PageModel.HasPreviousPage)
            {
                TagBuilder prevItem = CreateTag(PageModel.PageNumber - 1, urlHelper);
                tag.InnerHtml.AppendHtml(prevItem);
            }
            int index = 0;
            for (int i = PageModel.PageNumber; i <= PageModel.TotalPages; i++)
                {
                    index++;
                    if (index ==5)
                    {
                        break;
                    }
                    TagBuilder Item = CreateTag(i, urlHelper);
                    tag.InnerHtml.AppendHtml(Item);
                }
            if (!PageModel.HasNextPage)
            {
                TagBuilder nextItem = CreateTagLastAndFirst(1, urlHelper, false);
                tag.InnerHtml.AppendHtml(nextItem);
            }
            output.Content.AppendHtml(tag);
        }

        TagBuilder CreateTag(int pageNumber, IUrlHelper urlHelper)
        {
            TagBuilder item = new TagBuilder("li");
            TagBuilder link = new TagBuilder("a");
            if (pageNumber == this.PageModel.PageNumber)
            {
                item.AddCssClass("active");
                item.AddCssClass("btn btn-primary");
            }
            else
            {
                item.AddCssClass("btn btn-default");
                link.Attributes["href"] = urlHelper.Action(PageAction, new { id = StorageId, page = pageNumber });
            }
            link.InnerHtml.Append(pageNumber.ToString());
            item.InnerHtml.AppendHtml(link);
            return item;
        }

        TagBuilder CreateTagLastAndFirst(int pageNumber, IUrlHelper urlHelper, bool b)
        {
            TagBuilder item = new TagBuilder("li");
            TagBuilder link = new TagBuilder("a");
            if (pageNumber == this.PageModel.PageNumber)
            {
                item.AddCssClass("active");
                item.AddCssClass("btn btn-primary");
            }
            else
            {
                item.AddCssClass("btn btn-default");
                link.Attributes["href"] = urlHelper.Action(PageAction, new { id = StorageId, page = pageNumber });
            }

            if (b)
            {
                link.InnerHtml.Append("Last");
            }
            else
            {
                link.InnerHtml.Append("First");
            }
            
            item.InnerHtml.AppendHtml(link);
            return item;
        }
    }
}