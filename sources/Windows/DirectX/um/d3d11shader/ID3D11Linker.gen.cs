// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11shader.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;

/// <include file='ID3D11Linker.xml' path='doc/member[@name="ID3D11Linker"]/*' />
[Guid("59A6CD0E-E10D-4C1F-88C0-63ABA1DAF30E")]
[NativeTypeName("struct ID3D11Linker : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID3D11Linker : ID3D11Linker.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D11Linker));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID3D11Linker*, Guid*, void**, int>)(lpVtbl[0]))((ID3D11Linker*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ID3D11Linker*, uint>)(lpVtbl[1]))((ID3D11Linker*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID3D11Linker*, uint>)(lpVtbl[2]))((ID3D11Linker*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3D11Linker.xml' path='doc/member[@name="ID3D11Linker.Link"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Link([NativeTypeName("struct ID3D11ModuleInstance *")] ID3D11ModuleInstance* pEntry, [NativeTypeName("LPCSTR")] sbyte* pEntryName, [NativeTypeName("LPCSTR")] sbyte* pTargetName, uint uFlags, ID3DBlob** ppShaderBlob, ID3DBlob** ppErrorBuffer)
    {
        return ((delegate* unmanaged<ID3D11Linker*, ID3D11ModuleInstance*, sbyte*, sbyte*, uint, ID3DBlob**, ID3DBlob**, int>)(lpVtbl[3]))((ID3D11Linker*)Unsafe.AsPointer(ref this), pEntry, pEntryName, pTargetName, uFlags, ppShaderBlob, ppErrorBuffer);
    }

    /// <include file='ID3D11Linker.xml' path='doc/member[@name="ID3D11Linker.UseLibrary"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT UseLibrary([NativeTypeName("struct ID3D11ModuleInstance *")] ID3D11ModuleInstance* pLibraryMI)
    {
        return ((delegate* unmanaged<ID3D11Linker*, ID3D11ModuleInstance*, int>)(lpVtbl[4]))((ID3D11Linker*)Unsafe.AsPointer(ref this), pLibraryMI);
    }

    /// <include file='ID3D11Linker.xml' path='doc/member[@name="ID3D11Linker.AddClipPlaneFromCBuffer"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT AddClipPlaneFromCBuffer(uint uCBufferSlot, uint uCBufferEntry)
    {
        return ((delegate* unmanaged<ID3D11Linker*, uint, uint, int>)(lpVtbl[5]))((ID3D11Linker*)Unsafe.AsPointer(ref this), uCBufferSlot, uCBufferEntry);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Link([NativeTypeName("struct ID3D11ModuleInstance *")] ID3D11ModuleInstance* pEntry, [NativeTypeName("LPCSTR")] sbyte* pEntryName, [NativeTypeName("LPCSTR")] sbyte* pTargetName, uint uFlags, ID3DBlob** ppShaderBlob, ID3DBlob** ppErrorBuffer);

        [VtblIndex(4)]
        HRESULT UseLibrary([NativeTypeName("struct ID3D11ModuleInstance *")] ID3D11ModuleInstance* pLibraryMI);

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

        [NativeTypeName("HRESULT (struct ID3D11ModuleInstance *, LPCSTR, LPCSTR, UINT, ID3DBlob **, ID3DBlob **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11ModuleInstance*, sbyte*, sbyte*, uint, ID3DBlob**, ID3DBlob**, int> Link;

        [NativeTypeName("HRESULT (struct ID3D11ModuleInstance *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11ModuleInstance*, int> UseLibrary;

        [NativeTypeName("HRESULT (UINT, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, int> AddClipPlaneFromCBuffer;
    }
}
