// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/imapi2.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("25983551-9D65-49CE-B335-40630D901227")]
[NativeTypeName("struct IRawCDImageTrackInfo : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IRawCDImageTrackInfo : IRawCDImageTrackInfo.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IRawCDImageTrackInfo));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IRawCDImageTrackInfo, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IRawCDImageTrackInfo, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IRawCDImageTrackInfo, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IRawCDImageTrackInfo, uint*, int>)((*lpVtbl)[3]))(
            this,
            pctinfo
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo* ppTInfo)
    {
        return (
            (delegate* unmanaged<IRawCDImageTrackInfo, uint, uint, ITypeInfo*, int>)((*lpVtbl)[4])
        )(this, iTInfo, lcid, ppTInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames(
        [NativeTypeName("const IID &")] Guid* riid,
        [NativeTypeName("LPOLESTR *")] ushort** rgszNames,
        uint cNames,
        [NativeTypeName("LCID")] uint lcid,
        [NativeTypeName("DISPID *")] int* rgDispId
    )
    {
        return (
            (delegate* unmanaged<IRawCDImageTrackInfo, Guid*, ushort**, uint, uint, int*, int>)(
                (*lpVtbl)[5]
            )
        )(this, riid, rgszNames, cNames, lcid, rgDispId);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke(
        [NativeTypeName("DISPID")] int dispIdMember,
        [NativeTypeName("const IID &")] Guid* riid,
        [NativeTypeName("LCID")] uint lcid,
        [NativeTypeName("WORD")] ushort wFlags,
        DISPPARAMS* pDispParams,
        VARIANT* pVarResult,
        EXCEPINFO* pExcepInfo,
        uint* puArgErr
    )
    {
        return (
            (delegate* unmanaged<
                IRawCDImageTrackInfo,
                int,
                Guid*,
                uint,
                ushort,
                DISPPARAMS*,
                VARIANT*,
                EXCEPINFO*,
                uint*,
                int>)((*lpVtbl)[6])
        )(this, dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_StartingLba([NativeTypeName("LONG *")] int* value)
    {
        return ((delegate* unmanaged<IRawCDImageTrackInfo, int*, int>)((*lpVtbl)[7]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_SectorCount([NativeTypeName("LONG *")] int* value)
    {
        return ((delegate* unmanaged<IRawCDImageTrackInfo, int*, int>)((*lpVtbl)[8]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_TrackNumber([NativeTypeName("LONG *")] int* value)
    {
        return ((delegate* unmanaged<IRawCDImageTrackInfo, int*, int>)((*lpVtbl)[9]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_SectorType(IMAPI_CD_SECTOR_TYPE* value)
    {
        return (
            (delegate* unmanaged<IRawCDImageTrackInfo, IMAPI_CD_SECTOR_TYPE*, int>)((*lpVtbl)[10])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_ISRC([NativeTypeName("BSTR *")] ushort** value)
    {
        return ((delegate* unmanaged<IRawCDImageTrackInfo, ushort**, int>)((*lpVtbl)[11]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT put_ISRC([NativeTypeName("BSTR")] ushort* value)
    {
        return ((delegate* unmanaged<IRawCDImageTrackInfo, ushort*, int>)((*lpVtbl)[12]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_DigitalAudioCopySetting(IMAPI_CD_TRACK_DIGITAL_COPY_SETTING* value)
    {
        return (
            (delegate* unmanaged<IRawCDImageTrackInfo, IMAPI_CD_TRACK_DIGITAL_COPY_SETTING*, int>)(
                (*lpVtbl)[13]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT put_DigitalAudioCopySetting(IMAPI_CD_TRACK_DIGITAL_COPY_SETTING value)
    {
        return (
            (delegate* unmanaged<IRawCDImageTrackInfo, IMAPI_CD_TRACK_DIGITAL_COPY_SETTING, int>)(
                (*lpVtbl)[14]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_AudioHasPreemphasis([NativeTypeName("VARIANT_BOOL *")] short* value)
    {
        return ((delegate* unmanaged<IRawCDImageTrackInfo, short*, int>)((*lpVtbl)[15]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT put_AudioHasPreemphasis([NativeTypeName("VARIANT_BOOL")] short value)
    {
        return ((delegate* unmanaged<IRawCDImageTrackInfo, short, int>)((*lpVtbl)[16]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_TrackIndexes(SAFEARRAY** value)
    {
        return ((delegate* unmanaged<IRawCDImageTrackInfo, SAFEARRAY**, int>)((*lpVtbl)[17]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT AddTrackIndex([NativeTypeName("LONG")] int lbaOffset)
    {
        return ((delegate* unmanaged<IRawCDImageTrackInfo, int, int>)((*lpVtbl)[18]))(
            this,
            lbaOffset
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT ClearTrackIndex([NativeTypeName("LONG")] int lbaOffset)
    {
        return ((delegate* unmanaged<IRawCDImageTrackInfo, int, int>)((*lpVtbl)[19]))(
            this,
            lbaOffset
        );
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT get_StartingLba([NativeTypeName("LONG *")] int* value);

        [VtblIndex(8)]
        HRESULT get_SectorCount([NativeTypeName("LONG *")] int* value);

        [VtblIndex(9)]
        HRESULT get_TrackNumber([NativeTypeName("LONG *")] int* value);

        [VtblIndex(10)]
        HRESULT get_SectorType(IMAPI_CD_SECTOR_TYPE* value);

        [VtblIndex(11)]
        HRESULT get_ISRC([NativeTypeName("BSTR *")] ushort** value);

        [VtblIndex(12)]
        HRESULT put_ISRC([NativeTypeName("BSTR")] ushort* value);

        [VtblIndex(13)]
        HRESULT get_DigitalAudioCopySetting(IMAPI_CD_TRACK_DIGITAL_COPY_SETTING* value);

        [VtblIndex(14)]
        HRESULT put_DigitalAudioCopySetting(IMAPI_CD_TRACK_DIGITAL_COPY_SETTING value);

        [VtblIndex(15)]
        HRESULT get_AudioHasPreemphasis([NativeTypeName("VARIANT_BOOL *")] short* value);

        [VtblIndex(16)]
        HRESULT put_AudioHasPreemphasis([NativeTypeName("VARIANT_BOOL")] short value);

        [VtblIndex(17)]
        HRESULT get_TrackIndexes(SAFEARRAY** value);

        [VtblIndex(18)]
        HRESULT AddTrackIndex([NativeTypeName("LONG")] int lbaOffset);

        [VtblIndex(19)]
        HRESULT ClearTrackIndex([NativeTypeName("LONG")] int lbaOffset);
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

        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetTypeInfoCount;

        [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, ITypeInfo*, int> GetTypeInfo;

        [NativeTypeName(
            "HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Guid*, ushort**, uint, uint, int*, int> GetIDsOfNames;

        [NativeTypeName(
            "HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            int,
            Guid*,
            uint,
            ushort,
            DISPPARAMS*,
            VARIANT*,
            EXCEPINFO*,
            uint*,
            int> Invoke;

        [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_StartingLba;

        [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_SectorCount;

        [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_TrackNumber;

        [NativeTypeName("HRESULT (IMAPI_CD_SECTOR_TYPE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMAPI_CD_SECTOR_TYPE*, int> get_SectorType;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_ISRC;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_ISRC;

        [NativeTypeName("HRESULT (IMAPI_CD_TRACK_DIGITAL_COPY_SETTING *) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            IMAPI_CD_TRACK_DIGITAL_COPY_SETTING*,
            int> get_DigitalAudioCopySetting;

        [NativeTypeName("HRESULT (IMAPI_CD_TRACK_DIGITAL_COPY_SETTING) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            IMAPI_CD_TRACK_DIGITAL_COPY_SETTING,
            int> put_DigitalAudioCopySetting;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_AudioHasPreemphasis;

        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> put_AudioHasPreemphasis;

        [NativeTypeName("HRESULT (SAFEARRAY **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SAFEARRAY**, int> get_TrackIndexes;

        [NativeTypeName("HRESULT (LONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> AddTrackIndex;

        [NativeTypeName("HRESULT (LONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> ClearTrackIndex;
    }

    /// <summary>Initializes a new instance of the <see cref = "IRawCDImageTrackInfo"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IRawCDImageTrackInfo(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IDispatch"/> to <see cref = "IRawCDImageTrackInfo"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IDispatch"/> instance to be converted </param>
    public static explicit operator IRawCDImageTrackInfo(Silk.NET.Windows.IDispatch value)
    {
        return new IRawCDImageTrackInfo(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IRawCDImageTrackInfo"/> to <see cref = "Silk.NET.Windows.IDispatch"/>.</summary>
    /// <param name = "value">The <see cref = "IRawCDImageTrackInfo"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IDispatch(IRawCDImageTrackInfo value)
    {
        return new Silk.NET.Windows.IDispatch(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IRawCDImageTrackInfo"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IRawCDImageTrackInfo(Silk.NET.Windows.IUnknown value)
    {
        return new IRawCDImageTrackInfo(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IRawCDImageTrackInfo"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IRawCDImageTrackInfo"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IRawCDImageTrackInfo value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
