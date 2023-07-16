// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MSAAText.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='ICoCreateLocally.xml' path='doc/member[@name="ICoCreateLocally"]/*'/>
[Guid("03DE00AA-F272-41E3-99CB-03C5E8114EA0")]
[NativeTypeName("struct ICoCreateLocally : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ICoCreateLocally : ICoCreateLocally.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICoCreateLocally));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ICoCreateLocally*, Guid*, void**, int> )(lpVtbl[0]))((ICoCreateLocally*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ICoCreateLocally*, uint> )(lpVtbl[1]))((ICoCreateLocally*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICoCreateLocally*, uint> )(lpVtbl[2]))((ICoCreateLocally*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ICoCreateLocally.xml' path='doc/member[@name="ICoCreateLocally.CoCreateLocally"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CoCreateLocally([NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("DWORD")] uint dwClsContext, [NativeTypeName("const IID &")] Guid* riid, IUnknown** punk, [NativeTypeName("const IID &")] Guid* riidParam, IUnknown* punkParam, VARIANT varParam)
    {
        return ((delegate* unmanaged<ICoCreateLocally*, Guid*, uint, Guid*, IUnknown**, Guid*, IUnknown*, VARIANT, int> )(lpVtbl[3]))((ICoCreateLocally*)Unsafe.AsPointer(ref this), rclsid, dwClsContext, riid, punk, riidParam, punkParam, varParam);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT CoCreateLocally([NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("DWORD")] uint dwClsContext, [NativeTypeName("const IID &")] Guid* riid, IUnknown** punk, [NativeTypeName("const IID &")] Guid* riidParam, IUnknown* punkParam, VARIANT varParam);
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
        [NativeTypeName("HRESULT (const IID &, DWORD, const IID &, IUnknown **, const IID &, IUnknown *, VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, uint, Guid*, IUnknown**, Guid*, IUnknown*, VARIANT, int> CoCreateLocally;
    }
}