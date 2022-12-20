// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function debounce(func, wait) {
    let timeout;
    return function (...args) {
        clearTimeout(timeout);
        timeout = setTimeout(() => func.apply(this, args), wait);
    };
}

let chartHeight = '0';
const setChartDimensions = debounce(() => {
    chartHeight = window.innerHeight - (document.getElementById('header').getBoundingClientRect().height + document.getElementById('footer').getBoundingClientRect().height);

    if (document.getElementById('chart').style.height !== chartHeight) {
        document.getElementById('chart').setAttribute('height', chartHeight);
    }
}, 750);

window.onresize = () => {
    setChartDimensions();
}
window.onload = () => {
    setChartDimensions();
}