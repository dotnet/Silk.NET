// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ahadmin.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("450386DB-7409-4667-935E-384DBBEE2A9E")]
[NativeTypeName("struct IAppHostPropertySchema : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAppHostPropertySchema : IAppHostPropertySchema.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppHostPropertySchema));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAppHostPropertySchema, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IAppHostPropertySchema, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppHostPropertySchema, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT get_Name([NativeTypeName("BSTR *")] ushort** pbstrName)
    {
        return ((delegate* unmanaged<IAppHostPropertySchema, ushort**, int>)((*lpVtbl)[3]))(
            this,
            pbstrName
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT get_Type([NativeTypeName("BSTR *")] ushort** pbstrType)
    {
        return ((delegate* unmanaged<IAppHostPropertySchema, ushort**, int>)((*lpVtbl)[4]))(
            this,
            pbstrType
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT get_DefaultValue(VARIANT* pDefaultValue)
    {
        return ((delegate* unmanaged<IAppHostPropertySchema, VARIANT*, int>)((*lpVtbl)[5]))(
            this,
            pDefaultValue
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_IsRequired([NativeTypeName("VARIANT_BOOL *")] short* pfIsRequired)
    {
        return ((delegate* unmanaged<IAppHostPropertySchema, short*, int>)((*lpVtbl)[6]))(
            this,
            pfIsRequired
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_IsUniqueKey([NativeTypeName("VARIANT_BOOL *")] short* pfIsUniqueKey)
    {
        return ((delegate* unmanaged<IAppHostPropertySchema, short*, int>)((*lpVtbl)[7]))(
            this,
            pfIsUniqueKey
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_IsCombinedKey([NativeTypeName("VARIANT_BOOL *")] short* pfIsCombinedKey)
    {
        return ((delegate* unmanaged<IAppHostPropertySchema, short*, int>)((*lpVtbl)[8]))(
            this,
            pfIsCombinedKey
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_IsExpanded([NativeTypeName("VARIANT_BOOL *")] short* pfIsExpanded)
    {
        return ((delegate* unmanaged<IAppHostPropertySchema, short*, int>)((*lpVtbl)[9]))(
            this,
            pfIsExpanded
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_ValidationType([NativeTypeName("BSTR *")] ushort** pbstrValidationType)
    {
        return ((delegate* unmanaged<IAppHostPropertySchema, ushort**, int>)((*lpVtbl)[10]))(
            this,
            pbstrValidationType
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_ValidationParameter(
        [NativeTypeName("BSTR *")] ushort** pbstrValidationParameter
    )
    {
        return ((delegate* unmanaged<IAppHostPropertySchema, ushort**, int>)((*lpVtbl)[11]))(
            this,
            pbstrValidationParameter
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetMetadata([NativeTypeName("BSTR")] ushort* bstrMetadataType, VARIANT* pValue)
    {
        return (
            (delegate* unmanaged<IAppHostPropertySchema, ushort*, VARIANT*, int>)((*lpVtbl)[12])
        )(this, bstrMetadataType, pValue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_IsCaseSensitive([NativeTypeName("VARIANT_BOOL *")] short* pfIsCaseSensitive)
    {
        return ((delegate* unmanaged<IAppHostPropertySchema, short*, int>)((*lpVtbl)[13]))(
            this,
            pfIsCaseSensitive
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_PossibleValues(IAppHostConstantValueCollection* ppValues)
    {
        return (
            (delegate* unmanaged<IAppHostPropertySchema, IAppHostConstantValueCollection*, int>)(
                (*lpVtbl)[14]
            )
        )(this, ppValues);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_DoesAllowInfinite([NativeTypeName("VARIANT_BOOL *")] short* pfAllowInfinite)
    {
        return ((delegate* unmanaged<IAppHostPropertySchema, short*, int>)((*lpVtbl)[15]))(
            this,
            pfAllowInfinite
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_IsEncrypted([NativeTypeName("VARIANT_BOOL *")] short* pfIsEncrypted)
    {
        return ((delegate* unmanaged<IAppHostPropertySchema, short*, int>)((*lpVtbl)[16]))(
            this,
            pfIsEncrypted
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_TimeSpanFormat([NativeTypeName("BSTR *")] ushort** pbstrTimeSpanFormat)
    {
        return ((delegate* unmanaged<IAppHostPropertySchema, ushort**, int>)((*lpVtbl)[17]))(
            this,
            pbstrTimeSpanFormat
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT get_Name([NativeTypeName("BSTR *")] ushort** pbstrName);

        [VtblIndex(4)]
        HRESULT get_Type([NativeTypeName("BSTR *")] ushort** pbstrType);

        [VtblIndex(5)]
        HRESULT get_DefaultValue(VARIANT* pDefaultValue);

        [VtblIndex(6)]
        HRESULT get_IsRequired([NativeTypeName("VARIANT_BOOL *")] short* pfIsRequired);

        [VtblIndex(7)]
        HRESULT get_IsUniqueKey([NativeTypeName("VARIANT_BOOL *")] short* pfIsUniqueKey);

        [VtblIndex(8)]
        HRESULT get_IsCombinedKey([NativeTypeName("VARIANT_BOOL *")] short* pfIsCombinedKey);

        [VtblIndex(9)]
        HRESULT get_IsExpanded([NativeTypeName("VARIANT_BOOL *")] short* pfIsExpanded);

        [VtblIndex(10)]
        HRESULT get_ValidationType([NativeTypeName("BSTR *")] ushort** pbstrValidationType);

        [VtblIndex(11)]
        HRESULT get_ValidationParameter(
            [NativeTypeName("BSTR *")] ushort** pbstrValidationParameter
        );

        [VtblIndex(12)]
        HRESULT GetMetadata([NativeTypeName("BSTR")] ushort* bstrMetadataType, VARIANT* pValue);

        [VtblIndex(13)]
        HRESULT get_IsCaseSensitive([NativeTypeName("VARIANT_BOOL *")] short* pfIsCaseSensitive);

        [VtblIndex(14)]
        HRESULT get_PossibleValues(IAppHostConstantValueCollection* ppValues);

        [VtblIndex(15)]
        HRESULT get_DoesAllowInfinite([NativeTypeName("VARIANT_BOOL *")] short* pfAllowInfinite);

        [VtblIndex(16)]
        HRESULT get_IsEncrypted([NativeTypeName("VARIANT_BOOL *")] short* pfIsEncrypted);

        [VtblIndex(17)]
        HRESULT get_TimeSpanFormat([NativeTypeName("BSTR *")] ushort** pbstrTimeSpanFormat);
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

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_Name;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_Type;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_DefaultValue;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_IsRequired;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_IsUniqueKey;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_IsCombinedKey;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_IsExpanded;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_ValidationType;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_ValidationParameter;

        [NativeTypeName("HRESULT (BSTR, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, VARIANT*, int> GetMetadata;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_IsCaseSensitive;

        [NativeTypeName("HRESULT (IAppHostConstantValueCollection **) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            IAppHostConstantValueCollection*,
            int> get_PossibleValues;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_DoesAllowInfinite;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_IsEncrypted;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_TimeSpanFormat;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAppHostPropertySchema"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAppHostPropertySchema(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAppHostPropertySchema"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAppHostPropertySchema(Silk.NET.Windows.IUnknown value)
    {
        return new IAppHostPropertySchema(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAppHostPropertySchema"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAppHostPropertySchema"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAppHostPropertySchema value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
