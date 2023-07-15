// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnetwk.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='UNIVERSAL_NAME_INFOA.xml' path='doc/member[@name="UNIVERSAL_NAME_INFOA"]/*'/>
public unsafe partial struct UNIVERSAL_NAME_INFOA
{
    /// <include file='UNIVERSAL_NAME_INFOA.xml' path='doc/member[@name="UNIVERSAL_NAME_INFOA.lpUniversalName"]/*'/>
    [NativeTypeName("LPSTR")]
    public sbyte* lpUniversalName;
}