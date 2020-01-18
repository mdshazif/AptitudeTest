
//Type1
import {Car} from "app.js";
//Answer 1:
export function Car()
{ 
	return "lamborghini"; 
}

//Type2
import Car from "app.js";
//Answer 2:
export default function Car()
{ 
  return "lamborghini"; 
}
