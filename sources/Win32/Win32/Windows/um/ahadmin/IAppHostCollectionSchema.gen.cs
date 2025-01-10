// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ahadmin.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("DE095DB1-5368-4D11-81F6-EFEF619B7BCF")]
[NativeTypeName("struct IAppHostCollectionSchema : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAppHostCollectionSchema
    : IAppHostCollectionSchema.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppHostCollectionSchema));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAppHostCollectionSchema, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IAppHostCollectionSchema, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppHostCollectionSchema, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT get_AddElementNames([NativeTypeName("BSTR *")] ushort** pbstrElementName)
    {
        return ((delegate* unmanaged<IAppHostCollectionSchema, ushort**, int>)((*lpVtbl)[3]))(
            this,
            pbstrElementName
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetAddElementSchema(
        [NativeTypeName("BSTR")] ushort* bstrElementName,
        IAppHostElementSchema* ppSchema
    )
    {
        return (
            (delegate* unmanaged<IAppHostCollectionSchema, ushort*, IAppHostElementSchema*, int>)(
                (*lpVtbl)[4]
            )
        )(this, bstrElementName, ppSchema);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT get_RemoveElementSchema(IAppHostElementSchema* ppSchema)
    {
        return (
            (delegate* unmanaged<IAppHostCollectionSchema, IAppHostElementSchema*, int>)(
                (*lpVtbl)[5]
            )
        )(this, ppSchema);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_ClearElementSchema(IAppHostElementSchema* ppSchema)
    {
        return (
            (delegate* unmanaged<IAppHostCollectionSchema, IAppHostElementSchema*, int>)(
                (*lpVtbl)[6]
            )
        )(this, ppSchema);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_IsMergeAppend([NativeTypeName("VARIANT_BOOL *")] short* pfIsMergeAppend)
    {
        return ((delegate* unmanaged<IAppHostCollectionSchema, short*, int>)((*lpVtbl)[7]))(
            this,
            pfIsMergeAppend
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetMetadata([NativeTypeName("BSTR")] ushort* bstrMetadataType, VARIANT* pValue)
    {
        return (
            (delegate* unmanaged<IAppHostCollectionSchema, ushort*, VARIANT*, int>)((*lpVtbl)[8])
        )(this, bstrMetadataType, pValue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_DoesAllowDuplicates(
        [NativeTypeName("VARIANT_BOOL *")] short* pfAllowDuplicates
    )
    {
        return ((delegate* unmanaged<IAppHostCollectionSchema, short*, int>)((*lpVtbl)[9]))(
            this,
            pfAllowDuplicates
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT get_AddElementNames([NativeTypeName("BSTR *")] ushort** pbstrElementName);

        [VtblIndex(4)]
        HRESULT GetAddElementSchema(
            [NativeTypeName("BSTR")] ushort* bstrElementName,
            IAppHostElementSchema* ppSchema
        );

        [VtblIndex(5)]
        HRESULT get_RemoveElementSchema(IAppHostElementSchema* ppSchema);

        [VtblIndex(6)]
        HRESULT get_ClearElementSchema(IAppHostElementSchema* ppSchema);

        [VtblIndex(7)]
        HRESULT get_IsMergeAppend([NativeTypeName("VARIANT_BOOL *")] short* pfIsMergeAppend);

        [VtblIndex(8)]
        HRESULT GetMetadata([NativeTypeName("BSTR")] ushort* bstrMetadataType, VARIANT* pValue);

        [VtblIndex(9)]
        HRESULT get_DoesAllowDuplicates(
            [NativeTypeName("VARIANT_BOOL *")] short* pfAllowDuplicates
        );
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
        public delegate* unmanaged<TSelf*, ushort**, int> get_AddElementNames;

        [NativeTypeName("HRESULT (BSTR, IAppHostElementSchema **) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            IAppHostElementSchema*,
            int> GetAddElementSchema;

        [NativeTypeName("HRESULT (IAppHostElementSchema **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IAppHostElementSchema*, int> get_RemoveElementSchema;

        [NativeTypeName("HRESULT (IAppHostElementSchema **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IAppHostElementSchema*, int> get_ClearElementSchema;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_IsMergeAppend;

        [NativeTypeName("HRESULT (BSTR, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, VARIANT*, int> GetMetadata;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_DoesAllowDuplicates;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAppHostCollectionSchema"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAppHostCollectionSchema(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAppHostCollectionSchema"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAppHostCollectionSchema(Silk.NET.Windows.IUnknown value)
    {
        return new IAppHostCollectionSchema(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAppHostCollectionSchema"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAppHostCollectionSchema"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAppHostCollectionSchema value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
