// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IBindHttpSecurity.xml' path='doc/member[@name="IBindHttpSecurity"]/*'/>
[Guid("A9EDA967-F50E-4A33-B358-206F6EF3086D")]
[NativeTypeName("struct IBindHttpSecurity : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IBindHttpSecurity : IBindHttpSecurity.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBindHttpSecurity));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IBindHttpSecurity*, Guid*, void**, int> )(lpVtbl[0]))((IBindHttpSecurity*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IBindHttpSecurity*, uint> )(lpVtbl[1]))((IBindHttpSecurity*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IBindHttpSecurity*, uint> )(lpVtbl[2]))((IBindHttpSecurity*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IBindHttpSecurity.xml' path='doc/member[@name="IBindHttpSecurity.GetIgnoreCertMask"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIgnoreCertMask([NativeTypeName("DWORD *")] uint* pdwIgnoreCertMask)
    {
        return ((delegate* unmanaged<IBindHttpSecurity*, uint*, int> )(lpVtbl[3]))((IBindHttpSecurity*)Unsafe.AsPointer(ref this), pdwIgnoreCertMask);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetIgnoreCertMask([NativeTypeName("DWORD *")] uint* pdwIgnoreCertMask);
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
        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetIgnoreCertMask;
    }
}