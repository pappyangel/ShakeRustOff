window.bootstrapInterop = {
    showModal: function(id) {
        const modal = new bootstrap.Modal(document.getElementById(id));
        modal.show();
    }
};