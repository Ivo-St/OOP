import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

public class Triangle extends PlaneShape {
    public Triangle (Vertex a, Vertex b, Vertex c){
        super(Arrays.asList(a,b,c));
    }

    public Triangle(List<Vertex> list){
        super(list);
    }

    public double getArea(){
        double p = super.getPerimeter()/2;
        double a = calculateDistance(getVerices().get(0),getVerices().get(1));
        double b = calculateDistance(getVerices().get(0),getVerices().get(2));
        double c = calculateDistance(getVerices().get(1),getVerices().get(2));

        return Math.sqrt(p*(p-a)*(p-b)*(p-c));
    }
}
