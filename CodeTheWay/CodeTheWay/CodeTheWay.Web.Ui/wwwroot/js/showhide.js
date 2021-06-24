function showHide(id1) {
    var x = document.getElementById(id1);
    if (x.style.display !== "none") {
        x.style.display = "none";
    }
    else {
        x.style.display = "block";
    }
}

function showHideClass(id1) {
    var x = document.getElementsByClassName(id1);
    for (let i = 0; i < x.length; i++) { 
    if (x[i].style.display !== "none") {
        x[i].style.display = "none";
    }
    else {
        x[i].style.display = "block";
    }
    }
}
