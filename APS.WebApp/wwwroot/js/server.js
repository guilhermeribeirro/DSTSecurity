const express = require('express');
const bodyParser = require('body-parser');
const mysql = require('mysql');

const app = express();
const port = 3000;

app.use(bodyParser.urlencoded({ extended: true }));

// Configuração do banco de dados
const db = mysql.createConnection({
    host: '201.62.57.93, 1434',
    user: 'RA038216',
    password: '038216',
    database: 'BD038216',
});

// Conectar ao banco de dados
db.connect((err) => {
    if (err) {
        console.error('Erro ao conectar ao banco de dados:', err);
    } else {
        console.log('Conectado ao banco de dados');
    }
});

// Rota de autenticação
app.post('/login', (req, res) => {
    const { email, password } = req.body;

    // Consulta no banco de dados para verificar as credenciais
    const sql = 'SELECT * FROM clientes WHERE email = ? AND senha = ?';
    db.query(sql, [Email, Senha], (err, result) => {
        if (err) {
            console.error('Erro na consulta ao banco de dados:', err);
            res.status(500).send('Erro interno no servidor');
        } else {
            if (result.length > 0) {
                // Autenticação bem-sucedida
                res.send('Autenticação bem-sucedida');
            } else {
                // Credenciais inválidas
                res.status(401).send('Email ou senha incorretos');
            }
        }
    });
});

app.listen(port, () => {
    console.log(`Servidor rodando em http://localhost:${port}`);
});
