// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "CSV_CONTROL_PARAM"/> struct.</summary>
public static unsafe partial class CSV_CONTROL_PARAMTests
{
    /// <summary>Validates that the <see cref = "CSV_CONTROL_PARAM"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<CSV_CONTROL_PARAM>(), Is.EqualTo(sizeof(CSV_CONTROL_PARAM)));
    }

    /// <summary>Validates that the <see cref = "CSV_CONTROL_PARAM"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(CSV_CONTROL_PARAM).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "CSV_CONTROL_PARAM"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(CSV_CONTROL_PARAM), Is.EqualTo(16));
    }
}