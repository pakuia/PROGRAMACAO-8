<body>
	 <?php 
		$months = array("Janeiro", "Fevereiro", "Mar�o", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro");
		echo "<p>Com foreach:</p><br>";
		foreach($months as $j){
			echo "<p>$j</p>";
		}
		echo "<br><p>Com for</p><br>";
		for($i=0; $i<12; $i++){
			echo "<p>$months[$i]</p>";
		}
	?>
</body>