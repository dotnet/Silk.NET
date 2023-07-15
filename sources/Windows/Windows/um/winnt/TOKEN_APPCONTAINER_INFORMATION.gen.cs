// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;
/// <include file='TOKEN_APPCONTAINER_INFORMATION.xml' path='doc/member[@name="TOKEN_APPCONTAINER_INFORMATION"]/*'/>
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct TOKEN_APPCONTAINER_INFORMATION
{
    /// <include file='TOKEN_APPCONTAINER_INFORMATION.xml' path='doc/member[@name="TOKEN_APPCONTAINER_INFORMATION.TokenAppContainer"]/*'/>
    [NativeTypeName("PSID")]
    public void* TokenAppContainer;
}