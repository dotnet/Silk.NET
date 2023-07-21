// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/devicetopology.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IDeviceTopology.xml' path='doc/member[@name="IDeviceTopology"]/*' />
[Guid("2A07407E-6497-4A18-9787-32F79BD0D98F")]
[NativeTypeName("struct IDeviceTopology : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDeviceTopology : IDeviceTopology.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDeviceTopology));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDeviceTopology*, Guid*, void**, int>)(lpVtbl[0]))((IDeviceTopology*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDeviceTopology*, uint>)(lpVtbl[1]))((IDeviceTopology*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDeviceTopology*, uint>)(lpVtbl[2]))((IDeviceTopology*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDeviceTopology.xml' path='doc/member[@name="IDeviceTopology.GetConnectorCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetConnectorCount(uint* pCount)
    {
        return ((delegate* unmanaged<IDeviceTopology*, uint*, int>)(lpVtbl[3]))((IDeviceTopology*)Unsafe.AsPointer(ref this), pCount);
    }

    /// <include file='IDeviceTopology.xml' path='doc/member[@name="IDeviceTopology.GetConnector"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetConnector(uint nIndex, IConnector** ppConnector)
    {
        return ((delegate* unmanaged<IDeviceTopology*, uint, IConnector**, int>)(lpVtbl[4]))((IDeviceTopology*)Unsafe.AsPointer(ref this), nIndex, ppConnector);
    }

    /// <include file='IDeviceTopology.xml' path='doc/member[@name="IDeviceTopology.GetSubunitCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetSubunitCount(uint* pCount)
    {
        return ((delegate* unmanaged<IDeviceTopology*, uint*, int>)(lpVtbl[5]))((IDeviceTopology*)Unsafe.AsPointer(ref this), pCount);
    }

    /// <include file='IDeviceTopology.xml' path='doc/member[@name="IDeviceTopology.GetSubunit"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetSubunit(uint nIndex, ISubunit** ppSubunit)
    {
        return ((delegate* unmanaged<IDeviceTopology*, uint, ISubunit**, int>)(lpVtbl[6]))((IDeviceTopology*)Unsafe.AsPointer(ref this), nIndex, ppSubunit);
    }

    /// <include file='IDeviceTopology.xml' path='doc/member[@name="IDeviceTopology.GetPartById"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetPartById(uint nId, IPart** ppPart)
    {
        return ((delegate* unmanaged<IDeviceTopology*, uint, IPart**, int>)(lpVtbl[7]))((IDeviceTopology*)Unsafe.AsPointer(ref this), nId, ppPart);
    }

    /// <include file='IDeviceTopology.xml' path='doc/member[@name="IDeviceTopology.GetDeviceId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetDeviceId([NativeTypeName("LPWSTR *")] ushort** ppwstrDeviceId)
    {
        return ((delegate* unmanaged<IDeviceTopology*, ushort**, int>)(lpVtbl[8]))((IDeviceTopology*)Unsafe.AsPointer(ref this), ppwstrDeviceId);
    }

    /// <include file='IDeviceTopology.xml' path='doc/member[@name="IDeviceTopology.GetSignalPath"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetSignalPath(IPart* pIPartFrom, IPart* pIPartTo, BOOL bRejectMixedPaths, IPartsList** ppParts)
    {
        return ((delegate* unmanaged<IDeviceTopology*, IPart*, IPart*, BOOL, IPartsList**, int>)(lpVtbl[9]))((IDeviceTopology*)Unsafe.AsPointer(ref this), pIPartFrom, pIPartTo, bRejectMixedPaths, ppParts);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetConnectorCount(uint* pCount);

        [VtblIndex(4)]
        HRESULT GetConnector(uint nIndex, IConnector** ppConnector);

        [VtblIndex(5)]
        HRESULT GetSubunitCount(uint* pCount);

        [VtblIndex(6)]
        HRESULT GetSubunit(uint nIndex, ISubunit** ppSubunit);

        [VtblIndex(7)]
        HRESULT GetPartById(uint nId, IPart** ppPart);

        [VtblIndex(8)]
        HRESULT GetDeviceId([NativeTypeName("LPWSTR *")] ushort** ppwstrDeviceId);

        [VtblIndex(9)]
        HRESULT GetSignalPath(IPart* pIPartFrom, IPart* pIPartTo, BOOL bRejectMixedPaths, IPartsList** ppParts);
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
        public delegate* unmanaged<TSelf*, uint*, int> GetConnectorCount;

        [NativeTypeName("HRESULT (UINT, IConnector **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IConnector**, int> GetConnector;

        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetSubunitCount;

        [NativeTypeName("HRESULT (UINT, ISubunit **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ISubunit**, int> GetSubunit;

        [NativeTypeName("HRESULT (UINT, IPart **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IPart**, int> GetPartById;

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetDeviceId;

        [NativeTypeName("HRESULT (IPart *, IPart *, BOOL, IPartsList **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IPart*, IPart*, BOOL, IPartsList**, int> GetSignalPath;
    }
}
