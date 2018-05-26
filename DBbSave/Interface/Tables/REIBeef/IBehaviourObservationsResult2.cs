using System;

namespace LanBO.ServiceModel.Tables.REIBeef
{
	public interface IBehaviourObservationsResult2
	{
		long BoId { get; set; }
		string NbChew0 { get; set; }
		string NbChew1 { get; set; }
		string NbChew2 { get; set; }
		string NbChew3 { get; set; }
		string NbChew4 { get; set; }
		int AgressiveBehaviour { get; set; }
		bool ValidCategory { get; set; }
	}
}