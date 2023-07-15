// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='SPINTERFERENCE.xml' path='doc/member[@name="SPINTERFERENCE"]/*'/>
public enum SPINTERFERENCE
{
    /// <include file='SPINTERFERENCE.xml' path='doc/member[@name="SPINTERFERENCE.SPINTERFERENCE_NONE"]/*'/>
    SPINTERFERENCE_NONE = 0,
    /// <include file='SPINTERFERENCE.xml' path='doc/member[@name="SPINTERFERENCE.SPINTERFERENCE_NOISE"]/*'/>
    SPINTERFERENCE_NOISE = (SPINTERFERENCE_NONE + 1),
    /// <include file='SPINTERFERENCE.xml' path='doc/member[@name="SPINTERFERENCE.SPINTERFERENCE_NOSIGNAL"]/*'/>
    SPINTERFERENCE_NOSIGNAL = (SPINTERFERENCE_NOISE + 1),
    /// <include file='SPINTERFERENCE.xml' path='doc/member[@name="SPINTERFERENCE.SPINTERFERENCE_TOOLOUD"]/*'/>
    SPINTERFERENCE_TOOLOUD = (SPINTERFERENCE_NOSIGNAL + 1),
    /// <include file='SPINTERFERENCE.xml' path='doc/member[@name="SPINTERFERENCE.SPINTERFERENCE_TOOQUIET"]/*'/>
    SPINTERFERENCE_TOOQUIET = (SPINTERFERENCE_TOOLOUD + 1),
    /// <include file='SPINTERFERENCE.xml' path='doc/member[@name="SPINTERFERENCE.SPINTERFERENCE_TOOFAST"]/*'/>
    SPINTERFERENCE_TOOFAST = (SPINTERFERENCE_TOOQUIET + 1),
    /// <include file='SPINTERFERENCE.xml' path='doc/member[@name="SPINTERFERENCE.SPINTERFERENCE_TOOSLOW"]/*'/>
    SPINTERFERENCE_TOOSLOW = (SPINTERFERENCE_TOOFAST + 1),
    /// <include file='SPINTERFERENCE.xml' path='doc/member[@name="SPINTERFERENCE.SPINTERFERENCE_LATENCY_WARNING"]/*'/>
    SPINTERFERENCE_LATENCY_WARNING = (SPINTERFERENCE_TOOSLOW + 1),
    /// <include file='SPINTERFERENCE.xml' path='doc/member[@name="SPINTERFERENCE.SPINTERFERENCE_LATENCY_TRUNCATE_BEGIN"]/*'/>
    SPINTERFERENCE_LATENCY_TRUNCATE_BEGIN = (SPINTERFERENCE_LATENCY_WARNING + 1),
    /// <include file='SPINTERFERENCE.xml' path='doc/member[@name="SPINTERFERENCE.SPINTERFERENCE_LATENCY_TRUNCATE_END"]/*'/>
    SPINTERFERENCE_LATENCY_TRUNCATE_END = (SPINTERFERENCE_LATENCY_TRUNCATE_BEGIN + 1),
}