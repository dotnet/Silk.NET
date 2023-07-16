// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi1_2.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.DirectX;
public static partial class DXGI
{
    [NativeTypeName("#define DXGI_ENUM_MODES_STEREO ( 4UL )")]
    public const uint DXGI_ENUM_MODES_STEREO = (4U);
    [NativeTypeName("#define DXGI_ENUM_MODES_DISABLED_STEREO ( 8UL )")]
    public const uint DXGI_ENUM_MODES_DISABLED_STEREO = (8U);
    [NativeTypeName("#define DXGI_SHARED_RESOURCE_READ ( 0x80000000L )")]
    public const uint DXGI_SHARED_RESOURCE_READ = (0x80000000);
    [NativeTypeName("#define DXGI_SHARED_RESOURCE_WRITE ( 1 )")]
    public const int DXGI_SHARED_RESOURCE_WRITE = (1);
}