﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Articles
{
    public interface IRepositoryArticle
    {
        IEnumerable<Article> GetAll();
    }
}
