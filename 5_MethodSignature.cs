	var(averageSalary, numberOfEmployee) = await SomeCalculation(0L, 10, 0L == 10L);
  
  //Method signature looks like below code - C#-7. Couldn't run since I don't have latest C# version installed.
  public async Task<(long averageSalary, long numberOfEmployee)> SomeCalculation(long salary, long numEmployee, bool isValueEqual)
        {
            var avgSalary = (salary == 0L) ? salary : salary / numEmployee;
            return (avgSalary, numEmployee);
        }
