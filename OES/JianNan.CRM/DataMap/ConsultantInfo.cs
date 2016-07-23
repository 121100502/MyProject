using System;
using System.Data;
using System.Data.Common;
using Dos.ORM;
using Dos.ORM.Common;

namespace JiangNan.CRM.DataMap
{

	/// <summary>
	/// 实体类ConsultantInfo 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ConsultantInfo : Entity 
	{
		public ConsultantInfo():base("CRM_ConsultantInfo") {}
		#region Model
		private int _Id;
		private string _ConsultantName;
		private string _Sex;
		private string _Tel;
		private string _CellPhone;
		private string _QQ;
		private string _WeChat;
		private int? _Edu;
		private int? _ConsultantCollege;
		private int? _Degree;
		private int? _Major;
		private DateTime? _ConsultantDate;
		private string _ConsultantDetail;
		private int? _ConsultantStatus;
		private int? _BelongTeacher;
		private DateTime? _ApplyDate;
		private DateTime? _CreateDate;
		private DateTime? _LastModifyDate;
		private string _Modifyer;
		private int? _MediaSource;
		private string _NoApplyReason;
		private string _Remark;
		private int? _Gatherer;
		private int? _InfoStatus;
		private bool? _IsFillInApplyForm;
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
		public string ConsultantName
		{
			get{ return _ConsultantName; }
			set
			{
				this.OnPropertyValueChange(_.ConsultantName,_ConsultantName,value);
				this._ConsultantName=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Sex
		{
			get{ return _Sex; }
			set
			{
				this.OnPropertyValueChange(_.Sex,_Sex,value);
				this._Sex=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Tel
		{
			get{ return _Tel; }
			set
			{
				this.OnPropertyValueChange(_.Tel,_Tel,value);
				this._Tel=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CellPhone
		{
			get{ return _CellPhone; }
			set
			{
				this.OnPropertyValueChange(_.CellPhone,_CellPhone,value);
				this._CellPhone=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string QQ
		{
			get{ return _QQ; }
			set
			{
				this.OnPropertyValueChange(_.QQ,_QQ,value);
				this._QQ=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WeChat
		{
			get{ return _WeChat; }
			set
			{
				this.OnPropertyValueChange(_.WeChat,_WeChat,value);
				this._WeChat=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Edu
		{
			get{ return _Edu; }
			set
			{
				this.OnPropertyValueChange(_.Edu,_Edu,value);
				this._Edu=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ConsultantCollege
		{
			get{ return _ConsultantCollege; }
			set
			{
				this.OnPropertyValueChange(_.ConsultantCollege,_ConsultantCollege,value);
				this._ConsultantCollege=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Degree
		{
			get{ return _Degree; }
			set
			{
				this.OnPropertyValueChange(_.Degree,_Degree,value);
				this._Degree=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Major
		{
			get{ return _Major; }
			set
			{
				this.OnPropertyValueChange(_.Major,_Major,value);
				this._Major=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? ConsultantDate
		{
			get{ return _ConsultantDate; }
			set
			{
				this.OnPropertyValueChange(_.ConsultantDate,_ConsultantDate,value);
				this._ConsultantDate=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ConsultantDetail
		{
			get{ return _ConsultantDetail; }
			set
			{
				this.OnPropertyValueChange(_.ConsultantDetail,_ConsultantDetail,value);
				this._ConsultantDetail=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ConsultantStatus
		{
			get{ return _ConsultantStatus; }
			set
			{
				this.OnPropertyValueChange(_.ConsultantStatus,_ConsultantStatus,value);
				this._ConsultantStatus=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? BelongTeacher
		{
			get{ return _BelongTeacher; }
			set
			{
				this.OnPropertyValueChange(_.BelongTeacher,_BelongTeacher,value);
				this._BelongTeacher=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? ApplyDate
		{
			get{ return _ApplyDate; }
			set
			{
				this.OnPropertyValueChange(_.ApplyDate,_ApplyDate,value);
				this._ApplyDate=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? CreateDate
		{
			get{ return _CreateDate; }
			set
			{
				this.OnPropertyValueChange(_.CreateDate,_CreateDate,value);
				this._CreateDate=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? LastModifyDate
		{
			get{ return _LastModifyDate; }
			set
			{
				this.OnPropertyValueChange(_.LastModifyDate,_LastModifyDate,value);
				this._LastModifyDate=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Modifyer
		{
			get{ return _Modifyer; }
			set
			{
				this.OnPropertyValueChange(_.Modifyer,_Modifyer,value);
				this._Modifyer=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? MediaSource
		{
			get{ return _MediaSource; }
			set
			{
				this.OnPropertyValueChange(_.MediaSource,_MediaSource,value);
				this._MediaSource=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string NoApplyReason
		{
			get{ return _NoApplyReason; }
			set
			{
				this.OnPropertyValueChange(_.NoApplyReason,_NoApplyReason,value);
				this._NoApplyReason=value;
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
		public int? Gatherer
		{
			get{ return _Gatherer; }
			set
			{
				this.OnPropertyValueChange(_.Gatherer,_Gatherer,value);
				this._Gatherer=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? InfoStatus
		{
			get{ return _InfoStatus; }
			set
			{
				this.OnPropertyValueChange(_.InfoStatus,_InfoStatus,value);
				this._InfoStatus=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool? IsFillInApplyForm
		{
			get{ return _IsFillInApplyForm; }
			set
			{
				this.OnPropertyValueChange(_.IsFillInApplyForm,_IsFillInApplyForm,value);
				this._IsFillInApplyForm=value;
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
				_.ConsultantName,
				_.Sex,
				_.Tel,
				_.CellPhone,
				_.QQ,
				_.WeChat,
				_.Edu,
				_.ConsultantCollege,
				_.Degree,
				_.Major,
				_.ConsultantDate,
				_.ConsultantDetail,
				_.ConsultantStatus,
				_.BelongTeacher,
				_.ApplyDate,
				_.CreateDate,
				_.LastModifyDate,
				_.Modifyer,
				_.MediaSource,
				_.NoApplyReason,
				_.Remark,
				_.Gatherer,
				_.InfoStatus,
				_.IsFillInApplyForm};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._Id,
				this._ConsultantName,
				this._Sex,
				this._Tel,
				this._CellPhone,
				this._QQ,
				this._WeChat,
				this._Edu,
				this._ConsultantCollege,
				this._Degree,
				this._Major,
				this._ConsultantDate,
				this._ConsultantDetail,
				this._ConsultantStatus,
				this._BelongTeacher,
				this._ApplyDate,
				this._CreateDate,
				this._LastModifyDate,
				this._Modifyer,
				this._MediaSource,
				this._NoApplyReason,
				this._Remark,
				this._Gatherer,
				this._InfoStatus,
				this._IsFillInApplyForm};
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
			public readonly static Field All = new Field("*","CRM_ConsultantInfo");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Id = new Field("Id","CRM_ConsultantInfo","Id");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ConsultantName = new Field("ConsultantName","CRM_ConsultantInfo","ConsultantName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Sex = new Field("Sex","CRM_ConsultantInfo","Sex");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Tel = new Field("Tel","CRM_ConsultantInfo","Tel");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CellPhone = new Field("CellPhone","CRM_ConsultantInfo","CellPhone");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field QQ = new Field("QQ","CRM_ConsultantInfo","QQ");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field WeChat = new Field("WeChat","CRM_ConsultantInfo","WeChat");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Edu = new Field("Edu","CRM_ConsultantInfo","Edu");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ConsultantCollege = new Field("ConsultantCollege","CRM_ConsultantInfo","ConsultantCollege");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Degree = new Field("Degree","CRM_ConsultantInfo","Degree");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Major = new Field("Major","CRM_ConsultantInfo","Major");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ConsultantDate = new Field("ConsultantDate","CRM_ConsultantInfo","ConsultantDate");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ConsultantDetail = new Field("ConsultantDetail","CRM_ConsultantInfo","ConsultantDetail");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ConsultantStatus = new Field("ConsultantStatus","CRM_ConsultantInfo","ConsultantStatus");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field BelongTeacher = new Field("BelongTeacher","CRM_ConsultantInfo","BelongTeacher");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ApplyDate = new Field("ApplyDate","CRM_ConsultantInfo","ApplyDate");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CreateDate = new Field("CreateDate","CRM_ConsultantInfo","CreateDate");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field LastModifyDate = new Field("LastModifyDate","CRM_ConsultantInfo","LastModifyDate");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Modifyer = new Field("Modifyer","CRM_ConsultantInfo","Modifyer");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field MediaSource = new Field("MediaSource","CRM_ConsultantInfo","MediaSource");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field NoApplyReason = new Field("NoApplyReason","CRM_ConsultantInfo","NoApplyReason");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Remark = new Field("Remark","CRM_ConsultantInfo","Remark");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Gatherer = new Field("Gatherer","CRM_ConsultantInfo","Gatherer");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field InfoStatus = new Field("InfoStatus","CRM_ConsultantInfo","InfoStatus");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field IsFillInApplyForm = new Field("IsFillInApplyForm","CRM_ConsultantInfo","IsFillInApplyForm");
		}
		#endregion


	}
}

