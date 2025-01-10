// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ahadmin.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("EF13D885-642C-4709-99EC-B89561C6BC69")]
[NativeTypeName("struct IAppHostElementSchema : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAppHostElementSchema : IAppHostElementSchema.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppHostElementSchema));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAppHostElementSchema, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IAppHostElementSchema, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppHostElementSchema, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT get_Name([NativeTypeName("BSTR *")] ushort** pbstrName)
    {
        return ((delegate* unmanaged<IAppHostElementSchema, ushort**, int>)((*lpVtbl)[3]))(
            this,
            pbstrName
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT get_DoesAllowUnschematizedProperties(
        [NativeTypeName("VARIANT_BOOL *")] short* pfAllowUnschematized
    )
    {
        return ((delegate* unmanaged<IAppHostElementSchema, short*, int>)((*lpVtbl)[4]))(
            this,
            pfAllowUnschematized
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetMetadata([NativeTypeName("BSTR")] ushort* bstrMetadataType, VARIANT* pValue)
    {
        return ((delegate* unmanaged<IAppHostElementSchema, ushort*, VARIANT*, int>)((*lpVtbl)[5]))(
            this,
            bstrMetadataType,
            pValue
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_CollectionSchema(IAppHostCollectionSchema* ppCollectionSchema)
    {
        return (
            (delegate* unmanaged<IAppHostElementSchema, IAppHostCollectionSchema*, int>)(
                (*lpVtbl)[6]
            )
        )(this, ppCollectionSchema);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_ChildElementSchemas(IAppHostElementSchemaCollection* ppChildSchemas)
    {
        return (
            (delegate* unmanaged<IAppHostElementSchema, IAppHostElementSchemaCollection*, int>)(
                (*lpVtbl)[7]
            )
        )(this, ppChildSchemas);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_PropertySchemas(IAppHostPropertySchemaCollection* ppPropertySchemas)
    {
        return (
            (delegate* unmanaged<IAppHostElementSchema, IAppHostPropertySchemaCollection*, int>)(
                (*lpVtbl)[8]
            )
        )(this, ppPropertySchemas);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_IsCollectionDefault(
        [NativeTypeName("VARIANT_BOOL *")] short* pfIsCollectionDefault
    )
    {
        return ((delegate* unmanaged<IAppHostElementSchema, short*, int>)((*lpVtbl)[9]))(
            this,
            pfIsCollectionDefault
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT get_Name([NativeTypeName("BSTR *")] ushort** pbstrName);

        [VtblIndex(4)]
        HRESULT get_DoesAllowUnschematizedProperties(
            [NativeTypeName("VARIANT_BOOL *")] short* pfAllowUnschematized
        );

        [VtblIndex(5)]
        HRESULT GetMetadata([NativeTypeName("BSTR")] ushort* bstrMetadataType, VARIANT* pValue);

        [VtblIndex(6)]
        HRESULT get_CollectionSchema(IAppHostCollectionSchema* ppCollectionSchema);

        [VtblIndex(7)]
        HRESULT get_ChildElementSchemas(IAppHostElementSchemaCollection* ppChildSchemas);

        [VtblIndex(8)]
        HRESULT get_PropertySchemas(IAppHostPropertySchemaCollection* ppPropertySchemas);

        [VtblIndex(9)]
        HRESULT get_IsCollectionDefault(
            [NativeTypeName("VARIANT_BOOL *")] short* pfIsCollectionDefault
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
        public delegate* unmanaged<TSelf*, ushort**, int> get_Name;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_DoesAllowUnschematizedProperties;

        [NativeTypeName("HRESULT (BSTR, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, VARIANT*, int> GetMetadata;

        [NativeTypeName("HRESULT (IAppHostCollectionSchema **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IAppHostCollectionSchema*, int> get_CollectionSchema;

        [NativeTypeName("HRESULT (IAppHostElementSchemaCollection **) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            IAppHostElementSchemaCollection*,
            int> get_ChildElementSchemas;

        [NativeTypeName("HRESULT (IAppHostPropertySchemaCollection **) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            IAppHostPropertySchemaCollection*,
            int> get_PropertySchemas;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_IsCollectionDefault;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAppHostElementSchema"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAppHostElementSchema(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAppHostElementSchema"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAppHostElementSchema(Silk.NET.Windows.IUnknown value)
    {
        return new IAppHostElementSchema(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAppHostElementSchema"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAppHostElementSchema"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAppHostElementSchema value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
