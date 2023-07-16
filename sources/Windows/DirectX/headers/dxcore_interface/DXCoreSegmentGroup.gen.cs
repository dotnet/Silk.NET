// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from dxcore_interface.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.Versioning;

namespace Silk.NET.DirectX;
/// <include file='DXCoreSegmentGroup.xml' path='doc/member[@name="DXCoreSegmentGroup"]/*'/>
[NativeTypeName("uint32_t")]
[SupportedOSPlatform("windows10.0.19041.0")]
public enum DXCoreSegmentGroup : uint
{
    /// <include file='DXCoreSegmentGroup.xml' path='doc/member[@name="DXCoreSegmentGroup.Local"]/*'/>
    Local = 0,
    /// <include file='DXCoreSegmentGroup.xml' path='doc/member[@name="DXCoreSegmentGroup.NonLocal"]/*'/>
    NonLocal = 1,
}