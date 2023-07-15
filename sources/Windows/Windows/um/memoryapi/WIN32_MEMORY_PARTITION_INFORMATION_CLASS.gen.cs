// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/memoryapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='WIN32_MEMORY_PARTITION_INFORMATION_CLASS.xml' path='doc/member[@name="WIN32_MEMORY_PARTITION_INFORMATION_CLASS"]/*'/>
public enum WIN32_MEMORY_PARTITION_INFORMATION_CLASS
{
    /// <include file='WIN32_MEMORY_PARTITION_INFORMATION_CLASS.xml' path='doc/member[@name="WIN32_MEMORY_PARTITION_INFORMATION_CLASS.MemoryPartitionInfo"]/*'/>
    MemoryPartitionInfo,
    /// <include file='WIN32_MEMORY_PARTITION_INFORMATION_CLASS.xml' path='doc/member[@name="WIN32_MEMORY_PARTITION_INFORMATION_CLASS.MemoryPartitionDedicatedMemoryInfo"]/*'/>
    MemoryPartitionDedicatedMemoryInfo,
}