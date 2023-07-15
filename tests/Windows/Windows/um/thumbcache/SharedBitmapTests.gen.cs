// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/thumbcache.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "SharedBitmap"/> struct.</summary>
public static unsafe partial class SharedBitmapTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "SharedBitmap"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(SharedBitmap).GUID, Is.EqualTo(IID_SharedBitmap));
    }

    /// <summary>Validates that the <see cref = "SharedBitmap"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SharedBitmap>(), Is.EqualTo(sizeof(SharedBitmap)));
    }

    /// <summary>Validates that the <see cref = "SharedBitmap"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SharedBitmap).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "SharedBitmap"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(SharedBitmap), Is.EqualTo(1));
    }
}