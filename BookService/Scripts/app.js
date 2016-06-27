var ViewMode = function() {
    var self = this;
    self.books = ko.observableArray();
    self.error = ko.observable();

    var booksUri = '/api/books/';

    function ajaxHelper(uri, method, data) {
        self.error('');
        return $.ajax({
                type: method,
                url: uri,
                datatype: 'json',
                contentType: 'application/json',
                data: data ? JSON.stringify(data) : null
            })
            .fail(function(jqXHR, textStatus, errorThrown) {
                self.error(errorThrown);
            });

    }

    function getAllBooks() {
        ajaxHelper(booksUri, 'GET')
            .done(function(data) {
                self.books(data);
            });
    }

    getAllBooks();

};

ko.applyBindings(new ViewModel());

