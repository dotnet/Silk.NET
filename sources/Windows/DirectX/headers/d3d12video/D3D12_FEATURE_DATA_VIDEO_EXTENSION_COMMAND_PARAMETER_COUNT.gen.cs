// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
using System.Runtime.Versioning;

namespace Silk.NET.DirectX;
/// <include file='D3D12_FEATURE_DATA_VIDEO_EXTENSION_COMMAND_PARAMETER_COUNT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_EXTENSION_COMMAND_PARAMETER_COUNT"]/*'/>
[SupportedOSPlatform("windows10.0.19041.0")]
public partial struct D3D12_FEATURE_DATA_VIDEO_EXTENSION_COMMAND_PARAMETER_COUNT
{
    /// <include file='D3D12_FEATURE_DATA_VIDEO_EXTENSION_COMMAND_PARAMETER_COUNT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_EXTENSION_COMMAND_PARAMETER_COUNT.CommandId"]/*'/>
    public Guid CommandId;
    /// <include file='D3D12_FEATURE_DATA_VIDEO_EXTENSION_COMMAND_PARAMETER_COUNT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_EXTENSION_COMMAND_PARAMETER_COUNT.Stage"]/*'/>
    public D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_STAGE Stage;
    /// <include file='D3D12_FEATURE_DATA_VIDEO_EXTENSION_COMMAND_PARAMETER_COUNT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_EXTENSION_COMMAND_PARAMETER_COUNT.ParameterCount"]/*'/>
    public uint ParameterCount;
    /// <include file='D3D12_FEATURE_DATA_VIDEO_EXTENSION_COMMAND_PARAMETER_COUNT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_EXTENSION_COMMAND_PARAMETER_COUNT.ParameterPacking"]/*'/>
    public uint ParameterPacking;
}