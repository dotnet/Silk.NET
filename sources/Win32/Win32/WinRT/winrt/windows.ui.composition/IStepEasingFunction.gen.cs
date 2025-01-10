// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.ui.composition.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("D0CAA74B-560C-4A0B-A5F6-206CA8C3ECD6")]
[NativeTypeName("struct IStepEasingFunction : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IStepEasingFunction : IStepEasingFunction.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IStepEasingFunction));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IStepEasingFunction, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IStepEasingFunction, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IStepEasingFunction, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IStepEasingFunction, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IStepEasingFunction, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IStepEasingFunction, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_FinalStep([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged<IStepEasingFunction, int*, int>)((*lpVtbl)[6]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_FinalStep([NativeTypeName("INT32")] int value)
    {
        return ((delegate* unmanaged<IStepEasingFunction, int, int>)((*lpVtbl)[7]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_InitialStep([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged<IStepEasingFunction, int*, int>)((*lpVtbl)[8]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_InitialStep([NativeTypeName("INT32")] int value)
    {
        return ((delegate* unmanaged<IStepEasingFunction, int, int>)((*lpVtbl)[9]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_IsFinalStepSingleFrame([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IStepEasingFunction, byte*, int>)((*lpVtbl)[10]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_IsFinalStepSingleFrame([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged<IStepEasingFunction, byte, int>)((*lpVtbl)[11]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_IsInitialStepSingleFrame([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IStepEasingFunction, byte*, int>)((*lpVtbl)[12]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_IsInitialStepSingleFrame([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged<IStepEasingFunction, byte, int>)((*lpVtbl)[13]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_StepCount([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged<IStepEasingFunction, int*, int>)((*lpVtbl)[14]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_StepCount([NativeTypeName("INT32")] int value)
    {
        return ((delegate* unmanaged<IStepEasingFunction, int, int>)((*lpVtbl)[15]))(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_FinalStep([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(7)]
        HRESULT put_FinalStep([NativeTypeName("INT32")] int value);

        [VtblIndex(8)]
        HRESULT get_InitialStep([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(9)]
        HRESULT put_InitialStep([NativeTypeName("INT32")] int value);

        [VtblIndex(10)]
        HRESULT get_IsFinalStepSingleFrame([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(11)]
        HRESULT put_IsFinalStepSingleFrame([NativeTypeName("boolean")] byte value);

        [VtblIndex(12)]
        HRESULT get_IsInitialStepSingleFrame([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(13)]
        HRESULT put_IsInitialStepSingleFrame([NativeTypeName("boolean")] byte value);

        [VtblIndex(14)]
        HRESULT get_StepCount([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(15)]
        HRESULT put_StepCount([NativeTypeName("INT32")] int value);
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

        [NativeTypeName("HRESULT (ULONG *, IID **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, Guid**, int> GetIids;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> GetRuntimeClassName;

        [NativeTypeName("HRESULT (TrustLevel *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TrustLevel*, int> GetTrustLevel;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_FinalStep;

        [NativeTypeName("HRESULT (INT32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_FinalStep;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_InitialStep;

        [NativeTypeName("HRESULT (INT32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_InitialStep;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsFinalStepSingleFrame;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_IsFinalStepSingleFrame;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsInitialStepSingleFrame;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_IsInitialStepSingleFrame;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_StepCount;

        [NativeTypeName("HRESULT (INT32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_StepCount;
    }

    /// <summary>Initializes a new instance of the <see cref = "IStepEasingFunction"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IStepEasingFunction(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IStepEasingFunction"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IStepEasingFunction(Silk.NET.WinRT.IInspectable value)
    {
        return new IStepEasingFunction(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IStepEasingFunction"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IStepEasingFunction"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IStepEasingFunction value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IStepEasingFunction"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IStepEasingFunction(Silk.NET.Windows.IUnknown value)
    {
        return new IStepEasingFunction(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IStepEasingFunction"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IStepEasingFunction"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IStepEasingFunction value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
