// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("3050F425-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IElementBehavior : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IElementBehavior : IElementBehavior.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IElementBehavior));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IElementBehavior, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IElementBehavior, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IElementBehavior, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Init(IElementBehaviorSite pBehaviorSite)
    {
        return ((delegate* unmanaged<IElementBehavior, IElementBehaviorSite, int>)((*lpVtbl)[3]))(
            this,
            pBehaviorSite
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Notify([NativeTypeName("LONG")] int lEvent, VARIANT* pVar)
    {
        return ((delegate* unmanaged<IElementBehavior, int, VARIANT*, int>)((*lpVtbl)[4]))(
            this,
            lEvent,
            pVar
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Detach()
    {
        return ((delegate* unmanaged<IElementBehavior, int>)((*lpVtbl)[5]))(this);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Init(IElementBehaviorSite pBehaviorSite);

        [VtblIndex(4)]
        HRESULT Notify([NativeTypeName("LONG")] int lEvent, VARIANT* pVar);

        [VtblIndex(5)]
        HRESULT Detach();
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

        [NativeTypeName("HRESULT (IElementBehaviorSite *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IElementBehaviorSite, int> Init;

        [NativeTypeName("HRESULT (LONG, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, VARIANT*, int> Notify;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Detach;
    }

    /// <summary>Initializes a new instance of the <see cref = "IElementBehavior"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IElementBehavior(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IElementBehavior"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IElementBehavior(Silk.NET.Windows.IUnknown value)
    {
        return new IElementBehavior(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IElementBehavior"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IElementBehavior"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IElementBehavior value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
