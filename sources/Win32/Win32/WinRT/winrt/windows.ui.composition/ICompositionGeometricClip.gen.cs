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

[Guid("C840B581-81C9-4444-A2C1-CCAECE3A50E5")]
[NativeTypeName("struct ICompositionGeometricClip : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICompositionGeometricClip
    : ICompositionGeometricClip.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICompositionGeometricClip));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ICompositionGeometricClip, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ICompositionGeometricClip, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICompositionGeometricClip, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<ICompositionGeometricClip, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<ICompositionGeometricClip, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<ICompositionGeometricClip, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Geometry(
        [NativeTypeName("ABI::Windows::UI::Composition::ICompositionGeometry **")]
            ICompositionGeometry* value
    )
    {
        return (
            (delegate* unmanaged<ICompositionGeometricClip, ICompositionGeometry*, int>)(
                (*lpVtbl)[6]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Geometry(
        [NativeTypeName("ABI::Windows::UI::Composition::ICompositionGeometry *")]
            ICompositionGeometry value
    )
    {
        return (
            (delegate* unmanaged<ICompositionGeometricClip, ICompositionGeometry, int>)(
                (*lpVtbl)[7]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_ViewBox(
        [NativeTypeName("ABI::Windows::UI::Composition::ICompositionViewBox **")]
            ICompositionViewBox* value
    )
    {
        return (
            (delegate* unmanaged<ICompositionGeometricClip, ICompositionViewBox*, int>)(
                (*lpVtbl)[8]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_ViewBox(
        [NativeTypeName("ABI::Windows::UI::Composition::ICompositionViewBox *")]
            ICompositionViewBox value
    )
    {
        return (
            (delegate* unmanaged<ICompositionGeometricClip, ICompositionViewBox, int>)((*lpVtbl)[9])
        )(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Geometry(
            [NativeTypeName("ABI::Windows::UI::Composition::ICompositionGeometry **")]
                ICompositionGeometry* value
        );

        [VtblIndex(7)]
        HRESULT put_Geometry(
            [NativeTypeName("ABI::Windows::UI::Composition::ICompositionGeometry *")]
                ICompositionGeometry value
        );

        [VtblIndex(8)]
        HRESULT get_ViewBox(
            [NativeTypeName("ABI::Windows::UI::Composition::ICompositionViewBox **")]
                ICompositionViewBox* value
        );

        [VtblIndex(9)]
        HRESULT put_ViewBox(
            [NativeTypeName("ABI::Windows::UI::Composition::ICompositionViewBox *")]
                ICompositionViewBox value
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
            "HRESULT (ABI::Windows::UI::Composition::ICompositionGeometry **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ICompositionGeometry*, int> get_Geometry;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Composition::ICompositionGeometry *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ICompositionGeometry, int> put_Geometry;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Composition::ICompositionViewBox **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ICompositionViewBox*, int> get_ViewBox;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Composition::ICompositionViewBox *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ICompositionViewBox, int> put_ViewBox;
    }

    /// <summary>Initializes a new instance of the <see cref = "ICompositionGeometricClip"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ICompositionGeometricClip(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ICompositionGeometricClip"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ICompositionGeometricClip(Silk.NET.WinRT.IInspectable value)
    {
        return new ICompositionGeometricClip(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICompositionGeometricClip"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ICompositionGeometricClip"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(ICompositionGeometricClip value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ICompositionGeometricClip"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ICompositionGeometricClip(Silk.NET.Windows.IUnknown value)
    {
        return new ICompositionGeometricClip(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICompositionGeometricClip"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ICompositionGeometricClip"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ICompositionGeometricClip value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
