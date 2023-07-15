// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='ISpNotifyTranslator.xml' path='doc/member[@name="ISpNotifyTranslator"]/*'/>
[Guid("ACA16614-5D3D-11D2-960E-00C04F8EE628")]
[NativeTypeName("struct ISpNotifyTranslator : ISpNotifySink")]
[NativeInheritance("ISpNotifySink")]
public unsafe partial struct ISpNotifyTranslator : ISpNotifyTranslator.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpNotifyTranslator));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISpNotifyTranslator*, Guid*, void**, int> )(lpVtbl[0]))((ISpNotifyTranslator*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISpNotifyTranslator*, uint> )(lpVtbl[1]))((ISpNotifyTranslator*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISpNotifyTranslator*, uint> )(lpVtbl[2]))((ISpNotifyTranslator*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "ISpNotifySink.Notify"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Notify()
    {
        return ((delegate* unmanaged<ISpNotifyTranslator*, int> )(lpVtbl[3]))((ISpNotifyTranslator*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ISpNotifyTranslator.xml' path='doc/member[@name="ISpNotifyTranslator.InitWindowMessage"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT InitWindowMessage(HWND hWnd, uint Msg, WPARAM wParam, LPARAM lParam)
    {
        return ((delegate* unmanaged<ISpNotifyTranslator*, HWND, uint, WPARAM, LPARAM, int> )(lpVtbl[4]))((ISpNotifyTranslator*)Unsafe.AsPointer(ref this), hWnd, Msg, wParam, lParam);
    }

    /// <include file='ISpNotifyTranslator.xml' path='doc/member[@name="ISpNotifyTranslator.InitCallback"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT InitCallback([NativeTypeName("SPNOTIFYCALLBACK *")] delegate* unmanaged<WPARAM, LPARAM, void> pfnCallback, WPARAM wParam, LPARAM lParam)
    {
        return ((delegate* unmanaged<ISpNotifyTranslator*, delegate* unmanaged<WPARAM, LPARAM, void> , WPARAM, LPARAM, int> )(lpVtbl[5]))((ISpNotifyTranslator*)Unsafe.AsPointer(ref this), pfnCallback, wParam, lParam);
    }

    /// <include file='ISpNotifyTranslator.xml' path='doc/member[@name="ISpNotifyTranslator.InitSpNotifyCallback"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT InitSpNotifyCallback(ISpNotifyCallback* pSpCallback, WPARAM wParam, LPARAM lParam)
    {
        return ((delegate* unmanaged<ISpNotifyTranslator*, ISpNotifyCallback*, WPARAM, LPARAM, int> )(lpVtbl[6]))((ISpNotifyTranslator*)Unsafe.AsPointer(ref this), pSpCallback, wParam, lParam);
    }

    /// <include file='ISpNotifyTranslator.xml' path='doc/member[@name="ISpNotifyTranslator.InitWin32Event"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT InitWin32Event(HANDLE hEvent, BOOL fCloseHandleOnRelease)
    {
        return ((delegate* unmanaged<ISpNotifyTranslator*, HANDLE, BOOL, int> )(lpVtbl[7]))((ISpNotifyTranslator*)Unsafe.AsPointer(ref this), hEvent, fCloseHandleOnRelease);
    }

    /// <include file='ISpNotifyTranslator.xml' path='doc/member[@name="ISpNotifyTranslator.Wait"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT Wait([NativeTypeName("DWORD")] uint dwMilliseconds)
    {
        return ((delegate* unmanaged<ISpNotifyTranslator*, uint, int> )(lpVtbl[8]))((ISpNotifyTranslator*)Unsafe.AsPointer(ref this), dwMilliseconds);
    }

    /// <include file='ISpNotifyTranslator.xml' path='doc/member[@name="ISpNotifyTranslator.GetEventHandle"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HANDLE GetEventHandle()
    {
        return ((HANDLE)(((delegate* unmanaged<ISpNotifyTranslator*, void*> )(lpVtbl[9]))((ISpNotifyTranslator*)Unsafe.AsPointer(ref this))));
    }

    public interface Interface : ISpNotifySink.Interface
    {
        [VtblIndex(4)]
        HRESULT InitWindowMessage(HWND hWnd, uint Msg, WPARAM wParam, LPARAM lParam);
        [VtblIndex(6)]
        HRESULT InitSpNotifyCallback(ISpNotifyCallback* pSpCallback, WPARAM wParam, LPARAM lParam);
        [VtblIndex(7)]
        HRESULT InitWin32Event(HANDLE hEvent, BOOL fCloseHandleOnRelease);
        [VtblIndex(8)]
        HRESULT Wait([NativeTypeName("DWORD")] uint dwMilliseconds);
        [VtblIndex(9)]
        HANDLE GetEventHandle();
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
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Notify;
        [NativeTypeName("HRESULT (HWND, UINT, WPARAM, LPARAM) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, uint, WPARAM, LPARAM, int> InitWindowMessage;
        [NativeTypeName("HRESULT (SPNOTIFYCALLBACK *, WPARAM, LPARAM) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, delegate* unmanaged<WPARAM, LPARAM, void> , WPARAM, LPARAM, int> InitCallback;
        [NativeTypeName("HRESULT (ISpNotifyCallback *, WPARAM, LPARAM) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISpNotifyCallback*, WPARAM, LPARAM, int> InitSpNotifyCallback;
        [NativeTypeName("HRESULT (HANDLE, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HANDLE, BOOL, int> InitWin32Event;
        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> Wait;
        [NativeTypeName("HANDLE () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void*> GetEventHandle;
    }
}