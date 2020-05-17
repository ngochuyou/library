using library.application.models;
using System;

namespace library.application.service.services {
    class BookService {
        public ServiceResult<Book> validate(Book book) {
            ServiceResult<Book> result = new ServiceResult<Book>();

            if (book.name == null || book.name.Length == 0) {
                result.status = ServiceStatus.INVALID;
                result.messages.Add("name", "Name must not be empty.");
            }

            if (book.author == null || book.author.Length == 0) {
                result.status = ServiceStatus.INVALID;
                result.messages.Add("author", "Author's name must not be empty.");
            }

            if (book.publishDate == null) {
                result.status = ServiceStatus.INVALID;
                result.messages.Add("publishDate", "Publish date must not be empty.");
            }

            if (book.publisher == null || book.publisher.Length == 0) {
                result.status = ServiceStatus.INVALID;
                result.messages.Add("publisher", "Publisher name must not be empty.");
            }

            if (book.price < 0) {
                result.status = ServiceStatus.INVALID;
                result.messages.Add("price", "Price must not be negative.");
            }

            if (book.stockedDate == null) {
                result.status = ServiceStatus.INVALID;
                result.messages.Add("stockedDate", "Stocked date must not be empty.");
            }

            return result;
        }

        public ServiceResult<Book> initialize(Book book) {
            ServiceResult<Book> result = new ServiceResult<Book>();

            book.isActive = true;
            result.model = book;

            return result;
        }
    }
}
