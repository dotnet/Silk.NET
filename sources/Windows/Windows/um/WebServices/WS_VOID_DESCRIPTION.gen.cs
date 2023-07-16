// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='WS_VOID_DESCRIPTION.xml' path='doc/member[@name="WS_VOID_DESCRIPTION"]/*'/>
public partial struct WS_VOID_DESCRIPTION
{
    /// <include file='WS_VOID_DESCRIPTION.xml' path='doc/member[@name="WS_VOID_DESCRIPTION.size"]/*'/>
    [NativeTypeName("ULONG")]
    public uint size;
}