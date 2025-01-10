// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11shader.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("469E07F7-045A-48D5-AA12-68A478CDF75D")]
[NativeTypeName("struct ID3D11ModuleInstance : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID3D11ModuleInstance : ID3D11ModuleInstance.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D11ModuleInstance));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID3D11ModuleInstance, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ID3D11ModuleInstance, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID3D11ModuleInstance, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT BindConstantBuffer(uint uSrcSlot, uint uDstSlot, uint cbDstOffset)
    {
        return ((delegate* unmanaged<ID3D11ModuleInstance, uint, uint, uint, int>)((*lpVtbl)[3]))(
            this,
            uSrcSlot,
            uDstSlot,
            cbDstOffset
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT BindConstantBufferByName(
        [NativeTypeName("LPCSTR")] sbyte* pName,
        uint uDstSlot,
        uint cbDstOffset
    )
    {
        return ((delegate* unmanaged<ID3D11ModuleInstance, sbyte*, uint, uint, int>)((*lpVtbl)[4]))(
            this,
            pName,
            uDstSlot,
            cbDstOffset
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT BindResource(uint uSrcSlot, uint uDstSlot, uint uCount)
    {
        return ((delegate* unmanaged<ID3D11ModuleInstance, uint, uint, uint, int>)((*lpVtbl)[5]))(
            this,
            uSrcSlot,
            uDstSlot,
            uCount
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT BindResourceByName(
        [NativeTypeName("LPCSTR")] sbyte* pName,
        uint uDstSlot,
        uint uCount
    )
    {
        return ((delegate* unmanaged<ID3D11ModuleInstance, sbyte*, uint, uint, int>)((*lpVtbl)[6]))(
            this,
            pName,
            uDstSlot,
            uCount
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT BindSampler(uint uSrcSlot, uint uDstSlot, uint uCount)
    {
        return ((delegate* unmanaged<ID3D11ModuleInstance, uint, uint, uint, int>)((*lpVtbl)[7]))(
            this,
            uSrcSlot,
            uDstSlot,
            uCount
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT BindSamplerByName(
        [NativeTypeName("LPCSTR")] sbyte* pName,
        uint uDstSlot,
        uint uCount
    )
    {
        return ((delegate* unmanaged<ID3D11ModuleInstance, sbyte*, uint, uint, int>)((*lpVtbl)[8]))(
            this,
            pName,
            uDstSlot,
            uCount
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT BindUnorderedAccessView(uint uSrcSlot, uint uDstSlot, uint uCount)
    {
        return ((delegate* unmanaged<ID3D11ModuleInstance, uint, uint, uint, int>)((*lpVtbl)[9]))(
            this,
            uSrcSlot,
            uDstSlot,
            uCount
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT BindUnorderedAccessViewByName(
        [NativeTypeName("LPCSTR")] sbyte* pName,
        uint uDstSlot,
        uint uCount
    )
    {
        return (
            (delegate* unmanaged<ID3D11ModuleInstance, sbyte*, uint, uint, int>)((*lpVtbl)[10])
        )(this, pName, uDstSlot, uCount);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT BindResourceAsUnorderedAccessView(
        uint uSrcSrvSlot,
        uint uDstUavSlot,
        uint uCount
    )
    {
        return ((delegate* unmanaged<ID3D11ModuleInstance, uint, uint, uint, int>)((*lpVtbl)[11]))(
            this,
            uSrcSrvSlot,
            uDstUavSlot,
            uCount
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT BindResourceAsUnorderedAccessViewByName(
        [NativeTypeName("LPCSTR")] sbyte* pSrvName,
        uint uDstUavSlot,
        uint uCount
    )
    {
        return (
            (delegate* unmanaged<ID3D11ModuleInstance, sbyte*, uint, uint, int>)((*lpVtbl)[12])
        )(this, pSrvName, uDstUavSlot, uCount);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT BindConstantBuffer(uint uSrcSlot, uint uDstSlot, uint cbDstOffset);

        [VtblIndex(4)]
        HRESULT BindConstantBufferByName(
            [NativeTypeName("LPCSTR")] sbyte* pName,
            uint uDstSlot,
            uint cbDstOffset
        );

        [VtblIndex(5)]
        HRESULT BindResource(uint uSrcSlot, uint uDstSlot, uint uCount);

        [VtblIndex(6)]
        HRESULT BindResourceByName(
            [NativeTypeName("LPCSTR")] sbyte* pName,
            uint uDstSlot,
            uint uCount
        );

        [VtblIndex(7)]
        HRESULT BindSampler(uint uSrcSlot, uint uDstSlot, uint uCount);

        [VtblIndex(8)]
        HRESULT BindSamplerByName(
            [NativeTypeName("LPCSTR")] sbyte* pName,
            uint uDstSlot,
            uint uCount
        );

        [VtblIndex(9)]
        HRESULT BindUnorderedAccessView(uint uSrcSlot, uint uDstSlot, uint uCount);

        [VtblIndex(10)]
        HRESULT BindUnorderedAccessViewByName(
            [NativeTypeName("LPCSTR")] sbyte* pName,
            uint uDstSlot,
            uint uCount
        );

        [VtblIndex(11)]
        HRESULT BindResourceAsUnorderedAccessView(uint uSrcSrvSlot, uint uDstUavSlot, uint uCount);

        [VtblIndex(12)]
        HRESULT BindResourceAsUnorderedAccessViewByName(
            [NativeTypeName("LPCSTR")] sbyte* pSrvName,
            uint uDstUavSlot,
            uint uCount
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

        [NativeTypeName(
            "HRESULT (UINT, UINT, UINT) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, uint, uint, int> BindConstantBuffer;

        [NativeTypeName(
            "HRESULT (LPCSTR, UINT, UINT) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, sbyte*, uint, uint, int> BindConstantBufferByName;

        [NativeTypeName(
            "HRESULT (UINT, UINT, UINT) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, uint, uint, int> BindResource;

        [NativeTypeName(
            "HRESULT (LPCSTR, UINT, UINT) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, sbyte*, uint, uint, int> BindResourceByName;

        [NativeTypeName(
            "HRESULT (UINT, UINT, UINT) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, uint, uint, int> BindSampler;

        [NativeTypeName(
            "HRESULT (LPCSTR, UINT, UINT) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, sbyte*, uint, uint, int> BindSamplerByName;

        [NativeTypeName(
            "HRESULT (UINT, UINT, UINT) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, uint, uint, int> BindUnorderedAccessView;

        [NativeTypeName(
            "HRESULT (LPCSTR, UINT, UINT) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, sbyte*, uint, uint, int> BindUnorderedAccessViewByName;

        [NativeTypeName(
            "HRESULT (UINT, UINT, UINT) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, uint, uint, int> BindResourceAsUnorderedAccessView;

        [NativeTypeName(
            "HRESULT (LPCSTR, UINT, UINT) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            sbyte*,
            uint,
            uint,
            int> BindResourceAsUnorderedAccessViewByName;
    }

    /// <summary>Initializes a new instance of the <see cref = "ID3D11ModuleInstance"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D11ModuleInstance(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ID3D11ModuleInstance"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ID3D11ModuleInstance(Silk.NET.Windows.IUnknown value)
    {
        return new ID3D11ModuleInstance(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID3D11ModuleInstance"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D11ModuleInstance"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ID3D11ModuleInstance value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
