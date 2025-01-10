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

[Guid("5C1D0BA7-3856-48B9-8DC6-244BF107BF8C")]
[NativeTypeName("struct IMediaEnginePlaybackSource : IInspectable")]
[NativeInheritance("IInspectable")]
[Obsolete("Use MediaPlayer instead of MediaEngine. For more info, see MSDN.")]
public unsafe partial struct IMediaEnginePlaybackSource
    : IMediaEnginePlaybackSource.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaEnginePlaybackSource));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IMediaEnginePlaybackSource, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMediaEnginePlaybackSource, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMediaEnginePlaybackSource, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IMediaEnginePlaybackSource, uint*, Guid**, int>)((*lpVtbl)[3])
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IMediaEnginePlaybackSource, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IMediaEnginePlaybackSource, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [Obsolete("Use MediaPlayer instead of MediaEngine. For more info, see MSDN.")]
    public HRESULT get_CurrentItem(
        [NativeTypeName("ABI::Windows::Media::Playback::IMediaPlaybackItem **")]
            IMediaPlaybackItem* value
    )
    {
        return (
            (delegate* unmanaged<IMediaEnginePlaybackSource, IMediaPlaybackItem*, int>)(
                (*lpVtbl)[6]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    [Obsolete("Use MediaPlayer instead of MediaEngine. For more info, see MSDN.")]
    public HRESULT SetPlaybackSource(
        [NativeTypeName("ABI::Windows::Media::Playback::IMediaPlaybackSource *")]
            IMediaPlaybackSource source
    )
    {
        return (
            (delegate* unmanaged<IMediaEnginePlaybackSource, IMediaPlaybackSource, int>)(
                (*lpVtbl)[7]
            )
        )(this, source);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        [Obsolete("Use MediaPlayer instead of MediaEngine. For more info, see MSDN.")]
        HRESULT get_CurrentItem(
            [NativeTypeName("ABI::Windows::Media::Playback::IMediaPlaybackItem **")]
                IMediaPlaybackItem* value
        );

        [VtblIndex(7)]
        [Obsolete("Use MediaPlayer instead of MediaEngine. For more info, see MSDN.")]
        HRESULT SetPlaybackSource(
            [NativeTypeName("ABI::Windows::Media::Playback::IMediaPlaybackSource *")]
                IMediaPlaybackSource source
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
            "HRESULT (ABI::Windows::Media::Playback::IMediaPlaybackItem **) __attribute__((stdcall))"
        )]
        [Obsolete("Use MediaPlayer instead of MediaEngine. For more info, see MSDN.")]
        public delegate* unmanaged<TSelf*, IMediaPlaybackItem*, int> get_CurrentItem;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Playback::IMediaPlaybackSource *) __attribute__((stdcall))"
        )]
        [Obsolete("Use MediaPlayer instead of MediaEngine. For more info, see MSDN.")]
        public delegate* unmanaged<TSelf*, IMediaPlaybackSource, int> SetPlaybackSource;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMediaEnginePlaybackSource"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMediaEnginePlaybackSource(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IMediaEnginePlaybackSource"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IMediaEnginePlaybackSource(Silk.NET.WinRT.IInspectable value)
    {
        return new IMediaEnginePlaybackSource(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMediaEnginePlaybackSource"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IMediaEnginePlaybackSource"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IMediaEnginePlaybackSource value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMediaEnginePlaybackSource"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMediaEnginePlaybackSource(Silk.NET.Windows.IUnknown value)
    {
        return new IMediaEnginePlaybackSource(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMediaEnginePlaybackSource"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMediaEnginePlaybackSource"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMediaEnginePlaybackSource value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
