// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='SE_SECURITY_DESCRIPTOR.xml' path='doc/member[@name="SE_SECURITY_DESCRIPTOR"]/*'/>
public unsafe partial struct SE_SECURITY_DESCRIPTOR
{
    /// <include file='SE_SECURITY_DESCRIPTOR.xml' path='doc/member[@name="SE_SECURITY_DESCRIPTOR.Size"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Size;
    /// <include file='SE_SECURITY_DESCRIPTOR.xml' path='doc/member[@name="SE_SECURITY_DESCRIPTOR.Flags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Flags;
    /// <include file='SE_SECURITY_DESCRIPTOR.xml' path='doc/member[@name="SE_SECURITY_DESCRIPTOR.SecurityDescriptor"]/*'/>
    [NativeTypeName("PSECURITY_DESCRIPTOR")]
    public void* SecurityDescriptor;
}