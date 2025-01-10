// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("92D43D0F-54A8-4BAE-96DA-356D259A5C26")]
[NativeTypeName("struct IMFCameraControlDefaultsCollection : IMFAttributes")]
[NativeInheritance("IMFAttributes")]
[SupportedOSPlatform("windows10.0.22621.0")]
public unsafe partial struct IMFCameraControlDefaultsCollection
    : IMFCameraControlDefaultsCollection.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFCameraControlDefaultsCollection));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IMFCameraControlDefaultsCollection, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFCameraControlDefaultsCollection, uint>)((*lpVtbl)[1]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFCameraControlDefaultsCollection, uint>)((*lpVtbl)[2]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetItem([NativeTypeName("const GUID &")] Guid* guidKey, PROPVARIANT* pValue)
    {
        return (
            (delegate* unmanaged<IMFCameraControlDefaultsCollection, Guid*, PROPVARIANT*, int>)(
                (*lpVtbl)[3]
            )
        )(this, guidKey, pValue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetItemType(
        [NativeTypeName("const GUID &")] Guid* guidKey,
        MF_ATTRIBUTE_TYPE* pType
    )
    {
        return (
            (delegate* unmanaged<
                IMFCameraControlDefaultsCollection,
                Guid*,
                MF_ATTRIBUTE_TYPE*,
                int>)((*lpVtbl)[4])
        )(this, guidKey, pType);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT CompareItem(
        [NativeTypeName("const GUID &")] Guid* guidKey,
        [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* Value,
        BOOL* pbResult
    )
    {
        return (
            (delegate* unmanaged<
                IMFCameraControlDefaultsCollection,
                Guid*,
                PROPVARIANT*,
                BOOL*,
                int>)((*lpVtbl)[5])
        )(this, guidKey, Value, pbResult);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Compare(
        IMFAttributes pTheirs,
        MF_ATTRIBUTES_MATCH_TYPE MatchType,
        BOOL* pbResult
    )
    {
        return (
            (delegate* unmanaged<
                IMFCameraControlDefaultsCollection,
                IMFAttributes,
                MF_ATTRIBUTES_MATCH_TYPE,
                BOOL*,
                int>)((*lpVtbl)[6])
        )(this, pTheirs, MatchType, pbResult);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetUINT32(
        [NativeTypeName("const GUID &")] Guid* guidKey,
        [NativeTypeName("UINT32 *")] uint* punValue
    )
    {
        return (
            (delegate* unmanaged<IMFCameraControlDefaultsCollection, Guid*, uint*, int>)(
                (*lpVtbl)[7]
            )
        )(this, guidKey, punValue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetUINT64(
        [NativeTypeName("const GUID &")] Guid* guidKey,
        [NativeTypeName("UINT64 *")] ulong* punValue
    )
    {
        return (
            (delegate* unmanaged<IMFCameraControlDefaultsCollection, Guid*, ulong*, int>)(
                (*lpVtbl)[8]
            )
        )(this, guidKey, punValue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetDouble([NativeTypeName("const GUID &")] Guid* guidKey, double* pfValue)
    {
        return (
            (delegate* unmanaged<IMFCameraControlDefaultsCollection, Guid*, double*, int>)(
                (*lpVtbl)[9]
            )
        )(this, guidKey, pfValue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetGUID([NativeTypeName("const GUID &")] Guid* guidKey, Guid* pguidValue)
    {
        return (
            (delegate* unmanaged<IMFCameraControlDefaultsCollection, Guid*, Guid*, int>)(
                (*lpVtbl)[10]
            )
        )(this, guidKey, pguidValue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetStringLength(
        [NativeTypeName("const GUID &")] Guid* guidKey,
        [NativeTypeName("UINT32 *")] uint* pcchLength
    )
    {
        return (
            (delegate* unmanaged<IMFCameraControlDefaultsCollection, Guid*, uint*, int>)(
                (*lpVtbl)[11]
            )
        )(this, guidKey, pcchLength);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetString(
        [NativeTypeName("const GUID &")] Guid* guidKey,
        [NativeTypeName("LPWSTR")] ushort* pwszValue,
        [NativeTypeName("UINT32")] uint cchBufSize,
        [NativeTypeName("UINT32 *")] uint* pcchLength
    )
    {
        return (
            (delegate* unmanaged<
                IMFCameraControlDefaultsCollection,
                Guid*,
                ushort*,
                uint,
                uint*,
                int>)((*lpVtbl)[12])
        )(this, guidKey, pwszValue, cchBufSize, pcchLength);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetAllocatedString(
        [NativeTypeName("const GUID &")] Guid* guidKey,
        [NativeTypeName("LPWSTR *")] ushort** ppwszValue,
        [NativeTypeName("UINT32 *")] uint* pcchLength
    )
    {
        return (
            (delegate* unmanaged<IMFCameraControlDefaultsCollection, Guid*, ushort**, uint*, int>)(
                (*lpVtbl)[13]
            )
        )(this, guidKey, ppwszValue, pcchLength);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetBlobSize(
        [NativeTypeName("const GUID &")] Guid* guidKey,
        [NativeTypeName("UINT32 *")] uint* pcbBlobSize
    )
    {
        return (
            (delegate* unmanaged<IMFCameraControlDefaultsCollection, Guid*, uint*, int>)(
                (*lpVtbl)[14]
            )
        )(this, guidKey, pcbBlobSize);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetBlob(
        [NativeTypeName("const GUID &")] Guid* guidKey,
        [NativeTypeName("UINT8 *")] byte* pBuf,
        [NativeTypeName("UINT32")] uint cbBufSize,
        [NativeTypeName("UINT32 *")] uint* pcbBlobSize
    )
    {
        return (
            (delegate* unmanaged<
                IMFCameraControlDefaultsCollection,
                Guid*,
                byte*,
                uint,
                uint*,
                int>)((*lpVtbl)[15])
        )(this, guidKey, pBuf, cbBufSize, pcbBlobSize);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT GetAllocatedBlob(
        [NativeTypeName("const GUID &")] Guid* guidKey,
        [NativeTypeName("UINT8 **")] byte** ppBuf,
        [NativeTypeName("UINT32 *")] uint* pcbSize
    )
    {
        return (
            (delegate* unmanaged<IMFCameraControlDefaultsCollection, Guid*, byte**, uint*, int>)(
                (*lpVtbl)[16]
            )
        )(this, guidKey, ppBuf, pcbSize);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT GetUnknown(
        [NativeTypeName("const GUID &")] Guid* guidKey,
        [NativeTypeName("const IID &")] Guid* riid,
        [NativeTypeName("LPVOID *")] void** ppv
    )
    {
        return (
            (delegate* unmanaged<IMFCameraControlDefaultsCollection, Guid*, Guid*, void**, int>)(
                (*lpVtbl)[17]
            )
        )(this, guidKey, riid, ppv);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT SetItem(
        [NativeTypeName("const GUID &")] Guid* guidKey,
        [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* Value
    )
    {
        return (
            (delegate* unmanaged<IMFCameraControlDefaultsCollection, Guid*, PROPVARIANT*, int>)(
                (*lpVtbl)[18]
            )
        )(this, guidKey, Value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT DeleteItem([NativeTypeName("const GUID &")] Guid* guidKey)
    {
        return (
            (delegate* unmanaged<IMFCameraControlDefaultsCollection, Guid*, int>)((*lpVtbl)[19])
        )(this, guidKey);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT DeleteAllItems()
    {
        return ((delegate* unmanaged<IMFCameraControlDefaultsCollection, int>)((*lpVtbl)[20]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT SetUINT32(
        [NativeTypeName("const GUID &")] Guid* guidKey,
        [NativeTypeName("UINT32")] uint unValue
    )
    {
        return (
            (delegate* unmanaged<IMFCameraControlDefaultsCollection, Guid*, uint, int>)(
                (*lpVtbl)[21]
            )
        )(this, guidKey, unValue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT SetUINT64(
        [NativeTypeName("const GUID &")] Guid* guidKey,
        [NativeTypeName("UINT64")] ulong unValue
    )
    {
        return (
            (delegate* unmanaged<IMFCameraControlDefaultsCollection, Guid*, ulong, int>)(
                (*lpVtbl)[22]
            )
        )(this, guidKey, unValue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT SetDouble([NativeTypeName("const GUID &")] Guid* guidKey, double fValue)
    {
        return (
            (delegate* unmanaged<IMFCameraControlDefaultsCollection, Guid*, double, int>)(
                (*lpVtbl)[23]
            )
        )(this, guidKey, fValue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT SetGUID(
        [NativeTypeName("const GUID &")] Guid* guidKey,
        [NativeTypeName("const GUID &")] Guid* guidValue
    )
    {
        return (
            (delegate* unmanaged<IMFCameraControlDefaultsCollection, Guid*, Guid*, int>)(
                (*lpVtbl)[24]
            )
        )(this, guidKey, guidValue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT SetString(
        [NativeTypeName("const GUID &")] Guid* guidKey,
        [NativeTypeName("LPCWSTR")] ushort* wszValue
    )
    {
        return (
            (delegate* unmanaged<IMFCameraControlDefaultsCollection, Guid*, ushort*, int>)(
                (*lpVtbl)[25]
            )
        )(this, guidKey, wszValue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT SetBlob(
        [NativeTypeName("const GUID &")] Guid* guidKey,
        [NativeTypeName("const UINT8 *")] byte* pBuf,
        [NativeTypeName("UINT32")] uint cbBufSize
    )
    {
        return (
            (delegate* unmanaged<IMFCameraControlDefaultsCollection, Guid*, byte*, uint, int>)(
                (*lpVtbl)[26]
            )
        )(this, guidKey, pBuf, cbBufSize);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT SetUnknown([NativeTypeName("const GUID &")] Guid* guidKey, IUnknown pUnknown)
    {
        return (
            (delegate* unmanaged<IMFCameraControlDefaultsCollection, Guid*, IUnknown, int>)(
                (*lpVtbl)[27]
            )
        )(this, guidKey, pUnknown);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT LockStore()
    {
        return ((delegate* unmanaged<IMFCameraControlDefaultsCollection, int>)((*lpVtbl)[28]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT UnlockStore()
    {
        return ((delegate* unmanaged<IMFCameraControlDefaultsCollection, int>)((*lpVtbl)[29]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT GetCount([NativeTypeName("UINT32 *")] uint* pcItems)
    {
        return (
            (delegate* unmanaged<IMFCameraControlDefaultsCollection, uint*, int>)((*lpVtbl)[30])
        )(this, pcItems);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT GetItemByIndex(
        [NativeTypeName("UINT32")] uint unIndex,
        Guid* pguidKey,
        PROPVARIANT* pValue
    )
    {
        return (
            (delegate* unmanaged<
                IMFCameraControlDefaultsCollection,
                uint,
                Guid*,
                PROPVARIANT*,
                int>)((*lpVtbl)[31])
        )(this, unIndex, pguidKey, pValue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT CopyAllItems(IMFAttributes pDest)
    {
        return (
            (delegate* unmanaged<IMFCameraControlDefaultsCollection, IMFAttributes, int>)(
                (*lpVtbl)[32]
            )
        )(this, pDest);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    [return: NativeTypeName("ULONG")]
    public uint GetControlCount()
    {
        return ((delegate* unmanaged<IMFCameraControlDefaultsCollection, uint>)((*lpVtbl)[33]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT GetControl(
        [NativeTypeName("ULONG")] uint index,
        IMFCameraControlDefaults* configuration
    )
    {
        return (
            (delegate* unmanaged<
                IMFCameraControlDefaultsCollection,
                uint,
                IMFCameraControlDefaults*,
                int>)((*lpVtbl)[34])
        )(this, index, configuration);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT GetOrAddExtendedControl(
        MF_CAMERA_CONTROL_CONFIGURATION_TYPE configType,
        [NativeTypeName("ULONG")] uint constrolId,
        [NativeTypeName("DWORD")] uint streamId,
        [NativeTypeName("ULONG")] uint dataSize,
        IMFCameraControlDefaults* defaults
    )
    {
        return (
            (delegate* unmanaged<
                IMFCameraControlDefaultsCollection,
                MF_CAMERA_CONTROL_CONFIGURATION_TYPE,
                uint,
                uint,
                uint,
                IMFCameraControlDefaults*,
                int>)((*lpVtbl)[35])
        )(this, configType, constrolId, streamId, dataSize, defaults);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT GetOrAddControl(
        MF_CAMERA_CONTROL_CONFIGURATION_TYPE configType,
        [NativeTypeName("const GUID &")] Guid* controlSet,
        [NativeTypeName("ULONG")] uint constrolId,
        [NativeTypeName("ULONG")] uint controlSize,
        [NativeTypeName("ULONG")] uint dataSize,
        IMFCameraControlDefaults* defaults
    )
    {
        return (
            (delegate* unmanaged<
                IMFCameraControlDefaultsCollection,
                MF_CAMERA_CONTROL_CONFIGURATION_TYPE,
                Guid*,
                uint,
                uint,
                uint,
                IMFCameraControlDefaults*,
                int>)((*lpVtbl)[36])
        )(this, configType, controlSet, constrolId, controlSize, dataSize, defaults);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public HRESULT RemoveControl(
        [NativeTypeName("const GUID &")] Guid* controlSet,
        [NativeTypeName("ULONG")] uint constrolId
    )
    {
        return (
            (delegate* unmanaged<IMFCameraControlDefaultsCollection, Guid*, uint, int>)(
                (*lpVtbl)[37]
            )
        )(this, controlSet, constrolId);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public HRESULT RemoveAllControls()
    {
        return ((delegate* unmanaged<IMFCameraControlDefaultsCollection, int>)((*lpVtbl)[38]))(
            this
        );
    }

    public interface Interface : IMFAttributes.Interface
    {
        [VtblIndex(33)]
        [return: NativeTypeName("ULONG")]
        uint GetControlCount();

        [VtblIndex(34)]
        HRESULT GetControl(
            [NativeTypeName("ULONG")] uint index,
            IMFCameraControlDefaults* configuration
        );

        [VtblIndex(35)]
        HRESULT GetOrAddExtendedControl(
            MF_CAMERA_CONTROL_CONFIGURATION_TYPE configType,
            [NativeTypeName("ULONG")] uint constrolId,
            [NativeTypeName("DWORD")] uint streamId,
            [NativeTypeName("ULONG")] uint dataSize,
            IMFCameraControlDefaults* defaults
        );

        [VtblIndex(36)]
        HRESULT GetOrAddControl(
            MF_CAMERA_CONTROL_CONFIGURATION_TYPE configType,
            [NativeTypeName("const GUID &")] Guid* controlSet,
            [NativeTypeName("ULONG")] uint constrolId,
            [NativeTypeName("ULONG")] uint controlSize,
            [NativeTypeName("ULONG")] uint dataSize,
            IMFCameraControlDefaults* defaults
        );

        [VtblIndex(37)]
        HRESULT RemoveControl(
            [NativeTypeName("const GUID &")] Guid* controlSet,
            [NativeTypeName("ULONG")] uint constrolId
        );

        [VtblIndex(38)]
        HRESULT RemoveAllControls();
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

        [NativeTypeName(
            "HRESULT (const GUID &, const PROPVARIANT &, BOOL *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Guid*, PROPVARIANT*, BOOL*, int> CompareItem;

        [NativeTypeName(
            "HRESULT (IMFAttributes *, MF_ATTRIBUTES_MATCH_TYPE, BOOL *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IMFAttributes,
            MF_ATTRIBUTES_MATCH_TYPE,
            BOOL*,
            int> Compare;

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

        [NativeTypeName(
            "HRESULT (const GUID &, LPWSTR, UINT32, UINT32 *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Guid*, ushort*, uint, uint*, int> GetString;

        [NativeTypeName("HRESULT (const GUID &, LPWSTR *, UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, ushort**, uint*, int> GetAllocatedString;

        [NativeTypeName("HRESULT (const GUID &, UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, uint*, int> GetBlobSize;

        [NativeTypeName(
            "HRESULT (const GUID &, UINT8 *, UINT32, UINT32 *) __attribute__((stdcall))"
        )]
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
        public delegate* unmanaged<TSelf*, Guid*, IUnknown, int> SetUnknown;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> LockStore;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> UnlockStore;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetCount;

        [NativeTypeName("HRESULT (UINT32, GUID *, PROPVARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, Guid*, PROPVARIANT*, int> GetItemByIndex;

        [NativeTypeName("HRESULT (IMFAttributes *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFAttributes, int> CopyAllItems;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> GetControlCount;

        [NativeTypeName("HRESULT (ULONG, IMFCameraControlDefaults **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IMFCameraControlDefaults*, int> GetControl;

        [NativeTypeName(
            "HRESULT (MF_CAMERA_CONTROL_CONFIGURATION_TYPE, ULONG, DWORD, ULONG, IMFCameraControlDefaults **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            MF_CAMERA_CONTROL_CONFIGURATION_TYPE,
            uint,
            uint,
            uint,
            IMFCameraControlDefaults*,
            int> GetOrAddExtendedControl;

        [NativeTypeName(
            "HRESULT (MF_CAMERA_CONTROL_CONFIGURATION_TYPE, const GUID &, ULONG, ULONG, ULONG, IMFCameraControlDefaults **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            MF_CAMERA_CONTROL_CONFIGURATION_TYPE,
            Guid*,
            uint,
            uint,
            uint,
            IMFCameraControlDefaults*,
            int> GetOrAddControl;

        [NativeTypeName("HRESULT (const GUID &, ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, uint, int> RemoveControl;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> RemoveAllControls;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMFCameraControlDefaultsCollection"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMFCameraControlDefaultsCollection(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IMFAttributes"/> to <see cref = "IMFCameraControlDefaultsCollection"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IMFAttributes"/> instance to be converted </param>
    public static explicit operator IMFCameraControlDefaultsCollection(
        Silk.NET.Windows.IMFAttributes value
    )
    {
        return new IMFCameraControlDefaultsCollection(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFCameraControlDefaultsCollection"/> to <see cref = "Silk.NET.Windows.IMFAttributes"/>.</summary>
    /// <param name = "value">The <see cref = "IMFCameraControlDefaultsCollection"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IMFAttributes(
        IMFCameraControlDefaultsCollection value
    )
    {
        return new Silk.NET.Windows.IMFAttributes(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMFCameraControlDefaultsCollection"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMFCameraControlDefaultsCollection(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IMFCameraControlDefaultsCollection(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFCameraControlDefaultsCollection"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMFCameraControlDefaultsCollection"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IMFCameraControlDefaultsCollection value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
