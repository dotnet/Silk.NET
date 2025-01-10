// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.ui.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("6F5E63C7-E3AA-4EAE-B0E0-DCF321CA4B2F")]
[NativeTypeName("struct ICoreDispatcher2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICoreDispatcher2 : ICoreDispatcher2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICoreDispatcher2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ICoreDispatcher2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ICoreDispatcher2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICoreDispatcher2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<ICoreDispatcher2, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<ICoreDispatcher2, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<ICoreDispatcher2, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT TryRunAsync(
        [NativeTypeName("ABI::Windows::UI::Core::CoreDispatcherPriority")]
            CoreDispatcherPriority priority,
        [NativeTypeName("ABI::Windows::UI::Core::IDispatchedHandler *")]
            IDispatchedHandler agileCallback,
        [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")]
            IAsyncOperation<byte>** asyncOperation
    )
    {
        return (
            (delegate* unmanaged<
                ICoreDispatcher2,
                CoreDispatcherPriority,
                IDispatchedHandler,
                IAsyncOperation<byte>**,
                int>)((*lpVtbl)[6])
        )(this, priority, agileCallback, asyncOperation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT TryRunIdleAsync(
        [NativeTypeName("ABI::Windows::UI::Core::IIdleDispatchedHandler *")]
            IIdleDispatchedHandler agileCallback,
        [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")]
            IAsyncOperation<byte>** asyncOperation
    )
    {
        return (
            (delegate* unmanaged<
                ICoreDispatcher2,
                IIdleDispatchedHandler,
                IAsyncOperation<byte>**,
                int>)((*lpVtbl)[7])
        )(this, agileCallback, asyncOperation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT TryRunAsync(
            [NativeTypeName("ABI::Windows::UI::Core::CoreDispatcherPriority")]
                CoreDispatcherPriority priority,
            [NativeTypeName("ABI::Windows::UI::Core::IDispatchedHandler *")]
                IDispatchedHandler agileCallback,
            [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")]
                IAsyncOperation<byte>** asyncOperation
        );

        [VtblIndex(7)]
        HRESULT TryRunIdleAsync(
            [NativeTypeName("ABI::Windows::UI::Core::IIdleDispatchedHandler *")]
                IIdleDispatchedHandler agileCallback,
            [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")]
                IAsyncOperation<byte>** asyncOperation
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
            "HRESULT (ABI::Windows::UI::Core::CoreDispatcherPriority, ABI::Windows::UI::Core::IDispatchedHandler *, ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            CoreDispatcherPriority,
            IDispatchedHandler,
            IAsyncOperation<byte>**,
            int> TryRunAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Core::IIdleDispatchedHandler *, ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IIdleDispatchedHandler,
            IAsyncOperation<byte>**,
            int> TryRunIdleAsync;
    }

    /// <summary>Initializes a new instance of the <see cref = "ICoreDispatcher2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ICoreDispatcher2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ICoreDispatcher2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ICoreDispatcher2(Silk.NET.WinRT.IInspectable value)
    {
        return new ICoreDispatcher2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICoreDispatcher2"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ICoreDispatcher2"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(ICoreDispatcher2 value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ICoreDispatcher2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ICoreDispatcher2(Silk.NET.Windows.IUnknown value)
    {
        return new ICoreDispatcher2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICoreDispatcher2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ICoreDispatcher2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ICoreDispatcher2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
