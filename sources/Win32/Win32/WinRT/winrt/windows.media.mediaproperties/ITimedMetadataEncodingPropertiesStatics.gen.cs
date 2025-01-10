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

[Guid("6629BB67-6E55-5643-89A0-7A7E8D85B52C")]
[NativeTypeName("struct ITimedMetadataEncodingPropertiesStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ITimedMetadataEncodingPropertiesStatics
    : ITimedMetadataEncodingPropertiesStatics.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITimedMetadataEncodingPropertiesStatics));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<ITimedMetadataEncodingPropertiesStatics, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ITimedMetadataEncodingPropertiesStatics, uint>)((*lpVtbl)[1]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITimedMetadataEncodingPropertiesStatics, uint>)((*lpVtbl)[2]))(
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
            (delegate* unmanaged<ITimedMetadataEncodingPropertiesStatics, uint*, Guid**, int>)(
                (*lpVtbl)[3]
            )
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<ITimedMetadataEncodingPropertiesStatics, HSTRING*, int>)(
                (*lpVtbl)[4]
            )
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<ITimedMetadataEncodingPropertiesStatics, TrustLevel*, int>)(
                (*lpVtbl)[5]
            )
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreatePgs(
        [NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProperties **")]
            IMediaEncodingProperties* result
    )
    {
        return (
            (delegate* unmanaged<
                ITimedMetadataEncodingPropertiesStatics,
                IMediaEncodingProperties*,
                int>)((*lpVtbl)[6])
        )(this, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateSrt(
        [NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProperties **")]
            IMediaEncodingProperties* result
    )
    {
        return (
            (delegate* unmanaged<
                ITimedMetadataEncodingPropertiesStatics,
                IMediaEncodingProperties*,
                int>)((*lpVtbl)[7])
        )(this, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateSsa(
        [NativeTypeName("UINT32")] uint formatUserDataLength,
        byte* formatUserData,
        [NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProperties **")]
            IMediaEncodingProperties* result
    )
    {
        return (
            (delegate* unmanaged<
                ITimedMetadataEncodingPropertiesStatics,
                uint,
                byte*,
                IMediaEncodingProperties*,
                int>)((*lpVtbl)[8])
        )(this, formatUserDataLength, formatUserData, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT CreateVobSub(
        [NativeTypeName("UINT32")] uint formatUserDataLength,
        byte* formatUserData,
        [NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProperties **")]
            IMediaEncodingProperties* result
    )
    {
        return (
            (delegate* unmanaged<
                ITimedMetadataEncodingPropertiesStatics,
                uint,
                byte*,
                IMediaEncodingProperties*,
                int>)((*lpVtbl)[9])
        )(this, formatUserDataLength, formatUserData, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreatePgs(
            [NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProperties **")]
                IMediaEncodingProperties* result
        );

        [VtblIndex(7)]
        HRESULT CreateSrt(
            [NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProperties **")]
                IMediaEncodingProperties* result
        );

        [VtblIndex(8)]
        HRESULT CreateSsa(
            [NativeTypeName("UINT32")] uint formatUserDataLength,
            byte* formatUserData,
            [NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProperties **")]
                IMediaEncodingProperties* result
        );

        [VtblIndex(9)]
        HRESULT CreateVobSub(
            [NativeTypeName("UINT32")] uint formatUserDataLength,
            byte* formatUserData,
            [NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProperties **")]
                IMediaEncodingProperties* result
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
            "HRESULT (ABI::Windows::Media::MediaProperties::IMediaEncodingProperties **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IMediaEncodingProperties*, int> CreatePgs;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::MediaProperties::IMediaEncodingProperties **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IMediaEncodingProperties*, int> CreateSrt;

        [NativeTypeName(
            "HRESULT (UINT32, BYTE *, ABI::Windows::Media::MediaProperties::IMediaEncodingProperties **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, byte*, IMediaEncodingProperties*, int> CreateSsa;

        [NativeTypeName(
            "HRESULT (UINT32, BYTE *, ABI::Windows::Media::MediaProperties::IMediaEncodingProperties **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            byte*,
            IMediaEncodingProperties*,
            int> CreateVobSub;
    }

    /// <summary>Initializes a new instance of the <see cref = "ITimedMetadataEncodingPropertiesStatics"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ITimedMetadataEncodingPropertiesStatics(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ITimedMetadataEncodingPropertiesStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ITimedMetadataEncodingPropertiesStatics(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new ITimedMetadataEncodingPropertiesStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ITimedMetadataEncodingPropertiesStatics"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ITimedMetadataEncodingPropertiesStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        ITimedMetadataEncodingPropertiesStatics value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ITimedMetadataEncodingPropertiesStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ITimedMetadataEncodingPropertiesStatics(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new ITimedMetadataEncodingPropertiesStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ITimedMetadataEncodingPropertiesStatics"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ITimedMetadataEncodingPropertiesStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        ITimedMetadataEncodingPropertiesStatics value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
