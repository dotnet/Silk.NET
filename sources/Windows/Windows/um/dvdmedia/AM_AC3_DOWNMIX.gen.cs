// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dvdmedia.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='AM_AC3_DOWNMIX.xml' path='doc/member[@name="AM_AC3_DOWNMIX"]/*'/>
public partial struct AM_AC3_DOWNMIX
{
    /// <include file='AM_AC3_DOWNMIX.xml' path='doc/member[@name="AM_AC3_DOWNMIX.fDownMix"]/*'/>
    public BOOL fDownMix;
    /// <include file='AM_AC3_DOWNMIX.xml' path='doc/member[@name="AM_AC3_DOWNMIX.fDolbySurround"]/*'/>
    public BOOL fDolbySurround;
}