<?php
    $con=mysqli_connect("localhost","root","","Answers");
    if (mysqli_connect_errno())
    {
    echo "Failed to connect to MySQL: " . mysqli_connect_error();
    }

    // Perform queries and print out affected rows
    mysqli_query($con,"SELECT * FROM Answers");
    echo "Affected rows: " . mysqli_affected_rows($con);

    mysqli_close($con);
?>