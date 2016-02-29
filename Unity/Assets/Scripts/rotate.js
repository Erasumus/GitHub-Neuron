#pragma strict

var speed : int;
var lerpSpeed : float;
private var xDeg : float;
private var yDeg : float;
private var fromRotation : Quaternion;
private var toRotation : Quaternion;
 
function Update () {
 
    if(Input.GetMouseButton(0)) {
 
            xDeg -= Input.GetAxis("Mouse X") * speed;
            yDeg -= Input.GetAxis("Mouse Y") * speed;
            fromRotation = transform.rotation;
            toRotation = Quaternion.Euler(yDeg,xDeg,0);
        transform.rotation = Quaternion.Lerp(fromRotation,toRotation,Time.deltaTime * lerpSpeed);
        }
}