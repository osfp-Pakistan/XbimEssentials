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
namespace Xbim.Ifc2x3.GeometricModelResource
{
	public partial class @IfcSectionedSpine : IIfcSectionedSpine
	{
		IIfcCompositeCurve IIfcSectionedSpine.SpineCurve 
		{ 
			get
			{
				return SpineCurve;
			} 
		}
		IEnumerable<IIfcProfileDef> IIfcSectionedSpine.CrossSections 
		{ 
			get
			{
			foreach (var member in CrossSections)
			{
				yield return member as IIfcProfileDef;
			}
			} 
		}
		IEnumerable<IIfcAxis2Placement3D> IIfcSectionedSpine.CrossSectionPositions 
		{ 
			get
			{
			foreach (var member in CrossSectionPositions)
			{
				yield return member as IIfcAxis2Placement3D;
			}
			} 
		}

	//## Custom code
	//##
	}
}