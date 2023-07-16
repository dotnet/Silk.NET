// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dxcapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the University of Illinois Open Source License.
using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;
/// <include file='IDxcVersionInfo3.xml' path='doc/member[@name="IDxcVersionInfo3"]/*'/>
[Guid("5E13E843-9D25-473C-9AD2-03B2D0B44B1E")]
[NativeTypeName("struct IDxcVersionInfo3 : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDxcVersionInfo3 : IDxcVersionInfo3.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDxcVersionInfo3));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDxcVersionInfo3*, Guid*, void**, int> )(lpVtbl[0]))((IDxcVersionInfo3*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDxcVersionInfo3*, uint> )(lpVtbl[1]))((IDxcVersionInfo3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDxcVersionInfo3*, uint> )(lpVtbl[2]))((IDxcVersionInfo3*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDxcVersionInfo3.xml' path='doc/member[@name="IDxcVersionInfo3.GetCustomVersionString"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetCustomVersionString([NativeTypeName("char **")] sbyte** pVersionString)
    {
        return ((delegate* unmanaged<IDxcVersionInfo3*, sbyte**, int> )(lpVtbl[3]))((IDxcVersionInfo3*)Unsafe.AsPointer(ref this), pVersionString);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetCustomVersionString([NativeTypeName("char **")] sbyte** pVersionString);
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
        [NativeTypeName("HRESULT (char **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, sbyte**, int> GetCustomVersionString;
    }
}