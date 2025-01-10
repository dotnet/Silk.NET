// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/CoreWindow.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("7A5B6FD1-CD73-4B6C-9CF4-2E869EAF470A")]
[NativeTypeName("struct ICoreWindowAdapterInterop : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICoreWindowAdapterInterop
    : ICoreWindowAdapterInterop.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICoreWindowAdapterInterop));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ICoreWindowAdapterInterop, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ICoreWindowAdapterInterop, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICoreWindowAdapterInterop, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<ICoreWindowAdapterInterop, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<ICoreWindowAdapterInterop, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<ICoreWindowAdapterInterop, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_AppActivationClientAdapter(IUnknown* value)
    {
        return ((delegate* unmanaged<ICoreWindowAdapterInterop, IUnknown*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_ApplicationViewClientAdapter(IUnknown* value)
    {
        return ((delegate* unmanaged<ICoreWindowAdapterInterop, IUnknown*, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_CoreApplicationViewClientAdapter(IUnknown* value)
    {
        return ((delegate* unmanaged<ICoreWindowAdapterInterop, IUnknown*, int>)((*lpVtbl)[8]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_HoloViewClientAdapter(IUnknown* value)
    {
        return ((delegate* unmanaged<ICoreWindowAdapterInterop, IUnknown*, int>)((*lpVtbl)[9]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_PositionerClientAdapter(IUnknown* value)
    {
        return ((delegate* unmanaged<ICoreWindowAdapterInterop, IUnknown*, int>)((*lpVtbl)[10]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_SystemNavigationClientAdapter(IUnknown* value)
    {
        return ((delegate* unmanaged<ICoreWindowAdapterInterop, IUnknown*, int>)((*lpVtbl)[11]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_TitleBarClientAdapter(IUnknown* value)
    {
        return ((delegate* unmanaged<ICoreWindowAdapterInterop, IUnknown*, int>)((*lpVtbl)[12]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT SetWindowClientAdapter(IUnknown value)
    {
        return ((delegate* unmanaged<ICoreWindowAdapterInterop, IUnknown, int>)((*lpVtbl)[13]))(
            this,
            value
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_AppActivationClientAdapter(IUnknown* value);

        [VtblIndex(7)]
        HRESULT get_ApplicationViewClientAdapter(IUnknown* value);

        [VtblIndex(8)]
        HRESULT get_CoreApplicationViewClientAdapter(IUnknown* value);

        [VtblIndex(9)]
        HRESULT get_HoloViewClientAdapter(IUnknown* value);

        [VtblIndex(10)]
        HRESULT get_PositionerClientAdapter(IUnknown* value);

        [VtblIndex(11)]
        HRESULT get_SystemNavigationClientAdapter(IUnknown* value);

        [VtblIndex(12)]
        HRESULT get_TitleBarClientAdapter(IUnknown* value);

        [VtblIndex(13)]
        HRESULT SetWindowClientAdapter(IUnknown value);
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

        [NativeTypeName("HRESULT (IUnknown **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown*, int> get_AppActivationClientAdapter;

        [NativeTypeName("HRESULT (IUnknown **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown*, int> get_ApplicationViewClientAdapter;

        [NativeTypeName("HRESULT (IUnknown **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown*, int> get_CoreApplicationViewClientAdapter;

        [NativeTypeName("HRESULT (IUnknown **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown*, int> get_HoloViewClientAdapter;

        [NativeTypeName("HRESULT (IUnknown **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown*, int> get_PositionerClientAdapter;

        [NativeTypeName("HRESULT (IUnknown **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown*, int> get_SystemNavigationClientAdapter;

        [NativeTypeName("HRESULT (IUnknown **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown*, int> get_TitleBarClientAdapter;

        [NativeTypeName("HRESULT (IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown, int> SetWindowClientAdapter;
    }

    /// <summary>Initializes a new instance of the <see cref = "ICoreWindowAdapterInterop"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ICoreWindowAdapterInterop(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ICoreWindowAdapterInterop"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ICoreWindowAdapterInterop(Silk.NET.WinRT.IInspectable value)
    {
        return new ICoreWindowAdapterInterop(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICoreWindowAdapterInterop"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ICoreWindowAdapterInterop"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(ICoreWindowAdapterInterop value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ICoreWindowAdapterInterop"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ICoreWindowAdapterInterop(Silk.NET.Windows.IUnknown value)
    {
        return new ICoreWindowAdapterInterop(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICoreWindowAdapterInterop"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ICoreWindowAdapterInterop"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ICoreWindowAdapterInterop value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
