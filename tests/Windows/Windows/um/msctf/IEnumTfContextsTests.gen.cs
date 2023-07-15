// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/msctf.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IEnumTfContexts"/> struct.</summary>
public static unsafe partial class IEnumTfContextsTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IEnumTfContexts"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IEnumTfContexts).GUID, Is.EqualTo(IID_IEnumTfContexts));
    }

    /// <summary>Validates that the <see cref = "IEnumTfContexts"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IEnumTfContexts>(), Is.EqualTo(sizeof(IEnumTfContexts)));
    }

    /// <summary>Validates that the <see cref = "IEnumTfContexts"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IEnumTfContexts).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IEnumTfContexts"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IEnumTfContexts), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IEnumTfContexts), Is.EqualTo(4));
        }
    }
}