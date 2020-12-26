

window.addEventListener("click", function(event) {// When the user clicks anywhere outside of the modal, close it
  var modal = document.getElementById("myModal");// Get the modal
  var btn = document.getElementById("myBtn");// Get the button that opens the modal
  var span = document.getElementsByClassName("close")[0];// Get the <span> element that closes the modal

  if (event.target == modal) {
    modal.style.display = "none";
  }
})


function openModal(ModalID) { //Open modal sent by variable
  var modal = document.getElementById(ModalID); // Get the modal
  modal.style.display = "block";// Open the modal
}

//Close modal sent by variable
function closeModal(ModalID) {
  var modal = document.getElementById(ModalID); // Get the modal
  modal.style.display = "none";// Close the modal
}

//Only allow numbers and decimals
function isNumberKey(evt)
       {
          var charCode = (evt.which) ? evt.which : evt.keyCode;
          if (charCode != 46 && charCode > 31 
            && (charCode < 48 || charCode > 57))
             return false;

          return true;
       }