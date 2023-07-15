// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='ISpNotifySource.xml' path='doc/member[@name="ISpNotifySource"]/*'/>
[Guid("5EFF4AEF-8487-11D2-961C-00C04F8EE628")]
[NativeTypeName("struct ISpNotifySource : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ISpNotifySource : ISpNotifySource.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpNotifySource));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISpNotifySource*, Guid*, void**, int> )(lpVtbl[0]))((ISpNotifySource*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISpNotifySource*, uint> )(lpVtbl[1]))((ISpNotifySource*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISpNotifySource*, uint> )(lpVtbl[2]))((ISpNotifySource*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ISpNotifySource.xml' path='doc/member[@name="ISpNotifySource.SetNotifySink"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetNotifySink(ISpNotifySink* pNotifySink)
    {
        return ((delegate* unmanaged<ISpNotifySource*, ISpNotifySink*, int> )(lpVtbl[3]))((ISpNotifySource*)Unsafe.AsPointer(ref this), pNotifySink);
    }

    /// <include file='ISpNotifySource.xml' path='doc/member[@name="ISpNotifySource.SetNotifyWindowMessage"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetNotifyWindowMessage(HWND hWnd, uint Msg, WPARAM wParam, LPARAM lParam)
    {
        return ((delegate* unmanaged<ISpNotifySource*, HWND, uint, WPARAM, LPARAM, int> )(lpVtbl[4]))((ISpNotifySource*)Unsafe.AsPointer(ref this), hWnd, Msg, wParam, lParam);
    }

    /// <include file='ISpNotifySource.xml' path='doc/member[@name="ISpNotifySource.SetNotifyCallbackFunction"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetNotifyCallbackFunction([NativeTypeName("SPNOTIFYCALLBACK *")] delegate* unmanaged<WPARAM, LPARAM, void> pfnCallback, WPARAM wParam, LPARAM lParam)
    {
        return ((delegate* unmanaged<ISpNotifySource*, delegate* unmanaged<WPARAM, LPARAM, void> , WPARAM, LPARAM, int> )(lpVtbl[5]))((ISpNotifySource*)Unsafe.AsPointer(ref this), pfnCallback, wParam, lParam);
    }

    /// <include file='ISpNotifySource.xml' path='doc/member[@name="ISpNotifySource.SetNotifyCallbackInterface"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetNotifyCallbackInterface(ISpNotifyCallback* pSpCallback, WPARAM wParam, LPARAM lParam)
    {
        return ((delegate* unmanaged<ISpNotifySource*, ISpNotifyCallback*, WPARAM, LPARAM, int> )(lpVtbl[6]))((ISpNotifySource*)Unsafe.AsPointer(ref this), pSpCallback, wParam, lParam);
    }

    /// <include file='ISpNotifySource.xml' path='doc/member[@name="ISpNotifySource.SetNotifyWin32Event"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetNotifyWin32Event()
    {
        return ((delegate* unmanaged<ISpNotifySource*, int> )(lpVtbl[7]))((ISpNotifySource*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ISpNotifySource.xml' path='doc/member[@name="ISpNotifySource.WaitForNotifyEvent"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT WaitForNotifyEvent([NativeTypeName("DWORD")] uint dwMilliseconds)
    {
        return ((delegate* unmanaged<ISpNotifySource*, uint, int> )(lpVtbl[8]))((ISpNotifySource*)Unsafe.AsPointer(ref this), dwMilliseconds);
    }

    /// <include file='ISpNotifySource.xml' path='doc/member[@name="ISpNotifySource.GetNotifyEventHandle"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HANDLE GetNotifyEventHandle()
    {
        return ((HANDLE)(((delegate* unmanaged<ISpNotifySource*, void*> )(lpVtbl[9]))((ISpNotifySource*)Unsafe.AsPointer(ref this))));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetNotifySink(ISpNotifySink* pNotifySink);
        [VtblIndex(4)]
        HRESULT SetNotifyWindowMessage(HWND hWnd, uint Msg, WPARAM wParam, LPARAM lParam);
        [VtblIndex(6)]
        HRESULT SetNotifyCallbackInterface(ISpNotifyCallback* pSpCallback, WPARAM wParam, LPARAM lParam);
        [VtblIndex(7)]
        HRESULT SetNotifyWin32Event();
        [VtblIndex(8)]
        HRESULT WaitForNotifyEvent([NativeTypeName("DWORD")] uint dwMilliseconds);
        [VtblIndex(9)]
        HANDLE GetNotifyEventHandle();
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
        [NativeTypeName("HRESULT (ISpNotifySink *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISpNotifySink*, int> SetNotifySink;
        [NativeTypeName("HRESULT (HWND, UINT, WPARAM, LPARAM) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, uint, WPARAM, LPARAM, int> SetNotifyWindowMessage;
        [NativeTypeName("HRESULT (SPNOTIFYCALLBACK *, WPARAM, LPARAM) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, delegate* unmanaged<WPARAM, LPARAM, void> , WPARAM, LPARAM, int> SetNotifyCallbackFunction;
        [NativeTypeName("HRESULT (ISpNotifyCallback *, WPARAM, LPARAM) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISpNotifyCallback*, WPARAM, LPARAM, int> SetNotifyCallbackInterface;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> SetNotifyWin32Event;
        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> WaitForNotifyEvent;
        [NativeTypeName("HANDLE () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void*> GetNotifyEventHandle;
    }
}