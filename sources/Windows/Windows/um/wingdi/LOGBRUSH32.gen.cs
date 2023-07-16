// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='LOGBRUSH32.xml' path='doc/member[@name="LOGBRUSH32"]/*'/>
public partial struct LOGBRUSH32
{
    /// <include file='LOGBRUSH32.xml' path='doc/member[@name="LOGBRUSH32.lbStyle"]/*'/>
    public uint lbStyle;
    /// <include file='LOGBRUSH32.xml' path='doc/member[@name="LOGBRUSH32.lbColor"]/*'/>
    public COLORREF lbColor;
    /// <include file='LOGBRUSH32.xml' path='doc/member[@name="LOGBRUSH32.lbHatch"]/*'/>
    [NativeTypeName("ULONG")]
    public uint lbHatch;
}