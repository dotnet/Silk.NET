// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/gdiplustypes.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace Silk.NET.Gdiplus;

/// <include file='GpPathData.xml' path='doc/member[@name="GpPathData"]/*' />
public unsafe partial struct GpPathData
{
    /// <include file='GpPathData.xml' path='doc/member[@name="GpPathData.Count"]/*' />
    public int Count;

    /// <include file='GpPathData.xml' path='doc/member[@name="GpPathData.Points"]/*' />
    [NativeTypeName("Gdiplus::PointF *")]
    public GpPointF* Points;

    /// <include file='GpPathData.xml' path='doc/member[@name="GpPathData.Types"]/*' />
    public byte* Types;

    public GpPathData()
    {
        Count = 0;
        Points = null;
        Types = null;
    }

    [DllImport("""", EntryPoint = "??0PathData@Gdiplus@@AEAA@AEBV01@@Z", ExactSpelling = true)]
    private static extern GpPathData(GpPathData* pThis, [NativeTypeName("const PathData &")] GpPathData* param0);
}
