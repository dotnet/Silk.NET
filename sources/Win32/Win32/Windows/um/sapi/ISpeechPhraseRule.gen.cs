// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("A7BFE112-A4A0-48D9-B602-C313843F6964")]
[NativeTypeName("struct ISpeechPhraseRule : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct ISpeechPhraseRule : ISpeechPhraseRule.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpeechPhraseRule));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISpeechPhraseRule, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ISpeechPhraseRule, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISpeechPhraseRule, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<ISpeechPhraseRule, uint*, int>)((*lpVtbl)[3]))(this, pctinfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo* ppTInfo)
    {
        return (
            (delegate* unmanaged<ISpeechPhraseRule, uint, uint, ITypeInfo*, int>)((*lpVtbl)[4])
        )(this, iTInfo, lcid, ppTInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames(
        [NativeTypeName("const IID &")] Guid* riid,
        [NativeTypeName("LPOLESTR *")] ushort** rgszNames,
        uint cNames,
        [NativeTypeName("LCID")] uint lcid,
        [NativeTypeName("DISPID *")] int* rgDispId
    )
    {
        return (
            (delegate* unmanaged<ISpeechPhraseRule, Guid*, ushort**, uint, uint, int*, int>)(
                (*lpVtbl)[5]
            )
        )(this, riid, rgszNames, cNames, lcid, rgDispId);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke(
        [NativeTypeName("DISPID")] int dispIdMember,
        [NativeTypeName("const IID &")] Guid* riid,
        [NativeTypeName("LCID")] uint lcid,
        [NativeTypeName("WORD")] ushort wFlags,
        DISPPARAMS* pDispParams,
        VARIANT* pVarResult,
        EXCEPINFO* pExcepInfo,
        uint* puArgErr
    )
    {
        return (
            (delegate* unmanaged<
                ISpeechPhraseRule,
                int,
                Guid*,
                uint,
                ushort,
                DISPPARAMS*,
                VARIANT*,
                EXCEPINFO*,
                uint*,
                int>)((*lpVtbl)[6])
        )(this, dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Name([NativeTypeName("BSTR *")] ushort** Name)
    {
        return ((delegate* unmanaged<ISpeechPhraseRule, ushort**, int>)((*lpVtbl)[7]))(this, Name);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Id([NativeTypeName("long *")] int* Id)
    {
        return ((delegate* unmanaged<ISpeechPhraseRule, int*, int>)((*lpVtbl)[8]))(this, Id);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_FirstElement([NativeTypeName("long *")] int* FirstElement)
    {
        return ((delegate* unmanaged<ISpeechPhraseRule, int*, int>)((*lpVtbl)[9]))(
            this,
            FirstElement
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_NumberOfElements([NativeTypeName("long *")] int* NumberOfElements)
    {
        return ((delegate* unmanaged<ISpeechPhraseRule, int*, int>)((*lpVtbl)[10]))(
            this,
            NumberOfElements
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_Parent(ISpeechPhraseRule* Parent)
    {
        return ((delegate* unmanaged<ISpeechPhraseRule, ISpeechPhraseRule*, int>)((*lpVtbl)[11]))(
            this,
            Parent
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_Children(ISpeechPhraseRules* Children)
    {
        return ((delegate* unmanaged<ISpeechPhraseRule, ISpeechPhraseRules*, int>)((*lpVtbl)[12]))(
            this,
            Children
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_Confidence(SpeechEngineConfidence* ActualConfidence)
    {
        return (
            (delegate* unmanaged<ISpeechPhraseRule, SpeechEngineConfidence*, int>)((*lpVtbl)[13])
        )(this, ActualConfidence);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_EngineConfidence(float* EngineConfidence)
    {
        return ((delegate* unmanaged<ISpeechPhraseRule, float*, int>)((*lpVtbl)[14]))(
            this,
            EngineConfidence
        );
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT get_Name([NativeTypeName("BSTR *")] ushort** Name);

        [VtblIndex(8)]
        HRESULT get_Id([NativeTypeName("long *")] int* Id);

        [VtblIndex(9)]
        HRESULT get_FirstElement([NativeTypeName("long *")] int* FirstElement);

        [VtblIndex(10)]
        HRESULT get_NumberOfElements([NativeTypeName("long *")] int* NumberOfElements);

        [VtblIndex(11)]
        HRESULT get_Parent(ISpeechPhraseRule* Parent);

        [VtblIndex(12)]
        HRESULT get_Children(ISpeechPhraseRules* Children);

        [VtblIndex(13)]
        HRESULT get_Confidence(SpeechEngineConfidence* ActualConfidence);

        [VtblIndex(14)]
        HRESULT get_EngineConfidence(float* EngineConfidence);
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
        public delegate* unmanaged<TSelf*, uint, uint, ITypeInfo*, int> GetTypeInfo;

        [NativeTypeName(
            "HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Guid*, ushort**, uint, uint, int*, int> GetIDsOfNames;

        [NativeTypeName(
            "HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            int,
            Guid*,
            uint,
            ushort,
            DISPPARAMS*,
            VARIANT*,
            EXCEPINFO*,
            uint*,
            int> Invoke;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_Name;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_Id;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_FirstElement;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_NumberOfElements;

        [NativeTypeName("HRESULT (ISpeechPhraseRule **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISpeechPhraseRule*, int> get_Parent;

        [NativeTypeName("HRESULT (ISpeechPhraseRules **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISpeechPhraseRules*, int> get_Children;

        [NativeTypeName("HRESULT (SpeechEngineConfidence *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SpeechEngineConfidence*, int> get_Confidence;

        [NativeTypeName("HRESULT (float *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> get_EngineConfidence;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISpeechPhraseRule"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISpeechPhraseRule(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IDispatch"/> to <see cref = "ISpeechPhraseRule"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IDispatch"/> instance to be converted </param>
    public static explicit operator ISpeechPhraseRule(Silk.NET.Windows.IDispatch value)
    {
        return new ISpeechPhraseRule(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpeechPhraseRule"/> to <see cref = "Silk.NET.Windows.IDispatch"/>.</summary>
    /// <param name = "value">The <see cref = "ISpeechPhraseRule"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IDispatch(ISpeechPhraseRule value)
    {
        return new Silk.NET.Windows.IDispatch(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISpeechPhraseRule"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISpeechPhraseRule(Silk.NET.Windows.IUnknown value)
    {
        return new ISpeechPhraseRule(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpeechPhraseRule"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISpeechPhraseRule"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISpeechPhraseRule value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
