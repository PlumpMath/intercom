#ifdef MYTHDLL_EXPORTS
#define MYTHDLL_API __declspec(dllexport)
#else
#define MYTHDLL_API __declspec(dllimport)
#endif

#define EXTERN_API extern "C"

namespace MathLib
{
    EXTERN_API MYTHDLL_API double Add(double a, double b);
    EXTERN_API MYTHDLL_API double Sub(double a, double b);
    EXTERN_API MYTHDLL_API double Mul(double a, double b);
    EXTERN_API MYTHDLL_API double Div(double a, double b);
}