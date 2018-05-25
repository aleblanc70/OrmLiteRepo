using LanBO.ServiceModel.Tables.REIBeef;
using ServiceStack.OrmLite;

namespace DBbSave
{
	class Program
    {

		static OrmLiteConnectionFactory dbFactory;
		static System.Data.IDbConnection db;
		protected static void Main(string[] args)
        {
		    dbFactory = new OrmLiteConnectionFactory(":memory:", SqliteDialect.Provider);
            db = dbFactory.Open();     //Open ADO.NET DB Connection
			ResetSchema();

			var audit = new Audit();

            audit.Name = "FakeSync";
            audit.FlatStage = "FakeSync";
            audit.MainType = "FakeSync";
            audit.AnimalNb = "200";
            audit.AnimalAge = "9";
            audit.AnimalSex = "male";
            audit.AnimalDietType = "Normal";
            audit.Date = System.DateTime.UtcNow;
            audit.State = "Fine";
            audit.Progress = 60;
            audit.Score = "60";
            audit.Benchmark = "FakeTest";


            var dietResult = new DietResult();
            dietResult.AccessFiber = 15;
            dietResult.MainFiber = 12;
            dietResult.FiberQuality = 20;
            dietResult.FiberRegularity = 35;
            dietResult.ValidCategory = true;
            audit.DietResult = dietResult;

            var manureResult = new ManureResult();
            manureResult.Medium = "5";
            manureResult.Pasty = "3";
            manureResult.Liquid = "0";
            audit.ManureResult = manureResult;

			db.Save(audit, true);
                 
   		}
		/// <summary>
        /// Resets the schema, and clear data from the database
        /// Use with caution
        /// </summary>
        public static void ResetSchema()
        {
            
            
			db.DropAndCreateTable<ManureResult>();
			db.DropAndCreateTable<DietResult>();
			db.DropAndCreateTable<AnimalPerformanceResult>();
			db.DropAndCreateTable<BehaviourObservationsResult1>();
			db.DropAndCreateTable<CleanlinessResult>();
			db.DropAndCreateTable<DietResult>();
			db.DropAndCreateTable<RumenFillResult>();
            db.DropAndCreateTable<Audit>();
        }
    
    }
}
