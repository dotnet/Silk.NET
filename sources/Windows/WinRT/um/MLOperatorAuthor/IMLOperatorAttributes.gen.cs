// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MLOperatorAuthor.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.WinRT;

/// <include file='IMLOperatorAttributes.xml' path='doc/member[@name="IMLOperatorAttributes"]/*' />
[Guid("4B1B1759-EC40-466C-AAB4-BEB5347FD24C")]
[NativeTypeName("struct IMLOperatorAttributes : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMLOperatorAttributes : IMLOperatorAttributes.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMLOperatorAttributes));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMLOperatorAttributes*, Guid*, void**, int>)(lpVtbl[0]))((IMLOperatorAttributes*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMLOperatorAttributes*, uint>)(lpVtbl[1]))((IMLOperatorAttributes*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMLOperatorAttributes*, uint>)(lpVtbl[2]))((IMLOperatorAttributes*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMLOperatorAttributes.xml' path='doc/member[@name="IMLOperatorAttributes.GetAttributeElementCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetAttributeElementCount([NativeTypeName("const char *")] sbyte* name, MLOperatorAttributeType type, [NativeTypeName("uint32_t *")] uint* elementCount)
    {
        return ((delegate* unmanaged<IMLOperatorAttributes*, sbyte*, MLOperatorAttributeType, uint*, int>)(lpVtbl[3]))((IMLOperatorAttributes*)Unsafe.AsPointer(ref this), name, type, elementCount);
    }

    /// <include file='IMLOperatorAttributes.xml' path='doc/member[@name="IMLOperatorAttributes.GetAttribute"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetAttribute([NativeTypeName("const char *")] sbyte* name, MLOperatorAttributeType type, [NativeTypeName("uint32_t")] uint elementCount, [NativeTypeName("size_t")] nuint elementByteSize, void* value)
    {
        return ((delegate* unmanaged<IMLOperatorAttributes*, sbyte*, MLOperatorAttributeType, uint, nuint, void*, int>)(lpVtbl[4]))((IMLOperatorAttributes*)Unsafe.AsPointer(ref this), name, type, elementCount, elementByteSize, value);
    }

    /// <include file='IMLOperatorAttributes.xml' path='doc/member[@name="IMLOperatorAttributes.GetStringAttributeElementLength"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetStringAttributeElementLength([NativeTypeName("const char *")] sbyte* name, [NativeTypeName("uint32_t")] uint elementIndex, [NativeTypeName("uint32_t *")] uint* attributeElementByteSize)
    {
        return ((delegate* unmanaged<IMLOperatorAttributes*, sbyte*, uint, uint*, int>)(lpVtbl[5]))((IMLOperatorAttributes*)Unsafe.AsPointer(ref this), name, elementIndex, attributeElementByteSize);
    }

    /// <include file='IMLOperatorAttributes.xml' path='doc/member[@name="IMLOperatorAttributes.GetStringAttributeElement"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetStringAttributeElement([NativeTypeName("const char *")] sbyte* name, [NativeTypeName("uint32_t")] uint elementIndex, [NativeTypeName("uint32_t")] uint attributeElementByteSize, [NativeTypeName("char *")] sbyte* attributeElement)
    {
        return ((delegate* unmanaged<IMLOperatorAttributes*, sbyte*, uint, uint, sbyte*, int>)(lpVtbl[6]))((IMLOperatorAttributes*)Unsafe.AsPointer(ref this), name, elementIndex, attributeElementByteSize, attributeElement);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetAttributeElementCount([NativeTypeName("const char *")] sbyte* name, MLOperatorAttributeType type, [NativeTypeName("uint32_t *")] uint* elementCount);

        [VtblIndex(4)]
        HRESULT GetAttribute([NativeTypeName("const char *")] sbyte* name, MLOperatorAttributeType type, [NativeTypeName("uint32_t")] uint elementCount, [NativeTypeName("size_t")] nuint elementByteSize, void* value);

        [VtblIndex(5)]
        HRESULT GetStringAttributeElementLength([NativeTypeName("const char *")] sbyte* name, [NativeTypeName("uint32_t")] uint elementIndex, [NativeTypeName("uint32_t *")] uint* attributeElementByteSize);

        [VtblIndex(6)]
        HRESULT GetStringAttributeElement([NativeTypeName("const char *")] sbyte* name, [NativeTypeName("uint32_t")] uint elementIndex, [NativeTypeName("uint32_t")] uint attributeElementByteSize, [NativeTypeName("char *")] sbyte* attributeElement);
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

        [NativeTypeName("HRESULT (const char *, MLOperatorAttributeType, uint32_t *) const noexcept __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, sbyte*, MLOperatorAttributeType, uint*, int> GetAttributeElementCount;

        [NativeTypeName("HRESULT (const char *, MLOperatorAttributeType, uint32_t, size_t, void *) const noexcept __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, sbyte*, MLOperatorAttributeType, uint, nuint, void*, int> GetAttribute;

        [NativeTypeName("HRESULT (const char *, uint32_t, uint32_t *) const noexcept __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, sbyte*, uint, uint*, int> GetStringAttributeElementLength;

        [NativeTypeName("HRESULT (const char *, uint32_t, uint32_t, char *) const noexcept __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, sbyte*, uint, uint, sbyte*, int> GetStringAttributeElement;
    }
}
