//Globarl variables
var iM = 0; // Get ingresos menusales
var gB = 0; // Get gastos básicos
var aM = 0; // Get ahorros mensuales
var gP = 0; // Get gastos personales
var tG = 0; // Get total gastos

// Porcentajes
var gBP = 0; // Get gastos básicos porcentaje
var aMP = 0; // Get ahorros mensuales porcentaje
var gPP = 0; // Get gastos personales porcentaje

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
    getUserType();
    openAndcloseModal("modalResutado","modalGastos")
    return false;
  } else {

    /*
    if (confirm('Los valores ingresados no suman la cantidad de sus ingresos. ¿Desea continuar?')) {
      openAndcloseModal("modalResutado","modalGastos")
      // Save it!
      console.log('Thing was saved to the database.');
    } else {
      // Do nothing!
      console.log('Thing was not saved to the database.');
    }
    */
      alert("Los valores ingresados no suman la misma cantidad de sus ingresos.")
      return false;
  }

}

// getUserType function
// Cantidad a sacar porcentaje por el total dividido 100
// Gastos básicos 50% - Ahorros 20% - Gastos Personales 30%
function getUserType(){

  gBP = 50 * parseFloat(iM) / 100 // Get gastos básicos porcentaje
  aMP = 20 * parseFloat(iM) / 100 // Get ahorros mensuales porcentaje
  gPP = 30 * parseFloat(iM) / 100 // Get gastos personales porcentaje

  if (gB > gBP) {
    document.getElementById("texto").innerHTML = "- Tal vez tienes más obligaciones de las que deberías tener.";
    // alert("Tal vez tienes más obligaciones de las que deberías tener.")
    return false;
  }
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