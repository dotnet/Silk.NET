// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from DirectML.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Silk.NET.Windows;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static unsafe partial class DirectX
{
    [NativeTypeName("const UINT")]
    public const uint DML_TENSOR_DIMENSION_COUNT_MAX = 5;

    [NativeTypeName("const UINT")]
    public const uint DML_TENSOR_DIMENSION_COUNT_MAX1 = 8;

    [NativeTypeName("const UINT")]
    public const uint DML_TEMPORARY_BUFFER_ALIGNMENT = 256;

    [NativeTypeName("const UINT")]
    public const uint DML_PERSISTENT_BUFFER_ALIGNMENT = 256;

    [NativeTypeName("const UINT")]
    public const uint DML_MINIMUM_BUFFER_TENSOR_ALIGNMENT = 16;

    [DllImport("directml", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0")]
    public static extern HRESULT DMLCreateDevice(
        ID3D12Device d3d12Device,
        DML_CREATE_DEVICE_FLAGS flags,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppv
    );

    [DllImport("directml", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0.19043.0")]
    public static extern HRESULT DMLCreateDevice1(
        ID3D12Device d3d12Device,
        DML_CREATE_DEVICE_FLAGS flags,
        DML_FEATURE_LEVEL minimumFeatureLevel,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppv
    );

    [NativeTypeName("#define DML_TARGET_VERSION 0x5000")]
    public const int DML_TARGET_VERSION = 0x5000;
}
