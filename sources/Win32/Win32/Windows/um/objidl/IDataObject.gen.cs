// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/objidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("0000010E-0000-0000-C000-000000000046")]
[NativeTypeName("struct IDataObject : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDataObject : IDataObject.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDataObject));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDataObject, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDataObject, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDataObject, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetData(FORMATETC* pformatetcIn, STGMEDIUM* pmedium)
    {
        return ((delegate* unmanaged<IDataObject, FORMATETC*, STGMEDIUM*, int>)((*lpVtbl)[3]))(
            this,
            pformatetcIn,
            pmedium
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetDataHere(FORMATETC* pformatetc, STGMEDIUM* pmedium)
    {
        return ((delegate* unmanaged<IDataObject, FORMATETC*, STGMEDIUM*, int>)((*lpVtbl)[4]))(
            this,
            pformatetc,
            pmedium
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT QueryGetData(FORMATETC* pformatetc)
    {
        return ((delegate* unmanaged<IDataObject, FORMATETC*, int>)((*lpVtbl)[5]))(
            this,
            pformatetc
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetCanonicalFormatEtc(FORMATETC* pformatectIn, FORMATETC* pformatetcOut)
    {
        return ((delegate* unmanaged<IDataObject, FORMATETC*, FORMATETC*, int>)((*lpVtbl)[6]))(
            this,
            pformatectIn,
            pformatetcOut
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetData(FORMATETC* pformatetc, STGMEDIUM* pmedium, BOOL fRelease)
    {
        return (
            (delegate* unmanaged<IDataObject, FORMATETC*, STGMEDIUM*, BOOL, int>)((*lpVtbl)[7])
        )(this, pformatetc, pmedium, fRelease);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT EnumFormatEtc(
        [NativeTypeName("DWORD")] uint dwDirection,
        IEnumFORMATETC* ppenumFormatEtc
    )
    {
        return ((delegate* unmanaged<IDataObject, uint, IEnumFORMATETC*, int>)((*lpVtbl)[8]))(
            this,
            dwDirection,
            ppenumFormatEtc
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT DAdvise(
        FORMATETC* pformatetc,
        [NativeTypeName("DWORD")] uint advf,
        IAdviseSink pAdvSink,
        [NativeTypeName("DWORD *")] uint* pdwConnection
    )
    {
        return (
            (delegate* unmanaged<IDataObject, FORMATETC*, uint, IAdviseSink, uint*, int>)(
                (*lpVtbl)[9]
            )
        )(this, pformatetc, advf, pAdvSink, pdwConnection);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT DUnadvise([NativeTypeName("DWORD")] uint dwConnection)
    {
        return ((delegate* unmanaged<IDataObject, uint, int>)((*lpVtbl)[10]))(this, dwConnection);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT EnumDAdvise(IEnumSTATDATA* ppenumAdvise)
    {
        return ((delegate* unmanaged<IDataObject, IEnumSTATDATA*, int>)((*lpVtbl)[11]))(
            this,
            ppenumAdvise
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetData(FORMATETC* pformatetcIn, STGMEDIUM* pmedium);

        [VtblIndex(4)]
        HRESULT GetDataHere(FORMATETC* pformatetc, STGMEDIUM* pmedium);

        [VtblIndex(5)]
        HRESULT QueryGetData(FORMATETC* pformatetc);

        [VtblIndex(6)]
        HRESULT GetCanonicalFormatEtc(FORMATETC* pformatectIn, FORMATETC* pformatetcOut);

        [VtblIndex(7)]
        HRESULT SetData(FORMATETC* pformatetc, STGMEDIUM* pmedium, BOOL fRelease);

        [VtblIndex(8)]
        HRESULT EnumFormatEtc(
            [NativeTypeName("DWORD")] uint dwDirection,
            IEnumFORMATETC* ppenumFormatEtc
        );

        [VtblIndex(9)]
        HRESULT DAdvise(
            FORMATETC* pformatetc,
            [NativeTypeName("DWORD")] uint advf,
            IAdviseSink pAdvSink,
            [NativeTypeName("DWORD *")] uint* pdwConnection
        );

        [VtblIndex(10)]
        HRESULT DUnadvise([NativeTypeName("DWORD")] uint dwConnection);

        [VtblIndex(11)]
        HRESULT EnumDAdvise(IEnumSTATDATA* ppenumAdvise);
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

        [NativeTypeName("HRESULT (FORMATETC *, STGMEDIUM *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, FORMATETC*, STGMEDIUM*, int> GetData;

        [NativeTypeName("HRESULT (FORMATETC *, STGMEDIUM *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, FORMATETC*, STGMEDIUM*, int> GetDataHere;

        [NativeTypeName("HRESULT (FORMATETC *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, FORMATETC*, int> QueryGetData;

        [NativeTypeName("HRESULT (FORMATETC *, FORMATETC *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, FORMATETC*, FORMATETC*, int> GetCanonicalFormatEtc;

        [NativeTypeName("HRESULT (FORMATETC *, STGMEDIUM *, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, FORMATETC*, STGMEDIUM*, BOOL, int> SetData;

        [NativeTypeName("HRESULT (DWORD, IEnumFORMATETC **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IEnumFORMATETC*, int> EnumFormatEtc;

        [NativeTypeName(
            "HRESULT (FORMATETC *, DWORD, IAdviseSink *, DWORD *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, FORMATETC*, uint, IAdviseSink, uint*, int> DAdvise;

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> DUnadvise;

        [NativeTypeName("HRESULT (IEnumSTATDATA **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IEnumSTATDATA*, int> EnumDAdvise;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDataObject"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDataObject(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDataObject"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDataObject(Silk.NET.Windows.IUnknown value)
    {
        return new IDataObject(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDataObject"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDataObject"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDataObject value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
