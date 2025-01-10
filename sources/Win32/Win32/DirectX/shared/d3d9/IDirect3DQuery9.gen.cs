// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("D9771460-A695-4F26-BBD3-27B840B541CC")]
[NativeTypeName("struct IDirect3DQuery9 : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDirect3DQuery9 : IDirect3DQuery9.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDirect3DQuery9));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDirect3DQuery9, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDirect3DQuery9, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDirect3DQuery9, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetDevice(IDirect3DDevice9* ppDevice)
    {
        return ((delegate* unmanaged<IDirect3DQuery9, IDirect3DDevice9*, int>)((*lpVtbl)[3]))(
            this,
            ppDevice
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public new D3DQUERYTYPE GetType()
    {
        return ((delegate* unmanaged<IDirect3DQuery9, D3DQUERYTYPE>)((*lpVtbl)[4]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    [return: NativeTypeName("DWORD")]
    public uint GetDataSize()
    {
        return ((delegate* unmanaged<IDirect3DQuery9, uint>)((*lpVtbl)[5]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Issue([NativeTypeName("DWORD")] uint dwIssueFlags)
    {
        return ((delegate* unmanaged<IDirect3DQuery9, uint, int>)((*lpVtbl)[6]))(
            this,
            dwIssueFlags
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetData(
        void* pData,
        [NativeTypeName("DWORD")] uint dwSize,
        [NativeTypeName("DWORD")] uint dwGetDataFlags
    )
    {
        return ((delegate* unmanaged<IDirect3DQuery9, void*, uint, uint, int>)((*lpVtbl)[7]))(
            this,
            pData,
            dwSize,
            dwGetDataFlags
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetDevice(IDirect3DDevice9* ppDevice);

        [VtblIndex(4)]
        D3DQUERYTYPE GetType();

        [VtblIndex(5)]
        [return: NativeTypeName("DWORD")]
        uint GetDataSize();

        [VtblIndex(6)]
        HRESULT Issue([NativeTypeName("DWORD")] uint dwIssueFlags);

        [VtblIndex(7)]
        HRESULT GetData(
            void* pData,
            [NativeTypeName("DWORD")] uint dwSize,
            [NativeTypeName("DWORD")] uint dwGetDataFlags
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
            "HRESULT (IDirect3DDevice9 **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDirect3DDevice9*, int> GetDevice;

        [NativeTypeName("D3DQUERYTYPE () __attribute__((nothrow)) __attribute__((stdcall))")]
        public new delegate* unmanaged<TSelf*, D3DQUERYTYPE> GetType;

        [NativeTypeName("DWORD () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> GetDataSize;

        [NativeTypeName("HRESULT (DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> Issue;

        [NativeTypeName(
            "HRESULT (void *, DWORD, DWORD) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, void*, uint, uint, int> GetData;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDirect3DQuery9"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDirect3DQuery9(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDirect3DQuery9"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDirect3DQuery9(Silk.NET.Windows.IUnknown value)
    {
        return new IDirect3DQuery9(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDirect3DQuery9"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDirect3DQuery9"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDirect3DQuery9 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
