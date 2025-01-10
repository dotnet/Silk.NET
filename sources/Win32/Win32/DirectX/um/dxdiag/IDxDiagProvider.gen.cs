// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dxdiag.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("9C6B4CB0-23F8-49CC-A3ED-45A55000A6D2")]
[NativeTypeName("struct IDxDiagProvider : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDxDiagProvider : IDxDiagProvider.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDxDiagProvider));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDxDiagProvider, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDxDiagProvider, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDxDiagProvider, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Initialize(DXDIAG_INIT_PARAMS* pParams)
    {
        return ((delegate* unmanaged<IDxDiagProvider, DXDIAG_INIT_PARAMS*, int>)((*lpVtbl)[3]))(
            this,
            pParams
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRootContainer(
        [NativeTypeName("struct IDxDiagContainer **")] IDxDiagContainer* ppInstance
    )
    {
        return ((delegate* unmanaged<IDxDiagProvider, IDxDiagContainer*, int>)((*lpVtbl)[4]))(
            this,
            ppInstance
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Initialize(DXDIAG_INIT_PARAMS* pParams);

        [VtblIndex(4)]
        HRESULT GetRootContainer(
            [NativeTypeName("struct IDxDiagContainer **")] IDxDiagContainer* ppInstance
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
            "HRESULT (DXDIAG_INIT_PARAMS *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, DXDIAG_INIT_PARAMS*, int> Initialize;

        [NativeTypeName(
            "HRESULT (struct IDxDiagContainer **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDxDiagContainer*, int> GetRootContainer;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDxDiagProvider"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDxDiagProvider(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDxDiagProvider"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDxDiagProvider(Silk.NET.Windows.IUnknown value)
    {
        return new IDxDiagProvider(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDxDiagProvider"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDxDiagProvider"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDxDiagProvider value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
