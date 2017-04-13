#include "stdafx.h"
#include "CppUnitTest.h"
#include "MathLib.h"

using namespace Microsoft::VisualStudio::CppUnitTestFramework;

namespace MathLibTest
{
    TEST_CLASS(TestMul)
    {
    public:

        BEGIN_TEST_METHOD_ATTRIBUTE(TestMul1)
            TEST_METHOD_ATTRIBUTE(L"Category", L"MathLib")
            TEST_METHOD_ATTRIBUTE(L"Category", L"Mul")
        END_TEST_METHOD_ATTRIBUTE()
        TEST_METHOD(TestMul1)
        {
            double d = Math::Mul(0, 10);
            Assert::AreEqual(0.0, d);
        }

        BEGIN_TEST_METHOD_ATTRIBUTE(TestMul2)
            TEST_METHOD_ATTRIBUTE(L"Category", L"MathLib")
            TEST_METHOD_ATTRIBUTE(L"Category", L"Mul")
        END_TEST_METHOD_ATTRIBUTE()
        TEST_METHOD(TestMul2)
        {
            double d = Math::Mul(10, 0);
            Assert::AreEqual(0.0, d);
        }

        BEGIN_TEST_METHOD_ATTRIBUTE(TestMul3)
            TEST_METHOD_ATTRIBUTE(L"Category", L"MathLib")
            TEST_METHOD_ATTRIBUTE(L"Category", L"Mul")
        END_TEST_METHOD_ATTRIBUTE()
        TEST_METHOD(TestMul3)
        {
            double d = Math::Mul(-5, -2);
            Assert::AreEqual(10.0, d);
        }
    };
}