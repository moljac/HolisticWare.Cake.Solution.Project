using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolisticWare.IDE.Tools.Projects.DomainBusinessLogic
{
	/// <remarks/>
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/developer/msbuild/2003")]
	public partial class ProjectItemGroupNone
	{

		private string includeField;

		private string subTypeField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string Include
		{
			get
			{
				return this.includeField;
			}
			set
			{
				this.includeField = value;
			}
		}


		/// <remarks/>
		public string SubType
		{
			get
			{
				return this.subTypeField;
			}
			set
			{
				this.subTypeField = value;
			}
		}


	}

}
