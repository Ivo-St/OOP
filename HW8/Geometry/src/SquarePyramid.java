import java.util.Arrays;

public class SquarePyramid extends SpaceShape {
    private double width;
    private double height;

    SquarePyramid(Vertex a, double width, double height){
        super(Arrays.asList(a));

        setWidth(width);
        setHeight(height);
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

    public double getVolume(){
        return (this.getWidth() * this.getWidth() * this.getHeight()) / 3;
    }

    public double getArea(){
        double sideHeight = Math.sqrt(
                this.getHeight() * this.getHeight() +
                        (this.getWidth() / 2) * (this.getWidth() / 2));
        return 2 * this.getWidth() * sideHeight + this.getWidth() * this.getWidth();
    }
}
