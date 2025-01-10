// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("2CD906C1-12E2-11DC-9FED-001143A055F9")]
[NativeTypeName("struct ID2D1TessellationSink : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID2D1TessellationSink : ID2D1TessellationSink.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1TessellationSink));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID2D1TessellationSink, Guid*, void**, int>)((*lpVtbl)[0]))(
            this,
            riid,
            ppvObject
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ID2D1TessellationSink, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID2D1TessellationSink, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void AddTriangles(
        [NativeTypeName("const D2D1_TRIANGLE *")] D2D1_TRIANGLE* triangles,
        [NativeTypeName("UINT32")] uint trianglesCount
    )
    {
        ((delegate* unmanaged<ID2D1TessellationSink, D2D1_TRIANGLE*, uint, void>)((*lpVtbl)[3]))(
            this,
            triangles,
            trianglesCount
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Close()
    {
        return ((delegate* unmanaged<ID2D1TessellationSink, int>)((*lpVtbl)[4]))(this);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        void AddTriangles(
            [NativeTypeName("const D2D1_TRIANGLE *")] D2D1_TRIANGLE* triangles,
            [NativeTypeName("UINT32")] uint trianglesCount
        );

        [VtblIndex(4)]
        HRESULT Close();
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> Release;

        [NativeTypeName(
            "void (const D2D1_TRIANGLE *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D2D1_TRIANGLE*, uint, void> AddTriangles;

        [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Close;
    }

    /// <summary>Initializes a new instance of the <see cref = "ID2D1TessellationSink"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID2D1TessellationSink(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ID2D1TessellationSink"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ID2D1TessellationSink(Silk.NET.Windows.IUnknown value)
    {
        return new ID2D1TessellationSink(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID2D1TessellationSink"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ID2D1TessellationSink"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ID2D1TessellationSink value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
