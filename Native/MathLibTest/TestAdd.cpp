#include "stdafx.h"
#include "CppUnitTest.h"
#include "MathLib.h"

using namespace Microsoft::VisualStudio::CppUnitTestFramework;

namespace MathLibTest
{
    TEST_CLASS(TestAdd)
    {
    public:

        BEGIN_TEST_METHOD_ATTRIBUTE(TestAdd1)
            TEST_METHOD_ATTRIBUTE(L"Category", L"MathLib")
            TEST_METHOD_ATTRIBUTE(L"Category", L"Add")
        END_TEST_METHOD_ATTRIBUTE()
        TEST_METHOD(TestAdd1)
        {
            double d = MathLib::Add(5, 10);
            Assert::AreEqual(15.0, d);
        }

        BEGIN_TEST_METHOD_ATTRIBUTE(TestAdd2)
            TEST_METHOD_ATTRIBUTE(L"Category", L"MathLib")
            TEST_METHOD_ATTRIBUTE(L"Category", L"Add")
        END_TEST_METHOD_ATTRIBUTE()
        TEST_METHOD(TestAdd2)
        {
            double d = MathLib::Add(-5, 10);
            Assert::AreEqual(5.0, d);
        }

        BEGIN_TEST_METHOD_ATTRIBUTE(TestAdd3)
            TEST_METHOD_ATTRIBUTE(L"Category", L"MathLib")
            TEST_METHOD_ATTRIBUTE(L"Category", L"Add")
        END_TEST_METHOD_ATTRIBUTE()
        TEST_METHOD(TestAdd3)
        {
            double d = MathLib::Add(-1.0, 1.0);
            Assert::AreEqual(0.0, d);
        }

        BEGIN_TEST_METHOD_ATTRIBUTE(TestAdd4)
            TEST_METHOD_ATTRIBUTE(L"Category", L"MathLib")
            TEST_METHOD_ATTRIBUTE(L"Category", L"Add")
        END_TEST_METHOD_ATTRIBUTE()
        TEST_METHOD(TestAdd4)
        {
            double d = MathLib::Add(0.0, 0.0);
            Assert::AreEqual(0.0, d);
        }
    };
}