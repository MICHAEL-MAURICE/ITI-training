var svgNS = "http://www.w3.org/2000/svg";  
var shap=0
var b=false
var x1,y1,x2,y2
var arr=[]


circle_but.addEventListener("click", ()=>{
shap=1
});
Rec_but.addEventListener("click", ()=>{
    shap=2
    });


Line_but .addEventListener("click", ()=>{
        shap=3
        }); 
var svg =document.getElementById("mySVG")

svg.addEventListener("click",(e)=>{

  
    if(shap==1)
    createCircle(e.x,e.y)

    if(shap==2){
    criteRectangle(e.x,e.y)

}
    if(shap==3){
       
arr.push(e.x,e.y);
        if(arr.length>=4){createline(arr[0],arr[1],arr[2],arr[3])

            console.log(arr);
arr=[];
console.log(arr);

        }
    }

   

})



  function criteRectangle(x,y){

    var rect = document.createElementNS( svgNS,'rect' );
    rect.setAttributeNS( null,'x',x-100 );
    rect.setAttributeNS( null,'y',y-100 );
    rect.setAttributeNS( null,'width','100' );
    rect.setAttributeNS( null,'height','100' );
    rect.setAttributeNS( null,'fill','black' );
    document.getElementById( 'mySVG' ).appendChild( rect );

  }



  function createline(x1,y1,x2,y2){

var newLine = document.createElementNS(svgNS,'line');
newLine.setAttribute('id','line2');
newLine.setAttribute('x1',x1);
newLine.setAttribute('y1',y1);
newLine.setAttribute('x2',x2);
newLine.setAttribute('y2',y2);
newLine.setAttribute("stroke", "black")
document.getElementById( 'mySVG' ).appendChild( newLine );
  }

function createCircle( x,y)
{
    var myCircle = document.createElementNS(svgNS,"circle"); //to create a circle. for rectangle use "rectangle"
    myCircle.setAttributeNS(null,"id","mycircle");
    myCircle.setAttributeNS(null,"cx",x);
    myCircle.setAttributeNS(null,"cy",y);
    myCircle.setAttributeNS(null,"r",50);
    myCircle.setAttributeNS(null,"fill","black");
    myCircle.setAttributeNS(null,"stroke","none");

    document.getElementById("mySVG").appendChild(myCircle);
}     