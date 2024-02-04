function StartCarousel(carouselId) {
    const myCarouselElement = document.querySelector(carouselId);

    // Set a variable to control the carousel
    const carousel = new bootstrap.Carousel(myCarouselElement, {
        interval: 2000,
        touch: false
    });

    // Pause the carousel on mouseenter
    myCarouselElement.addEventListener('mouseenter', function () {
        carousel.pause();
    });

    // Resume the carousel on mouseleave
    myCarouselElement.addEventListener('mouseleave', function () {
        carousel.cycle();
    });
}
