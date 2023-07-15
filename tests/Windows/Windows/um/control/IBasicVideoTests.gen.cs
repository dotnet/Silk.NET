// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/control.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IBasicVideo"/> struct.</summary>
public static unsafe partial class IBasicVideoTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IBasicVideo"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IBasicVideo).GUID, Is.EqualTo(IID_IBasicVideo));
    }

    /// <summary>Validates that the <see cref = "IBasicVideo"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IBasicVideo>(), Is.EqualTo(sizeof(IBasicVideo)));
    }

    /// <summary>Validates that the <see cref = "IBasicVideo"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IBasicVideo).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IBasicVideo"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IBasicVideo), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IBasicVideo), Is.EqualTo(4));
        }
    }
}