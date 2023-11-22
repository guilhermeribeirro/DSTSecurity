const elements = document.querySelectorAll('.scroll-reveal');

function revealOnScroll() {
    elements.forEach(element => {
        const elementTop = element.getBoundingClientRect().top;
        const windowHeight = window.innerHeight;

        if (elementTop < windowHeight) {
            element.classList.add('visible');
        }
    });
}

window.addEventListener('scroll', revealOnScroll);


document.addEventListener("DOMContentLoaded", function () {
    // Adicione interatividade ou anima��es aqui, por exemplo:
    const numerosSection = document.getElementById("visao");
    numerosSection.classList.add("wow");
});
