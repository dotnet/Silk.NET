// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='TOKEN_MANDATORY_LABEL.xml' path='doc/member[@name="TOKEN_MANDATORY_LABEL"]/*'/>
public partial struct TOKEN_MANDATORY_LABEL
{
    /// <include file='TOKEN_MANDATORY_LABEL.xml' path='doc/member[@name="TOKEN_MANDATORY_LABEL.Label"]/*'/>
    public SID_AND_ATTRIBUTES Label;
}