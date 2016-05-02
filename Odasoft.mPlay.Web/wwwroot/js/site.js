// Write your Javascript code.
$(document).on('click', 'a', function (e) {
  var url = $(this).attr('href');
  var classs = $(this).attr('class');
  if (classs == "navR" || url == "#myCarousel") {
    return true;
  } else {
    $.get(url, function (data) {
      $('#myModal .modal-body').html(data);
    });
    $('#myModal').modal('toggle');
    return false;
  }
});