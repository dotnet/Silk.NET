// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/accctrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='ACTRL_ACCESS_ENTRYA.xml' path='doc/member[@name="ACTRL_ACCESS_ENTRYA"]/*'/>
public unsafe partial struct ACTRL_ACCESS_ENTRYA
{
    /// <include file='ACTRL_ACCESS_ENTRYA.xml' path='doc/member[@name="ACTRL_ACCESS_ENTRYA.Trustee"]/*'/>
    public TRUSTEE_A Trustee;
    /// <include file='ACTRL_ACCESS_ENTRYA.xml' path='doc/member[@name="ACTRL_ACCESS_ENTRYA.fAccessFlags"]/*'/>
    [NativeTypeName("ULONG")]
    public uint fAccessFlags;
    /// <include file='ACTRL_ACCESS_ENTRYA.xml' path='doc/member[@name="ACTRL_ACCESS_ENTRYA.Access"]/*'/>
    [NativeTypeName("ACCESS_RIGHTS")]
    public uint Access;
    /// <include file='ACTRL_ACCESS_ENTRYA.xml' path='doc/member[@name="ACTRL_ACCESS_ENTRYA.ProvSpecificAccess"]/*'/>
    [NativeTypeName("ACCESS_RIGHTS")]
    public uint ProvSpecificAccess;
    /// <include file='ACTRL_ACCESS_ENTRYA.xml' path='doc/member[@name="ACTRL_ACCESS_ENTRYA.Inheritance"]/*'/>
    [NativeTypeName("INHERIT_FLAGS")]
    public uint Inheritance;
    /// <include file='ACTRL_ACCESS_ENTRYA.xml' path='doc/member[@name="ACTRL_ACCESS_ENTRYA.lpInheritProperty"]/*'/>
    [NativeTypeName("LPSTR")]
    public sbyte* lpInheritProperty;
}