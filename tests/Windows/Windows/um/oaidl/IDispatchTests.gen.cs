// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/oaidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IDispatch"/> struct.</summary>
public static unsafe partial class IDispatchTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IDispatch"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IDispatch).GUID, Is.EqualTo(IID_IDispatch));
    }

    /// <summary>Validates that the <see cref = "IDispatch"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IDispatch>(), Is.EqualTo(sizeof(IDispatch)));
    }

    /// <summary>Validates that the <see cref = "IDispatch"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IDispatch).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IDispatch"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IDispatch), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IDispatch), Is.EqualTo(4));
        }
    }
}