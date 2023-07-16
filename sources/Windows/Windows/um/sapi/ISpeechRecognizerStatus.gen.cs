// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='ISpeechRecognizerStatus.xml' path='doc/member[@name="ISpeechRecognizerStatus"]/*'/>
[Guid("BFF9E781-53EC-484E-BB8A-0E1B5551E35C")]
[NativeTypeName("struct ISpeechRecognizerStatus : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct ISpeechRecognizerStatus : ISpeechRecognizerStatus.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpeechRecognizerStatus));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISpeechRecognizerStatus*, Guid*, void**, int> )(lpVtbl[0]))((ISpeechRecognizerStatus*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISpeechRecognizerStatus*, uint> )(lpVtbl[1]))((ISpeechRecognizerStatus*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISpeechRecognizerStatus*, uint> )(lpVtbl[2]))((ISpeechRecognizerStatus*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfoCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<ISpeechRecognizerStatus*, uint*, int> )(lpVtbl[3]))((ISpeechRecognizerStatus*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<ISpeechRecognizerStatus*, uint, uint, ITypeInfo**, int> )(lpVtbl[4]))((ISpeechRecognizerStatus*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref = "IDispatch.GetIDsOfNames"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<ISpeechRecognizerStatus*, Guid*, ushort**, uint, uint, int*, int> )(lpVtbl[5]))((ISpeechRecognizerStatus*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref = "IDispatch.Invoke"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<ISpeechRecognizerStatus*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> )(lpVtbl[6]))((ISpeechRecognizerStatus*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='ISpeechRecognizerStatus.xml' path='doc/member[@name="ISpeechRecognizerStatus.get_AudioStatus"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_AudioStatus(ISpeechAudioStatus** AudioStatus)
    {
        return ((delegate* unmanaged<ISpeechRecognizerStatus*, ISpeechAudioStatus**, int> )(lpVtbl[7]))((ISpeechRecognizerStatus*)Unsafe.AsPointer(ref this), AudioStatus);
    }

    /// <include file='ISpeechRecognizerStatus.xml' path='doc/member[@name="ISpeechRecognizerStatus.get_CurrentStreamPosition"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_CurrentStreamPosition(VARIANT* pCurrentStreamPos)
    {
        return ((delegate* unmanaged<ISpeechRecognizerStatus*, VARIANT*, int> )(lpVtbl[8]))((ISpeechRecognizerStatus*)Unsafe.AsPointer(ref this), pCurrentStreamPos);
    }

    /// <include file='ISpeechRecognizerStatus.xml' path='doc/member[@name="ISpeechRecognizerStatus.get_CurrentStreamNumber"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_CurrentStreamNumber([NativeTypeName("long *")] int* StreamNumber)
    {
        return ((delegate* unmanaged<ISpeechRecognizerStatus*, int*, int> )(lpVtbl[9]))((ISpeechRecognizerStatus*)Unsafe.AsPointer(ref this), StreamNumber);
    }

    /// <include file='ISpeechRecognizerStatus.xml' path='doc/member[@name="ISpeechRecognizerStatus.get_NumberOfActiveRules"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_NumberOfActiveRules([NativeTypeName("long *")] int* NumberOfActiveRules)
    {
        return ((delegate* unmanaged<ISpeechRecognizerStatus*, int*, int> )(lpVtbl[10]))((ISpeechRecognizerStatus*)Unsafe.AsPointer(ref this), NumberOfActiveRules);
    }

    /// <include file='ISpeechRecognizerStatus.xml' path='doc/member[@name="ISpeechRecognizerStatus.get_ClsidEngine"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_ClsidEngine([NativeTypeName("BSTR *")] ushort** ClsidEngine)
    {
        return ((delegate* unmanaged<ISpeechRecognizerStatus*, ushort**, int> )(lpVtbl[11]))((ISpeechRecognizerStatus*)Unsafe.AsPointer(ref this), ClsidEngine);
    }

    /// <include file='ISpeechRecognizerStatus.xml' path='doc/member[@name="ISpeechRecognizerStatus.get_SupportedLanguages"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_SupportedLanguages(VARIANT* SupportedLanguages)
    {
        return ((delegate* unmanaged<ISpeechRecognizerStatus*, VARIANT*, int> )(lpVtbl[12]))((ISpeechRecognizerStatus*)Unsafe.AsPointer(ref this), SupportedLanguages);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT get_AudioStatus(ISpeechAudioStatus** AudioStatus);
        [VtblIndex(8)]
        HRESULT get_CurrentStreamPosition(VARIANT* pCurrentStreamPos);
        [VtblIndex(9)]
        HRESULT get_CurrentStreamNumber([NativeTypeName("long *")] int* StreamNumber);
        [VtblIndex(10)]
        HRESULT get_NumberOfActiveRules([NativeTypeName("long *")] int* NumberOfActiveRules);
        [VtblIndex(11)]
        HRESULT get_ClsidEngine([NativeTypeName("BSTR *")] ushort** ClsidEngine);
        [VtblIndex(12)]
        HRESULT get_SupportedLanguages(VARIANT* SupportedLanguages);
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
        [NativeTypeName("HRESULT (ISpeechAudioStatus **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISpeechAudioStatus**, int> get_AudioStatus;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_CurrentStreamPosition;
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_CurrentStreamNumber;
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_NumberOfActiveRules;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_ClsidEngine;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_SupportedLanguages;
    }
}