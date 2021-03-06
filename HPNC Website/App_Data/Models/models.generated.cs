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

[assembly: PureLiveAssembly]
[assembly:ModelsBuilderAssembly(PureLive = true, SourceHash = "9bcee3c6ccbb78a4")]
[assembly:System.Reflection.AssemblyVersion("0.0.0.1")]

namespace Umbraco.Web.PublishedContentModels
{
	/// <summary>Home</summary>
	[PublishedContentModel("home")]
	public partial class Home : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "home";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Home(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Home, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Featured Content
		///</summary>
		[ImplementPropertyType("featuredContent")]
		public Archetype.Models.ArchetypeModel FeaturedContent
		{
			get { return this.GetPropertyValue<Archetype.Models.ArchetypeModel>("featuredContent"); }
		}
	}

	// Mixin content Type 1080 with alias "admin"
	/// <summary>Admin</summary>
	public partial interface IAdmin : IPublishedContent
	{
		/// <summary>UmbracoNaviHide</summary>
		bool UmbracoNaviHide { get; }
	}

	/// <summary>Admin</summary>
	[PublishedContentModel("admin")]
	public partial class Admin : PublishedContentModel, IAdmin
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "admin";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Admin(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Admin, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// UmbracoNaviHide: UmbracoNaviHide
		///</summary>
		[ImplementPropertyType("umbracoNaviHide")]
		public bool UmbracoNaviHide
		{
			get { return GetUmbracoNaviHide(this); }
		}

		/// <summary>Static getter for UmbracoNaviHide</summary>
		public static bool GetUmbracoNaviHide(IAdmin that) { return that.GetPropertyValue<bool>("umbracoNaviHide"); }
	}

	// Mixin content Type 1085 with alias "richTextBase"
	/// <summary>Rich Text Base</summary>
	public partial interface IRichTextBase : IPublishedContent
	{
		/// <summary>Core Page Content</summary>
		IHtmlString CorePageContent { get; }
	}

	/// <summary>Rich Text Base</summary>
	[PublishedContentModel("richTextBase")]
	public partial class RichTextBase : PublishedContentModel, IRichTextBase
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "richTextBase";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public RichTextBase(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<RichTextBase, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Core Page Content: Add full page content here
		///</summary>
		[ImplementPropertyType("corePageContent")]
		public IHtmlString CorePageContent
		{
			get { return GetCorePageContent(this); }
		}

		/// <summary>Static getter for Core Page Content</summary>
		public static IHtmlString GetCorePageContent(IRichTextBase that) { return that.GetPropertyValue<IHtmlString>("corePageContent"); }
	}

	/// <summary>Custom Home</summary>
	[PublishedContentModel("customHome")]
	public partial class CustomHome : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "customHome";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public CustomHome(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<CustomHome, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Add caption for Pic2: Add caption for Pic2
		///</summary>
		[ImplementPropertyType("addCaptionForPic2")]
		public string AddCaptionForPic2
		{
			get { return this.GetPropertyValue<string>("addCaptionForPic2"); }
		}

		///<summary>
		/// HomePic1: Add Top Left Pic
		///</summary>
		[ImplementPropertyType("homePic1")]
		public string HomePic1
		{
			get { return this.GetPropertyValue<string>("homePic1"); }
		}

		///<summary>
		/// HomePic1 Text: Add caption for Pic1
		///</summary>
		[ImplementPropertyType("homePic1Text")]
		public string HomePic1Text
		{
			get { return this.GetPropertyValue<string>("homePic1Text"); }
		}

		///<summary>
		/// HomePic2: Add Top Right Photo
		///</summary>
		[ImplementPropertyType("homePic2")]
		public string HomePic2
		{
			get { return this.GetPropertyValue<string>("homePic2"); }
		}
	}

	/// <summary>Volunteer</summary>
	[PublishedContentModel("volunteer1")]
	public partial class Volunteer1 : PublishedContentModel, IAdmin, IRichTextBase
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "volunteer1";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Volunteer1(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Volunteer1, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// UmbracoNaviHide: UmbracoNaviHide
		///</summary>
		[ImplementPropertyType("umbracoNaviHide")]
		public bool UmbracoNaviHide
		{
			get { return Umbraco.Web.PublishedContentModels.Admin.GetUmbracoNaviHide(this); }
		}

		///<summary>
		/// Core Page Content: Add full page content here
		///</summary>
		[ImplementPropertyType("corePageContent")]
		public IHtmlString CorePageContent
		{
			get { return Umbraco.Web.PublishedContentModels.RichTextBase.GetCorePageContent(this); }
		}
	}

	/// <summary>Our Story</summary>
	[PublishedContentModel("ourStory1")]
	public partial class OurStory1 : PublishedContentModel, IAdmin
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "ourStory1";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public OurStory1(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<OurStory1, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// contentField: Enter your content here
		///</summary>
		[ImplementPropertyType("contentField")]
		public IHtmlString ContentField
		{
			get { return this.GetPropertyValue<IHtmlString>("contentField"); }
		}

		///<summary>
		/// UmbracoNaviHide: UmbracoNaviHide
		///</summary>
		[ImplementPropertyType("umbracoNaviHide")]
		public bool UmbracoNaviHide
		{
			get { return Umbraco.Web.PublishedContentModels.Admin.GetUmbracoNaviHide(this); }
		}
	}

	/// <summary>Calendar</summary>
	[PublishedContentModel("calendar")]
	public partial class Calendar : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "calendar";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Calendar(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Calendar, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}
	}

	/// <summary>Board of Directors</summary>
	[PublishedContentModel("boardOfDirectors")]
	public partial class BoardOfDirectors : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "boardOfDirectors";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public BoardOfDirectors(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<BoardOfDirectors, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Board Members: Add Board Members with bio and pictures
		///</summary>
		[ImplementPropertyType("boardMembers")]
		public Archetype.Models.ArchetypeModel BoardMembers
		{
			get { return this.GetPropertyValue<Archetype.Models.ArchetypeModel>("boardMembers"); }
		}

		///<summary>
		/// contentField: Add info about being a Board Member here.
		///</summary>
		[ImplementPropertyType("contentField")]
		public IHtmlString ContentField
		{
			get { return this.GetPropertyValue<IHtmlString>("contentField"); }
		}
	}

	/// <summary>Donate</summary>
	[PublishedContentModel("donate1")]
	public partial class Donate1 : PublishedContentModel, IAdmin
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "donate1";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Donate1(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Donate1, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Appeal Language: Add top-of-page appeal language
		///</summary>
		[ImplementPropertyType("appealLanguage")]
		public string AppealLanguage
		{
			get { return this.GetPropertyValue<string>("appealLanguage"); }
		}

		///<summary>
		/// Confirmation Message: Add thank you message and information about donation
		///</summary>
		[ImplementPropertyType("confirmationMessage")]
		public string ConfirmationMessage
		{
			get { return this.GetPropertyValue<string>("confirmationMessage"); }
		}

		///<summary>
		/// Confirmation Photo
		///</summary>
		[ImplementPropertyType("confirmationPhoto")]
		public string ConfirmationPhoto
		{
			get { return this.GetPropertyValue<string>("confirmationPhoto"); }
		}

		///<summary>
		/// Donate Image: Select Donation Page Image
		///</summary>
		[ImplementPropertyType("donateImage")]
		public string DonateImage
		{
			get { return this.GetPropertyValue<string>("donateImage"); }
		}

		///<summary>
		/// Donation Error Message: Add text that will appear upon payment error.
		///</summary>
		[ImplementPropertyType("donationErrorMessage")]
		public string DonationErrorMessage
		{
			get { return this.GetPropertyValue<string>("donationErrorMessage"); }
		}

		///<summary>
		/// Legal Donation Language
		///</summary>
		[ImplementPropertyType("legalDonationLanguage")]
		public string LegalDonationLanguage
		{
			get { return this.GetPropertyValue<string>("legalDonationLanguage"); }
		}

		///<summary>
		/// UmbracoNaviHide: UmbracoNaviHide
		///</summary>
		[ImplementPropertyType("umbracoNaviHide")]
		public bool UmbracoNaviHide
		{
			get { return Umbraco.Web.PublishedContentModels.Admin.GetUmbracoNaviHide(this); }
		}
	}

	/// <summary>Space Rental</summary>
	[PublishedContentModel("spaceRental1")]
	public partial class SpaceRental1 : PublishedContentModel, IAdmin, IRichTextBase
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "spaceRental1";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public SpaceRental1(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<SpaceRental1, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// UmbracoNaviHide: UmbracoNaviHide
		///</summary>
		[ImplementPropertyType("umbracoNaviHide")]
		public bool UmbracoNaviHide
		{
			get { return Umbraco.Web.PublishedContentModels.Admin.GetUmbracoNaviHide(this); }
		}

		///<summary>
		/// Core Page Content: Add full page content here
		///</summary>
		[ImplementPropertyType("corePageContent")]
		public IHtmlString CorePageContent
		{
			get { return Umbraco.Web.PublishedContentModels.RichTextBase.GetCorePageContent(this); }
		}
	}

	/// <summary>Staff</summary>
	[PublishedContentModel("staff1")]
	public partial class Staff1 : PublishedContentModel, IAdmin
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "staff1";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Staff1(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Staff1, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Staff Members
		///</summary>
		[ImplementPropertyType("staffMembers")]
		public Archetype.Models.ArchetypeModel StaffMembers
		{
			get { return this.GetPropertyValue<Archetype.Models.ArchetypeModel>("staffMembers"); }
		}

		///<summary>
		/// UmbracoNaviHide: UmbracoNaviHide
		///</summary>
		[ImplementPropertyType("umbracoNaviHide")]
		public bool UmbracoNaviHide
		{
			get { return Umbraco.Web.PublishedContentModels.Admin.GetUmbracoNaviHide(this); }
		}
	}

	/// <summary>Programs</summary>
	[PublishedContentModel("programs1")]
	public partial class Programs1 : PublishedContentModel, IAdmin
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "programs1";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Programs1(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Programs1, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// UmbracoNaviHide: UmbracoNaviHide
		///</summary>
		[ImplementPropertyType("umbracoNaviHide")]
		public bool UmbracoNaviHide
		{
			get { return Umbraco.Web.PublishedContentModels.Admin.GetUmbracoNaviHide(this); }
		}
	}

	/// <summary>Programs Base</summary>
	[PublishedContentModel("programsBaseCopy")]
	public partial class ProgramsBaseCopy : Programs1, IRichTextBase
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "programsBaseCopy";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public ProgramsBaseCopy(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<ProgramsBaseCopy, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Core Page Content: Add full page content here
		///</summary>
		[ImplementPropertyType("corePageContent")]
		public IHtmlString CorePageContent
		{
			get { return Umbraco.Web.PublishedContentModels.RichTextBase.GetCorePageContent(this); }
		}
	}

	/// <summary>Board Documents</summary>
	[PublishedContentModel("boardDocuments")]
	public partial class BoardDocuments : PublishedContentModel, IAdmin
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "boardDocuments";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public BoardDocuments(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<BoardDocuments, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Board Docs
		///</summary>
		[ImplementPropertyType("boardDocs")]
		public string BoardDocs
		{
			get { return this.GetPropertyValue<string>("boardDocs"); }
		}

		///<summary>
		/// Board Docs Title
		///</summary>
		[ImplementPropertyType("boardDocsTitle")]
		public string BoardDocsTitle
		{
			get { return this.GetPropertyValue<string>("boardDocsTitle"); }
		}

		///<summary>
		/// UmbracoNaviHide: UmbracoNaviHide
		///</summary>
		[ImplementPropertyType("umbracoNaviHide")]
		public bool UmbracoNaviHide
		{
			get { return Umbraco.Web.PublishedContentModels.Admin.GetUmbracoNaviHide(this); }
		}
	}

	/// <summary>Folder</summary>
	[PublishedContentModel("Folder")]
	public partial class Folder : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Folder";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public Folder(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Folder, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Contents:
		///</summary>
		[ImplementPropertyType("contents")]
		public object Contents
		{
			get { return this.GetPropertyValue("contents"); }
		}
	}

	/// <summary>Image</summary>
	[PublishedContentModel("Image")]
	public partial class Image : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Image";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public Image(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Image, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Size
		///</summary>
		[ImplementPropertyType("umbracoBytes")]
		public string UmbracoBytes
		{
			get { return this.GetPropertyValue<string>("umbracoBytes"); }
		}

		///<summary>
		/// Type
		///</summary>
		[ImplementPropertyType("umbracoExtension")]
		public string UmbracoExtension
		{
			get { return this.GetPropertyValue<string>("umbracoExtension"); }
		}

		///<summary>
		/// Upload image
		///</summary>
		[ImplementPropertyType("umbracoFile")]
		public Umbraco.Web.Models.ImageCropDataSet UmbracoFile
		{
			get { return this.GetPropertyValue<Umbraco.Web.Models.ImageCropDataSet>("umbracoFile"); }
		}

		///<summary>
		/// Height
		///</summary>
		[ImplementPropertyType("umbracoHeight")]
		public string UmbracoHeight
		{
			get { return this.GetPropertyValue<string>("umbracoHeight"); }
		}

		///<summary>
		/// Width
		///</summary>
		[ImplementPropertyType("umbracoWidth")]
		public string UmbracoWidth
		{
			get { return this.GetPropertyValue<string>("umbracoWidth"); }
		}
	}

	/// <summary>File</summary>
	[PublishedContentModel("File")]
	public partial class File : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "File";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public File(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<File, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Size
		///</summary>
		[ImplementPropertyType("umbracoBytes")]
		public string UmbracoBytes
		{
			get { return this.GetPropertyValue<string>("umbracoBytes"); }
		}

		///<summary>
		/// Type
		///</summary>
		[ImplementPropertyType("umbracoExtension")]
		public string UmbracoExtension
		{
			get { return this.GetPropertyValue<string>("umbracoExtension"); }
		}

		///<summary>
		/// Upload file
		///</summary>
		[ImplementPropertyType("umbracoFile")]
		public object UmbracoFile
		{
			get { return this.GetPropertyValue("umbracoFile"); }
		}
	}

	/// <summary>Member</summary>
	[PublishedContentModel("Member")]
	public partial class Member : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Member";
		public new const PublishedItemType ModelItemType = PublishedItemType.Member;
#pragma warning restore 0109

		public Member(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Member, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Is Approved
		///</summary>
		[ImplementPropertyType("umbracoMemberApproved")]
		public bool UmbracoMemberApproved
		{
			get { return this.GetPropertyValue<bool>("umbracoMemberApproved"); }
		}

		///<summary>
		/// Comments
		///</summary>
		[ImplementPropertyType("umbracoMemberComments")]
		public string UmbracoMemberComments
		{
			get { return this.GetPropertyValue<string>("umbracoMemberComments"); }
		}

		///<summary>
		/// Failed Password Attempts
		///</summary>
		[ImplementPropertyType("umbracoMemberFailedPasswordAttempts")]
		public string UmbracoMemberFailedPasswordAttempts
		{
			get { return this.GetPropertyValue<string>("umbracoMemberFailedPasswordAttempts"); }
		}

		///<summary>
		/// Last Lockout Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastLockoutDate")]
		public string UmbracoMemberLastLockoutDate
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastLockoutDate"); }
		}

		///<summary>
		/// Last Login Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastLogin")]
		public string UmbracoMemberLastLogin
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastLogin"); }
		}

		///<summary>
		/// Last Password Change Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastPasswordChangeDate")]
		public string UmbracoMemberLastPasswordChangeDate
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastPasswordChangeDate"); }
		}

		///<summary>
		/// Is Locked Out
		///</summary>
		[ImplementPropertyType("umbracoMemberLockedOut")]
		public bool UmbracoMemberLockedOut
		{
			get { return this.GetPropertyValue<bool>("umbracoMemberLockedOut"); }
		}

		///<summary>
		/// Password Answer
		///</summary>
		[ImplementPropertyType("umbracoMemberPasswordRetrievalAnswer")]
		public string UmbracoMemberPasswordRetrievalAnswer
		{
			get { return this.GetPropertyValue<string>("umbracoMemberPasswordRetrievalAnswer"); }
		}

		///<summary>
		/// Password Question
		///</summary>
		[ImplementPropertyType("umbracoMemberPasswordRetrievalQuestion")]
		public string UmbracoMemberPasswordRetrievalQuestion
		{
			get { return this.GetPropertyValue<string>("umbracoMemberPasswordRetrievalQuestion"); }
		}
	}

}
