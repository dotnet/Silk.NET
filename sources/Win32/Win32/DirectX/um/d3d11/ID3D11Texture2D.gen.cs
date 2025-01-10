// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("6F15AAF2-D208-4E89-9AB4-489535D34F9C")]
[NativeTypeName("struct ID3D11Texture2D : ID3D11Resource")]
[NativeInheritance("ID3D11Resource")]
public unsafe partial struct ID3D11Texture2D : ID3D11Texture2D.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D11Texture2D));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID3D11Texture2D, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ID3D11Texture2D, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID3D11Texture2D, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void GetDevice(ID3D11Device* ppDevice)
    {
        ((delegate* unmanaged<ID3D11Texture2D, ID3D11Device*, void>)((*lpVtbl)[3]))(this, ppDevice);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetPrivateData(
        [NativeTypeName("const GUID &")] Guid* guid,
        uint* pDataSize,
        void* pData
    )
    {
        return ((delegate* unmanaged<ID3D11Texture2D, Guid*, uint*, void*, int>)((*lpVtbl)[4]))(
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
        return ((delegate* unmanaged<ID3D11Texture2D, Guid*, uint, void*, int>)((*lpVtbl)[5]))(
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
        return ((delegate* unmanaged<ID3D11Texture2D, Guid*, IUnknown, int>)((*lpVtbl)[6]))(
            this,
            guid,
            pData
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public void GetType(D3D11_RESOURCE_DIMENSION* pResourceDimension)
    {
        ((delegate* unmanaged<ID3D11Texture2D, D3D11_RESOURCE_DIMENSION*, void>)((*lpVtbl)[7]))(
            this,
            pResourceDimension
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public void SetEvictionPriority(uint EvictionPriority)
    {
        ((delegate* unmanaged<ID3D11Texture2D, uint, void>)((*lpVtbl)[8]))(this, EvictionPriority);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public uint GetEvictionPriority()
    {
        return ((delegate* unmanaged<ID3D11Texture2D, uint>)((*lpVtbl)[9]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public void GetDesc(D3D11_TEXTURE2D_DESC* pDesc)
    {
        ((delegate* unmanaged<ID3D11Texture2D, D3D11_TEXTURE2D_DESC*, void>)((*lpVtbl)[10]))(
            this,
            pDesc
        );
    }

    public interface Interface : ID3D11Resource.Interface
    {
        [VtblIndex(10)]
        void GetDesc(D3D11_TEXTURE2D_DESC* pDesc);
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

        [NativeTypeName("void (D3D11_RESOURCE_DIMENSION *) __attribute__((stdcall))")]
        public new delegate* unmanaged<TSelf*, D3D11_RESOURCE_DIMENSION*, void> GetType;

        [NativeTypeName("void (UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, void> SetEvictionPriority;

        [NativeTypeName("UINT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> GetEvictionPriority;

        [NativeTypeName("void (D3D11_TEXTURE2D_DESC *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D11_TEXTURE2D_DESC*, void> GetDesc;
    }

    /// <summary>Initializes a new instance of the <see cref = "ID3D11Texture2D"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D11Texture2D(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.ID3D11Resource"/> to <see cref = "ID3D11Texture2D"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.ID3D11Resource"/> instance to be converted </param>
    public static explicit operator ID3D11Texture2D(Silk.NET.DirectX.ID3D11Resource value)
    {
        return new ID3D11Texture2D(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID3D11Texture2D"/> to <see cref = "Silk.NET.DirectX.ID3D11Resource"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D11Texture2D"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.ID3D11Resource(ID3D11Texture2D value)
    {
        return new Silk.NET.DirectX.ID3D11Resource(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.ID3D11DeviceChild"/> to <see cref = "ID3D11Texture2D"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.ID3D11DeviceChild"/> instance to be converted </param>
    public static explicit operator ID3D11Texture2D(Silk.NET.DirectX.ID3D11DeviceChild value)
    {
        return new ID3D11Texture2D(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID3D11Texture2D"/> to <see cref = "Silk.NET.DirectX.ID3D11DeviceChild"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D11Texture2D"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.ID3D11DeviceChild(ID3D11Texture2D value)
    {
        return new Silk.NET.DirectX.ID3D11DeviceChild(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ID3D11Texture2D"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ID3D11Texture2D(Silk.NET.Windows.IUnknown value)
    {
        return new ID3D11Texture2D(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID3D11Texture2D"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D11Texture2D"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ID3D11Texture2D value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
