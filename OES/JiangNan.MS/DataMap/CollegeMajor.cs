using System;
using System.Data;
using System.Data.Common;
using Dos.ORM;
using Dos.ORM.Common;

namespace JiangNan.MS.DataMap
{

	/// <summary>
	/// 实体类CollegeMajor 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class CollegeMajor : Entity 
	{
		public CollegeMajor():base("collegeMajor") {}

		#region Model
		private int _Id;
		private int? _MajorType;
		private int? _CollageID;
		private string _MajorName;
		private string _Pic;
		private string _ClassTime;
		private string _ClassAds;
		private string _XueShi;
		private string _XueFei;
		private string _Cenci;
		private string _MajorIntro;
		private string _XuefenAnPai;
		private int? _IsIndex;
		private int? _IsTuiJian;
		private int? _ViewCount;
		private string _DegreeFormId;
		private string _Keywords;
		private string _Remark;
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
		public int? MajorType
		{
			get{ return _MajorType; }
			set
			{
				this.OnPropertyValueChange(_.MajorType,_MajorType,value);
				this._MajorType=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? CollageID
		{
			get{ return _CollageID; }
			set
			{
				this.OnPropertyValueChange(_.CollageID,_CollageID,value);
				this._CollageID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MajorName
		{
			get{ return _MajorName; }
			set
			{
				this.OnPropertyValueChange(_.MajorName,_MajorName,value);
				this._MajorName=value;
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
		public string ClassTime
		{
			get{ return _ClassTime; }
			set
			{
				this.OnPropertyValueChange(_.ClassTime,_ClassTime,value);
				this._ClassTime=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ClassAds
		{
			get{ return _ClassAds; }
			set
			{
				this.OnPropertyValueChange(_.ClassAds,_ClassAds,value);
				this._ClassAds=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string XueShi
		{
			get{ return _XueShi; }
			set
			{
				this.OnPropertyValueChange(_.XueShi,_XueShi,value);
				this._XueShi=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string XueFei
		{
			get{ return _XueFei; }
			set
			{
				this.OnPropertyValueChange(_.XueFei,_XueFei,value);
				this._XueFei=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Cenci
		{
			get{ return _Cenci; }
			set
			{
				this.OnPropertyValueChange(_.Cenci,_Cenci,value);
				this._Cenci=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MajorIntro
		{
			get{ return _MajorIntro; }
			set
			{
				this.OnPropertyValueChange(_.MajorIntro,_MajorIntro,value);
				this._MajorIntro=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string XuefenAnPai
		{
			get{ return _XuefenAnPai; }
			set
			{
				this.OnPropertyValueChange(_.XuefenAnPai,_XuefenAnPai,value);
				this._XuefenAnPai=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? IsIndex
		{
			get{ return _IsIndex; }
			set
			{
				this.OnPropertyValueChange(_.IsIndex,_IsIndex,value);
				this._IsIndex=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? IsTuiJian
		{
			get{ return _IsTuiJian; }
			set
			{
				this.OnPropertyValueChange(_.IsTuiJian,_IsTuiJian,value);
				this._IsTuiJian=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ViewCount
		{
			get{ return _ViewCount; }
			set
			{
				this.OnPropertyValueChange(_.ViewCount,_ViewCount,value);
				this._ViewCount=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DegreeFormId
		{
			get{ return _DegreeFormId; }
			set
			{
				this.OnPropertyValueChange(_.DegreeFormId,_DegreeFormId,value);
				this._DegreeFormId=value;
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
		public string Remark
		{
			get{ return _Remark; }
			set
			{
				this.OnPropertyValueChange(_.Remark,_Remark,value);
				this._Remark=value;
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
				_.MajorType,
				_.CollageID,
				_.MajorName,
				_.Pic,
				_.ClassTime,
				_.ClassAds,
				_.XueShi,
				_.XueFei,
				_.Cenci,
				_.MajorIntro,
				_.XuefenAnPai,
				_.IsIndex,
				_.IsTuiJian,
				_.ViewCount,
				_.DegreeFormId,
				_.Keywords,
				_.Remark};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._Id,
				this._MajorType,
				this._CollageID,
				this._MajorName,
				this._Pic,
				this._ClassTime,
				this._ClassAds,
				this._XueShi,
				this._XueFei,
				this._Cenci,
				this._MajorIntro,
				this._XuefenAnPai,
				this._IsIndex,
				this._IsTuiJian,
				this._ViewCount,
				this._DegreeFormId,
				this._Keywords,
				this._Remark};
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
			public readonly static Field All = new Field("*","collegeMajor");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Id = new Field("id","collegeMajor","id");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field MajorType = new Field("majorType","collegeMajor","majorType");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CollageID = new Field("collageID","collegeMajor","collageID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field MajorName = new Field("majorName","collegeMajor","majorName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Pic = new Field("pic","collegeMajor","pic");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ClassTime = new Field("classTime","collegeMajor","classTime");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ClassAds = new Field("classAds","collegeMajor","classAds");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field XueShi = new Field("xueShi","collegeMajor","xueShi");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field XueFei = new Field("xueFei","collegeMajor","xueFei");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Cenci = new Field("cenci","collegeMajor","cenci");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field MajorIntro = new Field("majorIntro","collegeMajor","majorIntro");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field XuefenAnPai = new Field("xuefenAnPai","collegeMajor","xuefenAnPai");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field IsIndex = new Field("isIndex","collegeMajor","isIndex");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field IsTuiJian = new Field("isTuiJian","collegeMajor","isTuiJian");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ViewCount = new Field("viewCount","collegeMajor","viewCount");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field DegreeFormId = new Field("degreeFormId","collegeMajor","degreeFormId");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Keywords = new Field("keywords","collegeMajor","keywords");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Remark = new Field("remark","collegeMajor","remark");
		}
		#endregion


	}
}

