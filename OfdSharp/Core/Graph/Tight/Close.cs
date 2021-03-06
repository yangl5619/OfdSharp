﻿using System.Xml;

namespace OfdSharp.Core.Graph.Tight
{
    /// <summary>
    /// 自动闭合到当前路径的起始点，并以该点为当前点
    /// </summary>
    public class Close : OfdElement
    {
        public Close(XmlDocument xmlDocument) : base(xmlDocument, "Close")
        {
        }
    }
}
