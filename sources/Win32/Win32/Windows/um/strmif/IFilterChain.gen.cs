// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("DCFBDCF6-0DC2-45F5-9AB2-7C330EA09C29")]
[NativeTypeName("struct IFilterChain : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IFilterChain : IFilterChain.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IFilterChain));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IFilterChain, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IFilterChain, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IFilterChain, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT StartChain(IBaseFilter pStartFilter, IBaseFilter pEndFilter)
    {
        return ((delegate* unmanaged<IFilterChain, IBaseFilter, IBaseFilter, int>)((*lpVtbl)[3]))(
            this,
            pStartFilter,
            pEndFilter
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT PauseChain(IBaseFilter pStartFilter, IBaseFilter pEndFilter)
    {
        return ((delegate* unmanaged<IFilterChain, IBaseFilter, IBaseFilter, int>)((*lpVtbl)[4]))(
            this,
            pStartFilter,
            pEndFilter
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT StopChain(IBaseFilter pStartFilter, IBaseFilter pEndFilter)
    {
        return ((delegate* unmanaged<IFilterChain, IBaseFilter, IBaseFilter, int>)((*lpVtbl)[5]))(
            this,
            pStartFilter,
            pEndFilter
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT RemoveChain(IBaseFilter pStartFilter, IBaseFilter pEndFilter)
    {
        return ((delegate* unmanaged<IFilterChain, IBaseFilter, IBaseFilter, int>)((*lpVtbl)[6]))(
            this,
            pStartFilter,
            pEndFilter
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT StartChain(IBaseFilter pStartFilter, IBaseFilter pEndFilter);

        [VtblIndex(4)]
        HRESULT PauseChain(IBaseFilter pStartFilter, IBaseFilter pEndFilter);

        [VtblIndex(5)]
        HRESULT StopChain(IBaseFilter pStartFilter, IBaseFilter pEndFilter);

        [VtblIndex(6)]
        HRESULT RemoveChain(IBaseFilter pStartFilter, IBaseFilter pEndFilter);
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

        [NativeTypeName("HRESULT (IBaseFilter *, IBaseFilter *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IBaseFilter, IBaseFilter, int> StartChain;

        [NativeTypeName("HRESULT (IBaseFilter *, IBaseFilter *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IBaseFilter, IBaseFilter, int> PauseChain;

        [NativeTypeName("HRESULT (IBaseFilter *, IBaseFilter *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IBaseFilter, IBaseFilter, int> StopChain;

        [NativeTypeName("HRESULT (IBaseFilter *, IBaseFilter *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IBaseFilter, IBaseFilter, int> RemoveChain;
    }

    /// <summary>Initializes a new instance of the <see cref = "IFilterChain"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IFilterChain(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IFilterChain"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IFilterChain(Silk.NET.Windows.IUnknown value)
    {
        return new IFilterChain(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IFilterChain"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IFilterChain"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IFilterChain value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
