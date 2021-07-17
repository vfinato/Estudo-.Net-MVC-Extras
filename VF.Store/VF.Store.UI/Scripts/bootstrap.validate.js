$.validator.setDefaults({

    highlight: function(element) {

        $(element)
            .closest('.mb-3')
            .find('input,label,select,textarea,span')
            .addClass('is-invalid')

    },

    unhighlight: function(element) {

        $(element)
            .closest('.mb-3')
            .find('input,label,select,textarea,span')
            .removeClass('is-invalid')

    }

})