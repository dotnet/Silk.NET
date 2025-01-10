// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.ui.input.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("4D5FE14F-B87C-4028-BC9C-59E9947FB056")]
[NativeTypeName("struct IPointerPointTransform : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPointerPointTransform : IPointerPointTransform.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPointerPointTransform));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IPointerPointTransform, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IPointerPointTransform, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPointerPointTransform, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IPointerPointTransform, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IPointerPointTransform, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IPointerPointTransform, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Inverse(
        [NativeTypeName("ABI::Windows::UI::Input::IPointerPointTransform **")]
            IPointerPointTransform* value
    )
    {
        return (
            (delegate* unmanaged<IPointerPointTransform, IPointerPointTransform*, int>)(
                (*lpVtbl)[6]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT TryTransform(
        [NativeTypeName("ABI::Windows::Foundation::Point")] Point inPoint,
        [NativeTypeName("ABI::Windows::Foundation::Point *")] Point* outPoint,
        [NativeTypeName("boolean *")] byte* returnValue
    )
    {
        return (
            (delegate* unmanaged<IPointerPointTransform, Point, Point*, byte*, int>)((*lpVtbl)[7])
        )(this, inPoint, outPoint, returnValue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT TransformBounds(
        [NativeTypeName("ABI::Windows::Foundation::Rect")] Rect rect,
        [NativeTypeName("ABI::Windows::Foundation::Rect *")] Rect* returnValue
    )
    {
        return ((delegate* unmanaged<IPointerPointTransform, Rect, Rect*, int>)((*lpVtbl)[8]))(
            this,
            rect,
            returnValue
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Inverse(
            [NativeTypeName("ABI::Windows::UI::Input::IPointerPointTransform **")]
                IPointerPointTransform* value
        );

        [VtblIndex(7)]
        HRESULT TryTransform(
            [NativeTypeName("ABI::Windows::Foundation::Point")] Point inPoint,
            [NativeTypeName("ABI::Windows::Foundation::Point *")] Point* outPoint,
            [NativeTypeName("boolean *")] byte* returnValue
        );

        [VtblIndex(8)]
        HRESULT TransformBounds(
            [NativeTypeName("ABI::Windows::Foundation::Rect")] Rect rect,
            [NativeTypeName("ABI::Windows::Foundation::Rect *")] Rect* returnValue
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
            "HRESULT (ABI::Windows::UI::Input::IPointerPointTransform **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IPointerPointTransform*, int> get_Inverse;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Point, ABI::Windows::Foundation::Point *, boolean *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Point, Point*, byte*, int> TryTransform;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Rect, ABI::Windows::Foundation::Rect *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Rect, Rect*, int> TransformBounds;
    }

    /// <summary>Initializes a new instance of the <see cref = "IPointerPointTransform"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IPointerPointTransform(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IPointerPointTransform"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IPointerPointTransform(Silk.NET.WinRT.IInspectable value)
    {
        return new IPointerPointTransform(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPointerPointTransform"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IPointerPointTransform"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IPointerPointTransform value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IPointerPointTransform"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IPointerPointTransform(Silk.NET.Windows.IUnknown value)
    {
        return new IPointerPointTransform(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPointerPointTransform"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IPointerPointTransform"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IPointerPointTransform value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
