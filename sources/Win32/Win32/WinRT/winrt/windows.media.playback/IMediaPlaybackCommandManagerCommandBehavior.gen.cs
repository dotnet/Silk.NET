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

[Guid("786C1E78-CE78-4A10-AFD6-843FCBB90C2E")]
[NativeTypeName("struct IMediaPlaybackCommandManagerCommandBehavior : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaPlaybackCommandManagerCommandBehavior
    : IMediaPlaybackCommandManagerCommandBehavior.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)
            Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaPlaybackCommandManagerCommandBehavior));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IMediaPlaybackCommandManagerCommandBehavior, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return (
            (delegate* unmanaged<IMediaPlaybackCommandManagerCommandBehavior, uint>)((*lpVtbl)[1])
        )(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return (
            (delegate* unmanaged<IMediaPlaybackCommandManagerCommandBehavior, uint>)((*lpVtbl)[2])
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
            (delegate* unmanaged<IMediaPlaybackCommandManagerCommandBehavior, uint*, Guid**, int>)(
                (*lpVtbl)[3]
            )
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<IMediaPlaybackCommandManagerCommandBehavior, HSTRING*, int>)(
                (*lpVtbl)[4]
            )
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IMediaPlaybackCommandManagerCommandBehavior, TrustLevel*, int>)(
                (*lpVtbl)[5]
            )
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_CommandManager(
        [NativeTypeName("ABI::Windows::Media::Playback::IMediaPlaybackCommandManager **")]
            IMediaPlaybackCommandManager* value
    )
    {
        return (
            (delegate* unmanaged<
                IMediaPlaybackCommandManagerCommandBehavior,
                IMediaPlaybackCommandManager*,
                int>)((*lpVtbl)[6])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_IsEnabled([NativeTypeName("boolean *")] byte* value)
    {
        return (
            (delegate* unmanaged<IMediaPlaybackCommandManagerCommandBehavior, byte*, int>)(
                (*lpVtbl)[7]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_EnablingRule(
        [NativeTypeName("ABI::Windows::Media::Playback::MediaCommandEnablingRule *")]
            MediaCommandEnablingRule* value
    )
    {
        return (
            (delegate* unmanaged<
                IMediaPlaybackCommandManagerCommandBehavior,
                MediaCommandEnablingRule*,
                int>)((*lpVtbl)[8])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_EnablingRule(
        [NativeTypeName("ABI::Windows::Media::Playback::MediaCommandEnablingRule")]
            MediaCommandEnablingRule value
    )
    {
        return (
            (delegate* unmanaged<
                IMediaPlaybackCommandManagerCommandBehavior,
                MediaCommandEnablingRule,
                int>)((*lpVtbl)[9])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT add_IsEnabledChanged(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackCommandManagerCommandBehavior_IInspectable_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* handler,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IMediaPlaybackCommandManagerCommandBehavior,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[10])
        )(this, handler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT remove_IsEnabledChanged(EventRegistrationToken token)
    {
        return (
            (delegate* unmanaged<
                IMediaPlaybackCommandManagerCommandBehavior,
                EventRegistrationToken,
                int>)((*lpVtbl)[11])
        )(this, token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_CommandManager(
            [NativeTypeName("ABI::Windows::Media::Playback::IMediaPlaybackCommandManager **")]
                IMediaPlaybackCommandManager* value
        );

        [VtblIndex(7)]
        HRESULT get_IsEnabled([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(8)]
        HRESULT get_EnablingRule(
            [NativeTypeName("ABI::Windows::Media::Playback::MediaCommandEnablingRule *")]
                MediaCommandEnablingRule* value
        );

        [VtblIndex(9)]
        HRESULT put_EnablingRule(
            [NativeTypeName("ABI::Windows::Media::Playback::MediaCommandEnablingRule")]
                MediaCommandEnablingRule value
        );

        [VtblIndex(10)]
        HRESULT add_IsEnabledChanged(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackCommandManagerCommandBehavior_IInspectable_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* handler,
            EventRegistrationToken* token
        );

        [VtblIndex(11)]
        HRESULT remove_IsEnabledChanged(EventRegistrationToken token);
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
            "HRESULT (ABI::Windows::Media::Playback::IMediaPlaybackCommandManager **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IMediaPlaybackCommandManager*, int> get_CommandManager;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsEnabled;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Playback::MediaCommandEnablingRule *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, MediaCommandEnablingRule*, int> get_EnablingRule;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Playback::MediaCommandEnablingRule) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, MediaCommandEnablingRule, int> put_EnablingRule;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackCommandManagerCommandBehavior_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_IsEnabledChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_IsEnabledChanged;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMediaPlaybackCommandManagerCommandBehavior"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMediaPlaybackCommandManagerCommandBehavior(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IMediaPlaybackCommandManagerCommandBehavior"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IMediaPlaybackCommandManagerCommandBehavior(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new IMediaPlaybackCommandManagerCommandBehavior(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMediaPlaybackCommandManagerCommandBehavior"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IMediaPlaybackCommandManagerCommandBehavior"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        IMediaPlaybackCommandManagerCommandBehavior value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMediaPlaybackCommandManagerCommandBehavior"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMediaPlaybackCommandManagerCommandBehavior(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IMediaPlaybackCommandManagerCommandBehavior(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMediaPlaybackCommandManagerCommandBehavior"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMediaPlaybackCommandManagerCommandBehavior"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IMediaPlaybackCommandManagerCommandBehavior value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
