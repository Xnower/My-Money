//Globarl variables
var iM = 0; // Get ingresos menusales
var gB = 0; // Get gastos básicos
var aM = 0; // Get ahorros mensuales
var gP = 0; // Get gastos personales
var tG = 0; // Get total gastos

window.addEventListener("click", function(event) {// When the user clicks anywhere outside of the modal, close it

  var miArray = ['myModal', 'modalGastos', 'modalResutado'];

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

vCloseModal.style.display = "none";
vOpenModal.style.display = "block";
}



//Open modal sent by variable
function openModal(ModalID) { //Open modal sent by variable
  var modal = document.getElementById(ModalID); // Get the modal
  modal.style.display = "block";// Open the modal
  return true;
}

//Close modal sent by variable
function closeModal(ModalID) {
  var modal = document.getElementById(ModalID); // Get the modal
  modal.style.display = "none";// Close the modal
  return true;
}

//Matching function
function match() {
  iM = document.getElementById("ingresosMensuales").value; // Get ingresos mensuales
  gB = document.getElementById("gastosBasicos").value; // Get gastos básicos
  aM = document.getElementById("ahorrosMensuales").value; // Get ahorros mensuales
  gP = document.getElementById("gastosPersonales").value; // Get gastos personales

  tG = parseFloat(gB)+parseFloat(aM)+parseFloat(gP); // get total gastos

  if (iM == tG) {
    alert("Same")
    return false;
  } else {

    if (confirm('Are you sure you want to save this thing into the database?')) {
      // Save it!
      console.log('Thing was saved to the database.');
    } else {
      // Do nothing!
      console.log('Thing was not saved to the database.');
    }
    
  return false;
  }
      
  window.confirm("Testing")
    document.getElementById("myText").value = "Johnny Bravo";
 



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