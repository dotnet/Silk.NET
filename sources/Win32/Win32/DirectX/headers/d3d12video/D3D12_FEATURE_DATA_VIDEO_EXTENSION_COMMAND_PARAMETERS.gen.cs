// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
using System.Runtime.Versioning;

namespace Silk.NET.DirectX;

/// <include file='D3D12_FEATURE_DATA_VIDEO_EXTENSION_COMMAND_PARAMETERS.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_EXTENSION_COMMAND_PARAMETERS"]/*'/>
[SupportedOSPlatform("windows10.0.19041.0")]
public unsafe partial struct D3D12_FEATURE_DATA_VIDEO_EXTENSION_COMMAND_PARAMETERS
{
    /// <include file='D3D12_FEATURE_DATA_VIDEO_EXTENSION_COMMAND_PARAMETERS.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_EXTENSION_COMMAND_PARAMETERS.CommandId"]/*'/>

    public Guid CommandId;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_EXTENSION_COMMAND_PARAMETERS.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_EXTENSION_COMMAND_PARAMETERS.Stage"]/*'/>

    public D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_STAGE Stage;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_EXTENSION_COMMAND_PARAMETERS.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_EXTENSION_COMMAND_PARAMETERS.ParameterCount"]/*'/>

    public uint ParameterCount;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_EXTENSION_COMMAND_PARAMETERS.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_EXTENSION_COMMAND_PARAMETERS.pParameterInfos"]/*'/>

    public D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_INFO* pParameterInfos;
}
