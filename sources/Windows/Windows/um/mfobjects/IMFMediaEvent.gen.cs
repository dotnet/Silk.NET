// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IMFMediaEvent.xml' path='doc/member[@name="IMFMediaEvent"]/*'/>
[Guid("DF598932-F10C-4E39-BBA2-C308F101DAA3")]
[NativeTypeName("struct IMFMediaEvent : IMFAttributes")]
[NativeInheritance("IMFAttributes")]
public unsafe partial struct IMFMediaEvent : IMFMediaEvent.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFMediaEvent));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFMediaEvent*, Guid*, void**, int> )(lpVtbl[0]))((IMFMediaEvent*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFMediaEvent*, uint> )(lpVtbl[1]))((IMFMediaEvent*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFMediaEvent*, uint> )(lpVtbl[2]))((IMFMediaEvent*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IMFAttributes.GetItem"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetItem([NativeTypeName("const GUID &")] Guid* guidKey, PROPVARIANT* pValue)
    {
        return ((delegate* unmanaged<IMFMediaEvent*, Guid*, PROPVARIANT*, int> )(lpVtbl[3]))((IMFMediaEvent*)Unsafe.AsPointer(ref this), guidKey, pValue);
    }

    /// <inheritdoc cref = "IMFAttributes.GetItemType"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetItemType([NativeTypeName("const GUID &")] Guid* guidKey, MF_ATTRIBUTE_TYPE* pType)
    {
        return ((delegate* unmanaged<IMFMediaEvent*, Guid*, MF_ATTRIBUTE_TYPE*, int> )(lpVtbl[4]))((IMFMediaEvent*)Unsafe.AsPointer(ref this), guidKey, pType);
    }

    /// <inheritdoc cref = "IMFAttributes.CompareItem"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT CompareItem([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* Value, BOOL* pbResult)
    {
        return ((delegate* unmanaged<IMFMediaEvent*, Guid*, PROPVARIANT*, BOOL*, int> )(lpVtbl[5]))((IMFMediaEvent*)Unsafe.AsPointer(ref this), guidKey, Value, pbResult);
    }

    /// <inheritdoc cref = "IMFAttributes.Compare"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Compare(IMFAttributes* pTheirs, MF_ATTRIBUTES_MATCH_TYPE MatchType, BOOL* pbResult)
    {
        return ((delegate* unmanaged<IMFMediaEvent*, IMFAttributes*, MF_ATTRIBUTES_MATCH_TYPE, BOOL*, int> )(lpVtbl[6]))((IMFMediaEvent*)Unsafe.AsPointer(ref this), pTheirs, MatchType, pbResult);
    }

    /// <inheritdoc cref = "IMFAttributes.GetUINT32"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetUINT32([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT32 *")] uint* punValue)
    {
        return ((delegate* unmanaged<IMFMediaEvent*, Guid*, uint*, int> )(lpVtbl[7]))((IMFMediaEvent*)Unsafe.AsPointer(ref this), guidKey, punValue);
    }

    /// <inheritdoc cref = "IMFAttributes.GetUINT64"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetUINT64([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT64 *")] ulong* punValue)
    {
        return ((delegate* unmanaged<IMFMediaEvent*, Guid*, ulong*, int> )(lpVtbl[8]))((IMFMediaEvent*)Unsafe.AsPointer(ref this), guidKey, punValue);
    }

    /// <inheritdoc cref = "IMFAttributes.GetDouble"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetDouble([NativeTypeName("const GUID &")] Guid* guidKey, double* pfValue)
    {
        return ((delegate* unmanaged<IMFMediaEvent*, Guid*, double*, int> )(lpVtbl[9]))((IMFMediaEvent*)Unsafe.AsPointer(ref this), guidKey, pfValue);
    }

    /// <inheritdoc cref = "IMFAttributes.GetGUID"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetGUID([NativeTypeName("const GUID &")] Guid* guidKey, Guid* pguidValue)
    {
        return ((delegate* unmanaged<IMFMediaEvent*, Guid*, Guid*, int> )(lpVtbl[10]))((IMFMediaEvent*)Unsafe.AsPointer(ref this), guidKey, pguidValue);
    }

    /// <inheritdoc cref = "IMFAttributes.GetStringLength"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetStringLength([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT32 *")] uint* pcchLength)
    {
        return ((delegate* unmanaged<IMFMediaEvent*, Guid*, uint*, int> )(lpVtbl[11]))((IMFMediaEvent*)Unsafe.AsPointer(ref this), guidKey, pcchLength);
    }

    /// <inheritdoc cref = "IMFAttributes.GetString"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetString([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("LPWSTR")] ushort* pwszValue, [NativeTypeName("UINT32")] uint cchBufSize, [NativeTypeName("UINT32 *")] uint* pcchLength)
    {
        return ((delegate* unmanaged<IMFMediaEvent*, Guid*, ushort*, uint, uint*, int> )(lpVtbl[12]))((IMFMediaEvent*)Unsafe.AsPointer(ref this), guidKey, pwszValue, cchBufSize, pcchLength);
    }

    /// <inheritdoc cref = "IMFAttributes.GetAllocatedString"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetAllocatedString([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("LPWSTR *")] ushort** ppwszValue, [NativeTypeName("UINT32 *")] uint* pcchLength)
    {
        return ((delegate* unmanaged<IMFMediaEvent*, Guid*, ushort**, uint*, int> )(lpVtbl[13]))((IMFMediaEvent*)Unsafe.AsPointer(ref this), guidKey, ppwszValue, pcchLength);
    }

    /// <inheritdoc cref = "IMFAttributes.GetBlobSize"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetBlobSize([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT32 *")] uint* pcbBlobSize)
    {
        return ((delegate* unmanaged<IMFMediaEvent*, Guid*, uint*, int> )(lpVtbl[14]))((IMFMediaEvent*)Unsafe.AsPointer(ref this), guidKey, pcbBlobSize);
    }

    /// <inheritdoc cref = "IMFAttributes.GetBlob"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetBlob([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT8 *")] byte* pBuf, [NativeTypeName("UINT32")] uint cbBufSize, [NativeTypeName("UINT32 *")] uint* pcbBlobSize)
    {
        return ((delegate* unmanaged<IMFMediaEvent*, Guid*, byte*, uint, uint*, int> )(lpVtbl[15]))((IMFMediaEvent*)Unsafe.AsPointer(ref this), guidKey, pBuf, cbBufSize, pcbBlobSize);
    }

    /// <inheritdoc cref = "IMFAttributes.GetAllocatedBlob"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT GetAllocatedBlob([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT8 **")] byte** ppBuf, [NativeTypeName("UINT32 *")] uint* pcbSize)
    {
        return ((delegate* unmanaged<IMFMediaEvent*, Guid*, byte**, uint*, int> )(lpVtbl[16]))((IMFMediaEvent*)Unsafe.AsPointer(ref this), guidKey, ppBuf, pcbSize);
    }

    /// <inheritdoc cref = "IMFAttributes.GetUnknown"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT GetUnknown([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppv)
    {
        return ((delegate* unmanaged<IMFMediaEvent*, Guid*, Guid*, void**, int> )(lpVtbl[17]))((IMFMediaEvent*)Unsafe.AsPointer(ref this), guidKey, riid, ppv);
    }

    /// <inheritdoc cref = "IMFAttributes.SetItem"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT SetItem([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* Value)
    {
        return ((delegate* unmanaged<IMFMediaEvent*, Guid*, PROPVARIANT*, int> )(lpVtbl[18]))((IMFMediaEvent*)Unsafe.AsPointer(ref this), guidKey, Value);
    }

    /// <inheritdoc cref = "IMFAttributes.DeleteItem"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT DeleteItem([NativeTypeName("const GUID &")] Guid* guidKey)
    {
        return ((delegate* unmanaged<IMFMediaEvent*, Guid*, int> )(lpVtbl[19]))((IMFMediaEvent*)Unsafe.AsPointer(ref this), guidKey);
    }

    /// <inheritdoc cref = "IMFAttributes.DeleteAllItems"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT DeleteAllItems()
    {
        return ((delegate* unmanaged<IMFMediaEvent*, int> )(lpVtbl[20]))((IMFMediaEvent*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IMFAttributes.SetUINT32"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT SetUINT32([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT32")] uint unValue)
    {
        return ((delegate* unmanaged<IMFMediaEvent*, Guid*, uint, int> )(lpVtbl[21]))((IMFMediaEvent*)Unsafe.AsPointer(ref this), guidKey, unValue);
    }

    /// <inheritdoc cref = "IMFAttributes.SetUINT64"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT SetUINT64([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT64")] ulong unValue)
    {
        return ((delegate* unmanaged<IMFMediaEvent*, Guid*, ulong, int> )(lpVtbl[22]))((IMFMediaEvent*)Unsafe.AsPointer(ref this), guidKey, unValue);
    }

    /// <inheritdoc cref = "IMFAttributes.SetDouble"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT SetDouble([NativeTypeName("const GUID &")] Guid* guidKey, double fValue)
    {
        return ((delegate* unmanaged<IMFMediaEvent*, Guid*, double, int> )(lpVtbl[23]))((IMFMediaEvent*)Unsafe.AsPointer(ref this), guidKey, fValue);
    }

    /// <inheritdoc cref = "IMFAttributes.SetGUID"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT SetGUID([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("const GUID &")] Guid* guidValue)
    {
        return ((delegate* unmanaged<IMFMediaEvent*, Guid*, Guid*, int> )(lpVtbl[24]))((IMFMediaEvent*)Unsafe.AsPointer(ref this), guidKey, guidValue);
    }

    /// <inheritdoc cref = "IMFAttributes.SetString"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT SetString([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("LPCWSTR")] ushort* wszValue)
    {
        return ((delegate* unmanaged<IMFMediaEvent*, Guid*, ushort*, int> )(lpVtbl[25]))((IMFMediaEvent*)Unsafe.AsPointer(ref this), guidKey, wszValue);
    }

    /// <inheritdoc cref = "IMFAttributes.SetBlob"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT SetBlob([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("const UINT8 *")] byte* pBuf, [NativeTypeName("UINT32")] uint cbBufSize)
    {
        return ((delegate* unmanaged<IMFMediaEvent*, Guid*, byte*, uint, int> )(lpVtbl[26]))((IMFMediaEvent*)Unsafe.AsPointer(ref this), guidKey, pBuf, cbBufSize);
    }

    /// <inheritdoc cref = "IMFAttributes.SetUnknown"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT SetUnknown([NativeTypeName("const GUID &")] Guid* guidKey, IUnknown* pUnknown)
    {
        return ((delegate* unmanaged<IMFMediaEvent*, Guid*, IUnknown*, int> )(lpVtbl[27]))((IMFMediaEvent*)Unsafe.AsPointer(ref this), guidKey, pUnknown);
    }

    /// <inheritdoc cref = "IMFAttributes.LockStore"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT LockStore()
    {
        return ((delegate* unmanaged<IMFMediaEvent*, int> )(lpVtbl[28]))((IMFMediaEvent*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IMFAttributes.UnlockStore"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT UnlockStore()
    {
        return ((delegate* unmanaged<IMFMediaEvent*, int> )(lpVtbl[29]))((IMFMediaEvent*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IMFAttributes.GetCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT GetCount([NativeTypeName("UINT32 *")] uint* pcItems)
    {
        return ((delegate* unmanaged<IMFMediaEvent*, uint*, int> )(lpVtbl[30]))((IMFMediaEvent*)Unsafe.AsPointer(ref this), pcItems);
    }

    /// <inheritdoc cref = "IMFAttributes.GetItemByIndex"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT GetItemByIndex([NativeTypeName("UINT32")] uint unIndex, Guid* pguidKey, PROPVARIANT* pValue)
    {
        return ((delegate* unmanaged<IMFMediaEvent*, uint, Guid*, PROPVARIANT*, int> )(lpVtbl[31]))((IMFMediaEvent*)Unsafe.AsPointer(ref this), unIndex, pguidKey, pValue);
    }

    /// <inheritdoc cref = "IMFAttributes.CopyAllItems"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT CopyAllItems(IMFAttributes* pDest)
    {
        return ((delegate* unmanaged<IMFMediaEvent*, IMFAttributes*, int> )(lpVtbl[32]))((IMFMediaEvent*)Unsafe.AsPointer(ref this), pDest);
    }

    /// <include file='IMFMediaEvent.xml' path='doc/member[@name="IMFMediaEvent.GetType"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT GetType([NativeTypeName("MediaEventType *")] uint* pmet)
    {
        return ((delegate* unmanaged<IMFMediaEvent*, uint*, int> )(lpVtbl[33]))((IMFMediaEvent*)Unsafe.AsPointer(ref this), pmet);
    }

    /// <include file='IMFMediaEvent.xml' path='doc/member[@name="IMFMediaEvent.GetExtendedType"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT GetExtendedType(Guid* pguidExtendedType)
    {
        return ((delegate* unmanaged<IMFMediaEvent*, Guid*, int> )(lpVtbl[34]))((IMFMediaEvent*)Unsafe.AsPointer(ref this), pguidExtendedType);
    }

    /// <include file='IMFMediaEvent.xml' path='doc/member[@name="IMFMediaEvent.GetStatus"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT GetStatus(HRESULT* phrStatus)
    {
        return ((delegate* unmanaged<IMFMediaEvent*, HRESULT*, int> )(lpVtbl[35]))((IMFMediaEvent*)Unsafe.AsPointer(ref this), phrStatus);
    }

    /// <include file='IMFMediaEvent.xml' path='doc/member[@name="IMFMediaEvent.GetValue"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT GetValue(PROPVARIANT* pvValue)
    {
        return ((delegate* unmanaged<IMFMediaEvent*, PROPVARIANT*, int> )(lpVtbl[36]))((IMFMediaEvent*)Unsafe.AsPointer(ref this), pvValue);
    }

    public interface Interface : IMFAttributes.Interface
    {
        [VtblIndex(33)]
        HRESULT GetType([NativeTypeName("MediaEventType *")] uint* pmet);
        [VtblIndex(34)]
        HRESULT GetExtendedType(Guid* pguidExtendedType);
        [VtblIndex(35)]
        HRESULT GetStatus(HRESULT* phrStatus);
        [VtblIndex(36)]
        HRESULT GetValue(PROPVARIANT* pvValue);
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
        [NativeTypeName("HRESULT (const GUID &, PROPVARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, PROPVARIANT*, int> GetItem;
        [NativeTypeName("HRESULT (const GUID &, MF_ATTRIBUTE_TYPE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, MF_ATTRIBUTE_TYPE*, int> GetItemType;
        [NativeTypeName("HRESULT (const GUID &, const PROPVARIANT &, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, PROPVARIANT*, BOOL*, int> CompareItem;
        [NativeTypeName("HRESULT (IMFAttributes *, MF_ATTRIBUTES_MATCH_TYPE, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFAttributes*, MF_ATTRIBUTES_MATCH_TYPE, BOOL*, int> Compare;
        [NativeTypeName("HRESULT (const GUID &, UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, uint*, int> GetUINT32;
        [NativeTypeName("HRESULT (const GUID &, UINT64 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, ulong*, int> GetUINT64;
        [NativeTypeName("HRESULT (const GUID &, double *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, double*, int> GetDouble;
        [NativeTypeName("HRESULT (const GUID &, GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, Guid*, int> GetGUID;
        [NativeTypeName("HRESULT (const GUID &, UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, uint*, int> GetStringLength;
        [NativeTypeName("HRESULT (const GUID &, LPWSTR, UINT32, UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, ushort*, uint, uint*, int> GetString;
        [NativeTypeName("HRESULT (const GUID &, LPWSTR *, UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, ushort**, uint*, int> GetAllocatedString;
        [NativeTypeName("HRESULT (const GUID &, UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, uint*, int> GetBlobSize;
        [NativeTypeName("HRESULT (const GUID &, UINT8 *, UINT32, UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, byte*, uint, uint*, int> GetBlob;
        [NativeTypeName("HRESULT (const GUID &, UINT8 **, UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, byte**, uint*, int> GetAllocatedBlob;
        [NativeTypeName("HRESULT (const GUID &, const IID &, LPVOID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, Guid*, void**, int> GetUnknown;
        [NativeTypeName("HRESULT (const GUID &, const PROPVARIANT &) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, PROPVARIANT*, int> SetItem;
        [NativeTypeName("HRESULT (const GUID &) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> DeleteItem;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> DeleteAllItems;
        [NativeTypeName("HRESULT (const GUID &, UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, uint, int> SetUINT32;
        [NativeTypeName("HRESULT (const GUID &, UINT64) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, ulong, int> SetUINT64;
        [NativeTypeName("HRESULT (const GUID &, double) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, double, int> SetDouble;
        [NativeTypeName("HRESULT (const GUID &, const GUID &) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, Guid*, int> SetGUID;
        [NativeTypeName("HRESULT (const GUID &, LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, ushort*, int> SetString;
        [NativeTypeName("HRESULT (const GUID &, const UINT8 *, UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, byte*, uint, int> SetBlob;
        [NativeTypeName("HRESULT (const GUID &, IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, IUnknown*, int> SetUnknown;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> LockStore;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> UnlockStore;
        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetCount;
        [NativeTypeName("HRESULT (UINT32, GUID *, PROPVARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, Guid*, PROPVARIANT*, int> GetItemByIndex;
        [NativeTypeName("HRESULT (IMFAttributes *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFAttributes*, int> CopyAllItems;
        [NativeTypeName("HRESULT (MediaEventType *) __attribute__((stdcall))")]
        public new delegate* unmanaged<TSelf*, uint*, int> GetType;
        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> GetExtendedType;
        [NativeTypeName("HRESULT (HRESULT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HRESULT*, int> GetStatus;
        [NativeTypeName("HRESULT (PROPVARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, PROPVARIANT*, int> GetValue;
    }
}