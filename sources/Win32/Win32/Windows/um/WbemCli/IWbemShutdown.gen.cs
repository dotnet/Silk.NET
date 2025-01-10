// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WbemCli.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("B7B31DF9-D515-11D3-A11C-00105A1F515A")]
[NativeTypeName("struct IWbemShutdown : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IWbemShutdown : IWbemShutdown.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWbemShutdown));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IWbemShutdown, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IWbemShutdown, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IWbemShutdown, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Shutdown(
        [NativeTypeName("LONG")] int uReason,
        [NativeTypeName("ULONG")] uint uMaxMilliseconds,
        IWbemContext pCtx
    )
    {
        return ((delegate* unmanaged<IWbemShutdown, int, uint, IWbemContext, int>)((*lpVtbl)[3]))(
            this,
            uReason,
            uMaxMilliseconds,
            pCtx
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Shutdown(
            [NativeTypeName("LONG")] int uReason,
            [NativeTypeName("ULONG")] uint uMaxMilliseconds,
            IWbemContext pCtx
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

        [NativeTypeName("HRESULT (LONG, ULONG, IWbemContext *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, uint, IWbemContext, int> Shutdown;
    }

    /// <summary>Initializes a new instance of the <see cref = "IWbemShutdown"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IWbemShutdown(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IWbemShutdown"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IWbemShutdown(Silk.NET.Windows.IUnknown value)
    {
        return new IWbemShutdown(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IWbemShutdown"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IWbemShutdown"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IWbemShutdown value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
