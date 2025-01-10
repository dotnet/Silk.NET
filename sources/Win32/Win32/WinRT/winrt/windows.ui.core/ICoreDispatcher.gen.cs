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

[Guid("60DB2FA8-B705-4FDE-A7D6-EBBB1891D39E")]
[NativeTypeName("struct ICoreDispatcher : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICoreDispatcher : ICoreDispatcher.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICoreDispatcher));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ICoreDispatcher, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ICoreDispatcher, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICoreDispatcher, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<ICoreDispatcher, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<ICoreDispatcher, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<ICoreDispatcher, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_HasThreadAccess([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<ICoreDispatcher, byte*, int>)((*lpVtbl)[6]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT ProcessEvents(
        [NativeTypeName("ABI::Windows::UI::Core::CoreProcessEventsOption")]
            CoreProcessEventsOption options
    )
    {
        return ((delegate* unmanaged<ICoreDispatcher, CoreProcessEventsOption, int>)((*lpVtbl)[7]))(
            this,
            options
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT RunAsync(
        [NativeTypeName("ABI::Windows::UI::Core::CoreDispatcherPriority")]
            CoreDispatcherPriority priority,
        [NativeTypeName("ABI::Windows::UI::Core::IDispatchedHandler *")]
            IDispatchedHandler agileCallback,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* asyncAction
    )
    {
        return (
            (delegate* unmanaged<
                ICoreDispatcher,
                CoreDispatcherPriority,
                IDispatchedHandler,
                IAsyncAction*,
                int>)((*lpVtbl)[8])
        )(this, priority, agileCallback, asyncAction);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT RunIdleAsync(
        [NativeTypeName("ABI::Windows::UI::Core::IIdleDispatchedHandler *")]
            IIdleDispatchedHandler agileCallback,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* asyncAction
    )
    {
        return (
            (delegate* unmanaged<ICoreDispatcher, IIdleDispatchedHandler, IAsyncAction*, int>)(
                (*lpVtbl)[9]
            )
        )(this, agileCallback, asyncAction);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_HasThreadAccess([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(7)]
        HRESULT ProcessEvents(
            [NativeTypeName("ABI::Windows::UI::Core::CoreProcessEventsOption")]
                CoreProcessEventsOption options
        );

        [VtblIndex(8)]
        HRESULT RunAsync(
            [NativeTypeName("ABI::Windows::UI::Core::CoreDispatcherPriority")]
                CoreDispatcherPriority priority,
            [NativeTypeName("ABI::Windows::UI::Core::IDispatchedHandler *")]
                IDispatchedHandler agileCallback,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* asyncAction
        );

        [VtblIndex(9)]
        HRESULT RunIdleAsync(
            [NativeTypeName("ABI::Windows::UI::Core::IIdleDispatchedHandler *")]
                IIdleDispatchedHandler agileCallback,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* asyncAction
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

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_HasThreadAccess;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Core::CoreProcessEventsOption) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, CoreProcessEventsOption, int> ProcessEvents;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Core::CoreDispatcherPriority, ABI::Windows::UI::Core::IDispatchedHandler *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            CoreDispatcherPriority,
            IDispatchedHandler,
            IAsyncAction*,
            int> RunAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Core::IIdleDispatchedHandler *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IIdleDispatchedHandler, IAsyncAction*, int> RunIdleAsync;
    }

    /// <summary>Initializes a new instance of the <see cref = "ICoreDispatcher"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ICoreDispatcher(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ICoreDispatcher"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ICoreDispatcher(Silk.NET.WinRT.IInspectable value)
    {
        return new ICoreDispatcher(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICoreDispatcher"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ICoreDispatcher"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(ICoreDispatcher value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ICoreDispatcher"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ICoreDispatcher(Silk.NET.Windows.IUnknown value)
    {
        return new ICoreDispatcher(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICoreDispatcher"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ICoreDispatcher"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ICoreDispatcher value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
