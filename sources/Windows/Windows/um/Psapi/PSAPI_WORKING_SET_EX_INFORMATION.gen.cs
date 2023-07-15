// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Psapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='PSAPI_WORKING_SET_EX_INFORMATION.xml' path='doc/member[@name="PSAPI_WORKING_SET_EX_INFORMATION"]/*'/>
public unsafe partial struct PSAPI_WORKING_SET_EX_INFORMATION
{
    /// <include file='PSAPI_WORKING_SET_EX_INFORMATION.xml' path='doc/member[@name="PSAPI_WORKING_SET_EX_INFORMATION.VirtualAddress"]/*'/>
    [NativeTypeName("PVOID")]
    public void* VirtualAddress;
    /// <include file='PSAPI_WORKING_SET_EX_INFORMATION.xml' path='doc/member[@name="PSAPI_WORKING_SET_EX_INFORMATION.VirtualAttributes"]/*'/>
    public PSAPI_WORKING_SET_EX_BLOCK VirtualAttributes;
}