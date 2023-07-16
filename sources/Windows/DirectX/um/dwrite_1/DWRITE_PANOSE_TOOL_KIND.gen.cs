// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwrite_1.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.DirectX;
/// <include file='DWRITE_PANOSE_TOOL_KIND.xml' path='doc/member[@name="DWRITE_PANOSE_TOOL_KIND"]/*'/>
public enum DWRITE_PANOSE_TOOL_KIND
{
    /// <include file='DWRITE_PANOSE_TOOL_KIND.xml' path='doc/member[@name="DWRITE_PANOSE_TOOL_KIND.DWRITE_PANOSE_TOOL_KIND_ANY"]/*'/>
    DWRITE_PANOSE_TOOL_KIND_ANY = 0,
    /// <include file='DWRITE_PANOSE_TOOL_KIND.xml' path='doc/member[@name="DWRITE_PANOSE_TOOL_KIND.DWRITE_PANOSE_TOOL_KIND_NO_FIT"]/*'/>
    DWRITE_PANOSE_TOOL_KIND_NO_FIT = 1,
    /// <include file='DWRITE_PANOSE_TOOL_KIND.xml' path='doc/member[@name="DWRITE_PANOSE_TOOL_KIND.DWRITE_PANOSE_TOOL_KIND_FLAT_NIB"]/*'/>
    DWRITE_PANOSE_TOOL_KIND_FLAT_NIB = 2,
    /// <include file='DWRITE_PANOSE_TOOL_KIND.xml' path='doc/member[@name="DWRITE_PANOSE_TOOL_KIND.DWRITE_PANOSE_TOOL_KIND_PRESSURE_POINT"]/*'/>
    DWRITE_PANOSE_TOOL_KIND_PRESSURE_POINT = 3,
    /// <include file='DWRITE_PANOSE_TOOL_KIND.xml' path='doc/member[@name="DWRITE_PANOSE_TOOL_KIND.DWRITE_PANOSE_TOOL_KIND_ENGRAVED"]/*'/>
    DWRITE_PANOSE_TOOL_KIND_ENGRAVED = 4,
    /// <include file='DWRITE_PANOSE_TOOL_KIND.xml' path='doc/member[@name="DWRITE_PANOSE_TOOL_KIND.DWRITE_PANOSE_TOOL_KIND_BALL"]/*'/>
    DWRITE_PANOSE_TOOL_KIND_BALL = 5,
    /// <include file='DWRITE_PANOSE_TOOL_KIND.xml' path='doc/member[@name="DWRITE_PANOSE_TOOL_KIND.DWRITE_PANOSE_TOOL_KIND_BRUSH"]/*'/>
    DWRITE_PANOSE_TOOL_KIND_BRUSH = 6,
    /// <include file='DWRITE_PANOSE_TOOL_KIND.xml' path='doc/member[@name="DWRITE_PANOSE_TOOL_KIND.DWRITE_PANOSE_TOOL_KIND_ROUGH"]/*'/>
    DWRITE_PANOSE_TOOL_KIND_ROUGH = 7,
    /// <include file='DWRITE_PANOSE_TOOL_KIND.xml' path='doc/member[@name="DWRITE_PANOSE_TOOL_KIND.DWRITE_PANOSE_TOOL_KIND_FELT_PEN_BRUSH_TIP"]/*'/>
    DWRITE_PANOSE_TOOL_KIND_FELT_PEN_BRUSH_TIP = 8,
    /// <include file='DWRITE_PANOSE_TOOL_KIND.xml' path='doc/member[@name="DWRITE_PANOSE_TOOL_KIND.DWRITE_PANOSE_TOOL_KIND_WILD_BRUSH"]/*'/>
    DWRITE_PANOSE_TOOL_KIND_WILD_BRUSH = 9,
}