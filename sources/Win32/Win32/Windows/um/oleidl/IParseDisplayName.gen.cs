// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/oleidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("0000011A-0000-0000-C000-000000000046")]
[NativeTypeName("struct IParseDisplayName : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IParseDisplayName : IParseDisplayName.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IParseDisplayName));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IParseDisplayName, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IParseDisplayName, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IParseDisplayName, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT ParseDisplayName(
        IBindCtx pbc,
        [NativeTypeName("LPOLESTR")] ushort* pszDisplayName,
        [NativeTypeName("ULONG *")] uint* pchEaten,
        IMoniker* ppmkOut
    )
    {
        return (
            (delegate* unmanaged<IParseDisplayName, IBindCtx, ushort*, uint*, IMoniker*, int>)(
                (*lpVtbl)[3]
            )
        )(this, pbc, pszDisplayName, pchEaten, ppmkOut);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT ParseDisplayName(
            IBindCtx pbc,
            [NativeTypeName("LPOLESTR")] ushort* pszDisplayName,
            [NativeTypeName("ULONG *")] uint* pchEaten,
            IMoniker* ppmkOut
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
            "HRESULT (IBindCtx *, LPOLESTR, ULONG *, IMoniker **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IBindCtx,
            ushort*,
            uint*,
            IMoniker*,
            int> ParseDisplayName;
    }

    /// <summary>Initializes a new instance of the <see cref = "IParseDisplayName"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IParseDisplayName(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IParseDisplayName"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IParseDisplayName(Silk.NET.Windows.IUnknown value)
    {
        return new IParseDisplayName(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IParseDisplayName"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IParseDisplayName"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IParseDisplayName value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
