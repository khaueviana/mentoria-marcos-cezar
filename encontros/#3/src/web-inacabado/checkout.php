<!doctype html>
<html>
    <head>
        <meta charset="UTF-8">
        <title>Checkout Mirror Fashion</title>
        <link rel="stylesheet" href="mirrorfashion/css/bootstrap.css">
        <link rel="stylesheet" href="mirrorfashion/css/bootstrap-flatly.css">
        <link rel="stylesheet" href="css/checkout.css">
        <meta name="viewport" content="width=device-width">
    </head>
    <body>
    <nav class="navbar navbar-default navbar-fixed-top">
        <div class="navbar-header">
            <a class="navbar-brand" href="index.php">Mirror Fashion</a>
            <button class="navbar-toggle" type="button"
            data-target=".navbar-collapse" data-toggle="collapse">
            <span class="glyphicon glyphicon-align-justify"></span>
            </button>
        </div>
        <ul class="nav navbar-nav collapse navbar-collapse">
            <li><a href="sobre.php">Sobre</span></a></li>
            <li><a href="#">Ajuda</a></li>
            <li><a href="#">Perguntas frequentes</a></li>
            <li><a href="#">Entre em contato</a></li>
        </ul>
    </nav>
        <div class="jumbotron">
            <div class="container">
                <h1>Ótima escolha!</h1>
                <p>Obrigado por comprar na Mirror Fashion!
                Preencha seus dados para efetivar a compra.</p>
                <h2>Sua compra</h2>
            </div>
        </div>
        <div class="container">
            <div class="row">
                <div class="col-sm-4 col-lg-3">
                    <div class="panel panel-success">
                        <div class="panel-heading">
                            <h2 class="panel-title">Sua compra</h2>
                        </div>
                        <div class="panel-body">
                            <img src="mirrorfashion/img/produtos/foto<?= $_POST["ida"] ?>-<?= $_POST["cor"] ?>.png" class="hidden-xs img-thumbnail img-responsive">
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
                <div class="col-sm-8 col-lg-9">
                    <form>
                        <div class="row">
                            <div class="col-md-6">
                                <fieldset>
                                    <legend>Dados pessoais</legend>
                                    <div class="form-group">
                                        <label for="nome">Nome completo</label>
                                        <input type='text' required class="form-control" id="nome" name="nome" autofocus placeholder="Digite o seu nome">
                                    </div>
                                    <div class="form-group">
                                        <label for="email">E-mail</label>
                                        <div class="input-group">
                                            <span class="input-group-addon">@</span>
                                            <input type="email" class="form-control" id="email" name="email" placeholder="exemplo@exemplo.com">
                                        </div>
                                    </div>
                                    <div class="form-group">
                                        <label for="cpf">CPF</label>
                                        <input type='text' required class='form-control' id='cpf' name='cpf' placeholder="000.000.000-00">      
                                    </div>
                                    <div class="checkbox">
                                        <label for='span'><input type="checkbox" value="sim" name="spam" checked>
                                            Quero receber spam da Mirror Fashion</label>
                                    </div>
                                </fieldset>
                            </div>
                            <div class="col-md-6">
                                <fieldset>
                                    <legend>Cartão de crédito</legend>
                                    <div class="form-group">
                                        <label for="numero-cartao">Número - CVV</label>
                                        <input type="text" class="form-control"
                                            id="numero-cartao" name="numero-cartao">
                                    </div>
                                    <div class="form-group">
                                        <label for="bandeira-cartao">Bandeira</label>
                                        <select name="bandeira-cartao" id="bandeira-cartao"
                                            class="form-control">
                                            <option value="master">MasterCard</option>
                                            <option value="visa">VISA</option>
                                            <option value="amex">American Express</option>
                                        </select>
                                    </div>
                                    <div class="form-group">
                                        <label for="validade-cartao">Validade</label>
                                        <input type="month" class="form-control"
                                            id="validade-cartao" name="validade-cartao">
                                        </div>
                                </fieldset>
                            </div>
                        </div>
                        <button type="submit" class="btn btn-primary btn-lg pull-right">
                            <span class="glyphicon glyphicon-thumbs-up"></span>
                            Confirmar Pedido
                        </button>
                    </form>
                </div>
            </div>
        </div>
    </body>
    <script>
        document.querySelector('input[type=email]').oninvalid = function() {
        // remove mensagens de erro antigas
        this.setCustomValidity("");
        // reexecuta validação
        if (!this.validity.valid) {
        // se inválido, coloca mensagem de erro
            this.setCustomValidity("Email inválido");
            }
        };
    </script>    
    <script src="mirrorfashion/js/jquery.js"></script>
    <script src="mirrorfashion/js/bootstrap.js"></script>

</html>