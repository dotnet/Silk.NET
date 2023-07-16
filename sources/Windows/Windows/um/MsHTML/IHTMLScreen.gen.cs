// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IHTMLScreen.xml' path='doc/member[@name="IHTMLScreen"]/*'/>
[Guid("3050F35C-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IHTMLScreen : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IHTMLScreen : IHTMLScreen.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHTMLScreen));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHTMLScreen*, Guid*, void**, int> )(lpVtbl[0]))((IHTMLScreen*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IHTMLScreen*, uint> )(lpVtbl[1]))((IHTMLScreen*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHTMLScreen*, uint> )(lpVtbl[2]))((IHTMLScreen*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfoCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IHTMLScreen*, uint*, int> )(lpVtbl[3]))((IHTMLScreen*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IHTMLScreen*, uint, uint, ITypeInfo**, int> )(lpVtbl[4]))((IHTMLScreen*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref = "IDispatch.GetIDsOfNames"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IHTMLScreen*, Guid*, ushort**, uint, uint, int*, int> )(lpVtbl[5]))((IHTMLScreen*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref = "IDispatch.Invoke"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IHTMLScreen*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> )(lpVtbl[6]))((IHTMLScreen*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='IHTMLScreen.xml' path='doc/member[@name="IHTMLScreen.get_colorDepth"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_colorDepth([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLScreen*, int*, int> )(lpVtbl[7]))((IHTMLScreen*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLScreen.xml' path='doc/member[@name="IHTMLScreen.put_bufferDepth"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_bufferDepth([NativeTypeName("long")] int v)
    {
        return ((delegate* unmanaged<IHTMLScreen*, int, int> )(lpVtbl[8]))((IHTMLScreen*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLScreen.xml' path='doc/member[@name="IHTMLScreen.get_bufferDepth"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_bufferDepth([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLScreen*, int*, int> )(lpVtbl[9]))((IHTMLScreen*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLScreen.xml' path='doc/member[@name="IHTMLScreen.get_width"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_width([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLScreen*, int*, int> )(lpVtbl[10]))((IHTMLScreen*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLScreen.xml' path='doc/member[@name="IHTMLScreen.get_height"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_height([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLScreen*, int*, int> )(lpVtbl[11]))((IHTMLScreen*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLScreen.xml' path='doc/member[@name="IHTMLScreen.put_updateInterval"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT put_updateInterval([NativeTypeName("long")] int v)
    {
        return ((delegate* unmanaged<IHTMLScreen*, int, int> )(lpVtbl[12]))((IHTMLScreen*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLScreen.xml' path='doc/member[@name="IHTMLScreen.get_updateInterval"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_updateInterval([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLScreen*, int*, int> )(lpVtbl[13]))((IHTMLScreen*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLScreen.xml' path='doc/member[@name="IHTMLScreen.get_availHeight"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_availHeight([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLScreen*, int*, int> )(lpVtbl[14]))((IHTMLScreen*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLScreen.xml' path='doc/member[@name="IHTMLScreen.get_availWidth"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_availWidth([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLScreen*, int*, int> )(lpVtbl[15]))((IHTMLScreen*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLScreen.xml' path='doc/member[@name="IHTMLScreen.get_fontSmoothingEnabled"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_fontSmoothingEnabled([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<IHTMLScreen*, short*, int> )(lpVtbl[16]))((IHTMLScreen*)Unsafe.AsPointer(ref this), p);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT get_colorDepth([NativeTypeName("long *")] int* p);
        [VtblIndex(8)]
        HRESULT put_bufferDepth([NativeTypeName("long")] int v);
        [VtblIndex(9)]
        HRESULT get_bufferDepth([NativeTypeName("long *")] int* p);
        [VtblIndex(10)]
        HRESULT get_width([NativeTypeName("long *")] int* p);
        [VtblIndex(11)]
        HRESULT get_height([NativeTypeName("long *")] int* p);
        [VtblIndex(12)]
        HRESULT put_updateInterval([NativeTypeName("long")] int v);
        [VtblIndex(13)]
        HRESULT get_updateInterval([NativeTypeName("long *")] int* p);
        [VtblIndex(14)]
        HRESULT get_availHeight([NativeTypeName("long *")] int* p);
        [VtblIndex(15)]
        HRESULT get_availWidth([NativeTypeName("long *")] int* p);
        [VtblIndex(16)]
        HRESULT get_fontSmoothingEnabled([NativeTypeName("VARIANT_BOOL *")] short* p);
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
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_colorDepth;
        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_bufferDepth;
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_bufferDepth;
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_width;
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_height;
        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_updateInterval;
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_updateInterval;
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_availHeight;
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_availWidth;
        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_fontSmoothingEnabled;
    }
}