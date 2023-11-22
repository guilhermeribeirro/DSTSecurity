document.getElementById('btn-submit').addEventListener('click', function (event) {
    event.preventDefault();

    const email = document.getElementById('Email').value;
    const password = document.getElementById('Senha').value;

    // Simule a autentica��o no servidor (backend)
    authenticateUser(Email, Senha);
});

function authenticateUser(Email, Senha) {
    // Aqui voc� faria a chamada ao backend para autenticar o usu�rio
    // Pode ser usando AJAX (fetch) ou bibliotecas como axios

    // Neste exemplo, vou simular uma autentica��o simples
    if (Email === 'usuario@email.com' && Senha === 'senha123') {
        // Login bem-sucedido
        window.location.href = 'pagina-secreta.html'; // Redireciona para a p�gina ap�s o login
    } else {
        // Exibe mensagem de erro
        document.getElementById('errorMessage').innerText = 'Email ou senha incorretos';
    }
}
