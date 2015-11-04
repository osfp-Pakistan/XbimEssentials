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
namespace Xbim.Ifc2x3.MeasureResource
{
	public partial class @IfcSIUnit : IIfcSIUnit
	{
		Ifc4.MeasureResource.IfcSIPrefix? IIfcSIUnit.Prefix 
		{ 
			get
			{
				switch (Prefix)
				{
					case IfcSIPrefix.EXA:
						return Ifc4.MeasureResource.IfcSIPrefix.EXA;
					
					case IfcSIPrefix.PETA:
						return Ifc4.MeasureResource.IfcSIPrefix.PETA;
					
					case IfcSIPrefix.TERA:
						return Ifc4.MeasureResource.IfcSIPrefix.TERA;
					
					case IfcSIPrefix.GIGA:
						return Ifc4.MeasureResource.IfcSIPrefix.GIGA;
					
					case IfcSIPrefix.MEGA:
						return Ifc4.MeasureResource.IfcSIPrefix.MEGA;
					
					case IfcSIPrefix.KILO:
						return Ifc4.MeasureResource.IfcSIPrefix.KILO;
					
					case IfcSIPrefix.HECTO:
						return Ifc4.MeasureResource.IfcSIPrefix.HECTO;
					
					case IfcSIPrefix.DECA:
						return Ifc4.MeasureResource.IfcSIPrefix.DECA;
					
					case IfcSIPrefix.DECI:
						return Ifc4.MeasureResource.IfcSIPrefix.DECI;
					
					case IfcSIPrefix.CENTI:
						return Ifc4.MeasureResource.IfcSIPrefix.CENTI;
					
					case IfcSIPrefix.MILLI:
						return Ifc4.MeasureResource.IfcSIPrefix.MILLI;
					
					case IfcSIPrefix.MICRO:
						return Ifc4.MeasureResource.IfcSIPrefix.MICRO;
					
					case IfcSIPrefix.NANO:
						return Ifc4.MeasureResource.IfcSIPrefix.NANO;
					
					case IfcSIPrefix.PICO:
						return Ifc4.MeasureResource.IfcSIPrefix.PICO;
					
					case IfcSIPrefix.FEMTO:
						return Ifc4.MeasureResource.IfcSIPrefix.FEMTO;
					
					case IfcSIPrefix.ATTO:
						return Ifc4.MeasureResource.IfcSIPrefix.ATTO;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
		}
		Ifc4.MeasureResource.IfcSIUnitName IIfcSIUnit.Name 
		{ 
			get
			{
				switch (Name)
				{
					case IfcSIUnitName.AMPERE:
						return Ifc4.MeasureResource.IfcSIUnitName.AMPERE;
					
					case IfcSIUnitName.BECQUEREL:
						return Ifc4.MeasureResource.IfcSIUnitName.BECQUEREL;
					
					case IfcSIUnitName.CANDELA:
						return Ifc4.MeasureResource.IfcSIUnitName.CANDELA;
					
					case IfcSIUnitName.COULOMB:
						return Ifc4.MeasureResource.IfcSIUnitName.COULOMB;
					
					case IfcSIUnitName.CUBIC_METRE:
						return Ifc4.MeasureResource.IfcSIUnitName.CUBIC_METRE;
					
					case IfcSIUnitName.DEGREE_CELSIUS:
						return Ifc4.MeasureResource.IfcSIUnitName.DEGREE_CELSIUS;
					
					case IfcSIUnitName.FARAD:
						return Ifc4.MeasureResource.IfcSIUnitName.FARAD;
					
					case IfcSIUnitName.GRAM:
						return Ifc4.MeasureResource.IfcSIUnitName.GRAM;
					
					case IfcSIUnitName.GRAY:
						return Ifc4.MeasureResource.IfcSIUnitName.GRAY;
					
					case IfcSIUnitName.HENRY:
						return Ifc4.MeasureResource.IfcSIUnitName.HENRY;
					
					case IfcSIUnitName.HERTZ:
						return Ifc4.MeasureResource.IfcSIUnitName.HERTZ;
					
					case IfcSIUnitName.JOULE:
						return Ifc4.MeasureResource.IfcSIUnitName.JOULE;
					
					case IfcSIUnitName.KELVIN:
						return Ifc4.MeasureResource.IfcSIUnitName.KELVIN;
					
					case IfcSIUnitName.LUMEN:
						return Ifc4.MeasureResource.IfcSIUnitName.LUMEN;
					
					case IfcSIUnitName.LUX:
						return Ifc4.MeasureResource.IfcSIUnitName.LUX;
					
					case IfcSIUnitName.METRE:
						return Ifc4.MeasureResource.IfcSIUnitName.METRE;
					
					case IfcSIUnitName.MOLE:
						return Ifc4.MeasureResource.IfcSIUnitName.MOLE;
					
					case IfcSIUnitName.NEWTON:
						return Ifc4.MeasureResource.IfcSIUnitName.NEWTON;
					
					case IfcSIUnitName.OHM:
						return Ifc4.MeasureResource.IfcSIUnitName.OHM;
					
					case IfcSIUnitName.PASCAL:
						return Ifc4.MeasureResource.IfcSIUnitName.PASCAL;
					
					case IfcSIUnitName.RADIAN:
						return Ifc4.MeasureResource.IfcSIUnitName.RADIAN;
					
					case IfcSIUnitName.SECOND:
						return Ifc4.MeasureResource.IfcSIUnitName.SECOND;
					
					case IfcSIUnitName.SIEMENS:
						return Ifc4.MeasureResource.IfcSIUnitName.SIEMENS;
					
					case IfcSIUnitName.SIEVERT:
						return Ifc4.MeasureResource.IfcSIUnitName.SIEVERT;
					
					case IfcSIUnitName.SQUARE_METRE:
						return Ifc4.MeasureResource.IfcSIUnitName.SQUARE_METRE;
					
					case IfcSIUnitName.STERADIAN:
						return Ifc4.MeasureResource.IfcSIUnitName.STERADIAN;
					
					case IfcSIUnitName.TESLA:
						return Ifc4.MeasureResource.IfcSIUnitName.TESLA;
					
					case IfcSIUnitName.VOLT:
						return Ifc4.MeasureResource.IfcSIUnitName.VOLT;
					
					case IfcSIUnitName.WATT:
						return Ifc4.MeasureResource.IfcSIUnitName.WATT;
					
					case IfcSIUnitName.WEBER:
						return Ifc4.MeasureResource.IfcSIUnitName.WEBER;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
		}

	//## Custom code
	//##
	}
}