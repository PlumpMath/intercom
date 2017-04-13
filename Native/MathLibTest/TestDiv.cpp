#include "stdafx.h"
#include "CppUnitTest.h"
#include "MathLib.h"

using namespace Microsoft::VisualStudio::CppUnitTestFramework;

namespace MathLibTest
{
    TEST_CLASS(TestDiv)
    {
    public:

        BEGIN_TEST_METHOD_ATTRIBUTE(TestDiv1)
            TEST_METHOD_ATTRIBUTE(L"Category", L"MathLib")
            TEST_METHOD_ATTRIBUTE(L"Category", L"Mul")
        END_TEST_METHOD_ATTRIBUTE()
        TEST_METHOD(TestDiv1)
        {
            double d = Math::Div(0.0, 5);
            Assert::AreEqual(0.0, d);
        }

        BEGIN_TEST_METHOD_ATTRIBUTE(TestDiv2)
            TEST_METHOD_ATTRIBUTE(L"Category", L"MathLib")
            TEST_METHOD_ATTRIBUTE(L"Category", L"Mul")
        END_TEST_METHOD_ATTRIBUTE()
        TEST_METHOD(TestDiv2)
        {
            double d = Math::Div(10.0, 2.0);
            Assert::AreEqual(5.0, d);
        }

        BEGIN_TEST_METHOD_ATTRIBUTE(TestDiv3)
            TEST_METHOD_ATTRIBUTE(L"Category", L"MathLib")
            TEST_METHOD_ATTRIBUTE(L"Category", L"Mul")
        END_TEST_METHOD_ATTRIBUTE()
        TEST_METHOD(TestDiv3)
        {
            double d = Math::Div(-10.0, 2.0);
            Assert::AreEqual(-5.0, d);
        }

        BEGIN_TEST_METHOD_ATTRIBUTE(TestDiv4)
            TEST_METHOD_ATTRIBUTE(L"Category", L"MathLib")
            TEST_METHOD_ATTRIBUTE(L"Category", L"Mul")
        END_TEST_METHOD_ATTRIBUTE()
        TEST_METHOD(TestDiv4)
        {
            double d = Math::Div(-10.0, -2.0);
            Assert::AreEqual(5.0, d);
        }

    };
}