// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("3B9C7E7A-6EEE-4DED-9092-11657279ADBE")]
[NativeTypeName("struct ISpeechTextSelectionInformation : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct ISpeechTextSelectionInformation
    : ISpeechTextSelectionInformation.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpeechTextSelectionInformation));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<ISpeechTextSelectionInformation, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISpeechTextSelectionInformation, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISpeechTextSelectionInformation, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<ISpeechTextSelectionInformation, uint*, int>)((*lpVtbl)[3]))(
            this,
            pctinfo
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo* ppTInfo)
    {
        return (
            (delegate* unmanaged<ISpeechTextSelectionInformation, uint, uint, ITypeInfo*, int>)(
                (*lpVtbl)[4]
            )
        )(this, iTInfo, lcid, ppTInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames(
        [NativeTypeName("const IID &")] Guid* riid,
        [NativeTypeName("LPOLESTR *")] ushort** rgszNames,
        uint cNames,
        [NativeTypeName("LCID")] uint lcid,
        [NativeTypeName("DISPID *")] int* rgDispId
    )
    {
        return (
            (delegate* unmanaged<
                ISpeechTextSelectionInformation,
                Guid*,
                ushort**,
                uint,
                uint,
                int*,
                int>)((*lpVtbl)[5])
        )(this, riid, rgszNames, cNames, lcid, rgDispId);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke(
        [NativeTypeName("DISPID")] int dispIdMember,
        [NativeTypeName("const IID &")] Guid* riid,
        [NativeTypeName("LCID")] uint lcid,
        [NativeTypeName("WORD")] ushort wFlags,
        DISPPARAMS* pDispParams,
        VARIANT* pVarResult,
        EXCEPINFO* pExcepInfo,
        uint* puArgErr
    )
    {
        return (
            (delegate* unmanaged<
                ISpeechTextSelectionInformation,
                int,
                Guid*,
                uint,
                ushort,
                DISPPARAMS*,
                VARIANT*,
                EXCEPINFO*,
                uint*,
                int>)((*lpVtbl)[6])
        )(this, dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_ActiveOffset([NativeTypeName("long")] int ActiveOffset)
    {
        return ((delegate* unmanaged<ISpeechTextSelectionInformation, int, int>)((*lpVtbl)[7]))(
            this,
            ActiveOffset
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_ActiveOffset([NativeTypeName("long *")] int* ActiveOffset)
    {
        return ((delegate* unmanaged<ISpeechTextSelectionInformation, int*, int>)((*lpVtbl)[8]))(
            this,
            ActiveOffset
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_ActiveLength([NativeTypeName("long")] int ActiveLength)
    {
        return ((delegate* unmanaged<ISpeechTextSelectionInformation, int, int>)((*lpVtbl)[9]))(
            this,
            ActiveLength
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_ActiveLength([NativeTypeName("long *")] int* ActiveLength)
    {
        return ((delegate* unmanaged<ISpeechTextSelectionInformation, int*, int>)((*lpVtbl)[10]))(
            this,
            ActiveLength
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_SelectionOffset([NativeTypeName("long")] int SelectionOffset)
    {
        return ((delegate* unmanaged<ISpeechTextSelectionInformation, int, int>)((*lpVtbl)[11]))(
            this,
            SelectionOffset
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_SelectionOffset([NativeTypeName("long *")] int* SelectionOffset)
    {
        return ((delegate* unmanaged<ISpeechTextSelectionInformation, int*, int>)((*lpVtbl)[12]))(
            this,
            SelectionOffset
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_SelectionLength([NativeTypeName("long")] int SelectionLength)
    {
        return ((delegate* unmanaged<ISpeechTextSelectionInformation, int, int>)((*lpVtbl)[13]))(
            this,
            SelectionLength
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_SelectionLength([NativeTypeName("long *")] int* SelectionLength)
    {
        return ((delegate* unmanaged<ISpeechTextSelectionInformation, int*, int>)((*lpVtbl)[14]))(
            this,
            SelectionLength
        );
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT put_ActiveOffset([NativeTypeName("long")] int ActiveOffset);

        [VtblIndex(8)]
        HRESULT get_ActiveOffset([NativeTypeName("long *")] int* ActiveOffset);

        [VtblIndex(9)]
        HRESULT put_ActiveLength([NativeTypeName("long")] int ActiveLength);

        [VtblIndex(10)]
        HRESULT get_ActiveLength([NativeTypeName("long *")] int* ActiveLength);

        [VtblIndex(11)]
        HRESULT put_SelectionOffset([NativeTypeName("long")] int SelectionOffset);

        [VtblIndex(12)]
        HRESULT get_SelectionOffset([NativeTypeName("long *")] int* SelectionOffset);

        [VtblIndex(13)]
        HRESULT put_SelectionLength([NativeTypeName("long")] int SelectionLength);

        [VtblIndex(14)]
        HRESULT get_SelectionLength([NativeTypeName("long *")] int* SelectionLength);
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

        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetTypeInfoCount;

        [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, ITypeInfo*, int> GetTypeInfo;

        [NativeTypeName(
            "HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Guid*, ushort**, uint, uint, int*, int> GetIDsOfNames;

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
            int> Invoke;

        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_ActiveOffset;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_ActiveOffset;

        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_ActiveLength;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_ActiveLength;

        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_SelectionOffset;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_SelectionOffset;

        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_SelectionLength;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_SelectionLength;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISpeechTextSelectionInformation"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISpeechTextSelectionInformation(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IDispatch"/> to <see cref = "ISpeechTextSelectionInformation"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IDispatch"/> instance to be converted </param>
    public static explicit operator ISpeechTextSelectionInformation(
        Silk.NET.Windows.IDispatch value
    )
    {
        return new ISpeechTextSelectionInformation(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpeechTextSelectionInformation"/> to <see cref = "Silk.NET.Windows.IDispatch"/>.</summary>
    /// <param name = "value">The <see cref = "ISpeechTextSelectionInformation"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IDispatch(
        ISpeechTextSelectionInformation value
    )
    {
        return new Silk.NET.Windows.IDispatch(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISpeechTextSelectionInformation"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISpeechTextSelectionInformation(Silk.NET.Windows.IUnknown value)
    {
        return new ISpeechTextSelectionInformation(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpeechTextSelectionInformation"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISpeechTextSelectionInformation"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISpeechTextSelectionInformation value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
