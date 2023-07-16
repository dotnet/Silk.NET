// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/shdeprecated.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IExpDispSupportXP.xml' path='doc/member[@name="IExpDispSupportXP"]/*'/>
[Guid("2F0DD58C-F789-4F14-99FB-9293B3C9C212")]
[NativeTypeName("struct IExpDispSupportXP : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IExpDispSupportXP : IExpDispSupportXP.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IExpDispSupportXP));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IExpDispSupportXP*, Guid*, void**, int> )(lpVtbl[0]))((IExpDispSupportXP*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IExpDispSupportXP*, uint> )(lpVtbl[1]))((IExpDispSupportXP*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IExpDispSupportXP*, uint> )(lpVtbl[2]))((IExpDispSupportXP*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IExpDispSupportXP.xml' path='doc/member[@name="IExpDispSupportXP.FindCIE4ConnectionPoint"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT FindCIE4ConnectionPoint([NativeTypeName("const IID &")] Guid* riid, CIE4ConnectionPoint** ppccp)
    {
        return ((delegate* unmanaged<IExpDispSupportXP*, Guid*, CIE4ConnectionPoint**, int> )(lpVtbl[3]))((IExpDispSupportXP*)Unsafe.AsPointer(ref this), riid, ppccp);
    }

    /// <include file='IExpDispSupportXP.xml' path='doc/member[@name="IExpDispSupportXP.OnTranslateAccelerator"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT OnTranslateAccelerator(MSG* pMsg, [NativeTypeName("DWORD")] uint grfModifiers)
    {
        return ((delegate* unmanaged<IExpDispSupportXP*, MSG*, uint, int> )(lpVtbl[4]))((IExpDispSupportXP*)Unsafe.AsPointer(ref this), pMsg, grfModifiers);
    }

    /// <include file='IExpDispSupportXP.xml' path='doc/member[@name="IExpDispSupportXP.OnInvoke"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT OnInvoke([NativeTypeName("DISPID")] int dispidMember, [NativeTypeName("const IID &")] Guid* iid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pdispparams, VARIANT* pVarResult, EXCEPINFO* pexcepinfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IExpDispSupportXP*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> )(lpVtbl[5]))((IExpDispSupportXP*)Unsafe.AsPointer(ref this), dispidMember, iid, lcid, wFlags, pdispparams, pVarResult, pexcepinfo, puArgErr);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT FindCIE4ConnectionPoint([NativeTypeName("const IID &")] Guid* riid, CIE4ConnectionPoint** ppccp);
        [VtblIndex(4)]
        HRESULT OnTranslateAccelerator(MSG* pMsg, [NativeTypeName("DWORD")] uint grfModifiers);
        [VtblIndex(5)]
        HRESULT OnInvoke([NativeTypeName("DISPID")] int dispidMember, [NativeTypeName("const IID &")] Guid* iid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pdispparams, VARIANT* pVarResult, EXCEPINFO* pexcepinfo, uint* puArgErr);
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
        [NativeTypeName("HRESULT (const IID &, CIE4ConnectionPoint **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, CIE4ConnectionPoint**, int> FindCIE4ConnectionPoint;
        [NativeTypeName("HRESULT (MSG *, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, MSG*, uint, int> OnTranslateAccelerator;
        [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> OnInvoke;
    }
}