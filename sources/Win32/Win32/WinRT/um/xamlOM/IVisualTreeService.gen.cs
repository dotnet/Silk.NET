// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/xamlOM.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("A593B11A-D17F-48BB-8F66-83910731C8A5")]
[NativeTypeName("struct IVisualTreeService : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0")]
public unsafe partial struct IVisualTreeService : IVisualTreeService.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IVisualTreeService));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IVisualTreeService, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IVisualTreeService, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IVisualTreeService, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT AdviseVisualTreeChange(IVisualTreeServiceCallback pCallback)
    {
        return (
            (delegate* unmanaged<IVisualTreeService, IVisualTreeServiceCallback, int>)((*lpVtbl)[3])
        )(this, pCallback);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT UnadviseVisualTreeChange(IVisualTreeServiceCallback pCallback)
    {
        return (
            (delegate* unmanaged<IVisualTreeService, IVisualTreeServiceCallback, int>)((*lpVtbl)[4])
        )(this, pCallback);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetEnums([NativeTypeName("unsigned int *")] uint* pCount, EnumType** ppEnums)
    {
        return ((delegate* unmanaged<IVisualTreeService, uint*, EnumType**, int>)((*lpVtbl)[5]))(
            this,
            pCount,
            ppEnums
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateInstance(
        [NativeTypeName("BSTR")] ushort* typeName,
        [NativeTypeName("BSTR")] ushort* value,
        InstanceHandle* pInstanceHandle
    )
    {
        return (
            (delegate* unmanaged<IVisualTreeService, ushort*, ushort*, InstanceHandle*, int>)(
                (*lpVtbl)[6]
            )
        )(this, typeName, value, pInstanceHandle);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetPropertyValuesChain(
        InstanceHandle instanceHandle,
        [NativeTypeName("unsigned int *")] uint* pSourceCount,
        PropertyChainSource** ppPropertySources,
        [NativeTypeName("unsigned int *")] uint* pPropertyCount,
        PropertyChainValue** ppPropertyValues
    )
    {
        return (
            (delegate* unmanaged<
                IVisualTreeService,
                InstanceHandle,
                uint*,
                PropertyChainSource**,
                uint*,
                PropertyChainValue**,
                int>)((*lpVtbl)[7])
        )(this, instanceHandle, pSourceCount, ppPropertySources, pPropertyCount, ppPropertyValues);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetProperty(
        InstanceHandle instanceHandle,
        InstanceHandle value,
        [NativeTypeName("unsigned int")] uint propertyIndex
    )
    {
        return (
            (delegate* unmanaged<IVisualTreeService, InstanceHandle, InstanceHandle, uint, int>)(
                (*lpVtbl)[8]
            )
        )(this, instanceHandle, value, propertyIndex);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT ClearProperty(
        InstanceHandle instanceHandle,
        [NativeTypeName("unsigned int")] uint propertyIndex
    )
    {
        return ((delegate* unmanaged<IVisualTreeService, InstanceHandle, uint, int>)((*lpVtbl)[9]))(
            this,
            instanceHandle,
            propertyIndex
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetCollectionCount(
        InstanceHandle instanceHandle,
        [NativeTypeName("unsigned int *")] uint* pCollectionSize
    )
    {
        return (
            (delegate* unmanaged<IVisualTreeService, InstanceHandle, uint*, int>)((*lpVtbl)[10])
        )(this, instanceHandle, pCollectionSize);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetCollectionElements(
        InstanceHandle instanceHandle,
        [NativeTypeName("unsigned int")] uint startIndex,
        [NativeTypeName("unsigned int *")] uint* pElementCount,
        CollectionElementValue** ppElementValues
    )
    {
        return (
            (delegate* unmanaged<
                IVisualTreeService,
                InstanceHandle,
                uint,
                uint*,
                CollectionElementValue**,
                int>)((*lpVtbl)[11])
        )(this, instanceHandle, startIndex, pElementCount, ppElementValues);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT AddChild(
        InstanceHandle parent,
        InstanceHandle child,
        [NativeTypeName("unsigned int")] uint index
    )
    {
        return (
            (delegate* unmanaged<IVisualTreeService, InstanceHandle, InstanceHandle, uint, int>)(
                (*lpVtbl)[12]
            )
        )(this, parent, child, index);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT RemoveChild(InstanceHandle parent, [NativeTypeName("unsigned int")] uint index)
    {
        return (
            (delegate* unmanaged<IVisualTreeService, InstanceHandle, uint, int>)((*lpVtbl)[13])
        )(this, parent, index);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT ClearChildren(InstanceHandle parent)
    {
        return ((delegate* unmanaged<IVisualTreeService, InstanceHandle, int>)((*lpVtbl)[14]))(
            this,
            parent
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT AdviseVisualTreeChange(IVisualTreeServiceCallback pCallback);

        [VtblIndex(4)]
        HRESULT UnadviseVisualTreeChange(IVisualTreeServiceCallback pCallback);

        [VtblIndex(5)]
        HRESULT GetEnums([NativeTypeName("unsigned int *")] uint* pCount, EnumType** ppEnums);

        [VtblIndex(6)]
        HRESULT CreateInstance(
            [NativeTypeName("BSTR")] ushort* typeName,
            [NativeTypeName("BSTR")] ushort* value,
            InstanceHandle* pInstanceHandle
        );

        [VtblIndex(7)]
        HRESULT GetPropertyValuesChain(
            InstanceHandle instanceHandle,
            [NativeTypeName("unsigned int *")] uint* pSourceCount,
            PropertyChainSource** ppPropertySources,
            [NativeTypeName("unsigned int *")] uint* pPropertyCount,
            PropertyChainValue** ppPropertyValues
        );

        [VtblIndex(8)]
        HRESULT SetProperty(
            InstanceHandle instanceHandle,
            InstanceHandle value,
            [NativeTypeName("unsigned int")] uint propertyIndex
        );

        [VtblIndex(9)]
        HRESULT ClearProperty(
            InstanceHandle instanceHandle,
            [NativeTypeName("unsigned int")] uint propertyIndex
        );

        [VtblIndex(10)]
        HRESULT GetCollectionCount(
            InstanceHandle instanceHandle,
            [NativeTypeName("unsigned int *")] uint* pCollectionSize
        );

        [VtblIndex(11)]
        HRESULT GetCollectionElements(
            InstanceHandle instanceHandle,
            [NativeTypeName("unsigned int")] uint startIndex,
            [NativeTypeName("unsigned int *")] uint* pElementCount,
            CollectionElementValue** ppElementValues
        );

        [VtblIndex(12)]
        HRESULT AddChild(
            InstanceHandle parent,
            InstanceHandle child,
            [NativeTypeName("unsigned int")] uint index
        );

        [VtblIndex(13)]
        HRESULT RemoveChild(InstanceHandle parent, [NativeTypeName("unsigned int")] uint index);

        [VtblIndex(14)]
        HRESULT ClearChildren(InstanceHandle parent);
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

        [NativeTypeName("HRESULT (IVisualTreeServiceCallback *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IVisualTreeServiceCallback, int> AdviseVisualTreeChange;

        [NativeTypeName("HRESULT (IVisualTreeServiceCallback *) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            IVisualTreeServiceCallback,
            int> UnadviseVisualTreeChange;

        [NativeTypeName("HRESULT (unsigned int *, EnumType **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, EnumType**, int> GetEnums;

        [NativeTypeName("HRESULT (BSTR, BSTR, InstanceHandle *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, InstanceHandle*, int> CreateInstance;

        [NativeTypeName(
            "HRESULT (InstanceHandle, unsigned int *, PropertyChainSource **, unsigned int *, PropertyChainValue **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            InstanceHandle,
            uint*,
            PropertyChainSource**,
            uint*,
            PropertyChainValue**,
            int> GetPropertyValuesChain;

        [NativeTypeName(
            "HRESULT (InstanceHandle, InstanceHandle, unsigned int) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, InstanceHandle, InstanceHandle, uint, int> SetProperty;

        [NativeTypeName("HRESULT (InstanceHandle, unsigned int) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, InstanceHandle, uint, int> ClearProperty;

        [NativeTypeName("HRESULT (InstanceHandle, unsigned int *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, InstanceHandle, uint*, int> GetCollectionCount;

        [NativeTypeName(
            "HRESULT (InstanceHandle, unsigned int, unsigned int *, CollectionElementValue **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            InstanceHandle,
            uint,
            uint*,
            CollectionElementValue**,
            int> GetCollectionElements;

        [NativeTypeName(
            "HRESULT (InstanceHandle, InstanceHandle, unsigned int) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, InstanceHandle, InstanceHandle, uint, int> AddChild;

        [NativeTypeName("HRESULT (InstanceHandle, unsigned int) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, InstanceHandle, uint, int> RemoveChild;

        [NativeTypeName("HRESULT (InstanceHandle) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, InstanceHandle, int> ClearChildren;
    }

    /// <summary>Initializes a new instance of the <see cref = "IVisualTreeService"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IVisualTreeService(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IVisualTreeService"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IVisualTreeService(Silk.NET.Windows.IUnknown value)
    {
        return new IVisualTreeService(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IVisualTreeService"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IVisualTreeService"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IVisualTreeService value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
