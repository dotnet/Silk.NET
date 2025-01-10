// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ahadmin.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("8BED2C68-A5FB-4B28-8581-A0DC5267419F")]
[NativeTypeName("struct IAppHostPropertySchemaCollection : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAppHostPropertySchemaCollection
    : IAppHostPropertySchemaCollection.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppHostPropertySchemaCollection));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IAppHostPropertySchemaCollection, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAppHostPropertySchemaCollection, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppHostPropertySchemaCollection, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT get_Count([NativeTypeName("DWORD *")] uint* pcCount)
    {
        return ((delegate* unmanaged<IAppHostPropertySchemaCollection, uint*, int>)((*lpVtbl)[3]))(
            this,
            pcCount
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT get_Item(VARIANT cIndex, IAppHostPropertySchema* ppPropertySchema)
    {
        return (
            (delegate* unmanaged<
                IAppHostPropertySchemaCollection,
                VARIANT,
                IAppHostPropertySchema*,
                int>)((*lpVtbl)[4])
        )(this, cIndex, ppPropertySchema);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT get_Count([NativeTypeName("DWORD *")] uint* pcCount);

        [VtblIndex(4)]
        HRESULT get_Item(VARIANT cIndex, IAppHostPropertySchema* ppPropertySchema);
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

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_Count;

        [NativeTypeName("HRESULT (VARIANT, IAppHostPropertySchema **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, IAppHostPropertySchema*, int> get_Item;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAppHostPropertySchemaCollection"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAppHostPropertySchemaCollection(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAppHostPropertySchemaCollection"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAppHostPropertySchemaCollection(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IAppHostPropertySchemaCollection(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAppHostPropertySchemaCollection"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAppHostPropertySchemaCollection"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IAppHostPropertySchemaCollection value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
