#include "stdafx.h"
#include "MathDLL.h"

namespace Math
{
    MYTHDLL_API double Add(double a, double b)
    {
        return a + b;
    }

    MYTHDLL_API double Sub(double a, double b)
    {
        return a - b;
    }

    MYTHDLL_API double Mul(double a, double b)
    {
        return a * b;
    }

    MYTHDLL_API double Div(double a, double b)
    {
        if (b != 0)
            return a / b;

        throw "Division by zero!";
    }
}