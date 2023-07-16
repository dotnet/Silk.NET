// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/accctrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='EXPLICIT_ACCESS_A.xml' path='doc/member[@name="EXPLICIT_ACCESS_A"]/*'/>
public partial struct EXPLICIT_ACCESS_A
{
    /// <include file='EXPLICIT_ACCESS_A.xml' path='doc/member[@name="EXPLICIT_ACCESS_A.grfAccessPermissions"]/*'/>
    [NativeTypeName("DWORD")]
    public uint grfAccessPermissions;
    /// <include file='EXPLICIT_ACCESS_A.xml' path='doc/member[@name="EXPLICIT_ACCESS_A.grfAccessMode"]/*'/>
    public ACCESS_MODE grfAccessMode;
    /// <include file='EXPLICIT_ACCESS_A.xml' path='doc/member[@name="EXPLICIT_ACCESS_A.grfInheritance"]/*'/>
    [NativeTypeName("DWORD")]
    public uint grfInheritance;
    /// <include file='EXPLICIT_ACCESS_A.xml' path='doc/member[@name="EXPLICIT_ACCESS_A.Trustee"]/*'/>
    public TRUSTEE_A Trustee;
}