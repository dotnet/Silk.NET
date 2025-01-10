// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ahadmin.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("C8550BFF-5281-4B1E-AC34-99B6FA38464D")]
[NativeTypeName("struct IAppHostElementCollection : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAppHostElementCollection
    : IAppHostElementCollection.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppHostElementCollection));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAppHostElementCollection, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IAppHostElementCollection, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppHostElementCollection, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT get_Count([NativeTypeName("DWORD *")] uint* pcElementCount)
    {
        return ((delegate* unmanaged<IAppHostElementCollection, uint*, int>)((*lpVtbl)[3]))(
            this,
            pcElementCount
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT get_Item(VARIANT cIndex, IAppHostElement* ppElement)
    {
        return (
            (delegate* unmanaged<IAppHostElementCollection, VARIANT, IAppHostElement*, int>)(
                (*lpVtbl)[4]
            )
        )(this, cIndex, ppElement);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT AddElement(IAppHostElement pElement, int cPosition = -1)
    {
        return (
            (delegate* unmanaged<IAppHostElementCollection, IAppHostElement, int, int>)(
                (*lpVtbl)[5]
            )
        )(this, pElement, cPosition);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT DeleteElement(VARIANT cIndex)
    {
        return ((delegate* unmanaged<IAppHostElementCollection, VARIANT, int>)((*lpVtbl)[6]))(
            this,
            cIndex
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT Clear()
    {
        return ((delegate* unmanaged<IAppHostElementCollection, int>)((*lpVtbl)[7]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateNewElement(
        [NativeTypeName("BSTR")] ushort* bstrElementName,
        IAppHostElement* ppElement
    )
    {
        return (
            (delegate* unmanaged<IAppHostElementCollection, ushort*, IAppHostElement*, int>)(
                (*lpVtbl)[8]
            )
        )(this, bstrElementName, ppElement);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Schema(IAppHostCollectionSchema* ppSchema)
    {
        return (
            (delegate* unmanaged<IAppHostElementCollection, IAppHostCollectionSchema*, int>)(
                (*lpVtbl)[9]
            )
        )(this, ppSchema);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT get_Count([NativeTypeName("DWORD *")] uint* pcElementCount);

        [VtblIndex(4)]
        HRESULT get_Item(VARIANT cIndex, IAppHostElement* ppElement);

        [VtblIndex(5)]
        HRESULT AddElement(IAppHostElement pElement, int cPosition = -1);

        [VtblIndex(6)]
        HRESULT DeleteElement(VARIANT cIndex);

        [VtblIndex(7)]
        HRESULT Clear();

        [VtblIndex(8)]
        HRESULT CreateNewElement(
            [NativeTypeName("BSTR")] ushort* bstrElementName,
            IAppHostElement* ppElement
        );

        [VtblIndex(9)]
        HRESULT get_Schema(IAppHostCollectionSchema* ppSchema);
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

        [NativeTypeName("HRESULT (VARIANT, IAppHostElement **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, IAppHostElement*, int> get_Item;

        [NativeTypeName("HRESULT (IAppHostElement *, INT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IAppHostElement, int, int> AddElement;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> DeleteElement;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Clear;

        [NativeTypeName("HRESULT (BSTR, IAppHostElement **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, IAppHostElement*, int> CreateNewElement;

        [NativeTypeName("HRESULT (IAppHostCollectionSchema **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IAppHostCollectionSchema*, int> get_Schema;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAppHostElementCollection"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAppHostElementCollection(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAppHostElementCollection"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAppHostElementCollection(Silk.NET.Windows.IUnknown value)
    {
        return new IAppHostElementCollection(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAppHostElementCollection"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAppHostElementCollection"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAppHostElementCollection value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
