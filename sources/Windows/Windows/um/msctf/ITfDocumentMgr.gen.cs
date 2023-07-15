// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/msctf.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='ITfDocumentMgr.xml' path='doc/member[@name="ITfDocumentMgr"]/*'/>
[Guid("AA80E7F4-2021-11D2-93E0-0060B067B86E")]
[NativeTypeName("struct ITfDocumentMgr : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ITfDocumentMgr : ITfDocumentMgr.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITfDocumentMgr));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITfDocumentMgr*, Guid*, void**, int> )(lpVtbl[0]))((ITfDocumentMgr*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ITfDocumentMgr*, uint> )(lpVtbl[1]))((ITfDocumentMgr*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITfDocumentMgr*, uint> )(lpVtbl[2]))((ITfDocumentMgr*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ITfDocumentMgr.xml' path='doc/member[@name="ITfDocumentMgr.CreateContext"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CreateContext([NativeTypeName("TfClientId")] uint tidOwner, [NativeTypeName("DWORD")] uint dwFlags, IUnknown* punk, ITfContext** ppic, [NativeTypeName("TfEditCookie *")] uint* pecTextStore)
    {
        return ((delegate* unmanaged<ITfDocumentMgr*, uint, uint, IUnknown*, ITfContext**, uint*, int> )(lpVtbl[3]))((ITfDocumentMgr*)Unsafe.AsPointer(ref this), tidOwner, dwFlags, punk, ppic, pecTextStore);
    }

    /// <include file='ITfDocumentMgr.xml' path='doc/member[@name="ITfDocumentMgr.Push"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Push(ITfContext* pic)
    {
        return ((delegate* unmanaged<ITfDocumentMgr*, ITfContext*, int> )(lpVtbl[4]))((ITfDocumentMgr*)Unsafe.AsPointer(ref this), pic);
    }

    /// <include file='ITfDocumentMgr.xml' path='doc/member[@name="ITfDocumentMgr.Pop"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Pop([NativeTypeName("DWORD")] uint dwFlags)
    {
        return ((delegate* unmanaged<ITfDocumentMgr*, uint, int> )(lpVtbl[5]))((ITfDocumentMgr*)Unsafe.AsPointer(ref this), dwFlags);
    }

    /// <include file='ITfDocumentMgr.xml' path='doc/member[@name="ITfDocumentMgr.GetTop"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetTop(ITfContext** ppic)
    {
        return ((delegate* unmanaged<ITfDocumentMgr*, ITfContext**, int> )(lpVtbl[6]))((ITfDocumentMgr*)Unsafe.AsPointer(ref this), ppic);
    }

    /// <include file='ITfDocumentMgr.xml' path='doc/member[@name="ITfDocumentMgr.GetBase"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetBase(ITfContext** ppic)
    {
        return ((delegate* unmanaged<ITfDocumentMgr*, ITfContext**, int> )(lpVtbl[7]))((ITfDocumentMgr*)Unsafe.AsPointer(ref this), ppic);
    }

    /// <include file='ITfDocumentMgr.xml' path='doc/member[@name="ITfDocumentMgr.EnumContexts"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT EnumContexts(IEnumTfContexts** ppEnum)
    {
        return ((delegate* unmanaged<ITfDocumentMgr*, IEnumTfContexts**, int> )(lpVtbl[8]))((ITfDocumentMgr*)Unsafe.AsPointer(ref this), ppEnum);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT CreateContext([NativeTypeName("TfClientId")] uint tidOwner, [NativeTypeName("DWORD")] uint dwFlags, IUnknown* punk, ITfContext** ppic, [NativeTypeName("TfEditCookie *")] uint* pecTextStore);
        [VtblIndex(4)]
        HRESULT Push(ITfContext* pic);
        [VtblIndex(5)]
        HRESULT Pop([NativeTypeName("DWORD")] uint dwFlags);
        [VtblIndex(6)]
        HRESULT GetTop(ITfContext** ppic);
        [VtblIndex(7)]
        HRESULT GetBase(ITfContext** ppic);
        [VtblIndex(8)]
        HRESULT EnumContexts(IEnumTfContexts** ppEnum);
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
        [NativeTypeName("HRESULT (TfClientId, DWORD, IUnknown *, ITfContext **, TfEditCookie *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, IUnknown*, ITfContext**, uint*, int> CreateContext;
        [NativeTypeName("HRESULT (ITfContext *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ITfContext*, int> Push;
        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> Pop;
        [NativeTypeName("HRESULT (ITfContext **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ITfContext**, int> GetTop;
        [NativeTypeName("HRESULT (ITfContext **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ITfContext**, int> GetBase;
        [NativeTypeName("HRESULT (IEnumTfContexts **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IEnumTfContexts**, int> EnumContexts;
    }
}