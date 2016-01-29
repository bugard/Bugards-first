//  constructors have same name as class,  methods have any name
public class Employee {
	private String firstname,lastname;
	private float payrate, totalpay;
	private int hours;
	private static int employeeCount = 0;
	public Employee(String firstname, String lastname, float payrate,
			int hours) throws OutOfRangeException {
		this.firstname = firstname;
		this.lastname = lastname;
		setPayrate(payrate);
		setHours(hours);
		employeeCount++;
	}//end of Employee overloaded constructor
	
	public Employee() throws OutOfRangeException { //default constructors have no parameters
		//must create a default constructor, if a subclass is created
		this("","",10.0f,40);
		employeeCount++;
	}//end of Employee constructor
	
	public String toString() {
		return "Employee [firstname=" + firstname + ", hours=" + hours
				+ ", lastname=" + lastname + ", payrate=" + payrate
				+ ", totalpay=" + totalpay + "]";
	}

	
	public String getFirstname() {
		return firstname;
	}

	public void setFirstname(String firstname) {
		this.firstname = firstname;
	}

	public String getLastname() {
		return lastname;
	}

	public void setLastname(String lastname) {
		this.lastname = lastname;
	}

	public float getPayrate() {
		return payrate;
	}

		
		
		public void setPayrate(float payrate) throws OutOfRangeException {
		if ((payrate >= 8.00f) && (payrate <= 50.00f)){
		this.payrate = payrate;
		}
		else{
			throw new OutOfRangeException("Invalid pay rate" + 
					" The payrate must be greater than or equal to 8.00 " +
					"or less than or equal to 50.0; default payrate available " +
					"getData2()",0,8.00f);
		}
	} // end of setPayrate

	public int getHours() {
		return hours;
	}

	public void setHours(int hours) throws OutOfRangeException {
		if((hours >= 10) && (hours <= 80)) {
			this.hours = hours;
		}
		else{
			throw new OutOfRangeException("Invalid hours" + 
					" The hours must be greater than or equal to 10.00 " +
					"or less than or equal to 80.0" + 
					"default hours available getData1()", 10,0.0f);
			
		}
	}//end of setHours

	public float getTotalpay() {
		return totalpay;
	}

	public static int getEmployeeCount() {
		return employeeCount;
	}
	
	public float computePay() {
		totalpay = payrate * hours;
		return (totalpay);
	}
	
}//end of Employee class
