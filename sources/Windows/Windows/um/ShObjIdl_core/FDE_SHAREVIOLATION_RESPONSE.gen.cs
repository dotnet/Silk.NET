// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='FDE_SHAREVIOLATION_RESPONSE.xml' path='doc/member[@name="FDE_SHAREVIOLATION_RESPONSE"]/*'/>
public enum FDE_SHAREVIOLATION_RESPONSE
{
    /// <include file='FDE_SHAREVIOLATION_RESPONSE.xml' path='doc/member[@name="FDE_SHAREVIOLATION_RESPONSE.FDESVR_DEFAULT"]/*'/>
    FDESVR_DEFAULT = 0,
    /// <include file='FDE_SHAREVIOLATION_RESPONSE.xml' path='doc/member[@name="FDE_SHAREVIOLATION_RESPONSE.FDESVR_ACCEPT"]/*'/>
    FDESVR_ACCEPT = 1,
    /// <include file='FDE_SHAREVIOLATION_RESPONSE.xml' path='doc/member[@name="FDE_SHAREVIOLATION_RESPONSE.FDESVR_REFUSE"]/*'/>
    FDESVR_REFUSE = 2,
}