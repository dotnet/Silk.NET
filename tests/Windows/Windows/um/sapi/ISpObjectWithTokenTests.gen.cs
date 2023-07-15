// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "ISpObjectWithToken"/> struct.</summary>
public static unsafe partial class ISpObjectWithTokenTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "ISpObjectWithToken"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(ISpObjectWithToken).GUID, Is.EqualTo(IID_ISpObjectWithToken));
    }

    /// <summary>Validates that the <see cref = "ISpObjectWithToken"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ISpObjectWithToken>(), Is.EqualTo(sizeof(ISpObjectWithToken)));
    }

    /// <summary>Validates that the <see cref = "ISpObjectWithToken"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ISpObjectWithToken).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ISpObjectWithToken"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ISpObjectWithToken), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(ISpObjectWithToken), Is.EqualTo(4));
        }
    }
}