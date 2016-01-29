import java.util.*;
public class EmployeeDriver {

	public static void main(String[] args) {
		Employee Bob, Juan, Mary;
		CommisionEmployee Sandy;
		Employee emp[] = new Employee[4];
		ArrayList<Employee> empList;
		
		empList = new ArrayList<Employee>();
		int count = 0;
		try{
			Sandy = new CommisionEmployee("Sandy", "Nepal",
					15.0f, 40, 1500.0f);
			empList.add(Sandy);
		}
		catch (OutOfRangeException e){
			System.out.println("Error in input" + e.toString());
		}
		try{
		Bob = new Employee();
		empList.add(Bob);
		Bob.setFirstname("Bob");
		Bob.setLastname("Miller");
		System.out.println(Bob);
		System.out.println(Employee.getEmployeeCount());
		}
		catch (OutOfRangeException e) {
			System.out.println("Error in input " + e.toString());
		}// end of try...catch block
		
		try{
			Juan = new Employee("Martinez","Juan", 20.0f,40);
			empList.add(Juan);
			System.out.println(Juan.toString());
			System.out.println(Employee.getEmployeeCount());
			}
			catch (OutOfRangeException e) {
				System.out.println("Error in input " + e.toString());
				try{
					System.out.println("Setting default hours " + e.toString());
					Juan = new Employee("Marinez","Juan",20.0f,e.getData1());
					System.out.println(Juan.toString());
					System.out.println(Employee.getEmployeeCount());
				}
				catch (OutOfRangeException e2) {
					System.out.println("Error in input " + e.toString());
				}
			}// end of try...catch block
			
			try{
				Mary = new Employee("James","Mary", 20.0f, 41);
				empList.add(Mary);
				System.out.println(Mary);
				System.out.println(Employee.getEmployeeCount());
				System.out.println(Mary.computePay());
				}
				catch (OutOfRangeException e) {
					System.out.println("Error in input " + e.toString());
				}// end of try...catch block
				
				for(int i = 0; i < empList.size(); i++)
					System.out.println(empList.get(i).toString() + " " +
							empList.get(i).computePay());
	}//end of main
}//end of employee driver
