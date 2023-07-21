// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ExDisp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IWebBrowser.xml' path='doc/member[@name="IWebBrowser"]/*' />
[Guid("EAB22AC1-30C1-11CF-A7EB-0000C05BAE0B")]
[NativeTypeName("struct IWebBrowser : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IWebBrowser : IWebBrowser.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWebBrowser));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IWebBrowser*, Guid*, void**, int>)(lpVtbl[0]))((IWebBrowser*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IWebBrowser*, uint>)(lpVtbl[1]))((IWebBrowser*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IWebBrowser*, uint>)(lpVtbl[2]))((IWebBrowser*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfoCount" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IWebBrowser*, uint*, int>)(lpVtbl[3]))((IWebBrowser*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfo" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IWebBrowser*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IWebBrowser*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref="IDispatch.GetIDsOfNames" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IWebBrowser*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IWebBrowser*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref="IDispatch.Invoke" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IWebBrowser*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IWebBrowser*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='IWebBrowser.xml' path='doc/member[@name="IWebBrowser.GoBack"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GoBack()
    {
        return ((delegate* unmanaged<IWebBrowser*, int>)(lpVtbl[7]))((IWebBrowser*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IWebBrowser.xml' path='doc/member[@name="IWebBrowser.GoForward"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GoForward()
    {
        return ((delegate* unmanaged<IWebBrowser*, int>)(lpVtbl[8]))((IWebBrowser*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IWebBrowser.xml' path='doc/member[@name="IWebBrowser.GoHome"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GoHome()
    {
        return ((delegate* unmanaged<IWebBrowser*, int>)(lpVtbl[9]))((IWebBrowser*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IWebBrowser.xml' path='doc/member[@name="IWebBrowser.GoSearch"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GoSearch()
    {
        return ((delegate* unmanaged<IWebBrowser*, int>)(lpVtbl[10]))((IWebBrowser*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IWebBrowser.xml' path='doc/member[@name="IWebBrowser.Navigate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT Navigate([NativeTypeName("BSTR")] ushort* URL, VARIANT* Flags, VARIANT* TargetFrameName, VARIANT* PostData, VARIANT* Headers)
    {
        return ((delegate* unmanaged<IWebBrowser*, ushort*, VARIANT*, VARIANT*, VARIANT*, VARIANT*, int>)(lpVtbl[11]))((IWebBrowser*)Unsafe.AsPointer(ref this), URL, Flags, TargetFrameName, PostData, Headers);
    }

    /// <include file='IWebBrowser.xml' path='doc/member[@name="IWebBrowser.Refresh"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT Refresh()
    {
        return ((delegate* unmanaged<IWebBrowser*, int>)(lpVtbl[12]))((IWebBrowser*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IWebBrowser.xml' path='doc/member[@name="IWebBrowser.Refresh2"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT Refresh2(VARIANT* Level)
    {
        return ((delegate* unmanaged<IWebBrowser*, VARIANT*, int>)(lpVtbl[13]))((IWebBrowser*)Unsafe.AsPointer(ref this), Level);
    }

    /// <include file='IWebBrowser.xml' path='doc/member[@name="IWebBrowser.Stop"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT Stop()
    {
        return ((delegate* unmanaged<IWebBrowser*, int>)(lpVtbl[14]))((IWebBrowser*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IWebBrowser.xml' path='doc/member[@name="IWebBrowser.get_Application"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_Application(IDispatch** ppDisp)
    {
        return ((delegate* unmanaged<IWebBrowser*, IDispatch**, int>)(lpVtbl[15]))((IWebBrowser*)Unsafe.AsPointer(ref this), ppDisp);
    }

    /// <include file='IWebBrowser.xml' path='doc/member[@name="IWebBrowser.get_Parent"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_Parent(IDispatch** ppDisp)
    {
        return ((delegate* unmanaged<IWebBrowser*, IDispatch**, int>)(lpVtbl[16]))((IWebBrowser*)Unsafe.AsPointer(ref this), ppDisp);
    }

    /// <include file='IWebBrowser.xml' path='doc/member[@name="IWebBrowser.get_Container"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_Container(IDispatch** ppDisp)
    {
        return ((delegate* unmanaged<IWebBrowser*, IDispatch**, int>)(lpVtbl[17]))((IWebBrowser*)Unsafe.AsPointer(ref this), ppDisp);
    }

    /// <include file='IWebBrowser.xml' path='doc/member[@name="IWebBrowser.get_Document"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_Document(IDispatch** ppDisp)
    {
        return ((delegate* unmanaged<IWebBrowser*, IDispatch**, int>)(lpVtbl[18]))((IWebBrowser*)Unsafe.AsPointer(ref this), ppDisp);
    }

    /// <include file='IWebBrowser.xml' path='doc/member[@name="IWebBrowser.get_TopLevelContainer"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_TopLevelContainer([NativeTypeName("VARIANT_BOOL *")] short* pBool)
    {
        return ((delegate* unmanaged<IWebBrowser*, short*, int>)(lpVtbl[19]))((IWebBrowser*)Unsafe.AsPointer(ref this), pBool);
    }

    /// <include file='IWebBrowser.xml' path='doc/member[@name="IWebBrowser.get_Type"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_Type([NativeTypeName("BSTR *")] ushort** Type)
    {
        return ((delegate* unmanaged<IWebBrowser*, ushort**, int>)(lpVtbl[20]))((IWebBrowser*)Unsafe.AsPointer(ref this), Type);
    }

    /// <include file='IWebBrowser.xml' path='doc/member[@name="IWebBrowser.get_Left"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT get_Left([NativeTypeName("long *")] int* pl)
    {
        return ((delegate* unmanaged<IWebBrowser*, int*, int>)(lpVtbl[21]))((IWebBrowser*)Unsafe.AsPointer(ref this), pl);
    }

    /// <include file='IWebBrowser.xml' path='doc/member[@name="IWebBrowser.put_Left"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT put_Left([NativeTypeName("long")] int Left)
    {
        return ((delegate* unmanaged<IWebBrowser*, int, int>)(lpVtbl[22]))((IWebBrowser*)Unsafe.AsPointer(ref this), Left);
    }

    /// <include file='IWebBrowser.xml' path='doc/member[@name="IWebBrowser.get_Top"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT get_Top([NativeTypeName("long *")] int* pl)
    {
        return ((delegate* unmanaged<IWebBrowser*, int*, int>)(lpVtbl[23]))((IWebBrowser*)Unsafe.AsPointer(ref this), pl);
    }

    /// <include file='IWebBrowser.xml' path='doc/member[@name="IWebBrowser.put_Top"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT put_Top([NativeTypeName("long")] int Top)
    {
        return ((delegate* unmanaged<IWebBrowser*, int, int>)(lpVtbl[24]))((IWebBrowser*)Unsafe.AsPointer(ref this), Top);
    }

    /// <include file='IWebBrowser.xml' path='doc/member[@name="IWebBrowser.get_Width"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT get_Width([NativeTypeName("long *")] int* pl)
    {
        return ((delegate* unmanaged<IWebBrowser*, int*, int>)(lpVtbl[25]))((IWebBrowser*)Unsafe.AsPointer(ref this), pl);
    }

    /// <include file='IWebBrowser.xml' path='doc/member[@name="IWebBrowser.put_Width"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT put_Width([NativeTypeName("long")] int Width)
    {
        return ((delegate* unmanaged<IWebBrowser*, int, int>)(lpVtbl[26]))((IWebBrowser*)Unsafe.AsPointer(ref this), Width);
    }

    /// <include file='IWebBrowser.xml' path='doc/member[@name="IWebBrowser.get_Height"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT get_Height([NativeTypeName("long *")] int* pl)
    {
        return ((delegate* unmanaged<IWebBrowser*, int*, int>)(lpVtbl[27]))((IWebBrowser*)Unsafe.AsPointer(ref this), pl);
    }

    /// <include file='IWebBrowser.xml' path='doc/member[@name="IWebBrowser.put_Height"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT put_Height([NativeTypeName("long")] int Height)
    {
        return ((delegate* unmanaged<IWebBrowser*, int, int>)(lpVtbl[28]))((IWebBrowser*)Unsafe.AsPointer(ref this), Height);
    }

    /// <include file='IWebBrowser.xml' path='doc/member[@name="IWebBrowser.get_LocationName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT get_LocationName([NativeTypeName("BSTR *")] ushort** LocationName)
    {
        return ((delegate* unmanaged<IWebBrowser*, ushort**, int>)(lpVtbl[29]))((IWebBrowser*)Unsafe.AsPointer(ref this), LocationName);
    }

    /// <include file='IWebBrowser.xml' path='doc/member[@name="IWebBrowser.get_LocationURL"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT get_LocationURL([NativeTypeName("BSTR *")] ushort** LocationURL)
    {
        return ((delegate* unmanaged<IWebBrowser*, ushort**, int>)(lpVtbl[30]))((IWebBrowser*)Unsafe.AsPointer(ref this), LocationURL);
    }

    /// <include file='IWebBrowser.xml' path='doc/member[@name="IWebBrowser.get_Busy"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT get_Busy([NativeTypeName("VARIANT_BOOL *")] short* pBool)
    {
        return ((delegate* unmanaged<IWebBrowser*, short*, int>)(lpVtbl[31]))((IWebBrowser*)Unsafe.AsPointer(ref this), pBool);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT GoBack();

        [VtblIndex(8)]
        HRESULT GoForward();

        [VtblIndex(9)]
        HRESULT GoHome();

        [VtblIndex(10)]
        HRESULT GoSearch();

        [VtblIndex(11)]
        HRESULT Navigate([NativeTypeName("BSTR")] ushort* URL, VARIANT* Flags, VARIANT* TargetFrameName, VARIANT* PostData, VARIANT* Headers);

        [VtblIndex(12)]
        HRESULT Refresh();

        [VtblIndex(13)]
        HRESULT Refresh2(VARIANT* Level);

        [VtblIndex(14)]
        HRESULT Stop();

        [VtblIndex(15)]
        HRESULT get_Application(IDispatch** ppDisp);

        [VtblIndex(16)]
        HRESULT get_Parent(IDispatch** ppDisp);

        [VtblIndex(17)]
        HRESULT get_Container(IDispatch** ppDisp);

        [VtblIndex(18)]
        HRESULT get_Document(IDispatch** ppDisp);

        [VtblIndex(19)]
        HRESULT get_TopLevelContainer([NativeTypeName("VARIANT_BOOL *")] short* pBool);

        [VtblIndex(20)]
        HRESULT get_Type([NativeTypeName("BSTR *")] ushort** Type);

        [VtblIndex(21)]
        HRESULT get_Left([NativeTypeName("long *")] int* pl);

        [VtblIndex(22)]
        HRESULT put_Left([NativeTypeName("long")] int Left);

        [VtblIndex(23)]
        HRESULT get_Top([NativeTypeName("long *")] int* pl);

        [VtblIndex(24)]
        HRESULT put_Top([NativeTypeName("long")] int Top);

        [VtblIndex(25)]
        HRESULT get_Width([NativeTypeName("long *")] int* pl);

        [VtblIndex(26)]
        HRESULT put_Width([NativeTypeName("long")] int Width);

        [VtblIndex(27)]
        HRESULT get_Height([NativeTypeName("long *")] int* pl);

        [VtblIndex(28)]
        HRESULT put_Height([NativeTypeName("long")] int Height);

        [VtblIndex(29)]
        HRESULT get_LocationName([NativeTypeName("BSTR *")] ushort** LocationName);

        [VtblIndex(30)]
        HRESULT get_LocationURL([NativeTypeName("BSTR *")] ushort** LocationURL);

        [VtblIndex(31)]
        HRESULT get_Busy([NativeTypeName("VARIANT_BOOL *")] short* pBool);
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

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> GoBack;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> GoForward;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> GoHome;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> GoSearch;

        [NativeTypeName("HRESULT (BSTR, VARIANT *, VARIANT *, VARIANT *, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, VARIANT*, VARIANT*, VARIANT*, VARIANT*, int> Navigate;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Refresh;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> Refresh2;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Stop;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch**, int> get_Application;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch**, int> get_Parent;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch**, int> get_Container;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch**, int> get_Document;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_TopLevelContainer;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_Type;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_Left;

        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_Left;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_Top;

        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_Top;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_Width;

        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_Width;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_Height;

        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_Height;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_LocationName;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_LocationURL;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_Busy;
    }
}
