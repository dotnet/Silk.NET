// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/imapi2.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("27354154-8F64-5B0F-8F00-5D77AFBE261E")]
[NativeTypeName("struct IDiscFormat2TrackAtOnce : IDiscFormat2")]
[NativeInheritance("IDiscFormat2")]
public unsafe partial struct IDiscFormat2TrackAtOnce
    : IDiscFormat2TrackAtOnce.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDiscFormat2TrackAtOnce));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDiscFormat2TrackAtOnce, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDiscFormat2TrackAtOnce, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDiscFormat2TrackAtOnce, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IDiscFormat2TrackAtOnce, uint*, int>)((*lpVtbl)[3]))(
            this,
            pctinfo
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo* ppTInfo)
    {
        return (
            (delegate* unmanaged<IDiscFormat2TrackAtOnce, uint, uint, ITypeInfo*, int>)(
                (*lpVtbl)[4]
            )
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
            (delegate* unmanaged<IDiscFormat2TrackAtOnce, Guid*, ushort**, uint, uint, int*, int>)(
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
                IDiscFormat2TrackAtOnce,
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
            (delegate* unmanaged<IDiscFormat2TrackAtOnce, IDiscRecorder2, short*, int>)(
                (*lpVtbl)[7]
            )
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
            (delegate* unmanaged<IDiscFormat2TrackAtOnce, IDiscRecorder2, short*, int>)(
                (*lpVtbl)[8]
            )
        )(this, recorder, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_MediaPhysicallyBlank([NativeTypeName("VARIANT_BOOL *")] short* value)
    {
        return ((delegate* unmanaged<IDiscFormat2TrackAtOnce, short*, int>)((*lpVtbl)[9]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_MediaHeuristicallyBlank([NativeTypeName("VARIANT_BOOL *")] short* value)
    {
        return ((delegate* unmanaged<IDiscFormat2TrackAtOnce, short*, int>)((*lpVtbl)[10]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_SupportedMediaTypes(SAFEARRAY** value)
    {
        return ((delegate* unmanaged<IDiscFormat2TrackAtOnce, SAFEARRAY**, int>)((*lpVtbl)[11]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT PrepareMedia()
    {
        return ((delegate* unmanaged<IDiscFormat2TrackAtOnce, int>)((*lpVtbl)[12]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT AddAudioTrack(IStream data)
    {
        return ((delegate* unmanaged<IDiscFormat2TrackAtOnce, IStream, int>)((*lpVtbl)[13]))(
            this,
            data
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT CancelAddTrack()
    {
        return ((delegate* unmanaged<IDiscFormat2TrackAtOnce, int>)((*lpVtbl)[14]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT ReleaseMedia()
    {
        return ((delegate* unmanaged<IDiscFormat2TrackAtOnce, int>)((*lpVtbl)[15]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT SetWriteSpeed(
        [NativeTypeName("LONG")] int RequestedSectorsPerSecond,
        [NativeTypeName("VARIANT_BOOL")] short RotationTypeIsPureCAV
    )
    {
        return ((delegate* unmanaged<IDiscFormat2TrackAtOnce, int, short, int>)((*lpVtbl)[16]))(
            this,
            RequestedSectorsPerSecond,
            RotationTypeIsPureCAV
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT put_Recorder(IDiscRecorder2 value)
    {
        return ((delegate* unmanaged<IDiscFormat2TrackAtOnce, IDiscRecorder2, int>)((*lpVtbl)[17]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_Recorder(IDiscRecorder2* value)
    {
        return (
            (delegate* unmanaged<IDiscFormat2TrackAtOnce, IDiscRecorder2*, int>)((*lpVtbl)[18])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT put_BufferUnderrunFreeDisabled([NativeTypeName("VARIANT_BOOL")] short value)
    {
        return ((delegate* unmanaged<IDiscFormat2TrackAtOnce, short, int>)((*lpVtbl)[19]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_BufferUnderrunFreeDisabled([NativeTypeName("VARIANT_BOOL *")] short* value)
    {
        return ((delegate* unmanaged<IDiscFormat2TrackAtOnce, short*, int>)((*lpVtbl)[20]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT get_NumberOfExistingTracks([NativeTypeName("LONG *")] int* value)
    {
        return ((delegate* unmanaged<IDiscFormat2TrackAtOnce, int*, int>)((*lpVtbl)[21]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT get_TotalSectorsOnMedia([NativeTypeName("LONG *")] int* value)
    {
        return ((delegate* unmanaged<IDiscFormat2TrackAtOnce, int*, int>)((*lpVtbl)[22]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT get_FreeSectorsOnMedia([NativeTypeName("LONG *")] int* value)
    {
        return ((delegate* unmanaged<IDiscFormat2TrackAtOnce, int*, int>)((*lpVtbl)[23]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT get_UsedSectorsOnMedia([NativeTypeName("LONG *")] int* value)
    {
        return ((delegate* unmanaged<IDiscFormat2TrackAtOnce, int*, int>)((*lpVtbl)[24]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT put_DoNotFinalizeMedia([NativeTypeName("VARIANT_BOOL")] short value)
    {
        return ((delegate* unmanaged<IDiscFormat2TrackAtOnce, short, int>)((*lpVtbl)[25]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT get_DoNotFinalizeMedia([NativeTypeName("VARIANT_BOOL *")] short* value)
    {
        return ((delegate* unmanaged<IDiscFormat2TrackAtOnce, short*, int>)((*lpVtbl)[26]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT get_ExpectedTableOfContents(SAFEARRAY** value)
    {
        return ((delegate* unmanaged<IDiscFormat2TrackAtOnce, SAFEARRAY**, int>)((*lpVtbl)[27]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT get_CurrentPhysicalMediaType(IMAPI_MEDIA_PHYSICAL_TYPE* value)
    {
        return (
            (delegate* unmanaged<IDiscFormat2TrackAtOnce, IMAPI_MEDIA_PHYSICAL_TYPE*, int>)(
                (*lpVtbl)[28]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT put_ClientName([NativeTypeName("BSTR")] ushort* value)
    {
        return ((delegate* unmanaged<IDiscFormat2TrackAtOnce, ushort*, int>)((*lpVtbl)[29]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT get_ClientName([NativeTypeName("BSTR *")] ushort** value)
    {
        return ((delegate* unmanaged<IDiscFormat2TrackAtOnce, ushort**, int>)((*lpVtbl)[30]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT get_RequestedWriteSpeed([NativeTypeName("LONG *")] int* value)
    {
        return ((delegate* unmanaged<IDiscFormat2TrackAtOnce, int*, int>)((*lpVtbl)[31]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT get_RequestedRotationTypeIsPureCAV(
        [NativeTypeName("VARIANT_BOOL *")] short* value
    )
    {
        return ((delegate* unmanaged<IDiscFormat2TrackAtOnce, short*, int>)((*lpVtbl)[32]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT get_CurrentWriteSpeed([NativeTypeName("LONG *")] int* value)
    {
        return ((delegate* unmanaged<IDiscFormat2TrackAtOnce, int*, int>)((*lpVtbl)[33]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT get_CurrentRotationTypeIsPureCAV([NativeTypeName("VARIANT_BOOL *")] short* value)
    {
        return ((delegate* unmanaged<IDiscFormat2TrackAtOnce, short*, int>)((*lpVtbl)[34]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT get_SupportedWriteSpeeds(SAFEARRAY** supportedSpeeds)
    {
        return ((delegate* unmanaged<IDiscFormat2TrackAtOnce, SAFEARRAY**, int>)((*lpVtbl)[35]))(
            this,
            supportedSpeeds
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT get_SupportedWriteSpeedDescriptors(SAFEARRAY** supportedSpeedDescriptors)
    {
        return ((delegate* unmanaged<IDiscFormat2TrackAtOnce, SAFEARRAY**, int>)((*lpVtbl)[36]))(
            this,
            supportedSpeedDescriptors
        );
    }

    public interface Interface : IDiscFormat2.Interface
    {
        [VtblIndex(12)]
        HRESULT PrepareMedia();

        [VtblIndex(13)]
        HRESULT AddAudioTrack(IStream data);

        [VtblIndex(14)]
        HRESULT CancelAddTrack();

        [VtblIndex(15)]
        HRESULT ReleaseMedia();

        [VtblIndex(16)]
        HRESULT SetWriteSpeed(
            [NativeTypeName("LONG")] int RequestedSectorsPerSecond,
            [NativeTypeName("VARIANT_BOOL")] short RotationTypeIsPureCAV
        );

        [VtblIndex(17)]
        HRESULT put_Recorder(IDiscRecorder2 value);

        [VtblIndex(18)]
        HRESULT get_Recorder(IDiscRecorder2* value);

        [VtblIndex(19)]
        HRESULT put_BufferUnderrunFreeDisabled([NativeTypeName("VARIANT_BOOL")] short value);

        [VtblIndex(20)]
        HRESULT get_BufferUnderrunFreeDisabled([NativeTypeName("VARIANT_BOOL *")] short* value);

        [VtblIndex(21)]
        HRESULT get_NumberOfExistingTracks([NativeTypeName("LONG *")] int* value);

        [VtblIndex(22)]
        HRESULT get_TotalSectorsOnMedia([NativeTypeName("LONG *")] int* value);

        [VtblIndex(23)]
        HRESULT get_FreeSectorsOnMedia([NativeTypeName("LONG *")] int* value);

        [VtblIndex(24)]
        HRESULT get_UsedSectorsOnMedia([NativeTypeName("LONG *")] int* value);

        [VtblIndex(25)]
        HRESULT put_DoNotFinalizeMedia([NativeTypeName("VARIANT_BOOL")] short value);

        [VtblIndex(26)]
        HRESULT get_DoNotFinalizeMedia([NativeTypeName("VARIANT_BOOL *")] short* value);

        [VtblIndex(27)]
        HRESULT get_ExpectedTableOfContents(SAFEARRAY** value);

        [VtblIndex(28)]
        HRESULT get_CurrentPhysicalMediaType(IMAPI_MEDIA_PHYSICAL_TYPE* value);

        [VtblIndex(29)]
        HRESULT put_ClientName([NativeTypeName("BSTR")] ushort* value);

        [VtblIndex(30)]
        HRESULT get_ClientName([NativeTypeName("BSTR *")] ushort** value);

        [VtblIndex(31)]
        HRESULT get_RequestedWriteSpeed([NativeTypeName("LONG *")] int* value);

        [VtblIndex(32)]
        HRESULT get_RequestedRotationTypeIsPureCAV([NativeTypeName("VARIANT_BOOL *")] short* value);

        [VtblIndex(33)]
        HRESULT get_CurrentWriteSpeed([NativeTypeName("LONG *")] int* value);

        [VtblIndex(34)]
        HRESULT get_CurrentRotationTypeIsPureCAV([NativeTypeName("VARIANT_BOOL *")] short* value);

        [VtblIndex(35)]
        HRESULT get_SupportedWriteSpeeds(SAFEARRAY** supportedSpeeds);

        [VtblIndex(36)]
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
        public delegate* unmanaged<TSelf*, IStream, int> AddAudioTrack;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> CancelAddTrack;

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
        public delegate* unmanaged<TSelf*, int*, int> get_NumberOfExistingTracks;

        [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_TotalSectorsOnMedia;

        [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_FreeSectorsOnMedia;

        [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_UsedSectorsOnMedia;

        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> put_DoNotFinalizeMedia;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_DoNotFinalizeMedia;

        [NativeTypeName("HRESULT (SAFEARRAY **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SAFEARRAY**, int> get_ExpectedTableOfContents;

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
    }

    /// <summary>Initializes a new instance of the <see cref = "IDiscFormat2TrackAtOnce"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDiscFormat2TrackAtOnce(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IDiscFormat2"/> to <see cref = "IDiscFormat2TrackAtOnce"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IDiscFormat2"/> instance to be converted </param>
    public static explicit operator IDiscFormat2TrackAtOnce(Silk.NET.Windows.IDiscFormat2 value)
    {
        return new IDiscFormat2TrackAtOnce(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDiscFormat2TrackAtOnce"/> to <see cref = "Silk.NET.Windows.IDiscFormat2"/>.</summary>
    /// <param name = "value">The <see cref = "IDiscFormat2TrackAtOnce"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IDiscFormat2(IDiscFormat2TrackAtOnce value)
    {
        return new Silk.NET.Windows.IDiscFormat2(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IDispatch"/> to <see cref = "IDiscFormat2TrackAtOnce"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IDispatch"/> instance to be converted </param>
    public static explicit operator IDiscFormat2TrackAtOnce(Silk.NET.Windows.IDispatch value)
    {
        return new IDiscFormat2TrackAtOnce(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDiscFormat2TrackAtOnce"/> to <see cref = "Silk.NET.Windows.IDispatch"/>.</summary>
    /// <param name = "value">The <see cref = "IDiscFormat2TrackAtOnce"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IDispatch(IDiscFormat2TrackAtOnce value)
    {
        return new Silk.NET.Windows.IDispatch(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDiscFormat2TrackAtOnce"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDiscFormat2TrackAtOnce(Silk.NET.Windows.IUnknown value)
    {
        return new IDiscFormat2TrackAtOnce(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDiscFormat2TrackAtOnce"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDiscFormat2TrackAtOnce"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDiscFormat2TrackAtOnce value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
