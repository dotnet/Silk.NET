// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MSAAText.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("A2DE3BC2-3D8E-11D3-81A9-F753FBE61A00")]
[NativeTypeName("struct ITextStoreACPEx : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ITextStoreACPEx : ITextStoreACPEx.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITextStoreACPEx));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITextStoreACPEx, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ITextStoreACPEx, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITextStoreACPEx, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT ScrollToRect(
        [NativeTypeName("LONG")] int acpStart,
        [NativeTypeName("LONG")] int acpEnd,
        RECT rc,
        [NativeTypeName("DWORD")] uint dwPosition
    )
    {
        return ((delegate* unmanaged<ITextStoreACPEx, int, int, RECT, uint, int>)((*lpVtbl)[3]))(
            this,
            acpStart,
            acpEnd,
            rc,
            dwPosition
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT ScrollToRect(
            [NativeTypeName("LONG")] int acpStart,
            [NativeTypeName("LONG")] int acpEnd,
            RECT rc,
            [NativeTypeName("DWORD")] uint dwPosition
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

        [NativeTypeName("HRESULT (LONG, LONG, RECT, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int, RECT, uint, int> ScrollToRect;
    }

    /// <summary>Initializes a new instance of the <see cref = "ITextStoreACPEx"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ITextStoreACPEx(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ITextStoreACPEx"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ITextStoreACPEx(Silk.NET.Windows.IUnknown value)
    {
        return new ITextStoreACPEx(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ITextStoreACPEx"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ITextStoreACPEx"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ITextStoreACPEx value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
