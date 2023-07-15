// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IAppVisibility.xml' path='doc/member[@name="IAppVisibility"]/*'/>
[Guid("2246EA2D-CAEA-4444-A3C4-6DE827E44313")]
[NativeTypeName("struct IAppVisibility : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAppVisibility : IAppVisibility.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppVisibility));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAppVisibility*, Guid*, void**, int> )(lpVtbl[0]))((IAppVisibility*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAppVisibility*, uint> )(lpVtbl[1]))((IAppVisibility*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppVisibility*, uint> )(lpVtbl[2]))((IAppVisibility*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAppVisibility.xml' path='doc/member[@name="IAppVisibility.GetAppVisibilityOnMonitor"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetAppVisibilityOnMonitor(HMONITOR hMonitor, MONITOR_APP_VISIBILITY* pMode)
    {
        return ((delegate* unmanaged<IAppVisibility*, HMONITOR, MONITOR_APP_VISIBILITY*, int> )(lpVtbl[3]))((IAppVisibility*)Unsafe.AsPointer(ref this), hMonitor, pMode);
    }

    /// <include file='IAppVisibility.xml' path='doc/member[@name="IAppVisibility.IsLauncherVisible"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT IsLauncherVisible(BOOL* pfVisible)
    {
        return ((delegate* unmanaged<IAppVisibility*, BOOL*, int> )(lpVtbl[4]))((IAppVisibility*)Unsafe.AsPointer(ref this), pfVisible);
    }

    /// <include file='IAppVisibility.xml' path='doc/member[@name="IAppVisibility.Advise"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Advise(IAppVisibilityEvents* pCallback, [NativeTypeName("DWORD *")] uint* pdwCookie)
    {
        return ((delegate* unmanaged<IAppVisibility*, IAppVisibilityEvents*, uint*, int> )(lpVtbl[5]))((IAppVisibility*)Unsafe.AsPointer(ref this), pCallback, pdwCookie);
    }

    /// <include file='IAppVisibility.xml' path='doc/member[@name="IAppVisibility.Unadvise"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Unadvise([NativeTypeName("DWORD")] uint dwCookie)
    {
        return ((delegate* unmanaged<IAppVisibility*, uint, int> )(lpVtbl[6]))((IAppVisibility*)Unsafe.AsPointer(ref this), dwCookie);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetAppVisibilityOnMonitor(HMONITOR hMonitor, MONITOR_APP_VISIBILITY* pMode);
        [VtblIndex(4)]
        HRESULT IsLauncherVisible(BOOL* pfVisible);
        [VtblIndex(5)]
        HRESULT Advise(IAppVisibilityEvents* pCallback, [NativeTypeName("DWORD *")] uint* pdwCookie);
        [VtblIndex(6)]
        HRESULT Unadvise([NativeTypeName("DWORD")] uint dwCookie);
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
        [NativeTypeName("HRESULT (HMONITOR, MONITOR_APP_VISIBILITY *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HMONITOR, MONITOR_APP_VISIBILITY*, int> GetAppVisibilityOnMonitor;
        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> IsLauncherVisible;
        [NativeTypeName("HRESULT (IAppVisibilityEvents *, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IAppVisibilityEvents*, uint*, int> Advise;
        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> Unadvise;
    }
}