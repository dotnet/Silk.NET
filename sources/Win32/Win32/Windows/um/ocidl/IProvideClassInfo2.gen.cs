// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ocidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("A6BC3AC0-DBAA-11CE-9DE3-00AA004BB851")]
[NativeTypeName("struct IProvideClassInfo2 : IProvideClassInfo")]
[NativeInheritance("IProvideClassInfo")]
public unsafe partial struct IProvideClassInfo2 : IProvideClassInfo2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IProvideClassInfo2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IProvideClassInfo2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IProvideClassInfo2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IProvideClassInfo2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetClassInfo(ITypeInfo* ppTI)
    {
        return ((delegate* unmanaged<IProvideClassInfo2, ITypeInfo*, int>)((*lpVtbl)[3]))(
            this,
            ppTI
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetGUID([NativeTypeName("DWORD")] uint dwGuidKind, Guid* pGUID)
    {
        return ((delegate* unmanaged<IProvideClassInfo2, uint, Guid*, int>)((*lpVtbl)[4]))(
            this,
            dwGuidKind,
            pGUID
        );
    }

    public interface Interface : IProvideClassInfo.Interface
    {
        [VtblIndex(4)]
        HRESULT GetGUID([NativeTypeName("DWORD")] uint dwGuidKind, Guid* pGUID);
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
    }

    /// <summary>Initializes a new instance of the <see cref = "IProvideClassInfo2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IProvideClassInfo2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IProvideClassInfo"/> to <see cref = "IProvideClassInfo2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IProvideClassInfo"/> instance to be converted </param>
    public static explicit operator IProvideClassInfo2(Silk.NET.Windows.IProvideClassInfo value)
    {
        return new IProvideClassInfo2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IProvideClassInfo2"/> to <see cref = "Silk.NET.Windows.IProvideClassInfo"/>.</summary>
    /// <param name = "value">The <see cref = "IProvideClassInfo2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IProvideClassInfo(IProvideClassInfo2 value)
    {
        return new Silk.NET.Windows.IProvideClassInfo(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IProvideClassInfo2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IProvideClassInfo2(Silk.NET.Windows.IUnknown value)
    {
        return new IProvideClassInfo2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IProvideClassInfo2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IProvideClassInfo2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IProvideClassInfo2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
