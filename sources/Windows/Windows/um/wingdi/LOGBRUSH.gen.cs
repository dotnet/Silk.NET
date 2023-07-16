// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='LOGBRUSH.xml' path='doc/member[@name="LOGBRUSH"]/*'/>
public partial struct LOGBRUSH
{
    /// <include file='LOGBRUSH.xml' path='doc/member[@name="LOGBRUSH.lbStyle"]/*'/>
    public uint lbStyle;
    /// <include file='LOGBRUSH.xml' path='doc/member[@name="LOGBRUSH.lbColor"]/*'/>
    public COLORREF lbColor;
    /// <include file='LOGBRUSH.xml' path='doc/member[@name="LOGBRUSH.lbHatch"]/*'/>
    [NativeTypeName("ULONG_PTR")]
    public nuint lbHatch;
}