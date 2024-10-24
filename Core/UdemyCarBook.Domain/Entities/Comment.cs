﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.Domain.Entities
{
    public class Comment
    {
        public int CommentId { get; set; }

        public string NameSurname { get; set; }

        public DateTime CreatedDate { get; set; }

        public string Description { get; set; }

        public int BlogId { get; set; }

        public Blog Blog { get; set; }

    }
}
