// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Interfaces;
using System.Collections.Generic;
using System.Linq;

// ReSharper disable once CheckNamespace
namespace Xbim.Ifc2x3.StructuralElementsDomain
{
	public partial class @IfcReinforcingBar : IIfcReinforcingBar
	{
		Ifc4.MeasureResource.IfcPositiveLengthMeasure? IIfcReinforcingBar.NominalDiameter 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcPositiveLengthMeasure(NominalDiameter);
			} 
		}
		Ifc4.MeasureResource.IfcAreaMeasure? IIfcReinforcingBar.CrossSectionArea 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcAreaMeasure(CrossSectionArea);
			} 
		}
		Ifc4.MeasureResource.IfcPositiveLengthMeasure? IIfcReinforcingBar.BarLength 
		{ 
			get
			{
				if (!BarLength.HasValue) return null;
				return new Ifc4.MeasureResource.IfcPositiveLengthMeasure(BarLength.Value);
			} 
		}
		Ifc4.StructuralElementsDomain.IfcReinforcingBarTypeEnum? IIfcReinforcingBar.PredefinedType 
		{ 
			get
			{
				//## Handle return of PredefinedType for which no match was found
				//TODO: Handle return of PredefinedType for which no match was found
				throw new System.NotImplementedException();
				//##
			} 
		}
		Ifc4.ProfileResource.IfcReinforcingBarSurfaceEnum? IIfcReinforcingBar.BarSurface 
		{ 
			get
			{
				switch (BarSurface)
				{
					case ProfilePropertyResource.IfcReinforcingBarSurfaceEnum.PLAIN:
						return Ifc4.ProfileResource.IfcReinforcingBarSurfaceEnum.PLAIN;
					
					case ProfilePropertyResource.IfcReinforcingBarSurfaceEnum.TEXTURED:
						return Ifc4.ProfileResource.IfcReinforcingBarSurfaceEnum.TEXTURED;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
		}

	//## Custom code
	//##
	}
}