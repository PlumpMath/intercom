#include "stdafx.h"
#include "CppUnitTest.h"
#include "MathLib.h"

using namespace Microsoft::VisualStudio::CppUnitTestFramework;

namespace MathLibTest
{
    TEST_CLASS(TestSub)
    {
    public:
        BEGIN_TEST_METHOD_ATTRIBUTE(TestSub1)
            TEST_METHOD_ATTRIBUTE(L"Category", L"MathLib")
            TEST_METHOD_ATTRIBUTE(L"Category", L"Sub")
        END_TEST_METHOD_ATTRIBUTE()
        TEST_METHOD(TestSub1)
        {
            double d = Math::Sub(-5, 10);
            Assert::AreEqual(-15.0, d);
        }

        BEGIN_TEST_METHOD_ATTRIBUTE(TestSub2)
            TEST_METHOD_ATTRIBUTE(L"Category", L"MathLib")
            TEST_METHOD_ATTRIBUTE(L"Category", L"Sub")
        END_TEST_METHOD_ATTRIBUTE()
        TEST_METHOD(TestSub2)
        {
            double d = Math::Sub(0.0, 0.0);
            Assert::AreEqual(0.0, d);
        }

        BEGIN_TEST_METHOD_ATTRIBUTE(TestSub3)
            TEST_METHOD_ATTRIBUTE(L"Category", L"MathLib")
            TEST_METHOD_ATTRIBUTE(L"Category", L"Sub")
        END_TEST_METHOD_ATTRIBUTE()
        TEST_METHOD(TestSub3)
        {
            double d = Math::Sub(-1.0, 1.0);
            Assert::AreEqual(-2.0, d);
        }

        BEGIN_TEST_METHOD_ATTRIBUTE(TestSub4)
            TEST_METHOD_ATTRIBUTE(L"Category", L"MathLib")
            TEST_METHOD_ATTRIBUTE(L"Category", L"Sub")
        END_TEST_METHOD_ATTRIBUTE()
        TEST_METHOD(TestSub4)
        {
            double d = Math::Sub(1.0, -1.0);
            Assert::AreEqual(2.0, d);
        }
    };
}