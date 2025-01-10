// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.devices.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("6D5C4DD0-FADF-415D-AEE6-3BAA529300C9")]
[NativeTypeName("struct ILowLagPhotoControl : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ILowLagPhotoControl : ILowLagPhotoControl.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ILowLagPhotoControl));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ILowLagPhotoControl, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ILowLagPhotoControl, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ILowLagPhotoControl, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<ILowLagPhotoControl, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<ILowLagPhotoControl, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<ILowLagPhotoControl, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetHighestConcurrentFrameRate(
        [NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProperties *")]
            IMediaEncodingProperties captureProperties,
        [NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaRatio **")] IMediaRatio* value
    )
    {
        return (
            (delegate* unmanaged<ILowLagPhotoControl, IMediaEncodingProperties, IMediaRatio*, int>)(
                (*lpVtbl)[6]
            )
        )(this, captureProperties, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetCurrentFrameRate(
        [NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaRatio **")] IMediaRatio* value
    )
    {
        return ((delegate* unmanaged<ILowLagPhotoControl, IMediaRatio*, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_ThumbnailEnabled([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<ILowLagPhotoControl, byte*, int>)((*lpVtbl)[8]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_ThumbnailEnabled([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged<ILowLagPhotoControl, byte, int>)((*lpVtbl)[9]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_ThumbnailFormat(
        [NativeTypeName("ABI::Windows::Media::MediaProperties::MediaThumbnailFormat *")]
            MediaThumbnailFormat* value
    )
    {
        return (
            (delegate* unmanaged<ILowLagPhotoControl, MediaThumbnailFormat*, int>)((*lpVtbl)[10])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_ThumbnailFormat(
        [NativeTypeName("ABI::Windows::Media::MediaProperties::MediaThumbnailFormat")]
            MediaThumbnailFormat value
    )
    {
        return (
            (delegate* unmanaged<ILowLagPhotoControl, MediaThumbnailFormat, int>)((*lpVtbl)[11])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_DesiredThumbnailSize([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged<ILowLagPhotoControl, uint*, int>)((*lpVtbl)[12]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_DesiredThumbnailSize([NativeTypeName("UINT32")] uint value)
    {
        return ((delegate* unmanaged<ILowLagPhotoControl, uint, int>)((*lpVtbl)[13]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_HardwareAcceleratedThumbnailSupported(
        [NativeTypeName("UINT32 *")] uint* value
    )
    {
        return ((delegate* unmanaged<ILowLagPhotoControl, uint*, int>)((*lpVtbl)[14]))(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetHighestConcurrentFrameRate(
            [NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProperties *")]
                IMediaEncodingProperties captureProperties,
            [NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaRatio **")]
                IMediaRatio* value
        );

        [VtblIndex(7)]
        HRESULT GetCurrentFrameRate(
            [NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaRatio **")]
                IMediaRatio* value
        );

        [VtblIndex(8)]
        HRESULT get_ThumbnailEnabled([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(9)]
        HRESULT put_ThumbnailEnabled([NativeTypeName("boolean")] byte value);

        [VtblIndex(10)]
        HRESULT get_ThumbnailFormat(
            [NativeTypeName("ABI::Windows::Media::MediaProperties::MediaThumbnailFormat *")]
                MediaThumbnailFormat* value
        );

        [VtblIndex(11)]
        HRESULT put_ThumbnailFormat(
            [NativeTypeName("ABI::Windows::Media::MediaProperties::MediaThumbnailFormat")]
                MediaThumbnailFormat value
        );

        [VtblIndex(12)]
        HRESULT get_DesiredThumbnailSize([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(13)]
        HRESULT put_DesiredThumbnailSize([NativeTypeName("UINT32")] uint value);

        [VtblIndex(14)]
        HRESULT get_HardwareAcceleratedThumbnailSupported([NativeTypeName("UINT32 *")] uint* value);
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

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::MediaProperties::IMediaEncodingProperties *, ABI::Windows::Media::MediaProperties::IMediaRatio **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IMediaEncodingProperties,
            IMediaRatio*,
            int> GetHighestConcurrentFrameRate;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::MediaProperties::IMediaRatio **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IMediaRatio*, int> GetCurrentFrameRate;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_ThumbnailEnabled;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_ThumbnailEnabled;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::MediaProperties::MediaThumbnailFormat *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, MediaThumbnailFormat*, int> get_ThumbnailFormat;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::MediaProperties::MediaThumbnailFormat) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, MediaThumbnailFormat, int> put_ThumbnailFormat;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_DesiredThumbnailSize;

        [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> put_DesiredThumbnailSize;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_HardwareAcceleratedThumbnailSupported;
    }

    /// <summary>Initializes a new instance of the <see cref = "ILowLagPhotoControl"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ILowLagPhotoControl(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ILowLagPhotoControl"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ILowLagPhotoControl(Silk.NET.WinRT.IInspectable value)
    {
        return new ILowLagPhotoControl(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ILowLagPhotoControl"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ILowLagPhotoControl"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(ILowLagPhotoControl value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ILowLagPhotoControl"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ILowLagPhotoControl(Silk.NET.Windows.IUnknown value)
    {
        return new ILowLagPhotoControl(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ILowLagPhotoControl"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ILowLagPhotoControl"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ILowLagPhotoControl value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
