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

[Guid("E0CAA086-AE65-414C-B010-8BC55F00E692")]
[NativeTypeName("struct IMediaPlayer6 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaPlayer6 : IMediaPlayer6.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaPlayer6));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMediaPlayer6, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMediaPlayer6, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMediaPlayer6, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IMediaPlayer6, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IMediaPlayer6, HSTRING*, int>)((*lpVtbl)[4]))(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IMediaPlayer6, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT add_SubtitleFrameChanged(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlayer_IInspectable_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* handler,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IMediaPlayer6,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[6])
        )(this, handler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT remove_SubtitleFrameChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged<IMediaPlayer6, EventRegistrationToken, int>)((*lpVtbl)[7]))(
            this,
            token
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT RenderSubtitlesToSurface(
        [NativeTypeName("ABI::Windows::Graphics::DirectX::Direct3D11::IDirect3DSurface *")]
            IDirect3DSurface destination,
        [NativeTypeName("boolean *")] byte* result
    )
    {
        return ((delegate* unmanaged<IMediaPlayer6, IDirect3DSurface, byte*, int>)((*lpVtbl)[8]))(
            this,
            destination,
            result
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT RenderSubtitlesToSurfaceWithTargetRectangle(
        [NativeTypeName("ABI::Windows::Graphics::DirectX::Direct3D11::IDirect3DSurface *")]
            IDirect3DSurface destination,
        [NativeTypeName("ABI::Windows::Foundation::Rect")] Rect targetRectangle,
        [NativeTypeName("boolean *")] byte* result
    )
    {
        return (
            (delegate* unmanaged<IMediaPlayer6, IDirect3DSurface, Rect, byte*, int>)((*lpVtbl)[9])
        )(this, destination, targetRectangle, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT add_SubtitleFrameChanged(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlayer_IInspectable_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* handler,
            EventRegistrationToken* token
        );

        [VtblIndex(7)]
        HRESULT remove_SubtitleFrameChanged(EventRegistrationToken token);

        [VtblIndex(8)]
        HRESULT RenderSubtitlesToSurface(
            [NativeTypeName("ABI::Windows::Graphics::DirectX::Direct3D11::IDirect3DSurface *")]
                IDirect3DSurface destination,
            [NativeTypeName("boolean *")] byte* result
        );

        [VtblIndex(9)]
        HRESULT RenderSubtitlesToSurfaceWithTargetRectangle(
            [NativeTypeName("ABI::Windows::Graphics::DirectX::Direct3D11::IDirect3DSurface *")]
                IDirect3DSurface destination,
            [NativeTypeName("ABI::Windows::Foundation::Rect")] Rect targetRectangle,
            [NativeTypeName("boolean *")] byte* result
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
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlayer_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_SubtitleFrameChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_SubtitleFrameChanged;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Graphics::DirectX::Direct3D11::IDirect3DSurface *, boolean *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDirect3DSurface, byte*, int> RenderSubtitlesToSurface;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Graphics::DirectX::Direct3D11::IDirect3DSurface *, ABI::Windows::Foundation::Rect, boolean *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IDirect3DSurface,
            Rect,
            byte*,
            int> RenderSubtitlesToSurfaceWithTargetRectangle;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMediaPlayer6"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMediaPlayer6(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IMediaPlayer6"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IMediaPlayer6(Silk.NET.WinRT.IInspectable value)
    {
        return new IMediaPlayer6(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMediaPlayer6"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IMediaPlayer6"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IMediaPlayer6 value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMediaPlayer6"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMediaPlayer6(Silk.NET.Windows.IUnknown value)
    {
        return new IMediaPlayer6(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMediaPlayer6"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMediaPlayer6"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMediaPlayer6 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
