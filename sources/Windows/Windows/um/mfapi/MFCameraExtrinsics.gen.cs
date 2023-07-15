// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;
/// <include file='MFCameraExtrinsics.xml' path='doc/member[@name="MFCameraExtrinsics"]/*'/>
[SupportedOSPlatform("windows10.0")]
public partial struct MFCameraExtrinsics
{
    /// <include file='MFCameraExtrinsics.xml' path='doc/member[@name="MFCameraExtrinsics.TransformCount"]/*'/>
    [NativeTypeName("UINT32")]
    public uint TransformCount;
    /// <include file='MFCameraExtrinsics.xml' path='doc/member[@name="MFCameraExtrinsics.CalibratedTransforms"]/*'/>
    [NativeTypeName("MFCameraExtrinsic_CalibratedTransform[1]")]
    public _CalibratedTransforms_e__FixedBuffer CalibratedTransforms;
    /// <include file='_CalibratedTransforms_e__FixedBuffer.xml' path='doc/member[@name="_CalibratedTransforms_e__FixedBuffer"]/*'/>
    public partial struct _CalibratedTransforms_e__FixedBuffer
    {
        public MFCameraExtrinsic_CalibratedTransform e0;
        [UnscopedRef]
        public ref MFCameraExtrinsic_CalibratedTransform this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan(int.MaxValue)[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<MFCameraExtrinsic_CalibratedTransform> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}