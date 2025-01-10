// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct D3D12_SET_PROGRAM_DESC
{
    public D3D12_PROGRAM_TYPE Type;

    [NativeTypeName("__AnonymousRecord_d3d12_L20978_C5")]
    public _Anonymous_e__Union Anonymous;

    [UnscopedRef]
    public ref D3D12_SET_GENERIC_PIPELINE_DESC GenericPipeline
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.GenericPipeline; }
    }

    [UnscopedRef]
    public ref D3D12_SET_RAYTRACING_PIPELINE_DESC RaytracingPipeline
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.RaytracingPipeline; }
    }

    [UnscopedRef]
    public ref D3D12_SET_WORK_GRAPH_DESC WorkGraph
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.WorkGraph; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public D3D12_SET_GENERIC_PIPELINE_DESC GenericPipeline;

        [FieldOffset(0)]
        public D3D12_SET_RAYTRACING_PIPELINE_DESC RaytracingPipeline;

        [FieldOffset(0)]
        public D3D12_SET_WORK_GRAPH_DESC WorkGraph;
    }
}
