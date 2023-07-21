// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mmdeviceapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IMMDeviceCollection.xml' path='doc/member[@name="IMMDeviceCollection"]/*' />
[Guid("0BD7A1BE-7A1A-44DB-8397-CC5392387B5E")]
[NativeTypeName("struct IMMDeviceCollection : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMMDeviceCollection : IMMDeviceCollection.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMMDeviceCollection));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMMDeviceCollection*, Guid*, void**, int>)(lpVtbl[0]))((IMMDeviceCollection*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMMDeviceCollection*, uint>)(lpVtbl[1]))((IMMDeviceCollection*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMMDeviceCollection*, uint>)(lpVtbl[2]))((IMMDeviceCollection*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMMDeviceCollection.xml' path='doc/member[@name="IMMDeviceCollection.GetCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetCount(uint* pcDevices)
    {
        return ((delegate* unmanaged<IMMDeviceCollection*, uint*, int>)(lpVtbl[3]))((IMMDeviceCollection*)Unsafe.AsPointer(ref this), pcDevices);
    }

    /// <include file='IMMDeviceCollection.xml' path='doc/member[@name="IMMDeviceCollection.Item"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Item(uint nDevice, IMMDevice** ppDevice)
    {
        return ((delegate* unmanaged<IMMDeviceCollection*, uint, IMMDevice**, int>)(lpVtbl[4]))((IMMDeviceCollection*)Unsafe.AsPointer(ref this), nDevice, ppDevice);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetCount(uint* pcDevices);

        [VtblIndex(4)]
        HRESULT Item(uint nDevice, IMMDevice** ppDevice);
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

        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetCount;

        [NativeTypeName("HRESULT (UINT, IMMDevice **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IMMDevice**, int> Item;
    }
}
