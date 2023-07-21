// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/objidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='FLAG_STGMEDIUM.xml' path='doc/member[@name="FLAG_STGMEDIUM"]/*' />
public partial struct FLAG_STGMEDIUM
{
    /// <include file='FLAG_STGMEDIUM.xml' path='doc/member[@name="FLAG_STGMEDIUM.ContextFlags"]/*' />
    [NativeTypeName("LONG")]
    public int ContextFlags;

    /// <include file='FLAG_STGMEDIUM.xml' path='doc/member[@name="FLAG_STGMEDIUM.fPassOwnership"]/*' />
    [NativeTypeName("LONG")]
    public int fPassOwnership;

    /// <include file='FLAG_STGMEDIUM.xml' path='doc/member[@name="FLAG_STGMEDIUM.Stgmed"]/*' />
    public STGMEDIUM Stgmed;
}
