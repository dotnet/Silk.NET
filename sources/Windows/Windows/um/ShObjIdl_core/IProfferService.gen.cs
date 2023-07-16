// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IProfferService.xml' path='doc/member[@name="IProfferService"]/*'/>
[Guid("CB728B20-F786-11CE-92AD-00AA00A74CD0")]
[NativeTypeName("struct IProfferService : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IProfferService : IProfferService.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IProfferService));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IProfferService*, Guid*, void**, int> )(lpVtbl[0]))((IProfferService*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IProfferService*, uint> )(lpVtbl[1]))((IProfferService*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IProfferService*, uint> )(lpVtbl[2]))((IProfferService*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IProfferService.xml' path='doc/member[@name="IProfferService.ProfferService"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT ProfferService([NativeTypeName("const GUID &")] Guid* serviceId, IServiceProvider* serviceProvider, [NativeTypeName("DWORD *")] uint* cookie)
    {
        return ((delegate* unmanaged<IProfferService*, Guid*, IServiceProvider*, uint*, int> )(lpVtbl[3]))((IProfferService*)Unsafe.AsPointer(ref this), serviceId, serviceProvider, cookie);
    }

    /// <include file='IProfferService.xml' path='doc/member[@name="IProfferService.RevokeService"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT RevokeService([NativeTypeName("DWORD")] uint cookie)
    {
        return ((delegate* unmanaged<IProfferService*, uint, int> )(lpVtbl[4]))((IProfferService*)Unsafe.AsPointer(ref this), cookie);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT ProfferService([NativeTypeName("const GUID &")] Guid* serviceId, IServiceProvider* serviceProvider, [NativeTypeName("DWORD *")] uint* cookie);
        [VtblIndex(4)]
        HRESULT RevokeService([NativeTypeName("DWORD")] uint cookie);
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
        [NativeTypeName("HRESULT (const GUID &, IServiceProvider *, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, IServiceProvider*, uint*, int> ProfferService;
        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> RevokeService;
    }
}