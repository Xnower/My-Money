
window.addEventListener("click", function(event) {// When the user clicks anywhere outside of the modal, close it

  var miArray = ['myModal', 'modalGastos'];

  miArray.forEach( function(valor, indice, array) { // For que recorre cada modal en miArray

      var modal = document.getElementById(valor); // Get the current modal
      // console.log("Estos son los modals " + valor)

      if (modal.style.display === "block") { // si el current modal es igual a Block
        var modalOpen = document.getElementById(valor); // Almacenar modal abierto en una variable

        if (event.target == modalOpen) { // heck when the user clicks anywhere outside of the modal, close it
          modalOpen.style.display = "none";
        }
      }
  });
})

function test(varia){
  console.log(varia)
}

// Open and close modal sent by variables
function openAndcloseModal(openModal,closeModal){
var vOpenModal = document.getElementById(openModal);
var vCloseModal = document.getElementById(closeModal);

vOpenModal.style.display = "block";
vCloseModal.style.display = "none";
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