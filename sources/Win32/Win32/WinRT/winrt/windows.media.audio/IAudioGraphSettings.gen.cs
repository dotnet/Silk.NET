// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.audio.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("1D59647F-E6FE-4628-84F8-9D8BDBA25785")]
[NativeTypeName("struct IAudioGraphSettings : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAudioGraphSettings : IAudioGraphSettings.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAudioGraphSettings));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAudioGraphSettings, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IAudioGraphSettings, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAudioGraphSettings, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IAudioGraphSettings, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IAudioGraphSettings, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IAudioGraphSettings, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_EncodingProperties(
        [NativeTypeName("ABI::Windows::Media::MediaProperties::IAudioEncodingProperties **")]
            IAudioEncodingProperties* value
    )
    {
        return (
            (delegate* unmanaged<IAudioGraphSettings, IAudioEncodingProperties*, int>)((*lpVtbl)[6])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_EncodingProperties(
        [NativeTypeName("ABI::Windows::Media::MediaProperties::IAudioEncodingProperties *")]
            IAudioEncodingProperties value
    )
    {
        return (
            (delegate* unmanaged<IAudioGraphSettings, IAudioEncodingProperties, int>)((*lpVtbl)[7])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_PrimaryRenderDevice(
        [NativeTypeName("ABI::Windows::Devices::Enumeration::IDeviceInformation **")]
            IDeviceInformation* value
    )
    {
        return ((delegate* unmanaged<IAudioGraphSettings, IDeviceInformation*, int>)((*lpVtbl)[8]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_PrimaryRenderDevice(
        [NativeTypeName("ABI::Windows::Devices::Enumeration::IDeviceInformation *")]
            IDeviceInformation value
    )
    {
        return ((delegate* unmanaged<IAudioGraphSettings, IDeviceInformation, int>)((*lpVtbl)[9]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_QuantumSizeSelectionMode(
        [NativeTypeName("ABI::Windows::Media::Audio::QuantumSizeSelectionMode *")]
            QuantumSizeSelectionMode* value
    )
    {
        return (
            (delegate* unmanaged<IAudioGraphSettings, QuantumSizeSelectionMode*, int>)(
                (*lpVtbl)[10]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_QuantumSizeSelectionMode(
        [NativeTypeName("ABI::Windows::Media::Audio::QuantumSizeSelectionMode")]
            QuantumSizeSelectionMode value
    )
    {
        return (
            (delegate* unmanaged<IAudioGraphSettings, QuantumSizeSelectionMode, int>)((*lpVtbl)[11])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_DesiredSamplesPerQuantum([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged<IAudioGraphSettings, int*, int>)((*lpVtbl)[12]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_DesiredSamplesPerQuantum([NativeTypeName("INT32")] int value)
    {
        return ((delegate* unmanaged<IAudioGraphSettings, int, int>)((*lpVtbl)[13]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_AudioRenderCategory(
        [NativeTypeName("ABI::Windows::Media::Render::AudioRenderCategory *")]
            AudioRenderCategory* value
    )
    {
        return (
            (delegate* unmanaged<IAudioGraphSettings, AudioRenderCategory*, int>)((*lpVtbl)[14])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_AudioRenderCategory(
        [NativeTypeName("ABI::Windows::Media::Render::AudioRenderCategory")]
            AudioRenderCategory value
    )
    {
        return (
            (delegate* unmanaged<IAudioGraphSettings, AudioRenderCategory, int>)((*lpVtbl)[15])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_DesiredRenderDeviceAudioProcessing(
        [NativeTypeName("ABI::Windows::Media::AudioProcessing *")] AudioProcessing* value
    )
    {
        return ((delegate* unmanaged<IAudioGraphSettings, AudioProcessing*, int>)((*lpVtbl)[16]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT put_DesiredRenderDeviceAudioProcessing(
        [NativeTypeName("ABI::Windows::Media::AudioProcessing")] AudioProcessing value
    )
    {
        return ((delegate* unmanaged<IAudioGraphSettings, AudioProcessing, int>)((*lpVtbl)[17]))(
            this,
            value
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_EncodingProperties(
            [NativeTypeName("ABI::Windows::Media::MediaProperties::IAudioEncodingProperties **")]
                IAudioEncodingProperties* value
        );

        [VtblIndex(7)]
        HRESULT put_EncodingProperties(
            [NativeTypeName("ABI::Windows::Media::MediaProperties::IAudioEncodingProperties *")]
                IAudioEncodingProperties value
        );

        [VtblIndex(8)]
        HRESULT get_PrimaryRenderDevice(
            [NativeTypeName("ABI::Windows::Devices::Enumeration::IDeviceInformation **")]
                IDeviceInformation* value
        );

        [VtblIndex(9)]
        HRESULT put_PrimaryRenderDevice(
            [NativeTypeName("ABI::Windows::Devices::Enumeration::IDeviceInformation *")]
                IDeviceInformation value
        );

        [VtblIndex(10)]
        HRESULT get_QuantumSizeSelectionMode(
            [NativeTypeName("ABI::Windows::Media::Audio::QuantumSizeSelectionMode *")]
                QuantumSizeSelectionMode* value
        );

        [VtblIndex(11)]
        HRESULT put_QuantumSizeSelectionMode(
            [NativeTypeName("ABI::Windows::Media::Audio::QuantumSizeSelectionMode")]
                QuantumSizeSelectionMode value
        );

        [VtblIndex(12)]
        HRESULT get_DesiredSamplesPerQuantum([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(13)]
        HRESULT put_DesiredSamplesPerQuantum([NativeTypeName("INT32")] int value);

        [VtblIndex(14)]
        HRESULT get_AudioRenderCategory(
            [NativeTypeName("ABI::Windows::Media::Render::AudioRenderCategory *")]
                AudioRenderCategory* value
        );

        [VtblIndex(15)]
        HRESULT put_AudioRenderCategory(
            [NativeTypeName("ABI::Windows::Media::Render::AudioRenderCategory")]
                AudioRenderCategory value
        );

        [VtblIndex(16)]
        HRESULT get_DesiredRenderDeviceAudioProcessing(
            [NativeTypeName("ABI::Windows::Media::AudioProcessing *")] AudioProcessing* value
        );

        [VtblIndex(17)]
        HRESULT put_DesiredRenderDeviceAudioProcessing(
            [NativeTypeName("ABI::Windows::Media::AudioProcessing")] AudioProcessing value
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
            "HRESULT (ABI::Windows::Media::MediaProperties::IAudioEncodingProperties **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAudioEncodingProperties*, int> get_EncodingProperties;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::MediaProperties::IAudioEncodingProperties *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAudioEncodingProperties, int> put_EncodingProperties;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Enumeration::IDeviceInformation **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDeviceInformation*, int> get_PrimaryRenderDevice;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Enumeration::IDeviceInformation *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDeviceInformation, int> put_PrimaryRenderDevice;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Audio::QuantumSizeSelectionMode *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            QuantumSizeSelectionMode*,
            int> get_QuantumSizeSelectionMode;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Audio::QuantumSizeSelectionMode) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            QuantumSizeSelectionMode,
            int> put_QuantumSizeSelectionMode;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_DesiredSamplesPerQuantum;

        [NativeTypeName("HRESULT (INT32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_DesiredSamplesPerQuantum;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Render::AudioRenderCategory *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, AudioRenderCategory*, int> get_AudioRenderCategory;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Render::AudioRenderCategory) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, AudioRenderCategory, int> put_AudioRenderCategory;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::AudioProcessing *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            AudioProcessing*,
            int> get_DesiredRenderDeviceAudioProcessing;

        [NativeTypeName("HRESULT (ABI::Windows::Media::AudioProcessing) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            AudioProcessing,
            int> put_DesiredRenderDeviceAudioProcessing;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAudioGraphSettings"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAudioGraphSettings(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IAudioGraphSettings"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IAudioGraphSettings(Silk.NET.WinRT.IInspectable value)
    {
        return new IAudioGraphSettings(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAudioGraphSettings"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IAudioGraphSettings"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IAudioGraphSettings value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAudioGraphSettings"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAudioGraphSettings(Silk.NET.Windows.IUnknown value)
    {
        return new IAudioGraphSettings(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAudioGraphSettings"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAudioGraphSettings"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAudioGraphSettings value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
