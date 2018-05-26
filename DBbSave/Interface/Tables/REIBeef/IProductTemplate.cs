using System;
namespace LanBO.ServiceModel.Interface.Tables.REIBeef
{
	public interface IProductTemplate
	{
		string ProductCode { get; set; } //Code Template so user can assign it to a user profile. 
		string ProductName { get; set; } // Product Name
		string ProductText { get; set; } // Description of the Text
		string ProductLogo { get; set; } // Path to Product Logo
		string ProductURL { get; set; } // Product Description URL
		string LogoPath { get; set; } // Path to Company logo 
		Guid? CultureRowId { get; set; }
		bool IsLevucell { get; set; }
		bool Active { get; set; } // When Inactive user can't choose it.		
	}
}
