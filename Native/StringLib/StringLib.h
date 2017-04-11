#include <comutil.h>

#ifdef STRINGLIB_EXPORTS
#define STRINGLIB_API __declspec(dllexport)
#else
#define STRINGLIB_API __declspec(dllimport)
#endif

#define EXTERN_API extern "C"

EXTERN_API STRINGLIB_API int getStringLength(wchar_t* pszData);
EXTERN_API STRINGLIB_API int getWhiteSpaceCount(wchar_t* pszData);
EXTERN_API STRINGLIB_API void removeSpaces(wchar_t* pszData);
EXTERN_API STRINGLIB_API void trim(wchar_t* pszData);
EXTERN_API STRINGLIB_API void trimLeft(wchar_t* pszData);
EXTERN_API STRINGLIB_API void trimRight(wchar_t* pszData);

EXTERN_API STRINGLIB_API BSTR getVersionInfo();