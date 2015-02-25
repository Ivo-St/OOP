import sun.plugin.javascript.navig.Array;

import java.util.Arrays;

public class Circle extends PlaneShape {
    private double radius;

    public Circle(Vertex a, double radius){
        super(Arrays.asList(a));

        setRadius(radius);
    }

    public void setRadius(double value){
        this.radius=value;
    }

    public double getRadius(){
        return this.radius;
    }

    public double getArea(){
        return Math.PI*this.getRadius();
    }
}
