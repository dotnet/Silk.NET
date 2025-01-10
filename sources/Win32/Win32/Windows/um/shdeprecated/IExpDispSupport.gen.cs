// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/shdeprecated.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("0D7D1D00-6FC0-11D0-A974-00C04FD705A2")]
[NativeTypeName("struct IExpDispSupport : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IExpDispSupport : IExpDispSupport.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IExpDispSupport));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IExpDispSupport, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IExpDispSupport, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IExpDispSupport, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT FindConnectionPoint(
        [NativeTypeName("const IID &")] Guid* riid,
        IConnectionPoint* ppccp
    )
    {
        return (
            (delegate* unmanaged<IExpDispSupport, Guid*, IConnectionPoint*, int>)((*lpVtbl)[3])
        )(this, riid, ppccp);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT OnTranslateAccelerator(MSG* pMsg, [NativeTypeName("DWORD")] uint grfModifiers)
    {
        return ((delegate* unmanaged<IExpDispSupport, MSG*, uint, int>)((*lpVtbl)[4]))(
            this,
            pMsg,
            grfModifiers
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT OnInvoke(
        [NativeTypeName("DISPID")] int dispidMember,
        [NativeTypeName("const IID &")] Guid* iid,
        [NativeTypeName("LCID")] uint lcid,
        [NativeTypeName("WORD")] ushort wFlags,
        DISPPARAMS* pdispparams,
        VARIANT* pVarResult,
        EXCEPINFO* pexcepinfo,
        uint* puArgErr
    )
    {
        return (
            (delegate* unmanaged<
                IExpDispSupport,
                int,
                Guid*,
                uint,
                ushort,
                DISPPARAMS*,
                VARIANT*,
                EXCEPINFO*,
                uint*,
                int>)((*lpVtbl)[5])
        )(this, dispidMember, iid, lcid, wFlags, pdispparams, pVarResult, pexcepinfo, puArgErr);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT FindConnectionPoint(
            [NativeTypeName("const IID &")] Guid* riid,
            IConnectionPoint* ppccp
        );

        [VtblIndex(4)]
        HRESULT OnTranslateAccelerator(MSG* pMsg, [NativeTypeName("DWORD")] uint grfModifiers);

        [VtblIndex(5)]
        HRESULT OnInvoke(
            [NativeTypeName("DISPID")] int dispidMember,
            [NativeTypeName("const IID &")] Guid* iid,
            [NativeTypeName("LCID")] uint lcid,
            [NativeTypeName("WORD")] ushort wFlags,
            DISPPARAMS* pdispparams,
            VARIANT* pVarResult,
            EXCEPINFO* pexcepinfo,
            uint* puArgErr
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

        [NativeTypeName("HRESULT (const IID &, IConnectionPoint **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, IConnectionPoint*, int> FindConnectionPoint;

        [NativeTypeName("HRESULT (MSG *, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, MSG*, uint, int> OnTranslateAccelerator;

        [NativeTypeName(
            "HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            int,
            Guid*,
            uint,
            ushort,
            DISPPARAMS*,
            VARIANT*,
            EXCEPINFO*,
            uint*,
            int> OnInvoke;
    }

    /// <summary>Initializes a new instance of the <see cref = "IExpDispSupport"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IExpDispSupport(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IExpDispSupport"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IExpDispSupport(Silk.NET.Windows.IUnknown value)
    {
        return new IExpDispSupport(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IExpDispSupport"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IExpDispSupport"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IExpDispSupport value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
