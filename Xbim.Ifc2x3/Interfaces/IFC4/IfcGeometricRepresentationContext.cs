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
namespace Xbim.Ifc2x3.RepresentationResource
{
	public partial class @IfcGeometricRepresentationContext : IIfcGeometricRepresentationContext
	{
		Ifc4.GeometryResource.IfcDimensionCount IIfcGeometricRepresentationContext.CoordinateSpaceDimension 
		{ 
			get
			{
				return new Ifc4.GeometryResource.IfcDimensionCount(CoordinateSpaceDimension);
			} 
		}
		double? IIfcGeometricRepresentationContext.Precision 
		{ 
			get
			{
				if (Precision == null) return null;
				return Precision;
			} 
		}
		Ifc4.GeometryResource.IfcAxis2Placement IIfcGeometricRepresentationContext.WorldCoordinateSystem 
		{ 
			get
			{
				if (WorldCoordinateSystem == null) return null;
				var ifcaxis2placement2d = WorldCoordinateSystem as GeometryResource.IfcAxis2Placement2D;
				if (ifcaxis2placement2d != null) 
					return ifcaxis2placement2d;
				var ifcaxis2placement3d = WorldCoordinateSystem as GeometryResource.IfcAxis2Placement3D;
				if (ifcaxis2placement3d != null) 
					return ifcaxis2placement3d;
				return null;
			} 
		}
		IIfcDirection IIfcGeometricRepresentationContext.TrueNorth 
		{ 
			get
			{
				return TrueNorth;
			} 
		}
		IEnumerable<IIfcGeometricRepresentationSubContext> IIfcGeometricRepresentationContext.HasSubContexts 
		{ 
			get
			{
				return Model.Instances.Where<IIfcGeometricRepresentationSubContext>(e => (e.ParentContext as IfcGeometricRepresentationContext) == this);
			} 
		}

	//## Custom code
	//##
	}
}