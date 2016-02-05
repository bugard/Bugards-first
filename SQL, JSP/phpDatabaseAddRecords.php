<html>
  <body bgcolor = "peachpuff"> 
<?php
$connect = mysql_connect("localhost","root","abc123");

if(!$connect){
    die("could not connect to db".mysql_error($connect));
}
else{
$name = $_POST["name"];
$phone = $_POST["phone"];
$spent = $_POST["spent"];

$sqlcmd = "INSERT INTO customers VALUES('$name','$phone',$spent)";

}
?>
    </body>
</html>