import java.util.Arrays;

public class Rectangle extends PlaneShape {
    private double width;
    private double height;

    public Rectangle(Vertex a, double width, double height){
        super(Arrays.asList(a));

        setHeight(height);
        setWidth(width);
    }

    public double getWidth(){
        return this.width;
    }

    public void setWidth(double value){
        this.width=value;
    }

    public double getHeight(){
        return this.height;
    }

    public void setHeight(double value){
        this.height=value;
    }

    public double getArea(){
        return this.getHeight()*this.getWidth();
    }
}
