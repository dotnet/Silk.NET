// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/propsys.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='PERSIST_SPROPSTORE_FLAGS.xml' path='doc/member[@name="PERSIST_SPROPSTORE_FLAGS"]/*'/>
public enum PERSIST_SPROPSTORE_FLAGS
{
    /// <include file='PERSIST_SPROPSTORE_FLAGS.xml' path='doc/member[@name="PERSIST_SPROPSTORE_FLAGS.FPSPS_DEFAULT"]/*'/>
    FPSPS_DEFAULT = 0,
    /// <include file='PERSIST_SPROPSTORE_FLAGS.xml' path='doc/member[@name="PERSIST_SPROPSTORE_FLAGS.FPSPS_READONLY"]/*'/>
    FPSPS_READONLY = 0x1,
    /// <include file='PERSIST_SPROPSTORE_FLAGS.xml' path='doc/member[@name="PERSIST_SPROPSTORE_FLAGS.FPSPS_TREAT_NEW_VALUES_AS_DIRTY"]/*'/>
    FPSPS_TREAT_NEW_VALUES_AS_DIRTY = 0x2,
}