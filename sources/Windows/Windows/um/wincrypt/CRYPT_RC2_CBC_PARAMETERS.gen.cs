// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='CRYPT_RC2_CBC_PARAMETERS.xml' path='doc/member[@name="CRYPT_RC2_CBC_PARAMETERS"]/*'/>
public unsafe partial struct CRYPT_RC2_CBC_PARAMETERS
{
    /// <include file='CRYPT_RC2_CBC_PARAMETERS.xml' path='doc/member[@name="CRYPT_RC2_CBC_PARAMETERS.dwVersion"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwVersion;
    /// <include file='CRYPT_RC2_CBC_PARAMETERS.xml' path='doc/member[@name="CRYPT_RC2_CBC_PARAMETERS.fIV"]/*'/>
    public BOOL fIV;
    /// <include file='CRYPT_RC2_CBC_PARAMETERS.xml' path='doc/member[@name="CRYPT_RC2_CBC_PARAMETERS.rgbIV"]/*'/>
    [NativeTypeName("BYTE[8]")]
    public fixed byte rgbIV[8];
}