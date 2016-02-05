<html>
    <body bgcolor = "peachpuff">
<?php
$connect = mysql_connect("localhost","root","abc123");

if(!$connect){
    die("could not connect to db".mysql_error($connect));
}
else {
    mysql_select_db("waldoinc") or die ("could not connect");
    $sqlcmd = "Select * from customers";
    $resultset = mysql_query($sqlcmd, $connect);
    if ($resultset) {
        printf("<table>");
        while ($row = mysql_fetch_row($resultset)) {
            printf("<tr>");
            for ($i = 0; $i < count($row); $i += 1){
                printf("<td>%s</td>", $row[$i]);
            }
            printf("</tr>");
        }
        printf("</table>");
    }
    
}

mysql_close($connect);

?>
    </body>
</html>