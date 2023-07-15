// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/control.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IVideoWindow.xml' path='doc/member[@name="IVideoWindow"]/*'/>
[Guid("56A868B4-0AD4-11CE-B03A-0020AF0BA770")]
[NativeTypeName("struct IVideoWindow : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IVideoWindow : IVideoWindow.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IVideoWindow));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IVideoWindow*, Guid*, void**, int> )(lpVtbl[0]))((IVideoWindow*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IVideoWindow*, uint> )(lpVtbl[1]))((IVideoWindow*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IVideoWindow*, uint> )(lpVtbl[2]))((IVideoWindow*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfoCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IVideoWindow*, uint*, int> )(lpVtbl[3]))((IVideoWindow*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IVideoWindow*, uint, uint, ITypeInfo**, int> )(lpVtbl[4]))((IVideoWindow*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref = "IDispatch.GetIDsOfNames"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IVideoWindow*, Guid*, ushort**, uint, uint, int*, int> )(lpVtbl[5]))((IVideoWindow*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref = "IDispatch.Invoke"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IVideoWindow*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> )(lpVtbl[6]))((IVideoWindow*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='IVideoWindow.xml' path='doc/member[@name="IVideoWindow.put_Caption"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Caption([NativeTypeName("BSTR")] ushort* strCaption)
    {
        return ((delegate* unmanaged<IVideoWindow*, ushort*, int> )(lpVtbl[7]))((IVideoWindow*)Unsafe.AsPointer(ref this), strCaption);
    }

    /// <include file='IVideoWindow.xml' path='doc/member[@name="IVideoWindow.get_Caption"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Caption([NativeTypeName("BSTR *")] ushort** strCaption)
    {
        return ((delegate* unmanaged<IVideoWindow*, ushort**, int> )(lpVtbl[8]))((IVideoWindow*)Unsafe.AsPointer(ref this), strCaption);
    }

    /// <include file='IVideoWindow.xml' path='doc/member[@name="IVideoWindow.put_WindowStyle"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_WindowStyle([NativeTypeName("long")] int WindowStyle)
    {
        return ((delegate* unmanaged<IVideoWindow*, int, int> )(lpVtbl[9]))((IVideoWindow*)Unsafe.AsPointer(ref this), WindowStyle);
    }

    /// <include file='IVideoWindow.xml' path='doc/member[@name="IVideoWindow.get_WindowStyle"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_WindowStyle([NativeTypeName("long *")] int* WindowStyle)
    {
        return ((delegate* unmanaged<IVideoWindow*, int*, int> )(lpVtbl[10]))((IVideoWindow*)Unsafe.AsPointer(ref this), WindowStyle);
    }

    /// <include file='IVideoWindow.xml' path='doc/member[@name="IVideoWindow.put_WindowStyleEx"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_WindowStyleEx([NativeTypeName("long")] int WindowStyleEx)
    {
        return ((delegate* unmanaged<IVideoWindow*, int, int> )(lpVtbl[11]))((IVideoWindow*)Unsafe.AsPointer(ref this), WindowStyleEx);
    }

    /// <include file='IVideoWindow.xml' path='doc/member[@name="IVideoWindow.get_WindowStyleEx"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_WindowStyleEx([NativeTypeName("long *")] int* WindowStyleEx)
    {
        return ((delegate* unmanaged<IVideoWindow*, int*, int> )(lpVtbl[12]))((IVideoWindow*)Unsafe.AsPointer(ref this), WindowStyleEx);
    }

    /// <include file='IVideoWindow.xml' path='doc/member[@name="IVideoWindow.put_AutoShow"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_AutoShow([NativeTypeName("long")] int AutoShow)
    {
        return ((delegate* unmanaged<IVideoWindow*, int, int> )(lpVtbl[13]))((IVideoWindow*)Unsafe.AsPointer(ref this), AutoShow);
    }

    /// <include file='IVideoWindow.xml' path='doc/member[@name="IVideoWindow.get_AutoShow"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_AutoShow([NativeTypeName("long *")] int* AutoShow)
    {
        return ((delegate* unmanaged<IVideoWindow*, int*, int> )(lpVtbl[14]))((IVideoWindow*)Unsafe.AsPointer(ref this), AutoShow);
    }

    /// <include file='IVideoWindow.xml' path='doc/member[@name="IVideoWindow.put_WindowState"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_WindowState([NativeTypeName("long")] int WindowState)
    {
        return ((delegate* unmanaged<IVideoWindow*, int, int> )(lpVtbl[15]))((IVideoWindow*)Unsafe.AsPointer(ref this), WindowState);
    }

    /// <include file='IVideoWindow.xml' path='doc/member[@name="IVideoWindow.get_WindowState"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_WindowState([NativeTypeName("long *")] int* WindowState)
    {
        return ((delegate* unmanaged<IVideoWindow*, int*, int> )(lpVtbl[16]))((IVideoWindow*)Unsafe.AsPointer(ref this), WindowState);
    }

    /// <include file='IVideoWindow.xml' path='doc/member[@name="IVideoWindow.put_BackgroundPalette"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT put_BackgroundPalette([NativeTypeName("long")] int BackgroundPalette)
    {
        return ((delegate* unmanaged<IVideoWindow*, int, int> )(lpVtbl[17]))((IVideoWindow*)Unsafe.AsPointer(ref this), BackgroundPalette);
    }

    /// <include file='IVideoWindow.xml' path='doc/member[@name="IVideoWindow.get_BackgroundPalette"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_BackgroundPalette([NativeTypeName("long *")] int* pBackgroundPalette)
    {
        return ((delegate* unmanaged<IVideoWindow*, int*, int> )(lpVtbl[18]))((IVideoWindow*)Unsafe.AsPointer(ref this), pBackgroundPalette);
    }

    /// <include file='IVideoWindow.xml' path='doc/member[@name="IVideoWindow.put_Visible"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT put_Visible([NativeTypeName("long")] int Visible)
    {
        return ((delegate* unmanaged<IVideoWindow*, int, int> )(lpVtbl[19]))((IVideoWindow*)Unsafe.AsPointer(ref this), Visible);
    }

    /// <include file='IVideoWindow.xml' path='doc/member[@name="IVideoWindow.get_Visible"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_Visible([NativeTypeName("long *")] int* pVisible)
    {
        return ((delegate* unmanaged<IVideoWindow*, int*, int> )(lpVtbl[20]))((IVideoWindow*)Unsafe.AsPointer(ref this), pVisible);
    }

    /// <include file='IVideoWindow.xml' path='doc/member[@name="IVideoWindow.put_Left"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT put_Left([NativeTypeName("long")] int Left)
    {
        return ((delegate* unmanaged<IVideoWindow*, int, int> )(lpVtbl[21]))((IVideoWindow*)Unsafe.AsPointer(ref this), Left);
    }

    /// <include file='IVideoWindow.xml' path='doc/member[@name="IVideoWindow.get_Left"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT get_Left([NativeTypeName("long *")] int* pLeft)
    {
        return ((delegate* unmanaged<IVideoWindow*, int*, int> )(lpVtbl[22]))((IVideoWindow*)Unsafe.AsPointer(ref this), pLeft);
    }

    /// <include file='IVideoWindow.xml' path='doc/member[@name="IVideoWindow.put_Width"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT put_Width([NativeTypeName("long")] int Width)
    {
        return ((delegate* unmanaged<IVideoWindow*, int, int> )(lpVtbl[23]))((IVideoWindow*)Unsafe.AsPointer(ref this), Width);
    }

    /// <include file='IVideoWindow.xml' path='doc/member[@name="IVideoWindow.get_Width"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT get_Width([NativeTypeName("long *")] int* pWidth)
    {
        return ((delegate* unmanaged<IVideoWindow*, int*, int> )(lpVtbl[24]))((IVideoWindow*)Unsafe.AsPointer(ref this), pWidth);
    }

    /// <include file='IVideoWindow.xml' path='doc/member[@name="IVideoWindow.put_Top"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT put_Top([NativeTypeName("long")] int Top)
    {
        return ((delegate* unmanaged<IVideoWindow*, int, int> )(lpVtbl[25]))((IVideoWindow*)Unsafe.AsPointer(ref this), Top);
    }

    /// <include file='IVideoWindow.xml' path='doc/member[@name="IVideoWindow.get_Top"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT get_Top([NativeTypeName("long *")] int* pTop)
    {
        return ((delegate* unmanaged<IVideoWindow*, int*, int> )(lpVtbl[26]))((IVideoWindow*)Unsafe.AsPointer(ref this), pTop);
    }

    /// <include file='IVideoWindow.xml' path='doc/member[@name="IVideoWindow.put_Height"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT put_Height([NativeTypeName("long")] int Height)
    {
        return ((delegate* unmanaged<IVideoWindow*, int, int> )(lpVtbl[27]))((IVideoWindow*)Unsafe.AsPointer(ref this), Height);
    }

    /// <include file='IVideoWindow.xml' path='doc/member[@name="IVideoWindow.get_Height"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT get_Height([NativeTypeName("long *")] int* pHeight)
    {
        return ((delegate* unmanaged<IVideoWindow*, int*, int> )(lpVtbl[28]))((IVideoWindow*)Unsafe.AsPointer(ref this), pHeight);
    }

    /// <include file='IVideoWindow.xml' path='doc/member[@name="IVideoWindow.put_Owner"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT put_Owner(OAHWND Owner)
    {
        return ((delegate* unmanaged<IVideoWindow*, OAHWND, int> )(lpVtbl[29]))((IVideoWindow*)Unsafe.AsPointer(ref this), Owner);
    }

    /// <include file='IVideoWindow.xml' path='doc/member[@name="IVideoWindow.get_Owner"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT get_Owner(OAHWND* Owner)
    {
        return ((delegate* unmanaged<IVideoWindow*, OAHWND*, int> )(lpVtbl[30]))((IVideoWindow*)Unsafe.AsPointer(ref this), Owner);
    }

    /// <include file='IVideoWindow.xml' path='doc/member[@name="IVideoWindow.put_MessageDrain"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT put_MessageDrain(OAHWND Drain)
    {
        return ((delegate* unmanaged<IVideoWindow*, OAHWND, int> )(lpVtbl[31]))((IVideoWindow*)Unsafe.AsPointer(ref this), Drain);
    }

    /// <include file='IVideoWindow.xml' path='doc/member[@name="IVideoWindow.get_MessageDrain"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT get_MessageDrain(OAHWND* Drain)
    {
        return ((delegate* unmanaged<IVideoWindow*, OAHWND*, int> )(lpVtbl[32]))((IVideoWindow*)Unsafe.AsPointer(ref this), Drain);
    }

    /// <include file='IVideoWindow.xml' path='doc/member[@name="IVideoWindow.get_BorderColor"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT get_BorderColor([NativeTypeName("long *")] int* Color)
    {
        return ((delegate* unmanaged<IVideoWindow*, int*, int> )(lpVtbl[33]))((IVideoWindow*)Unsafe.AsPointer(ref this), Color);
    }

    /// <include file='IVideoWindow.xml' path='doc/member[@name="IVideoWindow.put_BorderColor"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT put_BorderColor([NativeTypeName("long")] int Color)
    {
        return ((delegate* unmanaged<IVideoWindow*, int, int> )(lpVtbl[34]))((IVideoWindow*)Unsafe.AsPointer(ref this), Color);
    }

    /// <include file='IVideoWindow.xml' path='doc/member[@name="IVideoWindow.get_FullScreenMode"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT get_FullScreenMode([NativeTypeName("long *")] int* FullScreenMode)
    {
        return ((delegate* unmanaged<IVideoWindow*, int*, int> )(lpVtbl[35]))((IVideoWindow*)Unsafe.AsPointer(ref this), FullScreenMode);
    }

    /// <include file='IVideoWindow.xml' path='doc/member[@name="IVideoWindow.put_FullScreenMode"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT put_FullScreenMode([NativeTypeName("long")] int FullScreenMode)
    {
        return ((delegate* unmanaged<IVideoWindow*, int, int> )(lpVtbl[36]))((IVideoWindow*)Unsafe.AsPointer(ref this), FullScreenMode);
    }

    /// <include file='IVideoWindow.xml' path='doc/member[@name="IVideoWindow.SetWindowForeground"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public HRESULT SetWindowForeground([NativeTypeName("long")] int Focus)
    {
        return ((delegate* unmanaged<IVideoWindow*, int, int> )(lpVtbl[37]))((IVideoWindow*)Unsafe.AsPointer(ref this), Focus);
    }

    /// <include file='IVideoWindow.xml' path='doc/member[@name="IVideoWindow.NotifyOwnerMessage"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public HRESULT NotifyOwnerMessage(OAHWND hwnd, [NativeTypeName("long")] int uMsg, [NativeTypeName("LONG_PTR")] nint wParam, [NativeTypeName("LONG_PTR")] nint lParam)
    {
        return ((delegate* unmanaged<IVideoWindow*, OAHWND, int, nint, nint, int> )(lpVtbl[38]))((IVideoWindow*)Unsafe.AsPointer(ref this), hwnd, uMsg, wParam, lParam);
    }

    /// <include file='IVideoWindow.xml' path='doc/member[@name="IVideoWindow.SetWindowPosition"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    public HRESULT SetWindowPosition([NativeTypeName("long")] int Left, [NativeTypeName("long")] int Top, [NativeTypeName("long")] int Width, [NativeTypeName("long")] int Height)
    {
        return ((delegate* unmanaged<IVideoWindow*, int, int, int, int, int> )(lpVtbl[39]))((IVideoWindow*)Unsafe.AsPointer(ref this), Left, Top, Width, Height);
    }

    /// <include file='IVideoWindow.xml' path='doc/member[@name="IVideoWindow.GetWindowPosition"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(40)]
    public HRESULT GetWindowPosition([NativeTypeName("long *")] int* pLeft, [NativeTypeName("long *")] int* pTop, [NativeTypeName("long *")] int* pWidth, [NativeTypeName("long *")] int* pHeight)
    {
        return ((delegate* unmanaged<IVideoWindow*, int*, int*, int*, int*, int> )(lpVtbl[40]))((IVideoWindow*)Unsafe.AsPointer(ref this), pLeft, pTop, pWidth, pHeight);
    }

    /// <include file='IVideoWindow.xml' path='doc/member[@name="IVideoWindow.GetMinIdealImageSize"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(41)]
    public HRESULT GetMinIdealImageSize([NativeTypeName("long *")] int* pWidth, [NativeTypeName("long *")] int* pHeight)
    {
        return ((delegate* unmanaged<IVideoWindow*, int*, int*, int> )(lpVtbl[41]))((IVideoWindow*)Unsafe.AsPointer(ref this), pWidth, pHeight);
    }

    /// <include file='IVideoWindow.xml' path='doc/member[@name="IVideoWindow.GetMaxIdealImageSize"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(42)]
    public HRESULT GetMaxIdealImageSize([NativeTypeName("long *")] int* pWidth, [NativeTypeName("long *")] int* pHeight)
    {
        return ((delegate* unmanaged<IVideoWindow*, int*, int*, int> )(lpVtbl[42]))((IVideoWindow*)Unsafe.AsPointer(ref this), pWidth, pHeight);
    }

    /// <include file='IVideoWindow.xml' path='doc/member[@name="IVideoWindow.GetRestorePosition"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(43)]
    public HRESULT GetRestorePosition([NativeTypeName("long *")] int* pLeft, [NativeTypeName("long *")] int* pTop, [NativeTypeName("long *")] int* pWidth, [NativeTypeName("long *")] int* pHeight)
    {
        return ((delegate* unmanaged<IVideoWindow*, int*, int*, int*, int*, int> )(lpVtbl[43]))((IVideoWindow*)Unsafe.AsPointer(ref this), pLeft, pTop, pWidth, pHeight);
    }

    /// <include file='IVideoWindow.xml' path='doc/member[@name="IVideoWindow.HideCursor"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(44)]
    public HRESULT HideCursor([NativeTypeName("long")] int HideCursor)
    {
        return ((delegate* unmanaged<IVideoWindow*, int, int> )(lpVtbl[44]))((IVideoWindow*)Unsafe.AsPointer(ref this), HideCursor);
    }

    /// <include file='IVideoWindow.xml' path='doc/member[@name="IVideoWindow.IsCursorHidden"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(45)]
    public HRESULT IsCursorHidden([NativeTypeName("long *")] int* CursorHidden)
    {
        return ((delegate* unmanaged<IVideoWindow*, int*, int> )(lpVtbl[45]))((IVideoWindow*)Unsafe.AsPointer(ref this), CursorHidden);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT put_Caption([NativeTypeName("BSTR")] ushort* strCaption);
        [VtblIndex(8)]
        HRESULT get_Caption([NativeTypeName("BSTR *")] ushort** strCaption);
        [VtblIndex(9)]
        HRESULT put_WindowStyle([NativeTypeName("long")] int WindowStyle);
        [VtblIndex(10)]
        HRESULT get_WindowStyle([NativeTypeName("long *")] int* WindowStyle);
        [VtblIndex(11)]
        HRESULT put_WindowStyleEx([NativeTypeName("long")] int WindowStyleEx);
        [VtblIndex(12)]
        HRESULT get_WindowStyleEx([NativeTypeName("long *")] int* WindowStyleEx);
        [VtblIndex(13)]
        HRESULT put_AutoShow([NativeTypeName("long")] int AutoShow);
        [VtblIndex(14)]
        HRESULT get_AutoShow([NativeTypeName("long *")] int* AutoShow);
        [VtblIndex(15)]
        HRESULT put_WindowState([NativeTypeName("long")] int WindowState);
        [VtblIndex(16)]
        HRESULT get_WindowState([NativeTypeName("long *")] int* WindowState);
        [VtblIndex(17)]
        HRESULT put_BackgroundPalette([NativeTypeName("long")] int BackgroundPalette);
        [VtblIndex(18)]
        HRESULT get_BackgroundPalette([NativeTypeName("long *")] int* pBackgroundPalette);
        [VtblIndex(19)]
        HRESULT put_Visible([NativeTypeName("long")] int Visible);
        [VtblIndex(20)]
        HRESULT get_Visible([NativeTypeName("long *")] int* pVisible);
        [VtblIndex(21)]
        HRESULT put_Left([NativeTypeName("long")] int Left);
        [VtblIndex(22)]
        HRESULT get_Left([NativeTypeName("long *")] int* pLeft);
        [VtblIndex(23)]
        HRESULT put_Width([NativeTypeName("long")] int Width);
        [VtblIndex(24)]
        HRESULT get_Width([NativeTypeName("long *")] int* pWidth);
        [VtblIndex(25)]
        HRESULT put_Top([NativeTypeName("long")] int Top);
        [VtblIndex(26)]
        HRESULT get_Top([NativeTypeName("long *")] int* pTop);
        [VtblIndex(27)]
        HRESULT put_Height([NativeTypeName("long")] int Height);
        [VtblIndex(28)]
        HRESULT get_Height([NativeTypeName("long *")] int* pHeight);
        [VtblIndex(29)]
        HRESULT put_Owner(OAHWND Owner);
        [VtblIndex(30)]
        HRESULT get_Owner(OAHWND* Owner);
        [VtblIndex(31)]
        HRESULT put_MessageDrain(OAHWND Drain);
        [VtblIndex(32)]
        HRESULT get_MessageDrain(OAHWND* Drain);
        [VtblIndex(33)]
        HRESULT get_BorderColor([NativeTypeName("long *")] int* Color);
        [VtblIndex(34)]
        HRESULT put_BorderColor([NativeTypeName("long")] int Color);
        [VtblIndex(35)]
        HRESULT get_FullScreenMode([NativeTypeName("long *")] int* FullScreenMode);
        [VtblIndex(36)]
        HRESULT put_FullScreenMode([NativeTypeName("long")] int FullScreenMode);
        [VtblIndex(37)]
        HRESULT SetWindowForeground([NativeTypeName("long")] int Focus);
        [VtblIndex(38)]
        HRESULT NotifyOwnerMessage(OAHWND hwnd, [NativeTypeName("long")] int uMsg, [NativeTypeName("LONG_PTR")] nint wParam, [NativeTypeName("LONG_PTR")] nint lParam);
        [VtblIndex(39)]
        HRESULT SetWindowPosition([NativeTypeName("long")] int Left, [NativeTypeName("long")] int Top, [NativeTypeName("long")] int Width, [NativeTypeName("long")] int Height);
        [VtblIndex(40)]
        HRESULT GetWindowPosition([NativeTypeName("long *")] int* pLeft, [NativeTypeName("long *")] int* pTop, [NativeTypeName("long *")] int* pWidth, [NativeTypeName("long *")] int* pHeight);
        [VtblIndex(41)]
        HRESULT GetMinIdealImageSize([NativeTypeName("long *")] int* pWidth, [NativeTypeName("long *")] int* pHeight);
        [VtblIndex(42)]
        HRESULT GetMaxIdealImageSize([NativeTypeName("long *")] int* pWidth, [NativeTypeName("long *")] int* pHeight);
        [VtblIndex(43)]
        HRESULT GetRestorePosition([NativeTypeName("long *")] int* pLeft, [NativeTypeName("long *")] int* pTop, [NativeTypeName("long *")] int* pWidth, [NativeTypeName("long *")] int* pHeight);
        [VtblIndex(44)]
        HRESULT HideCursor([NativeTypeName("long")] int HideCursor);
        [VtblIndex(45)]
        HRESULT IsCursorHidden([NativeTypeName("long *")] int* CursorHidden);
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
        public delegate* unmanaged<TSelf*, ushort*, int> put_Caption;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_Caption;
        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_WindowStyle;
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_WindowStyle;
        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_WindowStyleEx;
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_WindowStyleEx;
        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_AutoShow;
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_AutoShow;
        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_WindowState;
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_WindowState;
        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_BackgroundPalette;
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_BackgroundPalette;
        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_Visible;
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_Visible;
        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_Left;
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_Left;
        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_Width;
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_Width;
        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_Top;
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_Top;
        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_Height;
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_Height;
        [NativeTypeName("HRESULT (OAHWND) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, OAHWND, int> put_Owner;
        [NativeTypeName("HRESULT (OAHWND *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, OAHWND*, int> get_Owner;
        [NativeTypeName("HRESULT (OAHWND) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, OAHWND, int> put_MessageDrain;
        [NativeTypeName("HRESULT (OAHWND *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, OAHWND*, int> get_MessageDrain;
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_BorderColor;
        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_BorderColor;
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_FullScreenMode;
        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_FullScreenMode;
        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> SetWindowForeground;
        [NativeTypeName("HRESULT (OAHWND, long, LONG_PTR, LONG_PTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, OAHWND, int, nint, nint, int> NotifyOwnerMessage;
        [NativeTypeName("HRESULT (long, long, long, long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int, int, int, int> SetWindowPosition;
        [NativeTypeName("HRESULT (long *, long *, long *, long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int*, int*, int*, int> GetWindowPosition;
        [NativeTypeName("HRESULT (long *, long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int*, int> GetMinIdealImageSize;
        [NativeTypeName("HRESULT (long *, long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int*, int> GetMaxIdealImageSize;
        [NativeTypeName("HRESULT (long *, long *, long *, long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int*, int*, int*, int> GetRestorePosition;
        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> HideCursor;
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> IsCursorHidden;
    }
}