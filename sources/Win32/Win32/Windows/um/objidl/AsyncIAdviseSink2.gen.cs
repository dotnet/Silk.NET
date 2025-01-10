// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/objidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("00000151-0000-0000-C000-000000000046")]
[NativeTypeName("struct AsyncIAdviseSink2 : AsyncIAdviseSink")]
[NativeInheritance("AsyncIAdviseSink")]
public unsafe partial struct AsyncIAdviseSink2 : AsyncIAdviseSink2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_AsyncIAdviseSink2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<AsyncIAdviseSink2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<AsyncIAdviseSink2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<AsyncIAdviseSink2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void Begin_OnDataChange(FORMATETC* pFormatetc, STGMEDIUM* pStgmed)
    {
        ((delegate* unmanaged<AsyncIAdviseSink2, FORMATETC*, STGMEDIUM*, void>)((*lpVtbl)[3]))(
            this,
            pFormatetc,
            pStgmed
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void Finish_OnDataChange()
    {
        ((delegate* unmanaged<AsyncIAdviseSink2, void>)((*lpVtbl)[4]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public void Begin_OnViewChange(
        [NativeTypeName("DWORD")] uint dwAspect,
        [NativeTypeName("LONG")] int lindex
    )
    {
        ((delegate* unmanaged<AsyncIAdviseSink2, uint, int, void>)((*lpVtbl)[5]))(
            this,
            dwAspect,
            lindex
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public void Finish_OnViewChange()
    {
        ((delegate* unmanaged<AsyncIAdviseSink2, void>)((*lpVtbl)[6]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public void Begin_OnRename(IMoniker pmk)
    {
        ((delegate* unmanaged<AsyncIAdviseSink2, IMoniker, void>)((*lpVtbl)[7]))(this, pmk);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public void Finish_OnRename()
    {
        ((delegate* unmanaged<AsyncIAdviseSink2, void>)((*lpVtbl)[8]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public void Begin_OnSave()
    {
        ((delegate* unmanaged<AsyncIAdviseSink2, void>)((*lpVtbl)[9]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public void Finish_OnSave()
    {
        ((delegate* unmanaged<AsyncIAdviseSink2, void>)((*lpVtbl)[10]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public void Begin_OnClose()
    {
        ((delegate* unmanaged<AsyncIAdviseSink2, void>)((*lpVtbl)[11]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public void Finish_OnClose()
    {
        ((delegate* unmanaged<AsyncIAdviseSink2, void>)((*lpVtbl)[12]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public void Begin_OnLinkSrcChange(IMoniker pmk)
    {
        ((delegate* unmanaged<AsyncIAdviseSink2, IMoniker, void>)((*lpVtbl)[13]))(this, pmk);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public void Finish_OnLinkSrcChange()
    {
        ((delegate* unmanaged<AsyncIAdviseSink2, void>)((*lpVtbl)[14]))(this);
    }

    public interface Interface : AsyncIAdviseSink.Interface
    {
        [VtblIndex(13)]
        void Begin_OnLinkSrcChange(IMoniker pmk);

        [VtblIndex(14)]
        void Finish_OnLinkSrcChange();
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

        [NativeTypeName("void (FORMATETC *, STGMEDIUM *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, FORMATETC*, STGMEDIUM*, void> Begin_OnDataChange;

        [NativeTypeName("void () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void> Finish_OnDataChange;

        [NativeTypeName("void (DWORD, LONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int, void> Begin_OnViewChange;

        [NativeTypeName("void () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void> Finish_OnViewChange;

        [NativeTypeName("void (IMoniker *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMoniker, void> Begin_OnRename;

        [NativeTypeName("void () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void> Finish_OnRename;

        [NativeTypeName("void () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void> Begin_OnSave;

        [NativeTypeName("void () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void> Finish_OnSave;

        [NativeTypeName("void () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void> Begin_OnClose;

        [NativeTypeName("void () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void> Finish_OnClose;

        [NativeTypeName("void (IMoniker *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMoniker, void> Begin_OnLinkSrcChange;

        [NativeTypeName("void () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void> Finish_OnLinkSrcChange;
    }

    /// <summary>Initializes a new instance of the <see cref = "AsyncIAdviseSink2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public AsyncIAdviseSink2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.AsyncIAdviseSink"/> to <see cref = "AsyncIAdviseSink2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.AsyncIAdviseSink"/> instance to be converted </param>
    public static explicit operator AsyncIAdviseSink2(Silk.NET.Windows.AsyncIAdviseSink value)
    {
        return new AsyncIAdviseSink2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "AsyncIAdviseSink2"/> to <see cref = "Silk.NET.Windows.AsyncIAdviseSink"/>.</summary>
    /// <param name = "value">The <see cref = "AsyncIAdviseSink2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.AsyncIAdviseSink(AsyncIAdviseSink2 value)
    {
        return new Silk.NET.Windows.AsyncIAdviseSink(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "AsyncIAdviseSink2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator AsyncIAdviseSink2(Silk.NET.Windows.IUnknown value)
    {
        return new AsyncIAdviseSink2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "AsyncIAdviseSink2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "AsyncIAdviseSink2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(AsyncIAdviseSink2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
