import java.util.List;
import interfaces.AreaMeasurable;
import interfaces.PerimeterMeasurable;

public abstract class PlaneShape extends Shape
        implements PerimeterMeasurable, AreaMeasurable{
    public PlaneShape(List<Vertex> verices){
        super(verices);

        checkListFor3D(verices);
    }

    private void checkListFor3D(List<Vertex> verices){
        for(Vertex vertex : verices){
            if(!is2D(vertex)){
                throw new IllegalArgumentException("The list of 2D verices contains 3D vertex");
            }
        }
    }

    private boolean is2D(Vertex vertex){
        if(!Double.isNaN(vertex.getZ()))
            return false;
        return true;
    }

    protected double calculateDistance(Vertex a, Vertex b){
        double x = Math.pow((a.getX()-b.getX()),2);
        double y = Math.pow((a.getY()-b.getY()),2);

        return Math.sqrt(x+y);
    }

    public double getPerimeter(){
        double result =0;
        for (Vertex a:super.getVerices()){
            for(Vertex b:super.getVerices()){
                result+=calculateDistance(a,b);
            }
        }

        return result;
    }

    @Override
    public String toString(){
        String result=super.toString();
        result+="Perimeter: "+this.getPerimeter()+"\n"
                +"Area: "+this.getArea();

        return result+"\n";
    }
}
