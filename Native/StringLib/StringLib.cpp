#include "stdafx.h"
#include "StringLib.h"


STRINGLIB_API int getStringLength(wchar_t* pszData)
{
    int iLength = 0;

    if (pszData)
        iLength = wcslen(pszData);

    return iLength;
}

STRINGLIB_API int getWhiteSpaceCount(wchar_t* pszData)
{
    int iCount = 0;

    if (pszData)
    {
        int i = 0;
        while (pszData[i] != NULL)
        {
            if (isspace(pszData[i]))
                iCount++;

            i++;
        }
    }

    return iCount;
}

EXTERN_API STRINGLIB_API void removeSpaces(wchar_t* pszData)
{
    if (pszData)
    {
        int i = 0;
        int j = 0;

        while (pszData[i] != NULL)
        {
            if (!isspace(pszData[i]))
                pszData[j++] = pszData[i];

            i++;
        }
        pszData[j] = NULL;
    }
}

EXTERN_API STRINGLIB_API void trim(wchar_t* pszData)
{
    trimLeft(pszData);
    trimRight(pszData);
}

EXTERN_API STRINGLIB_API void trimLeft(wchar_t* pszData)
{
    if (pszData)
    {
        int i = 0;
        while ((pszData[i] != NULL) && (isspace(pszData[i])))
            i++;

        int j = 0;
        while (pszData[i] != NULL)
        {
            pszData[j++] = pszData[i++];
        }
        pszData[j] = NULL;
    }
}

EXTERN_API STRINGLIB_API void trimRight(wchar_t* pszData)
{
    if (pszData)
    {
        int i = getStringLength(pszData) - 1;

        while ((i >= 0) && (isspace(pszData[i])))
            pszData[i++] = NULL;
    }
}

EXTERN_API STRINGLIB_API BSTR getVersionInfo()
{
    return ::SysAllocString(L"This is a version string 1.0");
}