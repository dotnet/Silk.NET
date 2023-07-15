// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnetwk.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='REMOTE_NAME_INFOA.xml' path='doc/member[@name="REMOTE_NAME_INFOA"]/*'/>
public unsafe partial struct REMOTE_NAME_INFOA
{
    /// <include file='REMOTE_NAME_INFOA.xml' path='doc/member[@name="REMOTE_NAME_INFOA.lpUniversalName"]/*'/>
    [NativeTypeName("LPSTR")]
    public sbyte* lpUniversalName;
    /// <include file='REMOTE_NAME_INFOA.xml' path='doc/member[@name="REMOTE_NAME_INFOA.lpConnectionName"]/*'/>
    [NativeTypeName("LPSTR")]
    public sbyte* lpConnectionName;
    /// <include file='REMOTE_NAME_INFOA.xml' path='doc/member[@name="REMOTE_NAME_INFOA.lpRemainingPath"]/*'/>
    [NativeTypeName("LPSTR")]
    public sbyte* lpRemainingPath;
}