<body>
	 <?php 
		$n1="2";
		$n2="2";
		$n3="2";
		$n4="2";
		$media1=($n1*+$n2)/2;
		$media2=($n3*+$n4)/2;
		$soma=$media1+$media2;
		echo "n1= ".$n1.", n2= ".$n2;
		echo "<p>Média</p>";
		echo $media1."<br>";
		echo $media2."<br>";
		if($soma >8){
			echo "<br><b>$soma</b>";
		}
		else{
			echo "<br>$soma";
		}
	?>
</body>