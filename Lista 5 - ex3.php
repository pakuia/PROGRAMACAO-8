<body>
	 <?php 
		$nome = "Léo";
		$cores = array("orange", "blue", "red", "green", "yellow");
		echo "<p>Nome: Laranja, Azul, Vermelho, Verde e Amarelo</p><br>";
		foreach($cores as $aux){
			echo "<font color = '$aux'>$nome <br>";
		}
	?>
</body>