public class Vertex {
    private double x;
    private double y;
    private double z;

    public Vertex(double x, double y){
        this(x,y,Double.NaN);
    }

    public Vertex(double x, double y, double z){
        setX(x);
        setY(y);
        setZ(z);
    }

    public double getX(){
        return this.x;
    }

    public void setX(double value){
        this.x=value;
    }

    public double getY(){
        return this.y;
    }

    public void setY(double value){
        this.y=value;
    }

    public double getZ(){
        return this.z;
    }

    public void setZ(double value){
        this.z=value;
    }

    @Override
    public String toString(){
        String result = "("+this.getX()+", "+this.getY();
        if(!Double.isNaN(this.getZ())){
            result+=", "+this.getZ();
        }
        return result+")";
    }
}
