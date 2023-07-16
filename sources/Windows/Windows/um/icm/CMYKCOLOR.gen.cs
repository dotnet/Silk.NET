// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/icm.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='CMYKCOLOR.xml' path='doc/member[@name="CMYKCOLOR"]/*'/>
public partial struct CMYKCOLOR
{
    /// <include file='CMYKCOLOR.xml' path='doc/member[@name="CMYKCOLOR.cyan"]/*'/>
    [NativeTypeName("WORD")]
    public ushort cyan;
    /// <include file='CMYKCOLOR.xml' path='doc/member[@name="CMYKCOLOR.magenta"]/*'/>
    [NativeTypeName("WORD")]
    public ushort magenta;
    /// <include file='CMYKCOLOR.xml' path='doc/member[@name="CMYKCOLOR.yellow"]/*'/>
    [NativeTypeName("WORD")]
    public ushort yellow;
    /// <include file='CMYKCOLOR.xml' path='doc/member[@name="CMYKCOLOR.black"]/*'/>
    [NativeTypeName("WORD")]
    public ushort black;
}