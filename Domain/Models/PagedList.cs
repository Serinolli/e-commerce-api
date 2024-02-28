using System;
using System.Collections.Generic;

namespace Domain.Models
{
    public class PagedList<T> : List<T>
    {
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
        public int PageSize { get; set; }
        public int TotalRecords { get; set; }

        public PagedList(List<T> records, int currentPage, int pageSize)
        {
            CurrentPage = currentPage;
            PageSize = pageSize;
            TotalRecords = records.Count;
            TotalPages = (int)Math.Ceiling(records.Count / (double)pageSize);
            AddRange(records);
        }

        public PagedList() { }
    }
}
