// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='eAVEncVideoChromaResolution.xml' path='doc/member[@name="eAVEncVideoChromaResolution"]/*'/>
public enum eAVEncVideoChromaResolution
{
    /// <include file='eAVEncVideoChromaResolution.xml' path='doc/member[@name="eAVEncVideoChromaResolution.eAVEncVideoChromaResolution_SameAsSource"]/*'/>
    eAVEncVideoChromaResolution_SameAsSource = 0,
    /// <include file='eAVEncVideoChromaResolution.xml' path='doc/member[@name="eAVEncVideoChromaResolution.eAVEncVideoChromaResolution_444"]/*'/>
    eAVEncVideoChromaResolution_444 = 1,
    /// <include file='eAVEncVideoChromaResolution.xml' path='doc/member[@name="eAVEncVideoChromaResolution.eAVEncVideoChromaResolution_422"]/*'/>
    eAVEncVideoChromaResolution_422 = 2,
    /// <include file='eAVEncVideoChromaResolution.xml' path='doc/member[@name="eAVEncVideoChromaResolution.eAVEncVideoChromaResolution_420"]/*'/>
    eAVEncVideoChromaResolution_420 = 3,
    /// <include file='eAVEncVideoChromaResolution.xml' path='doc/member[@name="eAVEncVideoChromaResolution.eAVEncVideoChromaResolution_411"]/*'/>
    eAVEncVideoChromaResolution_411 = 4,
}