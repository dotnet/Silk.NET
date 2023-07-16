// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/IntShCut.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='IURL_INVOKECOMMAND_FLAGS.xml' path='doc/member[@name="IURL_INVOKECOMMAND_FLAGS"]/*'/>
public enum IURL_INVOKECOMMAND_FLAGS
{
    /// <include file='IURL_INVOKECOMMAND_FLAGS.xml' path='doc/member[@name="IURL_INVOKECOMMAND_FLAGS.IURL_INVOKECOMMAND_FL_ALLOW_UI"]/*'/>
    IURL_INVOKECOMMAND_FL_ALLOW_UI = 0x0001,
    /// <include file='IURL_INVOKECOMMAND_FLAGS.xml' path='doc/member[@name="IURL_INVOKECOMMAND_FLAGS.IURL_INVOKECOMMAND_FL_USE_DEFAULT_VERB"]/*'/>
    IURL_INVOKECOMMAND_FL_USE_DEFAULT_VERB = 0x0002,
    /// <include file='IURL_INVOKECOMMAND_FLAGS.xml' path='doc/member[@name="IURL_INVOKECOMMAND_FLAGS.IURL_INVOKECOMMAND_FL_DDEWAIT"]/*'/>
    IURL_INVOKECOMMAND_FL_DDEWAIT = 0x0004,
    /// <include file='IURL_INVOKECOMMAND_FLAGS.xml' path='doc/member[@name="IURL_INVOKECOMMAND_FLAGS.IURL_INVOKECOMMAND_FL_ASYNCOK"]/*'/>
    IURL_INVOKECOMMAND_FL_ASYNCOK = 0x0008,
    /// <include file='IURL_INVOKECOMMAND_FLAGS.xml' path='doc/member[@name="IURL_INVOKECOMMAND_FLAGS.IURL_INVOKECOMMAND_FL_LOG_USAGE"]/*'/>
    IURL_INVOKECOMMAND_FL_LOG_USAGE = 0x0010,
}