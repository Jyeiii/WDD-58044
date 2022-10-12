<html>
<body>
<?php
//inequality
$a = 2;
$b = 3;
$bank_balance =90;
echo "<br>";
//comparison operator
if($a > $b) echo "a is greater than b<br>";
echo "<br>";
if($a < $b) echo "a is less than b<br>";
echo "<br>";
if($a >= $b) echo "a is greater than or equal to b<br>";
echo "<br>";
if($a <= $b) echo "a is less than or equal to b<br>";
//logical operator
echo ($a AND $b). "<br>";
echo ($a or $b). "<br>";
echo ($a XOR $b). "<br>";
echo !$a 	. "<br>";
//If statement
if ($bank_balance<100)
{ 
   $money = 1000;
   $bank_balance += $money;
   echo $bank_balance;
}
?>
</body>
</html>