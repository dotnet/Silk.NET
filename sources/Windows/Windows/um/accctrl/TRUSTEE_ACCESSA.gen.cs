// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/accctrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='TRUSTEE_ACCESSA.xml' path='doc/member[@name="TRUSTEE_ACCESSA"]/*'/>
public unsafe partial struct TRUSTEE_ACCESSA
{
    /// <include file='TRUSTEE_ACCESSA.xml' path='doc/member[@name="TRUSTEE_ACCESSA.lpProperty"]/*'/>
    [NativeTypeName("LPSTR")]
    public sbyte* lpProperty;
    /// <include file='TRUSTEE_ACCESSA.xml' path='doc/member[@name="TRUSTEE_ACCESSA.Access"]/*'/>
    [NativeTypeName("ACCESS_RIGHTS")]
    public uint Access;
    /// <include file='TRUSTEE_ACCESSA.xml' path='doc/member[@name="TRUSTEE_ACCESSA.fAccessFlags"]/*'/>
    [NativeTypeName("ULONG")]
    public uint fAccessFlags;
    /// <include file='TRUSTEE_ACCESSA.xml' path='doc/member[@name="TRUSTEE_ACCESSA.fReturnedAccess"]/*'/>
    [NativeTypeName("ULONG")]
    public uint fReturnedAccess;
}