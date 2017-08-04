namespace domain.nvc
{
    public class LoadMass
    {
        public LoadMassProperty LoadMassProperty { get; set; }
    }
    public enum LoadMassProperty
    {
        FrontLoad = 1,
        RearLoad = 2,
        FifthWheel = 3
    }

}