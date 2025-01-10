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

[Guid("CAC701EE-80FC-4122-8242-10B39C8CEC34")]
[NativeTypeName("struct ID3D11Module : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID3D11Module : ID3D11Module.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D11Module));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID3D11Module, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ID3D11Module, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID3D11Module, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CreateInstance(
        [NativeTypeName("LPCSTR")] sbyte* pNamespace,
        [NativeTypeName("struct ID3D11ModuleInstance **")] ID3D11ModuleInstance* ppModuleInstance
    )
    {
        return (
            (delegate* unmanaged<ID3D11Module, sbyte*, ID3D11ModuleInstance*, int>)((*lpVtbl)[3])
        )(this, pNamespace, ppModuleInstance);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT CreateInstance(
            [NativeTypeName("LPCSTR")] sbyte* pNamespace,
            [NativeTypeName("struct ID3D11ModuleInstance **")]
                ID3D11ModuleInstance* ppModuleInstance
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
            "HRESULT (LPCSTR, struct ID3D11ModuleInstance **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, sbyte*, ID3D11ModuleInstance*, int> CreateInstance;
    }

    /// <summary>Initializes a new instance of the <see cref = "ID3D11Module"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D11Module(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ID3D11Module"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ID3D11Module(Silk.NET.Windows.IUnknown value)
    {
        return new ID3D11Module(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID3D11Module"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D11Module"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ID3D11Module value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
