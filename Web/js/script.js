function openModal() {
  var modal = document.getElementById("myModal"); // Get the modal
  var btn = document.getElementById("myBtn");// Get the button that opens the modal
  var span = document.getElementsByClassName("close")[0];// Get the <span> element that closes the modal
  modal.style.display = "block";// Open the modal
}

function closeModal() {
  var modal = document.getElementById("myModal");// Get the modal
  var btn = document.getElementById("myBtn");// Get the button that opens the modal
  var span = document.getElementsByClassName("close")[0];// Get the <span> element that closes the modal
  modal.style.display = "none";// Close the modal
}

window.addEventListener("click", function(event) {// When the user clicks anywhere outside of the modal, close it
  var modal = document.getElementById("myModal");// Get the modal
  var btn = document.getElementById("myBtn");// Get the button that opens the modal
  var span = document.getElementsByClassName("close")[0];// Get the <span> element that closes the modal

  if (event.target == modal) {
    modal.style.display = "none";
  }
})
