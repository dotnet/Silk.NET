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

[Guid("90DAC5AA-CF76-4294-A9ED-1A1420F51F6B")]
[NativeTypeName("struct IMediaEncodingProfileStatics3 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaEncodingProfileStatics3
    : IMediaEncodingProfileStatics3.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaEncodingProfileStatics3));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IMediaEncodingProfileStatics3, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMediaEncodingProfileStatics3, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMediaEncodingProfileStatics3, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IMediaEncodingProfileStatics3, uint*, Guid**, int>)((*lpVtbl)[3])
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IMediaEncodingProfileStatics3, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IMediaEncodingProfileStatics3, TrustLevel*, int>)((*lpVtbl)[5])
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateAlac(
        [NativeTypeName("ABI::Windows::Media::MediaProperties::AudioEncodingQuality")]
            AudioEncodingQuality quality,
        [NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProfile **")]
            IMediaEncodingProfile* value
    )
    {
        return (
            (delegate* unmanaged<
                IMediaEncodingProfileStatics3,
                AudioEncodingQuality,
                IMediaEncodingProfile*,
                int>)((*lpVtbl)[6])
        )(this, quality, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateFlac(
        [NativeTypeName("ABI::Windows::Media::MediaProperties::AudioEncodingQuality")]
            AudioEncodingQuality quality,
        [NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProfile **")]
            IMediaEncodingProfile* value
    )
    {
        return (
            (delegate* unmanaged<
                IMediaEncodingProfileStatics3,
                AudioEncodingQuality,
                IMediaEncodingProfile*,
                int>)((*lpVtbl)[7])
        )(this, quality, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateHevc(
        [NativeTypeName("ABI::Windows::Media::MediaProperties::VideoEncodingQuality")]
            VideoEncodingQuality quality,
        [NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProfile **")]
            IMediaEncodingProfile* value
    )
    {
        return (
            (delegate* unmanaged<
                IMediaEncodingProfileStatics3,
                VideoEncodingQuality,
                IMediaEncodingProfile*,
                int>)((*lpVtbl)[8])
        )(this, quality, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateAlac(
            [NativeTypeName("ABI::Windows::Media::MediaProperties::AudioEncodingQuality")]
                AudioEncodingQuality quality,
            [NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProfile **")]
                IMediaEncodingProfile* value
        );

        [VtblIndex(7)]
        HRESULT CreateFlac(
            [NativeTypeName("ABI::Windows::Media::MediaProperties::AudioEncodingQuality")]
                AudioEncodingQuality quality,
            [NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProfile **")]
                IMediaEncodingProfile* value
        );

        [VtblIndex(8)]
        HRESULT CreateHevc(
            [NativeTypeName("ABI::Windows::Media::MediaProperties::VideoEncodingQuality")]
                VideoEncodingQuality quality,
            [NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProfile **")]
                IMediaEncodingProfile* value
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
            "HRESULT (ABI::Windows::Media::MediaProperties::AudioEncodingQuality, ABI::Windows::Media::MediaProperties::IMediaEncodingProfile **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            AudioEncodingQuality,
            IMediaEncodingProfile*,
            int> CreateAlac;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::MediaProperties::AudioEncodingQuality, ABI::Windows::Media::MediaProperties::IMediaEncodingProfile **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            AudioEncodingQuality,
            IMediaEncodingProfile*,
            int> CreateFlac;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::MediaProperties::VideoEncodingQuality, ABI::Windows::Media::MediaProperties::IMediaEncodingProfile **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            VideoEncodingQuality,
            IMediaEncodingProfile*,
            int> CreateHevc;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMediaEncodingProfileStatics3"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMediaEncodingProfileStatics3(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IMediaEncodingProfileStatics3"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IMediaEncodingProfileStatics3(Silk.NET.WinRT.IInspectable value)
    {
        return new IMediaEncodingProfileStatics3(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMediaEncodingProfileStatics3"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IMediaEncodingProfileStatics3"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IMediaEncodingProfileStatics3 value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMediaEncodingProfileStatics3"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMediaEncodingProfileStatics3(Silk.NET.Windows.IUnknown value)
    {
        return new IMediaEncodingProfileStatics3(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMediaEncodingProfileStatics3"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMediaEncodingProfileStatics3"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMediaEncodingProfileStatics3 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
