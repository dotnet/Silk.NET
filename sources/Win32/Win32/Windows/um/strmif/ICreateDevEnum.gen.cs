// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("29840822-5B84-11D0-BD3B-00A0C911CE86")]
[NativeTypeName("struct ICreateDevEnum : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ICreateDevEnum : ICreateDevEnum.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICreateDevEnum));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ICreateDevEnum, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ICreateDevEnum, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICreateDevEnum, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CreateClassEnumerator(
        [NativeTypeName("const IID &")] Guid* clsidDeviceClass,
        IEnumMoniker* ppEnumMoniker,
        [NativeTypeName("DWORD")] uint dwFlags
    )
    {
        return (
            (delegate* unmanaged<ICreateDevEnum, Guid*, IEnumMoniker*, uint, int>)((*lpVtbl)[3])
        )(this, clsidDeviceClass, ppEnumMoniker, dwFlags);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT CreateClassEnumerator(
            [NativeTypeName("const IID &")] Guid* clsidDeviceClass,
            IEnumMoniker* ppEnumMoniker,
            [NativeTypeName("DWORD")] uint dwFlags
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

        [NativeTypeName("HRESULT (const IID &, IEnumMoniker **, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, IEnumMoniker*, uint, int> CreateClassEnumerator;
    }

    /// <summary>Initializes a new instance of the <see cref = "ICreateDevEnum"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ICreateDevEnum(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ICreateDevEnum"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ICreateDevEnum(Silk.NET.Windows.IUnknown value)
    {
        return new ICreateDevEnum(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICreateDevEnum"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ICreateDevEnum"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ICreateDevEnum value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
