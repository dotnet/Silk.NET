// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("79EAC9CD-BAF9-11CE-8C82-00AA004BA90B")]
[NativeTypeName("struct IBindProtocol : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IBindProtocol : IBindProtocol.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBindProtocol));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IBindProtocol, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IBindProtocol, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IBindProtocol, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CreateBinding(
        [NativeTypeName("LPCWSTR")] ushort* szUrl,
        IBindCtx pbc,
        IBinding* ppb
    )
    {
        return (
            (delegate* unmanaged<IBindProtocol, ushort*, IBindCtx, IBinding*, int>)((*lpVtbl)[3])
        )(this, szUrl, pbc, ppb);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT CreateBinding(
            [NativeTypeName("LPCWSTR")] ushort* szUrl,
            IBindCtx pbc,
            IBinding* ppb
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

        [NativeTypeName("HRESULT (LPCWSTR, IBindCtx *, IBinding **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, IBindCtx, IBinding*, int> CreateBinding;
    }

    /// <summary>Initializes a new instance of the <see cref = "IBindProtocol"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IBindProtocol(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IBindProtocol"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IBindProtocol(Silk.NET.Windows.IUnknown value)
    {
        return new IBindProtocol(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IBindProtocol"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IBindProtocol"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IBindProtocol value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
