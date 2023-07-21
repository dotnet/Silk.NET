// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/devicetopology.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IDeviceSpecificProperty.xml' path='doc/member[@name="IDeviceSpecificProperty"]/*' />
[Guid("3B22BCBF-2586-4AF0-8583-205D391B807C")]
[NativeTypeName("struct IDeviceSpecificProperty : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDeviceSpecificProperty : IDeviceSpecificProperty.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDeviceSpecificProperty));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDeviceSpecificProperty*, Guid*, void**, int>)(lpVtbl[0]))((IDeviceSpecificProperty*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDeviceSpecificProperty*, uint>)(lpVtbl[1]))((IDeviceSpecificProperty*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDeviceSpecificProperty*, uint>)(lpVtbl[2]))((IDeviceSpecificProperty*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDeviceSpecificProperty.xml' path='doc/member[@name="IDeviceSpecificProperty.GetType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetType([NativeTypeName("VARTYPE *")] ushort* pVType)
    {
        return ((delegate* unmanaged<IDeviceSpecificProperty*, ushort*, int>)(lpVtbl[3]))((IDeviceSpecificProperty*)Unsafe.AsPointer(ref this), pVType);
    }

    /// <include file='IDeviceSpecificProperty.xml' path='doc/member[@name="IDeviceSpecificProperty.GetValue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetValue(void* pvValue, [NativeTypeName("DWORD *")] uint* pcbValue)
    {
        return ((delegate* unmanaged<IDeviceSpecificProperty*, void*, uint*, int>)(lpVtbl[4]))((IDeviceSpecificProperty*)Unsafe.AsPointer(ref this), pvValue, pcbValue);
    }

    /// <include file='IDeviceSpecificProperty.xml' path='doc/member[@name="IDeviceSpecificProperty.SetValue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetValue(void* pvValue, [NativeTypeName("DWORD")] uint cbValue, [NativeTypeName("LPCGUID")] Guid* pguidEventContext)
    {
        return ((delegate* unmanaged<IDeviceSpecificProperty*, void*, uint, Guid*, int>)(lpVtbl[5]))((IDeviceSpecificProperty*)Unsafe.AsPointer(ref this), pvValue, cbValue, pguidEventContext);
    }

    /// <include file='IDeviceSpecificProperty.xml' path='doc/member[@name="IDeviceSpecificProperty.Get4BRange"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Get4BRange([NativeTypeName("LONG *")] int* plMin, [NativeTypeName("LONG *")] int* plMax, [NativeTypeName("LONG *")] int* plStepping)
    {
        return ((delegate* unmanaged<IDeviceSpecificProperty*, int*, int*, int*, int>)(lpVtbl[6]))((IDeviceSpecificProperty*)Unsafe.AsPointer(ref this), plMin, plMax, plStepping);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetType([NativeTypeName("VARTYPE *")] ushort* pVType);

        [VtblIndex(4)]
        HRESULT GetValue(void* pvValue, [NativeTypeName("DWORD *")] uint* pcbValue);

        [VtblIndex(5)]
        HRESULT SetValue(void* pvValue, [NativeTypeName("DWORD")] uint cbValue, [NativeTypeName("LPCGUID")] Guid* pguidEventContext);

        [VtblIndex(6)]
        HRESULT Get4BRange([NativeTypeName("LONG *")] int* plMin, [NativeTypeName("LONG *")] int* plMax, [NativeTypeName("LONG *")] int* plStepping);
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

        [NativeTypeName("HRESULT (VARTYPE *) __attribute__((stdcall))")]
        public new delegate* unmanaged<TSelf*, ushort*, int> GetType;

        [NativeTypeName("HRESULT (void *, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void*, uint*, int> GetValue;

        [NativeTypeName("HRESULT (void *, DWORD, LPCGUID) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void*, uint, Guid*, int> SetValue;

        [NativeTypeName("HRESULT (LONG *, LONG *, LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int*, int*, int> Get4BRange;
    }
}
