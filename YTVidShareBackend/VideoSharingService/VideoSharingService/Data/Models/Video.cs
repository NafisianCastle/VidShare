﻿using System;
using System.Collections.Generic;

namespace VideoSharingService.Data.Models
{
    public class Video
    {
        public int VideoID { get; set; }
        public string ThumbnailUrl { get; set; }
        public string Url { get; set; }
        public string Title { get; set; }
        public DateTime UploadDate { get; set; }
        public int ViewCount { get; set; }

        public string UserEmail { get; set; }

        public virtual IList<Reaction> Reactions { get; set; }
    }
}
