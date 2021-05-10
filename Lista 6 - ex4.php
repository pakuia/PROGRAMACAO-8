<body>
	 <?php 
		$word = "Palavra";
		$size = array(1,2,3,4,5,6,7);
		$j=1;
		echo "<font size = 3><p>Com 'for':</p><br>";
		for($i=1;$i<=7;$i++){
				echo "<font size = '$i'>$word <br>";
		}
		echo "<font size = 3><p>Com 'while':</p><br>";
		while($j <= 7){
			echo "<font size = '$j'>$word <br>";
			$j++;
		}
	?>
</body>