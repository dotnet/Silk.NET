// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

/// <include file='IMAGE_EPILOGUE_DYNAMIC_RELOCATION_HEADER.xml' path='doc/member[@name="IMAGE_EPILOGUE_DYNAMIC_RELOCATION_HEADER"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct IMAGE_EPILOGUE_DYNAMIC_RELOCATION_HEADER
{
    /// <include file='IMAGE_EPILOGUE_DYNAMIC_RELOCATION_HEADER.xml' path='doc/member[@name="IMAGE_EPILOGUE_DYNAMIC_RELOCATION_HEADER.EpilogueCount"]/*' />
    [NativeTypeName("DWORD")]
    public uint EpilogueCount;

    /// <include file='IMAGE_EPILOGUE_DYNAMIC_RELOCATION_HEADER.xml' path='doc/member[@name="IMAGE_EPILOGUE_DYNAMIC_RELOCATION_HEADER.EpilogueByteCount"]/*' />
    public byte EpilogueByteCount;

    /// <include file='IMAGE_EPILOGUE_DYNAMIC_RELOCATION_HEADER.xml' path='doc/member[@name="IMAGE_EPILOGUE_DYNAMIC_RELOCATION_HEADER.BranchDescriptorElementSize"]/*' />
    public byte BranchDescriptorElementSize;

    /// <include file='IMAGE_EPILOGUE_DYNAMIC_RELOCATION_HEADER.xml' path='doc/member[@name="IMAGE_EPILOGUE_DYNAMIC_RELOCATION_HEADER.BranchDescriptorCount"]/*' />
    [NativeTypeName("WORD")]
    public ushort BranchDescriptorCount;
}
