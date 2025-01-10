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

[Guid("3CE14D44-1DC5-43DB-9F38-EBEBF90152CB")]
[NativeTypeName("struct IVideoEncodingPropertiesStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IVideoEncodingPropertiesStatics
    : IVideoEncodingPropertiesStatics.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IVideoEncodingPropertiesStatics));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IVideoEncodingPropertiesStatics, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IVideoEncodingPropertiesStatics, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IVideoEncodingPropertiesStatics, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IVideoEncodingPropertiesStatics, uint*, Guid**, int>)((*lpVtbl)[3])
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<IVideoEncodingPropertiesStatics, HSTRING*, int>)((*lpVtbl)[4])
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IVideoEncodingPropertiesStatics, TrustLevel*, int>)((*lpVtbl)[5])
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateH264(
        [NativeTypeName("ABI::Windows::Media::MediaProperties::IVideoEncodingProperties **")]
            IVideoEncodingProperties* value
    )
    {
        return (
            (delegate* unmanaged<IVideoEncodingPropertiesStatics, IVideoEncodingProperties*, int>)(
                (*lpVtbl)[6]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateMpeg2(
        [NativeTypeName("ABI::Windows::Media::MediaProperties::IVideoEncodingProperties **")]
            IVideoEncodingProperties* value
    )
    {
        return (
            (delegate* unmanaged<IVideoEncodingPropertiesStatics, IVideoEncodingProperties*, int>)(
                (*lpVtbl)[7]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateUncompressed(
        HSTRING subtype,
        [NativeTypeName("UINT32")] uint width,
        [NativeTypeName("UINT32")] uint height,
        [NativeTypeName("ABI::Windows::Media::MediaProperties::IVideoEncodingProperties **")]
            IVideoEncodingProperties* value
    )
    {
        return (
            (delegate* unmanaged<
                IVideoEncodingPropertiesStatics,
                HSTRING,
                uint,
                uint,
                IVideoEncodingProperties*,
                int>)((*lpVtbl)[8])
        )(this, subtype, width, height, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateH264(
            [NativeTypeName("ABI::Windows::Media::MediaProperties::IVideoEncodingProperties **")]
                IVideoEncodingProperties* value
        );

        [VtblIndex(7)]
        HRESULT CreateMpeg2(
            [NativeTypeName("ABI::Windows::Media::MediaProperties::IVideoEncodingProperties **")]
                IVideoEncodingProperties* value
        );

        [VtblIndex(8)]
        HRESULT CreateUncompressed(
            HSTRING subtype,
            [NativeTypeName("UINT32")] uint width,
            [NativeTypeName("UINT32")] uint height,
            [NativeTypeName("ABI::Windows::Media::MediaProperties::IVideoEncodingProperties **")]
                IVideoEncodingProperties* value
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
            "HRESULT (ABI::Windows::Media::MediaProperties::IVideoEncodingProperties **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IVideoEncodingProperties*, int> CreateH264;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::MediaProperties::IVideoEncodingProperties **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IVideoEncodingProperties*, int> CreateMpeg2;

        [NativeTypeName(
            "HRESULT (HSTRING, UINT32, UINT32, ABI::Windows::Media::MediaProperties::IVideoEncodingProperties **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            uint,
            uint,
            IVideoEncodingProperties*,
            int> CreateUncompressed;
    }

    /// <summary>Initializes a new instance of the <see cref = "IVideoEncodingPropertiesStatics"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IVideoEncodingPropertiesStatics(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IVideoEncodingPropertiesStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IVideoEncodingPropertiesStatics(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new IVideoEncodingPropertiesStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IVideoEncodingPropertiesStatics"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IVideoEncodingPropertiesStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        IVideoEncodingPropertiesStatics value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IVideoEncodingPropertiesStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IVideoEncodingPropertiesStatics(Silk.NET.Windows.IUnknown value)
    {
        return new IVideoEncodingPropertiesStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IVideoEncodingPropertiesStatics"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IVideoEncodingPropertiesStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IVideoEncodingPropertiesStatics value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
