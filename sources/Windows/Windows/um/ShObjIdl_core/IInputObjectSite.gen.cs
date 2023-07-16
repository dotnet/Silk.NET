// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IInputObjectSite.xml' path='doc/member[@name="IInputObjectSite"]/*'/>
[Guid("F1DB8392-7331-11D0-8C99-00A0C92DBFE8")]
[NativeTypeName("struct IInputObjectSite : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IInputObjectSite : IInputObjectSite.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IInputObjectSite));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IInputObjectSite*, Guid*, void**, int> )(lpVtbl[0]))((IInputObjectSite*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IInputObjectSite*, uint> )(lpVtbl[1]))((IInputObjectSite*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IInputObjectSite*, uint> )(lpVtbl[2]))((IInputObjectSite*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IInputObjectSite.xml' path='doc/member[@name="IInputObjectSite.OnFocusChangeIS"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT OnFocusChangeIS(IUnknown* punkObj, BOOL fSetFocus)
    {
        return ((delegate* unmanaged<IInputObjectSite*, IUnknown*, BOOL, int> )(lpVtbl[3]))((IInputObjectSite*)Unsafe.AsPointer(ref this), punkObj, fSetFocus);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT OnFocusChangeIS(IUnknown* punkObj, BOOL fSetFocus);
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
        [NativeTypeName("HRESULT (IUnknown *, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown*, BOOL, int> OnFocusChangeIS;
    }
}