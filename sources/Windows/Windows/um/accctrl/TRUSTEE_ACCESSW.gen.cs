// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/accctrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='TRUSTEE_ACCESSW.xml' path='doc/member[@name="TRUSTEE_ACCESSW"]/*'/>
public unsafe partial struct TRUSTEE_ACCESSW
{
    /// <include file='TRUSTEE_ACCESSW.xml' path='doc/member[@name="TRUSTEE_ACCESSW.lpProperty"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* lpProperty;
    /// <include file='TRUSTEE_ACCESSW.xml' path='doc/member[@name="TRUSTEE_ACCESSW.Access"]/*'/>
    [NativeTypeName("ACCESS_RIGHTS")]
    public uint Access;
    /// <include file='TRUSTEE_ACCESSW.xml' path='doc/member[@name="TRUSTEE_ACCESSW.fAccessFlags"]/*'/>
    [NativeTypeName("ULONG")]
    public uint fAccessFlags;
    /// <include file='TRUSTEE_ACCESSW.xml' path='doc/member[@name="TRUSTEE_ACCESSW.fReturnedAccess"]/*'/>
    [NativeTypeName("ULONG")]
    public uint fReturnedAccess;
}