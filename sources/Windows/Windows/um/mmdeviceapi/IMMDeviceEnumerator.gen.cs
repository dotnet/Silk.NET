// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mmdeviceapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IMMDeviceEnumerator.xml' path='doc/member[@name="IMMDeviceEnumerator"]/*'/>
[Guid("A95664D2-9614-4F35-A746-DE8DB63617E6")]
[NativeTypeName("struct IMMDeviceEnumerator : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMMDeviceEnumerator : IMMDeviceEnumerator.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMMDeviceEnumerator));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMMDeviceEnumerator*, Guid*, void**, int> )(lpVtbl[0]))((IMMDeviceEnumerator*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMMDeviceEnumerator*, uint> )(lpVtbl[1]))((IMMDeviceEnumerator*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMMDeviceEnumerator*, uint> )(lpVtbl[2]))((IMMDeviceEnumerator*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMMDeviceEnumerator.xml' path='doc/member[@name="IMMDeviceEnumerator.EnumAudioEndpoints"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT EnumAudioEndpoints(EDataFlow dataFlow, [NativeTypeName("DWORD")] uint dwStateMask, IMMDeviceCollection** ppDevices)
    {
        return ((delegate* unmanaged<IMMDeviceEnumerator*, EDataFlow, uint, IMMDeviceCollection**, int> )(lpVtbl[3]))((IMMDeviceEnumerator*)Unsafe.AsPointer(ref this), dataFlow, dwStateMask, ppDevices);
    }

    /// <include file='IMMDeviceEnumerator.xml' path='doc/member[@name="IMMDeviceEnumerator.GetDefaultAudioEndpoint"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetDefaultAudioEndpoint(EDataFlow dataFlow, ERole role, IMMDevice** ppEndpoint)
    {
        return ((delegate* unmanaged<IMMDeviceEnumerator*, EDataFlow, ERole, IMMDevice**, int> )(lpVtbl[4]))((IMMDeviceEnumerator*)Unsafe.AsPointer(ref this), dataFlow, role, ppEndpoint);
    }

    /// <include file='IMMDeviceEnumerator.xml' path='doc/member[@name="IMMDeviceEnumerator.GetDevice"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetDevice([NativeTypeName("LPCWSTR")] ushort* pwstrId, IMMDevice** ppDevice)
    {
        return ((delegate* unmanaged<IMMDeviceEnumerator*, ushort*, IMMDevice**, int> )(lpVtbl[5]))((IMMDeviceEnumerator*)Unsafe.AsPointer(ref this), pwstrId, ppDevice);
    }

    /// <include file='IMMDeviceEnumerator.xml' path='doc/member[@name="IMMDeviceEnumerator.RegisterEndpointNotificationCallback"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT RegisterEndpointNotificationCallback(IMMNotificationClient* pClient)
    {
        return ((delegate* unmanaged<IMMDeviceEnumerator*, IMMNotificationClient*, int> )(lpVtbl[6]))((IMMDeviceEnumerator*)Unsafe.AsPointer(ref this), pClient);
    }

    /// <include file='IMMDeviceEnumerator.xml' path='doc/member[@name="IMMDeviceEnumerator.UnregisterEndpointNotificationCallback"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT UnregisterEndpointNotificationCallback(IMMNotificationClient* pClient)
    {
        return ((delegate* unmanaged<IMMDeviceEnumerator*, IMMNotificationClient*, int> )(lpVtbl[7]))((IMMDeviceEnumerator*)Unsafe.AsPointer(ref this), pClient);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT EnumAudioEndpoints(EDataFlow dataFlow, [NativeTypeName("DWORD")] uint dwStateMask, IMMDeviceCollection** ppDevices);
        [VtblIndex(4)]
        HRESULT GetDefaultAudioEndpoint(EDataFlow dataFlow, ERole role, IMMDevice** ppEndpoint);
        [VtblIndex(5)]
        HRESULT GetDevice([NativeTypeName("LPCWSTR")] ushort* pwstrId, IMMDevice** ppDevice);
        [VtblIndex(6)]
        HRESULT RegisterEndpointNotificationCallback(IMMNotificationClient* pClient);
        [VtblIndex(7)]
        HRESULT UnregisterEndpointNotificationCallback(IMMNotificationClient* pClient);
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
        [NativeTypeName("HRESULT (EDataFlow, DWORD, IMMDeviceCollection **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EDataFlow, uint, IMMDeviceCollection**, int> EnumAudioEndpoints;
        [NativeTypeName("HRESULT (EDataFlow, ERole, IMMDevice **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EDataFlow, ERole, IMMDevice**, int> GetDefaultAudioEndpoint;
        [NativeTypeName("HRESULT (LPCWSTR, IMMDevice **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, IMMDevice**, int> GetDevice;
        [NativeTypeName("HRESULT (IMMNotificationClient *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMMNotificationClient*, int> RegisterEndpointNotificationCallback;
        [NativeTypeName("HRESULT (IMMNotificationClient *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMMNotificationClient*, int> UnregisterEndpointNotificationCallback;
    }
}