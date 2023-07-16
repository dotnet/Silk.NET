// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dxcapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the University of Illinois Open Source License.
using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;
/// <include file='IDxcIncludeHandler.xml' path='doc/member[@name="IDxcIncludeHandler"]/*'/>
[Guid("7F61FC7D-950D-467F-B3E3-3C02FB49187C")]
[NativeTypeName("struct IDxcIncludeHandler : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDxcIncludeHandler : IDxcIncludeHandler.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDxcIncludeHandler));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDxcIncludeHandler*, Guid*, void**, int> )(lpVtbl[0]))((IDxcIncludeHandler*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDxcIncludeHandler*, uint> )(lpVtbl[1]))((IDxcIncludeHandler*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDxcIncludeHandler*, uint> )(lpVtbl[2]))((IDxcIncludeHandler*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDxcIncludeHandler.xml' path='doc/member[@name="IDxcIncludeHandler.LoadSource"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT LoadSource([NativeTypeName("LPCWSTR")] ushort* pFilename, IDxcBlob** ppIncludeSource)
    {
        return ((delegate* unmanaged<IDxcIncludeHandler*, ushort*, IDxcBlob**, int> )(lpVtbl[3]))((IDxcIncludeHandler*)Unsafe.AsPointer(ref this), pFilename, ppIncludeSource);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT LoadSource([NativeTypeName("LPCWSTR")] ushort* pFilename, IDxcBlob** ppIncludeSource);
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
        [NativeTypeName("HRESULT (LPCWSTR, IDxcBlob **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, IDxcBlob**, int> LoadSource;
    }
}