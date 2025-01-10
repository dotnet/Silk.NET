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

[Guid("A506638D-2A1A-413E-BC75-9F38381CC069")]
[NativeTypeName("struct IPointerPointStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPointerPointStatics : IPointerPointStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPointerPointStatics));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IPointerPointStatics, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IPointerPointStatics, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPointerPointStatics, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IPointerPointStatics, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IPointerPointStatics, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IPointerPointStatics, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetCurrentPoint(
        [NativeTypeName("UINT32")] uint pointerId,
        [NativeTypeName("ABI::Windows::UI::Input::IPointerPoint **")] IPointerPoint* pointerPoint
    )
    {
        return (
            (delegate* unmanaged<IPointerPointStatics, uint, IPointerPoint*, int>)((*lpVtbl)[6])
        )(this, pointerId, pointerPoint);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetIntermediatePoints(
        [NativeTypeName("UINT32")] uint pointerId,
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CUI__CInput__CPointerPoint_t **"
        )]
            IVector<IntPtr>** pointerPoints
    )
    {
        return (
            (delegate* unmanaged<IPointerPointStatics, uint, IVector<IntPtr>**, int>)((*lpVtbl)[7])
        )(this, pointerId, pointerPoints);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetCurrentPointTransformed(
        [NativeTypeName("UINT32")] uint pointerId,
        [NativeTypeName("ABI::Windows::UI::Input::IPointerPointTransform *")]
            IPointerPointTransform transform,
        [NativeTypeName("ABI::Windows::UI::Input::IPointerPoint **")] IPointerPoint* pointerPoint
    )
    {
        return (
            (delegate* unmanaged<
                IPointerPointStatics,
                uint,
                IPointerPointTransform,
                IPointerPoint*,
                int>)((*lpVtbl)[8])
        )(this, pointerId, transform, pointerPoint);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetIntermediatePointsTransformed(
        [NativeTypeName("UINT32")] uint pointerId,
        [NativeTypeName("ABI::Windows::UI::Input::IPointerPointTransform *")]
            IPointerPointTransform transform,
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CUI__CInput__CPointerPoint_t **"
        )]
            IVector<IntPtr>** pointerPoints
    )
    {
        return (
            (delegate* unmanaged<
                IPointerPointStatics,
                uint,
                IPointerPointTransform,
                IVector<IntPtr>**,
                int>)((*lpVtbl)[9])
        )(this, pointerId, transform, pointerPoints);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetCurrentPoint(
            [NativeTypeName("UINT32")] uint pointerId,
            [NativeTypeName("ABI::Windows::UI::Input::IPointerPoint **")]
                IPointerPoint* pointerPoint
        );

        [VtblIndex(7)]
        HRESULT GetIntermediatePoints(
            [NativeTypeName("UINT32")] uint pointerId,
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CUI__CInput__CPointerPoint_t **"
            )]
                IVector<IntPtr>** pointerPoints
        );

        [VtblIndex(8)]
        HRESULT GetCurrentPointTransformed(
            [NativeTypeName("UINT32")] uint pointerId,
            [NativeTypeName("ABI::Windows::UI::Input::IPointerPointTransform *")]
                IPointerPointTransform transform,
            [NativeTypeName("ABI::Windows::UI::Input::IPointerPoint **")]
                IPointerPoint* pointerPoint
        );

        [VtblIndex(9)]
        HRESULT GetIntermediatePointsTransformed(
            [NativeTypeName("UINT32")] uint pointerId,
            [NativeTypeName("ABI::Windows::UI::Input::IPointerPointTransform *")]
                IPointerPointTransform transform,
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CUI__CInput__CPointerPoint_t **"
            )]
                IVector<IntPtr>** pointerPoints
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
            "HRESULT (UINT32, ABI::Windows::UI::Input::IPointerPoint **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, IPointerPoint*, int> GetCurrentPoint;

        [NativeTypeName(
            "HRESULT (UINT32, ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CUI__CInput__CPointerPoint_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, IVector<IntPtr>**, int> GetIntermediatePoints;

        [NativeTypeName(
            "HRESULT (UINT32, ABI::Windows::UI::Input::IPointerPointTransform *, ABI::Windows::UI::Input::IPointerPoint **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            IPointerPointTransform,
            IPointerPoint*,
            int> GetCurrentPointTransformed;

        [NativeTypeName(
            "HRESULT (UINT32, ABI::Windows::UI::Input::IPointerPointTransform *, ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CUI__CInput__CPointerPoint_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            IPointerPointTransform,
            IVector<IntPtr>**,
            int> GetIntermediatePointsTransformed;
    }

    /// <summary>Initializes a new instance of the <see cref = "IPointerPointStatics"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IPointerPointStatics(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IPointerPointStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IPointerPointStatics(Silk.NET.WinRT.IInspectable value)
    {
        return new IPointerPointStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPointerPointStatics"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IPointerPointStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IPointerPointStatics value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IPointerPointStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IPointerPointStatics(Silk.NET.Windows.IUnknown value)
    {
        return new IPointerPointStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPointerPointStatics"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IPointerPointStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IPointerPointStatics value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
