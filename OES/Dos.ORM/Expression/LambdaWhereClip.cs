

using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using Dos.ORM;
using Dos.ORM.Common;

namespace Dos.ORM
{
    /// <summary>
    /// 条件
    /// </summary>
    [Serializable]
    public class LambdaWhereClip<T>
    {
        /// <summary>
        /// All
        /// </summary>
        public readonly static LambdaWhereClip<T> All = new LambdaWhereClip<T>();

        #region 构造函数
        /// <summary>
        /// 
        /// </summary>
        public LambdaWhereClip() { }
        #endregion
    }
}
