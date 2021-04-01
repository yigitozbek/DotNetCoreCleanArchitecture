using Nightrain.Base.Core.Entities;
using System;
using System.Collections.Generic;

namespace Nightrain.BookStore.Domain.Entities
{
    public class Book : AuditedEntity<int>
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public short PrintLength { get; set; }

        public DateTime Publication { get; set; }

        public short BookSizeId { get; set; }
        public virtual BookSize BookSize { get; set; }

        public int BookFormatId { get; set; }
        public virtual BookFormat BookFormat { get; set; }

        public int LanguageId { get; set; }
        public virtual Language Language { get; set; }

        public int PublisherId { get; set; }
        public virtual Publisher Publisher { get; set; }

    }

}
