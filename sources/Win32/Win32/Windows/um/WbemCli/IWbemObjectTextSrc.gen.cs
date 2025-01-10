// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WbemCli.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("BFBF883A-CAD7-11D3-A11B-00105A1F515A")]
[NativeTypeName("struct IWbemObjectTextSrc : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IWbemObjectTextSrc : IWbemObjectTextSrc.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWbemObjectTextSrc));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IWbemObjectTextSrc, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IWbemObjectTextSrc, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IWbemObjectTextSrc, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetText(
        [NativeTypeName("long")] int lFlags,
        IWbemClassObject pObj,
        [NativeTypeName("ULONG")] uint uObjTextFormat,
        IWbemContext pCtx,
        [NativeTypeName("BSTR *")] ushort** strText
    )
    {
        return (
            (delegate* unmanaged<
                IWbemObjectTextSrc,
                int,
                IWbemClassObject,
                uint,
                IWbemContext,
                ushort**,
                int>)((*lpVtbl)[3])
        )(this, lFlags, pObj, uObjTextFormat, pCtx, strText);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT CreateFromText(
        [NativeTypeName("long")] int lFlags,
        [NativeTypeName("BSTR")] ushort* strText,
        [NativeTypeName("ULONG")] uint uObjTextFormat,
        IWbemContext pCtx,
        IWbemClassObject* pNewObj
    )
    {
        return (
            (delegate* unmanaged<
                IWbemObjectTextSrc,
                int,
                ushort*,
                uint,
                IWbemContext,
                IWbemClassObject*,
                int>)((*lpVtbl)[4])
        )(this, lFlags, strText, uObjTextFormat, pCtx, pNewObj);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetText(
            [NativeTypeName("long")] int lFlags,
            IWbemClassObject pObj,
            [NativeTypeName("ULONG")] uint uObjTextFormat,
            IWbemContext pCtx,
            [NativeTypeName("BSTR *")] ushort** strText
        );

        [VtblIndex(4)]
        HRESULT CreateFromText(
            [NativeTypeName("long")] int lFlags,
            [NativeTypeName("BSTR")] ushort* strText,
            [NativeTypeName("ULONG")] uint uObjTextFormat,
            IWbemContext pCtx,
            IWbemClassObject* pNewObj
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
            "HRESULT (long, IWbemClassObject *, ULONG, IWbemContext *, BSTR *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            int,
            IWbemClassObject,
            uint,
            IWbemContext,
            ushort**,
            int> GetText;

        [NativeTypeName(
            "HRESULT (long, BSTR, ULONG, IWbemContext *, IWbemClassObject **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            int,
            ushort*,
            uint,
            IWbemContext,
            IWbemClassObject*,
            int> CreateFromText;
    }

    /// <summary>Initializes a new instance of the <see cref = "IWbemObjectTextSrc"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IWbemObjectTextSrc(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IWbemObjectTextSrc"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IWbemObjectTextSrc(Silk.NET.Windows.IUnknown value)
    {
        return new IWbemObjectTextSrc(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IWbemObjectTextSrc"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IWbemObjectTextSrc"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IWbemObjectTextSrc value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
