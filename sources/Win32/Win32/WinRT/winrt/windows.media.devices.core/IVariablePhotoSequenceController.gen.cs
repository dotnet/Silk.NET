// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.devices.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("7FBFF880-ED8C-43FD-A7C3-B35809E4229A")]
[NativeTypeName("struct IVariablePhotoSequenceController : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IVariablePhotoSequenceController
    : IVariablePhotoSequenceController.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IVariablePhotoSequenceController));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IVariablePhotoSequenceController, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IVariablePhotoSequenceController, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IVariablePhotoSequenceController, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IVariablePhotoSequenceController, uint*, Guid**, int>)(
                (*lpVtbl)[3]
            )
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<IVariablePhotoSequenceController, HSTRING*, int>)((*lpVtbl)[4])
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IVariablePhotoSequenceController, TrustLevel*, int>)((*lpVtbl)[5])
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Supported([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IVariablePhotoSequenceController, byte*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_MaxPhotosPerSecond(float* value)
    {
        return ((delegate* unmanaged<IVariablePhotoSequenceController, float*, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_PhotosPerSecondLimit(float* value)
    {
        return ((delegate* unmanaged<IVariablePhotoSequenceController, float*, int>)((*lpVtbl)[8]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_PhotosPerSecondLimit(float value)
    {
        return ((delegate* unmanaged<IVariablePhotoSequenceController, float, int>)((*lpVtbl)[9]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetHighestConcurrentFrameRate(
        [NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProperties *")]
            IMediaEncodingProperties captureProperties,
        [NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaRatio **")] IMediaRatio* value
    )
    {
        return (
            (delegate* unmanaged<
                IVariablePhotoSequenceController,
                IMediaEncodingProperties,
                IMediaRatio*,
                int>)((*lpVtbl)[10])
        )(this, captureProperties, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetCurrentFrameRate(
        [NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaRatio **")] IMediaRatio* value
    )
    {
        return (
            (delegate* unmanaged<IVariablePhotoSequenceController, IMediaRatio*, int>)(
                (*lpVtbl)[11]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_FrameCapabilities(
        [NativeTypeName("ABI::Windows::Media::Devices::Core::IFrameControlCapabilities **")]
            IFrameControlCapabilities* value
    )
    {
        return (
            (delegate* unmanaged<
                IVariablePhotoSequenceController,
                IFrameControlCapabilities*,
                int>)((*lpVtbl)[12])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_DesiredFrameControllers(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CMedia__CDevices__CCore__CFrameController_t **"
        )]
            IVector<IntPtr>** items
    )
    {
        return (
            (delegate* unmanaged<IVariablePhotoSequenceController, IVector<IntPtr>**, int>)(
                (*lpVtbl)[13]
            )
        )(this, items);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Supported([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(7)]
        HRESULT get_MaxPhotosPerSecond(float* value);

        [VtblIndex(8)]
        HRESULT get_PhotosPerSecondLimit(float* value);

        [VtblIndex(9)]
        HRESULT put_PhotosPerSecondLimit(float value);

        [VtblIndex(10)]
        HRESULT GetHighestConcurrentFrameRate(
            [NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProperties *")]
                IMediaEncodingProperties captureProperties,
            [NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaRatio **")]
                IMediaRatio* value
        );

        [VtblIndex(11)]
        HRESULT GetCurrentFrameRate(
            [NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaRatio **")]
                IMediaRatio* value
        );

        [VtblIndex(12)]
        HRESULT get_FrameCapabilities(
            [NativeTypeName("ABI::Windows::Media::Devices::Core::IFrameControlCapabilities **")]
                IFrameControlCapabilities* value
        );

        [VtblIndex(13)]
        HRESULT get_DesiredFrameControllers(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CMedia__CDevices__CCore__CFrameController_t **"
            )]
                IVector<IntPtr>** items
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

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_Supported;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> get_MaxPhotosPerSecond;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> get_PhotosPerSecondLimit;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> put_PhotosPerSecondLimit;

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

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Devices::Core::IFrameControlCapabilities **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IFrameControlCapabilities*, int> get_FrameCapabilities;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CMedia__CDevices__CCore__CFrameController_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IVector<IntPtr>**, int> get_DesiredFrameControllers;
    }

    /// <summary>Initializes a new instance of the <see cref = "IVariablePhotoSequenceController"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IVariablePhotoSequenceController(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IVariablePhotoSequenceController"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IVariablePhotoSequenceController(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new IVariablePhotoSequenceController(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IVariablePhotoSequenceController"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IVariablePhotoSequenceController"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        IVariablePhotoSequenceController value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IVariablePhotoSequenceController"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IVariablePhotoSequenceController(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IVariablePhotoSequenceController(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IVariablePhotoSequenceController"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IVariablePhotoSequenceController"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IVariablePhotoSequenceController value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
