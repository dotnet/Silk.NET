// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("3050F429-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IElementBehaviorFactory : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IElementBehaviorFactory
    : IElementBehaviorFactory.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IElementBehaviorFactory));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IElementBehaviorFactory, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IElementBehaviorFactory, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IElementBehaviorFactory, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT FindBehavior(
        [NativeTypeName("BSTR")] ushort* bstrBehavior,
        [NativeTypeName("BSTR")] ushort* bstrBehaviorUrl,
        IElementBehaviorSite pSite,
        IElementBehavior* ppBehavior
    )
    {
        return (
            (delegate* unmanaged<
                IElementBehaviorFactory,
                ushort*,
                ushort*,
                IElementBehaviorSite,
                IElementBehavior*,
                int>)((*lpVtbl)[3])
        )(this, bstrBehavior, bstrBehaviorUrl, pSite, ppBehavior);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT FindBehavior(
            [NativeTypeName("BSTR")] ushort* bstrBehavior,
            [NativeTypeName("BSTR")] ushort* bstrBehaviorUrl,
            IElementBehaviorSite pSite,
            IElementBehavior* ppBehavior
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
            "HRESULT (BSTR, BSTR, IElementBehaviorSite *, IElementBehavior **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            ushort*,
            IElementBehaviorSite,
            IElementBehavior*,
            int> FindBehavior;
    }

    /// <summary>Initializes a new instance of the <see cref = "IElementBehaviorFactory"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IElementBehaviorFactory(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IElementBehaviorFactory"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IElementBehaviorFactory(Silk.NET.Windows.IUnknown value)
    {
        return new IElementBehaviorFactory(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IElementBehaviorFactory"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IElementBehaviorFactory"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IElementBehaviorFactory value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
