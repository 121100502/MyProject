
using System;
using System.Data;
using System.Data.Common;
using Dos.ORM;
using Dos.ORM.Common;

namespace JiangNan.MS.DataMap
{

	/// <summary>
	/// 实体类Deptment 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Deptment : Entity 
	{
		public Deptment():base("MS_Deptment") {}

		#region Model
		private int _Id;
		private string _DeptmentName;
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
		public string DeptmentName
		{
			get{ return _DeptmentName; }
			set
			{
				this.OnPropertyValueChange(_.DeptmentName,_DeptmentName,value);
				this._DeptmentName=value;
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
				_.DeptmentName};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._Id,
				this._DeptmentName};
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
			public readonly static Field All = new Field("*","MS_Deptment");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Id = new Field("Id","MS_Deptment","Id");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field DeptmentName = new Field("DeptmentName","MS_Deptment","DeptmentName");
		}
		#endregion


	}
}

