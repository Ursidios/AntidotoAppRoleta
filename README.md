# AntidotoAppRoleta

Ideia e funcionamento do jogo:
  Decidi Criar um Aplicativo de roleta mesclando com o famoso jogo de cartas 21, herdando assim parte de suas regras e às adequando ao sistema de jogo. Ao apertar em começar, a roleta aparece e números inseridos
em suas fatias começão a mudar rapidamente de forma aleatória e juntamente com um texto informativo, chamam a atenção do jogador para clicar na roleta, fazendo isso ela gira em uma força aleatória, travando os 
números que antes estavam mudando, for fim a roleta para em alguma posição, e a de acordo com a fatia selecionada é somado na pontuação total do jogador, o valor da mesma. 
  Com a condição de a pontuação total do jogador não seja igual a 0, o jogador pode optar por finalizar suas jogadas, assim podendo ter 3 tipos de premiação, com base na proximidade do número 21, sendo 19 a 
premiação mais baixa, 20 a intermediária e 21 o prêmio máximo. Mas se ao finalizar com menos de 19, ou a soma total de pontos passar de 21 é declarada a derrota, assim não premiando de nenhuma forma

Decisões de desenvolvimento:
1. Decidi por usar o URP2D juntamente com sua extensão ShaderGraph para criar um material que recebe um gradiente customizável, para facilitar possíveis alterações sem que seja necessário o desenvolvimento de outra
imagem feita externamente
2. Optei por usar as fisicas 2D de RigidBody na roleta para uma melhor fluidez e deixar o movimento mais fiél e fácil de customizár

Possiveis melhorias: 
1. Uma das possíveis melhorias quanto ao projeto seria a implementação de um pop-up, que aparece após o botão de finalizar ser apertado, perguntando ao jogador se ele realmente quer executar tal ação.
2. Futuramente a possivel implementação de um bot para jogar contra o jogador assim trazendo mais desafios e dinamica ao jogo.
3. Um sitema de moedas que ao vencer o jogador recebe, dependendo do tipo de vitória, uma quantidade de moedas que podem ser usadas para mudar a aparencia da roleta, ou de algum outro possível cosmético.
