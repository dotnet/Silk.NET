// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IWrappedProtocol.xml' path='doc/member[@name="IWrappedProtocol"]/*'/>
[Guid("53C84785-8425-4DC5-971B-E58D9C19F9B6")]
[NativeTypeName("struct IWrappedProtocol : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IWrappedProtocol : IWrappedProtocol.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWrappedProtocol));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IWrappedProtocol*, Guid*, void**, int> )(lpVtbl[0]))((IWrappedProtocol*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IWrappedProtocol*, uint> )(lpVtbl[1]))((IWrappedProtocol*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IWrappedProtocol*, uint> )(lpVtbl[2]))((IWrappedProtocol*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IWrappedProtocol.xml' path='doc/member[@name="IWrappedProtocol.GetWrapperCode"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetWrapperCode([NativeTypeName("LONG *")] int* pnCode, [NativeTypeName("DWORD_PTR")] nuint dwReserved)
    {
        return ((delegate* unmanaged<IWrappedProtocol*, int*, nuint, int> )(lpVtbl[3]))((IWrappedProtocol*)Unsafe.AsPointer(ref this), pnCode, dwReserved);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetWrapperCode([NativeTypeName("LONG *")] int* pnCode, [NativeTypeName("DWORD_PTR")] nuint dwReserved);
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
        [NativeTypeName("HRESULT (LONG *, DWORD_PTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, nuint, int> GetWrapperCode;
    }
}