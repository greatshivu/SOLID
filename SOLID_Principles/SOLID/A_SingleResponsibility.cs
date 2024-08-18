namespace SOLID_Principles.SOLID
{
    public class A_SingleResponsibility
    {
    }

    
    public class A_Car
    {
        public int Wheels { get; set; }
        public string? StearingType { get; set; }
        #region Not belongs this class, Helmet is part of Bike not part of car, so moving to another class bike
        //public string GetHelmetType() { return  "FullRounded"; }
        #endregion
    }
    public class A_Bike
    {
        public string GetHelmetType() { return  "FullRounded"; }
    }
}
