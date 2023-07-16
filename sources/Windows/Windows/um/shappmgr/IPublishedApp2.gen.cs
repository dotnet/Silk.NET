// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/shappmgr.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IPublishedApp2.xml' path='doc/member[@name="IPublishedApp2"]/*'/>
[Guid("12B81347-1B3A-4A04-AA61-3F768B67FD7E")]
[NativeTypeName("struct IPublishedApp2 : IPublishedApp")]
[NativeInheritance("IPublishedApp")]
public unsafe partial struct IPublishedApp2 : IPublishedApp2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPublishedApp2));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IPublishedApp2*, Guid*, void**, int> )(lpVtbl[0]))((IPublishedApp2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IPublishedApp2*, uint> )(lpVtbl[1]))((IPublishedApp2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPublishedApp2*, uint> )(lpVtbl[2]))((IPublishedApp2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IShellApp.GetAppInfo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetAppInfo([NativeTypeName("PAPPINFODATA")] APPINFODATA* pai)
    {
        return ((delegate* unmanaged<IPublishedApp2*, APPINFODATA*, int> )(lpVtbl[3]))((IPublishedApp2*)Unsafe.AsPointer(ref this), pai);
    }

    /// <inheritdoc cref = "IShellApp.GetPossibleActions"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetPossibleActions([NativeTypeName("DWORD *")] uint* pdwActions)
    {
        return ((delegate* unmanaged<IPublishedApp2*, uint*, int> )(lpVtbl[4]))((IPublishedApp2*)Unsafe.AsPointer(ref this), pdwActions);
    }

    /// <inheritdoc cref = "IShellApp.GetSlowAppInfo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetSlowAppInfo([NativeTypeName("PSLOWAPPINFO")] SLOWAPPINFO* psaid)
    {
        return ((delegate* unmanaged<IPublishedApp2*, SLOWAPPINFO*, int> )(lpVtbl[5]))((IPublishedApp2*)Unsafe.AsPointer(ref this), psaid);
    }

    /// <inheritdoc cref = "IShellApp.GetCachedSlowAppInfo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetCachedSlowAppInfo([NativeTypeName("PSLOWAPPINFO")] SLOWAPPINFO* psaid)
    {
        return ((delegate* unmanaged<IPublishedApp2*, SLOWAPPINFO*, int> )(lpVtbl[6]))((IPublishedApp2*)Unsafe.AsPointer(ref this), psaid);
    }

    /// <inheritdoc cref = "IShellApp.IsInstalled"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT IsInstalled()
    {
        return ((delegate* unmanaged<IPublishedApp2*, int> )(lpVtbl[7]))((IPublishedApp2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IPublishedApp.Install"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT Install([NativeTypeName("LPSYSTEMTIME")] SYSTEMTIME* pstInstall)
    {
        return ((delegate* unmanaged<IPublishedApp2*, SYSTEMTIME*, int> )(lpVtbl[8]))((IPublishedApp2*)Unsafe.AsPointer(ref this), pstInstall);
    }

    /// <inheritdoc cref = "IPublishedApp.GetPublishedAppInfo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetPublishedAppInfo([NativeTypeName("PPUBAPPINFO")] PUBAPPINFO* ppai)
    {
        return ((delegate* unmanaged<IPublishedApp2*, PUBAPPINFO*, int> )(lpVtbl[9]))((IPublishedApp2*)Unsafe.AsPointer(ref this), ppai);
    }

    /// <inheritdoc cref = "IPublishedApp.Unschedule"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT Unschedule()
    {
        return ((delegate* unmanaged<IPublishedApp2*, int> )(lpVtbl[10]))((IPublishedApp2*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IPublishedApp2.xml' path='doc/member[@name="IPublishedApp2.Install2"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT Install2([NativeTypeName("LPSYSTEMTIME")] SYSTEMTIME* pstInstall, HWND hwndParent)
    {
        return ((delegate* unmanaged<IPublishedApp2*, SYSTEMTIME*, HWND, int> )(lpVtbl[11]))((IPublishedApp2*)Unsafe.AsPointer(ref this), pstInstall, hwndParent);
    }

    public interface Interface : IPublishedApp.Interface
    {
        [VtblIndex(11)]
        HRESULT Install2([NativeTypeName("LPSYSTEMTIME")] SYSTEMTIME* pstInstall, HWND hwndParent);
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
        [NativeTypeName("HRESULT (PAPPINFODATA) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, APPINFODATA*, int> GetAppInfo;
        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetPossibleActions;
        [NativeTypeName("HRESULT (PSLOWAPPINFO) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SLOWAPPINFO*, int> GetSlowAppInfo;
        [NativeTypeName("HRESULT (PSLOWAPPINFO) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SLOWAPPINFO*, int> GetCachedSlowAppInfo;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> IsInstalled;
        [NativeTypeName("HRESULT (LPSYSTEMTIME) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SYSTEMTIME*, int> Install;
        [NativeTypeName("HRESULT (PPUBAPPINFO) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, PUBAPPINFO*, int> GetPublishedAppInfo;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Unschedule;
        [NativeTypeName("HRESULT (LPSYSTEMTIME, HWND) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SYSTEMTIME*, HWND, int> Install2;
    }
}