namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: UsrYachtEventsSchema

	/// <exclude/>
	public class UsrYachtEventsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public UsrYachtEventsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public UsrYachtEventsSchema(UsrYachtEventsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e8a2dbfc-62ba-4647-bfc7-c5953ebe3c35");
			Name = "UsrYachtEvents";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c4d50eaf-6a76-4da5-9fce-1482155810c9");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,82,93,107,27,49,16,124,15,228,63,44,247,116,7,70,36,175,73,27,168,29,39,4,66,91,122,231,66,41,125,144,117,235,179,130,62,14,73,231,212,45,249,239,93,73,118,226,156,83,200,130,241,105,53,154,157,25,22,12,215,232,123,46,16,26,116,142,123,187,10,108,102,205,74,118,131,227,65,90,115,122,242,247,244,4,168,6,47,77,7,245,214,7,212,151,135,173,195,135,90,91,243,223,75,135,108,110,130,12,18,253,123,48,108,190,65,19,246,208,159,169,189,77,189,123,73,34,12,186,178,22,107,212,252,51,121,128,143,80,44,188,251,193,197,58,20,213,175,252,166,31,150,74,10,16,138,123,15,233,234,13,18,184,128,41,247,248,198,77,38,217,217,63,224,179,27,18,44,91,132,141,149,45,124,49,53,223,144,141,210,46,31,80,4,240,104,90,116,19,200,132,83,92,145,167,68,251,201,117,30,176,122,161,59,96,142,181,36,21,236,153,109,79,131,213,229,107,88,230,133,109,180,67,174,203,124,174,50,126,132,109,81,72,205,21,244,78,138,24,81,122,196,110,49,52,219,30,219,153,85,131,54,223,185,26,240,195,14,121,85,198,20,191,70,120,49,30,44,87,80,102,162,43,56,63,75,85,189,70,140,12,197,66,118,231,103,220,8,84,216,146,128,224,6,36,218,99,156,15,46,174,2,45,163,231,29,54,168,123,197,67,148,108,240,17,238,173,224,74,254,225,75,133,117,194,149,217,200,194,163,163,101,53,20,59,109,42,251,134,222,14,78,16,198,58,34,153,192,241,152,88,207,123,146,247,171,152,64,113,52,192,179,20,203,157,111,172,157,202,46,159,138,138,53,118,39,160,122,135,11,82,159,27,236,198,58,205,67,57,114,71,131,207,129,82,76,191,69,125,125,148,120,172,176,118,246,49,165,48,255,45,176,143,70,247,60,99,248,211,203,113,247,73,127,79,255,0,65,241,103,111,227,3,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateValueIsTooBigLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateValueIsTooBigLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("0e6bfb3c-2c33-f0dc-70bb-1faaf4014d47"),
				Name = "ValueIsTooBig",
				CreatedInPackageId = new Guid("c4d50eaf-6a76-4da5-9fce-1482155810c9"),
				CreatedInSchemaUId = new Guid("e8a2dbfc-62ba-4647-bfc7-c5953ebe3c35"),
				ModifiedInSchemaUId = new Guid("e8a2dbfc-62ba-4647-bfc7-c5953ebe3c35")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e8a2dbfc-62ba-4647-bfc7-c5953ebe3c35"));
		}

		#endregion

	}

	#endregion

}

