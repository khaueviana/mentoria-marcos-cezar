<!doctype html>
<html>
    <head>
        <meta charset="UTF-8">
        <title>Checkout Mirror Fashion</title>
        <link rel="stylesheet" href="mirrorfashion/css/bootstrap.css">
        <meta name="viewport" content="width=device-width">
    </head>
    <body>
        <div class="jumbotron">
            <div class="container">
                <h1>Ótima escolha!</h1>
                <p>Obrigado por comprar na Mirror Fashion!
                Preencha seus dados para efetivar a compra.</p>
                <h2>Sua compra</h2>
            </div>
        </div>
        <div class="container">
            <div class="panel panel-success">
                <div class="panel-heading">
                    <h2 class="panel-title">Sua compra</h2>
                </div>
                <div class="panel-body">
                    <img src="mirrorfashion/img/produtos/foto<?= $_POST["ida"] ?>-<?= $_POST["cor"] ?>.png" class="img-thumbnail img-responsive">
                    <dl>
                        <dt>Produto</dt>
                            <dd><?= $_POST['nome'] ?> </dd>
                        <dt>Preço</dt>
                            <dd><?= $_POST['preco'] ?> </dd>
                        <dt>Cor</dt>
                            <dd><?= $_POST['cor'] ?> </dd>
                        <dt>Tamanho</dt>
                            <dd><?= $_POST['tamanho'] ?> </dd>
                    </dl>
                </div>
            </div>
        </div>
    </body>
</html>