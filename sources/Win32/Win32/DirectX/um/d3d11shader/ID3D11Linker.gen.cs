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

[Guid("59A6CD0E-E10D-4C1F-88C0-63ABA1DAF30E")]
[NativeTypeName("struct ID3D11Linker : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID3D11Linker : ID3D11Linker.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D11Linker));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID3D11Linker, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ID3D11Linker, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID3D11Linker, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Link(
        [NativeTypeName("struct ID3D11ModuleInstance *")] ID3D11ModuleInstance pEntry,
        [NativeTypeName("LPCSTR")] sbyte* pEntryName,
        [NativeTypeName("LPCSTR")] sbyte* pTargetName,
        uint uFlags,
        ID3DBlob* ppShaderBlob,
        ID3DBlob* ppErrorBuffer
    )
    {
        return (
            (delegate* unmanaged<
                ID3D11Linker,
                ID3D11ModuleInstance,
                sbyte*,
                sbyte*,
                uint,
                ID3DBlob*,
                ID3DBlob*,
                int>)((*lpVtbl)[3])
        )(this, pEntry, pEntryName, pTargetName, uFlags, ppShaderBlob, ppErrorBuffer);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT UseLibrary(
        [NativeTypeName("struct ID3D11ModuleInstance *")] ID3D11ModuleInstance pLibraryMI
    )
    {
        return ((delegate* unmanaged<ID3D11Linker, ID3D11ModuleInstance, int>)((*lpVtbl)[4]))(
            this,
            pLibraryMI
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT AddClipPlaneFromCBuffer(uint uCBufferSlot, uint uCBufferEntry)
    {
        return ((delegate* unmanaged<ID3D11Linker, uint, uint, int>)((*lpVtbl)[5]))(
            this,
            uCBufferSlot,
            uCBufferEntry
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Link(
            [NativeTypeName("struct ID3D11ModuleInstance *")] ID3D11ModuleInstance pEntry,
            [NativeTypeName("LPCSTR")] sbyte* pEntryName,
            [NativeTypeName("LPCSTR")] sbyte* pTargetName,
            uint uFlags,
            ID3DBlob* ppShaderBlob,
            ID3DBlob* ppErrorBuffer
        );

        [VtblIndex(4)]
        HRESULT UseLibrary(
            [NativeTypeName("struct ID3D11ModuleInstance *")] ID3D11ModuleInstance pLibraryMI
        );

        [VtblIndex(5)]
        HRESULT AddClipPlaneFromCBuffer(uint uCBufferSlot, uint uCBufferEntry);
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
            "HRESULT (struct ID3D11ModuleInstance *, LPCSTR, LPCSTR, UINT, ID3DBlob **, ID3DBlob **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID3D11ModuleInstance,
            sbyte*,
            sbyte*,
            uint,
            ID3DBlob*,
            ID3DBlob*,
            int> Link;

        [NativeTypeName(
            "HRESULT (struct ID3D11ModuleInstance *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ID3D11ModuleInstance, int> UseLibrary;

        [NativeTypeName("HRESULT (UINT, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, int> AddClipPlaneFromCBuffer;
    }

    /// <summary>Initializes a new instance of the <see cref = "ID3D11Linker"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D11Linker(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ID3D11Linker"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ID3D11Linker(Silk.NET.Windows.IUnknown value)
    {
        return new ID3D11Linker(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID3D11Linker"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D11Linker"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ID3D11Linker value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
