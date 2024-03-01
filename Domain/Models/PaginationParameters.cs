namespace Domain.Models
{
    public class PaginationParameters
    {
        public int CurrentPage { get; set; } = 1;
        public int PageSize { get; set; } = 10;
    }
}
