using System;
using System.Data;
using System.Data.Common;
using Dos.ORM;
using Dos.ORM.Common;

namespace JiangNan.MS.DataMap
{

	/// <summary>
	/// 实体类SecondLevelConfig 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class SecondLevelConfig : Entity 
	{
		public SecondLevelConfig():base("MS_SecondLevelConfig") {}

		#region Model
		private int _Id;
		private string _SecondLevelName;
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
		public string SecondLevelName
		{
			get{ return _SecondLevelName; }
			set
			{
				this.OnPropertyValueChange(_.SecondLevelName,_SecondLevelName,value);
				this._SecondLevelName=value;
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
				_.SecondLevelName};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._Id,
				this._SecondLevelName};
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
			public readonly static Field All = new Field("*","MS_SecondLevelConfig");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Id = new Field("Id","MS_SecondLevelConfig","Id");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SecondLevelName = new Field("SecondLevelName","MS_SecondLevelConfig","SecondLevelName");
		}
		#endregion


	}
}

