// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;

namespace Silk.NET.DirectX;

/// <include file='D3D12_GRAPHICS_STATES.xml' path='doc/member[@name="D3D12_GRAPHICS_STATES"]/*'/>
[Flags]
public enum D3D12_GRAPHICS_STATES
{
    /// <include file='D3D12_GRAPHICS_STATES.xml' path='doc/member[@name="D3D12_GRAPHICS_STATES.D3D12_GRAPHICS_STATE_NONE"]/*'/>

    D3D12_GRAPHICS_STATE_NONE = 0,

    /// <include file='D3D12_GRAPHICS_STATES.xml' path='doc/member[@name="D3D12_GRAPHICS_STATES.D3D12_GRAPHICS_STATE_IA_VERTEX_BUFFERS"]/*'/>

    D3D12_GRAPHICS_STATE_IA_VERTEX_BUFFERS = (1 << 0),

    /// <include file='D3D12_GRAPHICS_STATES.xml' path='doc/member[@name="D3D12_GRAPHICS_STATES.D3D12_GRAPHICS_STATE_IA_INDEX_BUFFER"]/*'/>

    D3D12_GRAPHICS_STATE_IA_INDEX_BUFFER = (1 << 1),

    /// <include file='D3D12_GRAPHICS_STATES.xml' path='doc/member[@name="D3D12_GRAPHICS_STATES.D3D12_GRAPHICS_STATE_IA_PRIMITIVE_TOPOLOGY"]/*'/>

    D3D12_GRAPHICS_STATE_IA_PRIMITIVE_TOPOLOGY = (1 << 2),

    /// <include file='D3D12_GRAPHICS_STATES.xml' path='doc/member[@name="D3D12_GRAPHICS_STATES.D3D12_GRAPHICS_STATE_DESCRIPTOR_HEAP"]/*'/>

    D3D12_GRAPHICS_STATE_DESCRIPTOR_HEAP = (1 << 3),

    /// <include file='D3D12_GRAPHICS_STATES.xml' path='doc/member[@name="D3D12_GRAPHICS_STATES.D3D12_GRAPHICS_STATE_GRAPHICS_ROOT_SIGNATURE"]/*'/>

    D3D12_GRAPHICS_STATE_GRAPHICS_ROOT_SIGNATURE = (1 << 4),

    /// <include file='D3D12_GRAPHICS_STATES.xml' path='doc/member[@name="D3D12_GRAPHICS_STATES.D3D12_GRAPHICS_STATE_COMPUTE_ROOT_SIGNATURE"]/*'/>

    D3D12_GRAPHICS_STATE_COMPUTE_ROOT_SIGNATURE = (1 << 5),

    /// <include file='D3D12_GRAPHICS_STATES.xml' path='doc/member[@name="D3D12_GRAPHICS_STATES.D3D12_GRAPHICS_STATE_RS_VIEWPORTS"]/*'/>

    D3D12_GRAPHICS_STATE_RS_VIEWPORTS = (1 << 6),

    /// <include file='D3D12_GRAPHICS_STATES.xml' path='doc/member[@name="D3D12_GRAPHICS_STATES.D3D12_GRAPHICS_STATE_RS_SCISSOR_RECTS"]/*'/>

    D3D12_GRAPHICS_STATE_RS_SCISSOR_RECTS = (1 << 7),

    /// <include file='D3D12_GRAPHICS_STATES.xml' path='doc/member[@name="D3D12_GRAPHICS_STATES.D3D12_GRAPHICS_STATE_PREDICATION"]/*'/>

    D3D12_GRAPHICS_STATE_PREDICATION = (1 << 8),

    /// <include file='D3D12_GRAPHICS_STATES.xml' path='doc/member[@name="D3D12_GRAPHICS_STATES.D3D12_GRAPHICS_STATE_OM_RENDER_TARGETS"]/*'/>

    D3D12_GRAPHICS_STATE_OM_RENDER_TARGETS = (1 << 9),

    /// <include file='D3D12_GRAPHICS_STATES.xml' path='doc/member[@name="D3D12_GRAPHICS_STATES.D3D12_GRAPHICS_STATE_OM_STENCIL_REF"]/*'/>

    D3D12_GRAPHICS_STATE_OM_STENCIL_REF = (1 << 10),

    /// <include file='D3D12_GRAPHICS_STATES.xml' path='doc/member[@name="D3D12_GRAPHICS_STATES.D3D12_GRAPHICS_STATE_OM_BLEND_FACTOR"]/*'/>

    D3D12_GRAPHICS_STATE_OM_BLEND_FACTOR = (1 << 11),

    /// <include file='D3D12_GRAPHICS_STATES.xml' path='doc/member[@name="D3D12_GRAPHICS_STATES.D3D12_GRAPHICS_STATE_PIPELINE_STATE"]/*'/>

    D3D12_GRAPHICS_STATE_PIPELINE_STATE = (1 << 12),

    /// <include file='D3D12_GRAPHICS_STATES.xml' path='doc/member[@name="D3D12_GRAPHICS_STATES.D3D12_GRAPHICS_STATE_SO_TARGETS"]/*'/>

    D3D12_GRAPHICS_STATE_SO_TARGETS = (1 << 13),

    /// <include file='D3D12_GRAPHICS_STATES.xml' path='doc/member[@name="D3D12_GRAPHICS_STATES.D3D12_GRAPHICS_STATE_OM_DEPTH_BOUNDS"]/*'/>

    D3D12_GRAPHICS_STATE_OM_DEPTH_BOUNDS = (1 << 14),

    /// <include file='D3D12_GRAPHICS_STATES.xml' path='doc/member[@name="D3D12_GRAPHICS_STATES.D3D12_GRAPHICS_STATE_SAMPLE_POSITIONS"]/*'/>

    D3D12_GRAPHICS_STATE_SAMPLE_POSITIONS = (1 << 15),

    /// <include file='D3D12_GRAPHICS_STATES.xml' path='doc/member[@name="D3D12_GRAPHICS_STATES.D3D12_GRAPHICS_STATE_VIEW_INSTANCE_MASK"]/*'/>

    D3D12_GRAPHICS_STATE_VIEW_INSTANCE_MASK = (1 << 16),
}
