function checkS() {
    var table = document.getElementById('AllPeopleList');

    var rowLength = table.rows.length;

    for (var i = 0; i < rowLength; i += 1) {
        var row = table.rows[i];

        //your code goes here, looping over every row.
        //cells are accessed as easy

        var cellLength = row.cells.length;
        for (var y = 0; y < cellLength; y += 1) {
            var cell = row.cells[y];

            if (cell.charAt(0) == "S") {
                table[i].style.color = "red";
            }
            else {
                table[i].style.color = "black";
            }
        }
    }
}
