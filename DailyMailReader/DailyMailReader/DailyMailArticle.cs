using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DailyMailReader
{
    public class DailyMailArticle
    {
        public string status { get; set; }
        public string modifiedDate { get; set; }
        public int videoInstances { get; set; }
        public string largeHeadline { get; set; }
        public string previewText { get; set; }
        public string firstPubDate { get; set; }
        public string readerCommentsCount { get; set; }
        public string pageTitle { get; set; }
        public int articleId { get; set; }
        public string largePreviewText { get; set; }
        public ImageLinkListPuff imageLinkListPuff { get; set; }
        public string readerComments { get; set; }
        public string headline { get; set; }
        public string channel { get; set; }
        public bool videoFlag { get; set; }
        public string shortURL { get; set; }
        public ArticleImage articleImage { get; set; }
        public string shareCount { get; set; }
        public bool sponsoredArticle { get; set; }
        public string topParentChannel { get; set; }
        public string articleURL { get; set; }
    }

    public class ImageLinkListPuff
    {
        public int width { get; set; }
        public string imageType { get; set; }
        public string altTag { get; set; }
        public string caption { get; set; }
        public int imageId { get; set; }
        public string url { get; set; }
        public string source { get; set; }
        public int imageSize { get; set; }
        public int height { get; set; }
        public string hostUrl { get; set; }
    }

    public class ArticleImage
    {
        public int width { get; set; }
        public string imageType { get; set; }
        public string altTag { get; set; }
        public string caption { get; set; }
        public int imageId { get; set; }
        public string url { get; set; }
        public string source { get; set; }
        public int imageSize { get; set; }
        public int height { get; set; }
        public string hostUrl { get; set; }
    }
}
