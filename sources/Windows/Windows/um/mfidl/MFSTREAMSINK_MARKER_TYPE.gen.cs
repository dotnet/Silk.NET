// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='MFSTREAMSINK_MARKER_TYPE.xml' path='doc/member[@name="MFSTREAMSINK_MARKER_TYPE"]/*'/>
public enum MFSTREAMSINK_MARKER_TYPE
{
    /// <include file='MFSTREAMSINK_MARKER_TYPE.xml' path='doc/member[@name="MFSTREAMSINK_MARKER_TYPE.MFSTREAMSINK_MARKER_DEFAULT"]/*'/>
    MFSTREAMSINK_MARKER_DEFAULT = 0,
    /// <include file='MFSTREAMSINK_MARKER_TYPE.xml' path='doc/member[@name="MFSTREAMSINK_MARKER_TYPE.MFSTREAMSINK_MARKER_ENDOFSEGMENT"]/*'/>
    MFSTREAMSINK_MARKER_ENDOFSEGMENT = (MFSTREAMSINK_MARKER_DEFAULT + 1),
    /// <include file='MFSTREAMSINK_MARKER_TYPE.xml' path='doc/member[@name="MFSTREAMSINK_MARKER_TYPE.MFSTREAMSINK_MARKER_TICK"]/*'/>
    MFSTREAMSINK_MARKER_TICK = (MFSTREAMSINK_MARKER_ENDOFSEGMENT + 1),
    /// <include file='MFSTREAMSINK_MARKER_TYPE.xml' path='doc/member[@name="MFSTREAMSINK_MARKER_TYPE.MFSTREAMSINK_MARKER_EVENT"]/*'/>
    MFSTREAMSINK_MARKER_EVENT = (MFSTREAMSINK_MARKER_TICK + 1),
}