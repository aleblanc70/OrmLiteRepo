using System;
namespace LanBO.ServiceModel.Tables.REIBeef
{
    public interface IFacilitiesResult
    {
        long FacilityId { get; set; }
        int TypeIndex { get; set; }
        int FloorIndex { get; set; }
        string PenSurface { get; set; }
        string FeedBunkWidth { get; set; }
        int WaterQuality { get; set; }
        string NbDrink { get; set; }
        int SurfacePerAnimal { get; set; }
        int FeedBunkPerAnimal { get; set; }
        int NumberrAnimalPerDrink { get; set; }
        bool ValidCategory { get; set; }
		//Guid? AuditRowId { get; set; }
    }
}