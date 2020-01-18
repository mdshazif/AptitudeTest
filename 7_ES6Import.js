
//Type1
import {Car} from "app.js";
//Answer 1:
//app.js
export function Car()
{ 
	return "lamborghini"; 
}

//Type2
import Car from "app.js";
//Answer 2:
//app.js
export default function Car()
{ 
  return "lamborghini"; 
}
