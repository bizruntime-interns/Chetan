var pCount=1;
var btn=document.getElementById("btn");
var animalContainer=document.getElementById("animal-info");

btn.addEventListener("click",function()
{
    var ourRequest=new XMLHttpRequest();
    ourRequest.open('GET','https://learnwebcode.github.io/json-example/animals-' + pCount + '.json');
    ourRequest.onload=function(){
        var ourData=JSON.parse(ourRequest.responseText);
        renderHTML(ourData);
        //console.log(ourData[0]);
    };
    ourRequest.send(); 
    pCount++;
});

function renderHTML(Data)
{
    var htmlString="";
    for(i=0;i<Data.length;i++)
    {
        htmlString+="<p>" + Data[i].name + " is a " + Data[i].species + "thats likes to";
        
        for(j=0;j<Data[i].foods.likes.length;j++)
        {
            if(j==0)
            {
                htmlString+=Data[i].foods.likes[j];
            }
            else{
                htmlString+= ' and ' + Data[i].foods.likes[j];
            }
        }

        htmlString+=', dislikes ';
        for(j=0;j<Data[i].foods.dislikes.length;j++)
        {
            if(j==0)
            {
                htmlString+=Data[i].foods.dislikes[j];
            }
            else{
                htmlString+= ' and ' + Data[i].foods.dislikes[j];
            }
        }
        htmlString+='.<p>';
    }
    animalContainer.insertAdjacentHTML('beforeend', htmlString);
}