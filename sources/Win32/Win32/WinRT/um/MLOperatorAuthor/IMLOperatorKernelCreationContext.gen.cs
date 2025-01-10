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

[Guid("5459B53D-A0FC-4665-ADDD-70171EF7E631")]
[NativeTypeName("struct IMLOperatorKernelCreationContext : IMLOperatorAttributes")]
[NativeInheritance("IMLOperatorAttributes")]
public unsafe partial struct IMLOperatorKernelCreationContext
    : IMLOperatorKernelCreationContext.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMLOperatorKernelCreationContext));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IMLOperatorKernelCreationContext, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMLOperatorKernelCreationContext, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMLOperatorKernelCreationContext, uint>)((*lpVtbl)[2]))(this);
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
                IMLOperatorKernelCreationContext,
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
                IMLOperatorKernelCreationContext,
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
            (delegate* unmanaged<IMLOperatorKernelCreationContext, sbyte*, uint, uint*, int>)(
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
            (delegate* unmanaged<
                IMLOperatorKernelCreationContext,
                sbyte*,
                uint,
                uint,
                sbyte*,
                int>)((*lpVtbl)[6])
        )(this, name, elementIndex, attributeElementByteSize, attributeElement);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    [return: NativeTypeName("uint32_t")]
    public uint GetInputCount()
    {
        return ((delegate* unmanaged<IMLOperatorKernelCreationContext, uint>)((*lpVtbl)[7]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    [return: NativeTypeName("uint32_t")]
    public uint GetOutputCount()
    {
        return ((delegate* unmanaged<IMLOperatorKernelCreationContext, uint>)((*lpVtbl)[8]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public bool IsInputValid([NativeTypeName("uint32_t")] uint inputIndex)
    {
        return ((delegate* unmanaged<IMLOperatorKernelCreationContext, uint, byte>)((*lpVtbl)[9]))(
                this,
                inputIndex
            ) != 0;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public bool IsOutputValid([NativeTypeName("uint32_t")] uint outputIndex)
    {
        return ((delegate* unmanaged<IMLOperatorKernelCreationContext, uint, byte>)((*lpVtbl)[10]))(
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
                IMLOperatorKernelCreationContext,
                uint,
                MLOperatorEdgeDescription*,
                int>)((*lpVtbl)[11])
        )(this, inputIndex, edgeDescription);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetOutputEdgeDescription(
        [NativeTypeName("uint32_t")] uint outputIndex,
        MLOperatorEdgeDescription* edgeDescription
    )
    {
        return (
            (delegate* unmanaged<
                IMLOperatorKernelCreationContext,
                uint,
                MLOperatorEdgeDescription*,
                int>)((*lpVtbl)[12])
        )(this, outputIndex, edgeDescription);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public bool HasTensorShapeDescription()
    {
        return ((delegate* unmanaged<IMLOperatorKernelCreationContext, byte>)((*lpVtbl)[13]))(this)
            != 0;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetTensorShapeDescription(IMLOperatorTensorShapeDescription* shapeDescription)
    {
        return (
            (delegate* unmanaged<
                IMLOperatorKernelCreationContext,
                IMLOperatorTensorShapeDescription*,
                int>)((*lpVtbl)[14])
        )(this, shapeDescription);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public void GetExecutionInterface(IUnknown* executionObject)
    {
        ((delegate* unmanaged<IMLOperatorKernelCreationContext, IUnknown*, void>)((*lpVtbl)[15]))(
            this,
            executionObject
        );
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
        HRESULT GetOutputEdgeDescription(
            [NativeTypeName("uint32_t")] uint outputIndex,
            MLOperatorEdgeDescription* edgeDescription
        );

        [VtblIndex(13)]
        bool HasTensorShapeDescription();

        [VtblIndex(14)]
        HRESULT GetTensorShapeDescription(IMLOperatorTensorShapeDescription* shapeDescription);

        [VtblIndex(15)]
        void GetExecutionInterface(IUnknown* executionObject);
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
            "HRESULT (uint32_t, MLOperatorEdgeDescription *) const noexcept __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            MLOperatorEdgeDescription*,
            int> GetOutputEdgeDescription;

        [NativeTypeName("bool () const noexcept __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte> HasTensorShapeDescription;

        [NativeTypeName(
            "HRESULT (IMLOperatorTensorShapeDescription **) const noexcept __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IMLOperatorTensorShapeDescription*,
            int> GetTensorShapeDescription;

        [NativeTypeName("void (IUnknown **) const noexcept __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown*, void> GetExecutionInterface;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMLOperatorKernelCreationContext"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMLOperatorKernelCreationContext(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IMLOperatorAttributes"/> to <see cref = "IMLOperatorKernelCreationContext"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IMLOperatorAttributes"/> instance to be converted </param>
    public static explicit operator IMLOperatorKernelCreationContext(
        Silk.NET.WinRT.IMLOperatorAttributes value
    )
    {
        return new IMLOperatorKernelCreationContext(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMLOperatorKernelCreationContext"/> to <see cref = "Silk.NET.WinRT.IMLOperatorAttributes"/>.</summary>
    /// <param name = "value">The <see cref = "IMLOperatorKernelCreationContext"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IMLOperatorAttributes(
        IMLOperatorKernelCreationContext value
    )
    {
        return new Silk.NET.WinRT.IMLOperatorAttributes(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMLOperatorKernelCreationContext"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMLOperatorKernelCreationContext(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IMLOperatorKernelCreationContext(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMLOperatorKernelCreationContext"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMLOperatorKernelCreationContext"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IMLOperatorKernelCreationContext value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
