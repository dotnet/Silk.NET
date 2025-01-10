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

[Guid("EF15AD6F-0DC9-4908-AB35-A575A30DFBF8")]
[NativeTypeName("struct IMLOperatorKernelFactory : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMLOperatorKernelFactory
    : IMLOperatorKernelFactory.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMLOperatorKernelFactory));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMLOperatorKernelFactory, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMLOperatorKernelFactory, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMLOperatorKernelFactory, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CreateKernel(IMLOperatorKernelCreationContext context, IMLOperatorKernel* kernel)
    {
        return (
            (delegate* unmanaged<
                IMLOperatorKernelFactory,
                IMLOperatorKernelCreationContext,
                IMLOperatorKernel*,
                int>)((*lpVtbl)[3])
        )(this, context, kernel);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT CreateKernel(IMLOperatorKernelCreationContext context, IMLOperatorKernel* kernel);
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
            "HRESULT (IMLOperatorKernelCreationContext *, IMLOperatorKernel **) noexcept __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IMLOperatorKernelCreationContext,
            IMLOperatorKernel*,
            int> CreateKernel;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMLOperatorKernelFactory"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMLOperatorKernelFactory(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMLOperatorKernelFactory"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMLOperatorKernelFactory(Silk.NET.Windows.IUnknown value)
    {
        return new IMLOperatorKernelFactory(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMLOperatorKernelFactory"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMLOperatorKernelFactory"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMLOperatorKernelFactory value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
