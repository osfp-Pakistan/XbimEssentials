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
namespace Xbim.Ifc2x3.FacilitiesMgmtDomain
{
	public partial class @IfcActionRequest : IIfcActionRequest
	{
		Ifc4.SharedMgmtElements.IfcActionRequestTypeEnum? IIfcActionRequest.PredefinedType 
		{ 
			get
			{
				//## Handle return of PredefinedType for which no match was found
                return Ifc4.SharedMgmtElements.IfcActionRequestTypeEnum.NOTDEFINED;
				//##
			} 
		}
		Ifc4.MeasureResource.IfcLabel? IIfcActionRequest.Status 
		{ 
			get
			{
				//## Handle return of Status for which no match was found
			    return null;
			    //##
			} 
		}
		Ifc4.MeasureResource.IfcText? IIfcActionRequest.LongDescription 
		{ 
			get
			{
				//## Handle return of LongDescription for which no match was found
			    return Name != null ? new Ifc4.MeasureResource.IfcText(Name) : null;
			    //##
			} 
		}

	//## Custom code
	//##
	}
}