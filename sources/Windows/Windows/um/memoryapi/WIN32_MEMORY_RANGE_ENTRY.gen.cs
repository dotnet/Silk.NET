// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/memoryapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;
/// <include file='WIN32_MEMORY_RANGE_ENTRY.xml' path='doc/member[@name="WIN32_MEMORY_RANGE_ENTRY"]/*'/>
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct WIN32_MEMORY_RANGE_ENTRY
{
    /// <include file='WIN32_MEMORY_RANGE_ENTRY.xml' path='doc/member[@name="WIN32_MEMORY_RANGE_ENTRY.VirtualAddress"]/*'/>
    [NativeTypeName("PVOID")]
    public void* VirtualAddress;
    /// <include file='WIN32_MEMORY_RANGE_ENTRY.xml' path='doc/member[@name="WIN32_MEMORY_RANGE_ENTRY.NumberOfBytes"]/*'/>
    [NativeTypeName("SIZE_T")]
    public nuint NumberOfBytes;
}