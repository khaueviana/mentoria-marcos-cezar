        <?php
            $cabecalho_title = "Produto da Mirror Fashion";
            $cabecalho_css = '<link rel="stylesheet" href="css/produto.css">';
            include("cabecalho.php");
        ?>
    <div class="produto-back">
        <div class="container">
                <div class="produto">
                <h1>Fuzzy Cardigan</h1>
                <p>por apenas R$ 129,00</p>

                <form action="checkout.php" method="POST">
                    <input type="hidden" name="nome" value="Fuzzy Cardigan">
                    <input type="hidden" name="preco" value="129,00">
                    <input type="hidden" name="ida" value="2">
                    <fieldset class="cores">
                        <legend>Escsolha sua cor</legend>
                        <input type="radio" name="cor" value="verde" id="verde" checked>
                        <label for="verde">
                            <img src="mirrorfashion\img\produtos\foto2-verde.png" alt="Produto na cor verde">
                        </label>

                        <input type="radio" name="cor" value="rosa" id="rosa">
                        <label for="rosa">
                            <img src="mirrorfashion\img\produtos\foto2-rosa.png" alt="Produto na cor rosa">
                        </label>

                        <input type="radio" name="cor" value="azul" id="azul">
                        <label for="azul">
                            <img src="mirrorfashion\img\produtos\foto2-azul.png" alt="Produto na cor azul">
                        </label>
                    </fieldset>
                    <fieldset class="tamanhos">
                        <legend>Escolha o tamanho:</legend>
                        <input type="range" min="36" max="46" value="42" step="2"
                        name="tamanho" id="tamanho">
                        <output for="tamanho" name="valortamanho">42</output>
                    </fieldset>
                    <input type="submit" class="comprar" value="Comprar" id="2">
                </form>    
            </div>
            <div class="detalhes">
                <h2>Detalhes do protudo</h2>
                <p>Esse é o melhor casaco de Cardigã que você já viu. Excelente material italiano com estampa desenhada pelos artesãos da comunidade de Krotor nas ilhas gregas. Compre já e receba hoje mesmo pela nossa entrega a jato.<p>
                <table>
                    <thead>
                        <tr>
                            <th>Característica</th>
                            <th>Detalhe</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td>Modelo</td>
                            <td>Cardigã 7845</td>
                        </tr>
                        <tr>
                            <td>Material</td>
                            <td>Algodão e poliester</td>
                        </tr>
                        <tr>
                            <td>Cores</td>
                            <td>Azul, Rosa e Verde</td>
                        </tr>
                        <tr>
                            <td>Lavagem</td>
                            <td>Lavar a mão</td>
                        </tr>
                    </tbody>
                </table>
            </div>
        </div>
    </div>
    

        <?php 
            include("rodape.php");
        ?>
   <script src="mirrorfashion/js/jquery.js"></script>
    <script src="js/produto.js"></script>
    </body>
    
</html>