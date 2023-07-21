// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/gdiplusenums.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Gdiplus;

/// <include file='GpFlushIntention.xml' path='doc/member[@name="GpFlushIntention"]/*' />
public enum GpFlushIntention
{
    /// <include file='GpFlushIntention.xml' path='doc/member[@name="GpFlushIntention.FlushIntentionFlush"]/*' />
    FlushIntentionFlush = 0,

    /// <include file='GpFlushIntention.xml' path='doc/member[@name="GpFlushIntention.FlushIntentionSync"]/*' />
    FlushIntentionSync = 1,
}
