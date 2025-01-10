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

[Guid("EEA7918D-CC2B-4F03-8FF6-02FD217DB450")]
[NativeTypeName("struct ICoreTextTextUpdatingEventArgs : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICoreTextTextUpdatingEventArgs
    : ICoreTextTextUpdatingEventArgs.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICoreTextTextUpdatingEventArgs));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<ICoreTextTextUpdatingEventArgs, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ICoreTextTextUpdatingEventArgs, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICoreTextTextUpdatingEventArgs, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<ICoreTextTextUpdatingEventArgs, uint*, Guid**, int>)((*lpVtbl)[3])
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<ICoreTextTextUpdatingEventArgs, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<ICoreTextTextUpdatingEventArgs, TrustLevel*, int>)((*lpVtbl)[5])
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Range(
        [NativeTypeName("ABI::Windows::UI::Text::Core::CoreTextRange *")] CoreTextRange* value
    )
    {
        return (
            (delegate* unmanaged<ICoreTextTextUpdatingEventArgs, CoreTextRange*, int>)((*lpVtbl)[6])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Text(HSTRING* value)
    {
        return ((delegate* unmanaged<ICoreTextTextUpdatingEventArgs, HSTRING*, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_NewSelection(
        [NativeTypeName("ABI::Windows::UI::Text::Core::CoreTextRange *")] CoreTextRange* value
    )
    {
        return (
            (delegate* unmanaged<ICoreTextTextUpdatingEventArgs, CoreTextRange*, int>)((*lpVtbl)[8])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_InputLanguage(
        [NativeTypeName("ABI::Windows::Globalization::ILanguage **")] ILanguage* value
    )
    {
        return (
            (delegate* unmanaged<ICoreTextTextUpdatingEventArgs, ILanguage*, int>)((*lpVtbl)[9])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Result(
        [NativeTypeName("ABI::Windows::UI::Text::Core::CoreTextTextUpdatingResult *")]
            CoreTextTextUpdatingResult* value
    )
    {
        return (
            (delegate* unmanaged<ICoreTextTextUpdatingEventArgs, CoreTextTextUpdatingResult*, int>)(
                (*lpVtbl)[10]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_Result(
        [NativeTypeName("ABI::Windows::UI::Text::Core::CoreTextTextUpdatingResult")]
            CoreTextTextUpdatingResult value
    )
    {
        return (
            (delegate* unmanaged<ICoreTextTextUpdatingEventArgs, CoreTextTextUpdatingResult, int>)(
                (*lpVtbl)[11]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_IsCanceled([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<ICoreTextTextUpdatingEventArgs, byte*, int>)((*lpVtbl)[12]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetDeferral(
        [NativeTypeName("ABI::Windows::Foundation::IDeferral **")] IDeferral* value
    )
    {
        return (
            (delegate* unmanaged<ICoreTextTextUpdatingEventArgs, IDeferral*, int>)((*lpVtbl)[13])
        )(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Range(
            [NativeTypeName("ABI::Windows::UI::Text::Core::CoreTextRange *")] CoreTextRange* value
        );

        [VtblIndex(7)]
        HRESULT get_Text(HSTRING* value);

        [VtblIndex(8)]
        HRESULT get_NewSelection(
            [NativeTypeName("ABI::Windows::UI::Text::Core::CoreTextRange *")] CoreTextRange* value
        );

        [VtblIndex(9)]
        HRESULT get_InputLanguage(
            [NativeTypeName("ABI::Windows::Globalization::ILanguage **")] ILanguage* value
        );

        [VtblIndex(10)]
        HRESULT get_Result(
            [NativeTypeName("ABI::Windows::UI::Text::Core::CoreTextTextUpdatingResult *")]
                CoreTextTextUpdatingResult* value
        );

        [VtblIndex(11)]
        HRESULT put_Result(
            [NativeTypeName("ABI::Windows::UI::Text::Core::CoreTextTextUpdatingResult")]
                CoreTextTextUpdatingResult value
        );

        [VtblIndex(12)]
        HRESULT get_IsCanceled([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(13)]
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

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Text;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Text::Core::CoreTextRange *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, CoreTextRange*, int> get_NewSelection;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Globalization::ILanguage **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ILanguage*, int> get_InputLanguage;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Text::Core::CoreTextTextUpdatingResult *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, CoreTextTextUpdatingResult*, int> get_Result;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Text::Core::CoreTextTextUpdatingResult) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, CoreTextTextUpdatingResult, int> put_Result;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsCanceled;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::IDeferral **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDeferral*, int> GetDeferral;
    }

    /// <summary>Initializes a new instance of the <see cref = "ICoreTextTextUpdatingEventArgs"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ICoreTextTextUpdatingEventArgs(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ICoreTextTextUpdatingEventArgs"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ICoreTextTextUpdatingEventArgs(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new ICoreTextTextUpdatingEventArgs(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICoreTextTextUpdatingEventArgs"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ICoreTextTextUpdatingEventArgs"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        ICoreTextTextUpdatingEventArgs value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ICoreTextTextUpdatingEventArgs"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ICoreTextTextUpdatingEventArgs(Silk.NET.Windows.IUnknown value)
    {
        return new ICoreTextTextUpdatingEventArgs(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICoreTextTextUpdatingEventArgs"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ICoreTextTextUpdatingEventArgs"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ICoreTextTextUpdatingEventArgs value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
