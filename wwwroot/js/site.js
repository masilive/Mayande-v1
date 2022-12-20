// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
let timeout;
function useDebounce(func, wait) {
    clearTimeout(timeout);
    timeout = setTimeout(func, wait);
}

let chartHeight = 0;
const setChartDimensions = () => {
    if (document.getElementById('chart') == null) {
        return;
    }

    chartHeight = window.innerHeight - (document.getElementById('header').getBoundingClientRect().height + document.getElementById('footer').getBoundingClientRect().height);

    if (document.getElementById('chart').style.height !== chartHeight) {
        document.getElementById('chart').setAttribute('height', chartHeight);
    }
}

setChartDimensions();

window.onresize = () => {
    useDebounce(setChartDimensions, 750);
}