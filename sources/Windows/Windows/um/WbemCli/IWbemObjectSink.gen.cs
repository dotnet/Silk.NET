// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WbemCli.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IWbemObjectSink.xml' path='doc/member[@name="IWbemObjectSink"]/*' />
[Guid("7C857801-7381-11CF-884D-00AA004B2E24")]
[NativeTypeName("struct IWbemObjectSink : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IWbemObjectSink : IWbemObjectSink.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWbemObjectSink));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IWbemObjectSink*, Guid*, void**, int>)(lpVtbl[0]))((IWbemObjectSink*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IWbemObjectSink*, uint>)(lpVtbl[1]))((IWbemObjectSink*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IWbemObjectSink*, uint>)(lpVtbl[2]))((IWbemObjectSink*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IWbemObjectSink.xml' path='doc/member[@name="IWbemObjectSink.Indicate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Indicate([NativeTypeName("long")] int lObjectCount, IWbemClassObject** apObjArray)
    {
        return ((delegate* unmanaged<IWbemObjectSink*, int, IWbemClassObject**, int>)(lpVtbl[3]))((IWbemObjectSink*)Unsafe.AsPointer(ref this), lObjectCount, apObjArray);
    }

    /// <include file='IWbemObjectSink.xml' path='doc/member[@name="IWbemObjectSink.SetStatus"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetStatus([NativeTypeName("long")] int lFlags, HRESULT hResult, [NativeTypeName("BSTR")] ushort* strParam, IWbemClassObject* pObjParam)
    {
        return ((delegate* unmanaged<IWbemObjectSink*, int, HRESULT, ushort*, IWbemClassObject*, int>)(lpVtbl[4]))((IWbemObjectSink*)Unsafe.AsPointer(ref this), lFlags, hResult, strParam, pObjParam);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Indicate([NativeTypeName("long")] int lObjectCount, IWbemClassObject** apObjArray);

        [VtblIndex(4)]
        HRESULT SetStatus([NativeTypeName("long")] int lFlags, HRESULT hResult, [NativeTypeName("BSTR")] ushort* strParam, IWbemClassObject* pObjParam);
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

        [NativeTypeName("HRESULT (long, IWbemClassObject **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, IWbemClassObject**, int> Indicate;

        [NativeTypeName("HRESULT (long, HRESULT, BSTR, IWbemClassObject *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, HRESULT, ushort*, IWbemClassObject*, int> SetStatus;
    }
}
