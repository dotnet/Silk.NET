// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "FILE_ALIGNMENT_INFO"/> struct.</summary>
[SupportedOSPlatform("windows6.2")]
public static unsafe partial class FILE_ALIGNMENT_INFOTests
{
    /// <summary>Validates that the <see cref = "FILE_ALIGNMENT_INFO"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<FILE_ALIGNMENT_INFO>(), Is.EqualTo(sizeof(FILE_ALIGNMENT_INFO)));
    }

    /// <summary>Validates that the <see cref = "FILE_ALIGNMENT_INFO"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(FILE_ALIGNMENT_INFO).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "FILE_ALIGNMENT_INFO"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(FILE_ALIGNMENT_INFO), Is.EqualTo(4));
    }
}