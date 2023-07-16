// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='ISpeechPhraseProperty.xml' path='doc/member[@name="ISpeechPhraseProperty"]/*'/>
[Guid("CE563D48-961E-4732-A2E1-378A42B430BE")]
[NativeTypeName("struct ISpeechPhraseProperty : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct ISpeechPhraseProperty : ISpeechPhraseProperty.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpeechPhraseProperty));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISpeechPhraseProperty*, Guid*, void**, int> )(lpVtbl[0]))((ISpeechPhraseProperty*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISpeechPhraseProperty*, uint> )(lpVtbl[1]))((ISpeechPhraseProperty*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISpeechPhraseProperty*, uint> )(lpVtbl[2]))((ISpeechPhraseProperty*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfoCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<ISpeechPhraseProperty*, uint*, int> )(lpVtbl[3]))((ISpeechPhraseProperty*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<ISpeechPhraseProperty*, uint, uint, ITypeInfo**, int> )(lpVtbl[4]))((ISpeechPhraseProperty*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref = "IDispatch.GetIDsOfNames"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<ISpeechPhraseProperty*, Guid*, ushort**, uint, uint, int*, int> )(lpVtbl[5]))((ISpeechPhraseProperty*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref = "IDispatch.Invoke"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<ISpeechPhraseProperty*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> )(lpVtbl[6]))((ISpeechPhraseProperty*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='ISpeechPhraseProperty.xml' path='doc/member[@name="ISpeechPhraseProperty.get_Name"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Name([NativeTypeName("BSTR *")] ushort** Name)
    {
        return ((delegate* unmanaged<ISpeechPhraseProperty*, ushort**, int> )(lpVtbl[7]))((ISpeechPhraseProperty*)Unsafe.AsPointer(ref this), Name);
    }

    /// <include file='ISpeechPhraseProperty.xml' path='doc/member[@name="ISpeechPhraseProperty.get_Id"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Id([NativeTypeName("long *")] int* Id)
    {
        return ((delegate* unmanaged<ISpeechPhraseProperty*, int*, int> )(lpVtbl[8]))((ISpeechPhraseProperty*)Unsafe.AsPointer(ref this), Id);
    }

    /// <include file='ISpeechPhraseProperty.xml' path='doc/member[@name="ISpeechPhraseProperty.get_Value"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Value(VARIANT* Value)
    {
        return ((delegate* unmanaged<ISpeechPhraseProperty*, VARIANT*, int> )(lpVtbl[9]))((ISpeechPhraseProperty*)Unsafe.AsPointer(ref this), Value);
    }

    /// <include file='ISpeechPhraseProperty.xml' path='doc/member[@name="ISpeechPhraseProperty.get_FirstElement"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_FirstElement([NativeTypeName("long *")] int* FirstElement)
    {
        return ((delegate* unmanaged<ISpeechPhraseProperty*, int*, int> )(lpVtbl[10]))((ISpeechPhraseProperty*)Unsafe.AsPointer(ref this), FirstElement);
    }

    /// <include file='ISpeechPhraseProperty.xml' path='doc/member[@name="ISpeechPhraseProperty.get_NumberOfElements"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_NumberOfElements([NativeTypeName("long *")] int* NumberOfElements)
    {
        return ((delegate* unmanaged<ISpeechPhraseProperty*, int*, int> )(lpVtbl[11]))((ISpeechPhraseProperty*)Unsafe.AsPointer(ref this), NumberOfElements);
    }

    /// <include file='ISpeechPhraseProperty.xml' path='doc/member[@name="ISpeechPhraseProperty.get_EngineConfidence"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_EngineConfidence(float* Confidence)
    {
        return ((delegate* unmanaged<ISpeechPhraseProperty*, float*, int> )(lpVtbl[12]))((ISpeechPhraseProperty*)Unsafe.AsPointer(ref this), Confidence);
    }

    /// <include file='ISpeechPhraseProperty.xml' path='doc/member[@name="ISpeechPhraseProperty.get_Confidence"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_Confidence(SpeechEngineConfidence* Confidence)
    {
        return ((delegate* unmanaged<ISpeechPhraseProperty*, SpeechEngineConfidence*, int> )(lpVtbl[13]))((ISpeechPhraseProperty*)Unsafe.AsPointer(ref this), Confidence);
    }

    /// <include file='ISpeechPhraseProperty.xml' path='doc/member[@name="ISpeechPhraseProperty.get_Parent"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_Parent(ISpeechPhraseProperty** ParentProperty)
    {
        return ((delegate* unmanaged<ISpeechPhraseProperty*, ISpeechPhraseProperty**, int> )(lpVtbl[14]))((ISpeechPhraseProperty*)Unsafe.AsPointer(ref this), ParentProperty);
    }

    /// <include file='ISpeechPhraseProperty.xml' path='doc/member[@name="ISpeechPhraseProperty.get_Children"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_Children(ISpeechPhraseProperties** Children)
    {
        return ((delegate* unmanaged<ISpeechPhraseProperty*, ISpeechPhraseProperties**, int> )(lpVtbl[15]))((ISpeechPhraseProperty*)Unsafe.AsPointer(ref this), Children);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT get_Name([NativeTypeName("BSTR *")] ushort** Name);
        [VtblIndex(8)]
        HRESULT get_Id([NativeTypeName("long *")] int* Id);
        [VtblIndex(9)]
        HRESULT get_Value(VARIANT* Value);
        [VtblIndex(10)]
        HRESULT get_FirstElement([NativeTypeName("long *")] int* FirstElement);
        [VtblIndex(11)]
        HRESULT get_NumberOfElements([NativeTypeName("long *")] int* NumberOfElements);
        [VtblIndex(12)]
        HRESULT get_EngineConfidence(float* Confidence);
        [VtblIndex(13)]
        HRESULT get_Confidence(SpeechEngineConfidence* Confidence);
        [VtblIndex(14)]
        HRESULT get_Parent(ISpeechPhraseProperty** ParentProperty);
        [VtblIndex(15)]
        HRESULT get_Children(ISpeechPhraseProperties** Children);
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
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_Name;
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_Id;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_Value;
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_FirstElement;
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_NumberOfElements;
        [NativeTypeName("HRESULT (float *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> get_EngineConfidence;
        [NativeTypeName("HRESULT (SpeechEngineConfidence *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SpeechEngineConfidence*, int> get_Confidence;
        [NativeTypeName("HRESULT (ISpeechPhraseProperty **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISpeechPhraseProperty**, int> get_Parent;
        [NativeTypeName("HRESULT (ISpeechPhraseProperties **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISpeechPhraseProperties**, int> get_Children;
    }
}