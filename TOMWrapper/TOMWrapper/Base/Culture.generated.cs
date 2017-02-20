// Code generated by a template
using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using TabularEditor.PropertyGridUI;
using TabularEditor.UndoFramework;
using TOM = Microsoft.AnalysisServices.Tabular;

namespace TabularEditor.TOMWrapper
{
  
    /// <summary>
	/// Base class declaration for Culture
	/// </summary>
	[TypeConverter(typeof(DynamicPropertyConverter))]
	public partial class Culture: TabularNamedObject
	{
	    protected internal new TOM.Culture MetadataObject { get { return base.MetadataObject as TOM.Culture; } internal set { base.MetadataObject = value; } }

		public Culture(Model parent) : base(parent.Handler, new TOM.Culture(), false) {
			MetadataObject.Name = parent.MetadataObject.Cultures.GetNewName("New Culture");
			parent.Cultures.Add(this);
			Init();
		}

		public Culture(TabularModelHandler handler, TOM.Culture cultureMetadataObject) : base(handler, cultureMetadataObject)
		{
		}
    }

	/// <summary>
	/// Collection class for Culture. Provides convenient properties for setting a property on multiple objects at once.
	/// </summary>
	public partial class CultureCollection: TabularObjectCollection<Culture, TOM.Culture, TOM.Model>
	{
		public Model Parent { get; private set; }

		public CultureCollection(TabularModelHandler handler, string collectionName, TOM.CultureCollection metadataObjectCollection, Model parent) : base(handler, collectionName, metadataObjectCollection)
		{
			Parent = parent;

			// Construct child objects (they are automatically added to the Handler's WrapperLookup dictionary):
			foreach(var obj in MetadataObjectCollection) {
				new Culture(handler, obj) { Collection = this };
			}
		}


		public override string ToString() {
			return string.Format("({0} {1})", Count, (Count == 1 ? "Culture" : "Cultures").ToLower());
		}
	}
}
