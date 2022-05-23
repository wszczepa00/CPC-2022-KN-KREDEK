const drawBtnElement = document.getElementById("draw-btn");
const stopBtnElement = document.getElementById("stop-btn");
const secondsElement = document.getElementById("seconds");
const colorElement = document.getElementById("color");
const bodyElement = document.getElementById("body");
const colorBoxElement = document.getElementById("colorBox");

// Event Listenery dla przyciskow obslugujacych losowanie
drawBtnElement.addEventListener("click", draw);
stopBtnElement.addEventListener("click", stop);

//zmienna przechowujaca upłyniety czas
let time = 0;

// zmienna mówiaca o tym czy mozna losowac
let canDraw = true;

//zmienne do losowania koloru
var r, g, b;

//zmienne do interwałów
var intervalID;
var colorIntervalID;

//funkcja obsługująca losowania
function draw() {
  //Sprawdzenie czy mozna losowac
  if (canDraw) {
    //ustawienie interwalów
    intervalID = setInterval(myTimer, 1000);
    colorIntervalID = setInterval(colorTimer, 200);
    canDraw = false;
  }
}

//funkcja przerywajaca losowanie
function stop() {
  secondsElement.innerHTML = 0;
  time = 0;
  //wyczyszczenie interwałów
  clearInterval(intervalID);
  clearInterval(colorIntervalID);

  //zmiana koloru dla tagu body
  bodyElement.setAttribute("style", "background-color: rgb(171, 206, 221);");

  //zmiana koloru w boxie 
  colorBox.setAttribute(
    "style",
    "background-color: rgb(" + r + "," + g + "," + b + ")"
  );
  canDraw = true;
}

//funkcja uzyta do odmierzenia czasu w interwale
function myTimer() {
  secondsElement.innerHTML = time++;
}

//funkcja uzyta w interwale, losujaca kolory i zmieniajaca background-color w body 
function colorTimer() {
  r = Math.floor(Math.random() * (257 - 0)) + 0;
  g = Math.floor(Math.random() * (257 - 0)) + 0;
  b = Math.floor(Math.random() * (257 - 0)) + 0;

  bodyElement.setAttribute(
    "style",
    "background-color: rgb(" + r + "," + g + "," + b + ")"
  );
}

//funkcja wykonujaca sie po załadowaniu strony
function load() {
  secondsElement.innerHTML = time;
}
window.onload = load;
