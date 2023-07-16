// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='IMAGEINFO.xml' path='doc/member[@name="IMAGEINFO"]/*'/>
public partial struct IMAGEINFO
{
    /// <include file='IMAGEINFO.xml' path='doc/member[@name="IMAGEINFO.hbmImage"]/*'/>
    public HBITMAP hbmImage;
    /// <include file='IMAGEINFO.xml' path='doc/member[@name="IMAGEINFO.hbmMask"]/*'/>
    public HBITMAP hbmMask;
    /// <include file='IMAGEINFO.xml' path='doc/member[@name="IMAGEINFO.Unused1"]/*'/>
    public int Unused1;
    /// <include file='IMAGEINFO.xml' path='doc/member[@name="IMAGEINFO.Unused2"]/*'/>
    public int Unused2;
    /// <include file='IMAGEINFO.xml' path='doc/member[@name="IMAGEINFO.rcImage"]/*'/>
    public RECT rcImage;
}