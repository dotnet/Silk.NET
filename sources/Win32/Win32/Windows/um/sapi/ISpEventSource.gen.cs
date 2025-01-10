// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("BE7A9CCE-5F9E-11D2-960F-00C04F8EE628")]
[NativeTypeName("struct ISpEventSource : ISpNotifySource")]
[NativeInheritance("ISpNotifySource")]
public unsafe partial struct ISpEventSource : ISpEventSource.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpEventSource));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISpEventSource, Guid*, void**, int>)((*lpVtbl)[0]))(
            this,
            riid,
            ppvObject
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISpEventSource, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISpEventSource, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetNotifySink(ISpNotifySink pNotifySink)
    {
        return ((delegate* unmanaged<ISpEventSource, ISpNotifySink, int>)((*lpVtbl)[3]))(
            this,
            pNotifySink
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetNotifyWindowMessage(HWND hWnd, uint Msg, WPARAM wParam, LPARAM lParam)
    {
        return (
            (delegate* unmanaged<ISpEventSource, HWND, uint, WPARAM, LPARAM, int>)((*lpVtbl)[4])
        )(this, hWnd, Msg, wParam, lParam);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetNotifyCallbackFunction(
        [NativeTypeName("SPNOTIFYCALLBACK *")]
            delegate* unmanaged<WPARAM, LPARAM, void> pfnCallback,
        WPARAM wParam,
        LPARAM lParam
    )
    {
        return (
            (delegate* unmanaged<
                ISpEventSource,
                delegate* unmanaged<WPARAM, LPARAM, void>,
                WPARAM,
                LPARAM,
                int>)((*lpVtbl)[5])
        )(this, pfnCallback, wParam, lParam);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetNotifyCallbackInterface(
        ISpNotifyCallback* pSpCallback,
        WPARAM wParam,
        LPARAM lParam
    )
    {
        return (
            (delegate* unmanaged<ISpEventSource, ISpNotifyCallback*, WPARAM, LPARAM, int>)(
                (*lpVtbl)[6]
            )
        )(this, pSpCallback, wParam, lParam);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetNotifyWin32Event()
    {
        return ((delegate* unmanaged<ISpEventSource, int>)((*lpVtbl)[7]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT WaitForNotifyEvent([NativeTypeName("DWORD")] uint dwMilliseconds)
    {
        return ((delegate* unmanaged<ISpEventSource, uint, int>)((*lpVtbl)[8]))(
            this,
            dwMilliseconds
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HANDLE GetNotifyEventHandle()
    {
        return ((HANDLE)(((delegate* unmanaged<ISpEventSource, void*>)((*lpVtbl)[9]))(this)));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetInterest(
        [NativeTypeName("ULONGLONG")] ulong ullEventInterest,
        [NativeTypeName("ULONGLONG")] ulong ullQueuedInterest
    )
    {
        return ((delegate* unmanaged<ISpEventSource, ulong, ulong, int>)((*lpVtbl)[10]))(
            this,
            ullEventInterest,
            ullQueuedInterest
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetEvents(
        [NativeTypeName("ULONG")] uint ulCount,
        SPEVENT* pEventArray,
        [NativeTypeName("ULONG *")] uint* pulFetched
    )
    {
        return ((delegate* unmanaged<ISpEventSource, uint, SPEVENT*, uint*, int>)((*lpVtbl)[11]))(
            this,
            ulCount,
            pEventArray,
            pulFetched
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetInfo(SPEVENTSOURCEINFO* pInfo)
    {
        return ((delegate* unmanaged<ISpEventSource, SPEVENTSOURCEINFO*, int>)((*lpVtbl)[12]))(
            this,
            pInfo
        );
    }

    public interface Interface : ISpNotifySource.Interface
    {
        [VtblIndex(10)]
        HRESULT SetInterest(
            [NativeTypeName("ULONGLONG")] ulong ullEventInterest,
            [NativeTypeName("ULONGLONG")] ulong ullQueuedInterest
        );

        [VtblIndex(11)]
        HRESULT GetEvents(
            [NativeTypeName("ULONG")] uint ulCount,
            SPEVENT* pEventArray,
            [NativeTypeName("ULONG *")] uint* pulFetched
        );

        [VtblIndex(12)]
        HRESULT GetInfo(SPEVENTSOURCEINFO* pInfo);
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
        public delegate* unmanaged<TSelf*, ISpNotifySink, int> SetNotifySink;

        [NativeTypeName("HRESULT (HWND, UINT, WPARAM, LPARAM) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, uint, WPARAM, LPARAM, int> SetNotifyWindowMessage;

        [NativeTypeName("HRESULT (SPNOTIFYCALLBACK *, WPARAM, LPARAM) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            delegate* unmanaged<WPARAM, LPARAM, void>,
            WPARAM,
            LPARAM,
            int> SetNotifyCallbackFunction;

        [NativeTypeName("HRESULT (ISpNotifyCallback *, WPARAM, LPARAM) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            ISpNotifyCallback*,
            WPARAM,
            LPARAM,
            int> SetNotifyCallbackInterface;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> SetNotifyWin32Event;

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> WaitForNotifyEvent;

        [NativeTypeName("HANDLE () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void*> GetNotifyEventHandle;

        [NativeTypeName("HRESULT (ULONGLONG, ULONGLONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong, ulong, int> SetInterest;

        [NativeTypeName("HRESULT (ULONG, SPEVENT *, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, SPEVENT*, uint*, int> GetEvents;

        [NativeTypeName("HRESULT (SPEVENTSOURCEINFO *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SPEVENTSOURCEINFO*, int> GetInfo;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISpEventSource"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISpEventSource(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.ISpNotifySource"/> to <see cref = "ISpEventSource"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.ISpNotifySource"/> instance to be converted </param>
    public static explicit operator ISpEventSource(Silk.NET.Windows.ISpNotifySource value)
    {
        return new ISpEventSource(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpEventSource"/> to <see cref = "Silk.NET.Windows.ISpNotifySource"/>.</summary>
    /// <param name = "value">The <see cref = "ISpEventSource"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.ISpNotifySource(ISpEventSource value)
    {
        return new Silk.NET.Windows.ISpNotifySource(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISpEventSource"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISpEventSource(Silk.NET.Windows.IUnknown value)
    {
        return new ISpEventSource(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpEventSource"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISpEventSource"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISpEventSource value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
