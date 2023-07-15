// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "PPM_WMI_PERF_STATES_EX"/> struct.</summary>
public static unsafe partial class PPM_WMI_PERF_STATES_EXTests
{
    /// <summary>Validates that the <see cref = "PPM_WMI_PERF_STATES_EX"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<PPM_WMI_PERF_STATES_EX>(), Is.EqualTo(sizeof(PPM_WMI_PERF_STATES_EX)));
    }

    /// <summary>Validates that the <see cref = "PPM_WMI_PERF_STATES_EX"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(PPM_WMI_PERF_STATES_EX).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "PPM_WMI_PERF_STATES_EX"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(PPM_WMI_PERF_STATES_EX), Is.EqualTo(144));
        }
        else
        {
            Assert.That(sizeof(PPM_WMI_PERF_STATES_EX), Is.EqualTo(136));
        }
    }
}