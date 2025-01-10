// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static partial class D3D9_RESOURCE_PRIORITY
{
    [NativeTypeName("#define D3D9_RESOURCE_PRIORITY_MINIMUM 0x28000000")]
    public const int D3D9_RESOURCE_PRIORITY_MINIMUM = 0x28000000;

    [NativeTypeName("#define D3D9_RESOURCE_PRIORITY_LOW 0x50000000")]
    public const int D3D9_RESOURCE_PRIORITY_LOW = 0x50000000;

    [NativeTypeName("#define D3D9_RESOURCE_PRIORITY_NORMAL 0x78000000")]
    public const int D3D9_RESOURCE_PRIORITY_NORMAL = 0x78000000;

    [NativeTypeName("#define D3D9_RESOURCE_PRIORITY_HIGH 0xa0000000")]
    public const uint D3D9_RESOURCE_PRIORITY_HIGH = 0xa0000000;

    [NativeTypeName("#define D3D9_RESOURCE_PRIORITY_MAXIMUM 0xc8000000")]
    public const uint D3D9_RESOURCE_PRIORITY_MAXIMUM = 0xc8000000;
}
