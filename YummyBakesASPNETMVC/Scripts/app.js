$('#recipe-details').live('pagecreate', function (event) {
    $(".review-form").validate({
        submitHandler: function (form) {            
            var data = {
                RecipeId: $('#recipeId').val(),
                Author: $('#name').val(),
                Title: $('#title').val(),
                Rating: $(".starRating span.chosen").length,
                Body: $('#review-body').val()
            };

            $.ajax({
                type: 'POST',
                url: $(".review-form").attr('action'),
                data: data,
                success: function (result) {
                    $('.review-collapsible').trigger('collapse');
                    $(".review-form")[0].reset();
                    $('.reviews').append(result);
                },
                error: function (request, status, error) {
                    console.log(request.responseText);
                    console.log(status);
                    console.log(error);
                },
                complete: function () {
                    $('.reviews').listview('refresh');
                }

            });
        }
    });

    var element = $('.starRating');    
    $("span", element).each(function () {
        $(this).hover(
				function () { $(this).prevAll().add(this).addClass("hoverChosen", 750); },
				function () { $(this).prevAll().add(this).removeClass("hoverChosen", 750); }
			).click(function () {
			    var rating = $(".starRating span.hoverChosen").length;
			    $("span", element).each(function (index) {
			        $(this).toggleClass("chosen", index < rating);
			    });
			});
    });
});