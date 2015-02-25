import java.util.Arrays;

public class Sphere extends SpaceShape{
    private double radius;

    public Sphere(Vertex a, double radius){
        super(Arrays.asList(a));

        setRadius(radius);
    }

    public double getRadius(){
        return this.radius;
    }

    public void setRadius(double value){
        this.radius=value;
    }

    public double getArea(){
        return 4*Math.PI*this.getRadius()*this.getRadius();
    }

    public double getVolume(){
        return (4/3)*Math.PI*Math.pow(this.getRadius(),3);
    }
}
