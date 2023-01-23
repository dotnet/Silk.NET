var headrooms = document.querySelector(".headroom");
if (headrooms != null && headrooms.length > 0) {
    new Headroom(headrooms).init();
}

hljs.highlightAll();

function setTheme(theme) {
    localStorage.setItem('theme', theme);
    $("body").attr("class", "silk-" + theme);
}

$("#lighton").click(function() {
    setTheme("light");
});

$("#lightoff").click(function() {
    setTheme("dark");
});

(function () {
    if (localStorage.getItem("theme") === "dark") {
        setTheme("dark");
    } else if (localStorage.getItem("theme") === "light") {
        setTheme("light");
    } else if (window.matchMedia("(prefers-color-scheme: dark)").matches) {
        setTheme("dark");
    } else {
        setTheme("light");
    }
 })();