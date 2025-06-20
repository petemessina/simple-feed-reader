﻿using System;

namespace SimpleFeedReader.ViewModels
{
    public class NewsStoryViewModel
    {
        public DateTimeOffset Published { get; set; }

        public string Title { get; set; }

        public string Uri { get; set; }

        public string Summary { get; set; }

        public string FeedTitle { get; set; }
    }
}
