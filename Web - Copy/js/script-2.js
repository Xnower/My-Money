function openModal() {
  // Get the modal
var modal = document.getElementById("myModal");

// Get the button that opens the modal
var btn = document.getElementById("myBtn");

// Get the <span> element that closes the modal
var span = document.getElementsByClassName("close")[0];

// Open the modal
modal.style.display = "block";
}

function closeModal() {
    // Get the modal
var modal = document.getElementById("myModal");

// Get the button that opens the modal
var btn = document.getElementById("myBtn");

// Get the <span> element that closes the modal
var span = document.getElementsByClassName("close")[0];

// Close the modal
modal.style.display = "none";
}


// When the user clicks anywhere outside of the modal, close it
window.addEventListener("click", function(event) {

   // Get the modal
   var modal = document.getElementById("myModal");

   // Get the button that opens the modal
   var btn = document.getElementById("myBtn");
   
   // Get the <span> element that closes the modal
   var span = document.getElementsByClassName("close")[0];


  if (event.target == modal) {
    modal.style.display = "none";
  }
})
