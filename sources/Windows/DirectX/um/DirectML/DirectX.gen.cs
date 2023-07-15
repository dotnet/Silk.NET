// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/DirectML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;
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
    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.DMLCreateDevice"]/*'/>
    [DllImport("directml", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0")]
    public static extern HRESULT DMLCreateDevice(ID3D12Device* d3d12Device, DML_CREATE_DEVICE_FLAGS flags, [NativeTypeName("const IID &")] Guid* riid, void** ppv);
    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.DMLCreateDevice1"]/*'/>
    [DllImport("directml", ExactSpelling = true)]
    public static extern HRESULT DMLCreateDevice1(ID3D12Device* d3d12Device, DML_CREATE_DEVICE_FLAGS flags, DML_FEATURE_LEVEL minimumFeatureLevel, [NativeTypeName("const IID &")] Guid* riid, void** ppv);
    [NativeTypeName("#define DML_TARGET_VERSION 0x4000")]
    public const int DML_TARGET_VERSION = 0x4000;
}