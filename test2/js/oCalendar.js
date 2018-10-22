

function loadCalendarRange(dateFrom, dateTo) {

    // loads jquery calendar
    $(function () {

        var dates = $('#' + dateFrom + ', #' + dateTo).datepicker({
            dateFormat: "dd/mm/yy",
            changeMonth: true,
            numberOfMonths: 3,
            showCurrentAtPos: 1,
            onSelect: function (selectedDate) {
                var option = this.id == dateFrom ? "minDate" : "maxDate",
        					instance = $(this).data("datepicker"),
        					date = $.datepicker.parseDate(
        						instance.settings.dateFormat ||
        						$.datepicker._defaults.dateFormat,
        						selectedDate, instance.settings);
                dates.not(this).datepicker("option", option, date);
            }
        });
    });

}

