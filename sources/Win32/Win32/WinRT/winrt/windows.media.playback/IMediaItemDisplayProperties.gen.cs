// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.playback.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("1E3C1B48-7097-4384-A217-C1291DFA8C16")]
[NativeTypeName("struct IMediaItemDisplayProperties : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaItemDisplayProperties
    : IMediaItemDisplayProperties.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaItemDisplayProperties));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IMediaItemDisplayProperties, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMediaItemDisplayProperties, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMediaItemDisplayProperties, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IMediaItemDisplayProperties, uint*, Guid**, int>)((*lpVtbl)[3])
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IMediaItemDisplayProperties, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IMediaItemDisplayProperties, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Type(
        [NativeTypeName("ABI::Windows::Media::MediaPlaybackType *")] MediaPlaybackType* value
    )
    {
        return (
            (delegate* unmanaged<IMediaItemDisplayProperties, MediaPlaybackType*, int>)(
                (*lpVtbl)[6]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Type(
        [NativeTypeName("ABI::Windows::Media::MediaPlaybackType")] MediaPlaybackType value
    )
    {
        return (
            (delegate* unmanaged<IMediaItemDisplayProperties, MediaPlaybackType, int>)((*lpVtbl)[7])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_MusicProperties(
        [NativeTypeName("ABI::Windows::Media::IMusicDisplayProperties **")]
            IMusicDisplayProperties* value
    )
    {
        return (
            (delegate* unmanaged<IMediaItemDisplayProperties, IMusicDisplayProperties*, int>)(
                (*lpVtbl)[8]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_VideoProperties(
        [NativeTypeName("ABI::Windows::Media::IVideoDisplayProperties **")]
            IVideoDisplayProperties* value
    )
    {
        return (
            (delegate* unmanaged<IMediaItemDisplayProperties, IVideoDisplayProperties*, int>)(
                (*lpVtbl)[9]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Thumbnail(
        [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference **")]
            IRandomAccessStreamReference* value
    )
    {
        return (
            (delegate* unmanaged<IMediaItemDisplayProperties, IRandomAccessStreamReference*, int>)(
                (*lpVtbl)[10]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_Thumbnail(
        [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference *")]
            IRandomAccessStreamReference value
    )
    {
        return (
            (delegate* unmanaged<IMediaItemDisplayProperties, IRandomAccessStreamReference, int>)(
                (*lpVtbl)[11]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT ClearAll()
    {
        return ((delegate* unmanaged<IMediaItemDisplayProperties, int>)((*lpVtbl)[12]))(this);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Type(
            [NativeTypeName("ABI::Windows::Media::MediaPlaybackType *")] MediaPlaybackType* value
        );

        [VtblIndex(7)]
        HRESULT put_Type(
            [NativeTypeName("ABI::Windows::Media::MediaPlaybackType")] MediaPlaybackType value
        );

        [VtblIndex(8)]
        HRESULT get_MusicProperties(
            [NativeTypeName("ABI::Windows::Media::IMusicDisplayProperties **")]
                IMusicDisplayProperties* value
        );

        [VtblIndex(9)]
        HRESULT get_VideoProperties(
            [NativeTypeName("ABI::Windows::Media::IVideoDisplayProperties **")]
                IVideoDisplayProperties* value
        );

        [VtblIndex(10)]
        HRESULT get_Thumbnail(
            [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference **")]
                IRandomAccessStreamReference* value
        );

        [VtblIndex(11)]
        HRESULT put_Thumbnail(
            [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference *")]
                IRandomAccessStreamReference value
        );

        [VtblIndex(12)]
        HRESULT ClearAll();
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
            "HRESULT (ABI::Windows::Media::MediaPlaybackType *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, MediaPlaybackType*, int> get_Type;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::MediaPlaybackType) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, MediaPlaybackType, int> put_Type;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::IMusicDisplayProperties **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IMusicDisplayProperties*, int> get_MusicProperties;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::IVideoDisplayProperties **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IVideoDisplayProperties*, int> get_VideoProperties;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Streams::IRandomAccessStreamReference **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IRandomAccessStreamReference*, int> get_Thumbnail;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Streams::IRandomAccessStreamReference *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IRandomAccessStreamReference, int> put_Thumbnail;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> ClearAll;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMediaItemDisplayProperties"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMediaItemDisplayProperties(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IMediaItemDisplayProperties"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IMediaItemDisplayProperties(Silk.NET.WinRT.IInspectable value)
    {
        return new IMediaItemDisplayProperties(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMediaItemDisplayProperties"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IMediaItemDisplayProperties"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IMediaItemDisplayProperties value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMediaItemDisplayProperties"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMediaItemDisplayProperties(Silk.NET.Windows.IUnknown value)
    {
        return new IMediaItemDisplayProperties(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMediaItemDisplayProperties"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMediaItemDisplayProperties"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMediaItemDisplayProperties value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
