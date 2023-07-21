// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WbemCli.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IWbemCallResult.xml' path='doc/member[@name="IWbemCallResult"]/*' />
[Guid("44ACA675-E8FC-11D0-A07C-00C04FB68820")]
[NativeTypeName("struct IWbemCallResult : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IWbemCallResult : IWbemCallResult.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWbemCallResult));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IWbemCallResult*, Guid*, void**, int>)(lpVtbl[0]))((IWbemCallResult*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IWbemCallResult*, uint>)(lpVtbl[1]))((IWbemCallResult*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IWbemCallResult*, uint>)(lpVtbl[2]))((IWbemCallResult*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IWbemCallResult.xml' path='doc/member[@name="IWbemCallResult.GetResultObject"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetResultObject([NativeTypeName("long")] int lTimeout, IWbemClassObject** ppResultObject)
    {
        return ((delegate* unmanaged<IWbemCallResult*, int, IWbemClassObject**, int>)(lpVtbl[3]))((IWbemCallResult*)Unsafe.AsPointer(ref this), lTimeout, ppResultObject);
    }

    /// <include file='IWbemCallResult.xml' path='doc/member[@name="IWbemCallResult.GetResultString"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetResultString([NativeTypeName("long")] int lTimeout, [NativeTypeName("BSTR *")] ushort** pstrResultString)
    {
        return ((delegate* unmanaged<IWbemCallResult*, int, ushort**, int>)(lpVtbl[4]))((IWbemCallResult*)Unsafe.AsPointer(ref this), lTimeout, pstrResultString);
    }

    /// <include file='IWbemCallResult.xml' path='doc/member[@name="IWbemCallResult.GetResultServices"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetResultServices([NativeTypeName("long")] int lTimeout, IWbemServices** ppServices)
    {
        return ((delegate* unmanaged<IWbemCallResult*, int, IWbemServices**, int>)(lpVtbl[5]))((IWbemCallResult*)Unsafe.AsPointer(ref this), lTimeout, ppServices);
    }

    /// <include file='IWbemCallResult.xml' path='doc/member[@name="IWbemCallResult.GetCallStatus"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetCallStatus([NativeTypeName("long")] int lTimeout, [NativeTypeName("long *")] int* plStatus)
    {
        return ((delegate* unmanaged<IWbemCallResult*, int, int*, int>)(lpVtbl[6]))((IWbemCallResult*)Unsafe.AsPointer(ref this), lTimeout, plStatus);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetResultObject([NativeTypeName("long")] int lTimeout, IWbemClassObject** ppResultObject);

        [VtblIndex(4)]
        HRESULT GetResultString([NativeTypeName("long")] int lTimeout, [NativeTypeName("BSTR *")] ushort** pstrResultString);

        [VtblIndex(5)]
        HRESULT GetResultServices([NativeTypeName("long")] int lTimeout, IWbemServices** ppServices);

        [VtblIndex(6)]
        HRESULT GetCallStatus([NativeTypeName("long")] int lTimeout, [NativeTypeName("long *")] int* plStatus);
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
        public delegate* unmanaged<TSelf*, int, IWbemClassObject**, int> GetResultObject;

        [NativeTypeName("HRESULT (long, BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, ushort**, int> GetResultString;

        [NativeTypeName("HRESULT (long, IWbemServices **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, IWbemServices**, int> GetResultServices;

        [NativeTypeName("HRESULT (long, long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int*, int> GetCallStatus;
    }
}
