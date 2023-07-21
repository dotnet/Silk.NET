// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IHTMLAppBehavior.xml' path='doc/member[@name="IHTMLAppBehavior"]/*' />
[Guid("3050F5CA-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IHTMLAppBehavior : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IHTMLAppBehavior : IHTMLAppBehavior.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHTMLAppBehavior));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHTMLAppBehavior*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLAppBehavior*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IHTMLAppBehavior*, uint>)(lpVtbl[1]))((IHTMLAppBehavior*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHTMLAppBehavior*, uint>)(lpVtbl[2]))((IHTMLAppBehavior*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfoCount" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IHTMLAppBehavior*, uint*, int>)(lpVtbl[3]))((IHTMLAppBehavior*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfo" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IHTMLAppBehavior*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLAppBehavior*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref="IDispatch.GetIDsOfNames" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IHTMLAppBehavior*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLAppBehavior*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref="IDispatch.Invoke" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IHTMLAppBehavior*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLAppBehavior*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='IHTMLAppBehavior.xml' path='doc/member[@name="IHTMLAppBehavior.put_applicationName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_applicationName([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLAppBehavior*, ushort*, int>)(lpVtbl[7]))((IHTMLAppBehavior*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLAppBehavior.xml' path='doc/member[@name="IHTMLAppBehavior.get_applicationName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_applicationName([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLAppBehavior*, ushort**, int>)(lpVtbl[8]))((IHTMLAppBehavior*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLAppBehavior.xml' path='doc/member[@name="IHTMLAppBehavior.put_version"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_version([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLAppBehavior*, ushort*, int>)(lpVtbl[9]))((IHTMLAppBehavior*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLAppBehavior.xml' path='doc/member[@name="IHTMLAppBehavior.get_version"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_version([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLAppBehavior*, ushort**, int>)(lpVtbl[10]))((IHTMLAppBehavior*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLAppBehavior.xml' path='doc/member[@name="IHTMLAppBehavior.put_icon"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_icon([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLAppBehavior*, ushort*, int>)(lpVtbl[11]))((IHTMLAppBehavior*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLAppBehavior.xml' path='doc/member[@name="IHTMLAppBehavior.get_icon"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_icon([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLAppBehavior*, ushort**, int>)(lpVtbl[12]))((IHTMLAppBehavior*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLAppBehavior.xml' path='doc/member[@name="IHTMLAppBehavior.put_singleInstance"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_singleInstance([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLAppBehavior*, ushort*, int>)(lpVtbl[13]))((IHTMLAppBehavior*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLAppBehavior.xml' path='doc/member[@name="IHTMLAppBehavior.get_singleInstance"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_singleInstance([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLAppBehavior*, ushort**, int>)(lpVtbl[14]))((IHTMLAppBehavior*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLAppBehavior.xml' path='doc/member[@name="IHTMLAppBehavior.put_minimizeButton"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_minimizeButton([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLAppBehavior*, ushort*, int>)(lpVtbl[15]))((IHTMLAppBehavior*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLAppBehavior.xml' path='doc/member[@name="IHTMLAppBehavior.get_minimizeButton"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_minimizeButton([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLAppBehavior*, ushort**, int>)(lpVtbl[16]))((IHTMLAppBehavior*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLAppBehavior.xml' path='doc/member[@name="IHTMLAppBehavior.put_maximizeButton"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT put_maximizeButton([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLAppBehavior*, ushort*, int>)(lpVtbl[17]))((IHTMLAppBehavior*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLAppBehavior.xml' path='doc/member[@name="IHTMLAppBehavior.get_maximizeButton"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_maximizeButton([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLAppBehavior*, ushort**, int>)(lpVtbl[18]))((IHTMLAppBehavior*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLAppBehavior.xml' path='doc/member[@name="IHTMLAppBehavior.put_border"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT put_border([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLAppBehavior*, ushort*, int>)(lpVtbl[19]))((IHTMLAppBehavior*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLAppBehavior.xml' path='doc/member[@name="IHTMLAppBehavior.get_border"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_border([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLAppBehavior*, ushort**, int>)(lpVtbl[20]))((IHTMLAppBehavior*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLAppBehavior.xml' path='doc/member[@name="IHTMLAppBehavior.put_borderStyle"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT put_borderStyle([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLAppBehavior*, ushort*, int>)(lpVtbl[21]))((IHTMLAppBehavior*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLAppBehavior.xml' path='doc/member[@name="IHTMLAppBehavior.get_borderStyle"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT get_borderStyle([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLAppBehavior*, ushort**, int>)(lpVtbl[22]))((IHTMLAppBehavior*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLAppBehavior.xml' path='doc/member[@name="IHTMLAppBehavior.put_sysMenu"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT put_sysMenu([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLAppBehavior*, ushort*, int>)(lpVtbl[23]))((IHTMLAppBehavior*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLAppBehavior.xml' path='doc/member[@name="IHTMLAppBehavior.get_sysMenu"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT get_sysMenu([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLAppBehavior*, ushort**, int>)(lpVtbl[24]))((IHTMLAppBehavior*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLAppBehavior.xml' path='doc/member[@name="IHTMLAppBehavior.put_caption"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT put_caption([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLAppBehavior*, ushort*, int>)(lpVtbl[25]))((IHTMLAppBehavior*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLAppBehavior.xml' path='doc/member[@name="IHTMLAppBehavior.get_caption"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT get_caption([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLAppBehavior*, ushort**, int>)(lpVtbl[26]))((IHTMLAppBehavior*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLAppBehavior.xml' path='doc/member[@name="IHTMLAppBehavior.put_windowState"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT put_windowState([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLAppBehavior*, ushort*, int>)(lpVtbl[27]))((IHTMLAppBehavior*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLAppBehavior.xml' path='doc/member[@name="IHTMLAppBehavior.get_windowState"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT get_windowState([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLAppBehavior*, ushort**, int>)(lpVtbl[28]))((IHTMLAppBehavior*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLAppBehavior.xml' path='doc/member[@name="IHTMLAppBehavior.put_showInTaskBar"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT put_showInTaskBar([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLAppBehavior*, ushort*, int>)(lpVtbl[29]))((IHTMLAppBehavior*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLAppBehavior.xml' path='doc/member[@name="IHTMLAppBehavior.get_showInTaskBar"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT get_showInTaskBar([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLAppBehavior*, ushort**, int>)(lpVtbl[30]))((IHTMLAppBehavior*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLAppBehavior.xml' path='doc/member[@name="IHTMLAppBehavior.get_commandLine"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT get_commandLine([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLAppBehavior*, ushort**, int>)(lpVtbl[31]))((IHTMLAppBehavior*)Unsafe.AsPointer(ref this), p);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT put_applicationName([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(8)]
        HRESULT get_applicationName([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(9)]
        HRESULT put_version([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(10)]
        HRESULT get_version([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(11)]
        HRESULT put_icon([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(12)]
        HRESULT get_icon([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(13)]
        HRESULT put_singleInstance([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(14)]
        HRESULT get_singleInstance([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(15)]
        HRESULT put_minimizeButton([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(16)]
        HRESULT get_minimizeButton([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(17)]
        HRESULT put_maximizeButton([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(18)]
        HRESULT get_maximizeButton([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(19)]
        HRESULT put_border([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(20)]
        HRESULT get_border([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(21)]
        HRESULT put_borderStyle([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(22)]
        HRESULT get_borderStyle([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(23)]
        HRESULT put_sysMenu([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(24)]
        HRESULT get_sysMenu([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(25)]
        HRESULT put_caption([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(26)]
        HRESULT get_caption([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(27)]
        HRESULT put_windowState([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(28)]
        HRESULT get_windowState([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(29)]
        HRESULT put_showInTaskBar([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(30)]
        HRESULT get_showInTaskBar([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(31)]
        HRESULT get_commandLine([NativeTypeName("BSTR *")] ushort** p);
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

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_applicationName;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_applicationName;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_version;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_version;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_icon;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_icon;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_singleInstance;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_singleInstance;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_minimizeButton;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_minimizeButton;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_maximizeButton;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_maximizeButton;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_border;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_border;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_borderStyle;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_borderStyle;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_sysMenu;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_sysMenu;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_caption;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_caption;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_windowState;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_windowState;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_showInTaskBar;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_showInTaskBar;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_commandLine;
    }
}
