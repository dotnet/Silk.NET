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

[Guid("F33D2F43-2749-4CDE-B977-C0C41E7415D1")]
[NativeTypeName("struct IProjectionManagerStatics2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IProjectionManagerStatics2
    : IProjectionManagerStatics2.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IProjectionManagerStatics2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IProjectionManagerStatics2, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IProjectionManagerStatics2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IProjectionManagerStatics2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IProjectionManagerStatics2, uint*, Guid**, int>)((*lpVtbl)[3])
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IProjectionManagerStatics2, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IProjectionManagerStatics2, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT StartProjectingWithDeviceInfoAsync(
        [NativeTypeName("INT32")] int projectionViewId,
        [NativeTypeName("INT32")] int anchorViewId,
        [NativeTypeName("ABI::Windows::Devices::Enumeration::IDeviceInformation *")]
            IDeviceInformation displayDeviceInfo,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* operation
    )
    {
        return (
            (delegate* unmanaged<
                IProjectionManagerStatics2,
                int,
                int,
                IDeviceInformation,
                IAsyncAction*,
                int>)((*lpVtbl)[6])
        )(this, projectionViewId, anchorViewId, displayDeviceInfo, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT RequestStartProjectingAsync(
        [NativeTypeName("INT32")] int projectionViewId,
        [NativeTypeName("INT32")] int anchorViewId,
        [NativeTypeName("ABI::Windows::Foundation::Rect")] Rect selection,
        [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")]
            IAsyncOperation<byte>** operation
    )
    {
        return (
            (delegate* unmanaged<
                IProjectionManagerStatics2,
                int,
                int,
                Rect,
                IAsyncOperation<byte>**,
                int>)((*lpVtbl)[7])
        )(this, projectionViewId, anchorViewId, selection, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT RequestStartProjectingWithPlacementAsync(
        [NativeTypeName("INT32")] int projectionViewId,
        [NativeTypeName("INT32")] int anchorViewId,
        [NativeTypeName("ABI::Windows::Foundation::Rect")] Rect selection,
        [NativeTypeName("ABI::Windows::UI::Popups::Placement")] Placement prefferedPlacement,
        [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")]
            IAsyncOperation<byte>** operation
    )
    {
        return (
            (delegate* unmanaged<
                IProjectionManagerStatics2,
                int,
                int,
                Rect,
                Placement,
                IAsyncOperation<byte>**,
                int>)((*lpVtbl)[8])
        )(this, projectionViewId, anchorViewId, selection, prefferedPlacement, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetDeviceSelector(HSTRING* selector)
    {
        return ((delegate* unmanaged<IProjectionManagerStatics2, HSTRING*, int>)((*lpVtbl)[9]))(
            this,
            selector
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT StartProjectingWithDeviceInfoAsync(
            [NativeTypeName("INT32")] int projectionViewId,
            [NativeTypeName("INT32")] int anchorViewId,
            [NativeTypeName("ABI::Windows::Devices::Enumeration::IDeviceInformation *")]
                IDeviceInformation displayDeviceInfo,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* operation
        );

        [VtblIndex(7)]
        HRESULT RequestStartProjectingAsync(
            [NativeTypeName("INT32")] int projectionViewId,
            [NativeTypeName("INT32")] int anchorViewId,
            [NativeTypeName("ABI::Windows::Foundation::Rect")] Rect selection,
            [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")]
                IAsyncOperation<byte>** operation
        );

        [VtblIndex(8)]
        HRESULT RequestStartProjectingWithPlacementAsync(
            [NativeTypeName("INT32")] int projectionViewId,
            [NativeTypeName("INT32")] int anchorViewId,
            [NativeTypeName("ABI::Windows::Foundation::Rect")] Rect selection,
            [NativeTypeName("ABI::Windows::UI::Popups::Placement")] Placement prefferedPlacement,
            [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")]
                IAsyncOperation<byte>** operation
        );

        [VtblIndex(9)]
        HRESULT GetDeviceSelector(HSTRING* selector);
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
            "HRESULT (INT32, INT32, ABI::Windows::Devices::Enumeration::IDeviceInformation *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            int,
            int,
            IDeviceInformation,
            IAsyncAction*,
            int> StartProjectingWithDeviceInfoAsync;

        [NativeTypeName(
            "HRESULT (INT32, INT32, ABI::Windows::Foundation::Rect, ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            int,
            int,
            Rect,
            IAsyncOperation<byte>**,
            int> RequestStartProjectingAsync;

        [NativeTypeName(
            "HRESULT (INT32, INT32, ABI::Windows::Foundation::Rect, ABI::Windows::UI::Popups::Placement, ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            int,
            int,
            Rect,
            Placement,
            IAsyncOperation<byte>**,
            int> RequestStartProjectingWithPlacementAsync;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> GetDeviceSelector;
    }

    /// <summary>Initializes a new instance of the <see cref = "IProjectionManagerStatics2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IProjectionManagerStatics2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IProjectionManagerStatics2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IProjectionManagerStatics2(Silk.NET.WinRT.IInspectable value)
    {
        return new IProjectionManagerStatics2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IProjectionManagerStatics2"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IProjectionManagerStatics2"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IProjectionManagerStatics2 value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IProjectionManagerStatics2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IProjectionManagerStatics2(Silk.NET.Windows.IUnknown value)
    {
        return new IProjectionManagerStatics2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IProjectionManagerStatics2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IProjectionManagerStatics2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IProjectionManagerStatics2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
