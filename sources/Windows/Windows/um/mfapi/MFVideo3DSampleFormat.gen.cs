// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;
/// <include file='MFVideo3DSampleFormat.xml' path='doc/member[@name="MFVideo3DSampleFormat"]/*'/>
[SupportedOSPlatform("windows6.2")]
public enum MFVideo3DSampleFormat
{
    /// <include file='MFVideo3DSampleFormat.xml' path='doc/member[@name="MFVideo3DSampleFormat.MFSampleExtension_3DVideo_MultiView"]/*'/>
    MFSampleExtension_3DVideo_MultiView = 1,
    /// <include file='MFVideo3DSampleFormat.xml' path='doc/member[@name="MFVideo3DSampleFormat.MFSampleExtension_3DVideo_Packed"]/*'/>
    MFSampleExtension_3DVideo_Packed = 0,
}