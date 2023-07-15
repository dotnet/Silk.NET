// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IEventTarget.xml' path='doc/member[@name="IEventTarget"]/*'/>
[Guid("305104B9-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IEventTarget : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IEventTarget : IEventTarget.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IEventTarget));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IEventTarget*, Guid*, void**, int> )(lpVtbl[0]))((IEventTarget*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IEventTarget*, uint> )(lpVtbl[1]))((IEventTarget*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IEventTarget*, uint> )(lpVtbl[2]))((IEventTarget*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfoCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IEventTarget*, uint*, int> )(lpVtbl[3]))((IEventTarget*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IEventTarget*, uint, uint, ITypeInfo**, int> )(lpVtbl[4]))((IEventTarget*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref = "IDispatch.GetIDsOfNames"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IEventTarget*, Guid*, ushort**, uint, uint, int*, int> )(lpVtbl[5]))((IEventTarget*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref = "IDispatch.Invoke"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IEventTarget*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> )(lpVtbl[6]))((IEventTarget*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='IEventTarget.xml' path='doc/member[@name="IEventTarget.addEventListener"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT addEventListener([NativeTypeName("BSTR")] ushort* type, IDispatch* listener, [NativeTypeName("VARIANT_BOOL")] short useCapture)
    {
        return ((delegate* unmanaged<IEventTarget*, ushort*, IDispatch*, short, int> )(lpVtbl[7]))((IEventTarget*)Unsafe.AsPointer(ref this), type, listener, useCapture);
    }

    /// <include file='IEventTarget.xml' path='doc/member[@name="IEventTarget.removeEventListener"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT removeEventListener([NativeTypeName("BSTR")] ushort* type, IDispatch* listener, [NativeTypeName("VARIANT_BOOL")] short useCapture)
    {
        return ((delegate* unmanaged<IEventTarget*, ushort*, IDispatch*, short, int> )(lpVtbl[8]))((IEventTarget*)Unsafe.AsPointer(ref this), type, listener, useCapture);
    }

    /// <include file='IEventTarget.xml' path='doc/member[@name="IEventTarget.dispatchEvent"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT dispatchEvent(IDOMEvent* evt, [NativeTypeName("VARIANT_BOOL *")] short* pfResult)
    {
        return ((delegate* unmanaged<IEventTarget*, IDOMEvent*, short*, int> )(lpVtbl[9]))((IEventTarget*)Unsafe.AsPointer(ref this), evt, pfResult);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT addEventListener([NativeTypeName("BSTR")] ushort* type, IDispatch* listener, [NativeTypeName("VARIANT_BOOL")] short useCapture);
        [VtblIndex(8)]
        HRESULT removeEventListener([NativeTypeName("BSTR")] ushort* type, IDispatch* listener, [NativeTypeName("VARIANT_BOOL")] short useCapture);
        [VtblIndex(9)]
        HRESULT dispatchEvent(IDOMEvent* evt, [NativeTypeName("VARIANT_BOOL *")] short* pfResult);
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
        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetTypeInfoCount;
        [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, ITypeInfo**, int> GetTypeInfo;
        [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, ushort**, uint, uint, int*, int> GetIDsOfNames;
        [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> Invoke;
        [NativeTypeName("HRESULT (BSTR, IDispatch *, VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, IDispatch*, short, int> addEventListener;
        [NativeTypeName("HRESULT (BSTR, IDispatch *, VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, IDispatch*, short, int> removeEventListener;
        [NativeTypeName("HRESULT (IDOMEvent *, VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDOMEvent*, short*, int> dispatchEvent;
    }
}