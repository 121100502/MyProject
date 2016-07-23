using System;
using System.Data;
using System.Data.Common;
using Dos.ORM;
using Dos.ORM.Common;

namespace JiangNan.MS.DataMap
{

	/// <summary>
	/// 实体类Colleges 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class College : Entity 
	{
		public College():base("colleges") {}

		#region Model
		private int _Id;
		private string _CollegeName;
		private string _CollegeAdv;
		private string _LogoPic;
		private string _Thumb;
		private string _Pic;
		private string _CollegeIntro;
		private int? _Orders;
		private int? _Viewcount;
		private string _RemarkDetail;
		private string _PaperSample;
		private string _DegreeFormID;
		private string _Keywords;
		private string _Description;
		private string _Remark;
		private string _HotMajor;
		private int? _IsIndexShow;
		private string _Diploma;
		/// <summary>
		/// 
		/// </summary>
		public int Id
		{
			get{ return _Id; }
			set
			{
				this.OnPropertyValueChange(_.Id,_Id,value);
				this._Id=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CollegeName
		{
			get{ return _CollegeName; }
			set
			{
				this.OnPropertyValueChange(_.CollegeName,_CollegeName,value);
				this._CollegeName=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CollegeAdv
		{
			get{ return _CollegeAdv; }
			set
			{
				this.OnPropertyValueChange(_.CollegeAdv,_CollegeAdv,value);
				this._CollegeAdv=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LogoPic
		{
			get{ return _LogoPic; }
			set
			{
				this.OnPropertyValueChange(_.LogoPic,_LogoPic,value);
				this._LogoPic=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Thumb
		{
			get{ return _Thumb; }
			set
			{
				this.OnPropertyValueChange(_.Thumb,_Thumb,value);
				this._Thumb=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Pic
		{
			get{ return _Pic; }
			set
			{
				this.OnPropertyValueChange(_.Pic,_Pic,value);
				this._Pic=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CollegeIntro
		{
			get{ return _CollegeIntro; }
			set
			{
				this.OnPropertyValueChange(_.CollegeIntro,_CollegeIntro,value);
				this._CollegeIntro=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Orders
		{
			get{ return _Orders; }
			set
			{
				this.OnPropertyValueChange(_.Orders,_Orders,value);
				this._Orders=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Viewcount
		{
			get{ return _Viewcount; }
			set
			{
				this.OnPropertyValueChange(_.Viewcount,_Viewcount,value);
				this._Viewcount=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RemarkDetail
		{
			get{ return _RemarkDetail; }
			set
			{
				this.OnPropertyValueChange(_.RemarkDetail,_RemarkDetail,value);
				this._RemarkDetail=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PaperSample
		{
			get{ return _PaperSample; }
			set
			{
				this.OnPropertyValueChange(_.PaperSample,_PaperSample,value);
				this._PaperSample=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DegreeFormID
		{
			get{ return _DegreeFormID; }
			set
			{
				this.OnPropertyValueChange(_.DegreeFormID,_DegreeFormID,value);
				this._DegreeFormID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Keywords
		{
			get{ return _Keywords; }
			set
			{
				this.OnPropertyValueChange(_.Keywords,_Keywords,value);
				this._Keywords=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Description
		{
			get{ return _Description; }
			set
			{
				this.OnPropertyValueChange(_.Description,_Description,value);
				this._Description=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Remark
		{
			get{ return _Remark; }
			set
			{
				this.OnPropertyValueChange(_.Remark,_Remark,value);
				this._Remark=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string HotMajor
		{
			get{ return _HotMajor; }
			set
			{
				this.OnPropertyValueChange(_.HotMajor,_HotMajor,value);
				this._HotMajor=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? IsIndexShow
		{
			get{ return _IsIndexShow; }
			set
			{
				this.OnPropertyValueChange(_.IsIndexShow,_IsIndexShow,value);
				this._IsIndexShow=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Diploma
		{
			get{ return _Diploma; }
			set
			{
				this.OnPropertyValueChange(_.Diploma,_Diploma,value);
				this._Diploma=value;
			}
		}
		#endregion

		#region Method
		/// <summary>
		/// 获取实体中的标识列
		/// </summary>
		public override Field GetIdentityField()
		{
			return _.Id;
		}
		/// <summary>
		/// 获取实体中的主键列
		/// </summary>
		public override Field[] GetPrimaryKeyFields()
		{
			return new Field[] {
				_.Id};
		}
		/// <summary>
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.Id,
				_.CollegeName,
				_.CollegeAdv,
				_.LogoPic,
				_.Thumb,
				_.Pic,
				_.CollegeIntro,
				_.Orders,
				_.Viewcount,
				_.RemarkDetail,
				_.PaperSample,
				_.DegreeFormID,
				_.Keywords,
				_.Description,
				_.Remark,
				_.HotMajor,
				_.IsIndexShow,
				_.Diploma};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._Id,
				this._CollegeName,
				this._CollegeAdv,
				this._LogoPic,
				this._Thumb,
				this._Pic,
				this._CollegeIntro,
				this._Orders,
				this._Viewcount,
				this._RemarkDetail,
				this._PaperSample,
				this._DegreeFormID,
				this._Keywords,
				this._Description,
				this._Remark,
				this._HotMajor,
				this._IsIndexShow,
				this._Diploma};
		}
		#endregion

		#region _Field
		/// <summary>
		/// 字段信息
		/// </summary>
		public class _
		{
			/// <summary>
			/// * 
			/// </summary>
			public readonly static Field All = new Field("*","colleges");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Id = new Field("id","colleges","id");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CollegeName = new Field("collegeName","colleges","collegeName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CollegeAdv = new Field("CollegeAdv","colleges","CollegeAdv");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field LogoPic = new Field("logoPic","colleges","logoPic");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Thumb = new Field("thumb","colleges","thumb");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Pic = new Field("pic","colleges","pic");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CollegeIntro = new Field("collegeIntro","colleges","collegeIntro");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Orders = new Field("orders","colleges","orders");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Viewcount = new Field("viewcount","colleges","viewcount");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field RemarkDetail = new Field("remarkDetail","colleges","remarkDetail");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field PaperSample = new Field("paperSample","colleges","paperSample");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field DegreeFormID = new Field("degreeFormID","colleges","degreeFormID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Keywords = new Field("keywords","colleges","keywords");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Description = new Field("description","colleges","description");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Remark = new Field("remark","colleges","remark");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field HotMajor = new Field("HotMajor","colleges","HotMajor");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field IsIndexShow = new Field("isIndexShow","colleges","isIndexShow");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Diploma = new Field("diploma","colleges","diploma");
		}
		#endregion


	}
}

