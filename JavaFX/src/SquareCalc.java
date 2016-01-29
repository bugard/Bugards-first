//bugard liddell

import com.sun.xml.internal.ws.policy.privateutil.PolicyUtils.Text;
import javafx.event.*;
import javafx.application.Application;
import javafx.geometry.Pos;
import javafx.scene.Scene;
import javafx.scene.control.*;
import javafx.scene.layout.*;
import javafx.scene.paint.Color;
import javafx.scene.shape.Rectangle;
import javafx.stage.Stage;

public class SquareCalc extends Application {
	
	public static void main(String[] args) {
		Application.launch(args);
     	}
	
	public void start(Stage primaryStage) throws Exception{
		//CREATE FLOWPANE
		FlowPane pane1 = new FlowPane();
		pane1.setAlignment(Pos.TOP_CENTER);
		//ADD OBJECTS TO FLOWPANE
		Button btnOK = new Button("Compute Area");
		Button btnPerimeter = new Button("Compute Perimeter");
		Button btnCancel = new Button("Clear");
		
		pane1.getChildren().add(btnOK);
		pane1.getChildren().add(btnPerimeter);
		pane1.getChildren().add(btnCancel);
		
		FlowPane pane2 = new FlowPane();
		pane2.setAlignment(Pos.CENTER);
		Label lblMessage = new Label("Output here: ");
		TextField txtinput = new TextField();
		pane2.getChildren().add(txtinput);
		pane2.getChildren().add(lblMessage);
		
		FlowPane pane3 = new FlowPane();
		pane3.setAlignment(Pos.BOTTOM_CENTER);
		Rectangle rect1 = new Rectangle(0,0,0,0);
		rect1.setFill(Color.ORANGE);
		pane3.getChildren().add(rect1);
		
		BorderPane pane = new BorderPane();
		pane.setTop(pane1);
		pane.setCenter(pane2);
		pane.setBottom(pane3);
		
		ButtonHandlerClass handler1 = new ButtonHandlerClass(lblMessage,txtinput,
				btnOK,btnCancel,btnPerimeter, rect1);
		btnOK.setOnAction(handler1);
		btnCancel.setOnAction(handler1);
		btnPerimeter.setOnAction(handler1);
		
		Scene scene = new Scene(pane,300,200);
		primaryStage.setTitle("Process Data");
		primaryStage.setScene(scene);
		primaryStage.show();
		
	}

	class ButtonHandlerClass implements EventHandler<ActionEvent>{
		private Label label1;
		private TextField text1;
		private Button buttonCancel, buttonOK, buttonPerimeter;
		private Rectangle rect2;
		
		public ButtonHandlerClass(Label l1, TextField t1,Button b1, Button b2, Button b3,
				Rectangle r1){
			label1 = l1;
			text1 = t1;
			buttonOK = b1;
			buttonCancel = b2;
			buttonPerimeter = b3;
			rect2= r1;
		}
		
				public void handle(ActionEvent e) {
					if (e.getSource().equals(buttonCancel)){
						label1.setText("Output here: ");
						text1.setText("");
						rect2.setHeight(0);
						rect2.setWidth(0);
					}
					if (e.getSource().equals(buttonOK)){
						double side = Float.parseFloat(text1.getText());
						label1.setText("The area of the square is " + side*side);
						rect2.setHeight(side);
						rect2.setWidth(side);
					}
					if (e.getSource().equals(buttonPerimeter)){
						double side = Float.parseFloat(text1.getText());
						label1.setText("The perimeter of the square is " + side*4);
						rect2.setHeight(side);
						rect2.setWidth(side);
					}
				}// end of handle method
	}

}
