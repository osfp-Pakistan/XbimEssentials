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
namespace Xbim.Ifc2x3.ProcessExtension
{
	public partial class @IfcWorkControl : IIfcWorkControl
	{
		Ifc4.DateTimeResource.IfcDateTime IIfcWorkControl.CreationDate 
		{ 
			get
			{
				//## Handle return of CreationDate for which no match was found               
                return new Xbim.Ifc4.DateTimeResource.IfcDateTime(CreationDate.ToISODateTimeString());
				//##
			} 
		}
		IEnumerable<IIfcPerson> IIfcWorkControl.Creators 
		{ 
			get
			{
			foreach (var member in Creators)
			{
				yield return member as IIfcPerson;
			}
			} 
		}
		Ifc4.MeasureResource.IfcLabel? IIfcWorkControl.Purpose 
		{ 
			get
			{
				if (!Purpose.HasValue) return null;
				return new Ifc4.MeasureResource.IfcLabel(Purpose.Value);
			} 
		}
		Ifc4.DateTimeResource.IfcDuration? IIfcWorkControl.Duration 
		{ 
			get
			{
				//## Handle return of Duration for which no match was found
				//TODO: Handle return of Duration for which no match was found
				throw new System.NotImplementedException();
				//##
			} 
		}
		Ifc4.DateTimeResource.IfcDuration? IIfcWorkControl.TotalFloat 
		{ 
			get
			{
				//## Handle return of TotalFloat for which no match was found
				//TODO: Handle return of TotalFloat for which no match was found
				throw new System.NotImplementedException();
				//##
			} 
		}
		Ifc4.DateTimeResource.IfcDateTime IIfcWorkControl.StartTime 
		{ 
			get
			{
				//## Handle return of StartTime for which no match was found
				//TODO: Handle return of StartTime for which no match was found
				throw new System.NotImplementedException();
				//##
			} 
		}
		Ifc4.DateTimeResource.IfcDateTime? IIfcWorkControl.FinishTime 
		{ 
			get
			{
				//## Handle return of FinishTime for which no match was found
				//TODO: Handle return of FinishTime for which no match was found
				throw new System.NotImplementedException();
				//##
			} 
		}

	//## Custom code
	//##
	}
}