import javafx.animation.*;
import javafx.application.Application;
import javafx.event.EventHandler;
import javafx.scene.Scene;
import javafx.scene.input.MouseEvent;
import javafx.scene.layout.Pane;
import javafx.scene.paint.Color;
import javafx.scene.shape.Circle;
import javafx.scene.shape.Ellipse;
import javafx.scene.shape.Line;
import javafx.scene.shape.Rectangle;
import javafx.stage.Stage;
import javafx.util.Duration;

public class AnimationFun extends Application {
	public void start(Stage primaryStage) throws Exception{
		Pane pane = new Pane();
		Circle theCircle = new Circle(24);
		pane.getChildren().add(theCircle);
		theCircle.setFill(Color.ORCHID);
		PathTransition pt = new PathTransition(Duration.millis(1000),
				new Line(10,10,240,190),theCircle);
		pt.setCycleCount(Timeline.INDEFINITE);
		pt.setAutoReverse(true);
		pt.play();
		
		Rectangle rect1 = new Rectangle(0,0,25,50);
		rect1.setFill(Color.ORANGE);
		Circle circle2 = new Circle(125,100,50);
		circle2.setFill(Color.YELLOW);
		circle2.setStroke(Color.BLACK);
		pane.getChildren().add(circle2);
		pane.getChildren().add(rect1);
		final PathTransition pt2 = new PathTransition();
		pt2.setDuration(Duration.millis(4000));
		pt2.setPath(circle2); //path of object
		pt2.setNode(rect1); // object that moves
		pt2.setOrientation(PathTransition.OrientationType.ORTHOGONAL_TO_TANGENT);
		pt2.setCycleCount(Timeline.INDEFINITE);
		pt2.setAutoReverse(true);
		pt2.play();
		
		Ellipse ellipse = new Ellipse(200,150,30,30);
		ellipse.setFill(Color.BLUEVIOLET);
		pane.getChildren().add(ellipse);
		FadeTransition ft = new FadeTransition(Duration.millis(1000), ellipse);
		ft.setFromValue(1.0);
		ft.setToValue(0.1);
		ft.setCycleCount(Timeline.INDEFINITE);
		ft.setAutoReverse(true); //true, fade in and out
		ft.play();
		
		circle2.setOnMousePressed(new EventHandler<MouseEvent>(){
			public void handle(MouseEvent arg0){
				pt2.pause();
			}
		}
		);
		
		circle2.setOnMouseReleased(new EventHandler<MouseEvent>(){
			public void handle(MouseEvent arg0){
				pt2.play();
			}
		}
		);

		
		Scene scene = new Scene(pane,250,200);
		primaryStage.setTitle("Circle rising");
		primaryStage.setScene(scene);
		primaryStage.show();
		
	}
	
	public static void main(String[] args) {
		Application.launch(args);
	}

}
