//variáveis da bolinha
let xBolinha = 300;
let yBolinha = 200;
let diametro = 20;
let raio = diametro / 2 ;

//velocidade da bolinha
let velocidadeXBolinha = 8;
let velocidadeYBolinha = 8;

//variáveis da raquete
let xRaquete = 5;
let yRaquete = 150;
let raqueteComprimento = 15;
let raqueteAltura = 90;

//variáveis do oponente
let xRaqueteOponente = 580;
let yRaqueteOponente = 150;
let raqueteComprimentoOponente = 15;
let raqueteAlturaOponente = 90;

//chanceDeErrar
let chanceDeErrar = 0;

let colidiu = false

//placar do jogo
let meusPontos = 0;
let pontosDoOponente = 0

//sons do jogo
let raquetada;
let ponto;
let trilha;

function preload(){
  trilha = loadSound("trilha.mp3");
  ponto = loadSound("ponto.mp3");
  raquetada = loadSound("raquetada.mp3");
}

function setup() {
  createCanvas(600, 400);
  trilha.loop();
}

function draw() {
  background(0);
  mostraBolinha();
  movimentaBolinha();
  verificaColisaoBorda();
  mostraRaquete();
  movimentaRaquete();
  //colisaoRaquete();
  colisaoRaqueteBiblioteca();
  mostraRaqueteOponente();
  movimentaRaqueteOponente();
  colisaoRaqueteOponente();
  incluiPlacar();
  marcaPonto();
  movimentaRaqueteOponenteMulti();
}

function mostraBolinha(){
  circle(xBolinha, yBolinha, diametro);
}

function movimentaBolinha(){
  xBolinha += velocidadeXBolinha;
  yBolinha += velocidadeYBolinha;
}

function verificaColisaoBorda(){
   if (xBolinha + raio > width ||
     xBolinha - raio < 0 ){
    velocidadeXBolinha *= -1;
  }
  if (yBolinha + raio > height ||
     yBolinha - raio < 0){
    velocidadeYBolinha *= -1
  }
}

function mostraRaquete(){
  rect(xRaquete, yRaquete, raqueteComprimento, raqueteAltura);
}


function mostraRaqueteOponente(){
  rect(xRaqueteOponente, yRaqueteOponente, raqueteComprimentoOponente, raqueteAlturaOponente);
}


function movimentaRaqueteOponenteMulti(){
  if (keyIsDown(87)){
    yRaquete -= 10;
  }
  if (keyIsDown(83)){
    yRaquete += 10;
  }
}

function movimentaRaquete(){
  if (keyIsDown(UP_ARROW)){
    yRaqueteOponente -= 10;
  }
  if (keyIsDown(DOWN_ARROW)){
    yRaqueteOponente += 10;
  }
}

function colisaoRaquete(){
  if (xBolinha - raio < xRaquete + raqueteComprimento && yBolinha - raio < yRaquete + raqueteAltura && yBolinha +raio > yRaquete){
      velocidadeXBolinha *= -1;
    raquetada.play();
    }
}

function colisaoRaqueteBiblioteca() {
  colidiu = collideRectCircle(xRaquete, yRaquete, raqueteComprimento, raqueteAltura, xBolinha, yBolinha, raio);
  if(colidiu) {
    velocidadeXBolinha *= -1;
    raquetada.play();
  }
}

function movimentaRaqueteOponente() {
    velocidadeYOponente = yBolinha - yRaqueteOponente - raqueteComprimentoOponente / 2 - 30;
    yRaqueteOponente += velocidadeYOponente
  calculaChanceDeErrar()
}

function colisaoRaqueteOponente(x, y) {
    colidiu = collideRectCircle(xRaqueteOponente, yRaqueteOponente, raqueteComprimentoOponente, raqueteAlturaOponente, xBolinha, yBolinha, raio);
    if (colidiu){
        velocidadeXBolinha *= -1;
    }
}

function incluiPlacar(){
  stroke(300);
  textAlign(CENTER);
  textSize(16);
  fill(color(255, 150, 0));
  rect(150, 10, 40, 20);
  fill(255);
  text(meusPontos, 170, 26);
  fill(color(255, 150, 0));
  rect(450, 10, 40, 20);
  fill(255);
  text(pontosDoOponente, 470, 26);
}

function marcaPonto(){
   if (xBolinha > 590) {
    meusPontos += 1;
     ponto.play();
  }
  if (xBolinha < 10) {
    pontosDoOponente += 1;
    ponto.play();
  }
}

function calculaChanceDeErrar() {
  if (pontosDoOponente >= meusPontos) {
    chanceDeErrar += 1
    if (chanceDeErrar >= 39){
    chanceDeErrar = 40
    }
  } else {
    chanceDeErrar -= 1
    if (chanceDeErrar <= 35){
    chanceDeErrar = 35
    }
  }
}
