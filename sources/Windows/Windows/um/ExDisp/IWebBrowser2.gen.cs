// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ExDisp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IWebBrowser2.xml' path='doc/member[@name="IWebBrowser2"]/*' />
[Guid("D30C1661-CDAF-11D0-8A3E-00C04FC9E26E")]
[NativeTypeName("struct IWebBrowser2 : IWebBrowserApp")]
[NativeInheritance("IWebBrowserApp")]
public unsafe partial struct IWebBrowser2 : IWebBrowser2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWebBrowser2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IWebBrowser2*, Guid*, void**, int>)(lpVtbl[0]))((IWebBrowser2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IWebBrowser2*, uint>)(lpVtbl[1]))((IWebBrowser2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IWebBrowser2*, uint>)(lpVtbl[2]))((IWebBrowser2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfoCount" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IWebBrowser2*, uint*, int>)(lpVtbl[3]))((IWebBrowser2*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfo" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IWebBrowser2*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IWebBrowser2*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref="IDispatch.GetIDsOfNames" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IWebBrowser2*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IWebBrowser2*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref="IDispatch.Invoke" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IWebBrowser2*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IWebBrowser2*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <inheritdoc cref="IWebBrowser.GoBack" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GoBack()
    {
        return ((delegate* unmanaged<IWebBrowser2*, int>)(lpVtbl[7]))((IWebBrowser2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IWebBrowser.GoForward" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GoForward()
    {
        return ((delegate* unmanaged<IWebBrowser2*, int>)(lpVtbl[8]))((IWebBrowser2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IWebBrowser.GoHome" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GoHome()
    {
        return ((delegate* unmanaged<IWebBrowser2*, int>)(lpVtbl[9]))((IWebBrowser2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IWebBrowser.GoSearch" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GoSearch()
    {
        return ((delegate* unmanaged<IWebBrowser2*, int>)(lpVtbl[10]))((IWebBrowser2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IWebBrowser.Navigate" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT Navigate([NativeTypeName("BSTR")] ushort* URL, VARIANT* Flags, VARIANT* TargetFrameName, VARIANT* PostData, VARIANT* Headers)
    {
        return ((delegate* unmanaged<IWebBrowser2*, ushort*, VARIANT*, VARIANT*, VARIANT*, VARIANT*, int>)(lpVtbl[11]))((IWebBrowser2*)Unsafe.AsPointer(ref this), URL, Flags, TargetFrameName, PostData, Headers);
    }

    /// <inheritdoc cref="IWebBrowser.Refresh" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT Refresh()
    {
        return ((delegate* unmanaged<IWebBrowser2*, int>)(lpVtbl[12]))((IWebBrowser2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IWebBrowser.Refresh2" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT Refresh2(VARIANT* Level)
    {
        return ((delegate* unmanaged<IWebBrowser2*, VARIANT*, int>)(lpVtbl[13]))((IWebBrowser2*)Unsafe.AsPointer(ref this), Level);
    }

    /// <inheritdoc cref="IWebBrowser.Stop" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT Stop()
    {
        return ((delegate* unmanaged<IWebBrowser2*, int>)(lpVtbl[14]))((IWebBrowser2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IWebBrowser.get_Application" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_Application(IDispatch** ppDisp)
    {
        return ((delegate* unmanaged<IWebBrowser2*, IDispatch**, int>)(lpVtbl[15]))((IWebBrowser2*)Unsafe.AsPointer(ref this), ppDisp);
    }

    /// <inheritdoc cref="IWebBrowser.get_Parent" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_Parent(IDispatch** ppDisp)
    {
        return ((delegate* unmanaged<IWebBrowser2*, IDispatch**, int>)(lpVtbl[16]))((IWebBrowser2*)Unsafe.AsPointer(ref this), ppDisp);
    }

    /// <inheritdoc cref="IWebBrowser.get_Container" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_Container(IDispatch** ppDisp)
    {
        return ((delegate* unmanaged<IWebBrowser2*, IDispatch**, int>)(lpVtbl[17]))((IWebBrowser2*)Unsafe.AsPointer(ref this), ppDisp);
    }

    /// <inheritdoc cref="IWebBrowser.get_Document" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_Document(IDispatch** ppDisp)
    {
        return ((delegate* unmanaged<IWebBrowser2*, IDispatch**, int>)(lpVtbl[18]))((IWebBrowser2*)Unsafe.AsPointer(ref this), ppDisp);
    }

    /// <inheritdoc cref="IWebBrowser.get_TopLevelContainer" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_TopLevelContainer([NativeTypeName("VARIANT_BOOL *")] short* pBool)
    {
        return ((delegate* unmanaged<IWebBrowser2*, short*, int>)(lpVtbl[19]))((IWebBrowser2*)Unsafe.AsPointer(ref this), pBool);
    }

    /// <inheritdoc cref="IWebBrowser.get_Type" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_Type([NativeTypeName("BSTR *")] ushort** Type)
    {
        return ((delegate* unmanaged<IWebBrowser2*, ushort**, int>)(lpVtbl[20]))((IWebBrowser2*)Unsafe.AsPointer(ref this), Type);
    }

    /// <inheritdoc cref="IWebBrowser.get_Left" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT get_Left([NativeTypeName("long *")] int* pl)
    {
        return ((delegate* unmanaged<IWebBrowser2*, int*, int>)(lpVtbl[21]))((IWebBrowser2*)Unsafe.AsPointer(ref this), pl);
    }

    /// <inheritdoc cref="IWebBrowser.put_Left" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT put_Left([NativeTypeName("long")] int Left)
    {
        return ((delegate* unmanaged<IWebBrowser2*, int, int>)(lpVtbl[22]))((IWebBrowser2*)Unsafe.AsPointer(ref this), Left);
    }

    /// <inheritdoc cref="IWebBrowser.get_Top" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT get_Top([NativeTypeName("long *")] int* pl)
    {
        return ((delegate* unmanaged<IWebBrowser2*, int*, int>)(lpVtbl[23]))((IWebBrowser2*)Unsafe.AsPointer(ref this), pl);
    }

    /// <inheritdoc cref="IWebBrowser.put_Top" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT put_Top([NativeTypeName("long")] int Top)
    {
        return ((delegate* unmanaged<IWebBrowser2*, int, int>)(lpVtbl[24]))((IWebBrowser2*)Unsafe.AsPointer(ref this), Top);
    }

    /// <inheritdoc cref="IWebBrowser.get_Width" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT get_Width([NativeTypeName("long *")] int* pl)
    {
        return ((delegate* unmanaged<IWebBrowser2*, int*, int>)(lpVtbl[25]))((IWebBrowser2*)Unsafe.AsPointer(ref this), pl);
    }

    /// <inheritdoc cref="IWebBrowser.put_Width" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT put_Width([NativeTypeName("long")] int Width)
    {
        return ((delegate* unmanaged<IWebBrowser2*, int, int>)(lpVtbl[26]))((IWebBrowser2*)Unsafe.AsPointer(ref this), Width);
    }

    /// <inheritdoc cref="IWebBrowser.get_Height" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT get_Height([NativeTypeName("long *")] int* pl)
    {
        return ((delegate* unmanaged<IWebBrowser2*, int*, int>)(lpVtbl[27]))((IWebBrowser2*)Unsafe.AsPointer(ref this), pl);
    }

    /// <inheritdoc cref="IWebBrowser.put_Height" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT put_Height([NativeTypeName("long")] int Height)
    {
        return ((delegate* unmanaged<IWebBrowser2*, int, int>)(lpVtbl[28]))((IWebBrowser2*)Unsafe.AsPointer(ref this), Height);
    }

    /// <inheritdoc cref="IWebBrowser.get_LocationName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT get_LocationName([NativeTypeName("BSTR *")] ushort** LocationName)
    {
        return ((delegate* unmanaged<IWebBrowser2*, ushort**, int>)(lpVtbl[29]))((IWebBrowser2*)Unsafe.AsPointer(ref this), LocationName);
    }

    /// <inheritdoc cref="IWebBrowser.get_LocationURL" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT get_LocationURL([NativeTypeName("BSTR *")] ushort** LocationURL)
    {
        return ((delegate* unmanaged<IWebBrowser2*, ushort**, int>)(lpVtbl[30]))((IWebBrowser2*)Unsafe.AsPointer(ref this), LocationURL);
    }

    /// <inheritdoc cref="IWebBrowser.get_Busy" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT get_Busy([NativeTypeName("VARIANT_BOOL *")] short* pBool)
    {
        return ((delegate* unmanaged<IWebBrowser2*, short*, int>)(lpVtbl[31]))((IWebBrowser2*)Unsafe.AsPointer(ref this), pBool);
    }

    /// <inheritdoc cref="IWebBrowserApp.Quit" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT Quit()
    {
        return ((delegate* unmanaged<IWebBrowser2*, int>)(lpVtbl[32]))((IWebBrowser2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IWebBrowserApp.ClientToWindow" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT ClientToWindow(int* pcx, int* pcy)
    {
        return ((delegate* unmanaged<IWebBrowser2*, int*, int*, int>)(lpVtbl[33]))((IWebBrowser2*)Unsafe.AsPointer(ref this), pcx, pcy);
    }

    /// <inheritdoc cref="IWebBrowserApp.PutProperty" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT PutProperty([NativeTypeName("BSTR")] ushort* Property, VARIANT vtValue)
    {
        return ((delegate* unmanaged<IWebBrowser2*, ushort*, VARIANT, int>)(lpVtbl[34]))((IWebBrowser2*)Unsafe.AsPointer(ref this), Property, vtValue);
    }

    /// <inheritdoc cref="IWebBrowserApp.GetProperty" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT GetProperty([NativeTypeName("BSTR")] ushort* Property, VARIANT* pvtValue)
    {
        return ((delegate* unmanaged<IWebBrowser2*, ushort*, VARIANT*, int>)(lpVtbl[35]))((IWebBrowser2*)Unsafe.AsPointer(ref this), Property, pvtValue);
    }

    /// <inheritdoc cref="IWebBrowserApp.get_Name" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT get_Name([NativeTypeName("BSTR *")] ushort** Name)
    {
        return ((delegate* unmanaged<IWebBrowser2*, ushort**, int>)(lpVtbl[36]))((IWebBrowser2*)Unsafe.AsPointer(ref this), Name);
    }

    /// <inheritdoc cref="IWebBrowserApp.get_HWND" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public HRESULT get_HWND([NativeTypeName("SHANDLE_PTR *")] nint* pHWND)
    {
        return ((delegate* unmanaged<IWebBrowser2*, nint*, int>)(lpVtbl[37]))((IWebBrowser2*)Unsafe.AsPointer(ref this), pHWND);
    }

    /// <inheritdoc cref="IWebBrowserApp.get_FullName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public HRESULT get_FullName([NativeTypeName("BSTR *")] ushort** FullName)
    {
        return ((delegate* unmanaged<IWebBrowser2*, ushort**, int>)(lpVtbl[38]))((IWebBrowser2*)Unsafe.AsPointer(ref this), FullName);
    }

    /// <inheritdoc cref="IWebBrowserApp.get_Path" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    public HRESULT get_Path([NativeTypeName("BSTR *")] ushort** Path)
    {
        return ((delegate* unmanaged<IWebBrowser2*, ushort**, int>)(lpVtbl[39]))((IWebBrowser2*)Unsafe.AsPointer(ref this), Path);
    }

    /// <inheritdoc cref="IWebBrowserApp.get_Visible" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(40)]
    public HRESULT get_Visible([NativeTypeName("VARIANT_BOOL *")] short* pBool)
    {
        return ((delegate* unmanaged<IWebBrowser2*, short*, int>)(lpVtbl[40]))((IWebBrowser2*)Unsafe.AsPointer(ref this), pBool);
    }

    /// <inheritdoc cref="IWebBrowserApp.put_Visible" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(41)]
    public HRESULT put_Visible([NativeTypeName("VARIANT_BOOL")] short Value)
    {
        return ((delegate* unmanaged<IWebBrowser2*, short, int>)(lpVtbl[41]))((IWebBrowser2*)Unsafe.AsPointer(ref this), Value);
    }

    /// <inheritdoc cref="IWebBrowserApp.get_StatusBar" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(42)]
    public HRESULT get_StatusBar([NativeTypeName("VARIANT_BOOL *")] short* pBool)
    {
        return ((delegate* unmanaged<IWebBrowser2*, short*, int>)(lpVtbl[42]))((IWebBrowser2*)Unsafe.AsPointer(ref this), pBool);
    }

    /// <inheritdoc cref="IWebBrowserApp.put_StatusBar" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(43)]
    public HRESULT put_StatusBar([NativeTypeName("VARIANT_BOOL")] short Value)
    {
        return ((delegate* unmanaged<IWebBrowser2*, short, int>)(lpVtbl[43]))((IWebBrowser2*)Unsafe.AsPointer(ref this), Value);
    }

    /// <inheritdoc cref="IWebBrowserApp.get_StatusText" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(44)]
    public HRESULT get_StatusText([NativeTypeName("BSTR *")] ushort** StatusText)
    {
        return ((delegate* unmanaged<IWebBrowser2*, ushort**, int>)(lpVtbl[44]))((IWebBrowser2*)Unsafe.AsPointer(ref this), StatusText);
    }

    /// <inheritdoc cref="IWebBrowserApp.put_StatusText" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(45)]
    public HRESULT put_StatusText([NativeTypeName("BSTR")] ushort* StatusText)
    {
        return ((delegate* unmanaged<IWebBrowser2*, ushort*, int>)(lpVtbl[45]))((IWebBrowser2*)Unsafe.AsPointer(ref this), StatusText);
    }

    /// <inheritdoc cref="IWebBrowserApp.get_ToolBar" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(46)]
    public HRESULT get_ToolBar(int* Value)
    {
        return ((delegate* unmanaged<IWebBrowser2*, int*, int>)(lpVtbl[46]))((IWebBrowser2*)Unsafe.AsPointer(ref this), Value);
    }

    /// <inheritdoc cref="IWebBrowserApp.put_ToolBar" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(47)]
    public HRESULT put_ToolBar(int Value)
    {
        return ((delegate* unmanaged<IWebBrowser2*, int, int>)(lpVtbl[47]))((IWebBrowser2*)Unsafe.AsPointer(ref this), Value);
    }

    /// <inheritdoc cref="IWebBrowserApp.get_MenuBar" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(48)]
    public HRESULT get_MenuBar([NativeTypeName("VARIANT_BOOL *")] short* Value)
    {
        return ((delegate* unmanaged<IWebBrowser2*, short*, int>)(lpVtbl[48]))((IWebBrowser2*)Unsafe.AsPointer(ref this), Value);
    }

    /// <inheritdoc cref="IWebBrowserApp.put_MenuBar" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(49)]
    public HRESULT put_MenuBar([NativeTypeName("VARIANT_BOOL")] short Value)
    {
        return ((delegate* unmanaged<IWebBrowser2*, short, int>)(lpVtbl[49]))((IWebBrowser2*)Unsafe.AsPointer(ref this), Value);
    }

    /// <inheritdoc cref="IWebBrowserApp.get_FullScreen" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(50)]
    public HRESULT get_FullScreen([NativeTypeName("VARIANT_BOOL *")] short* pbFullScreen)
    {
        return ((delegate* unmanaged<IWebBrowser2*, short*, int>)(lpVtbl[50]))((IWebBrowser2*)Unsafe.AsPointer(ref this), pbFullScreen);
    }

    /// <inheritdoc cref="IWebBrowserApp.put_FullScreen" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(51)]
    public HRESULT put_FullScreen([NativeTypeName("VARIANT_BOOL")] short bFullScreen)
    {
        return ((delegate* unmanaged<IWebBrowser2*, short, int>)(lpVtbl[51]))((IWebBrowser2*)Unsafe.AsPointer(ref this), bFullScreen);
    }

    /// <include file='IWebBrowser2.xml' path='doc/member[@name="IWebBrowser2.Navigate2"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(52)]
    public HRESULT Navigate2(VARIANT* URL, VARIANT* Flags, VARIANT* TargetFrameName, VARIANT* PostData, VARIANT* Headers)
    {
        return ((delegate* unmanaged<IWebBrowser2*, VARIANT*, VARIANT*, VARIANT*, VARIANT*, VARIANT*, int>)(lpVtbl[52]))((IWebBrowser2*)Unsafe.AsPointer(ref this), URL, Flags, TargetFrameName, PostData, Headers);
    }

    /// <include file='IWebBrowser2.xml' path='doc/member[@name="IWebBrowser2.QueryStatusWB"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(53)]
    public HRESULT QueryStatusWB(OLECMDID cmdID, OLECMDF* pcmdf)
    {
        return ((delegate* unmanaged<IWebBrowser2*, OLECMDID, OLECMDF*, int>)(lpVtbl[53]))((IWebBrowser2*)Unsafe.AsPointer(ref this), cmdID, pcmdf);
    }

    /// <include file='IWebBrowser2.xml' path='doc/member[@name="IWebBrowser2.ExecWB"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(54)]
    public HRESULT ExecWB(OLECMDID cmdID, OLECMDEXECOPT cmdexecopt, VARIANT* pvaIn, VARIANT* pvaOut)
    {
        return ((delegate* unmanaged<IWebBrowser2*, OLECMDID, OLECMDEXECOPT, VARIANT*, VARIANT*, int>)(lpVtbl[54]))((IWebBrowser2*)Unsafe.AsPointer(ref this), cmdID, cmdexecopt, pvaIn, pvaOut);
    }

    /// <include file='IWebBrowser2.xml' path='doc/member[@name="IWebBrowser2.ShowBrowserBar"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(55)]
    public HRESULT ShowBrowserBar(VARIANT* pvaClsid, VARIANT* pvarShow, VARIANT* pvarSize)
    {
        return ((delegate* unmanaged<IWebBrowser2*, VARIANT*, VARIANT*, VARIANT*, int>)(lpVtbl[55]))((IWebBrowser2*)Unsafe.AsPointer(ref this), pvaClsid, pvarShow, pvarSize);
    }

    /// <include file='IWebBrowser2.xml' path='doc/member[@name="IWebBrowser2.get_ReadyState"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(56)]
    public HRESULT get_ReadyState(READYSTATE* plReadyState)
    {
        return ((delegate* unmanaged<IWebBrowser2*, READYSTATE*, int>)(lpVtbl[56]))((IWebBrowser2*)Unsafe.AsPointer(ref this), plReadyState);
    }

    /// <include file='IWebBrowser2.xml' path='doc/member[@name="IWebBrowser2.get_Offline"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(57)]
    public HRESULT get_Offline([NativeTypeName("VARIANT_BOOL *")] short* pbOffline)
    {
        return ((delegate* unmanaged<IWebBrowser2*, short*, int>)(lpVtbl[57]))((IWebBrowser2*)Unsafe.AsPointer(ref this), pbOffline);
    }

    /// <include file='IWebBrowser2.xml' path='doc/member[@name="IWebBrowser2.put_Offline"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(58)]
    public HRESULT put_Offline([NativeTypeName("VARIANT_BOOL")] short bOffline)
    {
        return ((delegate* unmanaged<IWebBrowser2*, short, int>)(lpVtbl[58]))((IWebBrowser2*)Unsafe.AsPointer(ref this), bOffline);
    }

    /// <include file='IWebBrowser2.xml' path='doc/member[@name="IWebBrowser2.get_Silent"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(59)]
    public HRESULT get_Silent([NativeTypeName("VARIANT_BOOL *")] short* pbSilent)
    {
        return ((delegate* unmanaged<IWebBrowser2*, short*, int>)(lpVtbl[59]))((IWebBrowser2*)Unsafe.AsPointer(ref this), pbSilent);
    }

    /// <include file='IWebBrowser2.xml' path='doc/member[@name="IWebBrowser2.put_Silent"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(60)]
    public HRESULT put_Silent([NativeTypeName("VARIANT_BOOL")] short bSilent)
    {
        return ((delegate* unmanaged<IWebBrowser2*, short, int>)(lpVtbl[60]))((IWebBrowser2*)Unsafe.AsPointer(ref this), bSilent);
    }

    /// <include file='IWebBrowser2.xml' path='doc/member[@name="IWebBrowser2.get_RegisterAsBrowser"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(61)]
    public HRESULT get_RegisterAsBrowser([NativeTypeName("VARIANT_BOOL *")] short* pbRegister)
    {
        return ((delegate* unmanaged<IWebBrowser2*, short*, int>)(lpVtbl[61]))((IWebBrowser2*)Unsafe.AsPointer(ref this), pbRegister);
    }

    /// <include file='IWebBrowser2.xml' path='doc/member[@name="IWebBrowser2.put_RegisterAsBrowser"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(62)]
    public HRESULT put_RegisterAsBrowser([NativeTypeName("VARIANT_BOOL")] short bRegister)
    {
        return ((delegate* unmanaged<IWebBrowser2*, short, int>)(lpVtbl[62]))((IWebBrowser2*)Unsafe.AsPointer(ref this), bRegister);
    }

    /// <include file='IWebBrowser2.xml' path='doc/member[@name="IWebBrowser2.get_RegisterAsDropTarget"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(63)]
    public HRESULT get_RegisterAsDropTarget([NativeTypeName("VARIANT_BOOL *")] short* pbRegister)
    {
        return ((delegate* unmanaged<IWebBrowser2*, short*, int>)(lpVtbl[63]))((IWebBrowser2*)Unsafe.AsPointer(ref this), pbRegister);
    }

    /// <include file='IWebBrowser2.xml' path='doc/member[@name="IWebBrowser2.put_RegisterAsDropTarget"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(64)]
    public HRESULT put_RegisterAsDropTarget([NativeTypeName("VARIANT_BOOL")] short bRegister)
    {
        return ((delegate* unmanaged<IWebBrowser2*, short, int>)(lpVtbl[64]))((IWebBrowser2*)Unsafe.AsPointer(ref this), bRegister);
    }

    /// <include file='IWebBrowser2.xml' path='doc/member[@name="IWebBrowser2.get_TheaterMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(65)]
    public HRESULT get_TheaterMode([NativeTypeName("VARIANT_BOOL *")] short* pbRegister)
    {
        return ((delegate* unmanaged<IWebBrowser2*, short*, int>)(lpVtbl[65]))((IWebBrowser2*)Unsafe.AsPointer(ref this), pbRegister);
    }

    /// <include file='IWebBrowser2.xml' path='doc/member[@name="IWebBrowser2.put_TheaterMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(66)]
    public HRESULT put_TheaterMode([NativeTypeName("VARIANT_BOOL")] short bRegister)
    {
        return ((delegate* unmanaged<IWebBrowser2*, short, int>)(lpVtbl[66]))((IWebBrowser2*)Unsafe.AsPointer(ref this), bRegister);
    }

    /// <include file='IWebBrowser2.xml' path='doc/member[@name="IWebBrowser2.get_AddressBar"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(67)]
    public HRESULT get_AddressBar([NativeTypeName("VARIANT_BOOL *")] short* Value)
    {
        return ((delegate* unmanaged<IWebBrowser2*, short*, int>)(lpVtbl[67]))((IWebBrowser2*)Unsafe.AsPointer(ref this), Value);
    }

    /// <include file='IWebBrowser2.xml' path='doc/member[@name="IWebBrowser2.put_AddressBar"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(68)]
    public HRESULT put_AddressBar([NativeTypeName("VARIANT_BOOL")] short Value)
    {
        return ((delegate* unmanaged<IWebBrowser2*, short, int>)(lpVtbl[68]))((IWebBrowser2*)Unsafe.AsPointer(ref this), Value);
    }

    /// <include file='IWebBrowser2.xml' path='doc/member[@name="IWebBrowser2.get_Resizable"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(69)]
    public HRESULT get_Resizable([NativeTypeName("VARIANT_BOOL *")] short* Value)
    {
        return ((delegate* unmanaged<IWebBrowser2*, short*, int>)(lpVtbl[69]))((IWebBrowser2*)Unsafe.AsPointer(ref this), Value);
    }

    /// <include file='IWebBrowser2.xml' path='doc/member[@name="IWebBrowser2.put_Resizable"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(70)]
    public HRESULT put_Resizable([NativeTypeName("VARIANT_BOOL")] short Value)
    {
        return ((delegate* unmanaged<IWebBrowser2*, short, int>)(lpVtbl[70]))((IWebBrowser2*)Unsafe.AsPointer(ref this), Value);
    }

    public interface Interface : IWebBrowserApp.Interface
    {
        [VtblIndex(52)]
        HRESULT Navigate2(VARIANT* URL, VARIANT* Flags, VARIANT* TargetFrameName, VARIANT* PostData, VARIANT* Headers);

        [VtblIndex(53)]
        HRESULT QueryStatusWB(OLECMDID cmdID, OLECMDF* pcmdf);

        [VtblIndex(54)]
        HRESULT ExecWB(OLECMDID cmdID, OLECMDEXECOPT cmdexecopt, VARIANT* pvaIn, VARIANT* pvaOut);

        [VtblIndex(55)]
        HRESULT ShowBrowserBar(VARIANT* pvaClsid, VARIANT* pvarShow, VARIANT* pvarSize);

        [VtblIndex(56)]
        HRESULT get_ReadyState(READYSTATE* plReadyState);

        [VtblIndex(57)]
        HRESULT get_Offline([NativeTypeName("VARIANT_BOOL *")] short* pbOffline);

        [VtblIndex(58)]
        HRESULT put_Offline([NativeTypeName("VARIANT_BOOL")] short bOffline);

        [VtblIndex(59)]
        HRESULT get_Silent([NativeTypeName("VARIANT_BOOL *")] short* pbSilent);

        [VtblIndex(60)]
        HRESULT put_Silent([NativeTypeName("VARIANT_BOOL")] short bSilent);

        [VtblIndex(61)]
        HRESULT get_RegisterAsBrowser([NativeTypeName("VARIANT_BOOL *")] short* pbRegister);

        [VtblIndex(62)]
        HRESULT put_RegisterAsBrowser([NativeTypeName("VARIANT_BOOL")] short bRegister);

        [VtblIndex(63)]
        HRESULT get_RegisterAsDropTarget([NativeTypeName("VARIANT_BOOL *")] short* pbRegister);

        [VtblIndex(64)]
        HRESULT put_RegisterAsDropTarget([NativeTypeName("VARIANT_BOOL")] short bRegister);

        [VtblIndex(65)]
        HRESULT get_TheaterMode([NativeTypeName("VARIANT_BOOL *")] short* pbRegister);

        [VtblIndex(66)]
        HRESULT put_TheaterMode([NativeTypeName("VARIANT_BOOL")] short bRegister);

        [VtblIndex(67)]
        HRESULT get_AddressBar([NativeTypeName("VARIANT_BOOL *")] short* Value);

        [VtblIndex(68)]
        HRESULT put_AddressBar([NativeTypeName("VARIANT_BOOL")] short Value);

        [VtblIndex(69)]
        HRESULT get_Resizable([NativeTypeName("VARIANT_BOOL *")] short* Value);

        [VtblIndex(70)]
        HRESULT put_Resizable([NativeTypeName("VARIANT_BOOL")] short Value);
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

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Quit;

        [NativeTypeName("HRESULT (int *, int *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int*, int> ClientToWindow;

        [NativeTypeName("HRESULT (BSTR, VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, VARIANT, int> PutProperty;

        [NativeTypeName("HRESULT (BSTR, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, VARIANT*, int> GetProperty;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_Name;

        [NativeTypeName("HRESULT (SHANDLE_PTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, nint*, int> get_HWND;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_FullName;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_Path;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_Visible;

        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> put_Visible;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_StatusBar;

        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> put_StatusBar;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_StatusText;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_StatusText;

        [NativeTypeName("HRESULT (int *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_ToolBar;

        [NativeTypeName("HRESULT (int) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_ToolBar;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_MenuBar;

        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> put_MenuBar;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_FullScreen;

        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> put_FullScreen;

        [NativeTypeName("HRESULT (VARIANT *, VARIANT *, VARIANT *, VARIANT *, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, VARIANT*, VARIANT*, VARIANT*, VARIANT*, int> Navigate2;

        [NativeTypeName("HRESULT (OLECMDID, OLECMDF *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, OLECMDID, OLECMDF*, int> QueryStatusWB;

        [NativeTypeName("HRESULT (OLECMDID, OLECMDEXECOPT, VARIANT *, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, OLECMDID, OLECMDEXECOPT, VARIANT*, VARIANT*, int> ExecWB;

        [NativeTypeName("HRESULT (VARIANT *, VARIANT *, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, VARIANT*, VARIANT*, int> ShowBrowserBar;

        [NativeTypeName("HRESULT (READYSTATE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, READYSTATE*, int> get_ReadyState;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_Offline;

        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> put_Offline;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_Silent;

        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> put_Silent;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_RegisterAsBrowser;

        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> put_RegisterAsBrowser;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_RegisterAsDropTarget;

        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> put_RegisterAsDropTarget;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_TheaterMode;

        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> put_TheaterMode;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_AddressBar;

        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> put_AddressBar;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_Resizable;

        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> put_Resizable;
    }
}
