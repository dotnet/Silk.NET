// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("30510842-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IDebugCallbackNotificationHandler : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDebugCallbackNotificationHandler
    : IDebugCallbackNotificationHandler.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDebugCallbackNotificationHandler));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IDebugCallbackNotificationHandler, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDebugCallbackNotificationHandler, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDebugCallbackNotificationHandler, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT RequestedCallbackTypes([NativeTypeName("DWORD *")] uint* pCallbackMask)
    {
        return ((delegate* unmanaged<IDebugCallbackNotificationHandler, uint*, int>)((*lpVtbl)[3]))(
            this,
            pCallbackMask
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT BeforeDispatchEvent(IUnknown pEvent)
    {
        return (
            (delegate* unmanaged<IDebugCallbackNotificationHandler, IUnknown, int>)((*lpVtbl)[4])
        )(this, pEvent);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT DispatchEventComplete(
        IUnknown pEvent,
        [NativeTypeName("DWORD")] uint propagationStatus
    )
    {
        return (
            (delegate* unmanaged<IDebugCallbackNotificationHandler, IUnknown, uint, int>)(
                (*lpVtbl)[5]
            )
        )(this, pEvent, propagationStatus);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT BeforeInvokeDomCallback(
        IUnknown pEvent,
        IScriptEventHandler pCallback,
        DOM_EVENT_PHASE eStage,
        [NativeTypeName("DWORD")] uint propagationStatus
    )
    {
        return (
            (delegate* unmanaged<
                IDebugCallbackNotificationHandler,
                IUnknown,
                IScriptEventHandler,
                DOM_EVENT_PHASE,
                uint,
                int>)((*lpVtbl)[6])
        )(this, pEvent, pCallback, eStage, propagationStatus);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT InvokeDomCallbackComplete(
        IUnknown pEvent,
        IScriptEventHandler pCallback,
        DOM_EVENT_PHASE eStage,
        [NativeTypeName("DWORD")] uint propagationStatus
    )
    {
        return (
            (delegate* unmanaged<
                IDebugCallbackNotificationHandler,
                IUnknown,
                IScriptEventHandler,
                DOM_EVENT_PHASE,
                uint,
                int>)((*lpVtbl)[7])
        )(this, pEvent, pCallback, eStage, propagationStatus);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT BeforeInvokeCallback(
        SCRIPT_TIMER_TYPE eCallbackType,
        [NativeTypeName("DWORD")] uint callbackCookie,
        IDispatch pDispHandler,
        [NativeTypeName("ULONGLONG")] ulong ullHandlerCookie,
        [NativeTypeName("BSTR")] ushort* functionName,
        [NativeTypeName("UINT32")] uint line,
        [NativeTypeName("UINT32")] uint column,
        [NativeTypeName("UINT32")] uint cchLength,
        IUnknown pDebugDocumentContext
    )
    {
        return (
            (delegate* unmanaged<
                IDebugCallbackNotificationHandler,
                SCRIPT_TIMER_TYPE,
                uint,
                IDispatch,
                ulong,
                ushort*,
                uint,
                uint,
                uint,
                IUnknown,
                int>)((*lpVtbl)[8])
        )(
            this,
            eCallbackType,
            callbackCookie,
            pDispHandler,
            ullHandlerCookie,
            functionName,
            line,
            column,
            cchLength,
            pDebugDocumentContext
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT InvokeCallbackComplete(
        SCRIPT_TIMER_TYPE eCallbackType,
        [NativeTypeName("DWORD")] uint callbackCookie,
        IDispatch pDispHandler,
        [NativeTypeName("ULONGLONG")] ulong ullHandlerCookie,
        [NativeTypeName("BSTR")] ushort* functionName,
        [NativeTypeName("UINT32")] uint line,
        [NativeTypeName("UINT32")] uint column,
        [NativeTypeName("UINT32")] uint cchLength,
        IUnknown pDebugDocumentContext
    )
    {
        return (
            (delegate* unmanaged<
                IDebugCallbackNotificationHandler,
                SCRIPT_TIMER_TYPE,
                uint,
                IDispatch,
                ulong,
                ushort*,
                uint,
                uint,
                uint,
                IUnknown,
                int>)((*lpVtbl)[9])
        )(
            this,
            eCallbackType,
            callbackCookie,
            pDispHandler,
            ullHandlerCookie,
            functionName,
            line,
            column,
            cchLength,
            pDebugDocumentContext
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT RequestedCallbackTypes([NativeTypeName("DWORD *")] uint* pCallbackMask);

        [VtblIndex(4)]
        HRESULT BeforeDispatchEvent(IUnknown pEvent);

        [VtblIndex(5)]
        HRESULT DispatchEventComplete(
            IUnknown pEvent,
            [NativeTypeName("DWORD")] uint propagationStatus
        );

        [VtblIndex(6)]
        HRESULT BeforeInvokeDomCallback(
            IUnknown pEvent,
            IScriptEventHandler pCallback,
            DOM_EVENT_PHASE eStage,
            [NativeTypeName("DWORD")] uint propagationStatus
        );

        [VtblIndex(7)]
        HRESULT InvokeDomCallbackComplete(
            IUnknown pEvent,
            IScriptEventHandler pCallback,
            DOM_EVENT_PHASE eStage,
            [NativeTypeName("DWORD")] uint propagationStatus
        );

        [VtblIndex(8)]
        HRESULT BeforeInvokeCallback(
            SCRIPT_TIMER_TYPE eCallbackType,
            [NativeTypeName("DWORD")] uint callbackCookie,
            IDispatch pDispHandler,
            [NativeTypeName("ULONGLONG")] ulong ullHandlerCookie,
            [NativeTypeName("BSTR")] ushort* functionName,
            [NativeTypeName("UINT32")] uint line,
            [NativeTypeName("UINT32")] uint column,
            [NativeTypeName("UINT32")] uint cchLength,
            IUnknown pDebugDocumentContext
        );

        [VtblIndex(9)]
        HRESULT InvokeCallbackComplete(
            SCRIPT_TIMER_TYPE eCallbackType,
            [NativeTypeName("DWORD")] uint callbackCookie,
            IDispatch pDispHandler,
            [NativeTypeName("ULONGLONG")] ulong ullHandlerCookie,
            [NativeTypeName("BSTR")] ushort* functionName,
            [NativeTypeName("UINT32")] uint line,
            [NativeTypeName("UINT32")] uint column,
            [NativeTypeName("UINT32")] uint cchLength,
            IUnknown pDebugDocumentContext
        );
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

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> RequestedCallbackTypes;

        [NativeTypeName("HRESULT (IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown, int> BeforeDispatchEvent;

        [NativeTypeName("HRESULT (IUnknown *, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown, uint, int> DispatchEventComplete;

        [NativeTypeName(
            "HRESULT (IUnknown *, IScriptEventHandler *, DOM_EVENT_PHASE, DWORD) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IUnknown,
            IScriptEventHandler,
            DOM_EVENT_PHASE,
            uint,
            int> BeforeInvokeDomCallback;

        [NativeTypeName(
            "HRESULT (IUnknown *, IScriptEventHandler *, DOM_EVENT_PHASE, DWORD) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IUnknown,
            IScriptEventHandler,
            DOM_EVENT_PHASE,
            uint,
            int> InvokeDomCallbackComplete;

        [NativeTypeName(
            "HRESULT (SCRIPT_TIMER_TYPE, DWORD, IDispatch *, ULONGLONG, BSTR, UINT32, UINT32, UINT32, IUnknown *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            SCRIPT_TIMER_TYPE,
            uint,
            IDispatch,
            ulong,
            ushort*,
            uint,
            uint,
            uint,
            IUnknown,
            int> BeforeInvokeCallback;

        [NativeTypeName(
            "HRESULT (SCRIPT_TIMER_TYPE, DWORD, IDispatch *, ULONGLONG, BSTR, UINT32, UINT32, UINT32, IUnknown *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            SCRIPT_TIMER_TYPE,
            uint,
            IDispatch,
            ulong,
            ushort*,
            uint,
            uint,
            uint,
            IUnknown,
            int> InvokeCallbackComplete;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDebugCallbackNotificationHandler"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDebugCallbackNotificationHandler(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDebugCallbackNotificationHandler"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDebugCallbackNotificationHandler(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IDebugCallbackNotificationHandler(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDebugCallbackNotificationHandler"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDebugCallbackNotificationHandler"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IDebugCallbackNotificationHandler value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
