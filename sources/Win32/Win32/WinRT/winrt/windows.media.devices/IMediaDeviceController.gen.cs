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

[Guid("F6F8F5CE-209A-48FB-86FC-D44578F317E6")]
[NativeTypeName("struct IMediaDeviceController : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaDeviceController : IMediaDeviceController.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaDeviceController));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMediaDeviceController, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMediaDeviceController, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMediaDeviceController, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IMediaDeviceController, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IMediaDeviceController, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IMediaDeviceController, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetAvailableMediaStreamProperties(
        [NativeTypeName("ABI::Windows::Media::Capture::MediaStreamType")]
            MediaStreamType mediaStreamType,
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CMediaProperties__CIMediaEncodingProperties_t **"
        )]
            IVectorView<IntPtr>** value
    )
    {
        return (
            (delegate* unmanaged<
                IMediaDeviceController,
                MediaStreamType,
                IVectorView<IntPtr>**,
                int>)((*lpVtbl)[6])
        )(this, mediaStreamType, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetMediaStreamProperties(
        [NativeTypeName("ABI::Windows::Media::Capture::MediaStreamType")]
            MediaStreamType mediaStreamType,
        [NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProperties **")]
            IMediaEncodingProperties* value
    )
    {
        return (
            (delegate* unmanaged<
                IMediaDeviceController,
                MediaStreamType,
                IMediaEncodingProperties*,
                int>)((*lpVtbl)[7])
        )(this, mediaStreamType, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetMediaStreamPropertiesAsync(
        [NativeTypeName("ABI::Windows::Media::Capture::MediaStreamType")]
            MediaStreamType mediaStreamType,
        [NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProperties *")]
            IMediaEncodingProperties mediaEncodingProperties,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* asyncInfo
    )
    {
        return (
            (delegate* unmanaged<
                IMediaDeviceController,
                MediaStreamType,
                IMediaEncodingProperties,
                IAsyncAction*,
                int>)((*lpVtbl)[8])
        )(this, mediaStreamType, mediaEncodingProperties, asyncInfo);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetAvailableMediaStreamProperties(
            [NativeTypeName("ABI::Windows::Media::Capture::MediaStreamType")]
                MediaStreamType mediaStreamType,
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CMediaProperties__CIMediaEncodingProperties_t **"
            )]
                IVectorView<IntPtr>** value
        );

        [VtblIndex(7)]
        HRESULT GetMediaStreamProperties(
            [NativeTypeName("ABI::Windows::Media::Capture::MediaStreamType")]
                MediaStreamType mediaStreamType,
            [NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProperties **")]
                IMediaEncodingProperties* value
        );

        [VtblIndex(8)]
        HRESULT SetMediaStreamPropertiesAsync(
            [NativeTypeName("ABI::Windows::Media::Capture::MediaStreamType")]
                MediaStreamType mediaStreamType,
            [NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProperties *")]
                IMediaEncodingProperties mediaEncodingProperties,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* asyncInfo
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

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Capture::MediaStreamType, ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CMediaProperties__CIMediaEncodingProperties_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            MediaStreamType,
            IVectorView<IntPtr>**,
            int> GetAvailableMediaStreamProperties;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Capture::MediaStreamType, ABI::Windows::Media::MediaProperties::IMediaEncodingProperties **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            MediaStreamType,
            IMediaEncodingProperties*,
            int> GetMediaStreamProperties;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Capture::MediaStreamType, ABI::Windows::Media::MediaProperties::IMediaEncodingProperties *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            MediaStreamType,
            IMediaEncodingProperties,
            IAsyncAction*,
            int> SetMediaStreamPropertiesAsync;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMediaDeviceController"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMediaDeviceController(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IMediaDeviceController"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IMediaDeviceController(Silk.NET.WinRT.IInspectable value)
    {
        return new IMediaDeviceController(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMediaDeviceController"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IMediaDeviceController"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IMediaDeviceController value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMediaDeviceController"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMediaDeviceController(Silk.NET.Windows.IUnknown value)
    {
        return new IMediaDeviceController(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMediaDeviceController"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMediaDeviceController"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMediaDeviceController value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
