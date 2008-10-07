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

using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.Modeling;
using Microsoft.Practices.Modeling.ExtensionProvider.Helpers;
using Microsoft.Practices.Modeling.ExtensionProvider.Extension;

namespace Microsoft.Practices.ServiceFactory.DataContracts
{
	[RuleOn(typeof(DataContractModel), FireTime = TimeToFire.TopLevelCommit)]
	public partial class ImplementationTechnologyChangeRule : ChangeRule
	{
		public override void ElementPropertyChanged(ElementPropertyChangedEventArgs e)
		{
			if (e.NewValue is IExtensionProvider)
			{
				// update all extenders
				foreach (ModelElement element in e.ModelElement.Store.ElementDirectory.AllElements)
				{
					if (typeof(IExtensibleObject).IsAssignableFrom(element.GetType()))
					{
						ExtensionProviderHelper.AttachObjectExtender((IExtensibleObject)element, (IExtensionProvider)e.NewValue);
					}
				}
			}
		}
	}
}
