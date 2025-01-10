// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/devicetopology.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("9C2C4058-23F5-41DE-877A-DF3AF236A09E")]
[NativeTypeName("struct IConnector : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IConnector : IConnector.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IConnector));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IConnector, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IConnector, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IConnector, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetType(ConnectorType* pType)
    {
        return ((delegate* unmanaged<IConnector, ConnectorType*, int>)((*lpVtbl)[3]))(this, pType);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetDataFlow(DataFlow* pFlow)
    {
        return ((delegate* unmanaged<IConnector, DataFlow*, int>)((*lpVtbl)[4]))(this, pFlow);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT ConnectTo(IConnector pConnectTo)
    {
        return ((delegate* unmanaged<IConnector, IConnector, int>)((*lpVtbl)[5]))(this, pConnectTo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Disconnect()
    {
        return ((delegate* unmanaged<IConnector, int>)((*lpVtbl)[6]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT IsConnected(BOOL* pbConnected)
    {
        return ((delegate* unmanaged<IConnector, BOOL*, int>)((*lpVtbl)[7]))(this, pbConnected);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetConnectedTo(IConnector* ppConTo)
    {
        return ((delegate* unmanaged<IConnector, IConnector*, int>)((*lpVtbl)[8]))(this, ppConTo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetConnectorIdConnectedTo(
        [NativeTypeName("LPWSTR *")] ushort** ppwstrConnectorId
    )
    {
        return ((delegate* unmanaged<IConnector, ushort**, int>)((*lpVtbl)[9]))(
            this,
            ppwstrConnectorId
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetDeviceIdConnectedTo([NativeTypeName("LPWSTR *")] ushort** ppwstrDeviceId)
    {
        return ((delegate* unmanaged<IConnector, ushort**, int>)((*lpVtbl)[10]))(
            this,
            ppwstrDeviceId
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetType(ConnectorType* pType);

        [VtblIndex(4)]
        HRESULT GetDataFlow(DataFlow* pFlow);

        [VtblIndex(5)]
        HRESULT ConnectTo(IConnector pConnectTo);

        [VtblIndex(6)]
        HRESULT Disconnect();

        [VtblIndex(7)]
        HRESULT IsConnected(BOOL* pbConnected);

        [VtblIndex(8)]
        HRESULT GetConnectedTo(IConnector* ppConTo);

        [VtblIndex(9)]
        HRESULT GetConnectorIdConnectedTo([NativeTypeName("LPWSTR *")] ushort** ppwstrConnectorId);

        [VtblIndex(10)]
        HRESULT GetDeviceIdConnectedTo([NativeTypeName("LPWSTR *")] ushort** ppwstrDeviceId);
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

        [NativeTypeName("HRESULT (ConnectorType *) __attribute__((stdcall))")]
        public new delegate* unmanaged<TSelf*, ConnectorType*, int> GetType;

        [NativeTypeName("HRESULT (DataFlow *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DataFlow*, int> GetDataFlow;

        [NativeTypeName("HRESULT (IConnector *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IConnector, int> ConnectTo;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Disconnect;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> IsConnected;

        [NativeTypeName("HRESULT (IConnector **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IConnector*, int> GetConnectedTo;

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetConnectorIdConnectedTo;

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetDeviceIdConnectedTo;
    }

    /// <summary>Initializes a new instance of the <see cref = "IConnector"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IConnector(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IConnector"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IConnector(Silk.NET.Windows.IUnknown value)
    {
        return new IConnector(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IConnector"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IConnector"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IConnector value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
