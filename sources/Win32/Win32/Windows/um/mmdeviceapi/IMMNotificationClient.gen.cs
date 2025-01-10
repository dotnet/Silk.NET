// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mmdeviceapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("7991EEC9-7E89-4D85-8390-6C703CEC60C0")]
[NativeTypeName("struct IMMNotificationClient : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMMNotificationClient : IMMNotificationClient.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMMNotificationClient));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMMNotificationClient, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMMNotificationClient, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMMNotificationClient, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT OnDeviceStateChanged(
        [NativeTypeName("LPCWSTR")] ushort* pwstrDeviceId,
        [NativeTypeName("DWORD")] uint dwNewState
    )
    {
        return ((delegate* unmanaged<IMMNotificationClient, ushort*, uint, int>)((*lpVtbl)[3]))(
            this,
            pwstrDeviceId,
            dwNewState
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT OnDeviceAdded([NativeTypeName("LPCWSTR")] ushort* pwstrDeviceId)
    {
        return ((delegate* unmanaged<IMMNotificationClient, ushort*, int>)((*lpVtbl)[4]))(
            this,
            pwstrDeviceId
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT OnDeviceRemoved([NativeTypeName("LPCWSTR")] ushort* pwstrDeviceId)
    {
        return ((delegate* unmanaged<IMMNotificationClient, ushort*, int>)((*lpVtbl)[5]))(
            this,
            pwstrDeviceId
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT OnDefaultDeviceChanged(
        EDataFlow flow,
        ERole role,
        [NativeTypeName("LPCWSTR")] ushort* pwstrDefaultDeviceId
    )
    {
        return (
            (delegate* unmanaged<IMMNotificationClient, EDataFlow, ERole, ushort*, int>)(
                (*lpVtbl)[6]
            )
        )(this, flow, role, pwstrDefaultDeviceId);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT OnPropertyValueChanged(
        [NativeTypeName("LPCWSTR")] ushort* pwstrDeviceId,
        [NativeTypeName("const PROPERTYKEY")] PROPERTYKEY key
    )
    {
        return (
            (delegate* unmanaged<IMMNotificationClient, ushort*, PROPERTYKEY, int>)((*lpVtbl)[7])
        )(this, pwstrDeviceId, key);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT OnDeviceStateChanged(
            [NativeTypeName("LPCWSTR")] ushort* pwstrDeviceId,
            [NativeTypeName("DWORD")] uint dwNewState
        );

        [VtblIndex(4)]
        HRESULT OnDeviceAdded([NativeTypeName("LPCWSTR")] ushort* pwstrDeviceId);

        [VtblIndex(5)]
        HRESULT OnDeviceRemoved([NativeTypeName("LPCWSTR")] ushort* pwstrDeviceId);

        [VtblIndex(6)]
        HRESULT OnDefaultDeviceChanged(
            EDataFlow flow,
            ERole role,
            [NativeTypeName("LPCWSTR")] ushort* pwstrDefaultDeviceId
        );

        [VtblIndex(7)]
        HRESULT OnPropertyValueChanged(
            [NativeTypeName("LPCWSTR")] ushort* pwstrDeviceId,
            [NativeTypeName("const PROPERTYKEY")] PROPERTYKEY key
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

        [NativeTypeName("HRESULT (LPCWSTR, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, uint, int> OnDeviceStateChanged;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> OnDeviceAdded;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> OnDeviceRemoved;

        [NativeTypeName("HRESULT (EDataFlow, ERole, LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EDataFlow, ERole, ushort*, int> OnDefaultDeviceChanged;

        [NativeTypeName("HRESULT (LPCWSTR, const PROPERTYKEY) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, PROPERTYKEY, int> OnPropertyValueChanged;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMMNotificationClient"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMMNotificationClient(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMMNotificationClient"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMMNotificationClient(Silk.NET.Windows.IUnknown value)
    {
        return new IMMNotificationClient(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMMNotificationClient"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMMNotificationClient"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMMNotificationClient value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
