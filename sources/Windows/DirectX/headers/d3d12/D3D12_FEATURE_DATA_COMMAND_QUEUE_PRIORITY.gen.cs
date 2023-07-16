// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
using Silk.NET.Windows;

namespace Silk.NET.DirectX;
/// <include file='D3D12_FEATURE_DATA_COMMAND_QUEUE_PRIORITY.xml' path='doc/member[@name="D3D12_FEATURE_DATA_COMMAND_QUEUE_PRIORITY"]/*'/>
public partial struct D3D12_FEATURE_DATA_COMMAND_QUEUE_PRIORITY
{
    /// <include file='D3D12_FEATURE_DATA_COMMAND_QUEUE_PRIORITY.xml' path='doc/member[@name="D3D12_FEATURE_DATA_COMMAND_QUEUE_PRIORITY.CommandListType"]/*'/>
    public D3D12_COMMAND_LIST_TYPE CommandListType;
    /// <include file='D3D12_FEATURE_DATA_COMMAND_QUEUE_PRIORITY.xml' path='doc/member[@name="D3D12_FEATURE_DATA_COMMAND_QUEUE_PRIORITY.Priority"]/*'/>
    public uint Priority;
    /// <include file='D3D12_FEATURE_DATA_COMMAND_QUEUE_PRIORITY.xml' path='doc/member[@name="D3D12_FEATURE_DATA_COMMAND_QUEUE_PRIORITY.PriorityForTypeIsSupported"]/*'/>
    public BOOL PriorityForTypeIsSupported;
}