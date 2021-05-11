function deActiveLogin() {
	$(document).ready(function () {
		$("#LoginDiv").hide();
	});
}
function deActiveRegister() {
	$(document).ready(function () {
		$("#RegisterDiv").hide();
	});
}
function deActiveUpdate() {
	$(document).ready(function () {
		$("#UpdateDiv").hide();
	});
}
function activeLogin() {
	$(document).ready(function () {
		$("#LoginDiv").show();
	});
	deActiveUpdate();
	deActiveRegister();
}
function activeRegister() {
	$(document).ready(function () {
		$("#RegisterDiv").show();
	});
	deActiveUpdate();
	deActiveLogin();
}
function activeUpdate() {
	$(document).ready(function () {
		$("#UpdateDiv").show();
	});
	deActiveLogin();
	deActiveRegister();
}


function LoginAction() {
	$(document).ready(function () {
		console.log($("#LoginName").val());
		console.log($("#loginMobile").val());
		var formData = new FormData;
		formData.append("employeeId", $("#loginEmpID").val());
		formData.append("mobile", $("#loginMobile").val());

		console.log(formData);
		$.ajax({
			url: "api/login",
			type: 'POST',
			cache: false,
			contentType: false,
			processData: false,
			data: formData,
			success: function (response) {
				alert("Logged in successfully");
			},
			error: function (response) {
				alert(response.responseText)
			}
		});
	});
}

function RegistrationAction() {
	$(document).ready(
		function () {
			var formData = new FormData;
			formData.append("id", $("#RegisterEmpID").val());
			formData.append("firstName", $("#firstName").val());
			formData.append("lastName", $("#lastName").val());
			formData.append("mobile", $("#mobile").val());
			formData.append("email", $("#email").val());
			formData.append("city", $("#city").val());
			$.ajax({
				url: "api/register",
				type: "POST",
				cache: false,
				contentType: false,
				processData: false,
				data: formData,
				success: function (responce) {
					alert("Registered Successfully");
				},
				error: function () {
					alert("Not registered");
                }
            });
        }
	);
}

function UpdateAction() {
	console.log("Here");
	$(document).ready(
		function () {
			var formData = new FormData;
			formData.append("id", $("#updateEmpID").val());
			formData.append("mobile", $("#updateMobile").val());
			formData.append("email", $("#updateEmail").val());
			formData.append("city", $("#updateCity").val());
			$.ajax({
				url: "api/update",
				type: "PUT",
				cache: false,
				contentType: false,
				processData: false,
				data: formData,
				success: function (responce) {
					alert("updated Successfully");
				},
				error: function () {
					alert("Not not updated");
				}
			});
        }
	);
}