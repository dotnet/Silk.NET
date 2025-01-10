// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("56A868BF-0AD4-11CE-B03A-0020AF0BA770")]
[NativeTypeName("struct IStreamBuilder : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IStreamBuilder : IStreamBuilder.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IStreamBuilder));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IStreamBuilder, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IStreamBuilder, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IStreamBuilder, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Render(IPin ppinOut, IGraphBuilder pGraph)
    {
        return ((delegate* unmanaged<IStreamBuilder, IPin, IGraphBuilder, int>)((*lpVtbl)[3]))(
            this,
            ppinOut,
            pGraph
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Backout(IPin ppinOut, IGraphBuilder pGraph)
    {
        return ((delegate* unmanaged<IStreamBuilder, IPin, IGraphBuilder, int>)((*lpVtbl)[4]))(
            this,
            ppinOut,
            pGraph
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Render(IPin ppinOut, IGraphBuilder pGraph);

        [VtblIndex(4)]
        HRESULT Backout(IPin ppinOut, IGraphBuilder pGraph);
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

        [NativeTypeName("HRESULT (IPin *, IGraphBuilder *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IPin, IGraphBuilder, int> Render;

        [NativeTypeName("HRESULT (IPin *, IGraphBuilder *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IPin, IGraphBuilder, int> Backout;
    }

    /// <summary>Initializes a new instance of the <see cref = "IStreamBuilder"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IStreamBuilder(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IStreamBuilder"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IStreamBuilder(Silk.NET.Windows.IUnknown value)
    {
        return new IStreamBuilder(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IStreamBuilder"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IStreamBuilder"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IStreamBuilder value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
