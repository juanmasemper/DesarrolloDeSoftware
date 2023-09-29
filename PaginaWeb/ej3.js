
// JavaScript para mostrar una alerta al hacer clic en la imagen

function mostrarAlerta() {
    alert('¡Gracias por hacer click en la imagen! Ahora le debes una hamburguesa al creador de esta página xD');
}


// JavaScript para la funcionalidad de búsqueda

// Datos de ejemplo (reemplaza con tus propios datos)
const contenidoDelSitio = [
    "Hola"
];

function search() {
    const searchTerm = document.getElementById('searchInput').value.toLowerCase();
    const searchResults = document.getElementById('searchResults');
    searchResults.innerHTML = '';

    contenidoDelSitio.forEach((item, index) => {
        if (item.toLowerCase().includes(searchTerm)) {
            const resultItem = document.createElement('p');
            resultItem.textContent = `Resultado ${index + 1}: ${item}`;
            searchResults.appendChild(resultItem);
        }
    });
}
