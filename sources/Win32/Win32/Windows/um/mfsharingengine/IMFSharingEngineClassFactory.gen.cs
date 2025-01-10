// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfsharingengine.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("2BA61F92-8305-413B-9733-FAF15F259384")]
[NativeTypeName("struct IMFSharingEngineClassFactory : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct IMFSharingEngineClassFactory
    : IMFSharingEngineClassFactory.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFSharingEngineClassFactory));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IMFSharingEngineClassFactory, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFSharingEngineClassFactory, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFSharingEngineClassFactory, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CreateInstance(
        [NativeTypeName("DWORD")] uint dwFlags,
        IMFAttributes pAttr,
        IUnknown* ppEngine
    )
    {
        return (
            (delegate* unmanaged<
                IMFSharingEngineClassFactory,
                uint,
                IMFAttributes,
                IUnknown*,
                int>)((*lpVtbl)[3])
        )(this, dwFlags, pAttr, ppEngine);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT CreateInstance(
            [NativeTypeName("DWORD")] uint dwFlags,
            IMFAttributes pAttr,
            IUnknown* ppEngine
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

        [NativeTypeName("HRESULT (DWORD, IMFAttributes *, IUnknown **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IMFAttributes, IUnknown*, int> CreateInstance;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMFSharingEngineClassFactory"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMFSharingEngineClassFactory(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMFSharingEngineClassFactory"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMFSharingEngineClassFactory(Silk.NET.Windows.IUnknown value)
    {
        return new IMFSharingEngineClassFactory(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFSharingEngineClassFactory"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMFSharingEngineClassFactory"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMFSharingEngineClassFactory value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
