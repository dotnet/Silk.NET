// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/propsys.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='PKA_FLAGS.xml' path='doc/member[@name="PKA_FLAGS"]/*'/>
public enum PKA_FLAGS
{
    /// <include file='PKA_FLAGS.xml' path='doc/member[@name="PKA_FLAGS.PKA_SET"]/*'/>
    PKA_SET = 0,
    /// <include file='PKA_FLAGS.xml' path='doc/member[@name="PKA_FLAGS.PKA_APPEND"]/*'/>
    PKA_APPEND = (PKA_SET + 1),
    /// <include file='PKA_FLAGS.xml' path='doc/member[@name="PKA_FLAGS.PKA_DELETE"]/*'/>
    PKA_DELETE = (PKA_APPEND + 1),
}