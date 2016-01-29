
public class OutOfRangeException extends Exception {
	private String messageString;
	private int data1;
	private float data2;
	
	public OutOfRangeException(String input, int d1, float d2) {
		super(); //call the default constructor for the parent class
		messageString = input;
		data1 = d1;
		data2 = d2;
	}
	
	public int getData1() {
		return data1;
	}

	public float getData2() {
		return data2;
	}

	public String getMessageString() {
		return messageString;
	}
	
	public String toString() {
		return "OutOfRangeException [messageString=" + messageString + "]";
	}
	
}// end of OutOfRangeException
