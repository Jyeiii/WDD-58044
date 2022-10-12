<html>
<body>
<?php

//Grade_System
			echo "<br><br>";
			$name = "Jun Jyei Tallod";
			$grade = 81;
			if ($grade >= 70) 
			{
				echo "Name: ".$name . "<br>Grade: ". $grade . ", You PASSED!<br>";
			} 
			elseif (($grade >=60) && ($grade <=69))
			{
				echo "Name: ".$name . "<br>Grade: ".$grade . ", Get REMEDIAL!<br>";
			}
			else
			{
				echo "Name: ".$name . "<br>Grade: ".$grade . ", You FAILED!<br>";
			}

?>


</body>
</html