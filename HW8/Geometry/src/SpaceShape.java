import java.util.List;
import interfaces.VolumeMeasurable;
import interfaces.AreaMeasurable;

public abstract class SpaceShape extends Shape
        implements AreaMeasurable, VolumeMeasurable {
    public SpaceShape(List<Vertex> verices){
        super(verices);
    }

    @Override
    public String toString(){
        String result = super.toString()+"\n";

        result+="Volume: "+this.getVolume()+"\n"
                +"Area: "+this.getArea()+"\n";

        return result+"\n";
    }
}
