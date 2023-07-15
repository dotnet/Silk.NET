// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ctffunc.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "ITfFnConfigureRegisterEudc"/> struct.</summary>
public static unsafe partial class ITfFnConfigureRegisterEudcTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "ITfFnConfigureRegisterEudc"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(ITfFnConfigureRegisterEudc).GUID, Is.EqualTo(IID_ITfFnConfigureRegisterEudc));
    }

    /// <summary>Validates that the <see cref = "ITfFnConfigureRegisterEudc"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ITfFnConfigureRegisterEudc>(), Is.EqualTo(sizeof(ITfFnConfigureRegisterEudc)));
    }

    /// <summary>Validates that the <see cref = "ITfFnConfigureRegisterEudc"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ITfFnConfigureRegisterEudc).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ITfFnConfigureRegisterEudc"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ITfFnConfigureRegisterEudc), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(ITfFnConfigureRegisterEudc), Is.EqualTo(4));
        }
    }
}