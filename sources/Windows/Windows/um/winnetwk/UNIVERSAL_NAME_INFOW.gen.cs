// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnetwk.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='UNIVERSAL_NAME_INFOW.xml' path='doc/member[@name="UNIVERSAL_NAME_INFOW"]/*'/>
public unsafe partial struct UNIVERSAL_NAME_INFOW
{
    /// <include file='UNIVERSAL_NAME_INFOW.xml' path='doc/member[@name="UNIVERSAL_NAME_INFOW.lpUniversalName"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* lpUniversalName;
}