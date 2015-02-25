import java.util.List;

public abstract class Shape {
    private List<Vertex> verices;

    public Shape(List<Vertex> verices){
        setVerices(verices);
    }

    public List<Vertex> getVerices(){
        return this.verices;
    }

    public void setVerices(List<Vertex> verts){
        this.verices=verts;
    }

    @Override
    public String toString(){
        String result= this.getClass().toString()+"\n";
        for(Vertex value:this.getVerices()){
            result+=value.toString()+"\n";
        }

        return result;
    }
}
