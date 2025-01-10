// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("C6E13370-30AC-11D0-A18C-00A0C9118956")]
[NativeTypeName("struct IAMCameraControl : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAMCameraControl : IAMCameraControl.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAMCameraControl));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAMCameraControl, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IAMCameraControl, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAMCameraControl, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetRange(
        [NativeTypeName("long")] int Property,
        [NativeTypeName("long *")] int* pMin,
        [NativeTypeName("long *")] int* pMax,
        [NativeTypeName("long *")] int* pSteppingDelta,
        [NativeTypeName("long *")] int* pDefault,
        [NativeTypeName("long *")] int* pCapsFlags
    )
    {
        return (
            (delegate* unmanaged<IAMCameraControl, int, int*, int*, int*, int*, int*, int>)(
                (*lpVtbl)[3]
            )
        )(this, Property, pMin, pMax, pSteppingDelta, pDefault, pCapsFlags);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Set(
        [NativeTypeName("long")] int Property,
        [NativeTypeName("long")] int lValue,
        [NativeTypeName("long")] int Flags
    )
    {
        return ((delegate* unmanaged<IAMCameraControl, int, int, int, int>)((*lpVtbl)[4]))(
            this,
            Property,
            lValue,
            Flags
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Get(
        [NativeTypeName("long")] int Property,
        [NativeTypeName("long *")] int* lValue,
        [NativeTypeName("long *")] int* Flags
    )
    {
        return ((delegate* unmanaged<IAMCameraControl, int, int*, int*, int>)((*lpVtbl)[5]))(
            this,
            Property,
            lValue,
            Flags
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetRange(
            [NativeTypeName("long")] int Property,
            [NativeTypeName("long *")] int* pMin,
            [NativeTypeName("long *")] int* pMax,
            [NativeTypeName("long *")] int* pSteppingDelta,
            [NativeTypeName("long *")] int* pDefault,
            [NativeTypeName("long *")] int* pCapsFlags
        );

        [VtblIndex(4)]
        HRESULT Set(
            [NativeTypeName("long")] int Property,
            [NativeTypeName("long")] int lValue,
            [NativeTypeName("long")] int Flags
        );

        [VtblIndex(5)]
        HRESULT Get(
            [NativeTypeName("long")] int Property,
            [NativeTypeName("long *")] int* lValue,
            [NativeTypeName("long *")] int* Flags
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

        [NativeTypeName(
            "HRESULT (long, long *, long *, long *, long *, long *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, int, int*, int*, int*, int*, int*, int> GetRange;

        [NativeTypeName("HRESULT (long, long, long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int, int, int> Set;

        [NativeTypeName("HRESULT (long, long *, long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int*, int*, int> Get;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAMCameraControl"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAMCameraControl(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAMCameraControl"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAMCameraControl(Silk.NET.Windows.IUnknown value)
    {
        return new IAMCameraControl(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAMCameraControl"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAMCameraControl"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAMCameraControl value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
