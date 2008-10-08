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

using VSShellInterop = global::Microsoft.VisualStudio.Shell.Interop;
using VSShell = global::Microsoft.VisualStudio.Shell;
using DslShell = global::Microsoft.VisualStudio.Modeling.Shell;
using DslDesign = global::Microsoft.VisualStudio.Modeling.Design;
using VSTextTemplatingHost = global::Microsoft.VisualStudio.TextTemplating.VSHost;
	
namespace Microsoft.Practices.ServiceFactory.ServiceContracts
{
	/// <summary>
	/// This class implements the VS package that integrates this DSL into Visual Studio.
	/// </summary>
	[VSShell::DefaultRegistryRoot("Software\\Microsoft\\VisualStudio\\9.0")]
	[VSShell::PackageRegistration(RegisterUsing = VSShell::RegistrationMethod.Assembly, UseManagedResourcesOnly = true)]
	[VSShell::ProvideToolWindow(typeof(ServiceContractDslExplorerToolWindow), MultiInstances = false, Style = VSShell::VsDockStyle.Tabbed, Orientation = VSShell::ToolWindowOrientation.Right, Window = "{3AE79031-E1BC-11D0-8F78-00A0C9110057}")]
	[VSShell::ProvideToolWindowVisibility(typeof(ServiceContractDslExplorerToolWindow), Constants.ServiceContractDslEditorFactoryId)]
	[VSShell::ProvideEditorFactory(typeof(ServiceContractDslEditorFactory), 103, TrustLevel = VSShellInterop::__VSEDITORTRUSTLEVEL.ETL_AlwaysTrusted)]
	[VSShell::ProvideEditorExtension(typeof(ServiceContractDslEditorFactory), "." + Constants.DesignerFileExtension, 32)]
	[DslShell::ProvideRelatedFile("." + Constants.DesignerFileExtension, Constants.DefaultDiagramExtension,
		ProjectSystem = DslShell::ProvideRelatedFileAttribute.CSharpProjectGuid,
		FileOptions = DslShell::RelatedFileType.FileName)]
	[DslShell::ProvideRelatedFile("." + Constants.DesignerFileExtension, Constants.DefaultDiagramExtension,
		ProjectSystem = DslShell::ProvideRelatedFileAttribute.VisualBasicProjectGuid,
		FileOptions = DslShell::RelatedFileType.FileName)]
	[DslShell::RegisterAsDslToolsEditor]
	[global::System.Runtime.InteropServices.ComVisible(true)]
	internal abstract partial class ServiceContractDslPackageBase : DslShell::ModelingPackage
	{
		/// <summary>
		/// Initialization method called by the package base class when this package is loaded.
		/// </summary>
		protected override void Initialize()
		{
			base.Initialize();

			// Register the editor factory used to create the DSL editor.
			this.RegisterEditorFactory(new ServiceContractDslEditorFactory(this));

			// Create the command set that handles menu commands provided by this package.
			ServiceContractDslCommandSet commandSet = new ServiceContractDslCommandSet(this);
			commandSet.Initialize();
			
			// Register the model explorer tool window for this DSL.
			this.AddToolWindow(typeof(ServiceContractDslExplorerToolWindow));

			if (this.DesignTimeRunMode)
			{
				// Toolbar registration doesn't work well under design run mode as the toolbox needs to be reset
				// Instead we'll dynamically zap and recreate our toolbox every time
				// Regular users of the finished tool will get the toolbox setup in the perfectly normal way
				this.SetupDynamicToolbox();
			}
		}
		
		/// <summary>
		/// Retrieves the toolbox items used by this DSL-based editor.
		/// </summary>
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1804:RemoveUnusedLocals")]
		protected override global::System.Collections.Generic.IList<DslDesign::ModelingToolboxItem> CreateToolboxItems()
		{
			global::Microsoft.Practices.ServiceFactory.ServiceContracts.ServiceContractDslToolboxHelper toolboxHelper = new global::Microsoft.Practices.ServiceFactory.ServiceContracts.ServiceContractDslToolboxHelper(this);
			try
			{
				return toolboxHelper.CreateToolboxItems();
			}
			catch(global::System.Exception e)
			{
				global::System.Diagnostics.Debug.Fail("Exception thrown during toolbox item creation.  This may result in Package Load Failure:\r\n\r\n" + e);
				throw;
			}
		}
	}
}
//
// Package attributes which may need to change are placed on the partial class below, rather than in the main include file.
//
namespace Microsoft.Practices.ServiceFactory.ServiceContracts
{
	/// <summary>
	/// Double-derived class to allow easier code customization.
	/// </summary>
	/// <remarks>
	/// A package load key is required to allow this package to load when the Visual Studio SDK is not installed.
	/// Package load keys may be obtained from http://msdn.microsoft.com/vstudio/extend.
	/// Consult the Visual Studio SDK documentation for more information.
	/// </remarks>
	// [VSShell::ProvideLoadKey("Standard", Constants.ProductVersion, Constants.ProductName, Constants.CompanyName, 1)]
	[VSShell::ProvideMenuResource(1000, 1)]
	[VSShell::ProvideToolboxItems(2)]
	[VSTextTemplatingHost::ProvideDirectiveProcessor(typeof(global::Microsoft.Practices.ServiceFactory.ServiceContracts.ServiceContractDirectiveProcessor), global::Microsoft.Practices.ServiceFactory.ServiceContracts.ServiceContractDirectiveProcessor.ServiceContractDirectiveProcessorName, "A directive processor that provides access to ServiceContract files")]
	[global::System.Runtime.InteropServices.Guid(Constants.ServiceContractDslPackageId)]
	[Microsoft.Practices.Modeling.Dsl.Service.RegisterAsExportable(
			typeof(ServiceContractDslDomainModel),
			typeof(ServiceContractDslSerializationBehaviorMonikerResolver),
			typeof(ServiceContractModel),
			typeof(ServiceContractDslSerializationBehavior))]	
	internal sealed partial class ServiceContractDslPackage : ServiceContractDslPackageBase
	{
	}
}