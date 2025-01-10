// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MLOperatorAuthor.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("EC893BB1-F938-427B-8488-C8DCF775F138")]
[NativeTypeName("struct IMLOperatorTypeInferenceContext : IMLOperatorAttributes")]
[NativeInheritance("IMLOperatorAttributes")]
public unsafe partial struct IMLOperatorTypeInferenceContext
    : IMLOperatorTypeInferenceContext.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMLOperatorTypeInferenceContext));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IMLOperatorTypeInferenceContext, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMLOperatorTypeInferenceContext, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMLOperatorTypeInferenceContext, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetAttributeElementCount(
        [NativeTypeName("const char *")] sbyte* name,
        MLOperatorAttributeType type,
        [NativeTypeName("uint32_t *")] uint* elementCount
    )
    {
        return (
            (delegate* unmanaged<
                IMLOperatorTypeInferenceContext,
                sbyte*,
                MLOperatorAttributeType,
                uint*,
                int>)((*lpVtbl)[3])
        )(this, name, type, elementCount);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetAttribute(
        [NativeTypeName("const char *")] sbyte* name,
        MLOperatorAttributeType type,
        [NativeTypeName("uint32_t")] uint elementCount,
        [NativeTypeName("size_t")] nuint elementByteSize,
        void* value
    )
    {
        return (
            (delegate* unmanaged<
                IMLOperatorTypeInferenceContext,
                sbyte*,
                MLOperatorAttributeType,
                uint,
                nuint,
                void*,
                int>)((*lpVtbl)[4])
        )(this, name, type, elementCount, elementByteSize, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetStringAttributeElementLength(
        [NativeTypeName("const char *")] sbyte* name,
        [NativeTypeName("uint32_t")] uint elementIndex,
        [NativeTypeName("uint32_t *")] uint* attributeElementByteSize
    )
    {
        return (
            (delegate* unmanaged<IMLOperatorTypeInferenceContext, sbyte*, uint, uint*, int>)(
                (*lpVtbl)[5]
            )
        )(this, name, elementIndex, attributeElementByteSize);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetStringAttributeElement(
        [NativeTypeName("const char *")] sbyte* name,
        [NativeTypeName("uint32_t")] uint elementIndex,
        [NativeTypeName("uint32_t")] uint attributeElementByteSize,
        [NativeTypeName("char *")] sbyte* attributeElement
    )
    {
        return (
            (delegate* unmanaged<IMLOperatorTypeInferenceContext, sbyte*, uint, uint, sbyte*, int>)(
                (*lpVtbl)[6]
            )
        )(this, name, elementIndex, attributeElementByteSize, attributeElement);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    [return: NativeTypeName("uint32_t")]
    public uint GetInputCount()
    {
        return ((delegate* unmanaged<IMLOperatorTypeInferenceContext, uint>)((*lpVtbl)[7]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    [return: NativeTypeName("uint32_t")]
    public uint GetOutputCount()
    {
        return ((delegate* unmanaged<IMLOperatorTypeInferenceContext, uint>)((*lpVtbl)[8]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public bool IsInputValid([NativeTypeName("uint32_t")] uint inputIndex)
    {
        return ((delegate* unmanaged<IMLOperatorTypeInferenceContext, uint, byte>)((*lpVtbl)[9]))(
                this,
                inputIndex
            ) != 0;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public bool IsOutputValid([NativeTypeName("uint32_t")] uint outputIndex)
    {
        return ((delegate* unmanaged<IMLOperatorTypeInferenceContext, uint, byte>)((*lpVtbl)[10]))(
                this,
                outputIndex
            ) != 0;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetInputEdgeDescription(
        [NativeTypeName("uint32_t")] uint inputIndex,
        MLOperatorEdgeDescription* edgeDescription
    )
    {
        return (
            (delegate* unmanaged<
                IMLOperatorTypeInferenceContext,
                uint,
                MLOperatorEdgeDescription*,
                int>)((*lpVtbl)[11])
        )(this, inputIndex, edgeDescription);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT SetOutputEdgeDescription(
        [NativeTypeName("uint32_t")] uint outputIndex,
        [NativeTypeName("const MLOperatorEdgeDescription *")]
            MLOperatorEdgeDescription* edgeDescription
    )
    {
        return (
            (delegate* unmanaged<
                IMLOperatorTypeInferenceContext,
                uint,
                MLOperatorEdgeDescription*,
                int>)((*lpVtbl)[12])
        )(this, outputIndex, edgeDescription);
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
        HRESULT GetInputEdgeDescription(
            [NativeTypeName("uint32_t")] uint inputIndex,
            MLOperatorEdgeDescription* edgeDescription
        );

        [VtblIndex(12)]
        HRESULT SetOutputEdgeDescription(
            [NativeTypeName("uint32_t")] uint outputIndex,
            [NativeTypeName("const MLOperatorEdgeDescription *")]
                MLOperatorEdgeDescription* edgeDescription
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

        [NativeTypeName(
            "HRESULT (const char *, MLOperatorAttributeType, uint32_t *) const noexcept __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            sbyte*,
            MLOperatorAttributeType,
            uint*,
            int> GetAttributeElementCount;

        [NativeTypeName(
            "HRESULT (const char *, MLOperatorAttributeType, uint32_t, size_t, void *) const noexcept __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            sbyte*,
            MLOperatorAttributeType,
            uint,
            nuint,
            void*,
            int> GetAttribute;

        [NativeTypeName(
            "HRESULT (const char *, uint32_t, uint32_t *) const noexcept __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            sbyte*,
            uint,
            uint*,
            int> GetStringAttributeElementLength;

        [NativeTypeName(
            "HRESULT (const char *, uint32_t, uint32_t, char *) const noexcept __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            sbyte*,
            uint,
            uint,
            sbyte*,
            int> GetStringAttributeElement;

        [NativeTypeName("uint32_t () const noexcept __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> GetInputCount;

        [NativeTypeName("uint32_t () const noexcept __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> GetOutputCount;

        [NativeTypeName("bool (uint32_t) const noexcept __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, byte> IsInputValid;

        [NativeTypeName("bool (uint32_t) const noexcept __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, byte> IsOutputValid;

        [NativeTypeName(
            "HRESULT (uint32_t, MLOperatorEdgeDescription *) const noexcept __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            MLOperatorEdgeDescription*,
            int> GetInputEdgeDescription;

        [NativeTypeName(
            "HRESULT (uint32_t, const MLOperatorEdgeDescription *) const noexcept __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            MLOperatorEdgeDescription*,
            int> SetOutputEdgeDescription;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMLOperatorTypeInferenceContext"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMLOperatorTypeInferenceContext(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IMLOperatorAttributes"/> to <see cref = "IMLOperatorTypeInferenceContext"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IMLOperatorAttributes"/> instance to be converted </param>
    public static explicit operator IMLOperatorTypeInferenceContext(
        Silk.NET.WinRT.IMLOperatorAttributes value
    )
    {
        return new IMLOperatorTypeInferenceContext(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMLOperatorTypeInferenceContext"/> to <see cref = "Silk.NET.WinRT.IMLOperatorAttributes"/>.</summary>
    /// <param name = "value">The <see cref = "IMLOperatorTypeInferenceContext"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IMLOperatorAttributes(
        IMLOperatorTypeInferenceContext value
    )
    {
        return new Silk.NET.WinRT.IMLOperatorAttributes(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMLOperatorTypeInferenceContext"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMLOperatorTypeInferenceContext(Silk.NET.Windows.IUnknown value)
    {
        return new IMLOperatorTypeInferenceContext(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMLOperatorTypeInferenceContext"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMLOperatorTypeInferenceContext"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMLOperatorTypeInferenceContext value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
