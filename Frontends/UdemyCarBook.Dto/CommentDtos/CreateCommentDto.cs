﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.Dto.CommentDtos
{
    public class CreateCommentDto
    {
        public string NameSurname { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Description { get; set; }
        public int BlogId { get; set; }
    }
}
