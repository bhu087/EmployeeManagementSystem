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