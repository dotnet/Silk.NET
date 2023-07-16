// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/objidlbase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IGlobalInterfaceTable.xml' path='doc/member[@name="IGlobalInterfaceTable"]/*'/>
[Guid("00000146-0000-0000-C000-000000000046")]
[NativeTypeName("struct IGlobalInterfaceTable : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IGlobalInterfaceTable : IGlobalInterfaceTable.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IGlobalInterfaceTable));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IGlobalInterfaceTable*, Guid*, void**, int> )(lpVtbl[0]))((IGlobalInterfaceTable*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IGlobalInterfaceTable*, uint> )(lpVtbl[1]))((IGlobalInterfaceTable*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IGlobalInterfaceTable*, uint> )(lpVtbl[2]))((IGlobalInterfaceTable*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IGlobalInterfaceTable.xml' path='doc/member[@name="IGlobalInterfaceTable.RegisterInterfaceInGlobal"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT RegisterInterfaceInGlobal(IUnknown* pUnk, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("DWORD *")] uint* pdwCookie)
    {
        return ((delegate* unmanaged<IGlobalInterfaceTable*, IUnknown*, Guid*, uint*, int> )(lpVtbl[3]))((IGlobalInterfaceTable*)Unsafe.AsPointer(ref this), pUnk, riid, pdwCookie);
    }

    /// <include file='IGlobalInterfaceTable.xml' path='doc/member[@name="IGlobalInterfaceTable.RevokeInterfaceFromGlobal"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT RevokeInterfaceFromGlobal([NativeTypeName("DWORD")] uint dwCookie)
    {
        return ((delegate* unmanaged<IGlobalInterfaceTable*, uint, int> )(lpVtbl[4]))((IGlobalInterfaceTable*)Unsafe.AsPointer(ref this), dwCookie);
    }

    /// <include file='IGlobalInterfaceTable.xml' path='doc/member[@name="IGlobalInterfaceTable.GetInterfaceFromGlobal"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetInterfaceFromGlobal([NativeTypeName("DWORD")] uint dwCookie, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
    {
        return ((delegate* unmanaged<IGlobalInterfaceTable*, uint, Guid*, void**, int> )(lpVtbl[5]))((IGlobalInterfaceTable*)Unsafe.AsPointer(ref this), dwCookie, riid, ppv);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT RegisterInterfaceInGlobal(IUnknown* pUnk, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("DWORD *")] uint* pdwCookie);
        [VtblIndex(4)]
        HRESULT RevokeInterfaceFromGlobal([NativeTypeName("DWORD")] uint dwCookie);
        [VtblIndex(5)]
        HRESULT GetInterfaceFromGlobal([NativeTypeName("DWORD")] uint dwCookie, [NativeTypeName("const IID &")] Guid* riid, void** ppv);
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
        [NativeTypeName("HRESULT (IUnknown *, const IID &, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown*, Guid*, uint*, int> RegisterInterfaceInGlobal;
        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> RevokeInterfaceFromGlobal;
        [NativeTypeName("HRESULT (DWORD, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, Guid*, void**, int> GetInterfaceFromGlobal;
    }
}