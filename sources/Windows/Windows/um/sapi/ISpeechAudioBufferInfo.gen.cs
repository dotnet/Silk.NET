// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='ISpeechAudioBufferInfo.xml' path='doc/member[@name="ISpeechAudioBufferInfo"]/*'/>
[Guid("11B103D8-1142-4EDF-A093-82FB3915F8CC")]
[NativeTypeName("struct ISpeechAudioBufferInfo : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct ISpeechAudioBufferInfo : ISpeechAudioBufferInfo.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpeechAudioBufferInfo));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISpeechAudioBufferInfo*, Guid*, void**, int> )(lpVtbl[0]))((ISpeechAudioBufferInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISpeechAudioBufferInfo*, uint> )(lpVtbl[1]))((ISpeechAudioBufferInfo*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISpeechAudioBufferInfo*, uint> )(lpVtbl[2]))((ISpeechAudioBufferInfo*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfoCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<ISpeechAudioBufferInfo*, uint*, int> )(lpVtbl[3]))((ISpeechAudioBufferInfo*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<ISpeechAudioBufferInfo*, uint, uint, ITypeInfo**, int> )(lpVtbl[4]))((ISpeechAudioBufferInfo*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref = "IDispatch.GetIDsOfNames"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<ISpeechAudioBufferInfo*, Guid*, ushort**, uint, uint, int*, int> )(lpVtbl[5]))((ISpeechAudioBufferInfo*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref = "IDispatch.Invoke"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<ISpeechAudioBufferInfo*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> )(lpVtbl[6]))((ISpeechAudioBufferInfo*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='ISpeechAudioBufferInfo.xml' path='doc/member[@name="ISpeechAudioBufferInfo.get_MinNotification"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_MinNotification([NativeTypeName("long *")] int* MinNotification)
    {
        return ((delegate* unmanaged<ISpeechAudioBufferInfo*, int*, int> )(lpVtbl[7]))((ISpeechAudioBufferInfo*)Unsafe.AsPointer(ref this), MinNotification);
    }

    /// <include file='ISpeechAudioBufferInfo.xml' path='doc/member[@name="ISpeechAudioBufferInfo.put_MinNotification"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_MinNotification([NativeTypeName("long")] int MinNotification)
    {
        return ((delegate* unmanaged<ISpeechAudioBufferInfo*, int, int> )(lpVtbl[8]))((ISpeechAudioBufferInfo*)Unsafe.AsPointer(ref this), MinNotification);
    }

    /// <include file='ISpeechAudioBufferInfo.xml' path='doc/member[@name="ISpeechAudioBufferInfo.get_BufferSize"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_BufferSize([NativeTypeName("long *")] int* BufferSize)
    {
        return ((delegate* unmanaged<ISpeechAudioBufferInfo*, int*, int> )(lpVtbl[9]))((ISpeechAudioBufferInfo*)Unsafe.AsPointer(ref this), BufferSize);
    }

    /// <include file='ISpeechAudioBufferInfo.xml' path='doc/member[@name="ISpeechAudioBufferInfo.put_BufferSize"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_BufferSize([NativeTypeName("long")] int BufferSize)
    {
        return ((delegate* unmanaged<ISpeechAudioBufferInfo*, int, int> )(lpVtbl[10]))((ISpeechAudioBufferInfo*)Unsafe.AsPointer(ref this), BufferSize);
    }

    /// <include file='ISpeechAudioBufferInfo.xml' path='doc/member[@name="ISpeechAudioBufferInfo.get_EventBias"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_EventBias([NativeTypeName("long *")] int* EventBias)
    {
        return ((delegate* unmanaged<ISpeechAudioBufferInfo*, int*, int> )(lpVtbl[11]))((ISpeechAudioBufferInfo*)Unsafe.AsPointer(ref this), EventBias);
    }

    /// <include file='ISpeechAudioBufferInfo.xml' path='doc/member[@name="ISpeechAudioBufferInfo.put_EventBias"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT put_EventBias([NativeTypeName("long")] int EventBias)
    {
        return ((delegate* unmanaged<ISpeechAudioBufferInfo*, int, int> )(lpVtbl[12]))((ISpeechAudioBufferInfo*)Unsafe.AsPointer(ref this), EventBias);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT get_MinNotification([NativeTypeName("long *")] int* MinNotification);
        [VtblIndex(8)]
        HRESULT put_MinNotification([NativeTypeName("long")] int MinNotification);
        [VtblIndex(9)]
        HRESULT get_BufferSize([NativeTypeName("long *")] int* BufferSize);
        [VtblIndex(10)]
        HRESULT put_BufferSize([NativeTypeName("long")] int BufferSize);
        [VtblIndex(11)]
        HRESULT get_EventBias([NativeTypeName("long *")] int* EventBias);
        [VtblIndex(12)]
        HRESULT put_EventBias([NativeTypeName("long")] int EventBias);
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
        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetTypeInfoCount;
        [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, ITypeInfo**, int> GetTypeInfo;
        [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, ushort**, uint, uint, int*, int> GetIDsOfNames;
        [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> Invoke;
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_MinNotification;
        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_MinNotification;
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_BufferSize;
        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_BufferSize;
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_EventBias;
        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_EventBias;
    }
}