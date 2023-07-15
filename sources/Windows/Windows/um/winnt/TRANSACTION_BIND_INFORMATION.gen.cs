// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='TRANSACTION_BIND_INFORMATION.xml' path='doc/member[@name="TRANSACTION_BIND_INFORMATION"]/*'/>
public partial struct TRANSACTION_BIND_INFORMATION
{
    /// <include file='TRANSACTION_BIND_INFORMATION.xml' path='doc/member[@name="TRANSACTION_BIND_INFORMATION.TmHandle"]/*'/>
    public HANDLE TmHandle;
}