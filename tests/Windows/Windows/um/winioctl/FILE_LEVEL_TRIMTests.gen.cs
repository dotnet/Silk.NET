// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "FILE_LEVEL_TRIM"/> struct.</summary>
[SupportedOSPlatform("windows6.2")]
public static unsafe partial class FILE_LEVEL_TRIMTests
{
    /// <summary>Validates that the <see cref = "FILE_LEVEL_TRIM"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<FILE_LEVEL_TRIM>(), Is.EqualTo(sizeof(FILE_LEVEL_TRIM)));
    }

    /// <summary>Validates that the <see cref = "FILE_LEVEL_TRIM"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(FILE_LEVEL_TRIM).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "FILE_LEVEL_TRIM"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(FILE_LEVEL_TRIM), Is.EqualTo(24));
    }
}