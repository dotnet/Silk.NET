// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='WCRANGE.xml' path='doc/member[@name="WCRANGE"]/*'/>
public partial struct WCRANGE
{
    /// <include file='WCRANGE.xml' path='doc/member[@name="WCRANGE.wcLow"]/*'/>
    [NativeTypeName("WCHAR")]
    public ushort wcLow;
    /// <include file='WCRANGE.xml' path='doc/member[@name="WCRANGE.cGlyphs"]/*'/>
    public ushort cGlyphs;
}