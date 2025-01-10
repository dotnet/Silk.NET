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

[Guid("A2E6330E-8A60-5A38-BB85-B44EA901677C")]
[NativeTypeName("struct ICompositorWithProjectedShadow : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICompositorWithProjectedShadow
    : ICompositorWithProjectedShadow.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICompositorWithProjectedShadow));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<ICompositorWithProjectedShadow, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ICompositorWithProjectedShadow, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICompositorWithProjectedShadow, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<ICompositorWithProjectedShadow, uint*, Guid**, int>)((*lpVtbl)[3])
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<ICompositorWithProjectedShadow, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<ICompositorWithProjectedShadow, TrustLevel*, int>)((*lpVtbl)[5])
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateProjectedShadowCaster(
        [NativeTypeName("ABI::Windows::UI::Composition::ICompositionProjectedShadowCaster **")]
            ICompositionProjectedShadowCaster* result
    )
    {
        return (
            (delegate* unmanaged<
                ICompositorWithProjectedShadow,
                ICompositionProjectedShadowCaster*,
                int>)((*lpVtbl)[6])
        )(this, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateProjectedShadow(
        [NativeTypeName("ABI::Windows::UI::Composition::ICompositionProjectedShadow **")]
            ICompositionProjectedShadow* result
    )
    {
        return (
            (delegate* unmanaged<
                ICompositorWithProjectedShadow,
                ICompositionProjectedShadow*,
                int>)((*lpVtbl)[7])
        )(this, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateProjectedShadowReceiver(
        [NativeTypeName("ABI::Windows::UI::Composition::ICompositionProjectedShadowReceiver **")]
            ICompositionProjectedShadowReceiver* result
    )
    {
        return (
            (delegate* unmanaged<
                ICompositorWithProjectedShadow,
                ICompositionProjectedShadowReceiver*,
                int>)((*lpVtbl)[8])
        )(this, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateProjectedShadowCaster(
            [NativeTypeName("ABI::Windows::UI::Composition::ICompositionProjectedShadowCaster **")]
                ICompositionProjectedShadowCaster* result
        );

        [VtblIndex(7)]
        HRESULT CreateProjectedShadow(
            [NativeTypeName("ABI::Windows::UI::Composition::ICompositionProjectedShadow **")]
                ICompositionProjectedShadow* result
        );

        [VtblIndex(8)]
        HRESULT CreateProjectedShadowReceiver(
            [NativeTypeName(
                "ABI::Windows::UI::Composition::ICompositionProjectedShadowReceiver **"
            )]
                ICompositionProjectedShadowReceiver* result
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
            "HRESULT (ABI::Windows::UI::Composition::ICompositionProjectedShadowCaster **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ICompositionProjectedShadowCaster*,
            int> CreateProjectedShadowCaster;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Composition::ICompositionProjectedShadow **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ICompositionProjectedShadow*, int> CreateProjectedShadow;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Composition::ICompositionProjectedShadowReceiver **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ICompositionProjectedShadowReceiver*,
            int> CreateProjectedShadowReceiver;
    }

    /// <summary>Initializes a new instance of the <see cref = "ICompositorWithProjectedShadow"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ICompositorWithProjectedShadow(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ICompositorWithProjectedShadow"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ICompositorWithProjectedShadow(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new ICompositorWithProjectedShadow(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICompositorWithProjectedShadow"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ICompositorWithProjectedShadow"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        ICompositorWithProjectedShadow value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ICompositorWithProjectedShadow"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ICompositorWithProjectedShadow(Silk.NET.Windows.IUnknown value)
    {
        return new ICompositorWithProjectedShadow(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICompositorWithProjectedShadow"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ICompositorWithProjectedShadow"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ICompositorWithProjectedShadow value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
