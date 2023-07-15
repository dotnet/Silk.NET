// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dxcapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the University of Illinois Open Source License.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;
/// <include file='IDxcLinker.xml' path='doc/member[@name="IDxcLinker"]/*'/>
[Guid("F1B5BE2A-62DD-4327-A1C2-42AC1E1E78E6")]
[NativeTypeName("struct IDxcLinker : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDxcLinker : IDxcLinker.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDxcLinker));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDxcLinker*, Guid*, void**, int> )(lpVtbl[0]))((IDxcLinker*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDxcLinker*, uint> )(lpVtbl[1]))((IDxcLinker*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDxcLinker*, uint> )(lpVtbl[2]))((IDxcLinker*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDxcLinker.xml' path='doc/member[@name="IDxcLinker.RegisterLibrary"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT RegisterLibrary([NativeTypeName("LPCWSTR")] ushort* pLibName, IDxcBlob* pLib)
    {
        return ((delegate* unmanaged<IDxcLinker*, ushort*, IDxcBlob*, int> )(lpVtbl[3]))((IDxcLinker*)Unsafe.AsPointer(ref this), pLibName, pLib);
    }

    /// <include file='IDxcLinker.xml' path='doc/member[@name="IDxcLinker.Link"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Link([NativeTypeName("LPCWSTR")] ushort* pEntryName, [NativeTypeName("LPCWSTR")] ushort* pTargetProfile, [NativeTypeName("const LPCWSTR *")] ushort** pLibNames, [NativeTypeName("UINT32")] uint libCount, [NativeTypeName("const LPCWSTR *")] ushort** pArguments, [NativeTypeName("UINT32")] uint argCount, IDxcOperationResult** ppResult)
    {
        return ((delegate* unmanaged<IDxcLinker*, ushort*, ushort*, ushort**, uint, ushort**, uint, IDxcOperationResult**, int> )(lpVtbl[4]))((IDxcLinker*)Unsafe.AsPointer(ref this), pEntryName, pTargetProfile, pLibNames, libCount, pArguments, argCount, ppResult);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT RegisterLibrary([NativeTypeName("LPCWSTR")] ushort* pLibName, IDxcBlob* pLib);
        [VtblIndex(4)]
        HRESULT Link([NativeTypeName("LPCWSTR")] ushort* pEntryName, [NativeTypeName("LPCWSTR")] ushort* pTargetProfile, [NativeTypeName("const LPCWSTR *")] ushort** pLibNames, [NativeTypeName("UINT32")] uint libCount, [NativeTypeName("const LPCWSTR *")] ushort** pArguments, [NativeTypeName("UINT32")] uint argCount, IDxcOperationResult** ppResult);
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
        [NativeTypeName("HRESULT (LPCWSTR, IDxcBlob *)")]
        public delegate* unmanaged<TSelf*, ushort*, IDxcBlob*, int> RegisterLibrary;
        [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR, const LPCWSTR *, UINT32, const LPCWSTR *, UINT32, IDxcOperationResult **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, ushort**, uint, ushort**, uint, IDxcOperationResult**, int> Link;
    }
}