
window.addEventListener("click", function(event) {// When the user clicks anywhere outside of the modal, close it
    var modal = document.getElementById("myModal");// Get the modal      
    
  if (event.target == modal) {
    modal.style.display = "none";
  }
})

// Testing
function Testing() {
  const modals = ['myModal','modalGastos'];

}


//Open modal sent by variable
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