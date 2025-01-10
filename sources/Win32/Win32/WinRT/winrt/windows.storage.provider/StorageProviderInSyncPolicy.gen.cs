// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.storage.provider.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[NativeTypeName("unsigned int")]
public enum StorageProviderInSyncPolicy : uint
{
    StorageProviderInSyncPolicy_Default = 0,
    StorageProviderInSyncPolicy_FileCreationTime = 0x1,
    StorageProviderInSyncPolicy_FileReadOnlyAttribute = 0x2,
    StorageProviderInSyncPolicy_FileHiddenAttribute = 0x4,
    StorageProviderInSyncPolicy_FileSystemAttribute = 0x8,
    StorageProviderInSyncPolicy_DirectoryCreationTime = 0x10,
    StorageProviderInSyncPolicy_DirectoryReadOnlyAttribute = 0x20,
    StorageProviderInSyncPolicy_DirectoryHiddenAttribute = 0x40,
    StorageProviderInSyncPolicy_DirectorySystemAttribute = 0x80,
    StorageProviderInSyncPolicy_FileLastWriteTime = 0x100,
    StorageProviderInSyncPolicy_DirectoryLastWriteTime = 0x200,
    StorageProviderInSyncPolicy_PreserveInsyncForSyncEngine = 0x80000000,
}
