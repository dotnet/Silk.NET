// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace TerraFX.Interop.Windows;
/// <include file='NETWORK_APP_INSTANCE_EA.xml' path='doc/member[@name="NETWORK_APP_INSTANCE_EA"]/*'/>
public partial struct NETWORK_APP_INSTANCE_EA
{
    /// <include file='NETWORK_APP_INSTANCE_EA.xml' path='doc/member[@name="NETWORK_APP_INSTANCE_EA.AppInstanceID"]/*'/>
    public Guid AppInstanceID;
    /// <include file='NETWORK_APP_INSTANCE_EA.xml' path='doc/member[@name="NETWORK_APP_INSTANCE_EA.CsvFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint CsvFlags;
}