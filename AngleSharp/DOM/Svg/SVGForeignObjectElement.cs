﻿namespace AngleSharp.DOM.Svg
{
    /// <summary>
    /// Represents the foreign object element of the SVG DOM.
    /// </summary>
    sealed class SVGForeignObjectElement : SVGElement, IScopeElement
    {
        internal SVGForeignObjectElement()
            : base(Tags.ForeignObject, NodeFlags.HtmlTip | NodeFlags.Special)
        {
        }
    }
}
