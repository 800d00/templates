var invocation = new XMLHttpRequest();
var url = 'http://localhost';

function callOtherDomain() {
    if (invocation) {
        invocation.open('GET', url, true);
        invocation.onreadystatechange = handler;
        invocation.send();
    }
}