
/*
@page
@model IndexModel

<select id="idList">
    <option value="1">ID 1</option>
    <option value="2">ID 2</option>
    <option value="3">ID 3</option>
    <!-- Add more options as needed -->
</select>

<button id="getDataButton">Get Data</button>

<div id="result"></div>

<script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
<script>
    $(document).ready(function () {
        $('#getDataButton').click(function () {
            var selectedId = $('#idList').val(); // Get the selected ID from the list

            $.ajax({
                type: 'GET',
                url: '/GetData', // Replace with your endpoint
                data: { id: selectedId }, // Pass the selected ID in the AJAX request
                success: function (data) {
                    $('#result').html(data); // Display the received data in a result container
                },
                error: function () {
                    $('#result').html('Error fetching data.'); // Display an error message if the AJAX call fails
                }
            });
        });
    });
</script>

*/