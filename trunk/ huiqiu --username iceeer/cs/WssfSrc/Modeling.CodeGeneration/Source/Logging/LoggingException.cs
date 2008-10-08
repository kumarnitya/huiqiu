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
using System.Runtime.Serialization;

namespace Microsoft.Practices.Modeling.CodeGeneration.Logging
{
	/// <summary>
	/// The current logging infraestructure might be replaced by EntLib v3
	/// </summary>
	[Serializable]
	public class LoggingException : Exception
	{
		public LoggingException()
			: base()
		{
		}

		public LoggingException(string message)
			: base(message)
		{
		}

		public LoggingException(string message, Exception exception)
			: base(message, exception)
		{
		}

		protected LoggingException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}
	}
}