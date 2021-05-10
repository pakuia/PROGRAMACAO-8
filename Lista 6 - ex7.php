<body>
	 <?php 
		$months = array("Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro");
		$aux=(bool)true;
		echo "<br><p>Com vetor</p><br>";
		if($aux=true){
			for($i=0; $i<12; $i++){
				echo "<p>$months[$i]</p>";
			}
		}

		echo "<br><p>Sem vetor</p><br>";
		if($aux=true){		
			echo "<p>Janeiro</p>";
			echo "<p>Fevereiro</p>";
			echo "<p>Março</p>";
			echo "<p>Abril</p>";
			echo "<p>Maio</p>";
			echo "<p>Junho</p>";
			echo "<p>Julho</p>";
			echo "<p>Agosto</p>";
			echo "<p>Setembro</p>";
			echo "<p>Outubro</p>";
			echo "<p>Novembro</p>";
			echo "<p>Dezembro</p>";
		}
	?>
</body>