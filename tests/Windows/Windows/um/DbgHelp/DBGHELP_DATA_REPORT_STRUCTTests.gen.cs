// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/DbgHelp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "DBGHELP_DATA_REPORT_STRUCT"/> struct.</summary>
public static unsafe partial class DBGHELP_DATA_REPORT_STRUCTTests
{
    /// <summary>Validates that the <see cref = "DBGHELP_DATA_REPORT_STRUCT"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<DBGHELP_DATA_REPORT_STRUCT>(), Is.EqualTo(sizeof(DBGHELP_DATA_REPORT_STRUCT)));
    }

    /// <summary>Validates that the <see cref = "DBGHELP_DATA_REPORT_STRUCT"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DBGHELP_DATA_REPORT_STRUCT).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DBGHELP_DATA_REPORT_STRUCT"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(DBGHELP_DATA_REPORT_STRUCT), Is.EqualTo(16));
        }
        else
        {
            Assert.That(sizeof(DBGHELP_DATA_REPORT_STRUCT), Is.EqualTo(8));
        }
    }
}