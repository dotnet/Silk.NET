// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.networking.connectivity.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("C1431DD3-B146-4D39-B959-0C69B096C512")]
[NativeTypeName("struct IDataUsage : IInspectable")]
[NativeInheritance("IInspectable")]
[Obsolete(
    "IDataUsage may be altered or unavailable for releases after Windows 8.1. Instead, use INetworkUsage."
)]
public unsafe partial struct IDataUsage : IDataUsage.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDataUsage));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDataUsage, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDataUsage, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDataUsage, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IDataUsage, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IDataUsage, HSTRING*, int>)((*lpVtbl)[4]))(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IDataUsage, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [Obsolete(
        "IDataUsage may be altered or unavailable for releases after Windows 8.1. Instead, use INetworkUsage."
    )]
    public HRESULT get_BytesSent([NativeTypeName("UINT64 *")] ulong* value)
    {
        return ((delegate* unmanaged<IDataUsage, ulong*, int>)((*lpVtbl)[6]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    [Obsolete(
        "IDataUsage may be altered or unavailable for releases after Windows 8.1. Instead, use INetworkUsage."
    )]
    public HRESULT get_BytesReceived([NativeTypeName("UINT64 *")] ulong* value)
    {
        return ((delegate* unmanaged<IDataUsage, ulong*, int>)((*lpVtbl)[7]))(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        [Obsolete(
            "IDataUsage may be altered or unavailable for releases after Windows 8.1. Instead, use INetworkUsage."
        )]
        HRESULT get_BytesSent([NativeTypeName("UINT64 *")] ulong* value);

        [VtblIndex(7)]
        [Obsolete(
            "IDataUsage may be altered or unavailable for releases after Windows 8.1. Instead, use INetworkUsage."
        )]
        HRESULT get_BytesReceived([NativeTypeName("UINT64 *")] ulong* value);
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

        [NativeTypeName("HRESULT (UINT64 *) __attribute__((stdcall))")]
        [Obsolete(
            "IDataUsage may be altered or unavailable for releases after Windows 8.1. Instead, use INetworkUsage."
        )]
        public delegate* unmanaged<TSelf*, ulong*, int> get_BytesSent;

        [NativeTypeName("HRESULT (UINT64 *) __attribute__((stdcall))")]
        [Obsolete(
            "IDataUsage may be altered or unavailable for releases after Windows 8.1. Instead, use INetworkUsage."
        )]
        public delegate* unmanaged<TSelf*, ulong*, int> get_BytesReceived;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDataUsage"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDataUsage(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IDataUsage"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IDataUsage(Silk.NET.WinRT.IInspectable value)
    {
        return new IDataUsage(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDataUsage"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IDataUsage"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IDataUsage value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDataUsage"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDataUsage(Silk.NET.Windows.IUnknown value)
    {
        return new IDataUsage(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDataUsage"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDataUsage"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDataUsage value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
