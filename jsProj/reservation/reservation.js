$(document).ready(function() {
	$("#arrival_date").focus();

	$("#reservation_form").submit(
		function(event) {
			var isValid = true;

			//ARRIVAL DATE
			var datePattern = /^(0[1-9]|1[0-2])\/(0[1-9]|1\d|2\d|3[01])\/(19|20)\d{2}$/;
			var arrival_date = $("#arrival_date").val().trim();
			if (arrival_date == "") {
				$("#arrival_date").next().text("This field is required.");
				isValid = false;
			}
			else if (!datePattern.test(arrival_date)) {
				$("#arrival_date").next().text("Use MM/DD/YYYY format.");
				isValid = false;
			}
			else {
				$("#arrival_date").next().text("");
			}
			$("#arrival_date").val(arrival_date);

			//NIGHTS
			var numberPattern = /^[0-9]+$/;
			var nights = $("#nights").val().trim();
			if (nights == "") {
				$("#nights").next().text("This field is required.");
				isValid = false;
			}
			else if (!numberPattern.test(nights)) {
				$("#nights").next().text("Must be a valid number.");
				isValid = false;
			}
			else {
				$("#nights").next().text("");
			}
			$("#nights").val(nights);


			// NAME
			var name = $("#name").val().trim();
			if (name == "") {
				$("#name").next().text("This field is required.");
				isValid = false;
			} else {
				$("#name").next().text("");
			}
			$("#name").val(name);

			//EMAIL
			var emailPattern = /\b[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}\b/;
			var email = $("#email").val().trim();
			if (email == "") {
				$("#email").next().text("This field is required.");
				isValid = false;
			}
			else if (!emailPattern.test(email)) {
				$("#email").next().text("Must be a valid email address.");
				isValid = false;
			}
			else {
				$("#email").next().text("");
			}
			$("#email").val(email);

			//PHONE
			var phonePattern = /^\d{3}-\d{3}-\d{4}$/;
			var phone = $("#phone").val().trim();
			if (phone == "") {
				$("#phone").next().text("This field is required.");
				isValid = false;
			}
			else if ( !phonePattern.test(phone) ) {
				$("#phone").next().text("Use 999-999-9999 format.");
				isValid = false;
			}
			else {
				$("#phone").next().text("");
			}
			$("#phone").val(phone);

			if (isValid == false) {
				event.preventDefault();
			}
		}
	);
}); // end ready
