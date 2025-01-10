// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.ui.viewmanagement.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("5349D588-0CB5-5F05-BD34-706B3231F0BD")]
[NativeTypeName("struct IUISettings5 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IUISettings5 : IUISettings5.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IUISettings5));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IUISettings5, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IUISettings5, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IUISettings5, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IUISettings5, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IUISettings5, HSTRING*, int>)((*lpVtbl)[4]))(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IUISettings5, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_AutoHideScrollBars([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IUISettings5, byte*, int>)((*lpVtbl)[6]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT add_AutoHideScrollBarsChanged(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CViewManagement__CUISettings_Windows__CUI__CViewManagement__CUISettingsAutoHideScrollBarsChangedEventArgs_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* handler,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IUISettings5,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[7])
        )(this, handler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT remove_AutoHideScrollBarsChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged<IUISettings5, EventRegistrationToken, int>)((*lpVtbl)[8]))(
            this,
            token
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_AutoHideScrollBars([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(7)]
        HRESULT add_AutoHideScrollBarsChanged(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CViewManagement__CUISettings_Windows__CUI__CViewManagement__CUISettingsAutoHideScrollBarsChangedEventArgs_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* handler,
            EventRegistrationToken* token
        );

        [VtblIndex(8)]
        HRESULT remove_AutoHideScrollBarsChanged(EventRegistrationToken token);
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
        public delegate* unmanaged<TSelf*, byte*, int> get_AutoHideScrollBars;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CViewManagement__CUISettings_Windows__CUI__CViewManagement__CUISettingsAutoHideScrollBarsChangedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_AutoHideScrollBarsChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            EventRegistrationToken,
            int> remove_AutoHideScrollBarsChanged;
    }

    /// <summary>Initializes a new instance of the <see cref = "IUISettings5"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IUISettings5(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IUISettings5"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IUISettings5(Silk.NET.WinRT.IInspectable value)
    {
        return new IUISettings5(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IUISettings5"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IUISettings5"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IUISettings5 value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IUISettings5"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IUISettings5(Silk.NET.Windows.IUnknown value)
    {
        return new IUISettings5(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IUISettings5"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IUISettings5"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IUISettings5 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
