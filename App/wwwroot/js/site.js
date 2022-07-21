// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
var e = document.getElementById("some-id");
if (e !== null)
{
    var value = e.value;
    var e2 = document.getElementById("textarea1");
    e2.innerText = "abcde" + value;
}