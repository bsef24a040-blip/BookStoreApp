using System.Collections.Generic;
using BookStoreApp.Models;

namespace BookStoreApp.ViewModels
{
    public class HomeViewModel
    {
        public List<BookCardViewModel> Books { get; set; }
        public List<Author> Authors { get; set; }
    }
}