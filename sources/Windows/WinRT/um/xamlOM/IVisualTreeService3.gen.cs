// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/xamlOM.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;

namespace Silk.NET.WinRT;
/// <include file='IVisualTreeService3.xml' path='doc/member[@name="IVisualTreeService3"]/*'/>
[Guid("0E79C6E0-85A0-4BE8-B41A-655CF1FD19BD")]
[NativeTypeName("struct IVisualTreeService3 : IVisualTreeService2")]
[NativeInheritance("IVisualTreeService2")]
[SupportedOSPlatform("windows10.0.15063.0")]
public unsafe partial struct IVisualTreeService3 : IVisualTreeService3.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IVisualTreeService3));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IVisualTreeService3*, Guid*, void**, int> )(lpVtbl[0]))((IVisualTreeService3*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IVisualTreeService3*, uint> )(lpVtbl[1]))((IVisualTreeService3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IVisualTreeService3*, uint> )(lpVtbl[2]))((IVisualTreeService3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IVisualTreeService.AdviseVisualTreeChange"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT AdviseVisualTreeChange(IVisualTreeServiceCallback* pCallback)
    {
        return ((delegate* unmanaged<IVisualTreeService3*, IVisualTreeServiceCallback*, int> )(lpVtbl[3]))((IVisualTreeService3*)Unsafe.AsPointer(ref this), pCallback);
    }

    /// <inheritdoc cref = "IVisualTreeService.UnadviseVisualTreeChange"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT UnadviseVisualTreeChange(IVisualTreeServiceCallback* pCallback)
    {
        return ((delegate* unmanaged<IVisualTreeService3*, IVisualTreeServiceCallback*, int> )(lpVtbl[4]))((IVisualTreeService3*)Unsafe.AsPointer(ref this), pCallback);
    }

    /// <inheritdoc cref = "IVisualTreeService.GetEnums"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetEnums([NativeTypeName("unsigned int *")] uint* pCount, EnumType** ppEnums)
    {
        return ((delegate* unmanaged<IVisualTreeService3*, uint*, EnumType**, int> )(lpVtbl[5]))((IVisualTreeService3*)Unsafe.AsPointer(ref this), pCount, ppEnums);
    }

    /// <inheritdoc cref = "IVisualTreeService.CreateInstance"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateInstance([NativeTypeName("BSTR")] ushort* typeName, [NativeTypeName("BSTR")] ushort* value, InstanceHandle* pInstanceHandle)
    {
        return ((delegate* unmanaged<IVisualTreeService3*, ushort*, ushort*, InstanceHandle*, int> )(lpVtbl[6]))((IVisualTreeService3*)Unsafe.AsPointer(ref this), typeName, value, pInstanceHandle);
    }

    /// <inheritdoc cref = "IVisualTreeService.GetPropertyValuesChain"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetPropertyValuesChain(InstanceHandle instanceHandle, [NativeTypeName("unsigned int *")] uint* pSourceCount, PropertyChainSource** ppPropertySources, [NativeTypeName("unsigned int *")] uint* pPropertyCount, PropertyChainValue** ppPropertyValues)
    {
        return ((delegate* unmanaged<IVisualTreeService3*, InstanceHandle, uint*, PropertyChainSource**, uint*, PropertyChainValue**, int> )(lpVtbl[7]))((IVisualTreeService3*)Unsafe.AsPointer(ref this), instanceHandle, pSourceCount, ppPropertySources, pPropertyCount, ppPropertyValues);
    }

    /// <inheritdoc cref = "IVisualTreeService.SetProperty"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetProperty(InstanceHandle instanceHandle, InstanceHandle value, [NativeTypeName("unsigned int")] uint propertyIndex)
    {
        return ((delegate* unmanaged<IVisualTreeService3*, InstanceHandle, InstanceHandle, uint, int> )(lpVtbl[8]))((IVisualTreeService3*)Unsafe.AsPointer(ref this), instanceHandle, value, propertyIndex);
    }

    /// <inheritdoc cref = "IVisualTreeService.ClearProperty"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT ClearProperty(InstanceHandle instanceHandle, [NativeTypeName("unsigned int")] uint propertyIndex)
    {
        return ((delegate* unmanaged<IVisualTreeService3*, InstanceHandle, uint, int> )(lpVtbl[9]))((IVisualTreeService3*)Unsafe.AsPointer(ref this), instanceHandle, propertyIndex);
    }

    /// <inheritdoc cref = "IVisualTreeService.GetCollectionCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetCollectionCount(InstanceHandle instanceHandle, [NativeTypeName("unsigned int *")] uint* pCollectionSize)
    {
        return ((delegate* unmanaged<IVisualTreeService3*, InstanceHandle, uint*, int> )(lpVtbl[10]))((IVisualTreeService3*)Unsafe.AsPointer(ref this), instanceHandle, pCollectionSize);
    }

    /// <inheritdoc cref = "IVisualTreeService.GetCollectionElements"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetCollectionElements(InstanceHandle instanceHandle, [NativeTypeName("unsigned int")] uint startIndex, [NativeTypeName("unsigned int *")] uint* pElementCount, CollectionElementValue** ppElementValues)
    {
        return ((delegate* unmanaged<IVisualTreeService3*, InstanceHandle, uint, uint*, CollectionElementValue**, int> )(lpVtbl[11]))((IVisualTreeService3*)Unsafe.AsPointer(ref this), instanceHandle, startIndex, pElementCount, ppElementValues);
    }

    /// <inheritdoc cref = "IVisualTreeService.AddChild"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT AddChild(InstanceHandle parent, InstanceHandle child, [NativeTypeName("unsigned int")] uint index)
    {
        return ((delegate* unmanaged<IVisualTreeService3*, InstanceHandle, InstanceHandle, uint, int> )(lpVtbl[12]))((IVisualTreeService3*)Unsafe.AsPointer(ref this), parent, child, index);
    }

    /// <inheritdoc cref = "IVisualTreeService.RemoveChild"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT RemoveChild(InstanceHandle parent, [NativeTypeName("unsigned int")] uint index)
    {
        return ((delegate* unmanaged<IVisualTreeService3*, InstanceHandle, uint, int> )(lpVtbl[13]))((IVisualTreeService3*)Unsafe.AsPointer(ref this), parent, index);
    }

    /// <inheritdoc cref = "IVisualTreeService.ClearChildren"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT ClearChildren(InstanceHandle parent)
    {
        return ((delegate* unmanaged<IVisualTreeService3*, InstanceHandle, int> )(lpVtbl[14]))((IVisualTreeService3*)Unsafe.AsPointer(ref this), parent);
    }

    /// <inheritdoc cref = "IVisualTreeService2.GetPropertyIndex"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetPropertyIndex(InstanceHandle @object, [NativeTypeName("LPCWSTR")] ushort* propertyName, [NativeTypeName("unsigned int *")] uint* pPropertyIndex)
    {
        return ((delegate* unmanaged<IVisualTreeService3*, InstanceHandle, ushort*, uint*, int> )(lpVtbl[15]))((IVisualTreeService3*)Unsafe.AsPointer(ref this), @object, propertyName, pPropertyIndex);
    }

    /// <inheritdoc cref = "IVisualTreeService2.GetProperty"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT GetProperty(InstanceHandle @object, [NativeTypeName("unsigned int")] uint propertyIndex, InstanceHandle* pValue)
    {
        return ((delegate* unmanaged<IVisualTreeService3*, InstanceHandle, uint, InstanceHandle*, int> )(lpVtbl[16]))((IVisualTreeService3*)Unsafe.AsPointer(ref this), @object, propertyIndex, pValue);
    }

    /// <inheritdoc cref = "IVisualTreeService2.ReplaceResource"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT ReplaceResource(InstanceHandle resourceDictionary, InstanceHandle key, InstanceHandle newValue)
    {
        return ((delegate* unmanaged<IVisualTreeService3*, InstanceHandle, InstanceHandle, InstanceHandle, int> )(lpVtbl[17]))((IVisualTreeService3*)Unsafe.AsPointer(ref this), resourceDictionary, key, newValue);
    }

    /// <inheritdoc cref = "IVisualTreeService2.RenderTargetBitmap"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT RenderTargetBitmap(InstanceHandle handle, RenderTargetBitmapOptions options, [NativeTypeName("unsigned int")] uint maxPixelWidth, [NativeTypeName("unsigned int")] uint maxPixelHeight, IBitmapData** ppBitmapData)
    {
        return ((delegate* unmanaged<IVisualTreeService3*, InstanceHandle, RenderTargetBitmapOptions, uint, uint, IBitmapData**, int> )(lpVtbl[18]))((IVisualTreeService3*)Unsafe.AsPointer(ref this), handle, options, maxPixelWidth, maxPixelHeight, ppBitmapData);
    }

    /// <include file='IVisualTreeService3.xml' path='doc/member[@name="IVisualTreeService3.ResolveResource"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT ResolveResource(InstanceHandle resourceContext, [NativeTypeName("LPCWSTR")] ushort* resourceName, ResourceType resourceType, [NativeTypeName("unsigned int")] uint propertyIndex)
    {
        return ((delegate* unmanaged<IVisualTreeService3*, InstanceHandle, ushort*, ResourceType, uint, int> )(lpVtbl[19]))((IVisualTreeService3*)Unsafe.AsPointer(ref this), resourceContext, resourceName, resourceType, propertyIndex);
    }

    /// <include file='IVisualTreeService3.xml' path='doc/member[@name="IVisualTreeService3.GetDictionaryItem"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT GetDictionaryItem(InstanceHandle dictionaryHandle, [NativeTypeName("LPCWSTR")] ushort* resourceName, BOOL resourceIsImplicitStyle, InstanceHandle* resourceHandle)
    {
        return ((delegate* unmanaged<IVisualTreeService3*, InstanceHandle, ushort*, BOOL, InstanceHandle*, int> )(lpVtbl[20]))((IVisualTreeService3*)Unsafe.AsPointer(ref this), dictionaryHandle, resourceName, resourceIsImplicitStyle, resourceHandle);
    }

    /// <include file='IVisualTreeService3.xml' path='doc/member[@name="IVisualTreeService3.AddDictionaryItem"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT AddDictionaryItem(InstanceHandle dictionaryHandle, InstanceHandle resourceKey, InstanceHandle resourceHandle)
    {
        return ((delegate* unmanaged<IVisualTreeService3*, InstanceHandle, InstanceHandle, InstanceHandle, int> )(lpVtbl[21]))((IVisualTreeService3*)Unsafe.AsPointer(ref this), dictionaryHandle, resourceKey, resourceHandle);
    }

    /// <include file='IVisualTreeService3.xml' path='doc/member[@name="IVisualTreeService3.RemoveDictionaryItem"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT RemoveDictionaryItem(InstanceHandle dictionaryHandle, InstanceHandle resourceKey)
    {
        return ((delegate* unmanaged<IVisualTreeService3*, InstanceHandle, InstanceHandle, int> )(lpVtbl[22]))((IVisualTreeService3*)Unsafe.AsPointer(ref this), dictionaryHandle, resourceKey);
    }

    public interface Interface : IVisualTreeService2.Interface
    {
        [VtblIndex(19)]
        HRESULT ResolveResource(InstanceHandle resourceContext, [NativeTypeName("LPCWSTR")] ushort* resourceName, ResourceType resourceType, [NativeTypeName("unsigned int")] uint propertyIndex);
        [VtblIndex(20)]
        HRESULT GetDictionaryItem(InstanceHandle dictionaryHandle, [NativeTypeName("LPCWSTR")] ushort* resourceName, BOOL resourceIsImplicitStyle, InstanceHandle* resourceHandle);
        [VtblIndex(21)]
        HRESULT AddDictionaryItem(InstanceHandle dictionaryHandle, InstanceHandle resourceKey, InstanceHandle resourceHandle);
        [VtblIndex(22)]
        HRESULT RemoveDictionaryItem(InstanceHandle dictionaryHandle, InstanceHandle resourceKey);
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
        public delegate* unmanaged<TSelf*, IVisualTreeServiceCallback*, int> AdviseVisualTreeChange;
        [NativeTypeName("HRESULT (IVisualTreeServiceCallback *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IVisualTreeServiceCallback*, int> UnadviseVisualTreeChange;
        [NativeTypeName("HRESULT (unsigned int *, EnumType **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, EnumType**, int> GetEnums;
        [NativeTypeName("HRESULT (BSTR, BSTR, InstanceHandle *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, InstanceHandle*, int> CreateInstance;
        [NativeTypeName("HRESULT (InstanceHandle, unsigned int *, PropertyChainSource **, unsigned int *, PropertyChainValue **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, InstanceHandle, uint*, PropertyChainSource**, uint*, PropertyChainValue**, int> GetPropertyValuesChain;
        [NativeTypeName("HRESULT (InstanceHandle, InstanceHandle, unsigned int) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, InstanceHandle, InstanceHandle, uint, int> SetProperty;
        [NativeTypeName("HRESULT (InstanceHandle, unsigned int) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, InstanceHandle, uint, int> ClearProperty;
        [NativeTypeName("HRESULT (InstanceHandle, unsigned int *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, InstanceHandle, uint*, int> GetCollectionCount;
        [NativeTypeName("HRESULT (InstanceHandle, unsigned int, unsigned int *, CollectionElementValue **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, InstanceHandle, uint, uint*, CollectionElementValue**, int> GetCollectionElements;
        [NativeTypeName("HRESULT (InstanceHandle, InstanceHandle, unsigned int) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, InstanceHandle, InstanceHandle, uint, int> AddChild;
        [NativeTypeName("HRESULT (InstanceHandle, unsigned int) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, InstanceHandle, uint, int> RemoveChild;
        [NativeTypeName("HRESULT (InstanceHandle) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, InstanceHandle, int> ClearChildren;
        [NativeTypeName("HRESULT (InstanceHandle, LPCWSTR, unsigned int *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, InstanceHandle, ushort*, uint*, int> GetPropertyIndex;
        [NativeTypeName("HRESULT (InstanceHandle, unsigned int, InstanceHandle *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, InstanceHandle, uint, InstanceHandle*, int> GetProperty;
        [NativeTypeName("HRESULT (InstanceHandle, InstanceHandle, InstanceHandle) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, InstanceHandle, InstanceHandle, InstanceHandle, int> ReplaceResource;
        [NativeTypeName("HRESULT (InstanceHandle, RenderTargetBitmapOptions, unsigned int, unsigned int, IBitmapData **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, InstanceHandle, RenderTargetBitmapOptions, uint, uint, IBitmapData**, int> RenderTargetBitmap;
        [NativeTypeName("HRESULT (InstanceHandle, LPCWSTR, ResourceType, unsigned int) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, InstanceHandle, ushort*, ResourceType, uint, int> ResolveResource;
        [NativeTypeName("HRESULT (InstanceHandle, LPCWSTR, BOOL, InstanceHandle *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, InstanceHandle, ushort*, BOOL, InstanceHandle*, int> GetDictionaryItem;
        [NativeTypeName("HRESULT (InstanceHandle, InstanceHandle, InstanceHandle) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, InstanceHandle, InstanceHandle, InstanceHandle, int> AddDictionaryItem;
        [NativeTypeName("HRESULT (InstanceHandle, InstanceHandle) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, InstanceHandle, InstanceHandle, int> RemoveDictionaryItem;
    }
}