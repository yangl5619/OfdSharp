﻿using System.Collections.Generic;
using System.Xml;

namespace OfdSharp.Core.PageDescription.Clips
{
    /// <summary>
    /// 裁剪区
    ///
    /// 裁剪区由一组路径或文字构成，用以指定页面上的一个有效绘制区域，落在裁剪区
    /// 意外的部分不受绘制指令的影响。
    ///
    /// 一个裁剪区可由多个分路径（Area）组成，最终的裁剪范围是各个部分路径的并集。
    /// 裁剪区中的数据均相对于所修饰图元对象的外界矩形。
    /// </summary>
    public class Clip : OfdElement
    {
        public Clip(XmlDocument xmlDocument) : base(xmlDocument, "Clip")
        {
        }

        /// <summary>
        /// 裁剪区域
        ///
        /// 用一个图形对象或文字对象来描述裁剪区的一个组成部分，
        /// 最终裁剪区是这些区域的并集
        /// </summary>
        public IList<Area> Areas { get; set; }
    }
}
