import java.util.Arrays;

public class Cuboid extends SpaceShape {
    private double width;
    private double height;
    private double depth;

    public Cuboid(Vertex a, double width, double height, double depth){
        super(Arrays.asList(a));

        setWidth(width);
        setHeight(height);
        setDepth(depth);
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

    public double getDepth(){
        return this.depth;
    }

    public void setDepth(double value){
        this.depth=value;
    }

    public double getVolume(){
        return this.getDepth()*this.getWidth()*this.getHeight();
    }

    public double getArea(){
        return 2*(this.getWidth()*this.getDepth()+this.getDepth()*this.getHeight()+this.getHeight()*this.getWidth());
    }
}
