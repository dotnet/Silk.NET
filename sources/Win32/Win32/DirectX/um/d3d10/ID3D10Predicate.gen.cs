// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d10.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("9B7E4C10-342C-4106-A19F-4F2704F689F0")]
[NativeTypeName("struct ID3D10Predicate : ID3D10Query")]
[NativeInheritance("ID3D10Query")]
public unsafe partial struct ID3D10Predicate : ID3D10Predicate.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D10Predicate));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID3D10Predicate, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ID3D10Predicate, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID3D10Predicate, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void GetDevice(ID3D10Device* ppDevice)
    {
        ((delegate* unmanaged<ID3D10Predicate, ID3D10Device*, void>)((*lpVtbl)[3]))(this, ppDevice);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetPrivateData(
        [NativeTypeName("const GUID &")] Guid* guid,
        uint* pDataSize,
        void* pData
    )
    {
        return ((delegate* unmanaged<ID3D10Predicate, Guid*, uint*, void*, int>)((*lpVtbl)[4]))(
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
        return ((delegate* unmanaged<ID3D10Predicate, Guid*, uint, void*, int>)((*lpVtbl)[5]))(
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
        return ((delegate* unmanaged<ID3D10Predicate, Guid*, IUnknown, int>)((*lpVtbl)[6]))(
            this,
            guid,
            pData
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public void Begin()
    {
        ((delegate* unmanaged<ID3D10Predicate, void>)((*lpVtbl)[7]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public void End()
    {
        ((delegate* unmanaged<ID3D10Predicate, void>)((*lpVtbl)[8]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetData(void* pData, uint DataSize, uint GetDataFlags)
    {
        return ((delegate* unmanaged<ID3D10Predicate, void*, uint, uint, int>)((*lpVtbl)[9]))(
            this,
            pData,
            DataSize,
            GetDataFlags
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public uint GetDataSize()
    {
        return ((delegate* unmanaged<ID3D10Predicate, uint>)((*lpVtbl)[10]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public void GetDesc(D3D10_QUERY_DESC* pDesc)
    {
        ((delegate* unmanaged<ID3D10Predicate, D3D10_QUERY_DESC*, void>)((*lpVtbl)[11]))(
            this,
            pDesc
        );
    }

    public interface Interface : ID3D10Query.Interface { }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> Release;

        [NativeTypeName("void (ID3D10Device **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D10Device*, void> GetDevice;

        [NativeTypeName("HRESULT (const GUID &, UINT *, void *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, uint*, void*, int> GetPrivateData;

        [NativeTypeName("HRESULT (const GUID &, UINT, const void *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, uint, void*, int> SetPrivateData;

        [NativeTypeName("HRESULT (const GUID &, const IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, IUnknown, int> SetPrivateDataInterface;

        [NativeTypeName("void () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void> Begin;

        [NativeTypeName("void () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void> End;

        [NativeTypeName("HRESULT (void *, UINT, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void*, uint, uint, int> GetData;

        [NativeTypeName("UINT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> GetDataSize;

        [NativeTypeName("void (D3D10_QUERY_DESC *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D10_QUERY_DESC*, void> GetDesc;
    }

    /// <summary>Initializes a new instance of the <see cref = "ID3D10Predicate"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D10Predicate(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.ID3D10Query"/> to <see cref = "ID3D10Predicate"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.ID3D10Query"/> instance to be converted </param>
    public static explicit operator ID3D10Predicate(Silk.NET.DirectX.ID3D10Query value)
    {
        return new ID3D10Predicate(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID3D10Predicate"/> to <see cref = "Silk.NET.DirectX.ID3D10Query"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D10Predicate"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.ID3D10Query(ID3D10Predicate value)
    {
        return new Silk.NET.DirectX.ID3D10Query(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.ID3D10Asynchronous"/> to <see cref = "ID3D10Predicate"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.ID3D10Asynchronous"/> instance to be converted </param>
    public static explicit operator ID3D10Predicate(Silk.NET.DirectX.ID3D10Asynchronous value)
    {
        return new ID3D10Predicate(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID3D10Predicate"/> to <see cref = "Silk.NET.DirectX.ID3D10Asynchronous"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D10Predicate"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.ID3D10Asynchronous(ID3D10Predicate value)
    {
        return new Silk.NET.DirectX.ID3D10Asynchronous(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.ID3D10DeviceChild"/> to <see cref = "ID3D10Predicate"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.ID3D10DeviceChild"/> instance to be converted </param>
    public static explicit operator ID3D10Predicate(Silk.NET.DirectX.ID3D10DeviceChild value)
    {
        return new ID3D10Predicate(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID3D10Predicate"/> to <see cref = "Silk.NET.DirectX.ID3D10DeviceChild"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D10Predicate"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.ID3D10DeviceChild(ID3D10Predicate value)
    {
        return new Silk.NET.DirectX.ID3D10DeviceChild(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ID3D10Predicate"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ID3D10Predicate(Silk.NET.Windows.IUnknown value)
    {
        return new ID3D10Predicate(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID3D10Predicate"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D10Predicate"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ID3D10Predicate value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
