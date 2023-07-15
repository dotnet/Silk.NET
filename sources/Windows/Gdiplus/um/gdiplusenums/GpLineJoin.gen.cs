// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/gdiplusenums.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Gdiplus;
/// <include file='GpLineJoin.xml' path='doc/member[@name="GpLineJoin"]/*'/>
public enum GpLineJoin
{
    /// <include file='GpLineJoin.xml' path='doc/member[@name="GpLineJoin.LineJoinMiter"]/*'/>
    LineJoinMiter = 0,
    /// <include file='GpLineJoin.xml' path='doc/member[@name="GpLineJoin.LineJoinBevel"]/*'/>
    LineJoinBevel = 1,
    /// <include file='GpLineJoin.xml' path='doc/member[@name="GpLineJoin.LineJoinRound"]/*'/>
    LineJoinRound = 2,
    /// <include file='GpLineJoin.xml' path='doc/member[@name="GpLineJoin.LineJoinMiterClipped"]/*'/>
    LineJoinMiterClipped = 3,
}