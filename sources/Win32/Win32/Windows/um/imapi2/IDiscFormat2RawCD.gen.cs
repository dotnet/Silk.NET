// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/imapi2.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("27354155-8F64-5B0F-8F00-5D77AFBE261E")]
[NativeTypeName("struct IDiscFormat2RawCD : IDiscFormat2")]
[NativeInheritance("IDiscFormat2")]
public unsafe partial struct IDiscFormat2RawCD : IDiscFormat2RawCD.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDiscFormat2RawCD));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDiscFormat2RawCD, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDiscFormat2RawCD, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDiscFormat2RawCD, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IDiscFormat2RawCD, uint*, int>)((*lpVtbl)[3]))(this, pctinfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo* ppTInfo)
    {
        return (
            (delegate* unmanaged<IDiscFormat2RawCD, uint, uint, ITypeInfo*, int>)((*lpVtbl)[4])
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
            (delegate* unmanaged<IDiscFormat2RawCD, Guid*, ushort**, uint, uint, int*, int>)(
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
                IDiscFormat2RawCD,
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
    public HRESULT IsRecorderSupported(
        IDiscRecorder2 recorder,
        [NativeTypeName("VARIANT_BOOL *")] short* value
    )
    {
        return (
            (delegate* unmanaged<IDiscFormat2RawCD, IDiscRecorder2, short*, int>)((*lpVtbl)[7])
        )(this, recorder, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT IsCurrentMediaSupported(
        IDiscRecorder2 recorder,
        [NativeTypeName("VARIANT_BOOL *")] short* value
    )
    {
        return (
            (delegate* unmanaged<IDiscFormat2RawCD, IDiscRecorder2, short*, int>)((*lpVtbl)[8])
        )(this, recorder, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_MediaPhysicallyBlank([NativeTypeName("VARIANT_BOOL *")] short* value)
    {
        return ((delegate* unmanaged<IDiscFormat2RawCD, short*, int>)((*lpVtbl)[9]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_MediaHeuristicallyBlank([NativeTypeName("VARIANT_BOOL *")] short* value)
    {
        return ((delegate* unmanaged<IDiscFormat2RawCD, short*, int>)((*lpVtbl)[10]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_SupportedMediaTypes(SAFEARRAY** value)
    {
        return ((delegate* unmanaged<IDiscFormat2RawCD, SAFEARRAY**, int>)((*lpVtbl)[11]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT PrepareMedia()
    {
        return ((delegate* unmanaged<IDiscFormat2RawCD, int>)((*lpVtbl)[12]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT WriteMedia(IStream data)
    {
        return ((delegate* unmanaged<IDiscFormat2RawCD, IStream, int>)((*lpVtbl)[13]))(this, data);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT WriteMedia2(IStream data, [NativeTypeName("LONG")] int streamLeadInSectors)
    {
        return ((delegate* unmanaged<IDiscFormat2RawCD, IStream, int, int>)((*lpVtbl)[14]))(
            this,
            data,
            streamLeadInSectors
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT CancelWrite()
    {
        return ((delegate* unmanaged<IDiscFormat2RawCD, int>)((*lpVtbl)[15]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT ReleaseMedia()
    {
        return ((delegate* unmanaged<IDiscFormat2RawCD, int>)((*lpVtbl)[16]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT SetWriteSpeed(
        [NativeTypeName("LONG")] int RequestedSectorsPerSecond,
        [NativeTypeName("VARIANT_BOOL")] short RotationTypeIsPureCAV
    )
    {
        return ((delegate* unmanaged<IDiscFormat2RawCD, int, short, int>)((*lpVtbl)[17]))(
            this,
            RequestedSectorsPerSecond,
            RotationTypeIsPureCAV
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT put_Recorder(IDiscRecorder2 value)
    {
        return ((delegate* unmanaged<IDiscFormat2RawCD, IDiscRecorder2, int>)((*lpVtbl)[18]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_Recorder(IDiscRecorder2* value)
    {
        return ((delegate* unmanaged<IDiscFormat2RawCD, IDiscRecorder2*, int>)((*lpVtbl)[19]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT put_BufferUnderrunFreeDisabled([NativeTypeName("VARIANT_BOOL")] short value)
    {
        return ((delegate* unmanaged<IDiscFormat2RawCD, short, int>)((*lpVtbl)[20]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT get_BufferUnderrunFreeDisabled([NativeTypeName("VARIANT_BOOL *")] short* value)
    {
        return ((delegate* unmanaged<IDiscFormat2RawCD, short*, int>)((*lpVtbl)[21]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT get_StartOfNextSession([NativeTypeName("LONG *")] int* value)
    {
        return ((delegate* unmanaged<IDiscFormat2RawCD, int*, int>)((*lpVtbl)[22]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT get_LastPossibleStartOfLeadout([NativeTypeName("LONG *")] int* value)
    {
        return ((delegate* unmanaged<IDiscFormat2RawCD, int*, int>)((*lpVtbl)[23]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT get_CurrentPhysicalMediaType(IMAPI_MEDIA_PHYSICAL_TYPE* value)
    {
        return (
            (delegate* unmanaged<IDiscFormat2RawCD, IMAPI_MEDIA_PHYSICAL_TYPE*, int>)((*lpVtbl)[24])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT get_SupportedSectorTypes(SAFEARRAY** value)
    {
        return ((delegate* unmanaged<IDiscFormat2RawCD, SAFEARRAY**, int>)((*lpVtbl)[25]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT put_RequestedSectorType(IMAPI_FORMAT2_RAW_CD_DATA_SECTOR_TYPE value)
    {
        return (
            (delegate* unmanaged<IDiscFormat2RawCD, IMAPI_FORMAT2_RAW_CD_DATA_SECTOR_TYPE, int>)(
                (*lpVtbl)[26]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT get_RequestedSectorType(IMAPI_FORMAT2_RAW_CD_DATA_SECTOR_TYPE* value)
    {
        return (
            (delegate* unmanaged<IDiscFormat2RawCD, IMAPI_FORMAT2_RAW_CD_DATA_SECTOR_TYPE*, int>)(
                (*lpVtbl)[27]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT put_ClientName([NativeTypeName("BSTR")] ushort* value)
    {
        return ((delegate* unmanaged<IDiscFormat2RawCD, ushort*, int>)((*lpVtbl)[28]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT get_ClientName([NativeTypeName("BSTR *")] ushort** value)
    {
        return ((delegate* unmanaged<IDiscFormat2RawCD, ushort**, int>)((*lpVtbl)[29]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT get_RequestedWriteSpeed([NativeTypeName("LONG *")] int* value)
    {
        return ((delegate* unmanaged<IDiscFormat2RawCD, int*, int>)((*lpVtbl)[30]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT get_RequestedRotationTypeIsPureCAV(
        [NativeTypeName("VARIANT_BOOL *")] short* value
    )
    {
        return ((delegate* unmanaged<IDiscFormat2RawCD, short*, int>)((*lpVtbl)[31]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT get_CurrentWriteSpeed([NativeTypeName("LONG *")] int* value)
    {
        return ((delegate* unmanaged<IDiscFormat2RawCD, int*, int>)((*lpVtbl)[32]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT get_CurrentRotationTypeIsPureCAV([NativeTypeName("VARIANT_BOOL *")] short* value)
    {
        return ((delegate* unmanaged<IDiscFormat2RawCD, short*, int>)((*lpVtbl)[33]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT get_SupportedWriteSpeeds(SAFEARRAY** supportedSpeeds)
    {
        return ((delegate* unmanaged<IDiscFormat2RawCD, SAFEARRAY**, int>)((*lpVtbl)[34]))(
            this,
            supportedSpeeds
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT get_SupportedWriteSpeedDescriptors(SAFEARRAY** supportedSpeedDescriptors)
    {
        return ((delegate* unmanaged<IDiscFormat2RawCD, SAFEARRAY**, int>)((*lpVtbl)[35]))(
            this,
            supportedSpeedDescriptors
        );
    }

    public interface Interface : IDiscFormat2.Interface
    {
        [VtblIndex(12)]
        HRESULT PrepareMedia();

        [VtblIndex(13)]
        HRESULT WriteMedia(IStream data);

        [VtblIndex(14)]
        HRESULT WriteMedia2(IStream data, [NativeTypeName("LONG")] int streamLeadInSectors);

        [VtblIndex(15)]
        HRESULT CancelWrite();

        [VtblIndex(16)]
        HRESULT ReleaseMedia();

        [VtblIndex(17)]
        HRESULT SetWriteSpeed(
            [NativeTypeName("LONG")] int RequestedSectorsPerSecond,
            [NativeTypeName("VARIANT_BOOL")] short RotationTypeIsPureCAV
        );

        [VtblIndex(18)]
        HRESULT put_Recorder(IDiscRecorder2 value);

        [VtblIndex(19)]
        HRESULT get_Recorder(IDiscRecorder2* value);

        [VtblIndex(20)]
        HRESULT put_BufferUnderrunFreeDisabled([NativeTypeName("VARIANT_BOOL")] short value);

        [VtblIndex(21)]
        HRESULT get_BufferUnderrunFreeDisabled([NativeTypeName("VARIANT_BOOL *")] short* value);

        [VtblIndex(22)]
        HRESULT get_StartOfNextSession([NativeTypeName("LONG *")] int* value);

        [VtblIndex(23)]
        HRESULT get_LastPossibleStartOfLeadout([NativeTypeName("LONG *")] int* value);

        [VtblIndex(24)]
        HRESULT get_CurrentPhysicalMediaType(IMAPI_MEDIA_PHYSICAL_TYPE* value);

        [VtblIndex(25)]
        HRESULT get_SupportedSectorTypes(SAFEARRAY** value);

        [VtblIndex(26)]
        HRESULT put_RequestedSectorType(IMAPI_FORMAT2_RAW_CD_DATA_SECTOR_TYPE value);

        [VtblIndex(27)]
        HRESULT get_RequestedSectorType(IMAPI_FORMAT2_RAW_CD_DATA_SECTOR_TYPE* value);

        [VtblIndex(28)]
        HRESULT put_ClientName([NativeTypeName("BSTR")] ushort* value);

        [VtblIndex(29)]
        HRESULT get_ClientName([NativeTypeName("BSTR *")] ushort** value);

        [VtblIndex(30)]
        HRESULT get_RequestedWriteSpeed([NativeTypeName("LONG *")] int* value);

        [VtblIndex(31)]
        HRESULT get_RequestedRotationTypeIsPureCAV([NativeTypeName("VARIANT_BOOL *")] short* value);

        [VtblIndex(32)]
        HRESULT get_CurrentWriteSpeed([NativeTypeName("LONG *")] int* value);

        [VtblIndex(33)]
        HRESULT get_CurrentRotationTypeIsPureCAV([NativeTypeName("VARIANT_BOOL *")] short* value);

        [VtblIndex(34)]
        HRESULT get_SupportedWriteSpeeds(SAFEARRAY** supportedSpeeds);

        [VtblIndex(35)]
        HRESULT get_SupportedWriteSpeedDescriptors(SAFEARRAY** supportedSpeedDescriptors);
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

        [NativeTypeName("HRESULT (IDiscRecorder2 *, VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDiscRecorder2, short*, int> IsRecorderSupported;

        [NativeTypeName("HRESULT (IDiscRecorder2 *, VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDiscRecorder2, short*, int> IsCurrentMediaSupported;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_MediaPhysicallyBlank;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_MediaHeuristicallyBlank;

        [NativeTypeName("HRESULT (SAFEARRAY **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SAFEARRAY**, int> get_SupportedMediaTypes;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> PrepareMedia;

        [NativeTypeName("HRESULT (IStream *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IStream, int> WriteMedia;

        [NativeTypeName("HRESULT (IStream *, LONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IStream, int, int> WriteMedia2;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> CancelWrite;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> ReleaseMedia;

        [NativeTypeName("HRESULT (LONG, VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, short, int> SetWriteSpeed;

        [NativeTypeName("HRESULT (IDiscRecorder2 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDiscRecorder2, int> put_Recorder;

        [NativeTypeName("HRESULT (IDiscRecorder2 **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDiscRecorder2*, int> get_Recorder;

        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> put_BufferUnderrunFreeDisabled;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_BufferUnderrunFreeDisabled;

        [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_StartOfNextSession;

        [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_LastPossibleStartOfLeadout;

        [NativeTypeName("HRESULT (IMAPI_MEDIA_PHYSICAL_TYPE *) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            IMAPI_MEDIA_PHYSICAL_TYPE*,
            int> get_CurrentPhysicalMediaType;

        [NativeTypeName("HRESULT (SAFEARRAY **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SAFEARRAY**, int> get_SupportedSectorTypes;

        [NativeTypeName("HRESULT (IMAPI_FORMAT2_RAW_CD_DATA_SECTOR_TYPE) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            IMAPI_FORMAT2_RAW_CD_DATA_SECTOR_TYPE,
            int> put_RequestedSectorType;

        [NativeTypeName(
            "HRESULT (IMAPI_FORMAT2_RAW_CD_DATA_SECTOR_TYPE *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IMAPI_FORMAT2_RAW_CD_DATA_SECTOR_TYPE*,
            int> get_RequestedSectorType;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_ClientName;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_ClientName;

        [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_RequestedWriteSpeed;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_RequestedRotationTypeIsPureCAV;

        [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_CurrentWriteSpeed;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_CurrentRotationTypeIsPureCAV;

        [NativeTypeName("HRESULT (SAFEARRAY **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SAFEARRAY**, int> get_SupportedWriteSpeeds;

        [NativeTypeName("HRESULT (SAFEARRAY **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SAFEARRAY**, int> get_SupportedWriteSpeedDescriptors;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDiscFormat2RawCD"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDiscFormat2RawCD(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IDiscFormat2"/> to <see cref = "IDiscFormat2RawCD"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IDiscFormat2"/> instance to be converted </param>
    public static explicit operator IDiscFormat2RawCD(Silk.NET.Windows.IDiscFormat2 value)
    {
        return new IDiscFormat2RawCD(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDiscFormat2RawCD"/> to <see cref = "Silk.NET.Windows.IDiscFormat2"/>.</summary>
    /// <param name = "value">The <see cref = "IDiscFormat2RawCD"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IDiscFormat2(IDiscFormat2RawCD value)
    {
        return new Silk.NET.Windows.IDiscFormat2(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IDispatch"/> to <see cref = "IDiscFormat2RawCD"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IDispatch"/> instance to be converted </param>
    public static explicit operator IDiscFormat2RawCD(Silk.NET.Windows.IDispatch value)
    {
        return new IDiscFormat2RawCD(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDiscFormat2RawCD"/> to <see cref = "Silk.NET.Windows.IDispatch"/>.</summary>
    /// <param name = "value">The <see cref = "IDiscFormat2RawCD"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IDispatch(IDiscFormat2RawCD value)
    {
        return new Silk.NET.Windows.IDispatch(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDiscFormat2RawCD"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDiscFormat2RawCD(Silk.NET.Windows.IUnknown value)
    {
        return new IDiscFormat2RawCD(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDiscFormat2RawCD"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDiscFormat2RawCD"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDiscFormat2RawCD value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
