<html>
<meta charset="ut-8"  />
<style type = "text/css">
body {background-color:magenta; color:black}
</style>
<body>
    
<?php
$name = $_POST["name"];
$phone = $_POST["phone"];
$subs = $_POST["subs"];
$size = $_POST["size"];
$coupon = $_POST["coupon"];
$subcost = 0;
?>

<?php
print("Thank you for your order $name <br /> $phone <br /> of $subs subs <br />");
?>

<?php
if ($size == large){
    $subcost = $subs * 5.99;
}
elseif ($size == medium){
    $subcost = $subs * 4.99;
}
elseif ($size == mini){
    $subcost = $subs * 2.99;
}

if($coupon){
    $subcost = $subcost - 1.50;
}

printf("The cost is %4.2f", $subcost);

?>

<?php
$subfile = fopen("order.txt","a") or
die("File could not be opened");
fputs($subfile,"$name $phone $subs $subcost");
fclose($subfile);
?>
</body>    
</html>