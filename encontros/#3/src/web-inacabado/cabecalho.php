<!DOCTYPE html>
<head>
    <title><?php print $cabecalho_title ?></title>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width">
    <link rel="stylesheet" href="css/reset.css">
    <link rel="stylesheet" href="css/index.css">
    <link rel="stylesheet" href="css/estilo.css">
    <link rel="stylesheet" href="css\animacao-produtos.css">
    <?php print @$cabecalho_css; ?>
    <link rel = "stylesheet" href="css/mobile.css" media="(max-width:939px)">
    <link href='http://fonts.googleapis.com/css?family=PT+Sans|Bad+Script' rel='stylesheet'>
</head>
<body>
<header class="container">
        <h1><a href="index.php"><img src="mirrorfashion\img\logo.png" alt="Mirror Fashion"></a></h1>
        <p class="sacola">
            Nenhum item na sacola de compras
        </p>
        <nav class="menu-opcoes">
            <ul>
                <li><a href="#">Sua Conta</a></li>
                <li><a href="#">Lista de Desejos</a></li>
                <li><a href="#">Cartão Fidelidade</a></li>
                <li><a href="sobre.php">Sobre</a></li>
            </ul>
        </nav>
</header>