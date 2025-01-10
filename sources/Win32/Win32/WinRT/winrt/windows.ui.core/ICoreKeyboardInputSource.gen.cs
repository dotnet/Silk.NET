// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.ui.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("231C9088-E469-4DF1-B208-6E490D71CB90")]
[NativeTypeName("struct ICoreKeyboardInputSource : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICoreKeyboardInputSource
    : ICoreKeyboardInputSource.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICoreKeyboardInputSource));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ICoreKeyboardInputSource, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ICoreKeyboardInputSource, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICoreKeyboardInputSource, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<ICoreKeyboardInputSource, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<ICoreKeyboardInputSource, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<ICoreKeyboardInputSource, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetCurrentKeyState(
        [NativeTypeName("ABI::Windows::System::VirtualKey")] VirtualKey virtualKey,
        [NativeTypeName("ABI::Windows::UI::Core::CoreVirtualKeyStates *")]
            CoreVirtualKeyStates* KeyState
    )
    {
        return (
            (delegate* unmanaged<ICoreKeyboardInputSource, VirtualKey, CoreVirtualKeyStates*, int>)(
                (*lpVtbl)[6]
            )
        )(this, virtualKey, KeyState);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT add_CharacterReceived(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_IInspectable_Windows__CUI__CCore__CCharacterReceivedEventArgs_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* handler,
        EventRegistrationToken* pCookie
    )
    {
        return (
            (delegate* unmanaged<
                ICoreKeyboardInputSource,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[7])
        )(this, handler, pCookie);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT remove_CharacterReceived(EventRegistrationToken cookie)
    {
        return (
            (delegate* unmanaged<ICoreKeyboardInputSource, EventRegistrationToken, int>)(
                (*lpVtbl)[8]
            )
        )(this, cookie);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT add_KeyDown(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_IInspectable_Windows__CUI__CCore__CKeyEventArgs_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* handler,
        EventRegistrationToken* pCookie
    )
    {
        return (
            (delegate* unmanaged<
                ICoreKeyboardInputSource,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[9])
        )(this, handler, pCookie);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT remove_KeyDown(EventRegistrationToken cookie)
    {
        return (
            (delegate* unmanaged<ICoreKeyboardInputSource, EventRegistrationToken, int>)(
                (*lpVtbl)[10]
            )
        )(this, cookie);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT add_KeyUp(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_IInspectable_Windows__CUI__CCore__CKeyEventArgs_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* handler,
        EventRegistrationToken* pCookie
    )
    {
        return (
            (delegate* unmanaged<
                ICoreKeyboardInputSource,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[11])
        )(this, handler, pCookie);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT remove_KeyUp(EventRegistrationToken cookie)
    {
        return (
            (delegate* unmanaged<ICoreKeyboardInputSource, EventRegistrationToken, int>)(
                (*lpVtbl)[12]
            )
        )(this, cookie);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetCurrentKeyState(
            [NativeTypeName("ABI::Windows::System::VirtualKey")] VirtualKey virtualKey,
            [NativeTypeName("ABI::Windows::UI::Core::CoreVirtualKeyStates *")]
                CoreVirtualKeyStates* KeyState
        );

        [VtblIndex(7)]
        HRESULT add_CharacterReceived(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_IInspectable_Windows__CUI__CCore__CCharacterReceivedEventArgs_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* handler,
            EventRegistrationToken* pCookie
        );

        [VtblIndex(8)]
        HRESULT remove_CharacterReceived(EventRegistrationToken cookie);

        [VtblIndex(9)]
        HRESULT add_KeyDown(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_IInspectable_Windows__CUI__CCore__CKeyEventArgs_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* handler,
            EventRegistrationToken* pCookie
        );

        [VtblIndex(10)]
        HRESULT remove_KeyDown(EventRegistrationToken cookie);

        [VtblIndex(11)]
        HRESULT add_KeyUp(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_IInspectable_Windows__CUI__CCore__CKeyEventArgs_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* handler,
            EventRegistrationToken* pCookie
        );

        [VtblIndex(12)]
        HRESULT remove_KeyUp(EventRegistrationToken cookie);
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
            "HRESULT (ABI::Windows::System::VirtualKey, ABI::Windows::UI::Core::CoreVirtualKeyStates *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            VirtualKey,
            CoreVirtualKeyStates*,
            int> GetCurrentKeyState;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_IInspectable_Windows__CUI__CCore__CCharacterReceivedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_CharacterReceived;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_CharacterReceived;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_IInspectable_Windows__CUI__CCore__CKeyEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_KeyDown;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_KeyDown;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_IInspectable_Windows__CUI__CCore__CKeyEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_KeyUp;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_KeyUp;
    }

    /// <summary>Initializes a new instance of the <see cref = "ICoreKeyboardInputSource"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ICoreKeyboardInputSource(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ICoreKeyboardInputSource"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ICoreKeyboardInputSource(Silk.NET.WinRT.IInspectable value)
    {
        return new ICoreKeyboardInputSource(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICoreKeyboardInputSource"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ICoreKeyboardInputSource"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(ICoreKeyboardInputSource value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ICoreKeyboardInputSource"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ICoreKeyboardInputSource(Silk.NET.Windows.IUnknown value)
    {
        return new ICoreKeyboardInputSource(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICoreKeyboardInputSource"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ICoreKeyboardInputSource"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ICoreKeyboardInputSource value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
