// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mmdeviceapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("A95664D2-9614-4F35-A746-DE8DB63617E6")]
[NativeTypeName("struct IMMDeviceEnumerator : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMMDeviceEnumerator : IMMDeviceEnumerator.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMMDeviceEnumerator));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMMDeviceEnumerator, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMMDeviceEnumerator, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMMDeviceEnumerator, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT EnumAudioEndpoints(
        EDataFlow dataFlow,
        [NativeTypeName("DWORD")] uint dwStateMask,
        IMMDeviceCollection* ppDevices
    )
    {
        return (
            (delegate* unmanaged<IMMDeviceEnumerator, EDataFlow, uint, IMMDeviceCollection*, int>)(
                (*lpVtbl)[3]
            )
        )(this, dataFlow, dwStateMask, ppDevices);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetDefaultAudioEndpoint(EDataFlow dataFlow, ERole role, IMMDevice* ppEndpoint)
    {
        return (
            (delegate* unmanaged<IMMDeviceEnumerator, EDataFlow, ERole, IMMDevice*, int>)(
                (*lpVtbl)[4]
            )
        )(this, dataFlow, role, ppEndpoint);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetDevice([NativeTypeName("LPCWSTR")] ushort* pwstrId, IMMDevice* ppDevice)
    {
        return ((delegate* unmanaged<IMMDeviceEnumerator, ushort*, IMMDevice*, int>)((*lpVtbl)[5]))(
            this,
            pwstrId,
            ppDevice
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT RegisterEndpointNotificationCallback(IMMNotificationClient pClient)
    {
        return (
            (delegate* unmanaged<IMMDeviceEnumerator, IMMNotificationClient, int>)((*lpVtbl)[6])
        )(this, pClient);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT UnregisterEndpointNotificationCallback(IMMNotificationClient pClient)
    {
        return (
            (delegate* unmanaged<IMMDeviceEnumerator, IMMNotificationClient, int>)((*lpVtbl)[7])
        )(this, pClient);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT EnumAudioEndpoints(
            EDataFlow dataFlow,
            [NativeTypeName("DWORD")] uint dwStateMask,
            IMMDeviceCollection* ppDevices
        );

        [VtblIndex(4)]
        HRESULT GetDefaultAudioEndpoint(EDataFlow dataFlow, ERole role, IMMDevice* ppEndpoint);

        [VtblIndex(5)]
        HRESULT GetDevice([NativeTypeName("LPCWSTR")] ushort* pwstrId, IMMDevice* ppDevice);

        [VtblIndex(6)]
        HRESULT RegisterEndpointNotificationCallback(IMMNotificationClient pClient);

        [VtblIndex(7)]
        HRESULT UnregisterEndpointNotificationCallback(IMMNotificationClient pClient);
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

        [NativeTypeName(
            "HRESULT (EDataFlow, DWORD, IMMDeviceCollection **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            EDataFlow,
            uint,
            IMMDeviceCollection*,
            int> EnumAudioEndpoints;

        [NativeTypeName("HRESULT (EDataFlow, ERole, IMMDevice **) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            EDataFlow,
            ERole,
            IMMDevice*,
            int> GetDefaultAudioEndpoint;

        [NativeTypeName("HRESULT (LPCWSTR, IMMDevice **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, IMMDevice*, int> GetDevice;

        [NativeTypeName("HRESULT (IMMNotificationClient *) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            IMMNotificationClient,
            int> RegisterEndpointNotificationCallback;

        [NativeTypeName("HRESULT (IMMNotificationClient *) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            IMMNotificationClient,
            int> UnregisterEndpointNotificationCallback;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMMDeviceEnumerator"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMMDeviceEnumerator(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMMDeviceEnumerator"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMMDeviceEnumerator(Silk.NET.Windows.IUnknown value)
    {
        return new IMMDeviceEnumerator(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMMDeviceEnumerator"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMMDeviceEnumerator"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMMDeviceEnumerator value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
