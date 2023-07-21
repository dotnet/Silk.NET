// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='svgUnitTypes.xml' path='doc/member[@name="svgUnitTypes"]/*' />
public enum svgUnitTypes
{
    /// <include file='svgUnitTypes.xml' path='doc/member[@name="svgUnitTypes.SVG_UNITTYPE_UNKNOWN"]/*' />
    SVG_UNITTYPE_UNKNOWN = 0,

    /// <include file='svgUnitTypes.xml' path='doc/member[@name="svgUnitTypes.SVG_UNITTYPE_USERSPACEONUSE"]/*' />
    SVG_UNITTYPE_USERSPACEONUSE = 1,

    /// <include file='svgUnitTypes.xml' path='doc/member[@name="svgUnitTypes.SVG_UNITTYPE_OBJECTBOUNDINGBOX"]/*' />
    SVG_UNITTYPE_OBJECTBOUNDINGBOX = 2,

    /// <include file='svgUnitTypes.xml' path='doc/member[@name="svgUnitTypes.svgUnitTypes_Max"]/*' />
    svgUnitTypes_Max = 2147483647,
}
