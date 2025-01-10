// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("8FC6D974-C81E-4098-93C5-0147F61ED4D3")]
[NativeTypeName("struct ISpRecognizer2 : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ISpRecognizer2 : ISpRecognizer2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpRecognizer2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISpRecognizer2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ISpRecognizer2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISpRecognizer2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT EmulateRecognitionEx(
        ISpPhrase pPhrase,
        [NativeTypeName("DWORD")] uint dwCompareFlags
    )
    {
        return ((delegate* unmanaged<ISpRecognizer2, ISpPhrase, uint, int>)((*lpVtbl)[3]))(
            this,
            pPhrase,
            dwCompareFlags
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetTrainingState(BOOL fDoingTraining, BOOL fAdaptFromTrainingData)
    {
        return ((delegate* unmanaged<ISpRecognizer2, BOOL, BOOL, int>)((*lpVtbl)[4]))(
            this,
            fDoingTraining,
            fAdaptFromTrainingData
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT ResetAcousticModelAdaptation()
    {
        return ((delegate* unmanaged<ISpRecognizer2, int>)((*lpVtbl)[5]))(this);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT EmulateRecognitionEx(
            ISpPhrase pPhrase,
            [NativeTypeName("DWORD")] uint dwCompareFlags
        );

        [VtblIndex(4)]
        HRESULT SetTrainingState(BOOL fDoingTraining, BOOL fAdaptFromTrainingData);

        [VtblIndex(5)]
        HRESULT ResetAcousticModelAdaptation();
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

        [NativeTypeName("HRESULT (ISpPhrase *, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISpPhrase, uint, int> EmulateRecognitionEx;

        [NativeTypeName("HRESULT (BOOL, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, BOOL, int> SetTrainingState;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> ResetAcousticModelAdaptation;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISpRecognizer2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISpRecognizer2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISpRecognizer2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISpRecognizer2(Silk.NET.Windows.IUnknown value)
    {
        return new ISpRecognizer2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpRecognizer2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISpRecognizer2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISpRecognizer2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
