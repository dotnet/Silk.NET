// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='WS_STRING.xml' path='doc/member[@name="WS_STRING"]/*'/>
public unsafe partial struct WS_STRING
{
    /// <include file='WS_STRING.xml' path='doc/member[@name="WS_STRING.length"]/*'/>
    [NativeTypeName("ULONG")]
    public uint length;
    /// <include file='WS_STRING.xml' path='doc/member[@name="WS_STRING.chars"]/*'/>
    [NativeTypeName("WCHAR *")]
    public ushort* chars;
}