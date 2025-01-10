// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/imapi2.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("27354132-7F64-5B0F-8F00-5D77AFBE261E")]
[NativeTypeName("struct IDiscRecorder2Ex : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDiscRecorder2Ex : IDiscRecorder2Ex.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDiscRecorder2Ex));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDiscRecorder2Ex, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDiscRecorder2Ex, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDiscRecorder2Ex, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SendCommandNoData(
        byte* Cdb,
        [NativeTypeName("ULONG")] uint CdbSize,
        [NativeTypeName("BYTE[18]")] byte* SenseBuffer,
        [NativeTypeName("ULONG")] uint Timeout
    )
    {
        return (
            (delegate* unmanaged<IDiscRecorder2Ex, byte*, uint, byte*, uint, int>)((*lpVtbl)[3])
        )(this, Cdb, CdbSize, SenseBuffer, Timeout);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SendCommandSendDataToDevice(
        byte* Cdb,
        [NativeTypeName("ULONG")] uint CdbSize,
        [NativeTypeName("BYTE[18]")] byte* SenseBuffer,
        [NativeTypeName("ULONG")] uint Timeout,
        byte* Buffer,
        [NativeTypeName("ULONG_IMAPI2_NONZERO")] uint BufferSize
    )
    {
        return (
            (delegate* unmanaged<IDiscRecorder2Ex, byte*, uint, byte*, uint, byte*, uint, int>)(
                (*lpVtbl)[4]
            )
        )(this, Cdb, CdbSize, SenseBuffer, Timeout, Buffer, BufferSize);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SendCommandGetDataFromDevice(
        byte* Cdb,
        [NativeTypeName("ULONG")] uint CdbSize,
        [NativeTypeName("BYTE[18]")] byte* SenseBuffer,
        [NativeTypeName("ULONG")] uint Timeout,
        byte* Buffer,
        [NativeTypeName("ULONG_IMAPI2_NONZERO")] uint BufferSize,
        [NativeTypeName("ULONG_IMAPI2_NOT_NEGATIVE *")] uint* BufferFetched
    )
    {
        return (
            (delegate* unmanaged<
                IDiscRecorder2Ex,
                byte*,
                uint,
                byte*,
                uint,
                byte*,
                uint,
                uint*,
                int>)((*lpVtbl)[5])
        )(this, Cdb, CdbSize, SenseBuffer, Timeout, Buffer, BufferSize, BufferFetched);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT ReadDvdStructure(
        [NativeTypeName("ULONG")] uint format,
        [NativeTypeName("ULONG")] uint address,
        [NativeTypeName("ULONG")] uint layer,
        [NativeTypeName("ULONG")] uint agid,
        byte** data,
        [NativeTypeName("ULONG_IMAPI2_DVD_STRUCTURE *")] uint* count
    )
    {
        return (
            (delegate* unmanaged<IDiscRecorder2Ex, uint, uint, uint, uint, byte**, uint*, int>)(
                (*lpVtbl)[6]
            )
        )(this, format, address, layer, agid, data, count);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SendDvdStructure(
        [NativeTypeName("ULONG")] uint format,
        byte* data,
        [NativeTypeName("ULONG_IMAPI2_DVD_STRUCTURE")] uint count
    )
    {
        return ((delegate* unmanaged<IDiscRecorder2Ex, uint, byte*, uint, int>)((*lpVtbl)[7]))(
            this,
            format,
            data,
            count
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetAdapterDescriptor(
        byte** data,
        [NativeTypeName("ULONG_IMAPI2_ADAPTER_DESCRIPTOR *")] uint* byteSize
    )
    {
        return ((delegate* unmanaged<IDiscRecorder2Ex, byte**, uint*, int>)((*lpVtbl)[8]))(
            this,
            data,
            byteSize
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetDeviceDescriptor(
        byte** data,
        [NativeTypeName("ULONG_IMAPI2_DEVICE_DESCRIPTOR *")] uint* byteSize
    )
    {
        return ((delegate* unmanaged<IDiscRecorder2Ex, byte**, uint*, int>)((*lpVtbl)[9]))(
            this,
            data,
            byteSize
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetDiscInformation(
        byte** discInformation,
        [NativeTypeName("ULONG_IMAPI2_DISC_INFORMATION *")] uint* byteSize
    )
    {
        return ((delegate* unmanaged<IDiscRecorder2Ex, byte**, uint*, int>)((*lpVtbl)[10]))(
            this,
            discInformation,
            byteSize
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetTrackInformation(
        [NativeTypeName("ULONG")] uint address,
        IMAPI_READ_TRACK_ADDRESS_TYPE addressType,
        byte** trackInformation,
        [NativeTypeName("ULONG_IMAPI2_TRACK_INFORMATION *")] uint* byteSize
    )
    {
        return (
            (delegate* unmanaged<
                IDiscRecorder2Ex,
                uint,
                IMAPI_READ_TRACK_ADDRESS_TYPE,
                byte**,
                uint*,
                int>)((*lpVtbl)[11])
        )(this, address, addressType, trackInformation, byteSize);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetFeaturePage(
        IMAPI_FEATURE_PAGE_TYPE requestedFeature,
        [NativeTypeName("BOOLEAN")] byte currentFeatureOnly,
        byte** featureData,
        [NativeTypeName("ULONG_IMAPI2_FEATURE_PAGE *")] uint* byteSize
    )
    {
        return (
            (delegate* unmanaged<
                IDiscRecorder2Ex,
                IMAPI_FEATURE_PAGE_TYPE,
                byte,
                byte**,
                uint*,
                int>)((*lpVtbl)[12])
        )(this, requestedFeature, currentFeatureOnly, featureData, byteSize);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetModePage(
        IMAPI_MODE_PAGE_TYPE requestedModePage,
        IMAPI_MODE_PAGE_REQUEST_TYPE requestType,
        byte** modePageData,
        [NativeTypeName("ULONG_IMAPI2_MODE_PAGE *")] uint* byteSize
    )
    {
        return (
            (delegate* unmanaged<
                IDiscRecorder2Ex,
                IMAPI_MODE_PAGE_TYPE,
                IMAPI_MODE_PAGE_REQUEST_TYPE,
                byte**,
                uint*,
                int>)((*lpVtbl)[13])
        )(this, requestedModePage, requestType, modePageData, byteSize);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT SetModePage(
        IMAPI_MODE_PAGE_REQUEST_TYPE requestType,
        byte* data,
        [NativeTypeName("ULONG_IMAPI2_MODE_PAGE")] uint byteSize
    )
    {
        return (
            (delegate* unmanaged<IDiscRecorder2Ex, IMAPI_MODE_PAGE_REQUEST_TYPE, byte*, uint, int>)(
                (*lpVtbl)[14]
            )
        )(this, requestType, data, byteSize);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetSupportedFeaturePages(
        [NativeTypeName("BOOLEAN")] byte currentFeatureOnly,
        IMAPI_FEATURE_PAGE_TYPE** featureData,
        [NativeTypeName("ULONG_IMAPI2_ALL_FEATURE_PAGES *")] uint* byteSize
    )
    {
        return (
            (delegate* unmanaged<IDiscRecorder2Ex, byte, IMAPI_FEATURE_PAGE_TYPE**, uint*, int>)(
                (*lpVtbl)[15]
            )
        )(this, currentFeatureOnly, featureData, byteSize);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT GetSupportedProfiles(
        [NativeTypeName("BOOLEAN")] byte currentOnly,
        IMAPI_PROFILE_TYPE** profileTypes,
        [NativeTypeName("ULONG_IMAPI2_ALL_PROFILES *")] uint* validProfiles
    )
    {
        return (
            (delegate* unmanaged<IDiscRecorder2Ex, byte, IMAPI_PROFILE_TYPE**, uint*, int>)(
                (*lpVtbl)[16]
            )
        )(this, currentOnly, profileTypes, validProfiles);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT GetSupportedModePages(
        IMAPI_MODE_PAGE_REQUEST_TYPE requestType,
        IMAPI_MODE_PAGE_TYPE** modePageTypes,
        [NativeTypeName("ULONG_IMAPI2_ALL_MODE_PAGES *")] uint* validPages
    )
    {
        return (
            (delegate* unmanaged<
                IDiscRecorder2Ex,
                IMAPI_MODE_PAGE_REQUEST_TYPE,
                IMAPI_MODE_PAGE_TYPE**,
                uint*,
                int>)((*lpVtbl)[17])
        )(this, requestType, modePageTypes, validPages);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT GetByteAlignmentMask([NativeTypeName("ULONG *")] uint* value)
    {
        return ((delegate* unmanaged<IDiscRecorder2Ex, uint*, int>)((*lpVtbl)[18]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT GetMaximumNonPageAlignedTransferSize([NativeTypeName("ULONG *")] uint* value)
    {
        return ((delegate* unmanaged<IDiscRecorder2Ex, uint*, int>)((*lpVtbl)[19]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT GetMaximumPageAlignedTransferSize([NativeTypeName("ULONG *")] uint* value)
    {
        return ((delegate* unmanaged<IDiscRecorder2Ex, uint*, int>)((*lpVtbl)[20]))(this, value);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SendCommandNoData(
            byte* Cdb,
            [NativeTypeName("ULONG")] uint CdbSize,
            [NativeTypeName("BYTE[18]")] byte* SenseBuffer,
            [NativeTypeName("ULONG")] uint Timeout
        );

        [VtblIndex(4)]
        HRESULT SendCommandSendDataToDevice(
            byte* Cdb,
            [NativeTypeName("ULONG")] uint CdbSize,
            [NativeTypeName("BYTE[18]")] byte* SenseBuffer,
            [NativeTypeName("ULONG")] uint Timeout,
            byte* Buffer,
            [NativeTypeName("ULONG_IMAPI2_NONZERO")] uint BufferSize
        );

        [VtblIndex(5)]
        HRESULT SendCommandGetDataFromDevice(
            byte* Cdb,
            [NativeTypeName("ULONG")] uint CdbSize,
            [NativeTypeName("BYTE[18]")] byte* SenseBuffer,
            [NativeTypeName("ULONG")] uint Timeout,
            byte* Buffer,
            [NativeTypeName("ULONG_IMAPI2_NONZERO")] uint BufferSize,
            [NativeTypeName("ULONG_IMAPI2_NOT_NEGATIVE *")] uint* BufferFetched
        );

        [VtblIndex(6)]
        HRESULT ReadDvdStructure(
            [NativeTypeName("ULONG")] uint format,
            [NativeTypeName("ULONG")] uint address,
            [NativeTypeName("ULONG")] uint layer,
            [NativeTypeName("ULONG")] uint agid,
            byte** data,
            [NativeTypeName("ULONG_IMAPI2_DVD_STRUCTURE *")] uint* count
        );

        [VtblIndex(7)]
        HRESULT SendDvdStructure(
            [NativeTypeName("ULONG")] uint format,
            byte* data,
            [NativeTypeName("ULONG_IMAPI2_DVD_STRUCTURE")] uint count
        );

        [VtblIndex(8)]
        HRESULT GetAdapterDescriptor(
            byte** data,
            [NativeTypeName("ULONG_IMAPI2_ADAPTER_DESCRIPTOR *")] uint* byteSize
        );

        [VtblIndex(9)]
        HRESULT GetDeviceDescriptor(
            byte** data,
            [NativeTypeName("ULONG_IMAPI2_DEVICE_DESCRIPTOR *")] uint* byteSize
        );

        [VtblIndex(10)]
        HRESULT GetDiscInformation(
            byte** discInformation,
            [NativeTypeName("ULONG_IMAPI2_DISC_INFORMATION *")] uint* byteSize
        );

        [VtblIndex(11)]
        HRESULT GetTrackInformation(
            [NativeTypeName("ULONG")] uint address,
            IMAPI_READ_TRACK_ADDRESS_TYPE addressType,
            byte** trackInformation,
            [NativeTypeName("ULONG_IMAPI2_TRACK_INFORMATION *")] uint* byteSize
        );

        [VtblIndex(12)]
        HRESULT GetFeaturePage(
            IMAPI_FEATURE_PAGE_TYPE requestedFeature,
            [NativeTypeName("BOOLEAN")] byte currentFeatureOnly,
            byte** featureData,
            [NativeTypeName("ULONG_IMAPI2_FEATURE_PAGE *")] uint* byteSize
        );

        [VtblIndex(13)]
        HRESULT GetModePage(
            IMAPI_MODE_PAGE_TYPE requestedModePage,
            IMAPI_MODE_PAGE_REQUEST_TYPE requestType,
            byte** modePageData,
            [NativeTypeName("ULONG_IMAPI2_MODE_PAGE *")] uint* byteSize
        );

        [VtblIndex(14)]
        HRESULT SetModePage(
            IMAPI_MODE_PAGE_REQUEST_TYPE requestType,
            byte* data,
            [NativeTypeName("ULONG_IMAPI2_MODE_PAGE")] uint byteSize
        );

        [VtblIndex(15)]
        HRESULT GetSupportedFeaturePages(
            [NativeTypeName("BOOLEAN")] byte currentFeatureOnly,
            IMAPI_FEATURE_PAGE_TYPE** featureData,
            [NativeTypeName("ULONG_IMAPI2_ALL_FEATURE_PAGES *")] uint* byteSize
        );

        [VtblIndex(16)]
        HRESULT GetSupportedProfiles(
            [NativeTypeName("BOOLEAN")] byte currentOnly,
            IMAPI_PROFILE_TYPE** profileTypes,
            [NativeTypeName("ULONG_IMAPI2_ALL_PROFILES *")] uint* validProfiles
        );

        [VtblIndex(17)]
        HRESULT GetSupportedModePages(
            IMAPI_MODE_PAGE_REQUEST_TYPE requestType,
            IMAPI_MODE_PAGE_TYPE** modePageTypes,
            [NativeTypeName("ULONG_IMAPI2_ALL_MODE_PAGES *")] uint* validPages
        );

        [VtblIndex(18)]
        HRESULT GetByteAlignmentMask([NativeTypeName("ULONG *")] uint* value);

        [VtblIndex(19)]
        HRESULT GetMaximumNonPageAlignedTransferSize([NativeTypeName("ULONG *")] uint* value);

        [VtblIndex(20)]
        HRESULT GetMaximumPageAlignedTransferSize([NativeTypeName("ULONG *")] uint* value);
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

        [NativeTypeName("HRESULT (BYTE *, ULONG, BYTE *, ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, uint, byte*, uint, int> SendCommandNoData;

        [NativeTypeName(
            "HRESULT (BYTE *, ULONG, BYTE *, ULONG, BYTE *, ULONG_IMAPI2_NONZERO) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            byte*,
            uint,
            byte*,
            uint,
            byte*,
            uint,
            int> SendCommandSendDataToDevice;

        [NativeTypeName(
            "HRESULT (BYTE *, ULONG, BYTE *, ULONG, BYTE *, ULONG_IMAPI2_NONZERO, ULONG_IMAPI2_NOT_NEGATIVE *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            byte*,
            uint,
            byte*,
            uint,
            byte*,
            uint,
            uint*,
            int> SendCommandGetDataFromDevice;

        [NativeTypeName(
            "HRESULT (ULONG, ULONG, ULONG, ULONG, BYTE **, ULONG_IMAPI2_DVD_STRUCTURE *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            uint,
            uint,
            uint,
            byte**,
            uint*,
            int> ReadDvdStructure;

        [NativeTypeName(
            "HRESULT (ULONG, BYTE *, ULONG_IMAPI2_DVD_STRUCTURE) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, byte*, uint, int> SendDvdStructure;

        [NativeTypeName(
            "HRESULT (BYTE **, ULONG_IMAPI2_ADAPTER_DESCRIPTOR *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, byte**, uint*, int> GetAdapterDescriptor;

        [NativeTypeName(
            "HRESULT (BYTE **, ULONG_IMAPI2_DEVICE_DESCRIPTOR *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, byte**, uint*, int> GetDeviceDescriptor;

        [NativeTypeName(
            "HRESULT (BYTE **, ULONG_IMAPI2_DISC_INFORMATION *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, byte**, uint*, int> GetDiscInformation;

        [NativeTypeName(
            "HRESULT (ULONG, IMAPI_READ_TRACK_ADDRESS_TYPE, BYTE **, ULONG_IMAPI2_TRACK_INFORMATION *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            IMAPI_READ_TRACK_ADDRESS_TYPE,
            byte**,
            uint*,
            int> GetTrackInformation;

        [NativeTypeName(
            "HRESULT (IMAPI_FEATURE_PAGE_TYPE, BOOLEAN, BYTE **, ULONG_IMAPI2_FEATURE_PAGE *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IMAPI_FEATURE_PAGE_TYPE,
            byte,
            byte**,
            uint*,
            int> GetFeaturePage;

        [NativeTypeName(
            "HRESULT (IMAPI_MODE_PAGE_TYPE, IMAPI_MODE_PAGE_REQUEST_TYPE, BYTE **, ULONG_IMAPI2_MODE_PAGE *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IMAPI_MODE_PAGE_TYPE,
            IMAPI_MODE_PAGE_REQUEST_TYPE,
            byte**,
            uint*,
            int> GetModePage;

        [NativeTypeName(
            "HRESULT (IMAPI_MODE_PAGE_REQUEST_TYPE, BYTE *, ULONG_IMAPI2_MODE_PAGE) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IMAPI_MODE_PAGE_REQUEST_TYPE,
            byte*,
            uint,
            int> SetModePage;

        [NativeTypeName(
            "HRESULT (BOOLEAN, IMAPI_FEATURE_PAGE_TYPE **, ULONG_IMAPI2_ALL_FEATURE_PAGES *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            byte,
            IMAPI_FEATURE_PAGE_TYPE**,
            uint*,
            int> GetSupportedFeaturePages;

        [NativeTypeName(
            "HRESULT (BOOLEAN, IMAPI_PROFILE_TYPE **, ULONG_IMAPI2_ALL_PROFILES *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            byte,
            IMAPI_PROFILE_TYPE**,
            uint*,
            int> GetSupportedProfiles;

        [NativeTypeName(
            "HRESULT (IMAPI_MODE_PAGE_REQUEST_TYPE, IMAPI_MODE_PAGE_TYPE **, ULONG_IMAPI2_ALL_MODE_PAGES *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IMAPI_MODE_PAGE_REQUEST_TYPE,
            IMAPI_MODE_PAGE_TYPE**,
            uint*,
            int> GetSupportedModePages;

        [NativeTypeName("HRESULT (ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetByteAlignmentMask;

        [NativeTypeName("HRESULT (ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetMaximumNonPageAlignedTransferSize;

        [NativeTypeName("HRESULT (ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetMaximumPageAlignedTransferSize;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDiscRecorder2Ex"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDiscRecorder2Ex(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDiscRecorder2Ex"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDiscRecorder2Ex(Silk.NET.Windows.IUnknown value)
    {
        return new IDiscRecorder2Ex(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDiscRecorder2Ex"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDiscRecorder2Ex"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDiscRecorder2Ex value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
