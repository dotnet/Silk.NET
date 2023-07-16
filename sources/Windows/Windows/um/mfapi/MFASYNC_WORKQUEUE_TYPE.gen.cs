// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='MFASYNC_WORKQUEUE_TYPE.xml' path='doc/member[@name="MFASYNC_WORKQUEUE_TYPE"]/*'/>
public enum MFASYNC_WORKQUEUE_TYPE
{
    /// <include file='MFASYNC_WORKQUEUE_TYPE.xml' path='doc/member[@name="MFASYNC_WORKQUEUE_TYPE.MF_STANDARD_WORKQUEUE"]/*'/>
    MF_STANDARD_WORKQUEUE = 0,
    /// <include file='MFASYNC_WORKQUEUE_TYPE.xml' path='doc/member[@name="MFASYNC_WORKQUEUE_TYPE.MF_WINDOW_WORKQUEUE"]/*'/>
    MF_WINDOW_WORKQUEUE = 1,
    /// <include file='MFASYNC_WORKQUEUE_TYPE.xml' path='doc/member[@name="MFASYNC_WORKQUEUE_TYPE.MF_MULTITHREADED_WORKQUEUE"]/*'/>
    MF_MULTITHREADED_WORKQUEUE = 2,
}