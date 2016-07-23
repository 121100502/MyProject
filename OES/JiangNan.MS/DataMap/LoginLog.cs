using System;
using System.Data;
using System.Data.Common;
using Dos.ORM;
using Dos.ORM.Common;

namespace JiangNan.MS.DataMap
{

	/// <summary>
	/// 实体类LoginLog 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class LoginLog : Entity 
	{
		public LoginLog():base("MS_LoginLog") {}

		#region Model
		private int _Id;
		private string _UserName;
		private DateTime? _LoginDate;
		private string _LoginIP;
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
		public DateTime? LoginDate
		{
			get{ return _LoginDate; }
			set
			{
				this.OnPropertyValueChange(_.LoginDate,_LoginDate,value);
				this._LoginDate=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LoginIP
		{
			get{ return _LoginIP; }
			set
			{
				this.OnPropertyValueChange(_.LoginIP,_LoginIP,value);
				this._LoginIP=value;
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
				_.LoginDate,
				_.LoginIP};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._Id,
				this._UserName,
				this._LoginDate,
				this._LoginIP};
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
			public readonly static Field All = new Field("*","MS_LoginLog");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Id = new Field("id","MS_LoginLog","id");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field UserName = new Field("UserName","MS_LoginLog","UserName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field LoginDate = new Field("LoginDate","MS_LoginLog","LoginDate");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field LoginIP = new Field("LoginIP","MS_LoginLog","LoginIP");
		}
		#endregion


	}
}

