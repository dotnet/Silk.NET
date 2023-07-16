// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dxcapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the University of Illinois Open Source License.
using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;
/// <include file='IDxcCompilerArgs.xml' path='doc/member[@name="IDxcCompilerArgs"]/*'/>
[Guid("73EFFE2A-70DC-45F8-9690-EFF64C02429D")]
[NativeTypeName("struct IDxcCompilerArgs : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDxcCompilerArgs : IDxcCompilerArgs.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDxcCompilerArgs));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDxcCompilerArgs*, Guid*, void**, int> )(lpVtbl[0]))((IDxcCompilerArgs*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDxcCompilerArgs*, uint> )(lpVtbl[1]))((IDxcCompilerArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDxcCompilerArgs*, uint> )(lpVtbl[2]))((IDxcCompilerArgs*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDxcCompilerArgs.xml' path='doc/member[@name="IDxcCompilerArgs.GetArguments"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    [return: NativeTypeName("LPCWSTR *")]
    public ushort** GetArguments()
    {
        return ((delegate* unmanaged<IDxcCompilerArgs*, ushort**> )(lpVtbl[3]))((IDxcCompilerArgs*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDxcCompilerArgs.xml' path='doc/member[@name="IDxcCompilerArgs.GetCount"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    [return: NativeTypeName("UINT32")]
    public uint GetCount()
    {
        return ((delegate* unmanaged<IDxcCompilerArgs*, uint> )(lpVtbl[4]))((IDxcCompilerArgs*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDxcCompilerArgs.xml' path='doc/member[@name="IDxcCompilerArgs.AddArguments"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT AddArguments([NativeTypeName("LPCWSTR *")] ushort** pArguments, [NativeTypeName("UINT32")] uint argCount)
    {
        return ((delegate* unmanaged<IDxcCompilerArgs*, ushort**, uint, int> )(lpVtbl[5]))((IDxcCompilerArgs*)Unsafe.AsPointer(ref this), pArguments, argCount);
    }

    /// <include file='IDxcCompilerArgs.xml' path='doc/member[@name="IDxcCompilerArgs.AddArgumentsUTF8"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT AddArgumentsUTF8([NativeTypeName("LPCSTR *")] sbyte** pArguments, [NativeTypeName("UINT32")] uint argCount)
    {
        return ((delegate* unmanaged<IDxcCompilerArgs*, sbyte**, uint, int> )(lpVtbl[6]))((IDxcCompilerArgs*)Unsafe.AsPointer(ref this), pArguments, argCount);
    }

    /// <include file='IDxcCompilerArgs.xml' path='doc/member[@name="IDxcCompilerArgs.AddDefines"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT AddDefines([NativeTypeName("const DxcDefine *")] DxcDefine* pDefines, [NativeTypeName("UINT32")] uint defineCount)
    {
        return ((delegate* unmanaged<IDxcCompilerArgs*, DxcDefine*, uint, int> )(lpVtbl[7]))((IDxcCompilerArgs*)Unsafe.AsPointer(ref this), pDefines, defineCount);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        [return: NativeTypeName("LPCWSTR *")]
        ushort** GetArguments();
        [VtblIndex(4)]
        [return: NativeTypeName("UINT32")]
        uint GetCount();
        [VtblIndex(5)]
        HRESULT AddArguments([NativeTypeName("LPCWSTR *")] ushort** pArguments, [NativeTypeName("UINT32")] uint argCount);
        [VtblIndex(6)]
        HRESULT AddArgumentsUTF8([NativeTypeName("LPCSTR *")] sbyte** pArguments, [NativeTypeName("UINT32")] uint argCount);
        [VtblIndex(7)]
        HRESULT AddDefines([NativeTypeName("const DxcDefine *")] DxcDefine* pDefines, [NativeTypeName("UINT32")] uint defineCount);
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
        [NativeTypeName("LPCWSTR *() __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**> GetArguments;
        [NativeTypeName("UINT32 () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> GetCount;
        [NativeTypeName("HRESULT (LPCWSTR *, UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, uint, int> AddArguments;
        [NativeTypeName("HRESULT (LPCSTR *, UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, sbyte**, uint, int> AddArgumentsUTF8;
        [NativeTypeName("HRESULT (const DxcDefine *, UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DxcDefine*, uint, int> AddDefines;
    }
}