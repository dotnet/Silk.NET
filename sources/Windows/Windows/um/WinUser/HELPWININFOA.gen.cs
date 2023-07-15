// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='HELPWININFOA.xml' path='doc/member[@name="HELPWININFOA"]/*'/>
public unsafe partial struct HELPWININFOA
{
    /// <include file='HELPWININFOA.xml' path='doc/member[@name="HELPWININFOA.wStructSize"]/*'/>
    public int wStructSize;
    /// <include file='HELPWININFOA.xml' path='doc/member[@name="HELPWININFOA.x"]/*'/>
    public int x;
    /// <include file='HELPWININFOA.xml' path='doc/member[@name="HELPWININFOA.y"]/*'/>
    public int y;
    /// <include file='HELPWININFOA.xml' path='doc/member[@name="HELPWININFOA.dx"]/*'/>
    public int dx;
    /// <include file='HELPWININFOA.xml' path='doc/member[@name="HELPWININFOA.dy"]/*'/>
    public int dy;
    /// <include file='HELPWININFOA.xml' path='doc/member[@name="HELPWININFOA.wMax"]/*'/>
    public int wMax;
    /// <include file='HELPWININFOA.xml' path='doc/member[@name="HELPWININFOA.rgchMember"]/*'/>
    [NativeTypeName("CHAR[2]")]
    public fixed sbyte rgchMember[2];
}