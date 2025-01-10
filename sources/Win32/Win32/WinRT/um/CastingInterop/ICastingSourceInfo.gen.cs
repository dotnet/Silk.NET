// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CastingInterop.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("45101AB7-7C3A-4BCE-9500-12C09024B298")]
[NativeTypeName("struct ICastingSourceInfo : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ICastingSourceInfo : ICastingSourceInfo.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICastingSourceInfo));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ICastingSourceInfo, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ICastingSourceInfo, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICastingSourceInfo, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetController(ICastingController* controller)
    {
        return ((delegate* unmanaged<ICastingSourceInfo, ICastingController*, int>)((*lpVtbl)[3]))(
            this,
            controller
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetProperties(INamedPropertyStore* props)
    {
        return ((delegate* unmanaged<ICastingSourceInfo, INamedPropertyStore*, int>)((*lpVtbl)[4]))(
            this,
            props
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetController(ICastingController* controller);

        [VtblIndex(4)]
        HRESULT GetProperties(INamedPropertyStore* props);
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

        [NativeTypeName("HRESULT (ICastingController **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ICastingController*, int> GetController;

        [NativeTypeName("HRESULT (INamedPropertyStore **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, INamedPropertyStore*, int> GetProperties;
    }

    /// <summary>Initializes a new instance of the <see cref = "ICastingSourceInfo"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ICastingSourceInfo(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ICastingSourceInfo"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ICastingSourceInfo(Silk.NET.Windows.IUnknown value)
    {
        return new ICastingSourceInfo(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICastingSourceInfo"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ICastingSourceInfo"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ICastingSourceInfo value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
