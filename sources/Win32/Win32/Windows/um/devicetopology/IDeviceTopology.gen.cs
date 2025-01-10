// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/devicetopology.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("2A07407E-6497-4A18-9787-32F79BD0D98F")]
[NativeTypeName("struct IDeviceTopology : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDeviceTopology : IDeviceTopology.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDeviceTopology));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDeviceTopology, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDeviceTopology, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDeviceTopology, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetConnectorCount(uint* pCount)
    {
        return ((delegate* unmanaged<IDeviceTopology, uint*, int>)((*lpVtbl)[3]))(this, pCount);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetConnector(uint nIndex, IConnector* ppConnector)
    {
        return ((delegate* unmanaged<IDeviceTopology, uint, IConnector*, int>)((*lpVtbl)[4]))(
            this,
            nIndex,
            ppConnector
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetSubunitCount(uint* pCount)
    {
        return ((delegate* unmanaged<IDeviceTopology, uint*, int>)((*lpVtbl)[5]))(this, pCount);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetSubunit(uint nIndex, ISubunit* ppSubunit)
    {
        return ((delegate* unmanaged<IDeviceTopology, uint, ISubunit*, int>)((*lpVtbl)[6]))(
            this,
            nIndex,
            ppSubunit
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetPartById(uint nId, IPart* ppPart)
    {
        return ((delegate* unmanaged<IDeviceTopology, uint, IPart*, int>)((*lpVtbl)[7]))(
            this,
            nId,
            ppPart
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetDeviceId([NativeTypeName("LPWSTR *")] ushort** ppwstrDeviceId)
    {
        return ((delegate* unmanaged<IDeviceTopology, ushort**, int>)((*lpVtbl)[8]))(
            this,
            ppwstrDeviceId
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetSignalPath(
        IPart pIPartFrom,
        IPart pIPartTo,
        BOOL bRejectMixedPaths,
        IPartsList* ppParts
    )
    {
        return (
            (delegate* unmanaged<IDeviceTopology, IPart, IPart, BOOL, IPartsList*, int>)(
                (*lpVtbl)[9]
            )
        )(this, pIPartFrom, pIPartTo, bRejectMixedPaths, ppParts);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetConnectorCount(uint* pCount);

        [VtblIndex(4)]
        HRESULT GetConnector(uint nIndex, IConnector* ppConnector);

        [VtblIndex(5)]
        HRESULT GetSubunitCount(uint* pCount);

        [VtblIndex(6)]
        HRESULT GetSubunit(uint nIndex, ISubunit* ppSubunit);

        [VtblIndex(7)]
        HRESULT GetPartById(uint nId, IPart* ppPart);

        [VtblIndex(8)]
        HRESULT GetDeviceId([NativeTypeName("LPWSTR *")] ushort** ppwstrDeviceId);

        [VtblIndex(9)]
        HRESULT GetSignalPath(
            IPart pIPartFrom,
            IPart pIPartTo,
            BOOL bRejectMixedPaths,
            IPartsList* ppParts
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

        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetConnectorCount;

        [NativeTypeName("HRESULT (UINT, IConnector **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IConnector*, int> GetConnector;

        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetSubunitCount;

        [NativeTypeName("HRESULT (UINT, ISubunit **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ISubunit*, int> GetSubunit;

        [NativeTypeName("HRESULT (UINT, IPart **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IPart*, int> GetPartById;

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetDeviceId;

        [NativeTypeName("HRESULT (IPart *, IPart *, BOOL, IPartsList **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IPart, IPart, BOOL, IPartsList*, int> GetSignalPath;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDeviceTopology"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDeviceTopology(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDeviceTopology"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDeviceTopology(Silk.NET.Windows.IUnknown value)
    {
        return new IDeviceTopology(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDeviceTopology"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDeviceTopology"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDeviceTopology value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
