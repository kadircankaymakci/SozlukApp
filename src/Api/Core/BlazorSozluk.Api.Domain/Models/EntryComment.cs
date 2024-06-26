﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace BlazorSozluk.Api.Domain.Models
{
    public class EntryComment:BaseEntity
    {
        public string Content { get; set; }
        public Guid CreatedById { get; set; }
        public Guid EntryId { get; set; }


        public Entry Entry { get; set; }
        public User  CreatedBy { get; set; }
        public virtual ICollection<EntryCommentVote> EntryCommentVotes { get; set; }
        public virtual ICollection<EntryCommentFavorite> EntryCommentFavorites { get; set; }
    }
}
