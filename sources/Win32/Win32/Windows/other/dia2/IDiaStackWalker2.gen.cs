// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from dia2.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("7C185885-A015-4CAC-9411-0F4FB39B1F3A")]
[NativeTypeName("struct IDiaStackWalker2 : IDiaStackWalker")]
[NativeInheritance("IDiaStackWalker")]
public unsafe partial struct IDiaStackWalker2 : IDiaStackWalker2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDiaStackWalker2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDiaStackWalker2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDiaStackWalker2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDiaStackWalker2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT getEnumFrames(IDiaStackWalkHelper pHelper, IDiaEnumStackFrames* ppEnum)
    {
        return (
            (delegate* unmanaged<IDiaStackWalker2, IDiaStackWalkHelper, IDiaEnumStackFrames*, int>)(
                (*lpVtbl)[3]
            )
        )(this, pHelper, ppEnum);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT getEnumFrames2(
        [NativeTypeName("enum CV_CPU_TYPE_e")] CV_CPU_TYPE_e cpuid,
        IDiaStackWalkHelper pHelper,
        IDiaEnumStackFrames* ppEnum
    )
    {
        return (
            (delegate* unmanaged<
                IDiaStackWalker2,
                CV_CPU_TYPE_e,
                IDiaStackWalkHelper,
                IDiaEnumStackFrames*,
                int>)((*lpVtbl)[4])
        )(this, cpuid, pHelper, ppEnum);
    }

    public interface Interface : IDiaStackWalker.Interface { }

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
            "HRESULT (IDiaStackWalkHelper *, IDiaEnumStackFrames **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IDiaStackWalkHelper,
            IDiaEnumStackFrames*,
            int> getEnumFrames;

        [NativeTypeName(
            "HRESULT (enum CV_CPU_TYPE_e, IDiaStackWalkHelper *, IDiaEnumStackFrames **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            CV_CPU_TYPE_e,
            IDiaStackWalkHelper,
            IDiaEnumStackFrames*,
            int> getEnumFrames2;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDiaStackWalker2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDiaStackWalker2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IDiaStackWalker"/> to <see cref = "IDiaStackWalker2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IDiaStackWalker"/> instance to be converted </param>
    public static explicit operator IDiaStackWalker2(Silk.NET.Windows.IDiaStackWalker value)
    {
        return new IDiaStackWalker2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDiaStackWalker2"/> to <see cref = "Silk.NET.Windows.IDiaStackWalker"/>.</summary>
    /// <param name = "value">The <see cref = "IDiaStackWalker2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IDiaStackWalker(IDiaStackWalker2 value)
    {
        return new Silk.NET.Windows.IDiaStackWalker(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDiaStackWalker2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDiaStackWalker2(Silk.NET.Windows.IUnknown value)
    {
        return new IDiaStackWalker2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDiaStackWalker2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDiaStackWalker2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDiaStackWalker2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
