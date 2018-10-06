function check(id) {
    var x = document.getElementById(id).value;
    var er_x = document.getElementById(`er_${id}`);
     if (x == null || x.length == 0) {
          er_x.classList.remove("o-0");
          return 0;
     }
     else if (!er_x.classList.contains("o-0")) // neu khong co thi them, co thi thoi
     {
          er_x.classList.add("o-0");
          return 1;
     }

}
function checkall() {
     if (check("Name") == check("Email") == check("Address") == check("Phone") == check("Password") == check("cpassword") == 1)
          return true;
     else {
          return false;
     }
}
// var pattern =/^([0-9]{2})\/([0-9]{2})\/([0-9]{4})$/;