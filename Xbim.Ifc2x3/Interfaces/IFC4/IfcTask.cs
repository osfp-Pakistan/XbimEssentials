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
	public partial class @IfcTask : IIfcTask
	{
		Ifc4.MeasureResource.IfcLabel? IIfcTask.Status 
		{ 
			get
			{
				if (!Status.HasValue) return null;
				return new Ifc4.MeasureResource.IfcLabel(Status.Value);
			} 
		}
		Ifc4.MeasureResource.IfcLabel? IIfcTask.WorkMethod 
		{ 
			get
			{
				if (!WorkMethod.HasValue) return null;
				return new Ifc4.MeasureResource.IfcLabel(WorkMethod.Value);
			} 
		}
		bool IIfcTask.IsMilestone 
		{ 
			get
			{
				return IsMilestone;
			} 
		}
		long? IIfcTask.Priority 
		{ 
			get
			{
				if (Priority == null) return null;
				return Priority;
			} 
		}
		IIfcTaskTime IIfcTask.TaskTime 
		{ 
			get
			{
				//## Handle return of TaskTime for which no match was found
				//TODO: Handle return of TaskTime for which no match was found
				throw new System.NotImplementedException();
				//##
			} 
		}
		Ifc4.ProcessExtension.IfcTaskTypeEnum? IIfcTask.PredefinedType 
		{ 
			get
			{
				//## Handle return of PredefinedType for which no match was found
				//TODO: Handle return of PredefinedType for which no match was found
				throw new System.NotImplementedException();
				//##
			} 
		}

	//## Custom code
	//##
	}
}