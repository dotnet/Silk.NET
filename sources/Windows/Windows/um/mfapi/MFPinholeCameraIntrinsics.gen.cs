// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;
/// <include file='MFPinholeCameraIntrinsics.xml' path='doc/member[@name="MFPinholeCameraIntrinsics"]/*'/>
[SupportedOSPlatform("windows10.0")]
public partial struct MFPinholeCameraIntrinsics
{
    /// <include file='MFPinholeCameraIntrinsics.xml' path='doc/member[@name="MFPinholeCameraIntrinsics.IntrinsicModelCount"]/*'/>
    [NativeTypeName("UINT32")]
    public uint IntrinsicModelCount;
    /// <include file='MFPinholeCameraIntrinsics.xml' path='doc/member[@name="MFPinholeCameraIntrinsics.IntrinsicModels"]/*'/>
    [NativeTypeName("MFPinholeCameraIntrinsic_IntrinsicModel[1]")]
    public _IntrinsicModels_e__FixedBuffer IntrinsicModels;
    /// <include file='_IntrinsicModels_e__FixedBuffer.xml' path='doc/member[@name="_IntrinsicModels_e__FixedBuffer"]/*'/>
    public partial struct _IntrinsicModels_e__FixedBuffer
    {
        public MFPinholeCameraIntrinsic_IntrinsicModel e0;
        [UnscopedRef]
        public ref MFPinholeCameraIntrinsic_IntrinsicModel this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan(int.MaxValue)[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<MFPinholeCameraIntrinsic_IntrinsicModel> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}