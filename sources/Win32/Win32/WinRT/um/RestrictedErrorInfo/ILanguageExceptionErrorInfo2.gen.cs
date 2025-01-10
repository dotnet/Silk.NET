// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/RestrictedErrorInfo.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("5746E5C4-5B97-424C-B620-2822915734DD")]
[NativeTypeName("struct ILanguageExceptionErrorInfo2 : ILanguageExceptionErrorInfo")]
[NativeInheritance("ILanguageExceptionErrorInfo")]
[SupportedOSPlatform("windows10.0.15063.0")]
public unsafe partial struct ILanguageExceptionErrorInfo2
    : ILanguageExceptionErrorInfo2.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ILanguageExceptionErrorInfo2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<ILanguageExceptionErrorInfo2, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ILanguageExceptionErrorInfo2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ILanguageExceptionErrorInfo2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetLanguageException(IUnknown* languageException)
    {
        return ((delegate* unmanaged<ILanguageExceptionErrorInfo2, IUnknown*, int>)((*lpVtbl)[3]))(
            this,
            languageException
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetPreviousLanguageExceptionErrorInfo(
        ILanguageExceptionErrorInfo2* previousLanguageExceptionErrorInfo
    )
    {
        return (
            (delegate* unmanaged<ILanguageExceptionErrorInfo2, ILanguageExceptionErrorInfo2*, int>)(
                (*lpVtbl)[4]
            )
        )(this, previousLanguageExceptionErrorInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT CapturePropagationContext(IUnknown languageException)
    {
        return ((delegate* unmanaged<ILanguageExceptionErrorInfo2, IUnknown, int>)((*lpVtbl)[5]))(
            this,
            languageException
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetPropagationContextHead(
        ILanguageExceptionErrorInfo2* propagatedLanguageExceptionErrorInfoHead
    )
    {
        return (
            (delegate* unmanaged<ILanguageExceptionErrorInfo2, ILanguageExceptionErrorInfo2*, int>)(
                (*lpVtbl)[6]
            )
        )(this, propagatedLanguageExceptionErrorInfoHead);
    }

    public interface Interface : ILanguageExceptionErrorInfo.Interface
    {
        [VtblIndex(4)]
        HRESULT GetPreviousLanguageExceptionErrorInfo(
            ILanguageExceptionErrorInfo2* previousLanguageExceptionErrorInfo
        );

        [VtblIndex(5)]
        HRESULT CapturePropagationContext(IUnknown languageException);

        [VtblIndex(6)]
        HRESULT GetPropagationContextHead(
            ILanguageExceptionErrorInfo2* propagatedLanguageExceptionErrorInfoHead
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

        [NativeTypeName("HRESULT (IUnknown **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown*, int> GetLanguageException;

        [NativeTypeName("HRESULT (ILanguageExceptionErrorInfo2 **) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            ILanguageExceptionErrorInfo2*,
            int> GetPreviousLanguageExceptionErrorInfo;

        [NativeTypeName("HRESULT (IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown, int> CapturePropagationContext;

        [NativeTypeName("HRESULT (ILanguageExceptionErrorInfo2 **) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            ILanguageExceptionErrorInfo2*,
            int> GetPropagationContextHead;
    }

    /// <summary>Initializes a new instance of the <see cref = "ILanguageExceptionErrorInfo2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ILanguageExceptionErrorInfo2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.ILanguageExceptionErrorInfo"/> to <see cref = "ILanguageExceptionErrorInfo2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.ILanguageExceptionErrorInfo"/> instance to be converted </param>
    public static explicit operator ILanguageExceptionErrorInfo2(
        Silk.NET.WinRT.ILanguageExceptionErrorInfo value
    )
    {
        return new ILanguageExceptionErrorInfo2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ILanguageExceptionErrorInfo2"/> to <see cref = "Silk.NET.WinRT.ILanguageExceptionErrorInfo"/>.</summary>
    /// <param name = "value">The <see cref = "ILanguageExceptionErrorInfo2"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.ILanguageExceptionErrorInfo(
        ILanguageExceptionErrorInfo2 value
    )
    {
        return new Silk.NET.WinRT.ILanguageExceptionErrorInfo(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ILanguageExceptionErrorInfo2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ILanguageExceptionErrorInfo2(Silk.NET.Windows.IUnknown value)
    {
        return new ILanguageExceptionErrorInfo2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ILanguageExceptionErrorInfo2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ILanguageExceptionErrorInfo2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ILanguageExceptionErrorInfo2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
