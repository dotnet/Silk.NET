// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/accctrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='EXPLICIT_ACCESS_W.xml' path='doc/member[@name="EXPLICIT_ACCESS_W"]/*'/>
public partial struct EXPLICIT_ACCESS_W
{
    /// <include file='EXPLICIT_ACCESS_W.xml' path='doc/member[@name="EXPLICIT_ACCESS_W.grfAccessPermissions"]/*'/>
    [NativeTypeName("DWORD")]
    public uint grfAccessPermissions;
    /// <include file='EXPLICIT_ACCESS_W.xml' path='doc/member[@name="EXPLICIT_ACCESS_W.grfAccessMode"]/*'/>
    public ACCESS_MODE grfAccessMode;
    /// <include file='EXPLICIT_ACCESS_W.xml' path='doc/member[@name="EXPLICIT_ACCESS_W.grfInheritance"]/*'/>
    [NativeTypeName("DWORD")]
    public uint grfInheritance;
    /// <include file='EXPLICIT_ACCESS_W.xml' path='doc/member[@name="EXPLICIT_ACCESS_W.Trustee"]/*'/>
    public TRUSTEE_W Trustee;
}