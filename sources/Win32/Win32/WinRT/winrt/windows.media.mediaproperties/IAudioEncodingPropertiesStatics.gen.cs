// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.mediaproperties.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("0CAD332C-EBE9-4527-B36D-E42A13CF38DB")]
[NativeTypeName("struct IAudioEncodingPropertiesStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAudioEncodingPropertiesStatics
    : IAudioEncodingPropertiesStatics.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAudioEncodingPropertiesStatics));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IAudioEncodingPropertiesStatics, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAudioEncodingPropertiesStatics, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAudioEncodingPropertiesStatics, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IAudioEncodingPropertiesStatics, uint*, Guid**, int>)((*lpVtbl)[3])
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<IAudioEncodingPropertiesStatics, HSTRING*, int>)((*lpVtbl)[4])
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IAudioEncodingPropertiesStatics, TrustLevel*, int>)((*lpVtbl)[5])
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateAac(
        [NativeTypeName("UINT32")] uint sampleRate,
        [NativeTypeName("UINT32")] uint channelCount,
        [NativeTypeName("UINT32")] uint bitrate,
        [NativeTypeName("ABI::Windows::Media::MediaProperties::IAudioEncodingProperties **")]
            IAudioEncodingProperties* value
    )
    {
        return (
            (delegate* unmanaged<
                IAudioEncodingPropertiesStatics,
                uint,
                uint,
                uint,
                IAudioEncodingProperties*,
                int>)((*lpVtbl)[6])
        )(this, sampleRate, channelCount, bitrate, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateAacAdts(
        [NativeTypeName("UINT32")] uint sampleRate,
        [NativeTypeName("UINT32")] uint channelCount,
        [NativeTypeName("UINT32")] uint bitrate,
        [NativeTypeName("ABI::Windows::Media::MediaProperties::IAudioEncodingProperties **")]
            IAudioEncodingProperties* value
    )
    {
        return (
            (delegate* unmanaged<
                IAudioEncodingPropertiesStatics,
                uint,
                uint,
                uint,
                IAudioEncodingProperties*,
                int>)((*lpVtbl)[7])
        )(this, sampleRate, channelCount, bitrate, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateMp3(
        [NativeTypeName("UINT32")] uint sampleRate,
        [NativeTypeName("UINT32")] uint channelCount,
        [NativeTypeName("UINT32")] uint bitrate,
        [NativeTypeName("ABI::Windows::Media::MediaProperties::IAudioEncodingProperties **")]
            IAudioEncodingProperties* value
    )
    {
        return (
            (delegate* unmanaged<
                IAudioEncodingPropertiesStatics,
                uint,
                uint,
                uint,
                IAudioEncodingProperties*,
                int>)((*lpVtbl)[8])
        )(this, sampleRate, channelCount, bitrate, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT CreatePcm(
        [NativeTypeName("UINT32")] uint sampleRate,
        [NativeTypeName("UINT32")] uint channelCount,
        [NativeTypeName("UINT32")] uint bitsPerSample,
        [NativeTypeName("ABI::Windows::Media::MediaProperties::IAudioEncodingProperties **")]
            IAudioEncodingProperties* value
    )
    {
        return (
            (delegate* unmanaged<
                IAudioEncodingPropertiesStatics,
                uint,
                uint,
                uint,
                IAudioEncodingProperties*,
                int>)((*lpVtbl)[9])
        )(this, sampleRate, channelCount, bitsPerSample, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT CreateWma(
        [NativeTypeName("UINT32")] uint sampleRate,
        [NativeTypeName("UINT32")] uint channelCount,
        [NativeTypeName("UINT32")] uint bitrate,
        [NativeTypeName("ABI::Windows::Media::MediaProperties::IAudioEncodingProperties **")]
            IAudioEncodingProperties* value
    )
    {
        return (
            (delegate* unmanaged<
                IAudioEncodingPropertiesStatics,
                uint,
                uint,
                uint,
                IAudioEncodingProperties*,
                int>)((*lpVtbl)[10])
        )(this, sampleRate, channelCount, bitrate, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateAac(
            [NativeTypeName("UINT32")] uint sampleRate,
            [NativeTypeName("UINT32")] uint channelCount,
            [NativeTypeName("UINT32")] uint bitrate,
            [NativeTypeName("ABI::Windows::Media::MediaProperties::IAudioEncodingProperties **")]
                IAudioEncodingProperties* value
        );

        [VtblIndex(7)]
        HRESULT CreateAacAdts(
            [NativeTypeName("UINT32")] uint sampleRate,
            [NativeTypeName("UINT32")] uint channelCount,
            [NativeTypeName("UINT32")] uint bitrate,
            [NativeTypeName("ABI::Windows::Media::MediaProperties::IAudioEncodingProperties **")]
                IAudioEncodingProperties* value
        );

        [VtblIndex(8)]
        HRESULT CreateMp3(
            [NativeTypeName("UINT32")] uint sampleRate,
            [NativeTypeName("UINT32")] uint channelCount,
            [NativeTypeName("UINT32")] uint bitrate,
            [NativeTypeName("ABI::Windows::Media::MediaProperties::IAudioEncodingProperties **")]
                IAudioEncodingProperties* value
        );

        [VtblIndex(9)]
        HRESULT CreatePcm(
            [NativeTypeName("UINT32")] uint sampleRate,
            [NativeTypeName("UINT32")] uint channelCount,
            [NativeTypeName("UINT32")] uint bitsPerSample,
            [NativeTypeName("ABI::Windows::Media::MediaProperties::IAudioEncodingProperties **")]
                IAudioEncodingProperties* value
        );

        [VtblIndex(10)]
        HRESULT CreateWma(
            [NativeTypeName("UINT32")] uint sampleRate,
            [NativeTypeName("UINT32")] uint channelCount,
            [NativeTypeName("UINT32")] uint bitrate,
            [NativeTypeName("ABI::Windows::Media::MediaProperties::IAudioEncodingProperties **")]
                IAudioEncodingProperties* value
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
            "HRESULT (UINT32, UINT32, UINT32, ABI::Windows::Media::MediaProperties::IAudioEncodingProperties **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            uint,
            uint,
            IAudioEncodingProperties*,
            int> CreateAac;

        [NativeTypeName(
            "HRESULT (UINT32, UINT32, UINT32, ABI::Windows::Media::MediaProperties::IAudioEncodingProperties **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            uint,
            uint,
            IAudioEncodingProperties*,
            int> CreateAacAdts;

        [NativeTypeName(
            "HRESULT (UINT32, UINT32, UINT32, ABI::Windows::Media::MediaProperties::IAudioEncodingProperties **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            uint,
            uint,
            IAudioEncodingProperties*,
            int> CreateMp3;

        [NativeTypeName(
            "HRESULT (UINT32, UINT32, UINT32, ABI::Windows::Media::MediaProperties::IAudioEncodingProperties **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            uint,
            uint,
            IAudioEncodingProperties*,
            int> CreatePcm;

        [NativeTypeName(
            "HRESULT (UINT32, UINT32, UINT32, ABI::Windows::Media::MediaProperties::IAudioEncodingProperties **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            uint,
            uint,
            IAudioEncodingProperties*,
            int> CreateWma;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAudioEncodingPropertiesStatics"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAudioEncodingPropertiesStatics(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IAudioEncodingPropertiesStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IAudioEncodingPropertiesStatics(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new IAudioEncodingPropertiesStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAudioEncodingPropertiesStatics"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IAudioEncodingPropertiesStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        IAudioEncodingPropertiesStatics value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAudioEncodingPropertiesStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAudioEncodingPropertiesStatics(Silk.NET.Windows.IUnknown value)
    {
        return new IAudioEncodingPropertiesStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAudioEncodingPropertiesStatics"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAudioEncodingPropertiesStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAudioEncodingPropertiesStatics value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
