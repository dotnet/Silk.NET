// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlObj.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='AASHELLMENUFILENAME.xml' path='doc/member[@name="AASHELLMENUFILENAME"]/*'/>
public unsafe partial struct AASHELLMENUFILENAME
{
    /// <include file='AASHELLMENUFILENAME.xml' path='doc/member[@name="AASHELLMENUFILENAME.cbTotal"]/*'/>
    public short cbTotal;
    /// <include file='AASHELLMENUFILENAME.xml' path='doc/member[@name="AASHELLMENUFILENAME.rgbReserved"]/*'/>
    [NativeTypeName("BYTE[12]")]
    public fixed byte rgbReserved[12];
    /// <include file='AASHELLMENUFILENAME.xml' path='doc/member[@name="AASHELLMENUFILENAME.szFileName"]/*'/>
    [NativeTypeName("WCHAR[1]")]
    public fixed ushort szFileName[1];
}