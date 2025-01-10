// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/StructuredQueryCondition.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("0FC988D4-C935-4B97-A973-46282EA175C8")]
[NativeTypeName("struct ICondition : IPersistStream")]
[NativeInheritance("IPersistStream")]
public unsafe partial struct ICondition : ICondition.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICondition));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ICondition, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ICondition, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICondition, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetClassID([NativeTypeName("CLSID *")] Guid* pClassID)
    {
        return ((delegate* unmanaged<ICondition, Guid*, int>)((*lpVtbl)[3]))(this, pClassID);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT IsDirty()
    {
        return ((delegate* unmanaged<ICondition, int>)((*lpVtbl)[4]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Load(IStream pStm)
    {
        return ((delegate* unmanaged<ICondition, IStream, int>)((*lpVtbl)[5]))(this, pStm);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Save(IStream pStm, BOOL fClearDirty)
    {
        return ((delegate* unmanaged<ICondition, IStream, BOOL, int>)((*lpVtbl)[6]))(
            this,
            pStm,
            fClearDirty
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetSizeMax(ULARGE_INTEGER* pcbSize)
    {
        return ((delegate* unmanaged<ICondition, ULARGE_INTEGER*, int>)((*lpVtbl)[7]))(
            this,
            pcbSize
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetConditionType(CONDITION_TYPE* pNodeType)
    {
        return ((delegate* unmanaged<ICondition, CONDITION_TYPE*, int>)((*lpVtbl)[8]))(
            this,
            pNodeType
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetSubConditions([NativeTypeName("const IID &")] Guid* riid, void** ppv)
    {
        return ((delegate* unmanaged<ICondition, Guid*, void**, int>)((*lpVtbl)[9]))(
            this,
            riid,
            ppv
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetComparisonInfo(
        [NativeTypeName("LPWSTR *")] ushort** ppszPropertyName,
        CONDITION_OPERATION* pcop,
        PROPVARIANT* ppropvar
    )
    {
        return (
            (delegate* unmanaged<ICondition, ushort**, CONDITION_OPERATION*, PROPVARIANT*, int>)(
                (*lpVtbl)[10]
            )
        )(this, ppszPropertyName, pcop, ppropvar);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetValueType([NativeTypeName("LPWSTR *")] ushort** ppszValueTypeName)
    {
        return ((delegate* unmanaged<ICondition, ushort**, int>)((*lpVtbl)[11]))(
            this,
            ppszValueTypeName
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetValueNormalization([NativeTypeName("LPWSTR *")] ushort** ppszNormalization)
    {
        return ((delegate* unmanaged<ICondition, ushort**, int>)((*lpVtbl)[12]))(
            this,
            ppszNormalization
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetInputTerms(
        IRichChunk* ppPropertyTerm,
        IRichChunk* ppOperationTerm,
        IRichChunk* ppValueTerm
    )
    {
        return (
            (delegate* unmanaged<ICondition, IRichChunk*, IRichChunk*, IRichChunk*, int>)(
                (*lpVtbl)[13]
            )
        )(this, ppPropertyTerm, ppOperationTerm, ppValueTerm);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT Clone(ICondition* ppc)
    {
        return ((delegate* unmanaged<ICondition, ICondition*, int>)((*lpVtbl)[14]))(this, ppc);
    }

    public interface Interface : IPersistStream.Interface
    {
        [VtblIndex(8)]
        HRESULT GetConditionType(CONDITION_TYPE* pNodeType);

        [VtblIndex(9)]
        HRESULT GetSubConditions([NativeTypeName("const IID &")] Guid* riid, void** ppv);

        [VtblIndex(10)]
        HRESULT GetComparisonInfo(
            [NativeTypeName("LPWSTR *")] ushort** ppszPropertyName,
            CONDITION_OPERATION* pcop,
            PROPVARIANT* ppropvar
        );

        [VtblIndex(11)]
        HRESULT GetValueType([NativeTypeName("LPWSTR *")] ushort** ppszValueTypeName);

        [VtblIndex(12)]
        HRESULT GetValueNormalization([NativeTypeName("LPWSTR *")] ushort** ppszNormalization);

        [VtblIndex(13)]
        HRESULT GetInputTerms(
            IRichChunk* ppPropertyTerm,
            IRichChunk* ppOperationTerm,
            IRichChunk* ppValueTerm
        );

        [VtblIndex(14)]
        HRESULT Clone(ICondition* ppc);
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

        [NativeTypeName("HRESULT (CLSID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> GetClassID;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> IsDirty;

        [NativeTypeName("HRESULT (IStream *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IStream, int> Load;

        [NativeTypeName("HRESULT (IStream *, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IStream, BOOL, int> Save;

        [NativeTypeName("HRESULT (ULARGE_INTEGER *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ULARGE_INTEGER*, int> GetSizeMax;

        [NativeTypeName("HRESULT (CONDITION_TYPE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, CONDITION_TYPE*, int> GetConditionType;

        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> GetSubConditions;

        [NativeTypeName(
            "HRESULT (LPWSTR *, CONDITION_OPERATION *, PROPVARIANT *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ushort**,
            CONDITION_OPERATION*,
            PROPVARIANT*,
            int> GetComparisonInfo;

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetValueType;

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetValueNormalization;

        [NativeTypeName(
            "HRESULT (IRichChunk **, IRichChunk **, IRichChunk **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IRichChunk*,
            IRichChunk*,
            IRichChunk*,
            int> GetInputTerms;

        [NativeTypeName("HRESULT (ICondition **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ICondition*, int> Clone;
    }

    /// <summary>Initializes a new instance of the <see cref = "ICondition"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ICondition(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IPersistStream"/> to <see cref = "ICondition"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IPersistStream"/> instance to be converted </param>
    public static explicit operator ICondition(Silk.NET.Windows.IPersistStream value)
    {
        return new ICondition(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICondition"/> to <see cref = "Silk.NET.Windows.IPersistStream"/>.</summary>
    /// <param name = "value">The <see cref = "ICondition"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IPersistStream(ICondition value)
    {
        return new Silk.NET.Windows.IPersistStream(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IPersist"/> to <see cref = "ICondition"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IPersist"/> instance to be converted </param>
    public static explicit operator ICondition(Silk.NET.Windows.IPersist value)
    {
        return new ICondition(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICondition"/> to <see cref = "Silk.NET.Windows.IPersist"/>.</summary>
    /// <param name = "value">The <see cref = "ICondition"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IPersist(ICondition value)
    {
        return new Silk.NET.Windows.IPersist(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ICondition"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ICondition(Silk.NET.Windows.IUnknown value)
    {
        return new ICondition(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICondition"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ICondition"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ICondition value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
