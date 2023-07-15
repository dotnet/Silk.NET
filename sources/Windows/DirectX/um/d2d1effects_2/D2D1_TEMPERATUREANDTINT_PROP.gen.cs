// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1effects_2.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.DirectX;
/// <include file='D2D1_TEMPERATUREANDTINT_PROP.xml' path='doc/member[@name="D2D1_TEMPERATUREANDTINT_PROP"]/*'/>
public enum D2D1_TEMPERATUREANDTINT_PROP
{
    /// <include file='D2D1_TEMPERATUREANDTINT_PROP.xml' path='doc/member[@name="D2D1_TEMPERATUREANDTINT_PROP.D2D1_TEMPERATUREANDTINT_PROP_TEMPERATURE"]/*'/>
    D2D1_TEMPERATUREANDTINT_PROP_TEMPERATURE = 0,
    /// <include file='D2D1_TEMPERATUREANDTINT_PROP.xml' path='doc/member[@name="D2D1_TEMPERATUREANDTINT_PROP.D2D1_TEMPERATUREANDTINT_PROP_TINT"]/*'/>
    D2D1_TEMPERATUREANDTINT_PROP_TINT = 1,
    /// <include file='D2D1_TEMPERATUREANDTINT_PROP.xml' path='doc/member[@name="D2D1_TEMPERATUREANDTINT_PROP.D2D1_TEMPERATUREANDTINT_PROP_FORCE_DWORD"]/*'/>
    D2D1_TEMPERATUREANDTINT_PROP_FORCE_DWORD = unchecked((int)(0xffffffff)),
}