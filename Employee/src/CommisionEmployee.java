
public class CommisionEmployee extends 
Employee{
		private float sales;
		
		public CommisionEmployee(String firstname, String lastname, float payrate,
			int hours, float sales) throws OutOfRangeException {
		super(firstname, lastname, payrate, hours);
		this.sales = sales;
		}

	public CommisionEmployee() throws OutOfRangeException {
		super();
		this.sales = 0.0f;
	}//end of default constructor
	
	public float computePay() {
		float totalpay;
		totalpay = super.computePay() + 0.05f*sales;
		return totalpay;
	}//end of overridden computePay
}//end of CommissionEmployee
