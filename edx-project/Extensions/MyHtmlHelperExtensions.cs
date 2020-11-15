using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace edx_project.Extensions
{
    /// <summary>
    /// Html razor extensions
    /// </summary>
    public static class MyHtmlHelperExtensions
    {
        /// <summary>
        /// Heading for pages
        /// </summary>
        /// <param name="htmlHelper"></param>
        /// <param name="level">h1, h2, h3 headers...</param>
        /// <param name="color">color of your header</param>
        /// <param name="content">your content</param>
        /// <returns></returns>
        public static IHtmlContent ColorfulHeading(this IHtmlHelper htmlHelper, int level, string color, string content)
        {
            level = level < 1 ? 1 : level;
            level = level > 6 ? 6 : level;
            var tagName = $"h{level}";
            var tagBuilder = new TagBuilder(tagName);
            tagBuilder.Attributes.Add("style", $"color:{color ?? "green"}");
            tagBuilder.InnerHtml.Append(content ?? string.Empty);
            return tagBuilder;
        }

        public static IHtmlContent Initialize(this IHtmlHelper htmlHelper, string content, int count=1)
        {
            var div = $"div";
            var tagBuilder = new TagBuilder(div);
            tagBuilder.AddCssClass("text-center");

            var h1 = $"h1";
            var tagBuilder2 = new TagBuilder(h1);
            tagBuilder2.AddCssClass("display-4");
            tagBuilder2.InnerHtml.Append(content);

            //inner element added
            //tagBuilder.InnerHtml.AppendHtml(tagBuilder2);

            for (int i = 0; i < count; i++)
            {
                tagBuilder.InnerHtml.AppendHtml(tagBuilder2);
            }

            return tagBuilder;
        }
    }
}
