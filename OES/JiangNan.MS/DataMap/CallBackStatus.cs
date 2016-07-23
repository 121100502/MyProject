using System;
using System.Data;
using System.Data.Common;
using Dos.ORM;
using Dos.ORM.Common;

namespace JiangNan.MS.DataMap
{

	/// <summary>
	/// 实体类CallBackStatus 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class CallBackStatus : Entity 
	{
		public CallBackStatus():base("MS_CallBackStatus") {}

		#region Model
		private int _Id;
		private string _StatusName;
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
		public string StatusName
		{
			get{ return _StatusName; }
			set
			{
				this.OnPropertyValueChange(_.StatusName,_StatusName,value);
				this._StatusName=value;
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
				_.StatusName};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._Id,
				this._StatusName};
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
			public readonly static Field All = new Field("*","MS_CallBackStatus");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Id = new Field("Id","MS_CallBackStatus","Id");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field StatusName = new Field("StatusName","MS_CallBackStatus","StatusName");
		}
		#endregion


	}
}

