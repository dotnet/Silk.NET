// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;
/// <include file='MFFrameSourceTypes.xml' path='doc/member[@name="MFFrameSourceTypes"]/*'/>
[SupportedOSPlatform("windows10.0.14393.0")]
public enum MFFrameSourceTypes
{
    /// <include file='MFFrameSourceTypes.xml' path='doc/member[@name="MFFrameSourceTypes.MFFrameSourceTypes_Color"]/*'/>
    MFFrameSourceTypes_Color = 0x0001,
    /// <include file='MFFrameSourceTypes.xml' path='doc/member[@name="MFFrameSourceTypes.MFFrameSourceTypes_Infrared"]/*'/>
    MFFrameSourceTypes_Infrared = 0x0002,
    /// <include file='MFFrameSourceTypes.xml' path='doc/member[@name="MFFrameSourceTypes.MFFrameSourceTypes_Depth"]/*'/>
    MFFrameSourceTypes_Depth = 0x0004,
    /// <include file='MFFrameSourceTypes.xml' path='doc/member[@name="MFFrameSourceTypes.MFFrameSourceTypes_Image"]/*'/>
    MFFrameSourceTypes_Image = 0x0008,
    /// <include file='MFFrameSourceTypes.xml' path='doc/member[@name="MFFrameSourceTypes.MFFrameSourceTypes_Custom"]/*'/>
    MFFrameSourceTypes_Custom = 0x0080,
}