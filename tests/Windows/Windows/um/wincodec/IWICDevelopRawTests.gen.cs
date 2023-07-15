// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IWICDevelopRaw"/> struct.</summary>
public static unsafe partial class IWICDevelopRawTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IWICDevelopRaw"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IWICDevelopRaw).GUID, Is.EqualTo(IID_IWICDevelopRaw));
    }

    /// <summary>Validates that the <see cref = "IWICDevelopRaw"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IWICDevelopRaw>(), Is.EqualTo(sizeof(IWICDevelopRaw)));
    }

    /// <summary>Validates that the <see cref = "IWICDevelopRaw"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IWICDevelopRaw).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IWICDevelopRaw"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IWICDevelopRaw), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IWICDevelopRaw), Is.EqualTo(4));
        }
    }
}