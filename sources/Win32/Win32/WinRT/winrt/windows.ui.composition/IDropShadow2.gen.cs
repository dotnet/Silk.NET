// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.ui.composition.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("6C4218BC-15B9-4C2D-8D4A-0767DF11977A")]
[NativeTypeName("struct IDropShadow2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IDropShadow2 : IDropShadow2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDropShadow2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDropShadow2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDropShadow2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDropShadow2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IDropShadow2, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IDropShadow2, HSTRING*, int>)((*lpVtbl)[4]))(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IDropShadow2, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_SourcePolicy(
        [NativeTypeName("ABI::Windows::UI::Composition::CompositionDropShadowSourcePolicy *")]
            CompositionDropShadowSourcePolicy* value
    )
    {
        return (
            (delegate* unmanaged<IDropShadow2, CompositionDropShadowSourcePolicy*, int>)(
                (*lpVtbl)[6]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_SourcePolicy(
        [NativeTypeName("ABI::Windows::UI::Composition::CompositionDropShadowSourcePolicy")]
            CompositionDropShadowSourcePolicy value
    )
    {
        return (
            (delegate* unmanaged<IDropShadow2, CompositionDropShadowSourcePolicy, int>)(
                (*lpVtbl)[7]
            )
        )(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_SourcePolicy(
            [NativeTypeName("ABI::Windows::UI::Composition::CompositionDropShadowSourcePolicy *")]
                CompositionDropShadowSourcePolicy* value
        );

        [VtblIndex(7)]
        HRESULT put_SourcePolicy(
            [NativeTypeName("ABI::Windows::UI::Composition::CompositionDropShadowSourcePolicy")]
                CompositionDropShadowSourcePolicy value
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
            "HRESULT (ABI::Windows::UI::Composition::CompositionDropShadowSourcePolicy *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            CompositionDropShadowSourcePolicy*,
            int> get_SourcePolicy;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Composition::CompositionDropShadowSourcePolicy) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, CompositionDropShadowSourcePolicy, int> put_SourcePolicy;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDropShadow2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDropShadow2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IDropShadow2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IDropShadow2(Silk.NET.WinRT.IInspectable value)
    {
        return new IDropShadow2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDropShadow2"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IDropShadow2"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IDropShadow2 value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDropShadow2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDropShadow2(Silk.NET.Windows.IUnknown value)
    {
        return new IDropShadow2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDropShadow2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDropShadow2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDropShadow2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
