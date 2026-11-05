using BookStoreApp.Models;
using Microsoft.AspNetCore.Mvc;

[HttpPost]
public IActionResult AddBook(string title, string price, int authorId)
{
    if (!string.IsNullOrWhiteSpace(title))
    {
        decimal.TryParse(price, out decimal parsedPrice);
        int newId = books.Count > 0 ? books.Max(b => b.Id) + 1 : 1;
        books.Add(new Book
        {
            Id = newId,
            Title = title,
            Price = parsedPrice,
            AuthorId = authorId
        });
    }
    return RedirectToAction("Index");
}