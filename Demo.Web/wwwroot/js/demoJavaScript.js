function myFunction(msg) {
    let text;
    let person = prompt("Please enter your name:", "Harry Potter");
    if (person == null || person == "") {
        alert(msg);
    } else {
        alert("Hello " + person + "! How are you today? " + msg);
    }
    document.getElementById("demo").innerHTML = text;
}