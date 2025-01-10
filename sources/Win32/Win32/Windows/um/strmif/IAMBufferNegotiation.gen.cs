// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("56ED71A0-AF5F-11D0-B3F0-00AA003761C5")]
[NativeTypeName("struct IAMBufferNegotiation : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAMBufferNegotiation : IAMBufferNegotiation.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAMBufferNegotiation));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAMBufferNegotiation, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IAMBufferNegotiation, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAMBufferNegotiation, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SuggestAllocatorProperties(
        [NativeTypeName("const ALLOCATOR_PROPERTIES *")] ALLOCATOR_PROPERTIES* pprop
    )
    {
        return (
            (delegate* unmanaged<IAMBufferNegotiation, ALLOCATOR_PROPERTIES*, int>)((*lpVtbl)[3])
        )(this, pprop);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetAllocatorProperties(ALLOCATOR_PROPERTIES* pprop)
    {
        return (
            (delegate* unmanaged<IAMBufferNegotiation, ALLOCATOR_PROPERTIES*, int>)((*lpVtbl)[4])
        )(this, pprop);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SuggestAllocatorProperties(
            [NativeTypeName("const ALLOCATOR_PROPERTIES *")] ALLOCATOR_PROPERTIES* pprop
        );

        [VtblIndex(4)]
        HRESULT GetAllocatorProperties(ALLOCATOR_PROPERTIES* pprop);
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

        [NativeTypeName("HRESULT (const ALLOCATOR_PROPERTIES *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ALLOCATOR_PROPERTIES*, int> SuggestAllocatorProperties;

        [NativeTypeName("HRESULT (ALLOCATOR_PROPERTIES *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ALLOCATOR_PROPERTIES*, int> GetAllocatorProperties;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAMBufferNegotiation"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAMBufferNegotiation(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAMBufferNegotiation"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAMBufferNegotiation(Silk.NET.Windows.IUnknown value)
    {
        return new IAMBufferNegotiation(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAMBufferNegotiation"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAMBufferNegotiation"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAMBufferNegotiation value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
