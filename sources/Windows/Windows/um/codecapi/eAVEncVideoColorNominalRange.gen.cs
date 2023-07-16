// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='eAVEncVideoColorNominalRange.xml' path='doc/member[@name="eAVEncVideoColorNominalRange"]/*'/>
public enum eAVEncVideoColorNominalRange
{
    /// <include file='eAVEncVideoColorNominalRange.xml' path='doc/member[@name="eAVEncVideoColorNominalRange.eAVEncVideoColorNominalRange_SameAsSource"]/*'/>
    eAVEncVideoColorNominalRange_SameAsSource = 0,
    /// <include file='eAVEncVideoColorNominalRange.xml' path='doc/member[@name="eAVEncVideoColorNominalRange.eAVEncVideoColorNominalRange_0_255"]/*'/>
    eAVEncVideoColorNominalRange_0_255 = 1,
    /// <include file='eAVEncVideoColorNominalRange.xml' path='doc/member[@name="eAVEncVideoColorNominalRange.eAVEncVideoColorNominalRange_16_235"]/*'/>
    eAVEncVideoColorNominalRange_16_235 = 2,
    /// <include file='eAVEncVideoColorNominalRange.xml' path='doc/member[@name="eAVEncVideoColorNominalRange.eAVEncVideoColorNominalRange_48_208"]/*'/>
    eAVEncVideoColorNominalRange_48_208 = 3,
}