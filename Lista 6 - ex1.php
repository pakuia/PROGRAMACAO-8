<body>
	 <?php 
		$n1="2";
		$n2="2";
		$media=($n1*0.35)+($n2*0.65);
		echo "n1= ".$n1.", n2= ".$n2;
		echo "<p>Média</p>";
		echo $media;
		if($media >=7){
			echo "<br><font color = 'green'> 'Aprovado'";
		}
		else{
			echo "<br><font color = 'red'> 'Reprovado'";
		}
	?>
</body>