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

[Guid("3D6F4F23-5230-4411-A0E9-BAD94C2A045C")]
[NativeTypeName(
    "struct IMediaPlaybackCommandManagerAutoRepeatModeReceivedEventArgs : IInspectable"
)]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaPlaybackCommandManagerAutoRepeatModeReceivedEventArgs
    : IMediaPlaybackCommandManagerAutoRepeatModeReceivedEventArgs.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)
            Unsafe.AsPointer(
                ref Unsafe.AsRef(in IID_IMediaPlaybackCommandManagerAutoRepeatModeReceivedEventArgs)
            );
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<
                IMediaPlaybackCommandManagerAutoRepeatModeReceivedEventArgs,
                Guid*,
                void**,
                int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return (
            (delegate* unmanaged<
                IMediaPlaybackCommandManagerAutoRepeatModeReceivedEventArgs,
                uint>)((*lpVtbl)[1])
        )(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return (
            (delegate* unmanaged<
                IMediaPlaybackCommandManagerAutoRepeatModeReceivedEventArgs,
                uint>)((*lpVtbl)[2])
        )(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<
                IMediaPlaybackCommandManagerAutoRepeatModeReceivedEventArgs,
                uint*,
                Guid**,
                int>)((*lpVtbl)[3])
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<
                IMediaPlaybackCommandManagerAutoRepeatModeReceivedEventArgs,
                HSTRING*,
                int>)((*lpVtbl)[4])
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<
                IMediaPlaybackCommandManagerAutoRepeatModeReceivedEventArgs,
                TrustLevel*,
                int>)((*lpVtbl)[5])
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Handled([NativeTypeName("boolean *")] byte* value)
    {
        return (
            (delegate* unmanaged<
                IMediaPlaybackCommandManagerAutoRepeatModeReceivedEventArgs,
                byte*,
                int>)((*lpVtbl)[6])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Handled([NativeTypeName("boolean")] byte value)
    {
        return (
            (delegate* unmanaged<
                IMediaPlaybackCommandManagerAutoRepeatModeReceivedEventArgs,
                byte,
                int>)((*lpVtbl)[7])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_AutoRepeatMode(
        [NativeTypeName("ABI::Windows::Media::MediaPlaybackAutoRepeatMode *")]
            MediaPlaybackAutoRepeatMode* value
    )
    {
        return (
            (delegate* unmanaged<
                IMediaPlaybackCommandManagerAutoRepeatModeReceivedEventArgs,
                MediaPlaybackAutoRepeatMode*,
                int>)((*lpVtbl)[8])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetDeferral(
        [NativeTypeName("ABI::Windows::Foundation::IDeferral **")] IDeferral* value
    )
    {
        return (
            (delegate* unmanaged<
                IMediaPlaybackCommandManagerAutoRepeatModeReceivedEventArgs,
                IDeferral*,
                int>)((*lpVtbl)[9])
        )(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Handled([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(7)]
        HRESULT put_Handled([NativeTypeName("boolean")] byte value);

        [VtblIndex(8)]
        HRESULT get_AutoRepeatMode(
            [NativeTypeName("ABI::Windows::Media::MediaPlaybackAutoRepeatMode *")]
                MediaPlaybackAutoRepeatMode* value
        );

        [VtblIndex(9)]
        HRESULT GetDeferral(
            [NativeTypeName("ABI::Windows::Foundation::IDeferral **")] IDeferral* value
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
        public delegate* unmanaged<TSelf*, byte*, int> get_Handled;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_Handled;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::MediaPlaybackAutoRepeatMode *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, MediaPlaybackAutoRepeatMode*, int> get_AutoRepeatMode;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::IDeferral **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDeferral*, int> GetDeferral;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMediaPlaybackCommandManagerAutoRepeatModeReceivedEventArgs"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMediaPlaybackCommandManagerAutoRepeatModeReceivedEventArgs(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IMediaPlaybackCommandManagerAutoRepeatModeReceivedEventArgs"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IMediaPlaybackCommandManagerAutoRepeatModeReceivedEventArgs(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new IMediaPlaybackCommandManagerAutoRepeatModeReceivedEventArgs(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMediaPlaybackCommandManagerAutoRepeatModeReceivedEventArgs"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IMediaPlaybackCommandManagerAutoRepeatModeReceivedEventArgs"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        IMediaPlaybackCommandManagerAutoRepeatModeReceivedEventArgs value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMediaPlaybackCommandManagerAutoRepeatModeReceivedEventArgs"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMediaPlaybackCommandManagerAutoRepeatModeReceivedEventArgs(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IMediaPlaybackCommandManagerAutoRepeatModeReceivedEventArgs(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMediaPlaybackCommandManagerAutoRepeatModeReceivedEventArgs"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMediaPlaybackCommandManagerAutoRepeatModeReceivedEventArgs"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IMediaPlaybackCommandManagerAutoRepeatModeReceivedEventArgs value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
