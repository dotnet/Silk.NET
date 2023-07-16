// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='STORAGE_PREDICT_FAILURE.xml' path='doc/member[@name="STORAGE_PREDICT_FAILURE"]/*'/>
public unsafe partial struct STORAGE_PREDICT_FAILURE
{
    /// <include file='STORAGE_PREDICT_FAILURE.xml' path='doc/member[@name="STORAGE_PREDICT_FAILURE.PredictFailure"]/*'/>
    [NativeTypeName("DWORD")]
    public uint PredictFailure;
    /// <include file='STORAGE_PREDICT_FAILURE.xml' path='doc/member[@name="STORAGE_PREDICT_FAILURE.VendorSpecific"]/*'/>
    [NativeTypeName("BYTE[512]")]
    public fixed byte VendorSpecific[512];
}