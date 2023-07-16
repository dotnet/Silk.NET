// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mmdeviceapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IMMDeviceActivator.xml' path='doc/member[@name="IMMDeviceActivator"]/*'/>
[Guid("3B0D0EA4-D0A9-4B0E-935B-09516746FAC0")]
[NativeTypeName("struct IMMDeviceActivator : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMMDeviceActivator : IMMDeviceActivator.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMMDeviceActivator));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMMDeviceActivator*, Guid*, void**, int> )(lpVtbl[0]))((IMMDeviceActivator*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMMDeviceActivator*, uint> )(lpVtbl[1]))((IMMDeviceActivator*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMMDeviceActivator*, uint> )(lpVtbl[2]))((IMMDeviceActivator*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMMDeviceActivator.xml' path='doc/member[@name="IMMDeviceActivator.Activate"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Activate([NativeTypeName("const IID &")] Guid* iid, IMMDevice* pDevice, PROPVARIANT* pActivationParams, void** ppInterface)
    {
        return ((delegate* unmanaged<IMMDeviceActivator*, Guid*, IMMDevice*, PROPVARIANT*, void**, int> )(lpVtbl[3]))((IMMDeviceActivator*)Unsafe.AsPointer(ref this), iid, pDevice, pActivationParams, ppInterface);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Activate([NativeTypeName("const IID &")] Guid* iid, IMMDevice* pDevice, PROPVARIANT* pActivationParams, void** ppInterface);
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
        [NativeTypeName("HRESULT (const IID &, IMMDevice *, PROPVARIANT *, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, IMMDevice*, PROPVARIANT*, void**, int> Activate;
    }
}