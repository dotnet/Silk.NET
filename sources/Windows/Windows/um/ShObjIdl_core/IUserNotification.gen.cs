// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IUserNotification.xml' path='doc/member[@name="IUserNotification"]/*'/>
[Guid("BA9711BA-5893-4787-A7E1-41277151550B")]
[NativeTypeName("struct IUserNotification : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IUserNotification : IUserNotification.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IUserNotification));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IUserNotification*, Guid*, void**, int> )(lpVtbl[0]))((IUserNotification*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IUserNotification*, uint> )(lpVtbl[1]))((IUserNotification*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IUserNotification*, uint> )(lpVtbl[2]))((IUserNotification*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IUserNotification.xml' path='doc/member[@name="IUserNotification.SetBalloonInfo"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetBalloonInfo([NativeTypeName("LPCWSTR")] ushort* pszTitle, [NativeTypeName("LPCWSTR")] ushort* pszText, [NativeTypeName("DWORD")] uint dwInfoFlags)
    {
        return ((delegate* unmanaged<IUserNotification*, ushort*, ushort*, uint, int> )(lpVtbl[3]))((IUserNotification*)Unsafe.AsPointer(ref this), pszTitle, pszText, dwInfoFlags);
    }

    /// <include file='IUserNotification.xml' path='doc/member[@name="IUserNotification.SetBalloonRetry"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetBalloonRetry([NativeTypeName("DWORD")] uint dwShowTime, [NativeTypeName("DWORD")] uint dwInterval, uint cRetryCount)
    {
        return ((delegate* unmanaged<IUserNotification*, uint, uint, uint, int> )(lpVtbl[4]))((IUserNotification*)Unsafe.AsPointer(ref this), dwShowTime, dwInterval, cRetryCount);
    }

    /// <include file='IUserNotification.xml' path='doc/member[@name="IUserNotification.SetIconInfo"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetIconInfo(HICON hIcon, [NativeTypeName("LPCWSTR")] ushort* pszToolTip)
    {
        return ((delegate* unmanaged<IUserNotification*, HICON, ushort*, int> )(lpVtbl[5]))((IUserNotification*)Unsafe.AsPointer(ref this), hIcon, pszToolTip);
    }

    /// <include file='IUserNotification.xml' path='doc/member[@name="IUserNotification.Show"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Show(IQueryContinue* pqc, [NativeTypeName("DWORD")] uint dwContinuePollInterval)
    {
        return ((delegate* unmanaged<IUserNotification*, IQueryContinue*, uint, int> )(lpVtbl[6]))((IUserNotification*)Unsafe.AsPointer(ref this), pqc, dwContinuePollInterval);
    }

    /// <include file='IUserNotification.xml' path='doc/member[@name="IUserNotification.PlaySoundW"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT PlaySoundW([NativeTypeName("LPCWSTR")] ushort* pszSoundName)
    {
        return ((delegate* unmanaged<IUserNotification*, ushort*, int> )(lpVtbl[7]))((IUserNotification*)Unsafe.AsPointer(ref this), pszSoundName);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetBalloonInfo([NativeTypeName("LPCWSTR")] ushort* pszTitle, [NativeTypeName("LPCWSTR")] ushort* pszText, [NativeTypeName("DWORD")] uint dwInfoFlags);
        [VtblIndex(4)]
        HRESULT SetBalloonRetry([NativeTypeName("DWORD")] uint dwShowTime, [NativeTypeName("DWORD")] uint dwInterval, uint cRetryCount);
        [VtblIndex(5)]
        HRESULT SetIconInfo(HICON hIcon, [NativeTypeName("LPCWSTR")] ushort* pszToolTip);
        [VtblIndex(6)]
        HRESULT Show(IQueryContinue* pqc, [NativeTypeName("DWORD")] uint dwContinuePollInterval);
        [VtblIndex(7)]
        HRESULT PlaySoundW([NativeTypeName("LPCWSTR")] ushort* pszSoundName);
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
        [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, uint, int> SetBalloonInfo;
        [NativeTypeName("HRESULT (DWORD, DWORD, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, uint, int> SetBalloonRetry;
        [NativeTypeName("HRESULT (HICON, LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HICON, ushort*, int> SetIconInfo;
        [NativeTypeName("HRESULT (IQueryContinue *, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IQueryContinue*, uint, int> Show;
        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> PlaySoundW;
    }
}