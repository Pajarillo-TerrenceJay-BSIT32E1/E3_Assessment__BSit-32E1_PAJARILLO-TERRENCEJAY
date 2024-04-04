function isEvenOrOdd(num) {
    if (num % 2 === 0) {
      return "even";
    } else {
      return "odd";
    }
  }

  document.getElementById("checkButton").addEventListener("click", function() {
    var num = prompt("Enter a number:");
    var result = isEvenOrOdd(num);
    document.getElementById("result").innerText = "The number is " + result;
  });