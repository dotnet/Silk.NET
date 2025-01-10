// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[SupportedOSPlatform("windows10.0.19041.0")]
public unsafe partial struct D3D12_FEATURE_DATA_VIDEO_EXTENSION_COMMAND_SUPPORT
{
    public uint NodeIndex;
    public Guid CommandId;

    [NativeTypeName("const void *")]
    public void* pInputData;

    [NativeTypeName("SIZE_T")]
    public nuint InputDataSizeInBytes;
    public void* pOutputData;

    [NativeTypeName("SIZE_T")]
    public nuint OutputDataSizeInBytes;
}
