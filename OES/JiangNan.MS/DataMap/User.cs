using System;
using System.Data;
using System.Data.Common;
using Dos.ORM;
using Dos.ORM.Common;

namespace JiangNan.MS.DataMap
{

	/// <summary>
	/// 实体类User 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class User : Entity 
	{
		public User():base("MS_User") {}

		#region Model
		private int _Id;
		private string _UserName;
		private string _UserPwd;
		private int? _DeptmentId;
		private string _UserTrueName;
		private string _Email;
		private int? _LearnCenterId;
		private DateTime? _CreateDate;
		private DateTime? _LastModifyDate;
		private bool? _UserStatus;
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
		public string UserName
		{
			get{ return _UserName; }
			set
			{
				this.OnPropertyValueChange(_.UserName,_UserName,value);
				this._UserName=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UserPwd
		{
			get{ return _UserPwd; }
			set
			{
				this.OnPropertyValueChange(_.UserPwd,_UserPwd,value);
				this._UserPwd=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? DeptmentId
		{
			get{ return _DeptmentId; }
			set
			{
				this.OnPropertyValueChange(_.DeptmentId,_DeptmentId,value);
				this._DeptmentId=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UserTrueName
		{
			get{ return _UserTrueName; }
			set
			{
				this.OnPropertyValueChange(_.UserTrueName,_UserTrueName,value);
				this._UserTrueName=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Email
		{
			get{ return _Email; }
			set
			{
				this.OnPropertyValueChange(_.Email,_Email,value);
				this._Email=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? LearnCenterId
		{
			get{ return _LearnCenterId; }
			set
			{
				this.OnPropertyValueChange(_.LearnCenterId,_LearnCenterId,value);
				this._LearnCenterId=value;
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
		public bool? UserStatus
		{
			get{ return _UserStatus; }
			set
			{
				this.OnPropertyValueChange(_.UserStatus,_UserStatus,value);
				this._UserStatus=value;
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
				_.UserName,
				_.UserPwd,
				_.DeptmentId,
				_.UserTrueName,
				_.Email,
				_.LearnCenterId,
				_.CreateDate,
				_.LastModifyDate,
				_.UserStatus};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._Id,
				this._UserName,
				this._UserPwd,
				this._DeptmentId,
				this._UserTrueName,
				this._Email,
				this._LearnCenterId,
				this._CreateDate,
				this._LastModifyDate,
				this._UserStatus};
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
			public readonly static Field All = new Field("*","MS_User");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Id = new Field("Id","MS_User","Id");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field UserName = new Field("UserName","MS_User","UserName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field UserPwd = new Field("UserPwd","MS_User","UserPwd");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field DeptmentId = new Field("DeptmentId","MS_User","DeptmentId");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field UserTrueName = new Field("UserTrueName","MS_User","UserTrueName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Email = new Field("Email","MS_User","Email");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field LearnCenterId = new Field("LearnCenterId","MS_User","LearnCenterId");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CreateDate = new Field("CreateDate","MS_User","CreateDate");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field LastModifyDate = new Field("LastModifyDate","MS_User","LastModifyDate");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field UserStatus = new Field("UserStatus","MS_User","UserStatus");
		}
		#endregion


	}
}

