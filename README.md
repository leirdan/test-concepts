# CONCEITOS DE TESTES
Os testes são fundamentais ao criar aplicativos, tanto para agilizar o processo de verificar se as funcionalidades de um *software* são válidas quanto para prevenir, de imediato, *bugs* que são difíceis de se perceber manualmente, dentre outras razões.

## 1. O PROCESSO
* Basicamente, um teste envolve métodos que são executados no código e retornam algum valor, seja uma aprovação ou falha;
* A escrita de um teste é semelhante à de um método, que está dentro de uma classe própria de testes; a grande diferença é que eles não são executados junto da execução do aplicativo. Para executar um teste é necessário, por meio do *Gerenciador de Testes*, selecionar e executar os testes pretendidos.

## 2. PORQUE TESTAMOS
* A cada vez que um *software* é incrementado e cresce, pode ser difícil verificar manualmente todas as situações anteriores para um método e validar se elas continuam funcionando. Com os testes, é possível, com um único clique, validar não só as novas alterações mas também as anteriores; detectar *bugs* no início do desenvolvimento economiza tempo.
* Em casos onde há métodos "enormes" que envolvem várias etapas, os testes podem ajudá-lo a modularizar cada método e tornar a legibilidade do código melhor, dentre outros efeitos.

## 3. TIPOS DE TESTE E A "PIRÂMIDE"
Os testes podem ser organizados em uma pirâmide, onde cada nível é um tipo de teste diferente. Saindo da base ao topo, temos os testes:
* **de Unidade**: tipo mais básico de teste. Seu escopo costuma ser de um método ou a menor unidade testável; é comum que existam diversos testes para um único caso justamente pela facilidade em escrevê-los;
* **de Integração**: testes que envolvem mais de um método e comportamento, logo, são mais complexos de se escrever;
* **de Desempenho**: têm por objetivo capturar o tempo de execução de uma parte do aplicativo para detectar e resolver problemas de lentidão;
* **de Carga**: têm por objetivo "estressar" o aplicativo (por ex., imaginar que existem 10 mil usuários simultâneos o utilizando) para detectar comportamentos e lentidões;
* **de Aceitação**: servem para estruturar e validar regras de negócio; assim, esses testes só serão aprovados quando o aplicativo cumprir todas as regras definidas;
* **de UI**: o tipo de teste mais alto na pirâmide, envolve as interações de um usuário com a interface do aplicativo e tem por objetivo validar se o aplicativo responde corretamente à interação. Pode ser feito de forma automatizada ou manual, cada um com suas vantagens e desvantagens. 

## 4. ESCOLAS DE PENSAMENTOS DE TESTES
O mundo e a implementação dos testes é algo extremamente variado. Como consequência disso, existem diversas diretrizes diferentes que testadores podem seguir no caminho do desenvolvimento de um *software*. Vejamos abaixo alguns exemplos famosos:
1. **Desenvolvimento Orientado por Testes (TDD)**: neste método, resumidamente, os desenvolvedores começam primeiro pelos testes (que falham) e, em seguida, pelo código do método que estão testando (que podem ser aprovados ou não no teste). Isso parece estranho, mas tal padrão pode ajudar na construção de uma arquitetura melhor para o projeto, além de só conter código que realmente será utilizado.
> Existe um tipo de TDD que é chamado "Red/Green/Refactor". Consiste em escrever um teste que falha (Red), escrever o código no método necessário para o teste aprová-lo (Green) e, por fim, reescrever o código do método para torná-lo eficiente (Refactor).

2. **Desenvolvimento Orientado por Comportamento**: semelhante ao modelo TDD, mas com maior ênfase em testes de aceitação e utiliza-se de bastante documentação dos métodos (utilizando comentários, por exemplo).
