var Connection = require('tedious').Connection;
var config = {
    server: 'localhost.database.windows.net',
    authentication: {
        type: 'default',
        options: {
            userName: 'sa',
            password: 'chetan@18' //update me
        }
    },
    options: {
        // If you are on Microsoft Azure, you need encryption:
        encrypt: true,
        database: 'student' //update me
    }
};
var connection = new Connection(config);
connection.on('connect', function (err) {
    // If no error, then good to proceed.
    console.log("Connected");
});
var request = require('tedious').Request;
var TYPES = require('tedious').TYPES;
function executeStatement() {
    request = new request("SELECT * from dbo.student;", function (err) {
        if (err) {
            console.log(err);
        }
    });
    var result = "";
    request.on('row', function (columns) {
        columns.forEach(function (column) {
            if (column.value === null) {
                console.log('NULL');
            }
            else {
                result += column.value + " ";
            }
        });
        console.log(result);
        result = "";
    });
    request.on('done', function (rowCount, more) {
        console.log(rowCount + ' rows returned');
    });
    connection.execSql(request);
}
