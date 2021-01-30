//Globarl variables
var iM = 0; // Get ingresos menusales
var gB = 0; // Get gastos básicos
var aM = 0; // Get ahorros mensuales
var gP = 0; // Get gastos personales
var tG = 0; // Get total gastos
var points = 0; // Get total points

// Porcentajes
var gBP = 0; // Get gastos básicos porcentaje
var aMP = 0; // Get ahorros mensuales porcentaje
var gPP = 0; // Get gastos personales porcentaje

/*
window.addEventListener("click", function(event) {// When the user clicks anywhere outside of the modal, close it

  var miArray = ['myModal', 'modalGastos', 'modalResutado', 'saberMas'];

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
*/

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

    if (confirm('Los valores ingresados no suman la cantidad de sus ingresos. ¿Desea continuar?')) {
      getUserType();
      openAndcloseModal("modalResutado","modalGastos")
      return false;
    } else {
      // Cancel Pressed!
    }
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

console.log(gBP + " " + aMP + " " + gPP)

  if (gB > gBP) {
    document.getElementById("result_1").innerHTML = "- Tus gastos básicos superan el 50% de tus ingresos, tal vez tienes más obligaciones de las que deberías tener, analizar tu obligaciones y minimizarlas, puede ayudarte.";
  }

  if (gB <= gBP) {
    document.getElementById("result_1").innerHTML = "- Tus gastos básicos están por debajo del 50% de tus ingresos. Tienes un buen balance en relación con tus gastos básicos y tus ingresos mensuales.";
    points = points + 1
  }

  if (aM < aMP) {
    document.getElementById("result_2").innerHTML = "- Tus ahorros están por debajo del 20% de tus ingresos, puedes estar gastando más de lo que deberías. Ahorrar te puede ayudar en situaciones difíciles.";
    }

  if (aM >= aMP) {
    document.getElementById("result_2").innerHTML = "- Tus ahorros superan el 20% de tus ingresos. Asegurate de encontrar dónde invertir parte de ellos, para generar una mayor rentabilidad.";
    points = points + 1 
  }

  if (gP > gPP) {
    document.getElementById("result_3").innerHTML = "- Tus gastos personales superan el 30% de tus ingresos, debes moderar moderada tus gastos personales, comer más seguido en casa y reducir tus compras puede ayudarte.";
  }

  if (gP <= gPP) {
    document.getElementById("result_3").innerHTML = "- Tus gastos personales están por debajo del 30% de tus ingresos. Recuerda encontrar un balance en tu vida social, salir de vez en cuando no está mal, pero exceder puede causarte problemas. ¡Sigue así!";
    points = points + 1
  }

  points = parseFloat(points);

  if (points <= 0) {
    document.getElementById("result_points").innerHTML = "Aún hay mucho que puedes mejorar, controlar tus finanzas te impulsará a lograr tus objetivos financieros. ¡No te rindas, nosotros te ayudamos!";
  }

  if (points == 2) {
    document.getElementById("result_points").innerHTML = "¡Felicidades has conseguido un puntaje superior al del 60% de la gente que toma esta evaluación!";
  }

  if (points == 3) {
    document.getElementById("result_points").innerHTML = "¡Felicidades has conseguido un puntaje superior al del 60% de la gente que toma esta evaluación! Tal vez estás listo/a para empezar a invertir tus ahorros y evitar que pierdan valor, debido a la inflación.";
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