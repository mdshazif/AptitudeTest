class MathClass
{
		//@subtract(1) 
		//@multiply(2) 
		addOne(number: number) 
		{ 
			return number + 1; 
		} 
		multiplyTwo(number: number) 
		{ 
			number = this.addOne(number); 
			return number*2; 
		} 
		subtractOne(number: number) 
		{ 
			number = this.multiplyTwo(number); 
			return number-1; 
		} 
}

console.log(new MathClass().subtractOne(2)); //should print 5
