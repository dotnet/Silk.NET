// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.ui.composition.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("B440BF07-068F-4537-84C6-4ECBE019E1F4")]
[NativeTypeName("struct ICompositionViewBox : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICompositionViewBox : ICompositionViewBox.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICompositionViewBox));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ICompositionViewBox, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ICompositionViewBox, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICompositionViewBox, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<ICompositionViewBox, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<ICompositionViewBox, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<ICompositionViewBox, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_HorizontalAlignmentRatio(float* value)
    {
        return ((delegate* unmanaged<ICompositionViewBox, float*, int>)((*lpVtbl)[6]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_HorizontalAlignmentRatio(float value)
    {
        return ((delegate* unmanaged<ICompositionViewBox, float, int>)((*lpVtbl)[7]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Offset(
        [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2 *")] Vector2* value
    )
    {
        return ((delegate* unmanaged<ICompositionViewBox, Vector2*, int>)((*lpVtbl)[8]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_Offset(
        [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2")] Vector2 value
    )
    {
        return ((delegate* unmanaged<ICompositionViewBox, Vector2, int>)((*lpVtbl)[9]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Size(
        [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2 *")] Vector2* value
    )
    {
        return ((delegate* unmanaged<ICompositionViewBox, Vector2*, int>)((*lpVtbl)[10]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_Size(
        [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2")] Vector2 value
    )
    {
        return ((delegate* unmanaged<ICompositionViewBox, Vector2, int>)((*lpVtbl)[11]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_Stretch(
        [NativeTypeName("ABI::Windows::UI::Composition::CompositionStretch *")]
            CompositionStretch* value
    )
    {
        return (
            (delegate* unmanaged<ICompositionViewBox, CompositionStretch*, int>)((*lpVtbl)[12])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_Stretch(
        [NativeTypeName("ABI::Windows::UI::Composition::CompositionStretch")]
            CompositionStretch value
    )
    {
        return ((delegate* unmanaged<ICompositionViewBox, CompositionStretch, int>)((*lpVtbl)[13]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_VerticalAlignmentRatio(float* value)
    {
        return ((delegate* unmanaged<ICompositionViewBox, float*, int>)((*lpVtbl)[14]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_VerticalAlignmentRatio(float value)
    {
        return ((delegate* unmanaged<ICompositionViewBox, float, int>)((*lpVtbl)[15]))(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_HorizontalAlignmentRatio(float* value);

        [VtblIndex(7)]
        HRESULT put_HorizontalAlignmentRatio(float value);

        [VtblIndex(8)]
        HRESULT get_Offset(
            [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2 *")] Vector2* value
        );

        [VtblIndex(9)]
        HRESULT put_Offset(
            [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2")] Vector2 value
        );

        [VtblIndex(10)]
        HRESULT get_Size(
            [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2 *")] Vector2* value
        );

        [VtblIndex(11)]
        HRESULT put_Size(
            [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2")] Vector2 value
        );

        [VtblIndex(12)]
        HRESULT get_Stretch(
            [NativeTypeName("ABI::Windows::UI::Composition::CompositionStretch *")]
                CompositionStretch* value
        );

        [VtblIndex(13)]
        HRESULT put_Stretch(
            [NativeTypeName("ABI::Windows::UI::Composition::CompositionStretch")]
                CompositionStretch value
        );

        [VtblIndex(14)]
        HRESULT get_VerticalAlignmentRatio(float* value);

        [VtblIndex(15)]
        HRESULT put_VerticalAlignmentRatio(float value);
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

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> get_HorizontalAlignmentRatio;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> put_HorizontalAlignmentRatio;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Numerics::Vector2 *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Vector2*, int> get_Offset;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Numerics::Vector2) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Vector2, int> put_Offset;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Numerics::Vector2 *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Vector2*, int> get_Size;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Numerics::Vector2) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Vector2, int> put_Size;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Composition::CompositionStretch *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, CompositionStretch*, int> get_Stretch;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Composition::CompositionStretch) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, CompositionStretch, int> put_Stretch;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> get_VerticalAlignmentRatio;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> put_VerticalAlignmentRatio;
    }

    /// <summary>Initializes a new instance of the <see cref = "ICompositionViewBox"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ICompositionViewBox(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ICompositionViewBox"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ICompositionViewBox(Silk.NET.WinRT.IInspectable value)
    {
        return new ICompositionViewBox(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICompositionViewBox"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ICompositionViewBox"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(ICompositionViewBox value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ICompositionViewBox"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ICompositionViewBox(Silk.NET.Windows.IUnknown value)
    {
        return new ICompositionViewBox(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICompositionViewBox"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ICompositionViewBox"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ICompositionViewBox value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
