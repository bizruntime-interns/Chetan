var url="https://jsonplaceholder.typicode.com/posts/1";

var call=new XMLHttpRequest();
call.open("GET",url,true);
call.onreadystatechange=function()
{
    if(this.readyState==4 && this.status==200)
    {
        document.getElementById("print").innerHTML=this.responseText;
    }
}
call.send();