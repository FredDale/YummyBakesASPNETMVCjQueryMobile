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
                    $('html, body').animate({
                        scrollTop: $(".reviews li:last-child").offset().top
                    }, 2000);
                    $(".reviews li:last-child").animateHighlight();
                },
                error: function (request, status, error) {
                    console.log(request.responseText);
                    console.log(status);
                    console.log(error);
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

    $.fn.animateHighlight = function (highlightColor, duration) {
        var highlightBg = highlightColor || "#FADC53";
        var animateMs = duration || 800;
        var originalBg = this.css("background-color");

        if (!originalBg || originalBg == highlightBg)
            originalBg = "#FFFFFF"; // default to white

        $(this)
            .css("backgroundColor", highlightBg)
            .animate({ backgroundColor: originalBg }, animateMs, null, function () {
                $(this).css("backgroundColor", originalBg);
            });
    };
});




