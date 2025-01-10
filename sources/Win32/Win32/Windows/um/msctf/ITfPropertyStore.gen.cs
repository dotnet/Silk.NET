// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/msctf.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("6834B120-88CB-11D2-BF45-00105A2799B5")]
[NativeTypeName("struct ITfPropertyStore : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ITfPropertyStore : ITfPropertyStore.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITfPropertyStore));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITfPropertyStore, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ITfPropertyStore, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITfPropertyStore, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetType(Guid* pguid)
    {
        return ((delegate* unmanaged<ITfPropertyStore, Guid*, int>)((*lpVtbl)[3]))(this, pguid);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetDataType([NativeTypeName("DWORD *")] uint* pdwReserved)
    {
        return ((delegate* unmanaged<ITfPropertyStore, uint*, int>)((*lpVtbl)[4]))(
            this,
            pdwReserved
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetData(VARIANT* pvarValue)
    {
        return ((delegate* unmanaged<ITfPropertyStore, VARIANT*, int>)((*lpVtbl)[5]))(
            this,
            pvarValue
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT OnTextUpdated(
        [NativeTypeName("DWORD")] uint dwFlags,
        ITfRange pRangeNew,
        BOOL* pfAccept
    )
    {
        return ((delegate* unmanaged<ITfPropertyStore, uint, ITfRange, BOOL*, int>)((*lpVtbl)[6]))(
            this,
            dwFlags,
            pRangeNew,
            pfAccept
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT Shrink(ITfRange pRangeNew, BOOL* pfFree)
    {
        return ((delegate* unmanaged<ITfPropertyStore, ITfRange, BOOL*, int>)((*lpVtbl)[7]))(
            this,
            pRangeNew,
            pfFree
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT Divide(ITfRange pRangeThis, ITfRange pRangeNew, ITfPropertyStore* ppPropStore)
    {
        return (
            (delegate* unmanaged<ITfPropertyStore, ITfRange, ITfRange, ITfPropertyStore*, int>)(
                (*lpVtbl)[8]
            )
        )(this, pRangeThis, pRangeNew, ppPropStore);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT Clone(ITfPropertyStore* pPropStore)
    {
        return ((delegate* unmanaged<ITfPropertyStore, ITfPropertyStore*, int>)((*lpVtbl)[9]))(
            this,
            pPropStore
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetPropertyRangeCreator([NativeTypeName("CLSID *")] Guid* pclsid)
    {
        return ((delegate* unmanaged<ITfPropertyStore, Guid*, int>)((*lpVtbl)[10]))(this, pclsid);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT Serialize(IStream pStream, [NativeTypeName("ULONG *")] uint* pcb)
    {
        return ((delegate* unmanaged<ITfPropertyStore, IStream, uint*, int>)((*lpVtbl)[11]))(
            this,
            pStream,
            pcb
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetType(Guid* pguid);

        [VtblIndex(4)]
        HRESULT GetDataType([NativeTypeName("DWORD *")] uint* pdwReserved);

        [VtblIndex(5)]
        HRESULT GetData(VARIANT* pvarValue);

        [VtblIndex(6)]
        HRESULT OnTextUpdated(
            [NativeTypeName("DWORD")] uint dwFlags,
            ITfRange pRangeNew,
            BOOL* pfAccept
        );

        [VtblIndex(7)]
        HRESULT Shrink(ITfRange pRangeNew, BOOL* pfFree);

        [VtblIndex(8)]
        HRESULT Divide(ITfRange pRangeThis, ITfRange pRangeNew, ITfPropertyStore* ppPropStore);

        [VtblIndex(9)]
        HRESULT Clone(ITfPropertyStore* pPropStore);

        [VtblIndex(10)]
        HRESULT GetPropertyRangeCreator([NativeTypeName("CLSID *")] Guid* pclsid);

        [VtblIndex(11)]
        HRESULT Serialize(IStream pStream, [NativeTypeName("ULONG *")] uint* pcb);
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

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public new delegate* unmanaged<TSelf*, Guid*, int> GetType;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetDataType;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> GetData;

        [NativeTypeName("HRESULT (DWORD, ITfRange *, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ITfRange, BOOL*, int> OnTextUpdated;

        [NativeTypeName("HRESULT (ITfRange *, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ITfRange, BOOL*, int> Shrink;

        [NativeTypeName(
            "HRESULT (ITfRange *, ITfRange *, ITfPropertyStore **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ITfRange, ITfRange, ITfPropertyStore*, int> Divide;

        [NativeTypeName("HRESULT (ITfPropertyStore **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ITfPropertyStore*, int> Clone;

        [NativeTypeName("HRESULT (CLSID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> GetPropertyRangeCreator;

        [NativeTypeName("HRESULT (IStream *, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IStream, uint*, int> Serialize;
    }

    /// <summary>Initializes a new instance of the <see cref = "ITfPropertyStore"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ITfPropertyStore(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ITfPropertyStore"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ITfPropertyStore(Silk.NET.Windows.IUnknown value)
    {
        return new ITfPropertyStore(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ITfPropertyStore"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ITfPropertyStore"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ITfPropertyStore value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
