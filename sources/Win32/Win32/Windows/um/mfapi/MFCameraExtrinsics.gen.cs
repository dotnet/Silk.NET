// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[SupportedOSPlatform("windows10.0")]
public partial struct MFCameraExtrinsics
{
    [NativeTypeName("UINT32")]
    public uint TransformCount;

    [NativeTypeName("MFCameraExtrinsic_CalibratedTransform[1]")]
    public _CalibratedTransforms_e__FixedBuffer CalibratedTransforms;

    public partial struct _CalibratedTransforms_e__FixedBuffer
    {
        public MFCameraExtrinsic_CalibratedTransform e0;

        [UnscopedRef]
        public ref MFCameraExtrinsic_CalibratedTransform this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref Unsafe.Add(ref e0, index); }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<MFCameraExtrinsic_CalibratedTransform> AsSpan(int length) =>
            MemoryMarshal.CreateSpan(ref e0, length);
    }
}
