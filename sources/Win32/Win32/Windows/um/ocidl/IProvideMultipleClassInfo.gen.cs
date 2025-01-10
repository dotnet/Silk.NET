// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ocidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("A7ABA9C1-8983-11CF-8F20-00805F2CD064")]
[NativeTypeName("struct IProvideMultipleClassInfo : IProvideClassInfo2")]
[NativeInheritance("IProvideClassInfo2")]
public unsafe partial struct IProvideMultipleClassInfo
    : IProvideMultipleClassInfo.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IProvideMultipleClassInfo));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IProvideMultipleClassInfo, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IProvideMultipleClassInfo, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IProvideMultipleClassInfo, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetClassInfo(ITypeInfo* ppTI)
    {
        return ((delegate* unmanaged<IProvideMultipleClassInfo, ITypeInfo*, int>)((*lpVtbl)[3]))(
            this,
            ppTI
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetGUID([NativeTypeName("DWORD")] uint dwGuidKind, Guid* pGUID)
    {
        return ((delegate* unmanaged<IProvideMultipleClassInfo, uint, Guid*, int>)((*lpVtbl)[4]))(
            this,
            dwGuidKind,
            pGUID
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetMultiTypeInfoCount([NativeTypeName("ULONG *")] uint* pcti)
    {
        return ((delegate* unmanaged<IProvideMultipleClassInfo, uint*, int>)((*lpVtbl)[5]))(
            this,
            pcti
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetInfoOfIndex(
        [NativeTypeName("ULONG")] uint iti,
        [NativeTypeName("DWORD")] uint dwFlags,
        ITypeInfo* pptiCoClass,
        [NativeTypeName("DWORD *")] uint* pdwTIFlags,
        [NativeTypeName("ULONG *")] uint* pcdispidReserved,
        [NativeTypeName("IID *")] Guid* piidPrimary,
        [NativeTypeName("IID *")] Guid* piidSource
    )
    {
        return (
            (delegate* unmanaged<
                IProvideMultipleClassInfo,
                uint,
                uint,
                ITypeInfo*,
                uint*,
                uint*,
                Guid*,
                Guid*,
                int>)((*lpVtbl)[6])
        )(this, iti, dwFlags, pptiCoClass, pdwTIFlags, pcdispidReserved, piidPrimary, piidSource);
    }

    public interface Interface : IProvideClassInfo2.Interface
    {
        [VtblIndex(5)]
        HRESULT GetMultiTypeInfoCount([NativeTypeName("ULONG *")] uint* pcti);

        [VtblIndex(6)]
        HRESULT GetInfoOfIndex(
            [NativeTypeName("ULONG")] uint iti,
            [NativeTypeName("DWORD")] uint dwFlags,
            ITypeInfo* pptiCoClass,
            [NativeTypeName("DWORD *")] uint* pdwTIFlags,
            [NativeTypeName("ULONG *")] uint* pcdispidReserved,
            [NativeTypeName("IID *")] Guid* piidPrimary,
            [NativeTypeName("IID *")] Guid* piidSource
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

        [NativeTypeName("HRESULT (ITypeInfo **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ITypeInfo*, int> GetClassInfo;

        [NativeTypeName("HRESULT (DWORD, GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, Guid*, int> GetGUID;

        [NativeTypeName("HRESULT (ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetMultiTypeInfoCount;

        [NativeTypeName(
            "HRESULT (ULONG, DWORD, ITypeInfo **, DWORD *, ULONG *, IID *, IID *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            uint,
            ITypeInfo*,
            uint*,
            uint*,
            Guid*,
            Guid*,
            int> GetInfoOfIndex;
    }

    /// <summary>Initializes a new instance of the <see cref = "IProvideMultipleClassInfo"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IProvideMultipleClassInfo(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IProvideClassInfo2"/> to <see cref = "IProvideMultipleClassInfo"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IProvideClassInfo2"/> instance to be converted </param>
    public static explicit operator IProvideMultipleClassInfo(
        Silk.NET.Windows.IProvideClassInfo2 value
    )
    {
        return new IProvideMultipleClassInfo(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IProvideMultipleClassInfo"/> to <see cref = "Silk.NET.Windows.IProvideClassInfo2"/>.</summary>
    /// <param name = "value">The <see cref = "IProvideMultipleClassInfo"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IProvideClassInfo2(
        IProvideMultipleClassInfo value
    )
    {
        return new Silk.NET.Windows.IProvideClassInfo2(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IProvideClassInfo"/> to <see cref = "IProvideMultipleClassInfo"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IProvideClassInfo"/> instance to be converted </param>
    public static explicit operator IProvideMultipleClassInfo(
        Silk.NET.Windows.IProvideClassInfo value
    )
    {
        return new IProvideMultipleClassInfo(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IProvideMultipleClassInfo"/> to <see cref = "Silk.NET.Windows.IProvideClassInfo"/>.</summary>
    /// <param name = "value">The <see cref = "IProvideMultipleClassInfo"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IProvideClassInfo(
        IProvideMultipleClassInfo value
    )
    {
        return new Silk.NET.Windows.IProvideClassInfo(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IProvideMultipleClassInfo"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IProvideMultipleClassInfo(Silk.NET.Windows.IUnknown value)
    {
        return new IProvideMultipleClassInfo(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IProvideMultipleClassInfo"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IProvideMultipleClassInfo"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IProvideMultipleClassInfo value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
