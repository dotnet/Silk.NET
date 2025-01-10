// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/windows.ai.machinelearning.native.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("1ADAA23A-EB67-41F3-AAD8-5D984E9BACD4")]
[NativeTypeName("struct ILearningModelOperatorProviderNative : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ILearningModelOperatorProviderNative
    : ILearningModelOperatorProviderNative.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ILearningModelOperatorProviderNative));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<ILearningModelOperatorProviderNative, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ILearningModelOperatorProviderNative, uint>)((*lpVtbl)[1]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ILearningModelOperatorProviderNative, uint>)((*lpVtbl)[2]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetRegistry(IMLOperatorRegistry* ppOperatorRegistry)
    {
        return (
            (delegate* unmanaged<ILearningModelOperatorProviderNative, IMLOperatorRegistry*, int>)(
                (*lpVtbl)[3]
            )
        )(this, ppOperatorRegistry);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetRegistry(IMLOperatorRegistry* ppOperatorRegistry);
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
            "HRESULT (IMLOperatorRegistry **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IMLOperatorRegistry*, int> GetRegistry;
    }

    /// <summary>Initializes a new instance of the <see cref = "ILearningModelOperatorProviderNative"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ILearningModelOperatorProviderNative(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ILearningModelOperatorProviderNative"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ILearningModelOperatorProviderNative(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new ILearningModelOperatorProviderNative(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ILearningModelOperatorProviderNative"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ILearningModelOperatorProviderNative"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        ILearningModelOperatorProviderNative value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
