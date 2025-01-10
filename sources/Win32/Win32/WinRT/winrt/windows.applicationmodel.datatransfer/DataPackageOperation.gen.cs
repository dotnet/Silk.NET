// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.applicationmodel.datatransfer.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[NativeTypeName("unsigned int")]
public enum DataPackageOperation : uint
{
    DataPackageOperation_None = 0,
    DataPackageOperation_Copy = 0x1,
    DataPackageOperation_Move = 0x2,
    DataPackageOperation_Link = 0x4,
}
