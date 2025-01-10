// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.storage.streams.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("905A0FE2-BC53-11DF-8C49-001E4FC686DA")]
[NativeTypeName("struct IInputStream : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IInputStream : IInputStream.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IInputStream));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IInputStream, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IInputStream, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IInputStream, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IInputStream, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IInputStream, HSTRING*, int>)((*lpVtbl)[4]))(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IInputStream, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT ReadAsync(
        [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer buffer,
        [NativeTypeName("UINT32")] uint count,
        [NativeTypeName("ABI::Windows::Storage::Streams::InputStreamOptions")]
            InputStreamOptions options,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CStorage__CStreams__CIBuffer_UINT32_t **"
        )]
            IAsyncOperationWithProgress<IntPtr, uint>** operation
    )
    {
        return (
            (delegate* unmanaged<
                IInputStream,
                IBuffer,
                uint,
                InputStreamOptions,
                IAsyncOperationWithProgress<IntPtr, uint>**,
                int>)((*lpVtbl)[6])
        )(this, buffer, count, options, operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT ReadAsync(
            [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer buffer,
            [NativeTypeName("UINT32")] uint count,
            [NativeTypeName("ABI::Windows::Storage::Streams::InputStreamOptions")]
                InputStreamOptions options,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CStorage__CStreams__CIBuffer_UINT32_t **"
            )]
                IAsyncOperationWithProgress<IntPtr, uint>** operation
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

        [NativeTypeName("HRESULT (ULONG *, IID **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, Guid**, int> GetIids;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> GetRuntimeClassName;

        [NativeTypeName("HRESULT (TrustLevel *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TrustLevel*, int> GetTrustLevel;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Streams::IBuffer *, UINT32, ABI::Windows::Storage::Streams::InputStreamOptions, ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CStorage__CStreams__CIBuffer_UINT32_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IBuffer,
            uint,
            InputStreamOptions,
            IAsyncOperationWithProgress<IntPtr, uint>**,
            int> ReadAsync;
    }

    /// <summary>Initializes a new instance of the <see cref = "IInputStream"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IInputStream(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IInputStream"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IInputStream(Silk.NET.WinRT.IInspectable value)
    {
        return new IInputStream(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IInputStream"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IInputStream"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IInputStream value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IInputStream"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IInputStream(Silk.NET.Windows.IUnknown value)
    {
        return new IInputStream(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IInputStream"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IInputStream"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IInputStream value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
