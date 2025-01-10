// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/UIAnimation.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("BB3E1550-356E-44B0-99DA-85AC6017865E")]
[NativeTypeName("struct IUIAnimationVariableIntegerChangeHandler : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IUIAnimationVariableIntegerChangeHandler
    : IUIAnimationVariableIntegerChangeHandler.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IUIAnimationVariableIntegerChangeHandler));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IUIAnimationVariableIntegerChangeHandler, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return (
            (delegate* unmanaged<IUIAnimationVariableIntegerChangeHandler, uint>)((*lpVtbl)[1])
        )(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return (
            (delegate* unmanaged<IUIAnimationVariableIntegerChangeHandler, uint>)((*lpVtbl)[2])
        )(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT OnIntegerValueChanged(
        IUIAnimationStoryboard storyboard,
        IUIAnimationVariable variable,
        [NativeTypeName("INT32")] int newValue,
        [NativeTypeName("INT32")] int previousValue
    )
    {
        return (
            (delegate* unmanaged<
                IUIAnimationVariableIntegerChangeHandler,
                IUIAnimationStoryboard,
                IUIAnimationVariable,
                int,
                int,
                int>)((*lpVtbl)[3])
        )(this, storyboard, variable, newValue, previousValue);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT OnIntegerValueChanged(
            IUIAnimationStoryboard storyboard,
            IUIAnimationVariable variable,
            [NativeTypeName("INT32")] int newValue,
            [NativeTypeName("INT32")] int previousValue
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
            "HRESULT (IUIAnimationStoryboard *, IUIAnimationVariable *, INT32, INT32) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IUIAnimationStoryboard,
            IUIAnimationVariable,
            int,
            int,
            int> OnIntegerValueChanged;
    }

    /// <summary>Initializes a new instance of the <see cref = "IUIAnimationVariableIntegerChangeHandler"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IUIAnimationVariableIntegerChangeHandler(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IUIAnimationVariableIntegerChangeHandler"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IUIAnimationVariableIntegerChangeHandler(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IUIAnimationVariableIntegerChangeHandler(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IUIAnimationVariableIntegerChangeHandler"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IUIAnimationVariableIntegerChangeHandler"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IUIAnimationVariableIntegerChangeHandler value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
