//===============================================================================
// Microsoft patterns & practices
// Web Service Software Factory
//===============================================================================
// Copyright � Microsoft Corporation.  All rights reserved.
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY
// OF ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT
// LIMITED TO THE IMPLIED WARRANTIES OF MERCHANTABILITY AND
// FITNESS FOR A PARTICULAR PURPOSE.
//===============================================================================
// The example companies, organizations, products, domain names,
// e-mail addresses, logos, people, places, and events depicted
// herein are fictitious.  No association with any real company,
// organization, product, domain name, email address, logo, person,
// places, or events is intended or should be inferred.
//===============================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using DslModeling = global::Microsoft.VisualStudio.Modeling;
using DslDiagrams = global::Microsoft.VisualStudio.Modeling.Diagrams;

namespace Microsoft.Practices.ServiceFactory.DataContracts
{
	/// <summary>
	/// Empty ConnectionBuilder class as a placeholder for custom code.
	/// </summary>
	public static partial class AggregationConnectionBuilder
	{
	}
	/// <summary>
	/// ConnectionBuilder class to provide logic for constructing connections between elements.
	/// </summary>
	public static partial class ReferenceConnectionBuilder
	{
		#region Accept Connection Methods
		/// <summary>
		/// Test whether a given model element is acceptable to this ConnectionBuilder as the source of a connection.
		/// </summary>
		/// <param name="candidate">The model element to test.</param>
		/// <returns>Whether the element can be used as the source of a connection.</returns>
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
		public static bool CanAcceptSource(DslModeling::ModelElement candidate)
		{
			if (candidate == null) return false;
			else if (candidate is global::Microsoft.Practices.ServiceFactory.DataContracts.DataContractBase)
			{ 
				return true;
			}
			else
				return false;
		}

		/// <summary>
		/// Test whether a given model element is acceptable to this ConnectionBuilder as the target of a connection.
		/// </summary>
		/// <param name="candidate">The model element to test.</param>
		/// <returns>Whether the element can be used as the target of a connection.</returns>
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
		public static bool CanAcceptTarget(DslModeling::ModelElement candidate)
		{
			if (candidate == null) return false;
			else if (candidate is global::Microsoft.Practices.ServiceFactory.DataContracts.DataContractCollection)
			{ 
				return true;
			}
			else
				return false;
		}
		
		/// <summary>
		/// Test whether a given pair of model elements are acceptable to this ConnectionBuilder as the source and target of a connection
		/// </summary>
		/// <param name="candidateSource">The model element to test as a source</param>
		/// <param name="candidateTarget">The model element to test as a target</param>
		/// <returns>Whether the elements can be used as the source and target of a connection</returns>
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity", Justification = "Generated code.")]
		public static bool CanAcceptSourceAndTarget(DslModeling::ModelElement candidateSource, DslModeling::ModelElement candidateTarget)
		{
			// Accepts null, null; source, null; source, target but NOT null, target
			if (candidateSource == null)
			{
				if (candidateTarget != null)
				{
					throw new global::System.ArgumentNullException("candidateSource");
				}
				else // Both null
				{
					return false;
				}
			}
			bool acceptSource = CanAcceptSource(candidateSource);
			// If the source wasn't accepted then there's no point checking targets.
			// If there is no target then the source controls the accept.
			if (!acceptSource || candidateTarget == null)
			{
				return acceptSource;
			}
			else // Check combinations
			{
				if (candidateSource is global::Microsoft.Practices.ServiceFactory.DataContracts.DataContractBase)
				{
					if (candidateTarget is global::Microsoft.Practices.ServiceFactory.DataContracts.DataContractCollection)
					{
						global::Microsoft.Practices.ServiceFactory.DataContracts.DataContractBase sourceDataContractBase = (global::Microsoft.Practices.ServiceFactory.DataContracts.DataContractBase)candidateSource;
						global::Microsoft.Practices.ServiceFactory.DataContracts.DataContractCollection targetDataContractCollection = (global::Microsoft.Practices.ServiceFactory.DataContracts.DataContractCollection)candidateTarget;
						if(targetDataContractCollection == null || global::Microsoft.Practices.ServiceFactory.DataContracts.DataContractBaseIsBeingReferenceOnDataContractCollections.GetLinkToDataContract(targetDataContractCollection) != null) return false;
						if(targetDataContractCollection == null || sourceDataContractBase == null || global::Microsoft.Practices.ServiceFactory.DataContracts.DataContractBaseIsBeingReferenceOnDataContractCollections.GetLinks(sourceDataContractBase, targetDataContractCollection).Count > 0) return false;
						return true;
					}
				}
				
			}
			return false;
		}
		#endregion

		#region Connection Methods
		/// <summary>
		/// Make a connection between the given pair of source and target elements
		/// </summary>
		/// <param name="source">The model element to use as the source of the connection</param>
		/// <param name="target">The model element to use as the target of the connection</param>
		/// <returns>A link representing the created connection</returns>
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity", Justification = "Generated code.")]
		public static DslModeling::ElementLink Connect(DslModeling::ModelElement source, DslModeling::ModelElement target)
		{
			if (source == null)
			{
				throw new global::System.ArgumentNullException("source");
			}
			if (target == null)
			{
				throw new global::System.ArgumentNullException("target");
			}
			
			if (CanAcceptSourceAndTarget(source, target))
			{
				if (source is global::Microsoft.Practices.ServiceFactory.DataContracts.DataContractBase)
				{
					if (target is global::Microsoft.Practices.ServiceFactory.DataContracts.DataContractCollection)
					{
						global::Microsoft.Practices.ServiceFactory.DataContracts.DataContractBase sourceAccepted = (global::Microsoft.Practices.ServiceFactory.DataContracts.DataContractBase)source;
						global::Microsoft.Practices.ServiceFactory.DataContracts.DataContractCollection targetAccepted = (global::Microsoft.Practices.ServiceFactory.DataContracts.DataContractCollection)target;
						DslModeling::ElementLink result = new global::Microsoft.Practices.ServiceFactory.DataContracts.DataContractBaseIsBeingReferenceOnDataContractCollections(sourceAccepted, targetAccepted);
						if (DslModeling::DomainClassInfo.HasNameProperty(result))
						{
							DslModeling::DomainClassInfo.SetUniqueName(result);
						}
						return result;
					}
				}
				
			}
			global::System.Diagnostics.Debug.Fail("Having agreed that the connection can be accepted we should never fail to make one.");
			throw new global::System.InvalidOperationException();
		}
		#endregion
 	}
 	
 	/// <summary>
	/// Handles interaction between the ConnectionBuilder and the corresponding ConnectionTool.
	/// </summary>
	internal partial class AggregationConnectionToolConnectAction : DslDiagrams::ConnectAction
	{
		private DslDiagrams::ConnectionType[] connectionTypes;
		
		/// <summary>
		/// Constructs a new AggregationConnectionToolConnectAction for the given Diagram.
		/// </summary>
		public AggregationConnectionToolConnectAction(DslDiagrams::Diagram diagram): base(diagram, true) 
		{
		}
		
		/// <summary>
		/// Gets the cursor corresponding to the given mouse position.
		/// </summary>
		/// <remarks>
		/// Changes the cursor to Cursors.No before the first mouse click if the source shape is not valid.
		/// </remarks>
		public override global::System.Windows.Forms.Cursor GetCursor(global::System.Windows.Forms.Cursor currentCursor, DslDiagrams::DiagramClientView diagramClientView, DslDiagrams::PointD mousePosition)
		{
			if (this.MouseDownHitShape == null && currentCursor != global::System.Windows.Forms.Cursors.No)
			{
				DslDiagrams::DiagramHitTestInfo hitTestInfo = new DslDiagrams::DiagramHitTestInfo(diagramClientView);
				this.Diagram.DoHitTest(mousePosition, hitTestInfo);
				DslDiagrams::ShapeElement shape = hitTestInfo.HitDiagramItem.Shape;

				DslDiagrams::ConnectionType connectionType = GetConnectionTypes(shape, null)[0];
				string warningString = string.Empty;
				if (!connectionType.CanCreateConnection(shape, null, ref warningString))
				{
					return global::System.Windows.Forms.Cursors.No;
				}
			}
			return base.GetCursor(currentCursor, diagramClientView, mousePosition);
		}
		
		
		/// <summary>
		/// Returns the AggregationConnectionToolConnectionType associated with this action.
		/// </summary>
		protected override DslDiagrams::ConnectionType[] GetConnectionTypes(DslDiagrams::ShapeElement sourceShapeElement, DslDiagrams::ShapeElement targetShapeElement)
		{
			if(this.connectionTypes == null)
			{
				this.connectionTypes = new DslDiagrams::ConnectionType[] { new AggregationConnectionToolConnectionType() };
			}
			
			return this.connectionTypes;
		}
		
		private partial class AggregationConnectionToolConnectionTypeBase : DslDiagrams::ConnectionType
		{
			/// <summary>
			/// Constructs a new the AggregationConnectionToolConnectionType with the given ConnectionBuilder.
			/// </summary>
			protected AggregationConnectionToolConnectionTypeBase() : base() {}
			
			private static DslDiagrams::ShapeElement RemovePassThroughShapes(DslDiagrams::ShapeElement shape)
			{
				if (shape is DslDiagrams::Compartment)
				{
					return shape.ParentShape;
				}
				DslDiagrams::SwimlaneShape swimlane = shape as DslDiagrams::SwimlaneShape;
				if (swimlane != null && swimlane.ForwardDragDropToParent)
				{
					return shape.ParentShape;
				}
				return shape;
			}
			
			/// <summary>
			/// Called by the base ConnectAction class to determine if the given shapes can be connected.
			/// </summary>
			/// <remarks>
			/// This implementation delegates calls to the ConnectionBuilder AggregationConnectionBuilder.
			/// </remarks>
			public override bool CanCreateConnection(DslDiagrams::ShapeElement sourceShapeElement, DslDiagrams::ShapeElement targetShapeElement, ref string connectionWarning)
			{
				if(sourceShapeElement == null) throw new global::System.ArgumentNullException("sourceShapeElement");
				
				sourceShapeElement = RemovePassThroughShapes(sourceShapeElement);
				
				DslModeling::ModelElement sourceElement = sourceShapeElement.ModelElement;
				if(sourceElement == null) sourceElement = sourceShapeElement;
				
				if(targetShapeElement == null)
				{
					// You will need to implement a method with the following signature:
					// public static bool CanAcceptSource(DslModeling::ModelElement sourceElement)
					// {
					// }
					// in a partial class of AggregationConnectionBuilder.
					return AggregationConnectionBuilder.CanAcceptSource(sourceElement);
				}
				else
				{
					targetShapeElement = RemovePassThroughShapes(targetShapeElement);
					DslModeling::ModelElement targetElement = targetShapeElement.ModelElement;
					if(targetElement == null) targetElement = targetShapeElement;
				
					// You will need to implement a method with the following signature:
					// public static bool CanAcceptSourceAndTarget(DslModeling::ModelElement sourceElement, DslModeling::ModelElement targetElement)
					// {
					// }
					// in a partial class of AggregationConnectionBuilder.
					return AggregationConnectionBuilder.CanAcceptSourceAndTarget(sourceElement, targetElement);
				}
			}
			
			/// <summary>
			/// Called by the base ConnectAction class to ask whether the given source and target are valid.
			/// </summary>
			/// <remarks>
			/// Always return true here, to give CanCreateConnection a chance to decide.
			/// </remarks>
			public override bool IsValidSourceAndTarget(DslDiagrams::ShapeElement sourceShapeElement, DslDiagrams::ShapeElement targetShapeElement)
			{
				return true;
			}
			
			/// <summary>
			/// Called by the base ConnectAction class to create the underlying relationship.
			/// </summary>
			/// <remarks>
			/// This implementation delegates calls to the ConnectionBuilder AggregationConnectionBuilder.
			/// </remarks>
			public override void CreateConnection(DslDiagrams::ShapeElement sourceShapeElement, DslDiagrams::ShapeElement targetShapeElement, DslDiagrams::PaintFeedbackArgs paintFeedbackArgs)
			{
				if(sourceShapeElement == null) throw new global::System.ArgumentNullException("sourceShapeElement");
				if(targetShapeElement == null) throw new global::System.ArgumentNullException("targetShapeElement");
				
				sourceShapeElement = RemovePassThroughShapes(sourceShapeElement);
				targetShapeElement = RemovePassThroughShapes(targetShapeElement);
				
				DslModeling::ModelElement sourceElement = sourceShapeElement.ModelElement;
				if(sourceElement == null) sourceElement = sourceShapeElement;
				DslModeling::ModelElement targetElement = targetShapeElement.ModelElement;
				if(targetElement == null) targetElement = targetShapeElement;
				// You will need to implement a method with the following signature:
				// public static void Connect(DslModeling::ModelElement sourceElement, DslModeling::ModelElement targetElement)
				// {
				// }
				// in a partial class of AggregationConnectionBuilder.
				AggregationConnectionBuilder.Connect(sourceElement, targetElement);
			}
		}
		
		private partial class AggregationConnectionToolConnectionType : AggregationConnectionToolConnectionTypeBase
		{
			/// <summary>
			/// Constructs a new the AggregationConnectionToolConnectionType with the given ConnectionBuilder.
			/// </summary>
			public AggregationConnectionToolConnectionType() : base() {}
		}
	}
}

