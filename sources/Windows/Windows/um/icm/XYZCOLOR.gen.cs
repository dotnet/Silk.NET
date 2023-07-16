// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/icm.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='XYZCOLOR.xml' path='doc/member[@name="XYZCOLOR"]/*'/>
public partial struct XYZCOLOR
{
    /// <include file='XYZCOLOR.xml' path='doc/member[@name="XYZCOLOR.X"]/*'/>
    [NativeTypeName("WORD")]
    public ushort X;
    /// <include file='XYZCOLOR.xml' path='doc/member[@name="XYZCOLOR.Y"]/*'/>
    [NativeTypeName("WORD")]
    public ushort Y;
    /// <include file='XYZCOLOR.xml' path='doc/member[@name="XYZCOLOR.Z"]/*'/>
    [NativeTypeName("WORD")]
    public ushort Z;
}