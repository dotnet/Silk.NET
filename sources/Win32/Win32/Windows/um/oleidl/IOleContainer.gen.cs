// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/oleidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("0000011B-0000-0000-C000-000000000046")]
[NativeTypeName("struct IOleContainer : IParseDisplayName")]
[NativeInheritance("IParseDisplayName")]
public unsafe partial struct IOleContainer : IOleContainer.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IOleContainer));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IOleContainer, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IOleContainer, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IOleContainer, uint>)((*lpVtbl)[2]))(this);
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
            (delegate* unmanaged<IOleContainer, IBindCtx, ushort*, uint*, IMoniker*, int>)(
                (*lpVtbl)[3]
            )
        )(this, pbc, pszDisplayName, pchEaten, ppmkOut);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT EnumObjects([NativeTypeName("DWORD")] uint grfFlags, IEnumUnknown* ppenum)
    {
        return ((delegate* unmanaged<IOleContainer, uint, IEnumUnknown*, int>)((*lpVtbl)[4]))(
            this,
            grfFlags,
            ppenum
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT LockContainer(BOOL fLock)
    {
        return ((delegate* unmanaged<IOleContainer, BOOL, int>)((*lpVtbl)[5]))(this, fLock);
    }

    public interface Interface : IParseDisplayName.Interface
    {
        [VtblIndex(4)]
        HRESULT EnumObjects([NativeTypeName("DWORD")] uint grfFlags, IEnumUnknown* ppenum);

        [VtblIndex(5)]
        HRESULT LockContainer(BOOL fLock);
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

        [NativeTypeName("HRESULT (DWORD, IEnumUnknown **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IEnumUnknown*, int> EnumObjects;

        [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> LockContainer;
    }

    /// <summary>Initializes a new instance of the <see cref = "IOleContainer"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IOleContainer(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IParseDisplayName"/> to <see cref = "IOleContainer"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IParseDisplayName"/> instance to be converted </param>
    public static explicit operator IOleContainer(Silk.NET.Windows.IParseDisplayName value)
    {
        return new IOleContainer(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IOleContainer"/> to <see cref = "Silk.NET.Windows.IParseDisplayName"/>.</summary>
    /// <param name = "value">The <see cref = "IOleContainer"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IParseDisplayName(IOleContainer value)
    {
        return new Silk.NET.Windows.IParseDisplayName(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IOleContainer"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IOleContainer(Silk.NET.Windows.IUnknown value)
    {
        return new IOleContainer(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IOleContainer"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IOleContainer"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IOleContainer value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
