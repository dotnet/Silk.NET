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

[Guid("2AF9DD2D-B516-4672-9AB5-530C208493AD")]
[NativeTypeName("struct IMLOperatorRegistry : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMLOperatorRegistry : IMLOperatorRegistry.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMLOperatorRegistry));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMLOperatorRegistry, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMLOperatorRegistry, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMLOperatorRegistry, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT RegisterOperatorSetSchema(
        [NativeTypeName("const MLOperatorSetId *")] MLOperatorSetId* operatorSetId,
        [NativeTypeName("int32_t")] int baselineVersion,
        [NativeTypeName("const MLOperatorSchemaDescription *const *")]
            MLOperatorSchemaDescription** schema,
        [NativeTypeName("uint32_t")] uint schemaCount,
        IMLOperatorTypeInferrer typeInferrer,
        IMLOperatorShapeInferrer shapeInferrer
    )
    {
        return (
            (delegate* unmanaged<
                IMLOperatorRegistry,
                MLOperatorSetId*,
                int,
                MLOperatorSchemaDescription**,
                uint,
                IMLOperatorTypeInferrer,
                IMLOperatorShapeInferrer,
                int>)((*lpVtbl)[3])
        )(this, operatorSetId, baselineVersion, schema, schemaCount, typeInferrer, shapeInferrer);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT RegisterOperatorKernel(
        [NativeTypeName("const MLOperatorKernelDescription *")]
            MLOperatorKernelDescription* operatorKernel,
        IMLOperatorKernelFactory operatorKernelFactory,
        IMLOperatorShapeInferrer shapeInferrer
    )
    {
        return (
            (delegate* unmanaged<
                IMLOperatorRegistry,
                MLOperatorKernelDescription*,
                IMLOperatorKernelFactory,
                IMLOperatorShapeInferrer,
                int>)((*lpVtbl)[4])
        )(this, operatorKernel, operatorKernelFactory, shapeInferrer);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT RegisterOperatorSetSchema(
            [NativeTypeName("const MLOperatorSetId *")] MLOperatorSetId* operatorSetId,
            [NativeTypeName("int32_t")] int baselineVersion,
            [NativeTypeName("const MLOperatorSchemaDescription *const *")]
                MLOperatorSchemaDescription** schema,
            [NativeTypeName("uint32_t")] uint schemaCount,
            IMLOperatorTypeInferrer typeInferrer,
            IMLOperatorShapeInferrer shapeInferrer
        );

        [VtblIndex(4)]
        HRESULT RegisterOperatorKernel(
            [NativeTypeName("const MLOperatorKernelDescription *")]
                MLOperatorKernelDescription* operatorKernel,
            IMLOperatorKernelFactory operatorKernelFactory,
            IMLOperatorShapeInferrer shapeInferrer
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
            "HRESULT (const MLOperatorSetId *, int32_t, const MLOperatorSchemaDescription *const *, uint32_t, IMLOperatorTypeInferrer *, IMLOperatorShapeInferrer *) const noexcept __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            MLOperatorSetId*,
            int,
            MLOperatorSchemaDescription**,
            uint,
            IMLOperatorTypeInferrer,
            IMLOperatorShapeInferrer,
            int> RegisterOperatorSetSchema;

        [NativeTypeName(
            "HRESULT (const MLOperatorKernelDescription *, IMLOperatorKernelFactory *, IMLOperatorShapeInferrer *) const noexcept __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            MLOperatorKernelDescription*,
            IMLOperatorKernelFactory,
            IMLOperatorShapeInferrer,
            int> RegisterOperatorKernel;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMLOperatorRegistry"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMLOperatorRegistry(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMLOperatorRegistry"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMLOperatorRegistry(Silk.NET.Windows.IUnknown value)
    {
        return new IMLOperatorRegistry(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMLOperatorRegistry"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMLOperatorRegistry"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMLOperatorRegistry value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
