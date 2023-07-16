// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='VMRDeinterlacePrefs.xml' path='doc/member[@name="VMRDeinterlacePrefs"]/*'/>
public enum VMRDeinterlacePrefs
{
    /// <include file='VMRDeinterlacePrefs.xml' path='doc/member[@name="VMRDeinterlacePrefs.DeinterlacePref_NextBest"]/*'/>
    DeinterlacePref_NextBest = 0x1,
    /// <include file='VMRDeinterlacePrefs.xml' path='doc/member[@name="VMRDeinterlacePrefs.DeinterlacePref_BOB"]/*'/>
    DeinterlacePref_BOB = 0x2,
    /// <include file='VMRDeinterlacePrefs.xml' path='doc/member[@name="VMRDeinterlacePrefs.DeinterlacePref_Weave"]/*'/>
    DeinterlacePref_Weave = 0x4,
    /// <include file='VMRDeinterlacePrefs.xml' path='doc/member[@name="VMRDeinterlacePrefs.DeinterlacePref_Mask"]/*'/>
    DeinterlacePref_Mask = 0x7,
}