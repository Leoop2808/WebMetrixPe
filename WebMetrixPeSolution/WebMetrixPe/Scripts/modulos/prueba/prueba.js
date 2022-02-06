var _tbl_prueba = null;
$(document).ready(function () {
	_tbl_prueba = $("#tbl_prueba").DataTable({
		language: _languageDataTables,
		ordering: false,
		responsive: true,
		searching: false
	});
});