// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='HEAP_INFORMATION_CLASS.xml' path='doc/member[@name="HEAP_INFORMATION_CLASS"]/*'/>
public enum HEAP_INFORMATION_CLASS
{
    /// <include file='HEAP_INFORMATION_CLASS.xml' path='doc/member[@name="HEAP_INFORMATION_CLASS.HeapCompatibilityInformation"]/*'/>
    HeapCompatibilityInformation = 0,
    /// <include file='HEAP_INFORMATION_CLASS.xml' path='doc/member[@name="HEAP_INFORMATION_CLASS.HeapEnableTerminationOnCorruption"]/*'/>
    HeapEnableTerminationOnCorruption = 1,
    /// <include file='HEAP_INFORMATION_CLASS.xml' path='doc/member[@name="HEAP_INFORMATION_CLASS.HeapOptimizeResources"]/*'/>
    HeapOptimizeResources = 3,
    /// <include file='HEAP_INFORMATION_CLASS.xml' path='doc/member[@name="HEAP_INFORMATION_CLASS.HeapTag"]/*'/>
    HeapTag = 7,
}