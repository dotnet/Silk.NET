// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IProgressDialog.xml' path='doc/member[@name="IProgressDialog"]/*'/>
[Guid("EBBC7C04-315E-11D2-B62F-006097DF5BD4")]
[NativeTypeName("struct IProgressDialog : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IProgressDialog : IProgressDialog.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IProgressDialog));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IProgressDialog*, Guid*, void**, int> )(lpVtbl[0]))((IProgressDialog*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IProgressDialog*, uint> )(lpVtbl[1]))((IProgressDialog*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IProgressDialog*, uint> )(lpVtbl[2]))((IProgressDialog*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IProgressDialog.xml' path='doc/member[@name="IProgressDialog.StartProgressDialog"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT StartProgressDialog(HWND hwndParent, IUnknown* punkEnableModless, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPCVOID")] void* pvResevered)
    {
        return ((delegate* unmanaged<IProgressDialog*, HWND, IUnknown*, uint, void*, int> )(lpVtbl[3]))((IProgressDialog*)Unsafe.AsPointer(ref this), hwndParent, punkEnableModless, dwFlags, pvResevered);
    }

    /// <include file='IProgressDialog.xml' path='doc/member[@name="IProgressDialog.StopProgressDialog"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT StopProgressDialog()
    {
        return ((delegate* unmanaged<IProgressDialog*, int> )(lpVtbl[4]))((IProgressDialog*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IProgressDialog.xml' path='doc/member[@name="IProgressDialog.SetTitle"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetTitle([NativeTypeName("PCWSTR")] ushort* pwzTitle)
    {
        return ((delegate* unmanaged<IProgressDialog*, ushort*, int> )(lpVtbl[5]))((IProgressDialog*)Unsafe.AsPointer(ref this), pwzTitle);
    }

    /// <include file='IProgressDialog.xml' path='doc/member[@name="IProgressDialog.SetAnimation"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetAnimation(HINSTANCE hInstAnimation, uint idAnimation)
    {
        return ((delegate* unmanaged<IProgressDialog*, HINSTANCE, uint, int> )(lpVtbl[6]))((IProgressDialog*)Unsafe.AsPointer(ref this), hInstAnimation, idAnimation);
    }

    /// <include file='IProgressDialog.xml' path='doc/member[@name="IProgressDialog.HasUserCancelled"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public BOOL HasUserCancelled()
    {
        return ((delegate* unmanaged<IProgressDialog*, int> )(lpVtbl[7]))((IProgressDialog*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IProgressDialog.xml' path='doc/member[@name="IProgressDialog.SetProgress"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetProgress([NativeTypeName("DWORD")] uint dwCompleted, [NativeTypeName("DWORD")] uint dwTotal)
    {
        return ((delegate* unmanaged<IProgressDialog*, uint, uint, int> )(lpVtbl[8]))((IProgressDialog*)Unsafe.AsPointer(ref this), dwCompleted, dwTotal);
    }

    /// <include file='IProgressDialog.xml' path='doc/member[@name="IProgressDialog.SetProgress64"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SetProgress64([NativeTypeName("ULONGLONG")] ulong ullCompleted, [NativeTypeName("ULONGLONG")] ulong ullTotal)
    {
        return ((delegate* unmanaged<IProgressDialog*, ulong, ulong, int> )(lpVtbl[9]))((IProgressDialog*)Unsafe.AsPointer(ref this), ullCompleted, ullTotal);
    }

    /// <include file='IProgressDialog.xml' path='doc/member[@name="IProgressDialog.SetLine"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetLine([NativeTypeName("DWORD")] uint dwLineNum, [NativeTypeName("PCWSTR")] ushort* pwzString, BOOL fCompactPath, [NativeTypeName("LPCVOID")] void* pvResevered)
    {
        return ((delegate* unmanaged<IProgressDialog*, uint, ushort*, BOOL, void*, int> )(lpVtbl[10]))((IProgressDialog*)Unsafe.AsPointer(ref this), dwLineNum, pwzString, fCompactPath, pvResevered);
    }

    /// <include file='IProgressDialog.xml' path='doc/member[@name="IProgressDialog.SetCancelMsg"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT SetCancelMsg([NativeTypeName("PCWSTR")] ushort* pwzCancelMsg, [NativeTypeName("LPCVOID")] void* pvResevered)
    {
        return ((delegate* unmanaged<IProgressDialog*, ushort*, void*, int> )(lpVtbl[11]))((IProgressDialog*)Unsafe.AsPointer(ref this), pwzCancelMsg, pvResevered);
    }

    /// <include file='IProgressDialog.xml' path='doc/member[@name="IProgressDialog.Timer"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT Timer([NativeTypeName("DWORD")] uint dwTimerAction, [NativeTypeName("LPCVOID")] void* pvResevered)
    {
        return ((delegate* unmanaged<IProgressDialog*, uint, void*, int> )(lpVtbl[12]))((IProgressDialog*)Unsafe.AsPointer(ref this), dwTimerAction, pvResevered);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT StartProgressDialog(HWND hwndParent, IUnknown* punkEnableModless, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPCVOID")] void* pvResevered);
        [VtblIndex(4)]
        HRESULT StopProgressDialog();
        [VtblIndex(5)]
        HRESULT SetTitle([NativeTypeName("PCWSTR")] ushort* pwzTitle);
        [VtblIndex(6)]
        HRESULT SetAnimation(HINSTANCE hInstAnimation, uint idAnimation);
        [VtblIndex(7)]
        BOOL HasUserCancelled();
        [VtblIndex(8)]
        HRESULT SetProgress([NativeTypeName("DWORD")] uint dwCompleted, [NativeTypeName("DWORD")] uint dwTotal);
        [VtblIndex(9)]
        HRESULT SetProgress64([NativeTypeName("ULONGLONG")] ulong ullCompleted, [NativeTypeName("ULONGLONG")] ulong ullTotal);
        [VtblIndex(10)]
        HRESULT SetLine([NativeTypeName("DWORD")] uint dwLineNum, [NativeTypeName("PCWSTR")] ushort* pwzString, BOOL fCompactPath, [NativeTypeName("LPCVOID")] void* pvResevered);
        [VtblIndex(11)]
        HRESULT SetCancelMsg([NativeTypeName("PCWSTR")] ushort* pwzCancelMsg, [NativeTypeName("LPCVOID")] void* pvResevered);
        [VtblIndex(12)]
        HRESULT Timer([NativeTypeName("DWORD")] uint dwTimerAction, [NativeTypeName("LPCVOID")] void* pvResevered);
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
        [NativeTypeName("HRESULT (HWND, IUnknown *, DWORD, LPCVOID) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, IUnknown*, uint, void*, int> StartProgressDialog;
        [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> StopProgressDialog;
        [NativeTypeName("HRESULT (PCWSTR) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> SetTitle;
        [NativeTypeName("HRESULT (HINSTANCE, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HINSTANCE, uint, int> SetAnimation;
        [NativeTypeName("BOOL () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> HasUserCancelled;
        [NativeTypeName("HRESULT (DWORD, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, int> SetProgress;
        [NativeTypeName("HRESULT (ULONGLONG, ULONGLONG) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong, ulong, int> SetProgress64;
        [NativeTypeName("HRESULT (DWORD, PCWSTR, BOOL, LPCVOID) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ushort*, BOOL, void*, int> SetLine;
        [NativeTypeName("HRESULT (PCWSTR, LPCVOID) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, void*, int> SetCancelMsg;
        [NativeTypeName("HRESULT (DWORD, LPCVOID) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, void*, int> Timer;
    }
}