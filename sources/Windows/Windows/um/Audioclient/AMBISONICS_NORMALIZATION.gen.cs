// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Audioclient.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='AMBISONICS_NORMALIZATION.xml' path='doc/member[@name="AMBISONICS_NORMALIZATION"]/*'/>
public enum AMBISONICS_NORMALIZATION
{
    /// <include file='AMBISONICS_NORMALIZATION.xml' path='doc/member[@name="AMBISONICS_NORMALIZATION.AMBISONICS_NORMALIZATION_SN3D"]/*'/>
    AMBISONICS_NORMALIZATION_SN3D = 0,
    /// <include file='AMBISONICS_NORMALIZATION.xml' path='doc/member[@name="AMBISONICS_NORMALIZATION.AMBISONICS_NORMALIZATION_N3D"]/*'/>
    AMBISONICS_NORMALIZATION_N3D = (AMBISONICS_NORMALIZATION_SN3D + 1),
}