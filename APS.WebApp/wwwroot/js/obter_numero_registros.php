<?php
// Conectar ao banco de dados (substitua as credenciais e o nome do banco de dados conforme necess�rio)
$servername = "201.62.57.93, 1434";
$username = "RA038216";
$password = "038216";
$dbname = "BD038216";

$conn = new mysqli($servername, $username, $password, $dbname);

// Verificar a conex�o
if ($conn->connect_error) {
    die("Falha na conex�o: " . $conn->connect_error);
}

// Consulta SQL para obter o n�mero de registros
$sql = "SELECT COUNT(*) AS NumeroRegistros FROM CadastroPessoas";
$result = $conn->query($sql);

// Obter o n�mero de registros
if ($result->num_rows > 0) {
    $row = $result->fetch_assoc();
    $numeroRegistros = $row["NumeroRegistros"];
} else {
    $numeroRegistros = 0;
}

$conn->close();

// Retornar o n�mero de registros como JSON
echo json_encode(['numeroRegistros' => $numeroRegistros]);
?>
