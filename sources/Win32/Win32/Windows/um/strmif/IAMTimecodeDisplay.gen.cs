// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("9B496CE2-811B-11CF-8C77-00AA006B6814")]
[NativeTypeName("struct IAMTimecodeDisplay : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAMTimecodeDisplay : IAMTimecodeDisplay.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAMTimecodeDisplay));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAMTimecodeDisplay, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IAMTimecodeDisplay, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAMTimecodeDisplay, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTCDisplayEnable([NativeTypeName("long *")] int* pState)
    {
        return ((delegate* unmanaged<IAMTimecodeDisplay, int*, int>)((*lpVtbl)[3]))(this, pState);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetTCDisplayEnable([NativeTypeName("long")] int State)
    {
        return ((delegate* unmanaged<IAMTimecodeDisplay, int, int>)((*lpVtbl)[4]))(this, State);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTCDisplay(
        [NativeTypeName("long")] int Param,
        [NativeTypeName("long *")] int* pValue
    )
    {
        return ((delegate* unmanaged<IAMTimecodeDisplay, int, int*, int>)((*lpVtbl)[5]))(
            this,
            Param,
            pValue
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetTCDisplay(
        [NativeTypeName("long")] int Param,
        [NativeTypeName("long")] int Value
    )
    {
        return ((delegate* unmanaged<IAMTimecodeDisplay, int, int, int>)((*lpVtbl)[6]))(
            this,
            Param,
            Value
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetTCDisplayEnable([NativeTypeName("long *")] int* pState);

        [VtblIndex(4)]
        HRESULT SetTCDisplayEnable([NativeTypeName("long")] int State);

        [VtblIndex(5)]
        HRESULT GetTCDisplay(
            [NativeTypeName("long")] int Param,
            [NativeTypeName("long *")] int* pValue
        );

        [VtblIndex(6)]
        HRESULT SetTCDisplay(
            [NativeTypeName("long")] int Param,
            [NativeTypeName("long")] int Value
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

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> GetTCDisplayEnable;

        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> SetTCDisplayEnable;

        [NativeTypeName("HRESULT (long, long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int*, int> GetTCDisplay;

        [NativeTypeName("HRESULT (long, long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int, int> SetTCDisplay;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAMTimecodeDisplay"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAMTimecodeDisplay(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAMTimecodeDisplay"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAMTimecodeDisplay(Silk.NET.Windows.IUnknown value)
    {
        return new IAMTimecodeDisplay(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAMTimecodeDisplay"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAMTimecodeDisplay"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAMTimecodeDisplay value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
