// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winternl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='SYSTEM_REGISTRY_QUOTA_INFORMATION.xml' path='doc/member[@name="SYSTEM_REGISTRY_QUOTA_INFORMATION"]/*'/>
public unsafe partial struct SYSTEM_REGISTRY_QUOTA_INFORMATION
{
    /// <include file='SYSTEM_REGISTRY_QUOTA_INFORMATION.xml' path='doc/member[@name="SYSTEM_REGISTRY_QUOTA_INFORMATION.RegistryQuotaAllowed"]/*'/>
    [NativeTypeName("ULONG")]
    public uint RegistryQuotaAllowed;
    /// <include file='SYSTEM_REGISTRY_QUOTA_INFORMATION.xml' path='doc/member[@name="SYSTEM_REGISTRY_QUOTA_INFORMATION.RegistryQuotaUsed"]/*'/>
    [NativeTypeName("ULONG")]
    public uint RegistryQuotaUsed;
    /// <include file='SYSTEM_REGISTRY_QUOTA_INFORMATION.xml' path='doc/member[@name="SYSTEM_REGISTRY_QUOTA_INFORMATION.Reserved1"]/*'/>
    [NativeTypeName("PVOID")]
    public void* Reserved1;
}