// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function debounce(func, wait) {
    let timeout;
    return function (...args) {
        clearTimeout(timeout);
        timeout = setTimeout(() => func?.apply(this, args), wait);
    };
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

const debouncedSetChartDimensions = debounce(setChartDimensions(), 750);

window.onresize = () => {
    debouncedSetChartDimensions();
}