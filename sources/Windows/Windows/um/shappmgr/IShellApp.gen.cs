// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/shappmgr.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IShellApp.xml' path='doc/member[@name="IShellApp"]/*'/>
[Guid("A3E14960-935F-11D1-B8B8-006008059382")]
[NativeTypeName("struct IShellApp : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IShellApp : IShellApp.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IShellApp));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IShellApp*, Guid*, void**, int> )(lpVtbl[0]))((IShellApp*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IShellApp*, uint> )(lpVtbl[1]))((IShellApp*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IShellApp*, uint> )(lpVtbl[2]))((IShellApp*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IShellApp.xml' path='doc/member[@name="IShellApp.GetAppInfo"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetAppInfo([NativeTypeName("PAPPINFODATA")] APPINFODATA* pai)
    {
        return ((delegate* unmanaged<IShellApp*, APPINFODATA*, int> )(lpVtbl[3]))((IShellApp*)Unsafe.AsPointer(ref this), pai);
    }

    /// <include file='IShellApp.xml' path='doc/member[@name="IShellApp.GetPossibleActions"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetPossibleActions([NativeTypeName("DWORD *")] uint* pdwActions)
    {
        return ((delegate* unmanaged<IShellApp*, uint*, int> )(lpVtbl[4]))((IShellApp*)Unsafe.AsPointer(ref this), pdwActions);
    }

    /// <include file='IShellApp.xml' path='doc/member[@name="IShellApp.GetSlowAppInfo"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetSlowAppInfo([NativeTypeName("PSLOWAPPINFO")] SLOWAPPINFO* psaid)
    {
        return ((delegate* unmanaged<IShellApp*, SLOWAPPINFO*, int> )(lpVtbl[5]))((IShellApp*)Unsafe.AsPointer(ref this), psaid);
    }

    /// <include file='IShellApp.xml' path='doc/member[@name="IShellApp.GetCachedSlowAppInfo"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetCachedSlowAppInfo([NativeTypeName("PSLOWAPPINFO")] SLOWAPPINFO* psaid)
    {
        return ((delegate* unmanaged<IShellApp*, SLOWAPPINFO*, int> )(lpVtbl[6]))((IShellApp*)Unsafe.AsPointer(ref this), psaid);
    }

    /// <include file='IShellApp.xml' path='doc/member[@name="IShellApp.IsInstalled"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT IsInstalled()
    {
        return ((delegate* unmanaged<IShellApp*, int> )(lpVtbl[7]))((IShellApp*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetAppInfo([NativeTypeName("PAPPINFODATA")] APPINFODATA* pai);
        [VtblIndex(4)]
        HRESULT GetPossibleActions([NativeTypeName("DWORD *")] uint* pdwActions);
        [VtblIndex(5)]
        HRESULT GetSlowAppInfo([NativeTypeName("PSLOWAPPINFO")] SLOWAPPINFO* psaid);
        [VtblIndex(6)]
        HRESULT GetCachedSlowAppInfo([NativeTypeName("PSLOWAPPINFO")] SLOWAPPINFO* psaid);
        [VtblIndex(7)]
        HRESULT IsInstalled();
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
    }
}