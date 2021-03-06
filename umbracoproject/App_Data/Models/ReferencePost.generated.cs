//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v3.0.7.99
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder;
using Umbraco.ModelsBuilder.Umbraco;

namespace Umbraco.Web.PublishedContentModels
{
	/// <summary>Reference post</summary>
	[PublishedContentModel("referencePost")]
	public partial class ReferencePost : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "referencePost";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public ReferencePost(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<ReferencePost, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Name
		///</summary>
		[ImplementPropertyType("referenceName")]
		public string ReferenceName
		{
			get { return this.GetPropertyValue<string>("referenceName"); }
		}

		///<summary>
		/// Reference
		///</summary>
		[ImplementPropertyType("referencePo")]
		public IHtmlString ReferencePo
		{
			get { return this.GetPropertyValue<IHtmlString>("referencePo"); }
		}

		///<summary>
		/// picture
		///</summary>
		[ImplementPropertyType("refPic")]
		public IPublishedContent RefPic
		{
			get { return this.GetPropertyValue<IPublishedContent>("refPic"); }
		}
	}
}
