// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.ui.text.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("7310BD33-B4A8-43B1-B37B-0724D4ACA7AB")]
[NativeTypeName("struct ICoreTextFormatUpdatingEventArgs : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICoreTextFormatUpdatingEventArgs
    : ICoreTextFormatUpdatingEventArgs.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICoreTextFormatUpdatingEventArgs));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<ICoreTextFormatUpdatingEventArgs, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ICoreTextFormatUpdatingEventArgs, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICoreTextFormatUpdatingEventArgs, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<ICoreTextFormatUpdatingEventArgs, uint*, Guid**, int>)(
                (*lpVtbl)[3]
            )
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<ICoreTextFormatUpdatingEventArgs, HSTRING*, int>)((*lpVtbl)[4])
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<ICoreTextFormatUpdatingEventArgs, TrustLevel*, int>)((*lpVtbl)[5])
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Range(
        [NativeTypeName("ABI::Windows::UI::Text::Core::CoreTextRange *")] CoreTextRange* value
    )
    {
        return (
            (delegate* unmanaged<ICoreTextFormatUpdatingEventArgs, CoreTextRange*, int>)(
                (*lpVtbl)[6]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_TextColor(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CViewManagement__CUIElementType_t **"
        )]
            IReference<UIElementType>** value
    )
    {
        return (
            (delegate* unmanaged<
                ICoreTextFormatUpdatingEventArgs,
                IReference<UIElementType>**,
                int>)((*lpVtbl)[7])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_BackgroundColor(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CViewManagement__CUIElementType_t **"
        )]
            IReference<UIElementType>** value
    )
    {
        return (
            (delegate* unmanaged<
                ICoreTextFormatUpdatingEventArgs,
                IReference<UIElementType>**,
                int>)((*lpVtbl)[8])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_UnderlineColor(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CViewManagement__CUIElementType_t **"
        )]
            IReference<UIElementType>** value
    )
    {
        return (
            (delegate* unmanaged<
                ICoreTextFormatUpdatingEventArgs,
                IReference<UIElementType>**,
                int>)((*lpVtbl)[9])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_UnderlineType(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CText__CUnderlineType_t **"
        )]
            IReference<UnderlineType>** value
    )
    {
        return (
            (delegate* unmanaged<
                ICoreTextFormatUpdatingEventArgs,
                IReference<UnderlineType>**,
                int>)((*lpVtbl)[10])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_Reason(
        [NativeTypeName("ABI::Windows::UI::Text::Core::CoreTextFormatUpdatingReason *")]
            CoreTextFormatUpdatingReason* value
    )
    {
        return (
            (delegate* unmanaged<
                ICoreTextFormatUpdatingEventArgs,
                CoreTextFormatUpdatingReason*,
                int>)((*lpVtbl)[11])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_Result(
        [NativeTypeName("ABI::Windows::UI::Text::Core::CoreTextFormatUpdatingResult *")]
            CoreTextFormatUpdatingResult* value
    )
    {
        return (
            (delegate* unmanaged<
                ICoreTextFormatUpdatingEventArgs,
                CoreTextFormatUpdatingResult*,
                int>)((*lpVtbl)[12])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_Result(
        [NativeTypeName("ABI::Windows::UI::Text::Core::CoreTextFormatUpdatingResult")]
            CoreTextFormatUpdatingResult value
    )
    {
        return (
            (delegate* unmanaged<
                ICoreTextFormatUpdatingEventArgs,
                CoreTextFormatUpdatingResult,
                int>)((*lpVtbl)[13])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_IsCanceled([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<ICoreTextFormatUpdatingEventArgs, byte*, int>)((*lpVtbl)[14]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetDeferral(
        [NativeTypeName("ABI::Windows::Foundation::IDeferral **")] IDeferral* value
    )
    {
        return (
            (delegate* unmanaged<ICoreTextFormatUpdatingEventArgs, IDeferral*, int>)((*lpVtbl)[15])
        )(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Range(
            [NativeTypeName("ABI::Windows::UI::Text::Core::CoreTextRange *")] CoreTextRange* value
        );

        [VtblIndex(7)]
        HRESULT get_TextColor(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CViewManagement__CUIElementType_t **"
            )]
                IReference<UIElementType>** value
        );

        [VtblIndex(8)]
        HRESULT get_BackgroundColor(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CViewManagement__CUIElementType_t **"
            )]
                IReference<UIElementType>** value
        );

        [VtblIndex(9)]
        HRESULT get_UnderlineColor(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CViewManagement__CUIElementType_t **"
            )]
                IReference<UIElementType>** value
        );

        [VtblIndex(10)]
        HRESULT get_UnderlineType(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CText__CUnderlineType_t **"
            )]
                IReference<UnderlineType>** value
        );

        [VtblIndex(11)]
        HRESULT get_Reason(
            [NativeTypeName("ABI::Windows::UI::Text::Core::CoreTextFormatUpdatingReason *")]
                CoreTextFormatUpdatingReason* value
        );

        [VtblIndex(12)]
        HRESULT get_Result(
            [NativeTypeName("ABI::Windows::UI::Text::Core::CoreTextFormatUpdatingResult *")]
                CoreTextFormatUpdatingResult* value
        );

        [VtblIndex(13)]
        HRESULT put_Result(
            [NativeTypeName("ABI::Windows::UI::Text::Core::CoreTextFormatUpdatingResult")]
                CoreTextFormatUpdatingResult value
        );

        [VtblIndex(14)]
        HRESULT get_IsCanceled([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(15)]
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

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Text::Core::CoreTextRange *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, CoreTextRange*, int> get_Range;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CViewManagement__CUIElementType_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<UIElementType>**, int> get_TextColor;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CViewManagement__CUIElementType_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<UIElementType>**, int> get_BackgroundColor;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CViewManagement__CUIElementType_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<UIElementType>**, int> get_UnderlineColor;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CText__CUnderlineType_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<UnderlineType>**, int> get_UnderlineType;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Text::Core::CoreTextFormatUpdatingReason *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, CoreTextFormatUpdatingReason*, int> get_Reason;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Text::Core::CoreTextFormatUpdatingResult *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, CoreTextFormatUpdatingResult*, int> get_Result;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Text::Core::CoreTextFormatUpdatingResult) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, CoreTextFormatUpdatingResult, int> put_Result;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsCanceled;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::IDeferral **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDeferral*, int> GetDeferral;
    }

    /// <summary>Initializes a new instance of the <see cref = "ICoreTextFormatUpdatingEventArgs"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ICoreTextFormatUpdatingEventArgs(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ICoreTextFormatUpdatingEventArgs"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ICoreTextFormatUpdatingEventArgs(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new ICoreTextFormatUpdatingEventArgs(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICoreTextFormatUpdatingEventArgs"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ICoreTextFormatUpdatingEventArgs"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        ICoreTextFormatUpdatingEventArgs value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ICoreTextFormatUpdatingEventArgs"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ICoreTextFormatUpdatingEventArgs(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new ICoreTextFormatUpdatingEventArgs(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICoreTextFormatUpdatingEventArgs"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ICoreTextFormatUpdatingEventArgs"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        ICoreTextFormatUpdatingEventArgs value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
