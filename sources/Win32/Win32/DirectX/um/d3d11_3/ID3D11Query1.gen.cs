// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11_3.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("631B4766-36DC-461D-8DB6-C47E13E60916")]
[NativeTypeName("struct ID3D11Query1 : ID3D11Query")]
[NativeInheritance("ID3D11Query")]
[SupportedOSPlatform("windows10.0")]
public unsafe partial struct ID3D11Query1 : ID3D11Query1.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D11Query1));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID3D11Query1, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ID3D11Query1, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID3D11Query1, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void GetDevice(ID3D11Device* ppDevice)
    {
        ((delegate* unmanaged<ID3D11Query1, ID3D11Device*, void>)((*lpVtbl)[3]))(this, ppDevice);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetPrivateData(
        [NativeTypeName("const GUID &")] Guid* guid,
        uint* pDataSize,
        void* pData
    )
    {
        return ((delegate* unmanaged<ID3D11Query1, Guid*, uint*, void*, int>)((*lpVtbl)[4]))(
            this,
            guid,
            pDataSize,
            pData
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetPrivateData(
        [NativeTypeName("const GUID &")] Guid* guid,
        uint DataSize,
        [NativeTypeName("const void *")] void* pData
    )
    {
        return ((delegate* unmanaged<ID3D11Query1, Guid*, uint, void*, int>)((*lpVtbl)[5]))(
            this,
            guid,
            DataSize,
            pData
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetPrivateDataInterface(
        [NativeTypeName("const GUID &")] Guid* guid,
        [NativeTypeName("const IUnknown *")] IUnknown pData
    )
    {
        return ((delegate* unmanaged<ID3D11Query1, Guid*, IUnknown, int>)((*lpVtbl)[6]))(
            this,
            guid,
            pData
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public uint GetDataSize()
    {
        return ((delegate* unmanaged<ID3D11Query1, uint>)((*lpVtbl)[7]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public void GetDesc(D3D11_QUERY_DESC* pDesc)
    {
        ((delegate* unmanaged<ID3D11Query1, D3D11_QUERY_DESC*, void>)((*lpVtbl)[8]))(this, pDesc);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public void GetDesc1(D3D11_QUERY_DESC1* pDesc1)
    {
        ((delegate* unmanaged<ID3D11Query1, D3D11_QUERY_DESC1*, void>)((*lpVtbl)[9]))(this, pDesc1);
    }

    public interface Interface : ID3D11Query.Interface
    {
        [VtblIndex(9)]
        void GetDesc1(D3D11_QUERY_DESC1* pDesc1);
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

        [NativeTypeName("void (ID3D11Device **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11Device*, void> GetDevice;

        [NativeTypeName("HRESULT (const GUID &, UINT *, void *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, uint*, void*, int> GetPrivateData;

        [NativeTypeName("HRESULT (const GUID &, UINT, const void *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, uint, void*, int> SetPrivateData;

        [NativeTypeName("HRESULT (const GUID &, const IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, IUnknown, int> SetPrivateDataInterface;

        [NativeTypeName("UINT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> GetDataSize;

        [NativeTypeName("void (D3D11_QUERY_DESC *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D11_QUERY_DESC*, void> GetDesc;

        [NativeTypeName("void (D3D11_QUERY_DESC1 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D11_QUERY_DESC1*, void> GetDesc1;
    }

    /// <summary>Initializes a new instance of the <see cref = "ID3D11Query1"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D11Query1(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.ID3D11Query"/> to <see cref = "ID3D11Query1"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.ID3D11Query"/> instance to be converted </param>
    public static explicit operator ID3D11Query1(Silk.NET.DirectX.ID3D11Query value)
    {
        return new ID3D11Query1(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID3D11Query1"/> to <see cref = "Silk.NET.DirectX.ID3D11Query"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D11Query1"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.ID3D11Query(ID3D11Query1 value)
    {
        return new Silk.NET.DirectX.ID3D11Query(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.ID3D11Asynchronous"/> to <see cref = "ID3D11Query1"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.ID3D11Asynchronous"/> instance to be converted </param>
    public static explicit operator ID3D11Query1(Silk.NET.DirectX.ID3D11Asynchronous value)
    {
        return new ID3D11Query1(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID3D11Query1"/> to <see cref = "Silk.NET.DirectX.ID3D11Asynchronous"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D11Query1"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.ID3D11Asynchronous(ID3D11Query1 value)
    {
        return new Silk.NET.DirectX.ID3D11Asynchronous(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.ID3D11DeviceChild"/> to <see cref = "ID3D11Query1"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.ID3D11DeviceChild"/> instance to be converted </param>
    public static explicit operator ID3D11Query1(Silk.NET.DirectX.ID3D11DeviceChild value)
    {
        return new ID3D11Query1(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID3D11Query1"/> to <see cref = "Silk.NET.DirectX.ID3D11DeviceChild"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D11Query1"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.ID3D11DeviceChild(ID3D11Query1 value)
    {
        return new Silk.NET.DirectX.ID3D11DeviceChild(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ID3D11Query1"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ID3D11Query1(Silk.NET.Windows.IUnknown value)
    {
        return new ID3D11Query1(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID3D11Query1"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D11Query1"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ID3D11Query1 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
