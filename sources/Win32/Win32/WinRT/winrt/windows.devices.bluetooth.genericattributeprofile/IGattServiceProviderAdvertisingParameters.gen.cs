// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.bluetooth.genericattributeprofile.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("E2CE31AB-6315-4C22-9BD7-781DBC3D8D82")]
[NativeTypeName("struct IGattServiceProviderAdvertisingParameters : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IGattServiceProviderAdvertisingParameters
    : IGattServiceProviderAdvertisingParameters.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IGattServiceProviderAdvertisingParameters));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IGattServiceProviderAdvertisingParameters, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return (
            (delegate* unmanaged<IGattServiceProviderAdvertisingParameters, uint>)((*lpVtbl)[1])
        )(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return (
            (delegate* unmanaged<IGattServiceProviderAdvertisingParameters, uint>)((*lpVtbl)[2])
        )(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IGattServiceProviderAdvertisingParameters, uint*, Guid**, int>)(
                (*lpVtbl)[3]
            )
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<IGattServiceProviderAdvertisingParameters, HSTRING*, int>)(
                (*lpVtbl)[4]
            )
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IGattServiceProviderAdvertisingParameters, TrustLevel*, int>)(
                (*lpVtbl)[5]
            )
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT put_IsConnectable([NativeTypeName("boolean")] byte value)
    {
        return (
            (delegate* unmanaged<IGattServiceProviderAdvertisingParameters, byte, int>)(
                (*lpVtbl)[6]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_IsConnectable([NativeTypeName("boolean *")] byte* value)
    {
        return (
            (delegate* unmanaged<IGattServiceProviderAdvertisingParameters, byte*, int>)(
                (*lpVtbl)[7]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_IsDiscoverable([NativeTypeName("boolean")] byte value)
    {
        return (
            (delegate* unmanaged<IGattServiceProviderAdvertisingParameters, byte, int>)(
                (*lpVtbl)[8]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_IsDiscoverable([NativeTypeName("boolean *")] byte* value)
    {
        return (
            (delegate* unmanaged<IGattServiceProviderAdvertisingParameters, byte*, int>)(
                (*lpVtbl)[9]
            )
        )(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT put_IsConnectable([NativeTypeName("boolean")] byte value);

        [VtblIndex(7)]
        HRESULT get_IsConnectable([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(8)]
        HRESULT put_IsDiscoverable([NativeTypeName("boolean")] byte value);

        [VtblIndex(9)]
        HRESULT get_IsDiscoverable([NativeTypeName("boolean *")] byte* value);
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

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_IsConnectable;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsConnectable;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_IsDiscoverable;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsDiscoverable;
    }

    /// <summary>Initializes a new instance of the <see cref = "IGattServiceProviderAdvertisingParameters"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IGattServiceProviderAdvertisingParameters(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IGattServiceProviderAdvertisingParameters"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IGattServiceProviderAdvertisingParameters(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new IGattServiceProviderAdvertisingParameters(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IGattServiceProviderAdvertisingParameters"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IGattServiceProviderAdvertisingParameters"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        IGattServiceProviderAdvertisingParameters value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IGattServiceProviderAdvertisingParameters"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IGattServiceProviderAdvertisingParameters(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IGattServiceProviderAdvertisingParameters(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IGattServiceProviderAdvertisingParameters"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IGattServiceProviderAdvertisingParameters"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IGattServiceProviderAdvertisingParameters value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
