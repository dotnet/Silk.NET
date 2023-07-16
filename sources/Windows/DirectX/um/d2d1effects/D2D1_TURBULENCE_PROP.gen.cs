// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1effects.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.DirectX;
/// <include file='D2D1_TURBULENCE_PROP.xml' path='doc/member[@name="D2D1_TURBULENCE_PROP"]/*'/>
public enum D2D1_TURBULENCE_PROP
{
    /// <include file='D2D1_TURBULENCE_PROP.xml' path='doc/member[@name="D2D1_TURBULENCE_PROP.D2D1_TURBULENCE_PROP_OFFSET"]/*'/>
    D2D1_TURBULENCE_PROP_OFFSET = 0,
    /// <include file='D2D1_TURBULENCE_PROP.xml' path='doc/member[@name="D2D1_TURBULENCE_PROP.D2D1_TURBULENCE_PROP_SIZE"]/*'/>
    D2D1_TURBULENCE_PROP_SIZE = 1,
    /// <include file='D2D1_TURBULENCE_PROP.xml' path='doc/member[@name="D2D1_TURBULENCE_PROP.D2D1_TURBULENCE_PROP_BASE_FREQUENCY"]/*'/>
    D2D1_TURBULENCE_PROP_BASE_FREQUENCY = 2,
    /// <include file='D2D1_TURBULENCE_PROP.xml' path='doc/member[@name="D2D1_TURBULENCE_PROP.D2D1_TURBULENCE_PROP_NUM_OCTAVES"]/*'/>
    D2D1_TURBULENCE_PROP_NUM_OCTAVES = 3,
    /// <include file='D2D1_TURBULENCE_PROP.xml' path='doc/member[@name="D2D1_TURBULENCE_PROP.D2D1_TURBULENCE_PROP_SEED"]/*'/>
    D2D1_TURBULENCE_PROP_SEED = 4,
    /// <include file='D2D1_TURBULENCE_PROP.xml' path='doc/member[@name="D2D1_TURBULENCE_PROP.D2D1_TURBULENCE_PROP_NOISE"]/*'/>
    D2D1_TURBULENCE_PROP_NOISE = 5,
    /// <include file='D2D1_TURBULENCE_PROP.xml' path='doc/member[@name="D2D1_TURBULENCE_PROP.D2D1_TURBULENCE_PROP_STITCHABLE"]/*'/>
    D2D1_TURBULENCE_PROP_STITCHABLE = 6,
    /// <include file='D2D1_TURBULENCE_PROP.xml' path='doc/member[@name="D2D1_TURBULENCE_PROP.D2D1_TURBULENCE_PROP_FORCE_DWORD"]/*'/>
    D2D1_TURBULENCE_PROP_FORCE_DWORD = unchecked((int)(0xffffffff)),
}