// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct D3D12_RAYTRACING_GEOMETRY_DESC
{
    public D3D12_RAYTRACING_GEOMETRY_TYPE Type;
    public D3D12_RAYTRACING_GEOMETRY_FLAGS Flags;

    [NativeTypeName("__AnonymousRecord_d3d12_L14690_C5")]
    public _Anonymous_e__Union Anonymous;

    [UnscopedRef]
    public ref D3D12_RAYTRACING_GEOMETRY_TRIANGLES_DESC Triangles
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Triangles; }
    }

    [UnscopedRef]
    public ref D3D12_RAYTRACING_GEOMETRY_AABBS_DESC AABBs
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.AABBs; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public D3D12_RAYTRACING_GEOMETRY_TRIANGLES_DESC Triangles;

        [FieldOffset(0)]
        public D3D12_RAYTRACING_GEOMETRY_AABBS_DESC AABBs;
    }
}
