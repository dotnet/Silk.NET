// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.devices.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("EFA8DFA9-6F75-4863-BA0B-583F3036B4DE")]
[NativeTypeName("struct IMediaDeviceControl : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaDeviceControl : IMediaDeviceControl.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaDeviceControl));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMediaDeviceControl, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMediaDeviceControl, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMediaDeviceControl, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IMediaDeviceControl, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IMediaDeviceControl, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IMediaDeviceControl, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Capabilities(
        [NativeTypeName("ABI::Windows::Media::Devices::IMediaDeviceControlCapabilities **")]
            IMediaDeviceControlCapabilities* value
    )
    {
        return (
            (delegate* unmanaged<IMediaDeviceControl, IMediaDeviceControlCapabilities*, int>)(
                (*lpVtbl)[6]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT TryGetValue(double* value, [NativeTypeName("boolean *")] byte* succeeded)
    {
        return ((delegate* unmanaged<IMediaDeviceControl, double*, byte*, int>)((*lpVtbl)[7]))(
            this,
            value,
            succeeded
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT TrySetValue(double value, [NativeTypeName("boolean *")] byte* succeeded)
    {
        return ((delegate* unmanaged<IMediaDeviceControl, double, byte*, int>)((*lpVtbl)[8]))(
            this,
            value,
            succeeded
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT TryGetAuto(
        [NativeTypeName("boolean *")] byte* value,
        [NativeTypeName("boolean *")] byte* succeeded
    )
    {
        return ((delegate* unmanaged<IMediaDeviceControl, byte*, byte*, int>)((*lpVtbl)[9]))(
            this,
            value,
            succeeded
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT TrySetAuto(
        [NativeTypeName("boolean")] byte value,
        [NativeTypeName("boolean *")] byte* succeeded
    )
    {
        return ((delegate* unmanaged<IMediaDeviceControl, byte, byte*, int>)((*lpVtbl)[10]))(
            this,
            value,
            succeeded
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Capabilities(
            [NativeTypeName("ABI::Windows::Media::Devices::IMediaDeviceControlCapabilities **")]
                IMediaDeviceControlCapabilities* value
        );

        [VtblIndex(7)]
        HRESULT TryGetValue(double* value, [NativeTypeName("boolean *")] byte* succeeded);

        [VtblIndex(8)]
        HRESULT TrySetValue(double value, [NativeTypeName("boolean *")] byte* succeeded);

        [VtblIndex(9)]
        HRESULT TryGetAuto(
            [NativeTypeName("boolean *")] byte* value,
            [NativeTypeName("boolean *")] byte* succeeded
        );

        [VtblIndex(10)]
        HRESULT TrySetAuto(
            [NativeTypeName("boolean")] byte value,
            [NativeTypeName("boolean *")] byte* succeeded
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
            "HRESULT (ABI::Windows::Media::Devices::IMediaDeviceControlCapabilities **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IMediaDeviceControlCapabilities*, int> get_Capabilities;

        [NativeTypeName("HRESULT (DOUBLE *, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double*, byte*, int> TryGetValue;

        [NativeTypeName("HRESULT (DOUBLE, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double, byte*, int> TrySetValue;

        [NativeTypeName("HRESULT (boolean *, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, byte*, int> TryGetAuto;

        [NativeTypeName("HRESULT (boolean, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, byte*, int> TrySetAuto;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMediaDeviceControl"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMediaDeviceControl(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IMediaDeviceControl"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IMediaDeviceControl(Silk.NET.WinRT.IInspectable value)
    {
        return new IMediaDeviceControl(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMediaDeviceControl"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IMediaDeviceControl"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IMediaDeviceControl value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMediaDeviceControl"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMediaDeviceControl(Silk.NET.Windows.IUnknown value)
    {
        return new IMediaDeviceControl(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMediaDeviceControl"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMediaDeviceControl"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMediaDeviceControl value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
