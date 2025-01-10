// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/objidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("0000010F-0000-0000-C000-000000000046")]
[NativeTypeName("struct IAdviseSink : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAdviseSink : IAdviseSink.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAdviseSink));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAdviseSink, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IAdviseSink, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAdviseSink, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void OnDataChange(FORMATETC* pFormatetc, STGMEDIUM* pStgmed)
    {
        ((delegate* unmanaged<IAdviseSink, FORMATETC*, STGMEDIUM*, void>)((*lpVtbl)[3]))(
            this,
            pFormatetc,
            pStgmed
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void OnViewChange(
        [NativeTypeName("DWORD")] uint dwAspect,
        [NativeTypeName("LONG")] int lindex
    )
    {
        ((delegate* unmanaged<IAdviseSink, uint, int, void>)((*lpVtbl)[4]))(this, dwAspect, lindex);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public void OnRename(IMoniker pmk)
    {
        ((delegate* unmanaged<IAdviseSink, IMoniker, void>)((*lpVtbl)[5]))(this, pmk);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public void OnSave()
    {
        ((delegate* unmanaged<IAdviseSink, void>)((*lpVtbl)[6]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public void OnClose()
    {
        ((delegate* unmanaged<IAdviseSink, void>)((*lpVtbl)[7]))(this);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        void OnDataChange(FORMATETC* pFormatetc, STGMEDIUM* pStgmed);

        [VtblIndex(4)]
        void OnViewChange(
            [NativeTypeName("DWORD")] uint dwAspect,
            [NativeTypeName("LONG")] int lindex
        );

        [VtblIndex(5)]
        void OnRename(IMoniker pmk);

        [VtblIndex(6)]
        void OnSave();

        [VtblIndex(7)]
        void OnClose();
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
        public delegate* unmanaged<TSelf*, FORMATETC*, STGMEDIUM*, void> OnDataChange;

        [NativeTypeName("void (DWORD, LONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int, void> OnViewChange;

        [NativeTypeName("void (IMoniker *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMoniker, void> OnRename;

        [NativeTypeName("void () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void> OnSave;

        [NativeTypeName("void () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void> OnClose;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAdviseSink"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAdviseSink(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAdviseSink"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAdviseSink(Silk.NET.Windows.IUnknown value)
    {
        return new IAdviseSink(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAdviseSink"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAdviseSink"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAdviseSink value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
