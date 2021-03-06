﻿using E13.Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E13.Common.Data.Db.Tests.Sample
{
    public class TestCreatable : ICreatable
    {
        public Guid Id { get; set; }
        public string Text { get; set; }

        public string CreatedBy { get; set; }
        public string CreatedSource { get; set; }
        public DateTime Created { get; set; }
    }
}
