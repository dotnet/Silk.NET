// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winternl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='CLIENT_ID.xml' path='doc/member[@name="CLIENT_ID"]/*'/>
public partial struct CLIENT_ID
{
    /// <include file='CLIENT_ID.xml' path='doc/member[@name="CLIENT_ID.UniqueProcess"]/*'/>
    public HANDLE UniqueProcess;
    /// <include file='CLIENT_ID.xml' path='doc/member[@name="CLIENT_ID.UniqueThread"]/*'/>
    public HANDLE UniqueThread;
}