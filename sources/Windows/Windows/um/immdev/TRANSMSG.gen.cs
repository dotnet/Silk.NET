// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/immdev.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='TRANSMSG.xml' path='doc/member[@name="TRANSMSG"]/*'/>
public partial struct TRANSMSG
{
    /// <include file='TRANSMSG.xml' path='doc/member[@name="TRANSMSG.message"]/*'/>
    public uint message;
    /// <include file='TRANSMSG.xml' path='doc/member[@name="TRANSMSG.wParam"]/*'/>
    public WPARAM wParam;
    /// <include file='TRANSMSG.xml' path='doc/member[@name="TRANSMSG.lParam"]/*'/>
    public LPARAM lParam;
}