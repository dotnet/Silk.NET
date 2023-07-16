// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dxcapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the University of Illinois Open Source License.
using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;
/// <include file='IDxcCompiler3.xml' path='doc/member[@name="IDxcCompiler3"]/*'/>
[Guid("228B4687-5A6A-4730-900C-9702B2203F54")]
[NativeTypeName("struct IDxcCompiler3 : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDxcCompiler3 : IDxcCompiler3.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDxcCompiler3));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDxcCompiler3*, Guid*, void**, int> )(lpVtbl[0]))((IDxcCompiler3*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDxcCompiler3*, uint> )(lpVtbl[1]))((IDxcCompiler3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDxcCompiler3*, uint> )(lpVtbl[2]))((IDxcCompiler3*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDxcCompiler3.xml' path='doc/member[@name="IDxcCompiler3.Compile"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Compile([NativeTypeName("const DxcBuffer *")] DxcBuffer* pSource, [NativeTypeName("LPCWSTR *")] ushort** pArguments, [NativeTypeName("UINT32")] uint argCount, IDxcIncludeHandler* pIncludeHandler, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppResult)
    {
        return ((delegate* unmanaged<IDxcCompiler3*, DxcBuffer*, ushort**, uint, IDxcIncludeHandler*, Guid*, void**, int> )(lpVtbl[3]))((IDxcCompiler3*)Unsafe.AsPointer(ref this), pSource, pArguments, argCount, pIncludeHandler, riid, ppResult);
    }

    /// <include file='IDxcCompiler3.xml' path='doc/member[@name="IDxcCompiler3.Disassemble"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Disassemble([NativeTypeName("const DxcBuffer *")] DxcBuffer* pObject, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppResult)
    {
        return ((delegate* unmanaged<IDxcCompiler3*, DxcBuffer*, Guid*, void**, int> )(lpVtbl[4]))((IDxcCompiler3*)Unsafe.AsPointer(ref this), pObject, riid, ppResult);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Compile([NativeTypeName("const DxcBuffer *")] DxcBuffer* pSource, [NativeTypeName("LPCWSTR *")] ushort** pArguments, [NativeTypeName("UINT32")] uint argCount, IDxcIncludeHandler* pIncludeHandler, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppResult);
        [VtblIndex(4)]
        HRESULT Disassemble([NativeTypeName("const DxcBuffer *")] DxcBuffer* pObject, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppResult);
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
        [NativeTypeName("HRESULT (const DxcBuffer *, LPCWSTR *, UINT32, IDxcIncludeHandler *, const IID &, LPVOID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DxcBuffer*, ushort**, uint, IDxcIncludeHandler*, Guid*, void**, int> Compile;
        [NativeTypeName("HRESULT (const DxcBuffer *, const IID &, LPVOID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DxcBuffer*, Guid*, void**, int> Disassemble;
    }
}