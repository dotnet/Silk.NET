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

[Guid("85361600-1C63-4627-BCB1-3A89E0BC9C55")]
[NativeTypeName("struct IUISettings : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IUISettings : IUISettings.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IUISettings));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IUISettings, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IUISettings, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IUISettings, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IUISettings, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IUISettings, HSTRING*, int>)((*lpVtbl)[4]))(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IUISettings, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_HandPreference(
        [NativeTypeName("ABI::Windows::UI::ViewManagement::HandPreference *")] HandPreference* value
    )
    {
        return ((delegate* unmanaged<IUISettings, HandPreference*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_CursorSize([NativeTypeName("ABI::Windows::Foundation::Size *")] Size* value)
    {
        return ((delegate* unmanaged<IUISettings, Size*, int>)((*lpVtbl)[7]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_ScrollBarSize(
        [NativeTypeName("ABI::Windows::Foundation::Size *")] Size* value
    )
    {
        return ((delegate* unmanaged<IUISettings, Size*, int>)((*lpVtbl)[8]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_ScrollBarArrowSize(
        [NativeTypeName("ABI::Windows::Foundation::Size *")] Size* value
    )
    {
        return ((delegate* unmanaged<IUISettings, Size*, int>)((*lpVtbl)[9]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_ScrollBarThumbBoxSize(
        [NativeTypeName("ABI::Windows::Foundation::Size *")] Size* value
    )
    {
        return ((delegate* unmanaged<IUISettings, Size*, int>)((*lpVtbl)[10]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_MessageDuration([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged<IUISettings, uint*, int>)((*lpVtbl)[11]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_AnimationsEnabled([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IUISettings, byte*, int>)((*lpVtbl)[12]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_CaretBrowsingEnabled([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IUISettings, byte*, int>)((*lpVtbl)[13]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_CaretBlinkRate([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged<IUISettings, uint*, int>)((*lpVtbl)[14]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_CaretWidth([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged<IUISettings, uint*, int>)((*lpVtbl)[15]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_DoubleClickTime([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged<IUISettings, uint*, int>)((*lpVtbl)[16]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_MouseHoverTime([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged<IUISettings, uint*, int>)((*lpVtbl)[17]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT UIElementColor(
        [NativeTypeName("ABI::Windows::UI::ViewManagement::UIElementType")]
            UIElementType desiredElement,
        [NativeTypeName("ABI::Windows::UI::Color *")] Color* value
    )
    {
        return ((delegate* unmanaged<IUISettings, UIElementType, Color*, int>)((*lpVtbl)[18]))(
            this,
            desiredElement,
            value
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_HandPreference(
            [NativeTypeName("ABI::Windows::UI::ViewManagement::HandPreference *")]
                HandPreference* value
        );

        [VtblIndex(7)]
        HRESULT get_CursorSize([NativeTypeName("ABI::Windows::Foundation::Size *")] Size* value);

        [VtblIndex(8)]
        HRESULT get_ScrollBarSize([NativeTypeName("ABI::Windows::Foundation::Size *")] Size* value);

        [VtblIndex(9)]
        HRESULT get_ScrollBarArrowSize(
            [NativeTypeName("ABI::Windows::Foundation::Size *")] Size* value
        );

        [VtblIndex(10)]
        HRESULT get_ScrollBarThumbBoxSize(
            [NativeTypeName("ABI::Windows::Foundation::Size *")] Size* value
        );

        [VtblIndex(11)]
        HRESULT get_MessageDuration([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(12)]
        HRESULT get_AnimationsEnabled([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(13)]
        HRESULT get_CaretBrowsingEnabled([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(14)]
        HRESULT get_CaretBlinkRate([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(15)]
        HRESULT get_CaretWidth([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(16)]
        HRESULT get_DoubleClickTime([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(17)]
        HRESULT get_MouseHoverTime([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(18)]
        HRESULT UIElementColor(
            [NativeTypeName("ABI::Windows::UI::ViewManagement::UIElementType")]
                UIElementType desiredElement,
            [NativeTypeName("ABI::Windows::UI::Color *")] Color* value
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
            "HRESULT (ABI::Windows::UI::ViewManagement::HandPreference *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HandPreference*, int> get_HandPreference;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Size *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Size*, int> get_CursorSize;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Size *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Size*, int> get_ScrollBarSize;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Size *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Size*, int> get_ScrollBarArrowSize;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Size *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Size*, int> get_ScrollBarThumbBoxSize;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_MessageDuration;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_AnimationsEnabled;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_CaretBrowsingEnabled;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_CaretBlinkRate;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_CaretWidth;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_DoubleClickTime;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_MouseHoverTime;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::ViewManagement::UIElementType, ABI::Windows::UI::Color *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, UIElementType, Color*, int> UIElementColor;
    }

    /// <summary>Initializes a new instance of the <see cref = "IUISettings"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IUISettings(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IUISettings"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IUISettings(Silk.NET.WinRT.IInspectable value)
    {
        return new IUISettings(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IUISettings"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IUISettings"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IUISettings value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IUISettings"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IUISettings(Silk.NET.Windows.IUnknown value)
    {
        return new IUISettings(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IUISettings"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IUISettings"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IUISettings value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
