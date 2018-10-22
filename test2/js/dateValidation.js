
    function isValidDate(ds, format) 
    {

        var reDate = /^(?!(?:10([-./])(?:0?[5-9]|1[0-4])\1(?:1582)))(?:(?:(?:(?:0?[13578]|1[02])(\/|-|\.)31)\2|(?:(?:0?[13-9]|1[0-2])(\/|-|\.)(?:29|30)\3))(?:(?!0000)\d{4})$|^(?:0?2(\/|-|\.)29\4(?:(?:(?:(?!000[04]|(?:(?:1[^0-6]|[2468][^048]|[3579][^26])00))(?:(?:(?:\d\d)(?:[02468][048]|[13579][26]))))|(?:(?:16|[2468][048]|[3579][26])00))))$|^(?:(?:0?[1-9])|(?:1[0-2]))(\/|-|\.)(?:0?[1-9]|1\d|2[0-8])\5(?:(?!0000)\d{4}))$/;

        switch(format) 
        {
	        case "dmy":
		        return reDate.test(ds.toString().replace(/(\d?\d)(\D)(\d?\d)(\D)(\d{4})/, "$3$2$1$4$5"));
	        case "ymd":
		        return reDate.test(ds.toString().replace(/(\d{4})(\D)(\d?\d)(\D)(\d?\d)/, "$3$2$5$4$1"));
	        default:
		        return reDate.test(ds);
	    }
    }

    
//    function daterangeValidation(dateFrom, dateTo) 
//    {
//    
//       var start_date = new Date(dateFrom).getDate();
//       var end_date = new Date(dateTo).getDate();

//       if (eval(end_date - start_date) < 0)
//       {
//         alert("Invalid date range."); 
//         return false;
//       }
//       else
//         return true;

//    }