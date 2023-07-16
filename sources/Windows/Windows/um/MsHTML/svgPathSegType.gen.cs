// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='svgPathSegType.xml' path='doc/member[@name="svgPathSegType"]/*'/>
public enum svgPathSegType
{
    /// <include file='svgPathSegType.xml' path='doc/member[@name="svgPathSegType.PATHSEG_UNKNOWN"]/*'/>
    PATHSEG_UNKNOWN = 0,
    /// <include file='svgPathSegType.xml' path='doc/member[@name="svgPathSegType.PATHSEG_CLOSEPATH"]/*'/>
    PATHSEG_CLOSEPATH = 1,
    /// <include file='svgPathSegType.xml' path='doc/member[@name="svgPathSegType.PATHSEG_MOVETO_ABS"]/*'/>
    PATHSEG_MOVETO_ABS = 2,
    /// <include file='svgPathSegType.xml' path='doc/member[@name="svgPathSegType.PATHSEG_MOVETO_REL"]/*'/>
    PATHSEG_MOVETO_REL = 3,
    /// <include file='svgPathSegType.xml' path='doc/member[@name="svgPathSegType.PATHSEG_LINETO_ABS"]/*'/>
    PATHSEG_LINETO_ABS = 4,
    /// <include file='svgPathSegType.xml' path='doc/member[@name="svgPathSegType.PATHSEG_LINETO_REL"]/*'/>
    PATHSEG_LINETO_REL = 5,
    /// <include file='svgPathSegType.xml' path='doc/member[@name="svgPathSegType.PATHSEG_CURVETO_CUBIC_ABS"]/*'/>
    PATHSEG_CURVETO_CUBIC_ABS = 6,
    /// <include file='svgPathSegType.xml' path='doc/member[@name="svgPathSegType.PATHSEG_CURVETO_CUBIC_REL"]/*'/>
    PATHSEG_CURVETO_CUBIC_REL = 7,
    /// <include file='svgPathSegType.xml' path='doc/member[@name="svgPathSegType.PATHSEG_CURVETO_QUADRATIC_ABS"]/*'/>
    PATHSEG_CURVETO_QUADRATIC_ABS = 8,
    /// <include file='svgPathSegType.xml' path='doc/member[@name="svgPathSegType.PATHSEG_CURVETO_QUADRATIC_REL"]/*'/>
    PATHSEG_CURVETO_QUADRATIC_REL = 9,
    /// <include file='svgPathSegType.xml' path='doc/member[@name="svgPathSegType.PATHSEG_ARC_ABS"]/*'/>
    PATHSEG_ARC_ABS = 10,
    /// <include file='svgPathSegType.xml' path='doc/member[@name="svgPathSegType.PATHSEG_ARC_REL"]/*'/>
    PATHSEG_ARC_REL = 11,
    /// <include file='svgPathSegType.xml' path='doc/member[@name="svgPathSegType.PATHSEG_LINETO_HORIZONTAL_ABS"]/*'/>
    PATHSEG_LINETO_HORIZONTAL_ABS = 12,
    /// <include file='svgPathSegType.xml' path='doc/member[@name="svgPathSegType.PATHSEG_LINETO_HORIZONTAL_REL"]/*'/>
    PATHSEG_LINETO_HORIZONTAL_REL = 13,
    /// <include file='svgPathSegType.xml' path='doc/member[@name="svgPathSegType.PATHSEG_LINETO_VERTICAL_ABS"]/*'/>
    PATHSEG_LINETO_VERTICAL_ABS = 14,
    /// <include file='svgPathSegType.xml' path='doc/member[@name="svgPathSegType.PATHSEG_LINETO_VERTICAL_REL"]/*'/>
    PATHSEG_LINETO_VERTICAL_REL = 15,
    /// <include file='svgPathSegType.xml' path='doc/member[@name="svgPathSegType.PATHSEG_CURVETO_CUBIC_SMOOTH_ABS"]/*'/>
    PATHSEG_CURVETO_CUBIC_SMOOTH_ABS = 16,
    /// <include file='svgPathSegType.xml' path='doc/member[@name="svgPathSegType.PATHSEG_CURVETO_CUBIC_SMOOTH_REL"]/*'/>
    PATHSEG_CURVETO_CUBIC_SMOOTH_REL = 17,
    /// <include file='svgPathSegType.xml' path='doc/member[@name="svgPathSegType.PATHSEG_CURVETO_QUADRATIC_SMOOTH_ABS"]/*'/>
    PATHSEG_CURVETO_QUADRATIC_SMOOTH_ABS = 18,
    /// <include file='svgPathSegType.xml' path='doc/member[@name="svgPathSegType.PATHSEG_CURVETO_QUADRATIC_SMOOTH_REL"]/*'/>
    PATHSEG_CURVETO_QUADRATIC_SMOOTH_REL = 19,
    /// <include file='svgPathSegType.xml' path='doc/member[@name="svgPathSegType.svgPathSegType_Max"]/*'/>
    svgPathSegType_Max = 2147483647,
}