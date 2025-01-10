// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("30510839-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IEventTarget2 : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IEventTarget2 : IEventTarget2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IEventTarget2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IEventTarget2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IEventTarget2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IEventTarget2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetRegisteredEventTypes(SAFEARRAY** ppEventTypeArray)
    {
        return ((delegate* unmanaged<IEventTarget2, SAFEARRAY**, int>)((*lpVtbl)[3]))(
            this,
            ppEventTypeArray
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetListenersForType(
        [NativeTypeName("LPCWSTR")] ushort* pszEventType,
        SAFEARRAY** ppEventHandlerArray
    )
    {
        return ((delegate* unmanaged<IEventTarget2, ushort*, SAFEARRAY**, int>)((*lpVtbl)[4]))(
            this,
            pszEventType,
            ppEventHandlerArray
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT RegisterForDOMEventListeners(IDOMEventRegistrationCallback pCallback)
    {
        return (
            (delegate* unmanaged<IEventTarget2, IDOMEventRegistrationCallback, int>)((*lpVtbl)[5])
        )(this, pCallback);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT UnregisterForDOMEventListeners(IDOMEventRegistrationCallback pCallback)
    {
        return (
            (delegate* unmanaged<IEventTarget2, IDOMEventRegistrationCallback, int>)((*lpVtbl)[6])
        )(this, pCallback);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetRegisteredEventTypes(SAFEARRAY** ppEventTypeArray);

        [VtblIndex(4)]
        HRESULT GetListenersForType(
            [NativeTypeName("LPCWSTR")] ushort* pszEventType,
            SAFEARRAY** ppEventHandlerArray
        );

        [VtblIndex(5)]
        HRESULT RegisterForDOMEventListeners(IDOMEventRegistrationCallback pCallback);

        [VtblIndex(6)]
        HRESULT UnregisterForDOMEventListeners(IDOMEventRegistrationCallback pCallback);
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

        [NativeTypeName("HRESULT (SAFEARRAY **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SAFEARRAY**, int> GetRegisteredEventTypes;

        [NativeTypeName("HRESULT (LPCWSTR, SAFEARRAY **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, SAFEARRAY**, int> GetListenersForType;

        [NativeTypeName("HRESULT (IDOMEventRegistrationCallback *) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            IDOMEventRegistrationCallback,
            int> RegisterForDOMEventListeners;

        [NativeTypeName("HRESULT (IDOMEventRegistrationCallback *) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            IDOMEventRegistrationCallback,
            int> UnregisterForDOMEventListeners;
    }

    /// <summary>Initializes a new instance of the <see cref = "IEventTarget2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IEventTarget2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IEventTarget2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IEventTarget2(Silk.NET.Windows.IUnknown value)
    {
        return new IEventTarget2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IEventTarget2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IEventTarget2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IEventTarget2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
