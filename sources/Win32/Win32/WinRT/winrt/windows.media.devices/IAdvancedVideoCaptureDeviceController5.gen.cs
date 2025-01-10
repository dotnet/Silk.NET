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

[Guid("33512B17-B9CB-4A23-B875-F9EAAB535492")]
[NativeTypeName("struct IAdvancedVideoCaptureDeviceController5 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAdvancedVideoCaptureDeviceController5
    : IAdvancedVideoCaptureDeviceController5.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAdvancedVideoCaptureDeviceController5));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IAdvancedVideoCaptureDeviceController5, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAdvancedVideoCaptureDeviceController5, uint>)((*lpVtbl)[1]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAdvancedVideoCaptureDeviceController5, uint>)((*lpVtbl)[2]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IAdvancedVideoCaptureDeviceController5, uint*, Guid**, int>)(
                (*lpVtbl)[3]
            )
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<IAdvancedVideoCaptureDeviceController5, HSTRING*, int>)(
                (*lpVtbl)[4]
            )
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IAdvancedVideoCaptureDeviceController5, TrustLevel*, int>)(
                (*lpVtbl)[5]
            )
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Id(HSTRING* value)
    {
        return (
            (delegate* unmanaged<IAdvancedVideoCaptureDeviceController5, HSTRING*, int>)(
                (*lpVtbl)[6]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetDevicePropertyById(
        HSTRING propertyId,
        [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t *")]
            IReference<uint>* maxPropertyValueSize,
        [NativeTypeName(
            "ABI::Windows::Media::Devices::IVideoDeviceControllerGetDevicePropertyResult **"
        )]
            IVideoDeviceControllerGetDevicePropertyResult* value
    )
    {
        return (
            (delegate* unmanaged<
                IAdvancedVideoCaptureDeviceController5,
                HSTRING,
                IReference<uint>*,
                IVideoDeviceControllerGetDevicePropertyResult*,
                int>)((*lpVtbl)[7])
        )(this, propertyId, maxPropertyValueSize, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetDevicePropertyById(
        HSTRING propertyId,
        IInspectable propertyValue,
        [NativeTypeName(
            "ABI::Windows::Media::Devices::VideoDeviceControllerSetDevicePropertyStatus *"
        )]
            VideoDeviceControllerSetDevicePropertyStatus* value
    )
    {
        return (
            (delegate* unmanaged<
                IAdvancedVideoCaptureDeviceController5,
                HSTRING,
                IInspectable,
                VideoDeviceControllerSetDevicePropertyStatus*,
                int>)((*lpVtbl)[8])
        )(this, propertyId, propertyValue, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetDevicePropertyByExtendedId(
        [NativeTypeName("UINT32")] uint extendedPropertyIdLength,
        byte* extendedPropertyId,
        [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t *")]
            IReference<uint>* maxPropertyValueSize,
        [NativeTypeName(
            "ABI::Windows::Media::Devices::IVideoDeviceControllerGetDevicePropertyResult **"
        )]
            IVideoDeviceControllerGetDevicePropertyResult* value
    )
    {
        return (
            (delegate* unmanaged<
                IAdvancedVideoCaptureDeviceController5,
                uint,
                byte*,
                IReference<uint>*,
                IVideoDeviceControllerGetDevicePropertyResult*,
                int>)((*lpVtbl)[9])
        )(this, extendedPropertyIdLength, extendedPropertyId, maxPropertyValueSize, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetDevicePropertyByExtendedId(
        [NativeTypeName("UINT32")] uint extendedPropertyIdLength,
        byte* extendedPropertyId,
        [NativeTypeName("UINT32")] uint propertyValueLength,
        byte* propertyValue,
        [NativeTypeName(
            "ABI::Windows::Media::Devices::VideoDeviceControllerSetDevicePropertyStatus *"
        )]
            VideoDeviceControllerSetDevicePropertyStatus* value
    )
    {
        return (
            (delegate* unmanaged<
                IAdvancedVideoCaptureDeviceController5,
                uint,
                byte*,
                uint,
                byte*,
                VideoDeviceControllerSetDevicePropertyStatus*,
                int>)((*lpVtbl)[10])
        )(
            this,
            extendedPropertyIdLength,
            extendedPropertyId,
            propertyValueLength,
            propertyValue,
            value
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Id(HSTRING* value);

        [VtblIndex(7)]
        HRESULT GetDevicePropertyById(
            HSTRING propertyId,
            [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t *")]
                IReference<uint>* maxPropertyValueSize,
            [NativeTypeName(
                "ABI::Windows::Media::Devices::IVideoDeviceControllerGetDevicePropertyResult **"
            )]
                IVideoDeviceControllerGetDevicePropertyResult* value
        );

        [VtblIndex(8)]
        HRESULT SetDevicePropertyById(
            HSTRING propertyId,
            IInspectable propertyValue,
            [NativeTypeName(
                "ABI::Windows::Media::Devices::VideoDeviceControllerSetDevicePropertyStatus *"
            )]
                VideoDeviceControllerSetDevicePropertyStatus* value
        );

        [VtblIndex(9)]
        HRESULT GetDevicePropertyByExtendedId(
            [NativeTypeName("UINT32")] uint extendedPropertyIdLength,
            byte* extendedPropertyId,
            [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t *")]
                IReference<uint>* maxPropertyValueSize,
            [NativeTypeName(
                "ABI::Windows::Media::Devices::IVideoDeviceControllerGetDevicePropertyResult **"
            )]
                IVideoDeviceControllerGetDevicePropertyResult* value
        );

        [VtblIndex(10)]
        HRESULT SetDevicePropertyByExtendedId(
            [NativeTypeName("UINT32")] uint extendedPropertyIdLength,
            byte* extendedPropertyId,
            [NativeTypeName("UINT32")] uint propertyValueLength,
            byte* propertyValue,
            [NativeTypeName(
                "ABI::Windows::Media::Devices::VideoDeviceControllerSetDevicePropertyStatus *"
            )]
                VideoDeviceControllerSetDevicePropertyStatus* value
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
            "HRESULT (HSTRING, ABI::Windows::Foundation::__FIReference_1_UINT32_t *, ABI::Windows::Media::Devices::IVideoDeviceControllerGetDevicePropertyResult **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            IReference<uint>*,
            IVideoDeviceControllerGetDevicePropertyResult*,
            int> GetDevicePropertyById;

        [NativeTypeName(
            "HRESULT (HSTRING, IInspectable *, ABI::Windows::Media::Devices::VideoDeviceControllerSetDevicePropertyStatus *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            IInspectable,
            VideoDeviceControllerSetDevicePropertyStatus*,
            int> SetDevicePropertyById;

        [NativeTypeName(
            "HRESULT (UINT32, BYTE *, ABI::Windows::Foundation::__FIReference_1_UINT32_t *, ABI::Windows::Media::Devices::IVideoDeviceControllerGetDevicePropertyResult **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            byte*,
            IReference<uint>*,
            IVideoDeviceControllerGetDevicePropertyResult*,
            int> GetDevicePropertyByExtendedId;

        [NativeTypeName(
            "HRESULT (UINT32, BYTE *, UINT32, BYTE *, ABI::Windows::Media::Devices::VideoDeviceControllerSetDevicePropertyStatus *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            byte*,
            uint,
            byte*,
            VideoDeviceControllerSetDevicePropertyStatus*,
            int> SetDevicePropertyByExtendedId;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAdvancedVideoCaptureDeviceController5"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAdvancedVideoCaptureDeviceController5(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IAdvancedVideoCaptureDeviceController5"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IAdvancedVideoCaptureDeviceController5(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new IAdvancedVideoCaptureDeviceController5(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAdvancedVideoCaptureDeviceController5"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IAdvancedVideoCaptureDeviceController5"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        IAdvancedVideoCaptureDeviceController5 value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAdvancedVideoCaptureDeviceController5"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAdvancedVideoCaptureDeviceController5(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IAdvancedVideoCaptureDeviceController5(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAdvancedVideoCaptureDeviceController5"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAdvancedVideoCaptureDeviceController5"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IAdvancedVideoCaptureDeviceController5 value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
