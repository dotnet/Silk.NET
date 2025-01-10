// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/imapi2.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("27354153-9F64-5B0F-8F00-5D77AFBE261E")]
[NativeTypeName("struct IDiscFormat2Data : IDiscFormat2")]
[NativeInheritance("IDiscFormat2")]
public unsafe partial struct IDiscFormat2Data : IDiscFormat2Data.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDiscFormat2Data));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDiscFormat2Data, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDiscFormat2Data, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDiscFormat2Data, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IDiscFormat2Data, uint*, int>)((*lpVtbl)[3]))(this, pctinfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo* ppTInfo)
    {
        return ((delegate* unmanaged<IDiscFormat2Data, uint, uint, ITypeInfo*, int>)((*lpVtbl)[4]))(
            this,
            iTInfo,
            lcid,
            ppTInfo
        );
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
            (delegate* unmanaged<IDiscFormat2Data, Guid*, ushort**, uint, uint, int*, int>)(
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
                IDiscFormat2Data,
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
        return ((delegate* unmanaged<IDiscFormat2Data, IDiscRecorder2, short*, int>)((*lpVtbl)[7]))(
            this,
            recorder,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT IsCurrentMediaSupported(
        IDiscRecorder2 recorder,
        [NativeTypeName("VARIANT_BOOL *")] short* value
    )
    {
        return ((delegate* unmanaged<IDiscFormat2Data, IDiscRecorder2, short*, int>)((*lpVtbl)[8]))(
            this,
            recorder,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_MediaPhysicallyBlank([NativeTypeName("VARIANT_BOOL *")] short* value)
    {
        return ((delegate* unmanaged<IDiscFormat2Data, short*, int>)((*lpVtbl)[9]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_MediaHeuristicallyBlank([NativeTypeName("VARIANT_BOOL *")] short* value)
    {
        return ((delegate* unmanaged<IDiscFormat2Data, short*, int>)((*lpVtbl)[10]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_SupportedMediaTypes(SAFEARRAY** value)
    {
        return ((delegate* unmanaged<IDiscFormat2Data, SAFEARRAY**, int>)((*lpVtbl)[11]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT put_Recorder(IDiscRecorder2 value)
    {
        return ((delegate* unmanaged<IDiscFormat2Data, IDiscRecorder2, int>)((*lpVtbl)[12]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_Recorder(IDiscRecorder2* value)
    {
        return ((delegate* unmanaged<IDiscFormat2Data, IDiscRecorder2*, int>)((*lpVtbl)[13]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT put_BufferUnderrunFreeDisabled([NativeTypeName("VARIANT_BOOL")] short value)
    {
        return ((delegate* unmanaged<IDiscFormat2Data, short, int>)((*lpVtbl)[14]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_BufferUnderrunFreeDisabled([NativeTypeName("VARIANT_BOOL *")] short* value)
    {
        return ((delegate* unmanaged<IDiscFormat2Data, short*, int>)((*lpVtbl)[15]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT put_PostgapAlreadyInImage([NativeTypeName("VARIANT_BOOL")] short value)
    {
        return ((delegate* unmanaged<IDiscFormat2Data, short, int>)((*lpVtbl)[16]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_PostgapAlreadyInImage([NativeTypeName("VARIANT_BOOL *")] short* value)
    {
        return ((delegate* unmanaged<IDiscFormat2Data, short*, int>)((*lpVtbl)[17]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_CurrentMediaStatus(IMAPI_FORMAT2_DATA_MEDIA_STATE* value)
    {
        return (
            (delegate* unmanaged<IDiscFormat2Data, IMAPI_FORMAT2_DATA_MEDIA_STATE*, int>)(
                (*lpVtbl)[18]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_WriteProtectStatus(IMAPI_MEDIA_WRITE_PROTECT_STATE* value)
    {
        return (
            (delegate* unmanaged<IDiscFormat2Data, IMAPI_MEDIA_WRITE_PROTECT_STATE*, int>)(
                (*lpVtbl)[19]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_TotalSectorsOnMedia([NativeTypeName("LONG *")] int* value)
    {
        return ((delegate* unmanaged<IDiscFormat2Data, int*, int>)((*lpVtbl)[20]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT get_FreeSectorsOnMedia([NativeTypeName("LONG *")] int* value)
    {
        return ((delegate* unmanaged<IDiscFormat2Data, int*, int>)((*lpVtbl)[21]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT get_NextWritableAddress([NativeTypeName("LONG *")] int* value)
    {
        return ((delegate* unmanaged<IDiscFormat2Data, int*, int>)((*lpVtbl)[22]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT get_StartAddressOfPreviousSession([NativeTypeName("LONG *")] int* value)
    {
        return ((delegate* unmanaged<IDiscFormat2Data, int*, int>)((*lpVtbl)[23]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT get_LastWrittenAddressOfPreviousSession([NativeTypeName("LONG *")] int* value)
    {
        return ((delegate* unmanaged<IDiscFormat2Data, int*, int>)((*lpVtbl)[24]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT put_ForceMediaToBeClosed([NativeTypeName("VARIANT_BOOL")] short value)
    {
        return ((delegate* unmanaged<IDiscFormat2Data, short, int>)((*lpVtbl)[25]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT get_ForceMediaToBeClosed([NativeTypeName("VARIANT_BOOL *")] short* value)
    {
        return ((delegate* unmanaged<IDiscFormat2Data, short*, int>)((*lpVtbl)[26]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT put_DisableConsumerDvdCompatibilityMode(
        [NativeTypeName("VARIANT_BOOL")] short value
    )
    {
        return ((delegate* unmanaged<IDiscFormat2Data, short, int>)((*lpVtbl)[27]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT get_DisableConsumerDvdCompatibilityMode(
        [NativeTypeName("VARIANT_BOOL *")] short* value
    )
    {
        return ((delegate* unmanaged<IDiscFormat2Data, short*, int>)((*lpVtbl)[28]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT get_CurrentPhysicalMediaType(IMAPI_MEDIA_PHYSICAL_TYPE* value)
    {
        return (
            (delegate* unmanaged<IDiscFormat2Data, IMAPI_MEDIA_PHYSICAL_TYPE*, int>)((*lpVtbl)[29])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT put_ClientName([NativeTypeName("BSTR")] ushort* value)
    {
        return ((delegate* unmanaged<IDiscFormat2Data, ushort*, int>)((*lpVtbl)[30]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT get_ClientName([NativeTypeName("BSTR *")] ushort** value)
    {
        return ((delegate* unmanaged<IDiscFormat2Data, ushort**, int>)((*lpVtbl)[31]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT get_RequestedWriteSpeed([NativeTypeName("LONG *")] int* value)
    {
        return ((delegate* unmanaged<IDiscFormat2Data, int*, int>)((*lpVtbl)[32]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT get_RequestedRotationTypeIsPureCAV(
        [NativeTypeName("VARIANT_BOOL *")] short* value
    )
    {
        return ((delegate* unmanaged<IDiscFormat2Data, short*, int>)((*lpVtbl)[33]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT get_CurrentWriteSpeed([NativeTypeName("LONG *")] int* value)
    {
        return ((delegate* unmanaged<IDiscFormat2Data, int*, int>)((*lpVtbl)[34]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT get_CurrentRotationTypeIsPureCAV([NativeTypeName("VARIANT_BOOL *")] short* value)
    {
        return ((delegate* unmanaged<IDiscFormat2Data, short*, int>)((*lpVtbl)[35]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT get_SupportedWriteSpeeds(SAFEARRAY** supportedSpeeds)
    {
        return ((delegate* unmanaged<IDiscFormat2Data, SAFEARRAY**, int>)((*lpVtbl)[36]))(
            this,
            supportedSpeeds
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public HRESULT get_SupportedWriteSpeedDescriptors(SAFEARRAY** supportedSpeedDescriptors)
    {
        return ((delegate* unmanaged<IDiscFormat2Data, SAFEARRAY**, int>)((*lpVtbl)[37]))(
            this,
            supportedSpeedDescriptors
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public HRESULT put_ForceOverwrite([NativeTypeName("VARIANT_BOOL")] short value)
    {
        return ((delegate* unmanaged<IDiscFormat2Data, short, int>)((*lpVtbl)[38]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    public HRESULT get_ForceOverwrite([NativeTypeName("VARIANT_BOOL *")] short* value)
    {
        return ((delegate* unmanaged<IDiscFormat2Data, short*, int>)((*lpVtbl)[39]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(40)]
    public HRESULT get_MultisessionInterfaces(SAFEARRAY** value)
    {
        return ((delegate* unmanaged<IDiscFormat2Data, SAFEARRAY**, int>)((*lpVtbl)[40]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(41)]
    public HRESULT Write(IStream data)
    {
        return ((delegate* unmanaged<IDiscFormat2Data, IStream, int>)((*lpVtbl)[41]))(this, data);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(42)]
    public HRESULT CancelWrite()
    {
        return ((delegate* unmanaged<IDiscFormat2Data, int>)((*lpVtbl)[42]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(43)]
    public HRESULT SetWriteSpeed(
        [NativeTypeName("LONG")] int RequestedSectorsPerSecond,
        [NativeTypeName("VARIANT_BOOL")] short RotationTypeIsPureCAV
    )
    {
        return ((delegate* unmanaged<IDiscFormat2Data, int, short, int>)((*lpVtbl)[43]))(
            this,
            RequestedSectorsPerSecond,
            RotationTypeIsPureCAV
        );
    }

    public interface Interface : IDiscFormat2.Interface
    {
        [VtblIndex(12)]
        HRESULT put_Recorder(IDiscRecorder2 value);

        [VtblIndex(13)]
        HRESULT get_Recorder(IDiscRecorder2* value);

        [VtblIndex(14)]
        HRESULT put_BufferUnderrunFreeDisabled([NativeTypeName("VARIANT_BOOL")] short value);

        [VtblIndex(15)]
        HRESULT get_BufferUnderrunFreeDisabled([NativeTypeName("VARIANT_BOOL *")] short* value);

        [VtblIndex(16)]
        HRESULT put_PostgapAlreadyInImage([NativeTypeName("VARIANT_BOOL")] short value);

        [VtblIndex(17)]
        HRESULT get_PostgapAlreadyInImage([NativeTypeName("VARIANT_BOOL *")] short* value);

        [VtblIndex(18)]
        HRESULT get_CurrentMediaStatus(IMAPI_FORMAT2_DATA_MEDIA_STATE* value);

        [VtblIndex(19)]
        HRESULT get_WriteProtectStatus(IMAPI_MEDIA_WRITE_PROTECT_STATE* value);

        [VtblIndex(20)]
        HRESULT get_TotalSectorsOnMedia([NativeTypeName("LONG *")] int* value);

        [VtblIndex(21)]
        HRESULT get_FreeSectorsOnMedia([NativeTypeName("LONG *")] int* value);

        [VtblIndex(22)]
        HRESULT get_NextWritableAddress([NativeTypeName("LONG *")] int* value);

        [VtblIndex(23)]
        HRESULT get_StartAddressOfPreviousSession([NativeTypeName("LONG *")] int* value);

        [VtblIndex(24)]
        HRESULT get_LastWrittenAddressOfPreviousSession([NativeTypeName("LONG *")] int* value);

        [VtblIndex(25)]
        HRESULT put_ForceMediaToBeClosed([NativeTypeName("VARIANT_BOOL")] short value);

        [VtblIndex(26)]
        HRESULT get_ForceMediaToBeClosed([NativeTypeName("VARIANT_BOOL *")] short* value);

        [VtblIndex(27)]
        HRESULT put_DisableConsumerDvdCompatibilityMode(
            [NativeTypeName("VARIANT_BOOL")] short value
        );

        [VtblIndex(28)]
        HRESULT get_DisableConsumerDvdCompatibilityMode(
            [NativeTypeName("VARIANT_BOOL *")] short* value
        );

        [VtblIndex(29)]
        HRESULT get_CurrentPhysicalMediaType(IMAPI_MEDIA_PHYSICAL_TYPE* value);

        [VtblIndex(30)]
        HRESULT put_ClientName([NativeTypeName("BSTR")] ushort* value);

        [VtblIndex(31)]
        HRESULT get_ClientName([NativeTypeName("BSTR *")] ushort** value);

        [VtblIndex(32)]
        HRESULT get_RequestedWriteSpeed([NativeTypeName("LONG *")] int* value);

        [VtblIndex(33)]
        HRESULT get_RequestedRotationTypeIsPureCAV([NativeTypeName("VARIANT_BOOL *")] short* value);

        [VtblIndex(34)]
        HRESULT get_CurrentWriteSpeed([NativeTypeName("LONG *")] int* value);

        [VtblIndex(35)]
        HRESULT get_CurrentRotationTypeIsPureCAV([NativeTypeName("VARIANT_BOOL *")] short* value);

        [VtblIndex(36)]
        HRESULT get_SupportedWriteSpeeds(SAFEARRAY** supportedSpeeds);

        [VtblIndex(37)]
        HRESULT get_SupportedWriteSpeedDescriptors(SAFEARRAY** supportedSpeedDescriptors);

        [VtblIndex(38)]
        HRESULT put_ForceOverwrite([NativeTypeName("VARIANT_BOOL")] short value);

        [VtblIndex(39)]
        HRESULT get_ForceOverwrite([NativeTypeName("VARIANT_BOOL *")] short* value);

        [VtblIndex(40)]
        HRESULT get_MultisessionInterfaces(SAFEARRAY** value);

        [VtblIndex(41)]
        HRESULT Write(IStream data);

        [VtblIndex(42)]
        HRESULT CancelWrite();

        [VtblIndex(43)]
        HRESULT SetWriteSpeed(
            [NativeTypeName("LONG")] int RequestedSectorsPerSecond,
            [NativeTypeName("VARIANT_BOOL")] short RotationTypeIsPureCAV
        );
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

        [NativeTypeName("HRESULT (IDiscRecorder2 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDiscRecorder2, int> put_Recorder;

        [NativeTypeName("HRESULT (IDiscRecorder2 **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDiscRecorder2*, int> get_Recorder;

        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> put_BufferUnderrunFreeDisabled;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_BufferUnderrunFreeDisabled;

        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> put_PostgapAlreadyInImage;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_PostgapAlreadyInImage;

        [NativeTypeName("HRESULT (IMAPI_FORMAT2_DATA_MEDIA_STATE *) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            IMAPI_FORMAT2_DATA_MEDIA_STATE*,
            int> get_CurrentMediaStatus;

        [NativeTypeName("HRESULT (IMAPI_MEDIA_WRITE_PROTECT_STATE *) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            IMAPI_MEDIA_WRITE_PROTECT_STATE*,
            int> get_WriteProtectStatus;

        [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_TotalSectorsOnMedia;

        [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_FreeSectorsOnMedia;

        [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_NextWritableAddress;

        [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_StartAddressOfPreviousSession;

        [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_LastWrittenAddressOfPreviousSession;

        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> put_ForceMediaToBeClosed;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_ForceMediaToBeClosed;

        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> put_DisableConsumerDvdCompatibilityMode;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_DisableConsumerDvdCompatibilityMode;

        [NativeTypeName("HRESULT (IMAPI_MEDIA_PHYSICAL_TYPE *) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            IMAPI_MEDIA_PHYSICAL_TYPE*,
            int> get_CurrentPhysicalMediaType;

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

        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> put_ForceOverwrite;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_ForceOverwrite;

        [NativeTypeName("HRESULT (SAFEARRAY **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SAFEARRAY**, int> get_MultisessionInterfaces;

        [NativeTypeName("HRESULT (IStream *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IStream, int> Write;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> CancelWrite;

        [NativeTypeName("HRESULT (LONG, VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, short, int> SetWriteSpeed;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDiscFormat2Data"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDiscFormat2Data(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IDiscFormat2"/> to <see cref = "IDiscFormat2Data"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IDiscFormat2"/> instance to be converted </param>
    public static explicit operator IDiscFormat2Data(Silk.NET.Windows.IDiscFormat2 value)
    {
        return new IDiscFormat2Data(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDiscFormat2Data"/> to <see cref = "Silk.NET.Windows.IDiscFormat2"/>.</summary>
    /// <param name = "value">The <see cref = "IDiscFormat2Data"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IDiscFormat2(IDiscFormat2Data value)
    {
        return new Silk.NET.Windows.IDiscFormat2(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IDispatch"/> to <see cref = "IDiscFormat2Data"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IDispatch"/> instance to be converted </param>
    public static explicit operator IDiscFormat2Data(Silk.NET.Windows.IDispatch value)
    {
        return new IDiscFormat2Data(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDiscFormat2Data"/> to <see cref = "Silk.NET.Windows.IDispatch"/>.</summary>
    /// <param name = "value">The <see cref = "IDiscFormat2Data"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IDispatch(IDiscFormat2Data value)
    {
        return new Silk.NET.Windows.IDispatch(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDiscFormat2Data"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDiscFormat2Data(Silk.NET.Windows.IUnknown value)
    {
        return new IDiscFormat2Data(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDiscFormat2Data"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDiscFormat2Data"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDiscFormat2Data value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
