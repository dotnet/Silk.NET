// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "CREATE_DISK_GPT"/> struct.</summary>
public static unsafe partial class CREATE_DISK_GPTTests
{
    /// <summary>Validates that the <see cref = "CREATE_DISK_GPT"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<CREATE_DISK_GPT>(), Is.EqualTo(sizeof(CREATE_DISK_GPT)));
    }

    /// <summary>Validates that the <see cref = "CREATE_DISK_GPT"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(CREATE_DISK_GPT).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "CREATE_DISK_GPT"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(CREATE_DISK_GPT), Is.EqualTo(20));
    }
}