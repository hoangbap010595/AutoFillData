var CheckoutForm = function () {
    return {
        //Checkout Form 
        initCheckoutForm: function () {
            // Masking 
            $('#thoigianhocbatdau').mask('9999', { placeholder: 'X' });
            $('#thoigianhocketthuc').mask('9999', { placeholder: 'X' });
            $('#field_176').mask('99-99-9999', { placeholder: 'X' });
            $('#field_260').mask('99-99-9999', { placeholder: 'X' });
            $('#field_261').mask('99-99-9999', { placeholder: 'X' });
            // Add validation method 
            $.validator.addMethod("checkngaysinh", function (value, element, param) { if (/[^0-9\-]+/.test(value)) { return true; } },
                $.validator.format('Please enter a valid credit card number.'));
            // Validation 
            $('#sky-form').validate({
                // Rules for form validation 
                rules: {
                    field_68: { required: true },
                    field_250: { required: true },
                    field_257: { required: true },
                    noicaphochieu: { required: true },
                    field_176_days: { required: true },
                    field_176_month: { required: true },
                    field_176_year: { required: true },
                    lh_nguoilienhe: { required: true },
                    lh_dienthoai: { required: true },
                    ld_diachi: { required: true },
                    field_379: { required: true },
                    field_69: { required: true },
                    field_70: { required: true },
                    field_258: { required: true },
                    diachiemail: { required: true, email: true },
                    field_179: { required: true },
                    field_283: { required: true },
                    trinhdotienganh: { required: true },
                    tentruongdaihoc: { required: true },
                    thoigianhocbatdau: { digits: true },
                    thoigianhocketthuc: { digits: true },
                    thoigianhoc: { required: true },
                    hechinhquy: { required: true },
                    diachinoi_nhanthongbao: { required: true }
                },
                // Messages for form validation 
                messages: {
                    field_68: { required: 'TrÆ°á»ng dá»¯ liá»‡u báº¯t buá»™c pháº£i nháº­p' },
                    field_250: { required: 'TrÆ°á»ng dá»¯ liá»‡u báº¯t buá»™c pháº£i nháº­p' },
                    field_257: { required: 'TrÆ°á»ng dá»¯ liá»‡u báº¯t buá»™c pháº£i nháº­p' },
                    noicaphochieu: { required: 'TrÆ°á»ng dá»¯ liá»‡u báº¯t buá»™c pháº£i nháº­p' },
                    field_176_days: { required: 'TrÆ°á»ng dá»¯ liá»‡u báº¯t buá»™c pháº£i nháº­p' },
                    field_176_month: { required: 'TrÆ°á»ng dá»¯ liá»‡u báº¯t buá»™c pháº£i nháº­p' },
                    field_176_year: { required: 'TrÆ°á»ng dá»¯ liá»‡u báº¯t buá»™c pháº£i nháº­p' },
                    lh_nguoilienhe: { required: 'TrÆ°á»ng dá»¯ liá»‡u báº¯t buá»™c pháº£i nháº­p' },
                    lh_dienthoai: { required: 'TrÆ°á»ng dá»¯ liá»‡u báº¯t buá»™c pháº£i nháº­p' },
                    ld_diachi: { required: 'TrÆ°á»ng dá»¯ liá»‡u báº¯t buá»™c pháº£i nháº­p' },
                    field_379: { required: 'TrÆ°á»ng dá»¯ liá»‡u báº¯t buá»™c pháº£i nháº­p' },
                    field_69: { required: 'TrÆ°á»ng dá»¯ liá»‡u báº¯t buá»™c pháº£i nháº­p' },
                    field_70: { required: 'TrÆ°á»ng dá»¯ liá»‡u báº¯t buá»™c pháº£i nháº­p' },
                    field_258: { required: 'TrÆ°á»ng dá»¯ liá»‡u báº¯t buá»™c pháº£i nháº­p' },
                    diachiemail: { required: 'TrÆ°á»ng dá»¯ liá»‡u báº¯t buá»™c pháº£i nháº­p', email: 'HĂ£y nháº­p Ä‘á»‹a chá»‰ email' },
                    field_179: { required: 'TrÆ°á»ng dá»¯ liá»‡u báº¯t buá»™c pháº£i nháº­p' },
                    field_283: { required: 'TrÆ°á»ng dá»¯ liá»‡u báº¯t buá»™c pháº£i nháº­p' },
                    trinhdotienganh: { required: 'TrÆ°á»ng dá»¯ liá»‡u báº¯t buá»™c pháº£i nháº­p' },
                    tentruongdaihoc: { required: 'TrÆ°á»ng dá»¯ liá»‡u báº¯t buá»™c pháº£i nháº­p' },
                    thoigianhocbatdau: { digits: 'HĂ£y nháº­p sá»‘' },
                    thoigianhocketthuc: { digits: 'HĂ£y nháº­p sá»‘' },
                    thoigianhoc: { required: 'TrÆ°á»ng dá»¯ liá»‡u báº¯t buá»™c pháº£i nháº­p' },
                    hechinhquy: { required: 'TrÆ°á»ng dá»¯ liá»‡u báº¯t buá»™c pháº£i nháº­p' },
                    diachinoi_nhanthongbao: { required: 'TrÆ°á»ng dá»¯ liá»‡u báº¯t buá»™c pháº£i nháº­p' }
                },
                // Do not change code below 
                errorPlacement: function (error, element) { error.insertAfter(element.parent()); }
            });
        }
    };
}();