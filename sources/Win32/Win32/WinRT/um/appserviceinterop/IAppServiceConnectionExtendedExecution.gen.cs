// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/appserviceinterop.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("65219584-F9CB-4AE3-81F9-A28A6CA450D9")]
[NativeTypeName("struct IAppServiceConnectionExtendedExecution : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAppServiceConnectionExtendedExecution
    : IAppServiceConnectionExtendedExecution.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppServiceConnectionExtendedExecution));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IAppServiceConnectionExtendedExecution, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAppServiceConnectionExtendedExecution, uint>)((*lpVtbl)[1]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppServiceConnectionExtendedExecution, uint>)((*lpVtbl)[2]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT OpenForExtendedExecutionAsync(
        [NativeTypeName("const IID &")] Guid* riid,
        void** operation
    )
    {
        return (
            (delegate* unmanaged<IAppServiceConnectionExtendedExecution, Guid*, void**, int>)(
                (*lpVtbl)[3]
            )
        )(this, riid, operation);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT OpenForExtendedExecutionAsync(
            [NativeTypeName("const IID &")] Guid* riid,
            void** operation
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

        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> OpenForExtendedExecutionAsync;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAppServiceConnectionExtendedExecution"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAppServiceConnectionExtendedExecution(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAppServiceConnectionExtendedExecution"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAppServiceConnectionExtendedExecution(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IAppServiceConnectionExtendedExecution(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAppServiceConnectionExtendedExecution"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAppServiceConnectionExtendedExecution"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IAppServiceConnectionExtendedExecution value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
