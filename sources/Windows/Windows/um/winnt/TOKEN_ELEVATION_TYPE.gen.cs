// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='TOKEN_ELEVATION_TYPE.xml' path='doc/member[@name="TOKEN_ELEVATION_TYPE"]/*'/>
public enum TOKEN_ELEVATION_TYPE
{
    /// <include file='TOKEN_ELEVATION_TYPE.xml' path='doc/member[@name="TOKEN_ELEVATION_TYPE.TokenElevationTypeDefault"]/*'/>
    TokenElevationTypeDefault = 1,
    /// <include file='TOKEN_ELEVATION_TYPE.xml' path='doc/member[@name="TOKEN_ELEVATION_TYPE.TokenElevationTypeFull"]/*'/>
    TokenElevationTypeFull,
    /// <include file='TOKEN_ELEVATION_TYPE.xml' path='doc/member[@name="TOKEN_ELEVATION_TYPE.TokenElevationTypeLimited"]/*'/>
    TokenElevationTypeLimited,
}