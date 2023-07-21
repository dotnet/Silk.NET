// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IAMExtDevice.xml' path='doc/member[@name="IAMExtDevice"]/*' />
[Guid("B5730A90-1A2C-11CF-8C23-00AA006B6814")]
[NativeTypeName("struct IAMExtDevice : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAMExtDevice : IAMExtDevice.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAMExtDevice));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAMExtDevice*, Guid*, void**, int>)(lpVtbl[0]))((IAMExtDevice*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAMExtDevice*, uint>)(lpVtbl[1]))((IAMExtDevice*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAMExtDevice*, uint>)(lpVtbl[2]))((IAMExtDevice*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAMExtDevice.xml' path='doc/member[@name="IAMExtDevice.GetCapability"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetCapability([NativeTypeName("long")] int Capability, [NativeTypeName("long *")] int* pValue, double* pdblValue)
    {
        return ((delegate* unmanaged<IAMExtDevice*, int, int*, double*, int>)(lpVtbl[3]))((IAMExtDevice*)Unsafe.AsPointer(ref this), Capability, pValue, pdblValue);
    }

    /// <include file='IAMExtDevice.xml' path='doc/member[@name="IAMExtDevice.get_ExternalDeviceID"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT get_ExternalDeviceID([NativeTypeName("LPOLESTR *")] ushort** ppszData)
    {
        return ((delegate* unmanaged<IAMExtDevice*, ushort**, int>)(lpVtbl[4]))((IAMExtDevice*)Unsafe.AsPointer(ref this), ppszData);
    }

    /// <include file='IAMExtDevice.xml' path='doc/member[@name="IAMExtDevice.get_ExternalDeviceVersion"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT get_ExternalDeviceVersion([NativeTypeName("LPOLESTR *")] ushort** ppszData)
    {
        return ((delegate* unmanaged<IAMExtDevice*, ushort**, int>)(lpVtbl[5]))((IAMExtDevice*)Unsafe.AsPointer(ref this), ppszData);
    }

    /// <include file='IAMExtDevice.xml' path='doc/member[@name="IAMExtDevice.put_DevicePower"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT put_DevicePower([NativeTypeName("long")] int PowerMode)
    {
        return ((delegate* unmanaged<IAMExtDevice*, int, int>)(lpVtbl[6]))((IAMExtDevice*)Unsafe.AsPointer(ref this), PowerMode);
    }

    /// <include file='IAMExtDevice.xml' path='doc/member[@name="IAMExtDevice.get_DevicePower"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_DevicePower([NativeTypeName("long *")] int* pPowerMode)
    {
        return ((delegate* unmanaged<IAMExtDevice*, int*, int>)(lpVtbl[7]))((IAMExtDevice*)Unsafe.AsPointer(ref this), pPowerMode);
    }

    /// <include file='IAMExtDevice.xml' path='doc/member[@name="IAMExtDevice.Calibrate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT Calibrate(HEVENT hEvent, [NativeTypeName("long")] int Mode, [NativeTypeName("long *")] int* pStatus)
    {
        return ((delegate* unmanaged<IAMExtDevice*, HEVENT, int, int*, int>)(lpVtbl[8]))((IAMExtDevice*)Unsafe.AsPointer(ref this), hEvent, Mode, pStatus);
    }

    /// <include file='IAMExtDevice.xml' path='doc/member[@name="IAMExtDevice.put_DevicePort"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_DevicePort([NativeTypeName("long")] int DevicePort)
    {
        return ((delegate* unmanaged<IAMExtDevice*, int, int>)(lpVtbl[9]))((IAMExtDevice*)Unsafe.AsPointer(ref this), DevicePort);
    }

    /// <include file='IAMExtDevice.xml' path='doc/member[@name="IAMExtDevice.get_DevicePort"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_DevicePort([NativeTypeName("long *")] int* pDevicePort)
    {
        return ((delegate* unmanaged<IAMExtDevice*, int*, int>)(lpVtbl[10]))((IAMExtDevice*)Unsafe.AsPointer(ref this), pDevicePort);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetCapability([NativeTypeName("long")] int Capability, [NativeTypeName("long *")] int* pValue, double* pdblValue);

        [VtblIndex(4)]
        HRESULT get_ExternalDeviceID([NativeTypeName("LPOLESTR *")] ushort** ppszData);

        [VtblIndex(5)]
        HRESULT get_ExternalDeviceVersion([NativeTypeName("LPOLESTR *")] ushort** ppszData);

        [VtblIndex(6)]
        HRESULT put_DevicePower([NativeTypeName("long")] int PowerMode);

        [VtblIndex(7)]
        HRESULT get_DevicePower([NativeTypeName("long *")] int* pPowerMode);

        [VtblIndex(8)]
        HRESULT Calibrate(HEVENT hEvent, [NativeTypeName("long")] int Mode, [NativeTypeName("long *")] int* pStatus);

        [VtblIndex(9)]
        HRESULT put_DevicePort([NativeTypeName("long")] int DevicePort);

        [VtblIndex(10)]
        HRESULT get_DevicePort([NativeTypeName("long *")] int* pDevicePort);
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

        [NativeTypeName("HRESULT (long, long *, double *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int*, double*, int> GetCapability;

        [NativeTypeName("HRESULT (LPOLESTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_ExternalDeviceID;

        [NativeTypeName("HRESULT (LPOLESTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_ExternalDeviceVersion;

        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_DevicePower;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_DevicePower;

        [NativeTypeName("HRESULT (HEVENT, long, long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HEVENT, int, int*, int> Calibrate;

        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_DevicePort;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_DevicePort;
    }
}
