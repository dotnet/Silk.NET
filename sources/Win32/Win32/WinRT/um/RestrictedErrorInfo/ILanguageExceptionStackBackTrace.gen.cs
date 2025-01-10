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

[Guid("CBE53FB5-F967-4258-8D34-42F5E25833DE")]
[NativeTypeName("struct ILanguageExceptionStackBackTrace : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0.15063.0")]
public unsafe partial struct ILanguageExceptionStackBackTrace
    : ILanguageExceptionStackBackTrace.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ILanguageExceptionStackBackTrace));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<ILanguageExceptionStackBackTrace, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ILanguageExceptionStackBackTrace, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ILanguageExceptionStackBackTrace, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetStackBackTrace(
        [NativeTypeName("ULONG")] uint maxFramesToCapture,
        [NativeTypeName("UINT_PTR[]")] nuint* stackBackTrace,
        [NativeTypeName("ULONG *")] uint* framesCaptured
    )
    {
        return (
            (delegate* unmanaged<ILanguageExceptionStackBackTrace, uint, nuint*, uint*, int>)(
                (*lpVtbl)[3]
            )
        )(this, maxFramesToCapture, stackBackTrace, framesCaptured);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetStackBackTrace(
            [NativeTypeName("ULONG")] uint maxFramesToCapture,
            [NativeTypeName("UINT_PTR[]")] nuint* stackBackTrace,
            [NativeTypeName("ULONG *")] uint* framesCaptured
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

        [NativeTypeName("HRESULT (ULONG, UINT_PTR *, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, nuint*, uint*, int> GetStackBackTrace;
    }

    /// <summary>Initializes a new instance of the <see cref = "ILanguageExceptionStackBackTrace"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ILanguageExceptionStackBackTrace(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ILanguageExceptionStackBackTrace"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ILanguageExceptionStackBackTrace(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new ILanguageExceptionStackBackTrace(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ILanguageExceptionStackBackTrace"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ILanguageExceptionStackBackTrace"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        ILanguageExceptionStackBackTrace value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
