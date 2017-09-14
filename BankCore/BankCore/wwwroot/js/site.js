// Write your Javascript code.

// Credit to xims
// https://stackoverflow.com/questions/3108986/gaussian-bankers-rounding-in-javascript
function bankers_round(n, d) {
    var x = n * Math.pow(10, d);
    var r = Math.round(x);
    var br = (((((x > 0) ? x : (-x)) % 1) === 0.5) ? (((0 === (r % 2))) ? r : (r - 1)) : r);
    return br / Math.pow(10, d);
}