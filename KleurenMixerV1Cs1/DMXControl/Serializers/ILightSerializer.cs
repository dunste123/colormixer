namespace DMXControl.Serializers
{
    public interface ILightSerializer
    {
        int[] GetDmxRange();
        int[][] GetDmxValues();
    }
}
