// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='ISpeechAudioFormat.xml' path='doc/member[@name="ISpeechAudioFormat"]/*'/>
[Guid("E6E9C590-3E18-40E3-8299-061F98BDE7C7")]
[NativeTypeName("struct ISpeechAudioFormat : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct ISpeechAudioFormat : ISpeechAudioFormat.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpeechAudioFormat));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISpeechAudioFormat*, Guid*, void**, int> )(lpVtbl[0]))((ISpeechAudioFormat*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISpeechAudioFormat*, uint> )(lpVtbl[1]))((ISpeechAudioFormat*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISpeechAudioFormat*, uint> )(lpVtbl[2]))((ISpeechAudioFormat*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfoCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<ISpeechAudioFormat*, uint*, int> )(lpVtbl[3]))((ISpeechAudioFormat*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<ISpeechAudioFormat*, uint, uint, ITypeInfo**, int> )(lpVtbl[4]))((ISpeechAudioFormat*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref = "IDispatch.GetIDsOfNames"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<ISpeechAudioFormat*, Guid*, ushort**, uint, uint, int*, int> )(lpVtbl[5]))((ISpeechAudioFormat*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref = "IDispatch.Invoke"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<ISpeechAudioFormat*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> )(lpVtbl[6]))((ISpeechAudioFormat*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='ISpeechAudioFormat.xml' path='doc/member[@name="ISpeechAudioFormat.get_Type"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Type(SpeechAudioFormatType* AudioFormat)
    {
        return ((delegate* unmanaged<ISpeechAudioFormat*, SpeechAudioFormatType*, int> )(lpVtbl[7]))((ISpeechAudioFormat*)Unsafe.AsPointer(ref this), AudioFormat);
    }

    /// <include file='ISpeechAudioFormat.xml' path='doc/member[@name="ISpeechAudioFormat.put_Type"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_Type(SpeechAudioFormatType AudioFormat)
    {
        return ((delegate* unmanaged<ISpeechAudioFormat*, SpeechAudioFormatType, int> )(lpVtbl[8]))((ISpeechAudioFormat*)Unsafe.AsPointer(ref this), AudioFormat);
    }

    /// <include file='ISpeechAudioFormat.xml' path='doc/member[@name="ISpeechAudioFormat.get_Guid"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Guid([NativeTypeName("BSTR *")] ushort** Guid)
    {
        return ((delegate* unmanaged<ISpeechAudioFormat*, ushort**, int> )(lpVtbl[9]))((ISpeechAudioFormat*)Unsafe.AsPointer(ref this), Guid);
    }

    /// <include file='ISpeechAudioFormat.xml' path='doc/member[@name="ISpeechAudioFormat.put_Guid"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_Guid([NativeTypeName("BSTR")] ushort* Guid)
    {
        return ((delegate* unmanaged<ISpeechAudioFormat*, ushort*, int> )(lpVtbl[10]))((ISpeechAudioFormat*)Unsafe.AsPointer(ref this), Guid);
    }

    /// <include file='ISpeechAudioFormat.xml' path='doc/member[@name="ISpeechAudioFormat.GetWaveFormatEx"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetWaveFormatEx(ISpeechWaveFormatEx** SpeechWaveFormatEx)
    {
        return ((delegate* unmanaged<ISpeechAudioFormat*, ISpeechWaveFormatEx**, int> )(lpVtbl[11]))((ISpeechAudioFormat*)Unsafe.AsPointer(ref this), SpeechWaveFormatEx);
    }

    /// <include file='ISpeechAudioFormat.xml' path='doc/member[@name="ISpeechAudioFormat.SetWaveFormatEx"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT SetWaveFormatEx(ISpeechWaveFormatEx* SpeechWaveFormatEx)
    {
        return ((delegate* unmanaged<ISpeechAudioFormat*, ISpeechWaveFormatEx*, int> )(lpVtbl[12]))((ISpeechAudioFormat*)Unsafe.AsPointer(ref this), SpeechWaveFormatEx);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT get_Type(SpeechAudioFormatType* AudioFormat);
        [VtblIndex(8)]
        HRESULT put_Type(SpeechAudioFormatType AudioFormat);
        [VtblIndex(9)]
        HRESULT get_Guid([NativeTypeName("BSTR *")] ushort** Guid);
        [VtblIndex(10)]
        HRESULT put_Guid([NativeTypeName("BSTR")] ushort* Guid);
        [VtblIndex(11)]
        HRESULT GetWaveFormatEx(ISpeechWaveFormatEx** SpeechWaveFormatEx);
        [VtblIndex(12)]
        HRESULT SetWaveFormatEx(ISpeechWaveFormatEx* SpeechWaveFormatEx);
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
        [NativeTypeName("HRESULT (SpeechAudioFormatType *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SpeechAudioFormatType*, int> get_Type;
        [NativeTypeName("HRESULT (SpeechAudioFormatType) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SpeechAudioFormatType, int> put_Type;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_Guid;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_Guid;
        [NativeTypeName("HRESULT (ISpeechWaveFormatEx **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISpeechWaveFormatEx**, int> GetWaveFormatEx;
        [NativeTypeName("HRESULT (ISpeechWaveFormatEx *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISpeechWaveFormatEx*, int> SetWaveFormatEx;
    }
}