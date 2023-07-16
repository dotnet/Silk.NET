// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "ACTCTX_SECTION_KEYED_DATA_ASSEMBLY_METADATA"/> struct.</summary>
public static unsafe partial class ACTCTX_SECTION_KEYED_DATA_ASSEMBLY_METADATATests
{
    /// <summary>Validates that the <see cref = "ACTCTX_SECTION_KEYED_DATA_ASSEMBLY_METADATA"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ACTCTX_SECTION_KEYED_DATA_ASSEMBLY_METADATA>(), Is.EqualTo(sizeof(ACTCTX_SECTION_KEYED_DATA_ASSEMBLY_METADATA)));
    }

    /// <summary>Validates that the <see cref = "ACTCTX_SECTION_KEYED_DATA_ASSEMBLY_METADATA"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ACTCTX_SECTION_KEYED_DATA_ASSEMBLY_METADATA).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ACTCTX_SECTION_KEYED_DATA_ASSEMBLY_METADATA"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ACTCTX_SECTION_KEYED_DATA_ASSEMBLY_METADATA), Is.EqualTo(40));
        }
        else
        {
            Assert.That(sizeof(ACTCTX_SECTION_KEYED_DATA_ASSEMBLY_METADATA), Is.EqualTo(20));
        }
    }
}