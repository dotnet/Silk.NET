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

[Guid("E7DBF5A8-1DB9-4783-876B-3DFE12ACFDB3")]
[NativeTypeName("struct IMediaEncodingProfile : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaEncodingProfile : IMediaEncodingProfile.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaEncodingProfile));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMediaEncodingProfile, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMediaEncodingProfile, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMediaEncodingProfile, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IMediaEncodingProfile, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IMediaEncodingProfile, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IMediaEncodingProfile, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT put_Audio(
        [NativeTypeName("ABI::Windows::Media::MediaProperties::IAudioEncodingProperties *")]
            IAudioEncodingProperties value
    )
    {
        return (
            (delegate* unmanaged<IMediaEncodingProfile, IAudioEncodingProperties, int>)(
                (*lpVtbl)[6]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Audio(
        [NativeTypeName("ABI::Windows::Media::MediaProperties::IAudioEncodingProperties **")]
            IAudioEncodingProperties* value
    )
    {
        return (
            (delegate* unmanaged<IMediaEncodingProfile, IAudioEncodingProperties*, int>)(
                (*lpVtbl)[7]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_Video(
        [NativeTypeName("ABI::Windows::Media::MediaProperties::IVideoEncodingProperties *")]
            IVideoEncodingProperties value
    )
    {
        return (
            (delegate* unmanaged<IMediaEncodingProfile, IVideoEncodingProperties, int>)(
                (*lpVtbl)[8]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Video(
        [NativeTypeName("ABI::Windows::Media::MediaProperties::IVideoEncodingProperties **")]
            IVideoEncodingProperties* value
    )
    {
        return (
            (delegate* unmanaged<IMediaEncodingProfile, IVideoEncodingProperties*, int>)(
                (*lpVtbl)[9]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_Container(
        [NativeTypeName("ABI::Windows::Media::MediaProperties::IContainerEncodingProperties *")]
            IContainerEncodingProperties value
    )
    {
        return (
            (delegate* unmanaged<IMediaEncodingProfile, IContainerEncodingProperties, int>)(
                (*lpVtbl)[10]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_Container(
        [NativeTypeName("ABI::Windows::Media::MediaProperties::IContainerEncodingProperties **")]
            IContainerEncodingProperties* value
    )
    {
        return (
            (delegate* unmanaged<IMediaEncodingProfile, IContainerEncodingProperties*, int>)(
                (*lpVtbl)[11]
            )
        )(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT put_Audio(
            [NativeTypeName("ABI::Windows::Media::MediaProperties::IAudioEncodingProperties *")]
                IAudioEncodingProperties value
        );

        [VtblIndex(7)]
        HRESULT get_Audio(
            [NativeTypeName("ABI::Windows::Media::MediaProperties::IAudioEncodingProperties **")]
                IAudioEncodingProperties* value
        );

        [VtblIndex(8)]
        HRESULT put_Video(
            [NativeTypeName("ABI::Windows::Media::MediaProperties::IVideoEncodingProperties *")]
                IVideoEncodingProperties value
        );

        [VtblIndex(9)]
        HRESULT get_Video(
            [NativeTypeName("ABI::Windows::Media::MediaProperties::IVideoEncodingProperties **")]
                IVideoEncodingProperties* value
        );

        [VtblIndex(10)]
        HRESULT put_Container(
            [NativeTypeName("ABI::Windows::Media::MediaProperties::IContainerEncodingProperties *")]
                IContainerEncodingProperties value
        );

        [VtblIndex(11)]
        HRESULT get_Container(
            [NativeTypeName(
                "ABI::Windows::Media::MediaProperties::IContainerEncodingProperties **"
            )]
                IContainerEncodingProperties* value
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
            "HRESULT (ABI::Windows::Media::MediaProperties::IAudioEncodingProperties *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAudioEncodingProperties, int> put_Audio;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::MediaProperties::IAudioEncodingProperties **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAudioEncodingProperties*, int> get_Audio;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::MediaProperties::IVideoEncodingProperties *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IVideoEncodingProperties, int> put_Video;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::MediaProperties::IVideoEncodingProperties **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IVideoEncodingProperties*, int> get_Video;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::MediaProperties::IContainerEncodingProperties *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IContainerEncodingProperties, int> put_Container;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::MediaProperties::IContainerEncodingProperties **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IContainerEncodingProperties*, int> get_Container;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMediaEncodingProfile"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMediaEncodingProfile(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IMediaEncodingProfile"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IMediaEncodingProfile(Silk.NET.WinRT.IInspectable value)
    {
        return new IMediaEncodingProfile(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMediaEncodingProfile"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IMediaEncodingProfile"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IMediaEncodingProfile value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMediaEncodingProfile"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMediaEncodingProfile(Silk.NET.Windows.IUnknown value)
    {
        return new IMediaEncodingProfile(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMediaEncodingProfile"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMediaEncodingProfile"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMediaEncodingProfile value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
