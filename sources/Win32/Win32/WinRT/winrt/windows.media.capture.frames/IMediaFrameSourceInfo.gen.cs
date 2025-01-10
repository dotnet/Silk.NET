// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.capture.frames.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("87BDC9CD-4601-408F-91CF-038318CD0AF3")]
[NativeTypeName("struct IMediaFrameSourceInfo : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaFrameSourceInfo : IMediaFrameSourceInfo.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaFrameSourceInfo));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMediaFrameSourceInfo, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMediaFrameSourceInfo, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMediaFrameSourceInfo, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IMediaFrameSourceInfo, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IMediaFrameSourceInfo, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IMediaFrameSourceInfo, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Id(HSTRING* value)
    {
        return ((delegate* unmanaged<IMediaFrameSourceInfo, HSTRING*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_MediaStreamType(
        [NativeTypeName("ABI::Windows::Media::Capture::MediaStreamType *")] MediaStreamType* value
    )
    {
        return ((delegate* unmanaged<IMediaFrameSourceInfo, MediaStreamType*, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_SourceKind(
        [NativeTypeName("ABI::Windows::Media::Capture::Frames::MediaFrameSourceKind *")]
            MediaFrameSourceKind* value
    )
    {
        return (
            (delegate* unmanaged<IMediaFrameSourceInfo, MediaFrameSourceKind*, int>)((*lpVtbl)[8])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_SourceGroup(
        [NativeTypeName("ABI::Windows::Media::Capture::Frames::IMediaFrameSourceGroup **")]
            IMediaFrameSourceGroup* value
    )
    {
        return (
            (delegate* unmanaged<IMediaFrameSourceInfo, IMediaFrameSourceGroup*, int>)((*lpVtbl)[9])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_DeviceInformation(
        [NativeTypeName("ABI::Windows::Devices::Enumeration::IDeviceInformation **")]
            IDeviceInformation* value
    )
    {
        return (
            (delegate* unmanaged<IMediaFrameSourceInfo, IDeviceInformation*, int>)((*lpVtbl)[10])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_Properties(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIMapView_2_GUID_IInspectable_t **"
        )]
            IMapView<Guid, IntPtr>** value
    )
    {
        return (
            (delegate* unmanaged<IMediaFrameSourceInfo, IMapView<Guid, IntPtr>**, int>)(
                (*lpVtbl)[11]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_CoordinateSystem(
        [NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialCoordinateSystem **")]
            ISpatialCoordinateSystem* value
    )
    {
        return (
            (delegate* unmanaged<IMediaFrameSourceInfo, ISpatialCoordinateSystem*, int>)(
                (*lpVtbl)[12]
            )
        )(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Id(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_MediaStreamType(
            [NativeTypeName("ABI::Windows::Media::Capture::MediaStreamType *")]
                MediaStreamType* value
        );

        [VtblIndex(8)]
        HRESULT get_SourceKind(
            [NativeTypeName("ABI::Windows::Media::Capture::Frames::MediaFrameSourceKind *")]
                MediaFrameSourceKind* value
        );

        [VtblIndex(9)]
        HRESULT get_SourceGroup(
            [NativeTypeName("ABI::Windows::Media::Capture::Frames::IMediaFrameSourceGroup **")]
                IMediaFrameSourceGroup* value
        );

        [VtblIndex(10)]
        HRESULT get_DeviceInformation(
            [NativeTypeName("ABI::Windows::Devices::Enumeration::IDeviceInformation **")]
                IDeviceInformation* value
        );

        [VtblIndex(11)]
        HRESULT get_Properties(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIMapView_2_GUID_IInspectable_t **"
            )]
                IMapView<Guid, IntPtr>** value
        );

        [VtblIndex(12)]
        HRESULT get_CoordinateSystem(
            [NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialCoordinateSystem **")]
                ISpatialCoordinateSystem* value
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

        [NativeTypeName("HRESULT (ULONG *, IID **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, Guid**, int> GetIids;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> GetRuntimeClassName;

        [NativeTypeName("HRESULT (TrustLevel *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TrustLevel*, int> GetTrustLevel;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Id;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Capture::MediaStreamType *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, MediaStreamType*, int> get_MediaStreamType;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Capture::Frames::MediaFrameSourceKind *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, MediaFrameSourceKind*, int> get_SourceKind;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Capture::Frames::IMediaFrameSourceGroup **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IMediaFrameSourceGroup*, int> get_SourceGroup;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Enumeration::IDeviceInformation **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDeviceInformation*, int> get_DeviceInformation;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIMapView_2_GUID_IInspectable_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IMapView<Guid, IntPtr>**, int> get_Properties;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Perception::Spatial::ISpatialCoordinateSystem **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ISpatialCoordinateSystem*, int> get_CoordinateSystem;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMediaFrameSourceInfo"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMediaFrameSourceInfo(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IMediaFrameSourceInfo"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IMediaFrameSourceInfo(Silk.NET.WinRT.IInspectable value)
    {
        return new IMediaFrameSourceInfo(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMediaFrameSourceInfo"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IMediaFrameSourceInfo"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IMediaFrameSourceInfo value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMediaFrameSourceInfo"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMediaFrameSourceInfo(Silk.NET.Windows.IUnknown value)
    {
        return new IMediaFrameSourceInfo(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMediaFrameSourceInfo"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMediaFrameSourceInfo"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMediaFrameSourceInfo value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
