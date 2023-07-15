// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/tbs.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='TBS_CONTEXT_PARAMS.xml' path='doc/member[@name="TBS_CONTEXT_PARAMS"]/*'/>
public partial struct TBS_CONTEXT_PARAMS
{
    /// <include file='TBS_CONTEXT_PARAMS.xml' path='doc/member[@name="TBS_CONTEXT_PARAMS.version"]/*'/>
    [NativeTypeName("UINT32")]
    public uint version;
}