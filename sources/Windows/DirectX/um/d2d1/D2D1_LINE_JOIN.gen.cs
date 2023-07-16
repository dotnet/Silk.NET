// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.DirectX;
/// <include file='D2D1_LINE_JOIN.xml' path='doc/member[@name="D2D1_LINE_JOIN"]/*'/>
public enum D2D1_LINE_JOIN
{
    /// <include file='D2D1_LINE_JOIN.xml' path='doc/member[@name="D2D1_LINE_JOIN.D2D1_LINE_JOIN_MITER"]/*'/>
    D2D1_LINE_JOIN_MITER = 0,
    /// <include file='D2D1_LINE_JOIN.xml' path='doc/member[@name="D2D1_LINE_JOIN.D2D1_LINE_JOIN_BEVEL"]/*'/>
    D2D1_LINE_JOIN_BEVEL = 1,
    /// <include file='D2D1_LINE_JOIN.xml' path='doc/member[@name="D2D1_LINE_JOIN.D2D1_LINE_JOIN_ROUND"]/*'/>
    D2D1_LINE_JOIN_ROUND = 2,
    /// <include file='D2D1_LINE_JOIN.xml' path='doc/member[@name="D2D1_LINE_JOIN.D2D1_LINE_JOIN_MITER_OR_BEVEL"]/*'/>
    D2D1_LINE_JOIN_MITER_OR_BEVEL = 3,
    /// <include file='D2D1_LINE_JOIN.xml' path='doc/member[@name="D2D1_LINE_JOIN.D2D1_LINE_JOIN_FORCE_DWORD"]/*'/>
    D2D1_LINE_JOIN_FORCE_DWORD = unchecked((int)(0xffffffff)),
}