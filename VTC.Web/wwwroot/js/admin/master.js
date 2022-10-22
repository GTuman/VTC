$(".modal-open").on("click", function (event) {
    event.preventDefault();
    $('.modal-dialog').load(this.href, function () {
        $('#myModal').modal({ show: true });
    });

    var myModal = new bootstrap.Modal(document.getElementById("myModal"), {});

    myModal.show();
})