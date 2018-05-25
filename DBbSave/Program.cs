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
			//dbFactory = new OrmLiteConnectionFactory("repro.sqlite", SqliteDialect.Provider);
            db = dbFactory.Open();    
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

            // This one only it work no exception
            var dietResult = new DietResult();
            dietResult.AccessFiber = 15;
            dietResult.MainFiber = 12;
            dietResult.FiberQuality = 20;
            dietResult.FiberRegularity = 35;
            dietResult.ValidCategory = true;
            audit.DietResult = dietResult;

			// With this one included 'ServiceStack.Data.OptimisticConcurrencyException'
            var manureResult = new ManureResult();
            manureResult.Medium = "5";
            manureResult.Pasty = "3";
            manureResult.Liquid = "0";
            audit.ManureResult = manureResult;

			// With this one included When using SQLite = "SQLite Error 19: 'FOREIGN KEY constraint failed'."
			// When run :memory: 'ServiceStack.Data.OptimisticConcurrencyException'
			var rumenFillResult = new RumenFillResult();
            rumenFillResult.Normal = "10";
            rumenFillResult.SlightlyEmpty = "1";
            rumenFillResult.Bloated = "2";
            audit.RumenFillResult = rumenFillResult;

			db.Save(audit, true);
                 
   		}

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
