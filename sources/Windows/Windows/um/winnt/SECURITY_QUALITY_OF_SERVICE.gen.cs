// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='SECURITY_QUALITY_OF_SERVICE.xml' path='doc/member[@name="SECURITY_QUALITY_OF_SERVICE"]/*'/>
public partial struct SECURITY_QUALITY_OF_SERVICE
{
    /// <include file='SECURITY_QUALITY_OF_SERVICE.xml' path='doc/member[@name="SECURITY_QUALITY_OF_SERVICE.Length"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Length;
    /// <include file='SECURITY_QUALITY_OF_SERVICE.xml' path='doc/member[@name="SECURITY_QUALITY_OF_SERVICE.ImpersonationLevel"]/*'/>
    public SECURITY_IMPERSONATION_LEVEL ImpersonationLevel;
    /// <include file='SECURITY_QUALITY_OF_SERVICE.xml' path='doc/member[@name="SECURITY_QUALITY_OF_SERVICE.ContextTrackingMode"]/*'/>
    [NativeTypeName("SECURITY_CONTEXT_TRACKING_MODE")]
    public byte ContextTrackingMode;
    /// <include file='SECURITY_QUALITY_OF_SERVICE.xml' path='doc/member[@name="SECURITY_QUALITY_OF_SERVICE.EffectiveOnly"]/*'/>
    [NativeTypeName("BOOLEAN")]
    public byte EffectiveOnly;
}