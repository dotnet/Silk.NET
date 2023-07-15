// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;
/// <include file='MFVideo3DFormat.xml' path='doc/member[@name="MFVideo3DFormat"]/*'/>
[SupportedOSPlatform("windows6.2")]
public enum MFVideo3DFormat
{
    /// <include file='MFVideo3DFormat.xml' path='doc/member[@name="MFVideo3DFormat.MFVideo3DSampleFormat_BaseView"]/*'/>
    MFVideo3DSampleFormat_BaseView = 0,
    /// <include file='MFVideo3DFormat.xml' path='doc/member[@name="MFVideo3DFormat.MFVideo3DSampleFormat_MultiView"]/*'/>
    MFVideo3DSampleFormat_MultiView = 1,
    /// <include file='MFVideo3DFormat.xml' path='doc/member[@name="MFVideo3DFormat.MFVideo3DSampleFormat_Packed_LeftRight"]/*'/>
    MFVideo3DSampleFormat_Packed_LeftRight = 2,
    /// <include file='MFVideo3DFormat.xml' path='doc/member[@name="MFVideo3DFormat.MFVideo3DSampleFormat_Packed_TopBottom"]/*'/>
    MFVideo3DSampleFormat_Packed_TopBottom = 3,
}