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

[Guid("BAFAECAD-484D-41BE-BA80-1D58C65263EA")]
[NativeTypeName("struct ICoreDispatcherWithTaskPriority : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICoreDispatcherWithTaskPriority
    : ICoreDispatcherWithTaskPriority.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICoreDispatcherWithTaskPriority));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<ICoreDispatcherWithTaskPriority, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ICoreDispatcherWithTaskPriority, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICoreDispatcherWithTaskPriority, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<ICoreDispatcherWithTaskPriority, uint*, Guid**, int>)((*lpVtbl)[3])
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<ICoreDispatcherWithTaskPriority, HSTRING*, int>)((*lpVtbl)[4])
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<ICoreDispatcherWithTaskPriority, TrustLevel*, int>)((*lpVtbl)[5])
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_CurrentPriority(
        [NativeTypeName("ABI::Windows::UI::Core::CoreDispatcherPriority *")]
            CoreDispatcherPriority* value
    )
    {
        return (
            (delegate* unmanaged<ICoreDispatcherWithTaskPriority, CoreDispatcherPriority*, int>)(
                (*lpVtbl)[6]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_CurrentPriority(
        [NativeTypeName("ABI::Windows::UI::Core::CoreDispatcherPriority")]
            CoreDispatcherPriority value
    )
    {
        return (
            (delegate* unmanaged<ICoreDispatcherWithTaskPriority, CoreDispatcherPriority, int>)(
                (*lpVtbl)[7]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT ShouldYield([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<ICoreDispatcherWithTaskPriority, byte*, int>)((*lpVtbl)[8]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT ShouldYieldToPriority(
        [NativeTypeName("ABI::Windows::UI::Core::CoreDispatcherPriority")]
            CoreDispatcherPriority priority,
        [NativeTypeName("boolean *")] byte* value
    )
    {
        return (
            (delegate* unmanaged<
                ICoreDispatcherWithTaskPriority,
                CoreDispatcherPriority,
                byte*,
                int>)((*lpVtbl)[9])
        )(this, priority, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT StopProcessEvents()
    {
        return ((delegate* unmanaged<ICoreDispatcherWithTaskPriority, int>)((*lpVtbl)[10]))(this);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_CurrentPriority(
            [NativeTypeName("ABI::Windows::UI::Core::CoreDispatcherPriority *")]
                CoreDispatcherPriority* value
        );

        [VtblIndex(7)]
        HRESULT put_CurrentPriority(
            [NativeTypeName("ABI::Windows::UI::Core::CoreDispatcherPriority")]
                CoreDispatcherPriority value
        );

        [VtblIndex(8)]
        HRESULT ShouldYield([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(9)]
        HRESULT ShouldYieldToPriority(
            [NativeTypeName("ABI::Windows::UI::Core::CoreDispatcherPriority")]
                CoreDispatcherPriority priority,
            [NativeTypeName("boolean *")] byte* value
        );

        [VtblIndex(10)]
        HRESULT StopProcessEvents();
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
            "HRESULT (ABI::Windows::UI::Core::CoreDispatcherPriority *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, CoreDispatcherPriority*, int> get_CurrentPriority;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Core::CoreDispatcherPriority) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, CoreDispatcherPriority, int> put_CurrentPriority;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> ShouldYield;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Core::CoreDispatcherPriority, boolean *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            CoreDispatcherPriority,
            byte*,
            int> ShouldYieldToPriority;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> StopProcessEvents;
    }

    /// <summary>Initializes a new instance of the <see cref = "ICoreDispatcherWithTaskPriority"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ICoreDispatcherWithTaskPriority(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ICoreDispatcherWithTaskPriority"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ICoreDispatcherWithTaskPriority(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new ICoreDispatcherWithTaskPriority(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICoreDispatcherWithTaskPriority"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ICoreDispatcherWithTaskPriority"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        ICoreDispatcherWithTaskPriority value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ICoreDispatcherWithTaskPriority"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ICoreDispatcherWithTaskPriority(Silk.NET.Windows.IUnknown value)
    {
        return new ICoreDispatcherWithTaskPriority(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICoreDispatcherWithTaskPriority"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ICoreDispatcherWithTaskPriority"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ICoreDispatcherWithTaskPriority value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
