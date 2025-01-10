// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.storage.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[NativeTypeName("unsigned int")]
public enum FileAttributes : uint
{
    FileAttributes_Normal = 0,
    FileAttributes_ReadOnly = 0x1,
    FileAttributes_Directory = 0x10,
    FileAttributes_Archive = 0x20,
    FileAttributes_Temporary = 0x100,
    FileAttributes_LocallyIncomplete = 0x200,
}
