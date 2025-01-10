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

[Guid("8C530A78-E0AE-4E1A-A8C8-E23F982A937B")]
[NativeTypeName("struct IPlaybackMediaMarkerFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPlaybackMediaMarkerFactory
    : IPlaybackMediaMarkerFactory.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPlaybackMediaMarkerFactory));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IPlaybackMediaMarkerFactory, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IPlaybackMediaMarkerFactory, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPlaybackMediaMarkerFactory, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IPlaybackMediaMarkerFactory, uint*, Guid**, int>)((*lpVtbl)[3])
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IPlaybackMediaMarkerFactory, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IPlaybackMediaMarkerFactory, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateFromTime(
        [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan value,
        [NativeTypeName("ABI::Windows::Media::Playback::IPlaybackMediaMarker **")]
            IPlaybackMediaMarker* marker
    )
    {
        return (
            (delegate* unmanaged<
                IPlaybackMediaMarkerFactory,
                TimeSpan,
                IPlaybackMediaMarker*,
                int>)((*lpVtbl)[6])
        )(this, value, marker);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT Create(
        [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan value,
        HSTRING mediaMarketType,
        HSTRING text,
        [NativeTypeName("ABI::Windows::Media::Playback::IPlaybackMediaMarker **")]
            IPlaybackMediaMarker* marker
    )
    {
        return (
            (delegate* unmanaged<
                IPlaybackMediaMarkerFactory,
                TimeSpan,
                HSTRING,
                HSTRING,
                IPlaybackMediaMarker*,
                int>)((*lpVtbl)[7])
        )(this, value, mediaMarketType, text, marker);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateFromTime(
            [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan value,
            [NativeTypeName("ABI::Windows::Media::Playback::IPlaybackMediaMarker **")]
                IPlaybackMediaMarker* marker
        );

        [VtblIndex(7)]
        HRESULT Create(
            [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan value,
            HSTRING mediaMarketType,
            HSTRING text,
            [NativeTypeName("ABI::Windows::Media::Playback::IPlaybackMediaMarker **")]
                IPlaybackMediaMarker* marker
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
            "HRESULT (ABI::Windows::Foundation::TimeSpan, ABI::Windows::Media::Playback::IPlaybackMediaMarker **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, TimeSpan, IPlaybackMediaMarker*, int> CreateFromTime;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::TimeSpan, HSTRING, HSTRING, ABI::Windows::Media::Playback::IPlaybackMediaMarker **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            TimeSpan,
            HSTRING,
            HSTRING,
            IPlaybackMediaMarker*,
            int> Create;
    }

    /// <summary>Initializes a new instance of the <see cref = "IPlaybackMediaMarkerFactory"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IPlaybackMediaMarkerFactory(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IPlaybackMediaMarkerFactory"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IPlaybackMediaMarkerFactory(Silk.NET.WinRT.IInspectable value)
    {
        return new IPlaybackMediaMarkerFactory(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPlaybackMediaMarkerFactory"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IPlaybackMediaMarkerFactory"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IPlaybackMediaMarkerFactory value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IPlaybackMediaMarkerFactory"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IPlaybackMediaMarkerFactory(Silk.NET.Windows.IUnknown value)
    {
        return new IPlaybackMediaMarkerFactory(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPlaybackMediaMarkerFactory"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IPlaybackMediaMarkerFactory"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IPlaybackMediaMarkerFactory value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
