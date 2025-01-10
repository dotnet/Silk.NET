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

[Guid("0ED653BC-B736-49C3-830B-764A3845313A")]
[NativeTypeName("struct IMediaPlayerSurface : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaPlayerSurface : IMediaPlayerSurface.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaPlayerSurface));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMediaPlayerSurface, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMediaPlayerSurface, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMediaPlayerSurface, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IMediaPlayerSurface, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IMediaPlayerSurface, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IMediaPlayerSurface, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_CompositionSurface(
        [NativeTypeName("ABI::Windows::UI::Composition::ICompositionSurface **")]
            ICompositionSurface* value
    )
    {
        return (
            (delegate* unmanaged<IMediaPlayerSurface, ICompositionSurface*, int>)((*lpVtbl)[6])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Compositor(
        [NativeTypeName("ABI::Windows::UI::Composition::ICompositor **")] ICompositor* value
    )
    {
        return ((delegate* unmanaged<IMediaPlayerSurface, ICompositor*, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_MediaPlayer(
        [NativeTypeName("ABI::Windows::Media::Playback::IMediaPlayer **")] IMediaPlayer* value
    )
    {
        return ((delegate* unmanaged<IMediaPlayerSurface, IMediaPlayer*, int>)((*lpVtbl)[8]))(
            this,
            value
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_CompositionSurface(
            [NativeTypeName("ABI::Windows::UI::Composition::ICompositionSurface **")]
                ICompositionSurface* value
        );

        [VtblIndex(7)]
        HRESULT get_Compositor(
            [NativeTypeName("ABI::Windows::UI::Composition::ICompositor **")] ICompositor* value
        );

        [VtblIndex(8)]
        HRESULT get_MediaPlayer(
            [NativeTypeName("ABI::Windows::Media::Playback::IMediaPlayer **")] IMediaPlayer* value
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
            "HRESULT (ABI::Windows::UI::Composition::ICompositionSurface **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ICompositionSurface*, int> get_CompositionSurface;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Composition::ICompositor **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ICompositor*, int> get_Compositor;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Playback::IMediaPlayer **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IMediaPlayer*, int> get_MediaPlayer;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMediaPlayerSurface"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMediaPlayerSurface(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IMediaPlayerSurface"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IMediaPlayerSurface(Silk.NET.WinRT.IInspectable value)
    {
        return new IMediaPlayerSurface(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMediaPlayerSurface"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IMediaPlayerSurface"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IMediaPlayerSurface value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMediaPlayerSurface"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMediaPlayerSurface(Silk.NET.Windows.IUnknown value)
    {
        return new IMediaPlayerSurface(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMediaPlayerSurface"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMediaPlayerSurface"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMediaPlayerSurface value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
