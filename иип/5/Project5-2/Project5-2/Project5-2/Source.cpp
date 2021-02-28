//#define _CRT_SECURE_NO_WARNINGS;
#include<cctype>
#include <iostream>
#include <string.h>

using namespace std;

int main()
{
    errno_t pfile;
    FILE* p_file;
    pfile = fopen_s(&p_file, "txt.txt", "r");
    char str[256];
    char cset[] = "1234567890";
    while (!feof(p_file))
    {
        fgets(str, 256, p_file);
        char* pch = str;
        while (!isdigit(*pch))
            pch++;
        int i = strspn(pch, cset);
        if (i == 2) puts(str);
    }

    system("PAUSE");
    return EXIT_SUCCESS;
}