<body>
	<form method="POST">
		<select name="op">
			<option value="">Select...</option>
			<option value="A">Adição</option>
			<option value="S">Subtração</option>
			<option value="D",$op="D">Divisão</option>
			<option value="M">Multiplicação</option>
		</select>
		<button type="submit">Calcular</button>
	</form>

	<?php 
	$n1 = 10;
	$n2 = 5;
	$res = 0;
	$op = isset($_POST['op']) ? $_POST['op'] : "";

	function soma($x, $y) {
		return $x + $y;
	}

	function subtracao($x, $y) {
		return $x - $y;
	}

	function multiplicacao($x, $y) {
		return $x * $y;
	}

	function divisao($x, $y) {
		return $x / $y;
	}

	echo "<p>n1=10</p>";
	echo "<p>n2=5</p>";

	if($op != "") {
		switch ($op) {
			case "A":
			$res=soma($n1, $n2);
			break;
			case "S":
			$res=subtracao($n1, $n2);
			break;
			case "D":
			$res=divisao($n1, $n2);
			break;
			case "M":
			$res=multiplicacao($n1, $n2);
			break;
		}
		echo "<p>Resposta: ".$res."</p>";
	} else {
		echo "<p>Por favor, informe uma operação</p>";
	}
	?>
</body>