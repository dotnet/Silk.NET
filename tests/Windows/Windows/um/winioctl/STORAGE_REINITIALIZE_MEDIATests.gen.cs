// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "STORAGE_REINITIALIZE_MEDIA"/> struct.</summary>
public static unsafe partial class STORAGE_REINITIALIZE_MEDIATests
{
    /// <summary>Validates that the <see cref = "STORAGE_REINITIALIZE_MEDIA"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<STORAGE_REINITIALIZE_MEDIA>(), Is.EqualTo(sizeof(STORAGE_REINITIALIZE_MEDIA)));
    }

    /// <summary>Validates that the <see cref = "STORAGE_REINITIALIZE_MEDIA"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(STORAGE_REINITIALIZE_MEDIA).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "STORAGE_REINITIALIZE_MEDIA"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(STORAGE_REINITIALIZE_MEDIA), Is.EqualTo(16));
    }
}