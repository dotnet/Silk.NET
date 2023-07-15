// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='HIBERFILE_BUCKET_SIZE.xml' path='doc/member[@name="HIBERFILE_BUCKET_SIZE"]/*'/>
public enum HIBERFILE_BUCKET_SIZE
{
    /// <include file='HIBERFILE_BUCKET_SIZE.xml' path='doc/member[@name="HIBERFILE_BUCKET_SIZE.HiberFileBucket1GB"]/*'/>
    HiberFileBucket1GB = 0,
    /// <include file='HIBERFILE_BUCKET_SIZE.xml' path='doc/member[@name="HIBERFILE_BUCKET_SIZE.HiberFileBucket2GB"]/*'/>
    HiberFileBucket2GB,
    /// <include file='HIBERFILE_BUCKET_SIZE.xml' path='doc/member[@name="HIBERFILE_BUCKET_SIZE.HiberFileBucket4GB"]/*'/>
    HiberFileBucket4GB,
    /// <include file='HIBERFILE_BUCKET_SIZE.xml' path='doc/member[@name="HIBERFILE_BUCKET_SIZE.HiberFileBucket8GB"]/*'/>
    HiberFileBucket8GB,
    /// <include file='HIBERFILE_BUCKET_SIZE.xml' path='doc/member[@name="HIBERFILE_BUCKET_SIZE.HiberFileBucket16GB"]/*'/>
    HiberFileBucket16GB,
    /// <include file='HIBERFILE_BUCKET_SIZE.xml' path='doc/member[@name="HIBERFILE_BUCKET_SIZE.HiberFileBucket32GB"]/*'/>
    HiberFileBucket32GB,
    /// <include file='HIBERFILE_BUCKET_SIZE.xml' path='doc/member[@name="HIBERFILE_BUCKET_SIZE.HiberFileBucketUnlimited"]/*'/>
    HiberFileBucketUnlimited,
    /// <include file='HIBERFILE_BUCKET_SIZE.xml' path='doc/member[@name="HIBERFILE_BUCKET_SIZE.HiberFileBucketMax"]/*'/>
    HiberFileBucketMax,
}