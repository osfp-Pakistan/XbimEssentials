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
namespace Xbim.Ifc2x3.SharedMgmtElements
{
	public partial class @IfcProjectOrder : IIfcProjectOrder
	{
		Ifc4.SharedMgmtElements.IfcProjectOrderTypeEnum? IIfcProjectOrder.PredefinedType 
		{ 
			get
			{
				switch (PredefinedType)
				{
					case IfcProjectOrderTypeEnum.CHANGEORDER:
						return Ifc4.SharedMgmtElements.IfcProjectOrderTypeEnum.CHANGEORDER;
					
					case IfcProjectOrderTypeEnum.MAINTENANCEWORKORDER:
						return Ifc4.SharedMgmtElements.IfcProjectOrderTypeEnum.MAINTENANCEWORKORDER;
					
					case IfcProjectOrderTypeEnum.MOVEORDER:
						return Ifc4.SharedMgmtElements.IfcProjectOrderTypeEnum.MOVEORDER;
					
					case IfcProjectOrderTypeEnum.PURCHASEORDER:
						return Ifc4.SharedMgmtElements.IfcProjectOrderTypeEnum.PURCHASEORDER;
					
					case IfcProjectOrderTypeEnum.WORKORDER:
						return Ifc4.SharedMgmtElements.IfcProjectOrderTypeEnum.WORKORDER;
					
					case IfcProjectOrderTypeEnum.USERDEFINED:
						return Ifc4.SharedMgmtElements.IfcProjectOrderTypeEnum.USERDEFINED;
					
					case IfcProjectOrderTypeEnum.NOTDEFINED:
						return Ifc4.SharedMgmtElements.IfcProjectOrderTypeEnum.NOTDEFINED;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
		}
		Ifc4.MeasureResource.IfcLabel? IIfcProjectOrder.Status 
		{ 
			get
			{
				if (!Status.HasValue) return null;
				return new Ifc4.MeasureResource.IfcLabel(Status.Value);
			} 
		}
		Ifc4.MeasureResource.IfcText? IIfcProjectOrder.LongDescription 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcText(ID);
			} 
		}

	//## Custom code
	//##
	}
}