// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MLOperatorAuthor.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;
/// <include file='IMLOperatorTypeInferenceContext.xml' path='doc/member[@name="IMLOperatorTypeInferenceContext"]/*'/>
[Guid("EC893BB1-F938-427B-8488-C8DCF775F138")]
[NativeTypeName("struct IMLOperatorTypeInferenceContext : IMLOperatorAttributes")]
[NativeInheritance("IMLOperatorAttributes")]
public unsafe partial struct IMLOperatorTypeInferenceContext : IMLOperatorTypeInferenceContext.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMLOperatorTypeInferenceContext));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMLOperatorTypeInferenceContext*, Guid*, void**, int> )(lpVtbl[0]))((IMLOperatorTypeInferenceContext*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMLOperatorTypeInferenceContext*, uint> )(lpVtbl[1]))((IMLOperatorTypeInferenceContext*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMLOperatorTypeInferenceContext*, uint> )(lpVtbl[2]))((IMLOperatorTypeInferenceContext*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IMLOperatorAttributes.GetAttributeElementCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetAttributeElementCount([NativeTypeName("const char *")] sbyte* name, MLOperatorAttributeType type, [NativeTypeName("uint32_t *")] uint* elementCount)
    {
        return ((delegate* unmanaged<IMLOperatorTypeInferenceContext*, sbyte*, MLOperatorAttributeType, uint*, int> )(lpVtbl[3]))((IMLOperatorTypeInferenceContext*)Unsafe.AsPointer(ref this), name, type, elementCount);
    }

    /// <inheritdoc cref = "IMLOperatorAttributes.GetAttribute"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetAttribute([NativeTypeName("const char *")] sbyte* name, MLOperatorAttributeType type, [NativeTypeName("uint32_t")] uint elementCount, [NativeTypeName("size_t")] nuint elementByteSize, void* value)
    {
        return ((delegate* unmanaged<IMLOperatorTypeInferenceContext*, sbyte*, MLOperatorAttributeType, uint, nuint, void*, int> )(lpVtbl[4]))((IMLOperatorTypeInferenceContext*)Unsafe.AsPointer(ref this), name, type, elementCount, elementByteSize, value);
    }

    /// <inheritdoc cref = "IMLOperatorAttributes.GetStringAttributeElementLength"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetStringAttributeElementLength([NativeTypeName("const char *")] sbyte* name, [NativeTypeName("uint32_t")] uint elementIndex, [NativeTypeName("uint32_t *")] uint* attributeElementByteSize)
    {
        return ((delegate* unmanaged<IMLOperatorTypeInferenceContext*, sbyte*, uint, uint*, int> )(lpVtbl[5]))((IMLOperatorTypeInferenceContext*)Unsafe.AsPointer(ref this), name, elementIndex, attributeElementByteSize);
    }

    /// <inheritdoc cref = "IMLOperatorAttributes.GetStringAttributeElement"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetStringAttributeElement([NativeTypeName("const char *")] sbyte* name, [NativeTypeName("uint32_t")] uint elementIndex, [NativeTypeName("uint32_t")] uint attributeElementByteSize, [NativeTypeName("char *")] sbyte* attributeElement)
    {
        return ((delegate* unmanaged<IMLOperatorTypeInferenceContext*, sbyte*, uint, uint, sbyte*, int> )(lpVtbl[6]))((IMLOperatorTypeInferenceContext*)Unsafe.AsPointer(ref this), name, elementIndex, attributeElementByteSize, attributeElement);
    }

    /// <include file='IMLOperatorTypeInferenceContext.xml' path='doc/member[@name="IMLOperatorTypeInferenceContext.GetInputCount"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    [return: NativeTypeName("uint32_t")]
    public uint GetInputCount()
    {
        return ((delegate* unmanaged<IMLOperatorTypeInferenceContext*, uint> )(lpVtbl[7]))((IMLOperatorTypeInferenceContext*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMLOperatorTypeInferenceContext.xml' path='doc/member[@name="IMLOperatorTypeInferenceContext.GetOutputCount"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    [return: NativeTypeName("uint32_t")]
    public uint GetOutputCount()
    {
        return ((delegate* unmanaged<IMLOperatorTypeInferenceContext*, uint> )(lpVtbl[8]))((IMLOperatorTypeInferenceContext*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMLOperatorTypeInferenceContext.xml' path='doc/member[@name="IMLOperatorTypeInferenceContext.IsInputValid"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public bool IsInputValid([NativeTypeName("uint32_t")] uint inputIndex)
    {
        return ((delegate* unmanaged<IMLOperatorTypeInferenceContext*, uint, byte> )(lpVtbl[9]))((IMLOperatorTypeInferenceContext*)Unsafe.AsPointer(ref this), inputIndex) != 0;
    }

    /// <include file='IMLOperatorTypeInferenceContext.xml' path='doc/member[@name="IMLOperatorTypeInferenceContext.IsOutputValid"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public bool IsOutputValid([NativeTypeName("uint32_t")] uint outputIndex)
    {
        return ((delegate* unmanaged<IMLOperatorTypeInferenceContext*, uint, byte> )(lpVtbl[10]))((IMLOperatorTypeInferenceContext*)Unsafe.AsPointer(ref this), outputIndex) != 0;
    }

    /// <include file='IMLOperatorTypeInferenceContext.xml' path='doc/member[@name="IMLOperatorTypeInferenceContext.GetInputEdgeDescription"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetInputEdgeDescription([NativeTypeName("uint32_t")] uint inputIndex, MLOperatorEdgeDescription* edgeDescription)
    {
        return ((delegate* unmanaged<IMLOperatorTypeInferenceContext*, uint, MLOperatorEdgeDescription*, int> )(lpVtbl[11]))((IMLOperatorTypeInferenceContext*)Unsafe.AsPointer(ref this), inputIndex, edgeDescription);
    }

    /// <include file='IMLOperatorTypeInferenceContext.xml' path='doc/member[@name="IMLOperatorTypeInferenceContext.SetOutputEdgeDescription"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT SetOutputEdgeDescription([NativeTypeName("uint32_t")] uint outputIndex, [NativeTypeName("const MLOperatorEdgeDescription *")] MLOperatorEdgeDescription* edgeDescription)
    {
        return ((delegate* unmanaged<IMLOperatorTypeInferenceContext*, uint, MLOperatorEdgeDescription*, int> )(lpVtbl[12]))((IMLOperatorTypeInferenceContext*)Unsafe.AsPointer(ref this), outputIndex, edgeDescription);
    }

    public interface Interface : IMLOperatorAttributes.Interface
    {
        [VtblIndex(7)]
        [return: NativeTypeName("uint32_t")]
        uint GetInputCount();
        [VtblIndex(8)]
        [return: NativeTypeName("uint32_t")]
        uint GetOutputCount();
        [VtblIndex(9)]
        bool IsInputValid([NativeTypeName("uint32_t")] uint inputIndex);
        [VtblIndex(10)]
        bool IsOutputValid([NativeTypeName("uint32_t")] uint outputIndex);
        [VtblIndex(11)]
        HRESULT GetInputEdgeDescription([NativeTypeName("uint32_t")] uint inputIndex, MLOperatorEdgeDescription* edgeDescription);
        [VtblIndex(12)]
        HRESULT SetOutputEdgeDescription([NativeTypeName("uint32_t")] uint outputIndex, [NativeTypeName("const MLOperatorEdgeDescription *")] MLOperatorEdgeDescription* edgeDescription);
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
        [NativeTypeName("uint32_t () const noexcept __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> GetInputCount;
        [NativeTypeName("uint32_t () const noexcept __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> GetOutputCount;
        [NativeTypeName("bool (uint32_t) const noexcept __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, byte> IsInputValid;
        [NativeTypeName("bool (uint32_t) const noexcept __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, byte> IsOutputValid;
        [NativeTypeName("HRESULT (uint32_t, MLOperatorEdgeDescription *) const noexcept __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, MLOperatorEdgeDescription*, int> GetInputEdgeDescription;
        [NativeTypeName("HRESULT (uint32_t, const MLOperatorEdgeDescription *) const noexcept __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, MLOperatorEdgeDescription*, int> SetOutputEdgeDescription;
    }
}