
// Función para mostrar una alerta al hacer clic en la imagen
document.getElementById("miImagen").addEventListener("click", function () {
    alert("Esta página no es oficial. Ingresa en https://www.mercadolibre.com.ar/");
});

// Importa la biblioteca anime.js

// Selecciona el elemento que deseas animar por su id
const miDiv = document.getElementById('miDiv');

// Define la animación utilizando anime.js
anime({
  targets: miDiv,
  translateY: 20, // Desplaza horizontalmente 250px
  backgroundColor: 'red', // Cambia el color de fondo a rojo
  duration: 3000, // Duración de la animación en milisegundos (3 segundos)
  easing: 'easeOutElastic', // Tipo de animación
});

anime({
    targets: miDiv2,
    translateY: 20, // Desplaza horizontalmente 250px
    backgroundColor: 'red', // Cambia el color de fondo a rojo
    duration: 3000, // Duración de la animación en milisegundos (3 segundos)
    easing: 'easeOutElastic', // Tipo de animación
  });


