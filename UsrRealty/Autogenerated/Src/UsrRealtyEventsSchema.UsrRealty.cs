namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: UsrRealtyEventsSchema

	/// <exclude/>
	public class UsrRealtyEventsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public UsrRealtyEventsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public UsrRealtyEventsSchema(UsrRealtyEventsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b7512771-3bf4-4070-b777-b7100f8475a8");
			Name = "UsrRealtyEvents";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("208c67d9-3bf9-4ac3-aba0-9023b4c2186b");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,82,77,107,219,64,16,189,11,242,31,6,209,131,4,102,73,174,117,27,168,140,27,2,33,13,177,210,75,233,97,189,26,43,91,86,187,98,103,229,196,41,254,239,221,15,59,177,236,148,118,78,210,236,155,55,239,13,79,243,14,169,231,2,161,70,107,57,153,149,99,51,163,87,178,29,44,119,210,232,236,119,6,190,6,146,186,133,197,134,28,118,211,131,206,225,84,215,25,253,183,55,139,108,174,157,116,18,233,63,32,108,190,70,237,118,200,31,177,187,137,173,27,233,5,104,180,197,66,60,98,199,111,189,122,248,12,249,3,217,123,228,202,109,242,242,103,156,233,135,165,146,2,132,226,68,144,158,222,97,129,143,80,113,194,119,94,34,73,114,126,64,103,214,94,174,108,16,214,70,54,240,77,47,248,218,155,40,204,242,23,10,7,132,186,65,59,129,68,87,225,202,59,138,164,95,108,75,128,229,43,219,27,111,168,165,87,192,94,185,246,36,88,78,71,168,68,10,54,90,241,150,139,212,40,19,126,140,109,80,200,142,43,232,173,20,225,60,105,136,93,161,171,55,61,54,51,163,134,78,127,231,106,192,79,59,232,101,17,78,120,23,240,87,213,93,126,180,91,174,160,72,92,151,112,113,190,175,114,132,25,123,10,133,236,154,102,92,11,84,216,120,17,206,14,56,205,78,80,228,108,200,129,15,33,241,22,107,236,122,197,93,16,173,241,9,110,140,224,74,190,240,165,194,69,196,21,59,43,15,132,214,167,84,251,179,251,136,178,123,36,51,88,225,65,198,122,150,201,217,201,154,80,111,41,73,233,202,39,144,159,108,32,22,15,115,77,181,49,149,108,211,95,94,178,218,236,20,148,255,52,225,197,167,6,251,106,108,199,93,113,100,206,175,189,96,231,213,135,227,51,135,114,143,214,60,69,239,243,103,129,125,112,183,31,63,66,111,179,241,215,54,219,102,127,0,141,167,211,123,205,3,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateValueIsTooBigLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateValueIsTooBigLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("6510e18f-d49e-ac62-1b58-6581955d15c7"),
				Name = "ValueIsTooBig",
				CreatedInPackageId = new Guid("208c67d9-3bf9-4ac3-aba0-9023b4c2186b"),
				CreatedInSchemaUId = new Guid("b7512771-3bf4-4070-b777-b7100f8475a8"),
				ModifiedInSchemaUId = new Guid("b7512771-3bf4-4070-b777-b7100f8475a8")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b7512771-3bf4-4070-b777-b7100f8475a8"));
		}

		#endregion

	}

	#endregion

}

