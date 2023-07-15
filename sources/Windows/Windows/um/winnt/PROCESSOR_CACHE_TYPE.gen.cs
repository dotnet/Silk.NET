// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='PROCESSOR_CACHE_TYPE.xml' path='doc/member[@name="PROCESSOR_CACHE_TYPE"]/*'/>
public enum PROCESSOR_CACHE_TYPE
{
    /// <include file='PROCESSOR_CACHE_TYPE.xml' path='doc/member[@name="PROCESSOR_CACHE_TYPE.CacheUnified"]/*'/>
    CacheUnified,
    /// <include file='PROCESSOR_CACHE_TYPE.xml' path='doc/member[@name="PROCESSOR_CACHE_TYPE.CacheInstruction"]/*'/>
    CacheInstruction,
    /// <include file='PROCESSOR_CACHE_TYPE.xml' path='doc/member[@name="PROCESSOR_CACHE_TYPE.CacheData"]/*'/>
    CacheData,
    /// <include file='PROCESSOR_CACHE_TYPE.xml' path='doc/member[@name="PROCESSOR_CACHE_TYPE.CacheTrace"]/*'/>
    CacheTrace,
}