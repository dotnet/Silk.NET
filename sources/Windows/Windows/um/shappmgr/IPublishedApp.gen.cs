// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shappmgr.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IPublishedApp.xml' path='doc/member[@name="IPublishedApp"]/*' />
[Guid("1BC752E0-9046-11D1-B8B3-006008059382")]
[NativeTypeName("struct IPublishedApp : IShellApp")]
[NativeInheritance("IShellApp")]
public unsafe partial struct IPublishedApp : IPublishedApp.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPublishedApp));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IPublishedApp*, Guid*, void**, int>)(lpVtbl[0]))((IPublishedApp*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IPublishedApp*, uint>)(lpVtbl[1]))((IPublishedApp*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPublishedApp*, uint>)(lpVtbl[2]))((IPublishedApp*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IShellApp.GetAppInfo" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetAppInfo([NativeTypeName("PAPPINFODATA")] APPINFODATA* pai)
    {
        return ((delegate* unmanaged<IPublishedApp*, APPINFODATA*, int>)(lpVtbl[3]))((IPublishedApp*)Unsafe.AsPointer(ref this), pai);
    }

    /// <inheritdoc cref="IShellApp.GetPossibleActions" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetPossibleActions([NativeTypeName("DWORD *")] uint* pdwActions)
    {
        return ((delegate* unmanaged<IPublishedApp*, uint*, int>)(lpVtbl[4]))((IPublishedApp*)Unsafe.AsPointer(ref this), pdwActions);
    }

    /// <inheritdoc cref="IShellApp.GetSlowAppInfo" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetSlowAppInfo([NativeTypeName("PSLOWAPPINFO")] SLOWAPPINFO* psaid)
    {
        return ((delegate* unmanaged<IPublishedApp*, SLOWAPPINFO*, int>)(lpVtbl[5]))((IPublishedApp*)Unsafe.AsPointer(ref this), psaid);
    }

    /// <inheritdoc cref="IShellApp.GetCachedSlowAppInfo" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetCachedSlowAppInfo([NativeTypeName("PSLOWAPPINFO")] SLOWAPPINFO* psaid)
    {
        return ((delegate* unmanaged<IPublishedApp*, SLOWAPPINFO*, int>)(lpVtbl[6]))((IPublishedApp*)Unsafe.AsPointer(ref this), psaid);
    }

    /// <inheritdoc cref="IShellApp.IsInstalled" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT IsInstalled()
    {
        return ((delegate* unmanaged<IPublishedApp*, int>)(lpVtbl[7]))((IPublishedApp*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IPublishedApp.xml' path='doc/member[@name="IPublishedApp.Install"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT Install([NativeTypeName("LPSYSTEMTIME")] SYSTEMTIME* pstInstall)
    {
        return ((delegate* unmanaged<IPublishedApp*, SYSTEMTIME*, int>)(lpVtbl[8]))((IPublishedApp*)Unsafe.AsPointer(ref this), pstInstall);
    }

    /// <include file='IPublishedApp.xml' path='doc/member[@name="IPublishedApp.GetPublishedAppInfo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetPublishedAppInfo([NativeTypeName("PPUBAPPINFO")] PUBAPPINFO* ppai)
    {
        return ((delegate* unmanaged<IPublishedApp*, PUBAPPINFO*, int>)(lpVtbl[9]))((IPublishedApp*)Unsafe.AsPointer(ref this), ppai);
    }

    /// <include file='IPublishedApp.xml' path='doc/member[@name="IPublishedApp.Unschedule"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT Unschedule()
    {
        return ((delegate* unmanaged<IPublishedApp*, int>)(lpVtbl[10]))((IPublishedApp*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IShellApp.Interface
    {
        [VtblIndex(8)]
        HRESULT Install([NativeTypeName("LPSYSTEMTIME")] SYSTEMTIME* pstInstall);

        [VtblIndex(9)]
        HRESULT GetPublishedAppInfo([NativeTypeName("PPUBAPPINFO")] PUBAPPINFO* ppai);

        [VtblIndex(10)]
        HRESULT Unschedule();
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
    }
}
