
using System;
using System.Data;
using System.Data.Common;
using Dos.ORM;
using Dos.ORM.Common;

namespace JiangNan.CRM.DataMap
{
    /// <summary>
    /// 实体类Customer 。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class Customer : Entity
    {
        public Customer() : base("CRM_Customer") { }

        #region Model
        private int _Id;
        private string _CustomerName;
        private string _Sex;
        private string _Tel;
        private string _CellPhone;
        private string _QQ;
        private string _WeChat;
        private int? _BelongType;
        private int? _ConsultantDegreeType;
        private int? _EduLevelNo;
        private int? _CollegeNo;
        private int? _LevelNo;
        private int? _MajorNo;
        private DateTime? _ConsultantDate;
        private string _ConsultantDetail;
        private bool? _CustomeStatus;
        private string _BelongUser;
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
        private int? _CallBackStatus;
        private bool? _IsExpress;
        private int? _StarNum;
        /// <summary>
        /// 
        /// </summary>
        public int Id
        {
            get { return _Id; }
            set
            {
                this.OnPropertyValueChange(_.Id, _Id, value);
                this._Id = value;
            }
        }
        /// <summary>
        /// 客户姓名
        /// </summary>
        public string CustomerName
        {
            get { return _CustomerName; }
            set
            {
                this.OnPropertyValueChange(_.CustomerName, _CustomerName, value);
                this._CustomerName = value;
            }
        }
        /// <summary>
        /// 性别
        /// </summary>
        public string Sex
        {
            get { return _Sex; }
            set
            {
                this.OnPropertyValueChange(_.Sex, _Sex, value);
                this._Sex = value;
            }
        }
        /// <summary>
        /// 电话
        /// </summary>
        public string Tel
        {
            get { return _Tel; }
            set
            {
                this.OnPropertyValueChange(_.Tel, _Tel, value);
                this._Tel = value;
            }
        }
        /// <summary>
        /// 手机
        /// </summary>
        public string CellPhone
        {
            get { return _CellPhone; }
            set
            {
                this.OnPropertyValueChange(_.CellPhone, _CellPhone, value);
                this._CellPhone = value;
            }
        }
        /// <summary>
        /// QQ
        /// </summary>
        public string QQ
        {
            get { return _QQ; }
            set
            {
                this.OnPropertyValueChange(_.QQ, _QQ, value);
                this._QQ = value;
            }
        }
        /// <summary>
        /// 微信
        /// </summary>
        public string WeChat
        {
            get { return _WeChat; }
            set
            {
                this.OnPropertyValueChange(_.WeChat, _WeChat, value);
                this._WeChat = value;
            }
        }
        /// <summary>
        /// 咨询所属类型
        /// </summary>
        public int? BelongType
        {
            get { return _BelongType; }
            set
            {
                this.OnPropertyValueChange(_.BelongType, _BelongType, value);
                this._BelongType = value;
            }
        }
        /// <summary>
        /// 咨询学历类型
        /// </summary>
        public int? ConsultantDegreeType
        {
            get { return _ConsultantDegreeType; }
            set
            {
                this.OnPropertyValueChange(_.ConsultantDegreeType, _ConsultantDegreeType, value);
                this._ConsultantDegreeType = value;
            }
        }
        /// <summary>
        /// 现教育程度
        /// </summary>
        public int? EduLevelNo
        {
            get { return _EduLevelNo; }
            set
            {
                this.OnPropertyValueChange(_.EduLevelNo, _EduLevelNo, value);
                this._EduLevelNo = value;
            }
        }
        /// <summary>
        /// 咨询高校
        /// </summary>
        public int? CollegeNo
        {
            get { return _CollegeNo; }
            set
            {
                this.OnPropertyValueChange(_.CollegeNo, _CollegeNo, value);
                this._CollegeNo = value;
            }
        }
        /// <summary>
        /// 专业层次
        /// </summary>
        public int? LevelNo
        {
            get { return _LevelNo; }
            set
            {
                this.OnPropertyValueChange(_.LevelNo, _LevelNo, value);
                this._LevelNo = value;
            }
        }
        /// <summary>
        /// 专业
        /// </summary>
        public int? MajorNo
        {
            get { return _MajorNo; }
            set
            {
                this.OnPropertyValueChange(_.MajorNo, _MajorNo, value);
                this._MajorNo = value;
            }
        }
        /// <summary>
        /// 咨询日期
        /// </summary>
        public DateTime? ConsultantDate
        {
            get { return _ConsultantDate; }
            set
            {
                this.OnPropertyValueChange(_.ConsultantDate, _ConsultantDate, value);
                this._ConsultantDate = value;
            }
        }
        /// <summary>
        /// 咨询内容
        /// </summary>
        public string ConsultantDetail
        {
            get { return _ConsultantDetail; }
            set
            {
                this.OnPropertyValueChange(_.ConsultantDetail, _ConsultantDetail, value);
                this._ConsultantDetail = value;
            }
        }
        /// <summary>
        /// 客户状态
        /// </summary>
        public bool? CustomeStatus
        {
            get { return _CustomeStatus; }
            set
            {
                this.OnPropertyValueChange(_.CustomeStatus, _CustomeStatus, value);
                this._CustomeStatus = value;
            }
        }
        /// <summary>
        /// 属于用户
        /// </summary>
        public string BelongUser
        {
            get { return _BelongUser; }
            set
            {
                this.OnPropertyValueChange(_.BelongUser, _BelongUser, value);
                this._BelongUser = value;
            }
        }
        /// <summary>
        /// 报名日期
        /// </summary>
        public DateTime? ApplyDate
        {
            get { return _ApplyDate; }
            set
            {
                this.OnPropertyValueChange(_.ApplyDate, _ApplyDate, value);
                this._ApplyDate = value;
            }
        }
        /// <summary>
        /// 创建日期
        /// </summary>
        public DateTime? CreateDate
        {
            get { return _CreateDate; }
            set
            {
                this.OnPropertyValueChange(_.CreateDate, _CreateDate, value);
                this._CreateDate = value;
            }
        }
        /// <summary>
        /// 最后修改日期
        /// </summary>
        public DateTime? LastModifyDate
        {
            get { return _LastModifyDate; }
            set
            {
                this.OnPropertyValueChange(_.LastModifyDate, _LastModifyDate, value);
                this._LastModifyDate = value;
            }
        }
        /// <summary>
        /// 修改人
        /// </summary>
        public string Modifyer
        {
            get { return _Modifyer; }
            set
            {
                this.OnPropertyValueChange(_.Modifyer, _Modifyer, value);
                this._Modifyer = value;
            }
        }
        /// <summary>
        /// 媒体来源
        /// </summary>
        public int? MediaSource
        {
            get { return _MediaSource; }
            set
            {
                this.OnPropertyValueChange(_.MediaSource, _MediaSource, value);
                this._MediaSource = value;
            }
        }
        /// <summary>
        /// 未报名原因
        /// </summary>
        public string NoApplyReason
        {
            get { return _NoApplyReason; }
            set
            {
                this.OnPropertyValueChange(_.NoApplyReason, _NoApplyReason, value);
                this._NoApplyReason = value;
            }
        }
        /// <summary>
        /// 备注
        /// </summary>
        public string Remark
        {
            get { return _Remark; }
            set
            {
                this.OnPropertyValueChange(_.Remark, _Remark, value);
                this._Remark = value;
            }
        }
        /// <summary>
        /// 采集员
        /// </summary>
        public int? Gatherer
        {
            get { return _Gatherer; }
            set
            {
                this.OnPropertyValueChange(_.Gatherer, _Gatherer, value);
                this._Gatherer = value;
            }
        }
        /// <summary>
        /// 信息状态
        /// </summary>
        public int? InfoStatus
        {
            get { return _InfoStatus; }
            set
            {
                this.OnPropertyValueChange(_.InfoStatus, _InfoStatus, value);
                this._InfoStatus = value;
            }
        }
        /// <summary>
        /// 是否填写报名表
        /// </summary>
        public bool? IsFillInApplyForm
        {
            get { return _IsFillInApplyForm; }
            set
            {
                this.OnPropertyValueChange(_.IsFillInApplyForm, _IsFillInApplyForm, value);
                this._IsFillInApplyForm = value;
            }
        }
        /// <summary>
        /// 回访状态
        /// </summary>
        public int? CallBackStatus
        {
            get { return _CallBackStatus; }
            set
            {
                this.OnPropertyValueChange(_.CallBackStatus, _CallBackStatus, value);
                this._CallBackStatus = value;
            }
        }
        /// <summary>
        /// 是否标识
        /// </summary>
        public bool? IsExpress
        {
            get { return _IsExpress; }
            set
            {
                this.OnPropertyValueChange(_.IsExpress, _IsExpress, value);
                this._IsExpress = value;
            }
        }
        /// <summary>
        /// 报名意愿
        /// </summary>
        public int? StarNum
        {
            get { return _StarNum; }
            set
            {
                this.OnPropertyValueChange(_.StarNum, _StarNum, value);
                this._StarNum = value;
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
				_.CustomerName,
				_.Sex,
				_.Tel,
				_.CellPhone,
				_.QQ,
				_.WeChat,
				_.BelongType,
				_.ConsultantDegreeType,
				_.EduLevelNo,
				_.CollegeNo,
				_.LevelNo,
				_.MajorNo,
				_.ConsultantDate,
				_.ConsultantDetail,
				_.CustomeStatus,
				_.BelongUser,
				_.ApplyDate,
				_.CreateDate,
				_.LastModifyDate,
				_.Modifyer,
				_.MediaSource,
				_.NoApplyReason,
				_.Remark,
				_.Gatherer,
				_.InfoStatus,
				_.IsFillInApplyForm,
				_.CallBackStatus,
				_.IsExpress,
				_.StarNum};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._Id,
				this._CustomerName,
				this._Sex,
				this._Tel,
				this._CellPhone,
				this._QQ,
				this._WeChat,
				this._BelongType,
				this._ConsultantDegreeType,
				this._EduLevelNo,
				this._CollegeNo,
				this._LevelNo,
				this._MajorNo,
				this._ConsultantDate,
				this._ConsultantDetail,
				this._CustomeStatus,
				this._BelongUser,
				this._ApplyDate,
				this._CreateDate,
				this._LastModifyDate,
				this._Modifyer,
				this._MediaSource,
				this._NoApplyReason,
				this._Remark,
				this._Gatherer,
				this._InfoStatus,
				this._IsFillInApplyForm,
				this._CallBackStatus,
				this._IsExpress,
				this._StarNum};
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
            public readonly static Field All = new Field("*", "CRM_Customer");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field Id = new Field("Id", "CRM_Customer", "Id");
            /// <summary>
            /// 客户姓名
            /// </summary>
            public readonly static Field CustomerName = new Field("CustomerName", "CRM_Customer", "客户姓名");
            /// <summary>
            /// 性别
            /// </summary>
            public readonly static Field Sex = new Field("Sex", "CRM_Customer", "性别");
            /// <summary>
            /// 电话
            /// </summary>
            public readonly static Field Tel = new Field("Tel", "CRM_Customer", "电话");
            /// <summary>
            /// 手机
            /// </summary>
            public readonly static Field CellPhone = new Field("CellPhone", "CRM_Customer", "手机");
            /// <summary>
            /// QQ
            /// </summary>
            public readonly static Field QQ = new Field("QQ", "CRM_Customer", "QQ");
            /// <summary>
            /// 微信
            /// </summary>
            public readonly static Field WeChat = new Field("WeChat", "CRM_Customer", "微信");
            /// <summary>
            /// 咨询所属类型
            /// </summary>
            public readonly static Field BelongType = new Field("BelongType", "CRM_Customer", "咨询所属类型");
            /// <summary>
            /// 咨询学历类型
            /// </summary>
            public readonly static Field ConsultantDegreeType = new Field("ConsultantDegreeType", "CRM_Customer", "咨询学历类型");
            /// <summary>
            /// 现教育程度
            /// </summary>
            public readonly static Field EduLevelNo = new Field("EduLevelNo", "CRM_Customer", "现教育程度");
            /// <summary>
            /// 咨询高校
            /// </summary>
            public readonly static Field CollegeNo = new Field("CollegeNo", "CRM_Customer", "咨询高校");
            /// <summary>
            /// 专业层次
            /// </summary>
            public readonly static Field LevelNo = new Field("LevelNo", "CRM_Customer", "专业层次");
            /// <summary>
            /// 专业
            /// </summary>
            public readonly static Field MajorNo = new Field("MajorNo", "CRM_Customer", "专业");
            /// <summary>
            /// 咨询日期
            /// </summary>
            public readonly static Field ConsultantDate = new Field("ConsultantDate", "CRM_Customer", "咨询日期");
            /// <summary>
            /// 咨询内容
            /// </summary>
            public readonly static Field ConsultantDetail = new Field("ConsultantDetail", "CRM_Customer", "咨询内容");
            /// <summary>
            /// 客户状态
            /// </summary>
            public readonly static Field CustomeStatus = new Field("CustomeStatus", "CRM_Customer", "客户状态");
            /// <summary>
            /// 属于用户
            /// </summary>
            public readonly static Field BelongUser = new Field("BelongUser", "CRM_Customer", "属于用户");
            /// <summary>
            /// 报名日期
            /// </summary>
            public readonly static Field ApplyDate = new Field("ApplyDate", "CRM_Customer", "报名日期");
            /// <summary>
            /// 创建日期
            /// </summary>
            public readonly static Field CreateDate = new Field("CreateDate", "CRM_Customer", "创建日期");
            /// <summary>
            /// 最后修改日期
            /// </summary>
            public readonly static Field LastModifyDate = new Field("LastModifyDate", "CRM_Customer", "最后修改日期");
            /// <summary>
            /// 修改人
            /// </summary>
            public readonly static Field Modifyer = new Field("Modifyer", "CRM_Customer", "修改人");
            /// <summary>
            /// 媒体来源
            /// </summary>
            public readonly static Field MediaSource = new Field("MediaSource", "CRM_Customer", "媒体来源");
            /// <summary>
            /// 未报名原因
            /// </summary>
            public readonly static Field NoApplyReason = new Field("NoApplyReason", "CRM_Customer", "未报名原因");
            /// <summary>
            /// 备注
            /// </summary>
            public readonly static Field Remark = new Field("Remark", "CRM_Customer", "备注");
            /// <summary>
            /// 采集员
            /// </summary>
            public readonly static Field Gatherer = new Field("Gatherer", "CRM_Customer", "采集员");
            /// <summary>
            /// 信息状态
            /// </summary>
            public readonly static Field InfoStatus = new Field("InfoStatus", "CRM_Customer", "信息状态");
            /// <summary>
            /// 是否填写报名表
            /// </summary>
            public readonly static Field IsFillInApplyForm = new Field("IsFillInApplyForm", "CRM_Customer", "是否填写报名表");
            /// <summary>
            /// 回访状态
            /// </summary>
            public readonly static Field CallBackStatus = new Field("callBackStatus", "CRM_Customer", "回访状态");
            /// <summary>
            /// 是否标识
            /// </summary>
            public readonly static Field IsExpress = new Field("IsExpress", "CRM_Customer", "是否标识");
            /// <summary>
            /// 报名意愿
            /// </summary>
            public readonly static Field StarNum = new Field("StarNum", "CRM_Customer", "报名意愿");
        }
        #endregion


    }
}

