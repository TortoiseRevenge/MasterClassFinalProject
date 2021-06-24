function showHide(id1) {
    var x = document.getElementById(id1);
    if (x.style.display !== "none") {
        x.style.display = "none";
    }
    else {
        x.style.display = "block";
    }
}