// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='MFVideoPadFlags.xml' path='doc/member[@name="MFVideoPadFlags"]/*'/>
public enum MFVideoPadFlags
{
    /// <include file='MFVideoPadFlags.xml' path='doc/member[@name="MFVideoPadFlags.MFVideoPadFlag_PAD_TO_None"]/*'/>
    MFVideoPadFlag_PAD_TO_None = 0,
    /// <include file='MFVideoPadFlags.xml' path='doc/member[@name="MFVideoPadFlags.MFVideoPadFlag_PAD_TO_4x3"]/*'/>
    MFVideoPadFlag_PAD_TO_4x3 = 1,
    /// <include file='MFVideoPadFlags.xml' path='doc/member[@name="MFVideoPadFlags.MFVideoPadFlag_PAD_TO_16x9"]/*'/>
    MFVideoPadFlag_PAD_TO_16x9 = 2,
}