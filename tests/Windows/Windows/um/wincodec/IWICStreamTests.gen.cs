// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IWICStream"/> struct.</summary>
public static unsafe partial class IWICStreamTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IWICStream"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IWICStream).GUID, Is.EqualTo(IID_IWICStream));
    }

    /// <summary>Validates that the <see cref = "IWICStream"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IWICStream>(), Is.EqualTo(sizeof(IWICStream)));
    }

    /// <summary>Validates that the <see cref = "IWICStream"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IWICStream).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IWICStream"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IWICStream), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IWICStream), Is.EqualTo(4));
        }
    }
}