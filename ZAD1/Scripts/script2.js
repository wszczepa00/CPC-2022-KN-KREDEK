const counterElement = document.getElementById("counter");
const startBtnElement = document.getElementById("startBtn");

// Event Listener dla przycisku
startBtnElement.addEventListener("click", increase);

//ilosc klikniec
let temp = 0;

//czy pierwsze klikniecie
let firstClick = true;

//funkcja zwiekszajaca ilosc klikniec i ustawiajaca timeout
function increase() {
  if (firstClick) {
    setTimeout(endOfTime, 3000);
    firstClick = false;
    //zmiana napisu na przycisku
    startBtnElement.innerHTML = "Click!!!";
  }
  temp++;
  counterElement.innerHTML = temp;
}

//funkcja wykonujaca sie po upłynieciu czasu ustawionego w timeoutcie
function endOfTime() {
  //Sprawdzenie czy przycisk ok został wcisniety w alert boxie.
  if (!alert("End of time. Your result is: " + temp)) {
    temp = 0;
    counterElement.innerHTML = temp;
    //zmiana napisu na przycisku
    startBtnElement.innerHTML = "Start";
    firstClick = true;
  }
}
//funkcja wykonujaca sie po załadowaniu strony
function load() {
  counterElement.innerHTML = temp;
}
window.onload = load;
