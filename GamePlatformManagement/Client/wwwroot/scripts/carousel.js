function StartCarousel(carouselId) {
    const myCarouselElement = document.querySelector(carouselId)

    const carousel = new bootstrap.Carousel(myCarouselElement, {
        interval: 2000,
        touch: false
    })
}