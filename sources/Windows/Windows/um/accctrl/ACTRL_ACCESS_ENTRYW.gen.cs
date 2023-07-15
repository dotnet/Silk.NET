// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/accctrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='ACTRL_ACCESS_ENTRYW.xml' path='doc/member[@name="ACTRL_ACCESS_ENTRYW"]/*'/>
public unsafe partial struct ACTRL_ACCESS_ENTRYW
{
    /// <include file='ACTRL_ACCESS_ENTRYW.xml' path='doc/member[@name="ACTRL_ACCESS_ENTRYW.Trustee"]/*'/>
    public TRUSTEE_W Trustee;
    /// <include file='ACTRL_ACCESS_ENTRYW.xml' path='doc/member[@name="ACTRL_ACCESS_ENTRYW.fAccessFlags"]/*'/>
    [NativeTypeName("ULONG")]
    public uint fAccessFlags;
    /// <include file='ACTRL_ACCESS_ENTRYW.xml' path='doc/member[@name="ACTRL_ACCESS_ENTRYW.Access"]/*'/>
    [NativeTypeName("ACCESS_RIGHTS")]
    public uint Access;
    /// <include file='ACTRL_ACCESS_ENTRYW.xml' path='doc/member[@name="ACTRL_ACCESS_ENTRYW.ProvSpecificAccess"]/*'/>
    [NativeTypeName("ACCESS_RIGHTS")]
    public uint ProvSpecificAccess;
    /// <include file='ACTRL_ACCESS_ENTRYW.xml' path='doc/member[@name="ACTRL_ACCESS_ENTRYW.Inheritance"]/*'/>
    [NativeTypeName("INHERIT_FLAGS")]
    public uint Inheritance;
    /// <include file='ACTRL_ACCESS_ENTRYW.xml' path='doc/member[@name="ACTRL_ACCESS_ENTRYW.lpInheritProperty"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* lpInheritProperty;
}