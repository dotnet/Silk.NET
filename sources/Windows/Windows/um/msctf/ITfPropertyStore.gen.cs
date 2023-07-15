// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/msctf.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='ITfPropertyStore.xml' path='doc/member[@name="ITfPropertyStore"]/*'/>
[Guid("6834B120-88CB-11D2-BF45-00105A2799B5")]
[NativeTypeName("struct ITfPropertyStore : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ITfPropertyStore : ITfPropertyStore.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITfPropertyStore));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITfPropertyStore*, Guid*, void**, int> )(lpVtbl[0]))((ITfPropertyStore*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ITfPropertyStore*, uint> )(lpVtbl[1]))((ITfPropertyStore*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITfPropertyStore*, uint> )(lpVtbl[2]))((ITfPropertyStore*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ITfPropertyStore.xml' path='doc/member[@name="ITfPropertyStore.GetType"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetType(Guid* pguid)
    {
        return ((delegate* unmanaged<ITfPropertyStore*, Guid*, int> )(lpVtbl[3]))((ITfPropertyStore*)Unsafe.AsPointer(ref this), pguid);
    }

    /// <include file='ITfPropertyStore.xml' path='doc/member[@name="ITfPropertyStore.GetDataType"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetDataType([NativeTypeName("DWORD *")] uint* pdwReserved)
    {
        return ((delegate* unmanaged<ITfPropertyStore*, uint*, int> )(lpVtbl[4]))((ITfPropertyStore*)Unsafe.AsPointer(ref this), pdwReserved);
    }

    /// <include file='ITfPropertyStore.xml' path='doc/member[@name="ITfPropertyStore.GetData"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetData(VARIANT* pvarValue)
    {
        return ((delegate* unmanaged<ITfPropertyStore*, VARIANT*, int> )(lpVtbl[5]))((ITfPropertyStore*)Unsafe.AsPointer(ref this), pvarValue);
    }

    /// <include file='ITfPropertyStore.xml' path='doc/member[@name="ITfPropertyStore.OnTextUpdated"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT OnTextUpdated([NativeTypeName("DWORD")] uint dwFlags, ITfRange* pRangeNew, BOOL* pfAccept)
    {
        return ((delegate* unmanaged<ITfPropertyStore*, uint, ITfRange*, BOOL*, int> )(lpVtbl[6]))((ITfPropertyStore*)Unsafe.AsPointer(ref this), dwFlags, pRangeNew, pfAccept);
    }

    /// <include file='ITfPropertyStore.xml' path='doc/member[@name="ITfPropertyStore.Shrink"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT Shrink(ITfRange* pRangeNew, BOOL* pfFree)
    {
        return ((delegate* unmanaged<ITfPropertyStore*, ITfRange*, BOOL*, int> )(lpVtbl[7]))((ITfPropertyStore*)Unsafe.AsPointer(ref this), pRangeNew, pfFree);
    }

    /// <include file='ITfPropertyStore.xml' path='doc/member[@name="ITfPropertyStore.Divide"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT Divide(ITfRange* pRangeThis, ITfRange* pRangeNew, ITfPropertyStore** ppPropStore)
    {
        return ((delegate* unmanaged<ITfPropertyStore*, ITfRange*, ITfRange*, ITfPropertyStore**, int> )(lpVtbl[8]))((ITfPropertyStore*)Unsafe.AsPointer(ref this), pRangeThis, pRangeNew, ppPropStore);
    }

    /// <include file='ITfPropertyStore.xml' path='doc/member[@name="ITfPropertyStore.Clone"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT Clone(ITfPropertyStore** pPropStore)
    {
        return ((delegate* unmanaged<ITfPropertyStore*, ITfPropertyStore**, int> )(lpVtbl[9]))((ITfPropertyStore*)Unsafe.AsPointer(ref this), pPropStore);
    }

    /// <include file='ITfPropertyStore.xml' path='doc/member[@name="ITfPropertyStore.GetPropertyRangeCreator"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetPropertyRangeCreator([NativeTypeName("CLSID *")] Guid* pclsid)
    {
        return ((delegate* unmanaged<ITfPropertyStore*, Guid*, int> )(lpVtbl[10]))((ITfPropertyStore*)Unsafe.AsPointer(ref this), pclsid);
    }

    /// <include file='ITfPropertyStore.xml' path='doc/member[@name="ITfPropertyStore.Serialize"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT Serialize(IStream* pStream, [NativeTypeName("ULONG *")] uint* pcb)
    {
        return ((delegate* unmanaged<ITfPropertyStore*, IStream*, uint*, int> )(lpVtbl[11]))((ITfPropertyStore*)Unsafe.AsPointer(ref this), pStream, pcb);
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
        HRESULT OnTextUpdated([NativeTypeName("DWORD")] uint dwFlags, ITfRange* pRangeNew, BOOL* pfAccept);
        [VtblIndex(7)]
        HRESULT Shrink(ITfRange* pRangeNew, BOOL* pfFree);
        [VtblIndex(8)]
        HRESULT Divide(ITfRange* pRangeThis, ITfRange* pRangeNew, ITfPropertyStore** ppPropStore);
        [VtblIndex(9)]
        HRESULT Clone(ITfPropertyStore** pPropStore);
        [VtblIndex(10)]
        HRESULT GetPropertyRangeCreator([NativeTypeName("CLSID *")] Guid* pclsid);
        [VtblIndex(11)]
        HRESULT Serialize(IStream* pStream, [NativeTypeName("ULONG *")] uint* pcb);
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
        public delegate* unmanaged<TSelf*, uint, ITfRange*, BOOL*, int> OnTextUpdated;
        [NativeTypeName("HRESULT (ITfRange *, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ITfRange*, BOOL*, int> Shrink;
        [NativeTypeName("HRESULT (ITfRange *, ITfRange *, ITfPropertyStore **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ITfRange*, ITfRange*, ITfPropertyStore**, int> Divide;
        [NativeTypeName("HRESULT (ITfPropertyStore **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ITfPropertyStore**, int> Clone;
        [NativeTypeName("HRESULT (CLSID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> GetPropertyRangeCreator;
        [NativeTypeName("HRESULT (IStream *, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IStream*, uint*, int> Serialize;
    }
}