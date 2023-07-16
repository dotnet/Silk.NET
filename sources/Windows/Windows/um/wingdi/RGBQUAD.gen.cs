// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='RGBQUAD.xml' path='doc/member[@name="RGBQUAD"]/*'/>
public partial struct RGBQUAD
{
    /// <include file='RGBQUAD.xml' path='doc/member[@name="RGBQUAD.rgbBlue"]/*'/>
    public byte rgbBlue;
    /// <include file='RGBQUAD.xml' path='doc/member[@name="RGBQUAD.rgbGreen"]/*'/>
    public byte rgbGreen;
    /// <include file='RGBQUAD.xml' path='doc/member[@name="RGBQUAD.rgbRed"]/*'/>
    public byte rgbRed;
    /// <include file='RGBQUAD.xml' path='doc/member[@name="RGBQUAD.rgbReserved"]/*'/>
    public byte rgbReserved;
}