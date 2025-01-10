// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.ui.text.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("374E3515-BA8A-4A6E-8C59-0DDE3D0CF5CD")]
[NativeTypeName("struct IRichEditTextRange : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IRichEditTextRange : IRichEditTextRange.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IRichEditTextRange));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IRichEditTextRange, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IRichEditTextRange, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IRichEditTextRange, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IRichEditTextRange, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IRichEditTextRange, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IRichEditTextRange, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_ContentLinkInfo(
        [NativeTypeName("ABI::Windows::UI::Text::IContentLinkInfo **")] IContentLinkInfo* value
    )
    {
        return ((delegate* unmanaged<IRichEditTextRange, IContentLinkInfo*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_ContentLinkInfo(
        [NativeTypeName("ABI::Windows::UI::Text::IContentLinkInfo *")] IContentLinkInfo value
    )
    {
        return ((delegate* unmanaged<IRichEditTextRange, IContentLinkInfo, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_ContentLinkInfo(
            [NativeTypeName("ABI::Windows::UI::Text::IContentLinkInfo **")] IContentLinkInfo* value
        );

        [VtblIndex(7)]
        HRESULT put_ContentLinkInfo(
            [NativeTypeName("ABI::Windows::UI::Text::IContentLinkInfo *")] IContentLinkInfo value
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
            "HRESULT (ABI::Windows::UI::Text::IContentLinkInfo **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IContentLinkInfo*, int> get_ContentLinkInfo;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Text::IContentLinkInfo *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IContentLinkInfo, int> put_ContentLinkInfo;
    }

    /// <summary>Initializes a new instance of the <see cref = "IRichEditTextRange"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IRichEditTextRange(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IRichEditTextRange"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IRichEditTextRange(Silk.NET.WinRT.IInspectable value)
    {
        return new IRichEditTextRange(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IRichEditTextRange"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IRichEditTextRange"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IRichEditTextRange value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IRichEditTextRange"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IRichEditTextRange(Silk.NET.Windows.IUnknown value)
    {
        return new IRichEditTextRange(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IRichEditTextRange"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IRichEditTextRange"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IRichEditTextRange value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
